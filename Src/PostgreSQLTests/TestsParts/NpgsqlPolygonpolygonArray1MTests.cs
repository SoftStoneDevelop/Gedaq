

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8773811770306279d, y: 0.7421408575810408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074257802996466d, y: 0.6301862091744845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8654064228318201d, y: 0.24394520495531669d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7819406058198133d, y: 0.9809188160336796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4289416558915522d, y: 0.7611280422785425d), new NpgsqlTypes.NpgsqlPoint(x: 0.17693561800194624d, y: 0.35458971142050444d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19713306160962674d, y: 0.8707561056374449d), new NpgsqlTypes.NpgsqlPoint(x: 0.1787461965714907d, y: 0.3261964052017988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7324364259952786d, y: 0.9533640862715944d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25488475515154096d, y: 0.6393833220694879d), new NpgsqlTypes.NpgsqlPoint(x: 0.699407547219836d, y: 0.5147114954136269d), new NpgsqlTypes.NpgsqlPoint(x: 0.6366028089515037d, y: 0.29987700264619155d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48219894578991107d, y: 0.21311482252984326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620092468731335d, y: 0.8115922630710184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531410417432543d, y: 0.16579898154884265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9360716123626718d, y: 0.8974992713858062d), new NpgsqlTypes.NpgsqlPoint(x: 0.32425625301633154d, y: 0.20430657086722226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973378133224524d, y: 0.3792595975123686d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6985333308498884d, y: 0.025649330209030152d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795142013361648d, y: 0.19099750140300942d), new NpgsqlTypes.NpgsqlPoint(x: 0.22189158188409286d, y: 0.08502994121299645d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8348142274271343d, y: 0.5503518866437546d), new NpgsqlTypes.NpgsqlPoint(x: 0.17469418495771283d, y: 0.1551827556154296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345464382037181d, y: 0.5617444560159308d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08265122967589611d, y: 0.7045305869133696d), new NpgsqlTypes.NpgsqlPoint(x: 0.36313777732230224d, y: 0.7678959150663504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889742586131036d, y: 0.3704210579735159d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07965313373122207d, y: 0.8437707757074935d), new NpgsqlTypes.NpgsqlPoint(x: 0.615996679052224d, y: 0.5711130596138576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5411268748972496d, y: 0.43844665720413833d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4622763045734799d, y: 0.962026639690029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993904560246606d, y: 0.9117497403399076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364411724066263d, y: 0.9608117818141203d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6257755201121006d, y: 0.6849714270673813d), new NpgsqlTypes.NpgsqlPoint(x: 0.2776171221085302d, y: 0.330192809743324d), new NpgsqlTypes.NpgsqlPoint(x: 0.18134206552183896d, y: 0.397607759145999d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4775845141216414d, y: 0.6716488424355598d), new NpgsqlTypes.NpgsqlPoint(x: 0.02128016689766765d, y: 0.4663982895272678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763749506873646d, y: 0.9343521272863179d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4197034423994771d, y: 0.7657013873863165d), new NpgsqlTypes.NpgsqlPoint(x: 0.19341187965673823d, y: 0.517583931745113d), new NpgsqlTypes.NpgsqlPoint(x: 0.28306169694840755d, y: 0.7468936212183455d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9942895690684826d, y: 0.7860420946499669d), new NpgsqlTypes.NpgsqlPoint(x: 0.715232703532447d, y: 0.868561076790412d), new NpgsqlTypes.NpgsqlPoint(x: 0.42831962468562734d, y: 0.3121233716574012d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28250954786571025d, y: 0.4666687763070346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417595941689875d, y: 0.857313728167424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746558987704585d, y: 0.27602250085675595d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4037678891533585d, y: 0.8425084048527735d), new NpgsqlTypes.NpgsqlPoint(x: 0.25630617392516775d, y: 0.023417266310920448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3044113623400374d, y: 0.11089904322374444d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9303639698531443d, y: 0.6797520747373004d), new NpgsqlTypes.NpgsqlPoint(x: 0.22988753884085245d, y: 0.8245810653199296d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883228356156717d, y: 0.7535859440733758d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25317102056659035d, y: 0.701011891618709d), new NpgsqlTypes.NpgsqlPoint(x: 0.14648754566298172d, y: 0.44235532134222133d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615808512516217d, y: 0.5944520063471054d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9355076257107745d, y: 0.5073299438605915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2279867574065355d, y: 0.8395512883080518d), new NpgsqlTypes.NpgsqlPoint(x: 0.33297338415265454d, y: 0.4979916530134042d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39608442809019606d, y: 0.7077541726821845d), new NpgsqlTypes.NpgsqlPoint(x: 0.1610763159112334d, y: 0.5107996585489949d), new NpgsqlTypes.NpgsqlPoint(x: 0.5519445663369648d, y: 0.7866276082763303d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1585343265662641d, y: 0.4841385405011004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8248604168818149d, y: 0.9897614569594472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7929736900631467d, y: 0.997497601619432d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08252453735391596d, y: 0.034439244577011974d), new NpgsqlTypes.NpgsqlPoint(x: 0.24136291772480012d, y: 0.16031705470552937d), new NpgsqlTypes.NpgsqlPoint(x: 0.973097120693582d, y: 0.6136181473609787d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30462559297892944d, y: 0.8854227519968141d), new NpgsqlTypes.NpgsqlPoint(x: 0.49532771205703685d, y: 0.43045854884455015d), new NpgsqlTypes.NpgsqlPoint(x: 0.960754792096434d, y: 0.3452947759904694d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6548427314312905d, y: 0.384872415448002d), new NpgsqlTypes.NpgsqlPoint(x: 0.33587654150209134d, y: 0.8966324617901108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9034194430463275d, y: 0.675391607498065d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9247971081292155d, y: 0.814490418859492d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614792744459586d, y: 0.9786833760013889d), new NpgsqlTypes.NpgsqlPoint(x: 0.21329961519939977d, y: 0.5886204886019898d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21678643203736536d, y: 0.5262668769664072d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530819662066161d, y: 0.377444000777477d), new NpgsqlTypes.NpgsqlPoint(x: 0.07040611584513135d, y: 0.7086129349395786d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2786210953112511d, y: 0.40290737654033015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899661631851855d, y: 0.7445816056493786d), new NpgsqlTypes.NpgsqlPoint(x: 0.10105357228917777d, y: 0.3368287146744341d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3928922255460898d, y: 0.15039281379697844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9581346036130464d, y: 0.7129324451942037d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060055724726458d, y: 0.23965405629680492d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27196113633888475d, y: 0.8636733899070679d), new NpgsqlTypes.NpgsqlPoint(x: 0.35994722918790834d, y: 0.5706274489280958d), new NpgsqlTypes.NpgsqlPoint(x: 0.13720496668990956d, y: 0.3317859033599546d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7744107104184798d, y: 0.8725625049988517d), new NpgsqlTypes.NpgsqlPoint(x: 0.20487317378598724d, y: 0.14091779698441986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544834064445179d, y: 0.7347478869356959d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5250105062266646d, y: 0.6366504634705755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5483680817535432d, y: 0.7582693073627623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269925109848352d, y: 0.5862366539014421d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43229021177901006d, y: 0.8514052087862635d), new NpgsqlTypes.NpgsqlPoint(x: 0.10966955310836712d, y: 0.3215675182592974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840430063171798d, y: 0.7216291930285842d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8410507021389724d, y: 0.11782418960209284d), new NpgsqlTypes.NpgsqlPoint(x: 0.028973956925137156d, y: 0.1569064960678923d), new NpgsqlTypes.NpgsqlPoint(x: 0.36035419828123516d, y: 0.05594646183085761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7569483949108232d, y: 0.5598691614487178d), new NpgsqlTypes.NpgsqlPoint(x: 0.17309649641809266d, y: 0.5721056028988002d), new NpgsqlTypes.NpgsqlPoint(x: 0.8148835530419327d, y: 0.9438922364582377d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09366839662338833d, y: 0.4169298097457169d), new NpgsqlTypes.NpgsqlPoint(x: 0.14003311846317745d, y: 0.23002139040886949d), new NpgsqlTypes.NpgsqlPoint(x: 0.009066911320157245d, y: 0.5950071592859318d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8794162617179265d, y: 0.4733847252484553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236932657432674d, y: 0.9877225608136887d), new NpgsqlTypes.NpgsqlPoint(x: 0.08316754513526436d, y: 0.7097041616359999d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42243299823424585d, y: 0.2531511059023913d), new NpgsqlTypes.NpgsqlPoint(x: 0.20984726513616203d, y: 0.9895599169580299d), new NpgsqlTypes.NpgsqlPoint(x: 0.04926795249210292d, y: 0.7778858683456744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5093903089294687d, y: 0.690714472038096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162461765087055d, y: 0.5276783399590135d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593012280932387d, y: 0.7948644384562921d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09747222372496966d, y: 0.0769469090547179d), new NpgsqlTypes.NpgsqlPoint(x: 0.22550010329221726d, y: 0.39511370660948086d), new NpgsqlTypes.NpgsqlPoint(x: 0.4513588779391001d, y: 0.688406677637685d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39414913791861317d, y: 0.5265011004599679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408900024614728d, y: 0.21432860367587403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8651168305862261d, y: 0.531453222541202d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9235995947596353d, y: 0.4012805315926383d), new NpgsqlTypes.NpgsqlPoint(x: 0.49747097036612664d, y: 0.8024160577805683d), new NpgsqlTypes.NpgsqlPoint(x: 0.45908853915933556d, y: 0.39592451775093984d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2708511809675813d, y: 0.5934261681303479d), new NpgsqlTypes.NpgsqlPoint(x: 0.14462262617202948d, y: 0.5808724063479797d), new NpgsqlTypes.NpgsqlPoint(x: 0.12993640169180765d, y: 0.9208368042374911d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.531331082575503d, y: 0.30976458660653006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676473892521642d, y: 0.7332556017950091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8740049412581613d, y: 0.23317860106138733d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3041077725752278d, y: 0.48256948470743d), new NpgsqlTypes.NpgsqlPoint(x: 0.34951280485409575d, y: 0.49243276197196006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5461024167129684d, y: 0.29539411984430863d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8747062618634974d, y: 0.033541335763416336d), new NpgsqlTypes.NpgsqlPoint(x: 0.11447813148282615d, y: 0.337048382815046d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738199241761818d, y: 0.5809833203996013d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11222483794826643d, y: 0.9895763065350555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246899431082682d, y: 0.5408688042049146d), new NpgsqlTypes.NpgsqlPoint(x: 0.45178934378107194d, y: 0.9644664162786712d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8938602509286525d, y: 0.9210864617676506d), new NpgsqlTypes.NpgsqlPoint(x: 0.3606983616024193d, y: 0.29501937799855804d), new NpgsqlTypes.NpgsqlPoint(x: 0.9526767119999877d, y: 0.614804891819097d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22401132747273633d, y: 0.40391164167985527d), new NpgsqlTypes.NpgsqlPoint(x: 0.9963700786986107d, y: 0.7596101807699116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600608038045686d, y: 0.8001792799858244d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04370808301893769d, y: 0.8596377963023846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7251552530599189d, y: 0.8112214417298407d), new NpgsqlTypes.NpgsqlPoint(x: 0.22426197079314414d, y: 0.14140252273765264d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4772204599956035d, y: 0.39725428455344247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545217233203837d, y: 0.538702592130271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561822441943135d, y: 0.7076042087461483d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5001821292056418d, y: 0.11887958393672737d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803508593830769d, y: 0.5382732557101352d), new NpgsqlTypes.NpgsqlPoint(x: 0.244183240987352d, y: 0.5014486835077352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870079603633238d, y: 0.6158768274438168d), new NpgsqlTypes.NpgsqlPoint(x: 0.3540734478238161d, y: 0.6060204602754269d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036706843619053d, y: 0.44205829390377716d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9223554321155083d, y: 0.3742422576192489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632921906691554d, y: 0.9997242056981551d), new NpgsqlTypes.NpgsqlPoint(x: 0.684860785984264d, y: 0.29263424557789985d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20240938589555657d, y: 0.11150462240938341d), new NpgsqlTypes.NpgsqlPoint(x: 0.06430469749733947d, y: 0.894993470517706d), new NpgsqlTypes.NpgsqlPoint(x: 0.054060103004473614d, y: 0.7090085905405845d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0736347670186559d, y: 0.18726919991325208d), new NpgsqlTypes.NpgsqlPoint(x: 0.3643672053160827d, y: 0.8123364377882216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6307329595934038d, y: 0.331342571084591d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5961766445191734d, y: 0.43140483382090355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005369350007087d, y: 0.58046238254135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009399082989007d, y: 0.07572381657456717d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3528368676212613d, y: 0.892781848045755d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430387750967765d, y: 0.5221002719038332d), new NpgsqlTypes.NpgsqlPoint(x: 0.8209649631018102d, y: 0.12287226186533251d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41363309820753436d, y: 0.4748273284080994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622094922511964d, y: 0.33227114381413236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420225700540041d, y: 0.22023379723595715d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17505373449594497d, y: 0.8107095091675199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8964167248864207d, y: 0.4575667323653798d), new NpgsqlTypes.NpgsqlPoint(x: 0.568832978537077d, y: 0.874557793911768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125264664735981d, y: 0.22850640349861473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726478477388524d, y: 0.8319230607357901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4446787519844605d, y: 0.3532416017281075d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1712074204352264d, y: 0.2554159178210962d), new NpgsqlTypes.NpgsqlPoint(x: 0.06576762616064946d, y: 0.6094862646148826d), new NpgsqlTypes.NpgsqlPoint(x: 0.011847124150098143d, y: 0.5429501751996931d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8628592667385909d, y: 0.5699809338528822d), new NpgsqlTypes.NpgsqlPoint(x: 0.29735624495061574d, y: 0.6742946376170426d), new NpgsqlTypes.NpgsqlPoint(x: 0.1952568691771126d, y: 0.8637955040377964d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7657687431907976d, y: 0.5465804318015275d), new NpgsqlTypes.NpgsqlPoint(x: 0.019481193919554274d, y: 0.5146032123234265d), new NpgsqlTypes.NpgsqlPoint(x: 0.1419605769928617d, y: 0.774886029496996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6198429844508225d, y: 0.40466790051451984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010095064255596d, y: 0.5008438284859024d), new NpgsqlTypes.NpgsqlPoint(x: 0.053480578555441194d, y: 0.9380218831667179d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38388100902049305d, y: 0.3809660660600531d), new NpgsqlTypes.NpgsqlPoint(x: 0.08196015071977192d, y: 0.8576611195182285d), new NpgsqlTypes.NpgsqlPoint(x: 0.1956525380194868d, y: 0.12555282576865723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3194116867562653d, y: 0.7025654308757989d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529887656657172d, y: 0.8249502896223426d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280614820898203d, y: 0.2566133307689996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5264674040937036d, y: 0.8547488568115098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390714723905127d, y: 0.6089719528257056d), new NpgsqlTypes.NpgsqlPoint(x: 0.624998693942347d, y: 0.8113966700869761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1971858693719415d, y: 0.5412352158834324d), new NpgsqlTypes.NpgsqlPoint(x: 0.11228926500803404d, y: 0.8201318411775448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382201224258182d, y: 0.8258961786088591d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020127203277863437d, y: 0.2950736509449525d), new NpgsqlTypes.NpgsqlPoint(x: 0.22206660446238202d, y: 0.765763848047394d), new NpgsqlTypes.NpgsqlPoint(x: 0.31967819413008536d, y: 0.9490447950812795d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10142020373336469d, y: 0.18082360619952065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540752942575457d, y: 0.6806958617114716d), new NpgsqlTypes.NpgsqlPoint(x: 0.05815864761504708d, y: 0.5606751027529929d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22278661154589652d, y: 0.2495560734917125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4782793951802229d, y: 0.03612458019944931d), new NpgsqlTypes.NpgsqlPoint(x: 0.4013932554310953d, y: 0.45125740427512206d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5805644145007893d, y: 0.3080748885619383d), new NpgsqlTypes.NpgsqlPoint(x: 0.986552868756957d, y: 0.9559610621878991d), new NpgsqlTypes.NpgsqlPoint(x: 0.9929798368833516d, y: 0.21183406978638553d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8546448545976034d, y: 0.14452669776190308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816317415268226d, y: 0.13382751937425608d), new NpgsqlTypes.NpgsqlPoint(x: 0.42794233664346715d, y: 0.4095307086186246d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6096520027016644d, y: 0.9896512605517005d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450798595080964d, y: 0.8466898913280231d), new NpgsqlTypes.NpgsqlPoint(x: 0.812983326046037d, y: 0.9392630164264849d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9748638007529744d, y: 0.8053767938722786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296925229585145d, y: 0.06165515550782885d), new NpgsqlTypes.NpgsqlPoint(x: 0.6965161479194898d, y: 0.8743081713358307d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9312801799562548d, y: 0.7510354673618305d), new NpgsqlTypes.NpgsqlPoint(x: 0.1635164798105041d, y: 0.49503533703814595d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140116833098991d, y: 0.21511645090927745d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24220165882992928d, y: 0.7044216882987689d), new NpgsqlTypes.NpgsqlPoint(x: 0.5725842022311388d, y: 0.6154391627380033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746454320935079d, y: 0.24963527049955792d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6289352116723755d, y: 0.7677568560049371d), new NpgsqlTypes.NpgsqlPoint(x: 0.3851548651144511d, y: 0.3667291383125181d), new NpgsqlTypes.NpgsqlPoint(x: 0.42860923666616524d, y: 0.4730327212589601d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5064527896418582d, y: 0.43393709876047093d), new NpgsqlTypes.NpgsqlPoint(x: 0.09005809789821972d, y: 0.23797863795804786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9312668486851416d, y: 0.021004414585121478d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8202011194127794d, y: 0.4164797048726514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695785293541901d, y: 0.7614908196938386d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302539310736913d, y: 0.1184356980911977d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5739486794424278d, y: 0.7745103287997407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652739640411495d, y: 0.9429452223023987d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530525943708859d, y: 0.614628295193346d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.492462727836643d, y: 0.38357250456573744d), new NpgsqlTypes.NpgsqlPoint(x: 0.013669715858257714d, y: 0.26409665835953144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144397517215276d, y: 0.9150239047475218d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.917303835515796d, y: 0.34190064403402565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972740405877686d, y: 0.41113596089769866d), new NpgsqlTypes.NpgsqlPoint(x: 0.20421863712243604d, y: 0.20827762884500856d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9222440057943231d, y: 0.7674821190398274d), new NpgsqlTypes.NpgsqlPoint(x: 0.4891656406411019d, y: 0.6896363524934307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5890784791821662d, y: 0.09108171361951323d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34905593343358166d, y: 0.8656933672598434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284394031924922d, y: 0.7704369022602123d), new NpgsqlTypes.NpgsqlPoint(x: 0.3064468990771346d, y: 0.5139750453546461d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31211795818069143d, y: 0.8544010393275299d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084075305898552d, y: 0.12416040857462263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9549677133816317d, y: 0.29516000785909535d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10057240379313725d, y: 0.7392916155425953d), new NpgsqlTypes.NpgsqlPoint(x: 0.2969774400635109d, y: 0.4170105858837171d), new NpgsqlTypes.NpgsqlPoint(x: 0.5206935705670072d, y: 0.7377869403462554d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6820496721289977d, y: 0.6270977672243664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943993928918914d, y: 0.323006590273589d), new NpgsqlTypes.NpgsqlPoint(x: 0.39360237830366696d, y: 0.2202887423140817d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19097191868843655d, y: 0.7340038603786234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022108026710092d, y: 0.09328535560087137d), new NpgsqlTypes.NpgsqlPoint(x: 0.4630389877048995d, y: 0.6660367136372913d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8994407088828366d, y: 0.8465954848867325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308682700436191d, y: 0.07182022940714661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063185311238222d, y: 0.9593542501683987d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9809068351610618d, y: 0.04904456700640403d), new NpgsqlTypes.NpgsqlPoint(x: 0.1042537276972082d, y: 0.6169020675470808d), new NpgsqlTypes.NpgsqlPoint(x: 0.021050240111144647d, y: 0.4220345577864777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2509413658490278d, y: 0.3628333154730735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712651760745672d, y: 0.9743508539546034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497423781073205d, y: 0.8183610206834617d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3825450553605627d, y: 0.993697689724661d), new NpgsqlTypes.NpgsqlPoint(x: 0.07454630225439451d, y: 0.6188140865362114d), new NpgsqlTypes.NpgsqlPoint(x: 0.10428886015432481d, y: 0.7907607359444558d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36289791853473174d, y: 0.12924973226919712d), new NpgsqlTypes.NpgsqlPoint(x: 0.20001596470353122d, y: 0.34419318363643703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678914416211411d, y: 0.02176121011050003d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.559616099985773d, y: 0.42483522619654157d), new NpgsqlTypes.NpgsqlPoint(x: 0.42643905537475346d, y: 0.3666744796619472d), new NpgsqlTypes.NpgsqlPoint(x: 0.4534318925691283d, y: 0.01699928394566974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2862349046965944d, y: 0.8100442043096776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4499039628925261d, y: 0.7659290561743932d), new NpgsqlTypes.NpgsqlPoint(x: 0.9444794437187474d, y: 0.8241201447936742d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42106266194417086d, y: 0.5984862839692308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966851196668349d, y: 0.947287084442264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929406704462085d, y: 0.10870588233433909d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9642611487987182d, y: 0.207299237648508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016768839603066d, y: 0.0004344239421173457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622062114086866d, y: 0.7452670121835523d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6611757239364437d, y: 0.05440121953071031d), new NpgsqlTypes.NpgsqlPoint(x: 0.41206587754487456d, y: 0.6695326901821828d), new NpgsqlTypes.NpgsqlPoint(x: 0.4933105967650787d, y: 0.41830727292374037d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030775136766488576d, y: 0.789057740321322d), new NpgsqlTypes.NpgsqlPoint(x: 0.19406632868916374d, y: 0.24434211262954297d), new NpgsqlTypes.NpgsqlPoint(x: 0.4205795453019855d, y: 0.8891641197043806d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1793887953573543d, y: 0.3294532821265439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492724019012587d, y: 0.9736674166517229d), new NpgsqlTypes.NpgsqlPoint(x: 0.8124968118857261d, y: 0.9734796170501728d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21610827100341035d, y: 0.5253964666095912d), new NpgsqlTypes.NpgsqlPoint(x: 0.4116463687519041d, y: 0.29801118632396617d), new NpgsqlTypes.NpgsqlPoint(x: 0.0960670113800477d, y: 0.4613246356394405d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49194433346204236d, y: 0.14028631612147258d), new NpgsqlTypes.NpgsqlPoint(x: 0.3097790301895963d, y: 0.9882745763509674d), new NpgsqlTypes.NpgsqlPoint(x: 0.36533080238088556d, y: 0.8681806549814117d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0944084504542212d, y: 0.47410000416160025d), new NpgsqlTypes.NpgsqlPoint(x: 0.984689504751394d, y: 0.03799619998026971d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102985839603703d, y: 0.29539690636433347d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43310526146796924d, y: 0.957546875088677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357829441874559d, y: 0.2702721401629934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9463483598100335d, y: 0.9572647188628753d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41367329211218207d, y: 0.12918995665943334d), new NpgsqlTypes.NpgsqlPoint(x: 0.24526943959792968d, y: 0.22841395433202916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942852709573194d, y: 0.3806730433034813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2679483480424544d, y: 0.7369001209282632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761366458059606d, y: 0.16423118019276217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7979584757704441d, y: 0.17231558672823555d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7021262063308193d, y: 0.911112303899345d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389438444966238d, y: 0.7233990680909639d), new NpgsqlTypes.NpgsqlPoint(x: 0.988563416681762d, y: 0.7372429331083064d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3391214812155109d, y: 0.9729770807987543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800202509877167d, y: 0.5154507684195049d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826979358402566d, y: 0.1566415741803855d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3749947240000402d, y: 0.5204605868174386d), new NpgsqlTypes.NpgsqlPoint(x: 0.9164299994979913d, y: 0.24351449455312402d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846603778208918d, y: 0.04271861150815082d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5823300184892729d, y: 0.7422271474165114d), new NpgsqlTypes.NpgsqlPoint(x: 0.003732032356492998d, y: 0.5647847962883702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296093863008629d, y: 0.666496017085651d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0966176983485767d, y: 0.395153020091915d), new NpgsqlTypes.NpgsqlPoint(x: 0.91747397640143d, y: 0.9906054154291819d), new NpgsqlTypes.NpgsqlPoint(x: 0.060113862586560596d, y: 0.23444985419683217d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6908799194402919d, y: 0.29154049418040473d), new NpgsqlTypes.NpgsqlPoint(x: 0.006693714818449492d, y: 0.6476181959510661d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668878319029837d, y: 0.8251456038938791d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9459988166793437d, y: 0.09781242532969514d), new NpgsqlTypes.NpgsqlPoint(x: 0.029319583246142367d, y: 0.08427440984983836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4290436505579487d, y: 0.9410676704652208d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.290518911605557d, y: 0.22259083756888054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993433486368025d, y: 0.3981772565624401d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179420036571848d, y: 0.922232077462201d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6111701889965095d, y: 0.34799388702164336d), new NpgsqlTypes.NpgsqlPoint(x: 0.11223116695412849d, y: 0.4574382196441048d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451255159818165d, y: 0.9307476301226681d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3971676765448008d, y: 0.954010580293384d), new NpgsqlTypes.NpgsqlPoint(x: 0.006835190385444667d, y: 0.23076505560985927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765631394523194d, y: 0.21840631301536173d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05775268162211411d, y: 0.5511082939134541d), new NpgsqlTypes.NpgsqlPoint(x: 0.37745904851485124d, y: 0.691872890633519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658357028452028d, y: 0.612483418641053d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4881444853886089d, y: 0.9867120467683629d), new NpgsqlTypes.NpgsqlPoint(x: 0.3384979643970929d, y: 0.9937436184970103d), new NpgsqlTypes.NpgsqlPoint(x: 0.06390115124612772d, y: 0.07306622543802d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3758098424281462d, y: 0.6682841832322493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073313603964273d, y: 0.6370259951694228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835968469656469d, y: 0.3102590214109243d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3186819785468179d, y: 0.12000989775287285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5916926958978476d, y: 0.5321791369507043d), new NpgsqlTypes.NpgsqlPoint(x: 0.11399407262194783d, y: 0.5104719248227789d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5877081093495405d, y: 0.39150907954898273d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641219565470935d, y: 0.9483448423853156d), new NpgsqlTypes.NpgsqlPoint(x: 0.17196046085968797d, y: 0.5301488756726007d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29242349837393045d, y: 0.04664979440816952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237372937702404d, y: 0.18599869233201216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7789230737836174d, y: 0.08509254645563646d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6235531528299779d, y: 0.059314905371115056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292279305905828d, y: 0.8848669416221182d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394327273746379d, y: 0.15242530832695633d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0540086237390619d, y: 0.3664743301723007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658114694211776d, y: 0.5643424452231979d), new NpgsqlTypes.NpgsqlPoint(x: 0.46390653310902574d, y: 0.5347645568071416d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6978421155299763d, y: 0.10388458709952997d), new NpgsqlTypes.NpgsqlPoint(x: 0.684349369088126d, y: 0.8878034355384954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8127278692801527d, y: 0.6823941673918028d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004754811948688764d, y: 0.8646748305449409d), new NpgsqlTypes.NpgsqlPoint(x: 0.5216117668380228d, y: 0.9078557353974857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269761396621915d, y: 0.7541971309667134d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7893097711759142d, y: 0.8439605347228988d), new NpgsqlTypes.NpgsqlPoint(x: 0.05348758396342845d, y: 0.5700238654418068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108539347165682d, y: 0.9906891349696559d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5014494070331896d, y: 0.45293474598641104d), new NpgsqlTypes.NpgsqlPoint(x: 0.33810965317345276d, y: 0.7659826205329586d), new NpgsqlTypes.NpgsqlPoint(x: 0.08153570502342611d, y: 0.3132132545269355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3777163914124677d, y: 0.7473629259141406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6723903292768246d, y: 0.568881355610434d), new NpgsqlTypes.NpgsqlPoint(x: 0.11643209315160741d, y: 0.4976781640857729d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32612213060650597d, y: 0.5667624900728317d), new NpgsqlTypes.NpgsqlPoint(x: 0.2799709016455295d, y: 0.3057483425877451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8683715283500885d, y: 0.7840558822289994d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22269957078167724d, y: 0.6748493076826615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451891321348273d, y: 0.6688235603744047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813391262705908d, y: 0.4134033692435094d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2902504877160458d, y: 0.36316093821778117d), new NpgsqlTypes.NpgsqlPoint(x: 0.46863538196553844d, y: 0.8495746336373167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6617643794108546d, y: 0.02582402387367244d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21499507206524027d, y: 0.943475008864752d), new NpgsqlTypes.NpgsqlPoint(x: 0.2160372858631069d, y: 0.5236007580303693d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723516784668347d, y: 0.05734339691200363d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9394607784403829d, y: 0.9878043379344742d), new NpgsqlTypes.NpgsqlPoint(x: 0.6794321141052316d, y: 0.1390582342765263d), new NpgsqlTypes.NpgsqlPoint(x: 0.46218669323220984d, y: 0.11040163614997589d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.508859256599261d, y: 0.87098273657986d), new NpgsqlTypes.NpgsqlPoint(x: 0.045275603110308094d, y: 0.8148002871215427d), new NpgsqlTypes.NpgsqlPoint(x: 0.3411230896498576d, y: 0.8361939011729407d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6864326289016871d, y: 0.24381057808300977d), new NpgsqlTypes.NpgsqlPoint(x: 0.03897479005657156d, y: 0.435511517761887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4432212791472423d, y: 0.814097140863888d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.503399979932655d, y: 0.9624745069033567d), new NpgsqlTypes.NpgsqlPoint(x: 0.04640741095184675d, y: 0.36305648765736853d), new NpgsqlTypes.NpgsqlPoint(x: 0.19506730270938988d, y: 0.9119581815528167d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3325538756248769d, y: 0.025740908050351674d), new NpgsqlTypes.NpgsqlPoint(x: 0.48775987846661706d, y: 0.7637373890317942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490226574264707d, y: 0.4387646792374864d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9774229272085371d, y: 0.129339835770948d), new NpgsqlTypes.NpgsqlPoint(x: 0.7864281148677646d, y: 0.8504337388972124d), new NpgsqlTypes.NpgsqlPoint(x: 0.11640554416542614d, y: 0.5527921194975361d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8497414597994143d, y: 0.953137262295917d), new NpgsqlTypes.NpgsqlPoint(x: 0.4214869806356658d, y: 0.6766281460904731d), new NpgsqlTypes.NpgsqlPoint(x: 0.13266769171325166d, y: 0.8032778805621946d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4214374781173418d, y: 0.1265017590639227d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977376750827036d, y: 0.5178421697636258d), new NpgsqlTypes.NpgsqlPoint(x: 0.12248053176044982d, y: 0.34458882172695515d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25305630858828454d, y: 0.06068347789954864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5481943386535749d, y: 0.2255187157346401d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528263620532247d, y: 0.7354895450447236d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9584875769806399d, y: 0.8203333303871982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161219086928118d, y: 0.9950154004651252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821885661666381d, y: 0.32218508504173937d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2476249479696041d, y: 0.2308195869749402d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528669966113729d, y: 0.3321338943944182d), new NpgsqlTypes.NpgsqlPoint(x: 0.395642729527937d, y: 0.6887281777806159d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2252531972807157d, y: 0.18365479069060364d), new NpgsqlTypes.NpgsqlPoint(x: 0.11993535383695009d, y: 0.3905662486230339d), new NpgsqlTypes.NpgsqlPoint(x: 0.7723630085103571d, y: 0.6600746481515988d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3791324942397938d, y: 0.4158825791790989d), new NpgsqlTypes.NpgsqlPoint(x: 0.31261048063309416d, y: 0.039969241814289624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266582193332523d, y: 0.22732858100393416d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1435916029897536d, y: 0.9670929523910946d), new NpgsqlTypes.NpgsqlPoint(x: 0.01955602645706256d, y: 0.6604504274135699d), new NpgsqlTypes.NpgsqlPoint(x: 0.3591756055009063d, y: 0.09098631061956064d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42553880697767454d, y: 0.49719970572213945d), new NpgsqlTypes.NpgsqlPoint(x: 0.4975291981229143d, y: 0.05180342892830758d), new NpgsqlTypes.NpgsqlPoint(x: 0.2509372553061371d, y: 0.7835986732211805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7246480813388446d, y: 0.8464357018548115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288608190271501d, y: 0.3208429178963128d), new NpgsqlTypes.NpgsqlPoint(x: 0.34635724094161524d, y: 0.9282965605273028d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5260953255200456d, y: 0.5931951029454948d), new NpgsqlTypes.NpgsqlPoint(x: 0.3540047142929731d, y: 0.4431785501948182d), new NpgsqlTypes.NpgsqlPoint(x: 0.4187974429128467d, y: 0.5344288431868858d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7320906321140643d, y: 0.9205880841143d), new NpgsqlTypes.NpgsqlPoint(x: 0.3861665941399782d, y: 0.2962396716413609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867281661032483d, y: 0.2315757920294398d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7440243699754341d, y: 0.18837881986564708d), new NpgsqlTypes.NpgsqlPoint(x: 0.11669938406612645d, y: 0.842896347587209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616280506107068d, y: 0.3913198190831655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016325372323190868d, y: 0.9216314577403744d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613077358722403d, y: 0.8082962904702073d), new NpgsqlTypes.NpgsqlPoint(x: 0.973637609431894d, y: 0.8119299139862136d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34537521810815097d, y: 0.36761673776373194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7914040300950052d, y: 0.9387712323380015d), new NpgsqlTypes.NpgsqlPoint(x: 0.4455660695058583d, y: 0.9915029686295949d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8928186091616199d, y: 0.3821673532259279d), new NpgsqlTypes.NpgsqlPoint(x: 0.20981889648806162d, y: 0.04681942986083387d), new NpgsqlTypes.NpgsqlPoint(x: 0.6025423175109444d, y: 0.007697859521798245d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25786822551284594d, y: 0.20530454882776006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8754463854996931d, y: 0.08226622575833364d), new NpgsqlTypes.NpgsqlPoint(x: 0.08276078110373752d, y: 0.7575274322833155d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03890113436993614d, y: 0.7123095918291101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670420587889783d, y: 0.9577583824950013d), new NpgsqlTypes.NpgsqlPoint(x: 0.3410234507656038d, y: 0.971222521655218d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40701214802158914d, y: 0.6344903848396819d), new NpgsqlTypes.NpgsqlPoint(x: 0.3607045098048456d, y: 0.26171543405125985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591050398698505d, y: 0.8853179604710603d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5908811238171898d, y: 0.9207721549768235d), new NpgsqlTypes.NpgsqlPoint(x: 0.17572437284352715d, y: 0.593496415484084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130575232423048d, y: 0.7578494576388003d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1548397409338248d, y: 0.5234355898632246d), new NpgsqlTypes.NpgsqlPoint(x: 0.553016893150097d, y: 0.4555394991168259d), new NpgsqlTypes.NpgsqlPoint(x: 0.1290950614105273d, y: 0.681218257150904d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1346817191456443d, y: 0.38113697037600347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2007417333058329d, y: 0.24304862492806922d), new NpgsqlTypes.NpgsqlPoint(x: 0.16264465309014764d, y: 0.38633546196007507d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07825701157874065d, y: 0.9662954322149664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242644383166927d, y: 0.0732837312172625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894478951493645d, y: 0.6355530205288434d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.037818002984096655d, y: 0.6889834608177887d), new NpgsqlTypes.NpgsqlPoint(x: 0.3990604503705374d, y: 0.9914560557095099d), new NpgsqlTypes.NpgsqlPoint(x: 0.302687593563463d, y: 0.16974447634374945d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9140435333036476d, y: 0.16873247830617755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3023294509991352d, y: 0.8471790103019303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522131327514803d, y: 0.022583617573306514d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18260329700715017d, y: 0.370335765481576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783149447775737d, y: 0.8477418585149751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052143835879793d, y: 0.13635775576437126d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4803014441337299d, y: 0.8482032952551084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664866046158136d, y: 0.6040545977321101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006280795138658d, y: 0.6125913666736766d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13318943001883965d, y: 0.2052567307325297d), new NpgsqlTypes.NpgsqlPoint(x: 0.24292208958853612d, y: 0.8174358170246341d), new NpgsqlTypes.NpgsqlPoint(x: 0.49172139337753906d, y: 0.4851047489275414d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7572848626743711d, y: 0.6651599957929628d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792960376070735d, y: 0.04602336333774282d), new NpgsqlTypes.NpgsqlPoint(x: 0.42331959183229917d, y: 0.9920842729435891d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8538708551251d, y: 0.3662214666711687d), new NpgsqlTypes.NpgsqlPoint(x: 0.21019934829227538d, y: 0.43756364375937584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078488130306039d, y: 0.5846730897697295d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7910924697721342d, y: 0.9292489923831407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7704950433090464d, y: 0.8732574488499172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740774971817297d, y: 0.7713071714715752d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8374247783127396d, y: 0.001242232041734792d), new NpgsqlTypes.NpgsqlPoint(x: 0.015603185331291458d, y: 0.7808868412358869d), new NpgsqlTypes.NpgsqlPoint(x: 0.31630677512130856d, y: 0.7526072019323615d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16778981253434266d, y: 0.41614072128430935d), new NpgsqlTypes.NpgsqlPoint(x: 0.4057483432954788d, y: 0.7058247821148669d), new NpgsqlTypes.NpgsqlPoint(x: 0.45759964080141546d, y: 0.8247000519715204d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5589520084067934d, y: 0.32009995673401226d), new NpgsqlTypes.NpgsqlPoint(x: 0.3331972854540809d, y: 0.43934800569248766d), new NpgsqlTypes.NpgsqlPoint(x: 0.791757658894342d, y: 0.6925813727255871d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5701381146620965d, y: 0.2861143449996032d), new NpgsqlTypes.NpgsqlPoint(x: 0.18731128424305954d, y: 0.4744682919052804d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565170819690089d, y: 0.16865513645571018d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44066983116821645d, y: 0.20338874474356905d), new NpgsqlTypes.NpgsqlPoint(x: 0.14650860530732224d, y: 0.7412904799445897d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645613059398466d, y: 0.8266964445978516d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36613396697639944d, y: 0.39254425040667273d), new NpgsqlTypes.NpgsqlPoint(x: 0.2154653412563734d, y: 0.9401312404276546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322586874212023d, y: 0.6718144011878564d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21905008373991974d, y: 0.5244688605571534d), new NpgsqlTypes.NpgsqlPoint(x: 0.47132536272578496d, y: 0.06380390141907821d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614831141459642d, y: 0.9414723441362349d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38315985344269043d, y: 0.7659385726276361d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158163938595807d, y: 0.46704122401901205d), new NpgsqlTypes.NpgsqlPoint(x: 0.3873490773525846d, y: 0.2012968262502447d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1877162676007409d, y: 0.5999812406475006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978993136219992d, y: 0.18243977572333525d), new NpgsqlTypes.NpgsqlPoint(x: 0.426194759076159d, y: 0.8720425696639398d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9659835762873384d, y: 0.1310980446971982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8757027505353187d, y: 0.6523066243640654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9196152753493149d, y: 0.32022057288897543d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.967790686847218d, y: 0.6091983517412556d), new NpgsqlTypes.NpgsqlPoint(x: 0.14323578976171136d, y: 0.5736216769694524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433958531172005d, y: 0.08474017646070975d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4138487253785488d, y: 0.4435594340696577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3838134357973654d, y: 0.7119293714678615d), new NpgsqlTypes.NpgsqlPoint(x: 0.45994871677223226d, y: 0.7989928847299931d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6281118782803886d, y: 0.12980024665956824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000589526620113d, y: 0.6839042892833691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827311945529634d, y: 0.7301708086740932d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6595450823866703d, y: 0.5062575590975874d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426385784919866d, y: 0.79602367598668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5941863188475157d, y: 0.10810253522156099d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6929476862177668d, y: 0.8058731945428926d), new NpgsqlTypes.NpgsqlPoint(x: 0.4943326957760996d, y: 0.5600251874601568d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459388891653011d, y: 0.46646385777734667d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3948405033050161d, y: 0.9930952395264102d), new NpgsqlTypes.NpgsqlPoint(x: 0.45393512425641547d, y: 0.7335191279007741d), new NpgsqlTypes.NpgsqlPoint(x: 0.12239512605455782d, y: 0.5189826749175305d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7610449898905579d, y: 0.1474129962850168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022687583867764d, y: 0.834857766341546d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326959809895937d, y: 0.4945540619987707d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41094496120460544d, y: 0.9471381302214245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978557471379583d, y: 0.9679588245801728d), new NpgsqlTypes.NpgsqlPoint(x: 0.24582697474869486d, y: 0.64479939689155d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3456891563321475d, y: 0.8009217899795027d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931998896816642d, y: 0.09080837132467201d), new NpgsqlTypes.NpgsqlPoint(x: 0.03580916857593419d, y: 0.5598860676759692d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.590213520392368d, y: 0.6817261110978383d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199767572253108d, y: 0.8266837928319108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695156733699356d, y: 0.9000784217679683d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7759062124266457d, y: 0.09856628509425425d), new NpgsqlTypes.NpgsqlPoint(x: 0.017026448983371356d, y: 0.792617028731704d), new NpgsqlTypes.NpgsqlPoint(x: 0.02807593165998934d, y: 0.15685875445785646d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7926328195219469d, y: 0.09527676280664443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673357798515929d, y: 0.8868683542168965d), new NpgsqlTypes.NpgsqlPoint(x: 0.20386167802893362d, y: 0.3466541370569608d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06108278193522798d, y: 0.9918923865790245d), new NpgsqlTypes.NpgsqlPoint(x: 0.3051573408704128d, y: 0.5519475759234863d), new NpgsqlTypes.NpgsqlPoint(x: 0.1303862209060217d, y: 0.6923509743165785d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08393984573552027d, y: 0.7195598886313936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4016441385170546d, y: 0.6188825287957657d), new NpgsqlTypes.NpgsqlPoint(x: 0.24696242912833666d, y: 0.971992899962979d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9291457450237933d, y: 0.41016175318158243d), new NpgsqlTypes.NpgsqlPoint(x: 0.29947196709827784d, y: 0.24820709778943473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7794603539090423d, y: 0.052795482911252245d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07875049868423745d, y: 0.8280312167844432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390034677919046d, y: 0.29351466165981754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5819950497176956d, y: 0.23379596461661134d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6145229189813148d, y: 0.05268989181149686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461752736016064d, y: 0.6435381712983431d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205627984865436d, y: 0.23933905971851632d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8448414925559816d, y: 0.767157165675848d), new NpgsqlTypes.NpgsqlPoint(x: 0.04496697515140091d, y: 0.7555895183960201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9680958976186737d, y: 0.2256143648239567d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4692808632750628d, y: 0.20913790744830685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9757428402634559d, y: 0.8321499183171492d), new NpgsqlTypes.NpgsqlPoint(x: 0.14454120268380433d, y: 0.020914860645306232d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7198900847364725d, y: 0.26107429126477477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9173101414279752d, y: 0.0955245387643503d), new NpgsqlTypes.NpgsqlPoint(x: 0.06575899185334155d, y: 0.28396034335395726d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7966548737720491d, y: 0.16315635159297015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6421252322887787d, y: 0.000605580575323228d), new NpgsqlTypes.NpgsqlPoint(x: 0.023053046269372546d, y: 0.9091047284776688d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36087165054610026d, y: 0.9975721165497275d), new NpgsqlTypes.NpgsqlPoint(x: 0.32270239169780535d, y: 0.4642982265986626d), new NpgsqlTypes.NpgsqlPoint(x: 0.17450788805659d, y: 0.9690968518371755d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6827535699008163d, y: 0.034516242680609155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289405658220156d, y: 0.46943267636677244d), new NpgsqlTypes.NpgsqlPoint(x: 0.007102107438129224d, y: 0.36730633443435d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29776159290505677d, y: 0.7575268857902993d), new NpgsqlTypes.NpgsqlPoint(x: 0.43449491342010793d, y: 0.6033788110687793d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825495699286033d, y: 0.5122147297532855d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17802816768274365d, y: 0.6618762325836512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552169201273794d, y: 0.21503252133902584d), new NpgsqlTypes.NpgsqlPoint(x: 0.850754106441828d, y: 0.09578962397895008d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8014760608595619d, y: 0.9763732812267544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701454557907757d, y: 0.252389788282137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273960067264331d, y: 0.5976480711547731d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07995601565674904d, y: 0.4999137212369874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646887432222111d, y: 0.587320490167533d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685405301149972d, y: 0.4530837507891553d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27661484278682313d, y: 0.9585069135180673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2470820453575785d, y: 0.8106977946104027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370110690264137d, y: 0.5905715737010799d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8104677766918692d, y: 0.06561430982945493d), new NpgsqlTypes.NpgsqlPoint(x: 0.0033343392260372084d, y: 0.11133147428219337d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082399477213932d, y: 0.31815381227077855d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18961197191462653d, y: 0.0008326131216529475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7392515168106641d, y: 0.5799630959839049d), new NpgsqlTypes.NpgsqlPoint(x: 0.2183108798375868d, y: 0.1844720439161105d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5974741511568197d, y: 0.1354492679985777d), new NpgsqlTypes.NpgsqlPoint(x: 0.31962877322029426d, y: 0.4291867091261675d), new NpgsqlTypes.NpgsqlPoint(x: 0.022854433243860384d, y: 0.213821653913689d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.855833068848811d, y: 0.22903949660740475d), new NpgsqlTypes.NpgsqlPoint(x: 0.03995550468411724d, y: 0.853101254284119d), new NpgsqlTypes.NpgsqlPoint(x: 0.10775550442320314d, y: 0.03808254650985665d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9314337346042684d, y: 0.06589981093779917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267941638168827d, y: 0.548675319162433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607233523727126d, y: 0.36291814801881606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13760081742515007d, y: 0.18352595101678215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626957920253293d, y: 0.4029612043672878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6477854173832187d, y: 0.19781149480687266d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40821186073859117d, y: 0.9726451841704103d), new NpgsqlTypes.NpgsqlPoint(x: 0.17073783263243836d, y: 0.021198258010127535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238543188525174d, y: 0.7035380453296016d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015580864971773467d, y: 0.8397114905587217d), new NpgsqlTypes.NpgsqlPoint(x: 0.572203598622425d, y: 0.5194286341085579d), new NpgsqlTypes.NpgsqlPoint(x: 0.13718637720216387d, y: 0.8854331381567722d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2848272198524653d, y: 0.25201400539069607d), new NpgsqlTypes.NpgsqlPoint(x: 0.043444589761489794d, y: 0.387801158613725d), new NpgsqlTypes.NpgsqlPoint(x: 0.4164934008902409d, y: 0.2922856625787913d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33455532998115656d, y: 0.5500600676454198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8420390767427248d, y: 0.5953111166033003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671494374583111d, y: 0.03370756688719079d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1555578746004973d, y: 0.015420761405413042d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763327382443628d, y: 0.7638784553436258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536578465102776d, y: 0.06324890377921655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9426658082406228d, y: 0.1313489059319064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7272623570764375d, y: 0.6089305072695836d), new NpgsqlTypes.NpgsqlPoint(x: 0.20177775556434796d, y: 0.42076038753064204d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6669452670779062d, y: 0.7006518706007848d), new NpgsqlTypes.NpgsqlPoint(x: 0.15680259209912306d, y: 0.1092973820241856d), new NpgsqlTypes.NpgsqlPoint(x: 0.41990344288894d, y: 0.7582240353965417d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45446812828563443d, y: 0.8884117252788093d), new NpgsqlTypes.NpgsqlPoint(x: 0.7385896414472313d, y: 0.4685191840186532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5683615425664139d, y: 0.7583672373856659d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5523322888656302d, y: 0.28947546122213774d), new NpgsqlTypes.NpgsqlPoint(x: 0.23037716181213264d, y: 0.5788556974166035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586608501051328d, y: 0.4229023413596005d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6327083060804681d, y: 0.052914023838292024d), new NpgsqlTypes.NpgsqlPoint(x: 0.618454046858049d, y: 0.07643010404031936d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231429111237416d, y: 0.3819503876534205d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.746421434496636d, y: 0.7464129017304884d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756923559830503d, y: 0.9786048584186938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305130783248612d, y: 0.6993804609072362d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5961035497230989d, y: 0.8326553439686495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9538463541325524d, y: 0.4479856177797523d), new NpgsqlTypes.NpgsqlPoint(x: 0.35095589392314075d, y: 0.46386538386066967d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5656707157983105d, y: 0.7541892534470944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7328847078859273d, y: 0.21013638094284648d), new NpgsqlTypes.NpgsqlPoint(x: 0.17977929183292607d, y: 0.849232083493077d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672755812373902d, y: 0.9294417534887313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6179286885114277d, y: 0.12145279051890656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420117144174912d, y: 0.8303123964750796d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9403759929057476d, y: 0.7853482211784327d), new NpgsqlTypes.NpgsqlPoint(x: 0.2388367240069793d, y: 0.09907546769214282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822126022788258d, y: 0.3125698060335189d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7120578111257164d, y: 0.5145709715716846d), new NpgsqlTypes.NpgsqlPoint(x: 0.0909136838344814d, y: 0.7195297324892759d), new NpgsqlTypes.NpgsqlPoint(x: 0.4889274159253181d, y: 0.7617858901770594d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09098730610734174d, y: 0.32710941027087004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800862543344433d, y: 0.12285201160493198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5423104208227583d, y: 0.39538849700135204d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10889822598847032d, y: 0.8641239376854404d), new NpgsqlTypes.NpgsqlPoint(x: 0.3779895709640969d, y: 0.25616350573211977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566535098495688d, y: 0.8086113674104031d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49082082831461404d, y: 0.10786105668514367d), new NpgsqlTypes.NpgsqlPoint(x: 0.17083608737253164d, y: 0.43359291824600565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980436827860299d, y: 0.35492770413796104d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7285633646972669d, y: 0.9541861622944882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6635473576058841d, y: 0.7698206380553714d), new NpgsqlTypes.NpgsqlPoint(x: 0.3207163063898508d, y: 0.9921551562751987d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7118781191117682d, y: 0.4405066494575146d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604880608317672d, y: 0.4433296639349066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934634981080277d, y: 0.22238081097536766d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46458308180307883d, y: 0.515340762207965d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423307330671237d, y: 0.7207940771773919d), new NpgsqlTypes.NpgsqlPoint(x: 0.4235903103680403d, y: 0.26156950122807243d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.582353042444226d, y: 0.8724574605498062d), new NpgsqlTypes.NpgsqlPoint(x: 0.4804261086731286d, y: 0.06491030029290479d), new NpgsqlTypes.NpgsqlPoint(x: 0.23056885183714926d, y: 0.34582992019006364d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9474381400192086d, y: 0.2912170783851601d), new NpgsqlTypes.NpgsqlPoint(x: 0.10767109895476457d, y: 0.09642887743476647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6051030027362172d, y: 0.2821018925351979d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32850160131622075d, y: 0.6028510645974362d), new NpgsqlTypes.NpgsqlPoint(x: 0.06200690586456048d, y: 0.15626731305892516d), new NpgsqlTypes.NpgsqlPoint(x: 0.34935398393245554d, y: 0.5027815207169581d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024452815347452694d, y: 0.7306728015180798d), new NpgsqlTypes.NpgsqlPoint(x: 0.3895771092787146d, y: 0.06875104911284069d), new NpgsqlTypes.NpgsqlPoint(x: 0.6616645482616889d, y: 0.36624020319885997d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5919733520916229d, y: 0.7473826857604259d), new NpgsqlTypes.NpgsqlPoint(x: 0.2146979432565006d, y: 0.8905016677868469d), new NpgsqlTypes.NpgsqlPoint(x: 0.07948550534166132d, y: 0.46003783246579866d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2945518015143239d, y: 0.3577559528506218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207750903420699d, y: 0.5728221416194283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7168512913375676d, y: 0.509859061278557d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9914544944695771d, y: 0.8562233378500365d), new NpgsqlTypes.NpgsqlPoint(x: 0.409157645630963d, y: 0.4002065912091701d), new NpgsqlTypes.NpgsqlPoint(x: 0.23713093357905313d, y: 0.17532618112311815d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7321209041182452d, y: 0.11559593316695083d), new NpgsqlTypes.NpgsqlPoint(x: 0.37795502082948895d, y: 0.09239002748062974d), new NpgsqlTypes.NpgsqlPoint(x: 0.279799432873446d, y: 0.11332010029976602d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39161130611178996d, y: 0.7940915608614302d), new NpgsqlTypes.NpgsqlPoint(x: 0.20675389938999922d, y: 0.05706109071441734d), new NpgsqlTypes.NpgsqlPoint(x: 0.46284752331428336d, y: 0.8302496783630999d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16203432502621884d, y: 0.22808075069374045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068644589451609d, y: 0.5319711855765982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5490962332116026d, y: 0.32103144117730664d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4060020103628773d, y: 0.37574890655287496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880696273552019d, y: 0.33776488367799395d), new NpgsqlTypes.NpgsqlPoint(x: 0.28197588676182517d, y: 0.5325655469089683d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5619166439256287d, y: 0.8791029760248767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722425619335737d, y: 0.41420434663968575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2925535361127597d, y: 0.12380257299761555d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5001821292056418d, y: 0.11887958393672737d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803508593830769d, y: 0.5382732557101352d), new NpgsqlTypes.NpgsqlPoint(x: 0.244183240987352d, y: 0.5014486835077352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870079603633238d, y: 0.6158768274438168d), new NpgsqlTypes.NpgsqlPoint(x: 0.3540734478238161d, y: 0.6060204602754269d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036706843619053d, y: 0.44205829390377716d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9223554321155083d, y: 0.3742422576192489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632921906691554d, y: 0.9997242056981551d), new NpgsqlTypes.NpgsqlPoint(x: 0.684860785984264d, y: 0.29263424557789985d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41363309820753436d, y: 0.4748273284080994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622094922511964d, y: 0.33227114381413236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420225700540041d, y: 0.22023379723595715d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17505373449594497d, y: 0.8107095091675199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8964167248864207d, y: 0.4575667323653798d), new NpgsqlTypes.NpgsqlPoint(x: 0.568832978537077d, y: 0.874557793911768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125264664735981d, y: 0.22850640349861473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726478477388524d, y: 0.8319230607357901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4446787519844605d, y: 0.3532416017281075d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020127203277863437d, y: 0.2950736509449525d), new NpgsqlTypes.NpgsqlPoint(x: 0.22206660446238202d, y: 0.765763848047394d), new NpgsqlTypes.NpgsqlPoint(x: 0.31967819413008536d, y: 0.9490447950812795d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10142020373336469d, y: 0.18082360619952065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540752942575457d, y: 0.6806958617114716d), new NpgsqlTypes.NpgsqlPoint(x: 0.05815864761504708d, y: 0.5606751027529929d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22278661154589652d, y: 0.2495560734917125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4782793951802229d, y: 0.03612458019944931d), new NpgsqlTypes.NpgsqlPoint(x: 0.4013932554310953d, y: 0.45125740427512206d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9748638007529744d, y: 0.8053767938722786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296925229585145d, y: 0.06165515550782885d), new NpgsqlTypes.NpgsqlPoint(x: 0.6965161479194898d, y: 0.8743081713358307d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9312801799562548d, y: 0.7510354673618305d), new NpgsqlTypes.NpgsqlPoint(x: 0.1635164798105041d, y: 0.49503533703814595d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140116833098991d, y: 0.21511645090927745d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24220165882992928d, y: 0.7044216882987689d), new NpgsqlTypes.NpgsqlPoint(x: 0.5725842022311388d, y: 0.6154391627380033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746454320935079d, y: 0.24963527049955792d)),
}));
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19097191868843655d, y: 0.7340038603786234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022108026710092d, y: 0.09328535560087137d), new NpgsqlTypes.NpgsqlPoint(x: 0.4630389877048995d, y: 0.6660367136372913d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8994407088828366d, y: 0.8465954848867325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308682700436191d, y: 0.07182022940714661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063185311238222d, y: 0.9593542501683987d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9809068351610618d, y: 0.04904456700640403d), new NpgsqlTypes.NpgsqlPoint(x: 0.1042537276972082d, y: 0.6169020675470808d), new NpgsqlTypes.NpgsqlPoint(x: 0.021050240111144647d, y: 0.4220345577864777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2509413658490278d, y: 0.3628333154730735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712651760745672d, y: 0.9743508539546034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497423781073205d, y: 0.8183610206834617d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42106266194417086d, y: 0.5984862839692308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966851196668349d, y: 0.947287084442264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929406704462085d, y: 0.10870588233433909d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9642611487987182d, y: 0.207299237648508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016768839603066d, y: 0.0004344239421173457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622062114086866d, y: 0.7452670121835523d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6611757239364437d, y: 0.05440121953071031d), new NpgsqlTypes.NpgsqlPoint(x: 0.41206587754487456d, y: 0.6695326901821828d), new NpgsqlTypes.NpgsqlPoint(x: 0.4933105967650787d, y: 0.41830727292374037d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030775136766488576d, y: 0.789057740321322d), new NpgsqlTypes.NpgsqlPoint(x: 0.19406632868916374d, y: 0.24434211262954297d), new NpgsqlTypes.NpgsqlPoint(x: 0.4205795453019855d, y: 0.8891641197043806d)),
}));
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5823300184892729d, y: 0.7422271474165114d), new NpgsqlTypes.NpgsqlPoint(x: 0.003732032356492998d, y: 0.5647847962883702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296093863008629d, y: 0.666496017085651d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0966176983485767d, y: 0.395153020091915d), new NpgsqlTypes.NpgsqlPoint(x: 0.91747397640143d, y: 0.9906054154291819d), new NpgsqlTypes.NpgsqlPoint(x: 0.060113862586560596d, y: 0.23444985419683217d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6908799194402919d, y: 0.29154049418040473d), new NpgsqlTypes.NpgsqlPoint(x: 0.006693714818449492d, y: 0.6476181959510661d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668878319029837d, y: 0.8251456038938791d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 86, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 50, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 36, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 127, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatch(connection, 102, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1M>(15);

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
                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

