

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
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28831300195344d, y: 0.0929748172184065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729377503316047d, y: 0.9464436596097247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2481112567317576d, y: 0.26392397303159065d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77724645128919d, y: 0.016227515368352208d), new NpgsqlTypes.NpgsqlPoint(x: 0.26358336685075145d, y: 0.22177412050133005d), new NpgsqlTypes.NpgsqlPoint(x: 0.12607769854135076d, y: 0.7165216148849481d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38339116548650987d, y: 0.5415867879168583d), new NpgsqlTypes.NpgsqlPoint(x: 0.315380203267117d, y: 0.4905455849029532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194583584522468d, y: 0.7216909527534081d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11076308456254669d, y: 0.12160853828911833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222087068660112d, y: 0.026109044433501594d), new NpgsqlTypes.NpgsqlPoint(x: 0.48870150574658877d, y: 0.4104302704125685d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906641768857171d, y: 0.4467121244706509d), new NpgsqlTypes.NpgsqlPoint(x: 0.5520525562015579d, y: 0.49921836152985577d), new NpgsqlTypes.NpgsqlPoint(x: 0.2668804076703267d, y: 0.18768766776217805d)),
},
            new NpgsqlPathpath0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41601587122938377d, y: 0.37940311970794605d), new NpgsqlTypes.NpgsqlPoint(x: 0.31891912132907285d, y: 0.7267806454699454d), new NpgsqlTypes.NpgsqlPoint(x: 0.10754274391749641d, y: 0.037050411125227556d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4633397152076223d, y: 0.9886417951017633d), new NpgsqlTypes.NpgsqlPoint(x: 0.2422224506986682d, y: 0.28028157818148147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364224365530413d, y: 0.07340039323851733d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3552949751244383d, y: 0.5019669096647902d), new NpgsqlTypes.NpgsqlPoint(x: 0.750500293181955d, y: 0.5395638393590673d), new NpgsqlTypes.NpgsqlPoint(x: 0.48433028194043404d, y: 0.5141560500992332d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7105154890739028d, y: 0.7580154044718805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3013613547242767d, y: 0.8161196849842075d), new NpgsqlTypes.NpgsqlPoint(x: 0.14691487846466222d, y: 0.3330402881585043d)),
},
            new NpgsqlPathpath0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5984255034896624d, y: 0.02076928268754974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006040272184959d, y: 0.3271636600116107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746769468076411d, y: 0.48765430860876335d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6614018539150084d, y: 0.48893577702038193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202785371335617d, y: 0.7913793873902799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7173641907132036d, y: 0.6822394459474836d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2890596461861711d, y: 0.844308945823373d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317563192650613d, y: 0.16141889087041206d), new NpgsqlTypes.NpgsqlPoint(x: 0.1548827707338094d, y: 0.0036357788742638064d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611900189310911d, y: 0.8685666646806884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837934194846987d, y: 0.736202608643477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690010093364385d, y: 0.6073896984997524d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7870139566464146d, y: 0.4419432311203253d), new NpgsqlTypes.NpgsqlPoint(x: 0.05815851164209218d, y: 0.2363902515947106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135238912399938d, y: 0.2590833509440881d)),
},
            new NpgsqlPathpath0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047891679742668725d, y: 0.465598781423018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9332993971699387d, y: 0.5312600122661618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516759039643164d, y: 0.5297206682223973d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6764512115245349d, y: 0.8870479649025143d), new NpgsqlTypes.NpgsqlPoint(x: 0.012801610529443619d, y: 0.054759425950354546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382377548756228d, y: 0.9917795023400938d)),
},
            new NpgsqlPathpath0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2274206264369475d, y: 0.03175457518059166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079875475600382d, y: 0.14220374515772405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426045209733511d, y: 0.34406121727801087d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4094407649250199d, y: 0.8589237692191429d), new NpgsqlTypes.NpgsqlPoint(x: 0.42628063375666425d, y: 0.4412829516702178d), new NpgsqlTypes.NpgsqlPoint(x: 0.12055969365453656d, y: 0.6864163500881508d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4505654199202812d, y: 0.8051926778227086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922538432059608d, y: 0.7279848982781268d), new NpgsqlTypes.NpgsqlPoint(x: 0.17838654791652397d, y: 0.3229287860486826d)),
},
            new NpgsqlPathpath0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6071361554635768d, y: 0.23955141319908202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645056189079881d, y: 0.9330702780975464d), new NpgsqlTypes.NpgsqlPoint(x: 0.1002238066490595d, y: 0.9822097751799667d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787249371219273d, y: 0.41577484871624437d), new NpgsqlTypes.NpgsqlPoint(x: 0.485747266191652d, y: 0.9099158228406726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45233186905477984d, y: 0.5311992212897457d)),
},
            new NpgsqlPathpath0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46982006051530745d, y: 0.2176338130913924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226504075648116d, y: 0.16568124544928065d), new NpgsqlTypes.NpgsqlPoint(x: 0.458031414814456d, y: 0.4050073710526907d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08727409216142346d, y: 0.6988812164116189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725068939171019d, y: 0.5890252729679719d), new NpgsqlTypes.NpgsqlPoint(x: 0.31507604842094683d, y: 0.07981785337161373d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49956635480661005d, y: 0.3238602516068342d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394491410439694d, y: 0.9931627249860187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609168219816716d, y: 0.018515466187586593d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477948424798246d, y: 0.22448688613768575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331553710756616d, y: 0.677684148959098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578017043319507d, y: 0.5884312704825327d)),
},
            new NpgsqlPathpath0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3253535482469895d, y: 0.08943028862493219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909709837075972d, y: 0.8239151142072196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544226447151633d, y: 0.04590731069917675d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.531711168628735d, y: 0.4072739451965294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357002079167353d, y: 0.9954085348573675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096332221052772d, y: 0.6307106642409245d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3897218206640516d, y: 0.26486260614840096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629332827770182d, y: 0.4138776075575772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885344807941253d, y: 0.8977377406600535d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9828634835458117d, y: 0.31863257146949986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060199096658561d, y: 0.8622844573189969d), new NpgsqlTypes.NpgsqlPoint(x: 0.281694080002593d, y: 0.33429690038916393d)),
},
            new NpgsqlPathpath0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24142479290247376d, y: 0.5487913041275767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856004115509795d, y: 0.020205856467602756d), new NpgsqlTypes.NpgsqlPoint(x: 0.1656048181351496d, y: 0.3256900651120921d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49265579093873246d, y: 0.22210978343015975d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125027332490996d, y: 0.9629045342975875d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014046466268081d, y: 0.051911951583694105d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022990213760733d, y: 0.09031097942962196d), new NpgsqlTypes.NpgsqlPoint(x: 0.27213603834432065d, y: 0.8773523895576237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485714460868667d, y: 0.638911337692542d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8499111429099017d, y: 0.8257891624151252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179028911989616d, y: 0.6163707380796175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194922787636284d, y: 0.8759614137687683d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3275894769989983d, y: 0.689562064341376d), new NpgsqlTypes.NpgsqlPoint(x: 0.57045783116206d, y: 0.008253788656068184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696655317850066d, y: 0.6259449978979577d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17760669009480723d, y: 0.8670331189463415d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466845496584884d, y: 0.9401823129418212d), new NpgsqlTypes.NpgsqlPoint(x: 0.10856570697971846d, y: 0.5685556021880557d)),
},
            new NpgsqlPathpath0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5808993388880154d, y: 0.22144122698307123d), new NpgsqlTypes.NpgsqlPoint(x: 0.0905460853458171d, y: 0.18908641521758773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029423149714316d, y: 0.42122340299701466d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14670466842567564d, y: 0.9772651790306214d), new NpgsqlTypes.NpgsqlPoint(x: 0.35051410585471854d, y: 0.35164214433193863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4525822586953703d, y: 0.05606243329586891d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03348609440805206d, y: 0.9830288310569116d), new NpgsqlTypes.NpgsqlPoint(x: 0.17432980878902926d, y: 0.39670978555534786d), new NpgsqlTypes.NpgsqlPoint(x: 0.10432982824732973d, y: 0.167621886955434d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6777857701389702d, y: 0.5347401490964715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133103683414089d, y: 0.22353652702544136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601450023418311d, y: 0.595248509747635d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8029729848740058d, y: 0.38095882651732804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374168998387217d, y: 0.28608405545922055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900967610474563d, y: 0.010156177103194386d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5903218903955727d, y: 0.613029687562407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932686952678457d, y: 0.1715154815549198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8129836698274526d, y: 0.830123438889477d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590744336160716d, y: 0.228736162664687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274277023746199d, y: 0.11305288521917811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573112845391754d, y: 0.7941408486411161d)),
},
            new NpgsqlPathpath0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.941788705070168d, y: 0.7420364282932943d), new NpgsqlTypes.NpgsqlPoint(x: 0.4148672363406891d, y: 0.8751547971318265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010018019302991d, y: 0.8837209124922859d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.488035557724359d, y: 0.7754209178346392d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388596878285642d, y: 0.8576682375931791d), new NpgsqlTypes.NpgsqlPoint(x: 0.2895742465807327d, y: 0.47438902698460084d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5837892664226313d, y: 0.9020832452103541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982598611059297d, y: 0.18440428495833772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529171107264912d, y: 0.022254074399918555d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9425299345955871d, y: 0.4313924552979218d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542400351056592d, y: 0.6638779902828819d), new NpgsqlTypes.NpgsqlPoint(x: 0.36681903023534d, y: 0.9205432048852158d)),
},
            new NpgsqlPathpath0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9030294625395692d, y: 0.00490524284369287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957019272782032d, y: 0.05725895959409322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389317503273786d, y: 0.6402146052593728d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42162933938403657d, y: 0.45933938341872993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734328274636806d, y: 0.864528346725586d), new NpgsqlTypes.NpgsqlPoint(x: 0.19445367952815584d, y: 0.17801118104947655d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14463179002235682d, y: 0.4020876768856575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334650526749708d, y: 0.4949808602575144d), new NpgsqlTypes.NpgsqlPoint(x: 0.984432535726885d, y: 0.6606503305145429d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3597158918719028d, y: 0.6366659336903562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728146865449082d, y: 0.6009297635359397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375050615487762d, y: 0.7274889096318096d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0534746559281194d, y: 0.3365016751257148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553306848279595d, y: 0.9728022329775157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654313342975692d, y: 0.9584147963415532d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2301327422068603d, y: 0.31289018181597195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235280401437046d, y: 0.799927430265658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940082767796955d, y: 0.6954175541265964d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07251774710576853d, y: 0.2684983512633028d), new NpgsqlTypes.NpgsqlPoint(x: 0.668252167375124d, y: 0.5461842127669907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070513849792036d, y: 0.8790868191885038d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5998721132249853d, y: 0.24801047433073975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335256506239341d, y: 0.7811387688546667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390596073609111d, y: 0.10848776305004593d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5002065891957885d, y: 0.24326569671305687d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511543888272159d, y: 0.24974060621825034d), new NpgsqlTypes.NpgsqlPoint(x: 0.15652118620045563d, y: 0.06657796422786122d)),
},
            new NpgsqlPathpath0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7915233804924722d, y: 0.37596105104189437d), new NpgsqlTypes.NpgsqlPoint(x: 0.41094310861593886d, y: 0.6596365801181094d), new NpgsqlTypes.NpgsqlPoint(x: 0.15023303390284348d, y: 0.062276091503468356d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5475284585986018d, y: 0.06134262249596201d), new NpgsqlTypes.NpgsqlPoint(x: 0.08149552694608042d, y: 0.7889332025093468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686179812065036d, y: 0.1927249576558402d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7538894279820034d, y: 0.9812983600926166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863216073963943d, y: 0.6423992122646082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2027545679277617d, y: 0.9182644131193952d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4495067204678821d, y: 0.3476002601431507d), new NpgsqlTypes.NpgsqlPoint(x: 0.03385325577726217d, y: 0.7759814476539633d), new NpgsqlTypes.NpgsqlPoint(x: 0.26637123991629985d, y: 0.8739636080067572d)),
},
            new NpgsqlPathpath0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15468409524022697d, y: 0.9383674660568853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469637969181072d, y: 0.1871875452535876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9979045921489732d, y: 0.8694289008780619d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038178826791904874d, y: 0.45825778786319327d), new NpgsqlTypes.NpgsqlPoint(x: 0.10851572616676541d, y: 0.5350729028238127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853739655952862d, y: 0.43452646920992644d)),
},
            new NpgsqlPathpath0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.187346947890205d, y: 0.9331510288610391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411433440839748d, y: 0.25826612237167035d), new NpgsqlTypes.NpgsqlPoint(x: 0.36016822216739786d, y: 0.8347903801970022d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20344239209454673d, y: 0.9690712865553058d), new NpgsqlTypes.NpgsqlPoint(x: 0.35068964734857755d, y: 0.8840953624685626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672516756448686d, y: 0.0403626897159437d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30500581840394103d, y: 0.24719921702627845d), new NpgsqlTypes.NpgsqlPoint(x: 0.026941426122726764d, y: 0.516878531061996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241297663710556d, y: 0.6282097516484395d)),
},
            new NpgsqlPathpath0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4076306031714574d, y: 0.40320132143258913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781982678204563d, y: 0.733260079118118d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323705877899851d, y: 0.6815676828238694d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3450069048008324d, y: 0.9897469004547611d), new NpgsqlTypes.NpgsqlPoint(x: 0.05111316977380587d, y: 0.5306342304679359d), new NpgsqlTypes.NpgsqlPoint(x: 0.24079483381712752d, y: 0.8680019533639897d)),
},
            new NpgsqlPathpath0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7623839843878456d, y: 0.9193061532808959d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186052723711295d, y: 0.5073822792233246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638276202552711d, y: 0.6040089947236239d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7202320842754043d, y: 0.5760684115795004d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521830106970903d, y: 0.009337572893359902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7672888667446705d, y: 0.6681154923357747d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3053649457580291d, y: 0.2677071664939762d), new NpgsqlTypes.NpgsqlPoint(x: 0.04546221625624858d, y: 0.7362422385037031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532765845112062d, y: 0.10347343712618062d)),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7870139566464146d, y: 0.4419432311203253d), new NpgsqlTypes.NpgsqlPoint(x: 0.05815851164209218d, y: 0.2363902515947106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135238912399938d, y: 0.2590833509440881d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6764512115245349d, y: 0.8870479649025143d), new NpgsqlTypes.NpgsqlPoint(x: 0.012801610529443619d, y: 0.054759425950354546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382377548756228d, y: 0.9917795023400938d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4505654199202812d, y: 0.8051926778227086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922538432059608d, y: 0.7279848982781268d), new NpgsqlTypes.NpgsqlPoint(x: 0.17838654791652397d, y: 0.3229287860486826d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787249371219273d, y: 0.41577484871624437d), new NpgsqlTypes.NpgsqlPoint(x: 0.485747266191652d, y: 0.9099158228406726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45233186905477984d, y: 0.5311992212897457d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477948424798246d, y: 0.22448688613768575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331553710756616d, y: 0.677684148959098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578017043319507d, y: 0.5884312704825327d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9828634835458117d, y: 0.31863257146949986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060199096658561d, y: 0.8622844573189969d), new NpgsqlTypes.NpgsqlPoint(x: 0.281694080002593d, y: 0.33429690038916393d))));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[29], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 149, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 52, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 144, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 61, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 57, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 67, 67))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28831300195344d, y: 0.0929748172184065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729377503316047d, y: 0.9464436596097247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2481112567317576d, y: 0.26392397303159065d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77724645128919d, y: 0.016227515368352208d), new NpgsqlTypes.NpgsqlPoint(x: 0.26358336685075145d, y: 0.22177412050133005d), new NpgsqlTypes.NpgsqlPoint(x: 0.12607769854135076d, y: 0.7165216148849481d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38339116548650987d, y: 0.5415867879168583d), new NpgsqlTypes.NpgsqlPoint(x: 0.315380203267117d, y: 0.4905455849029532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194583584522468d, y: 0.7216909527534081d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11076308456254669d, y: 0.12160853828911833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222087068660112d, y: 0.026109044433501594d), new NpgsqlTypes.NpgsqlPoint(x: 0.48870150574658877d, y: 0.4104302704125685d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906641768857171d, y: 0.4467121244706509d), new NpgsqlTypes.NpgsqlPoint(x: 0.5520525562015579d, y: 0.49921836152985577d), new NpgsqlTypes.NpgsqlPoint(x: 0.2668804076703267d, y: 0.18768766776217805d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41601587122938377d, y: 0.37940311970794605d), new NpgsqlTypes.NpgsqlPoint(x: 0.31891912132907285d, y: 0.7267806454699454d), new NpgsqlTypes.NpgsqlPoint(x: 0.10754274391749641d, y: 0.037050411125227556d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4633397152076223d, y: 0.9886417951017633d), new NpgsqlTypes.NpgsqlPoint(x: 0.2422224506986682d, y: 0.28028157818148147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364224365530413d, y: 0.07340039323851733d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3552949751244383d, y: 0.5019669096647902d), new NpgsqlTypes.NpgsqlPoint(x: 0.750500293181955d, y: 0.5395638393590673d), new NpgsqlTypes.NpgsqlPoint(x: 0.48433028194043404d, y: 0.5141560500992332d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7105154890739028d, y: 0.7580154044718805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3013613547242767d, y: 0.8161196849842075d), new NpgsqlTypes.NpgsqlPoint(x: 0.14691487846466222d, y: 0.3330402881585043d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5984255034896624d, y: 0.02076928268754974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006040272184959d, y: 0.3271636600116107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746769468076411d, y: 0.48765430860876335d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6614018539150084d, y: 0.48893577702038193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202785371335617d, y: 0.7913793873902799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7173641907132036d, y: 0.6822394459474836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2890596461861711d, y: 0.844308945823373d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317563192650613d, y: 0.16141889087041206d), new NpgsqlTypes.NpgsqlPoint(x: 0.1548827707338094d, y: 0.0036357788742638064d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611900189310911d, y: 0.8685666646806884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837934194846987d, y: 0.736202608643477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690010093364385d, y: 0.6073896984997524d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7870139566464146d, y: 0.4419432311203253d), new NpgsqlTypes.NpgsqlPoint(x: 0.05815851164209218d, y: 0.2363902515947106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135238912399938d, y: 0.2590833509440881d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047891679742668725d, y: 0.465598781423018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9332993971699387d, y: 0.5312600122661618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516759039643164d, y: 0.5297206682223973d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6764512115245349d, y: 0.8870479649025143d), new NpgsqlTypes.NpgsqlPoint(x: 0.012801610529443619d, y: 0.054759425950354546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382377548756228d, y: 0.9917795023400938d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2274206264369475d, y: 0.03175457518059166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079875475600382d, y: 0.14220374515772405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426045209733511d, y: 0.34406121727801087d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4094407649250199d, y: 0.8589237692191429d), new NpgsqlTypes.NpgsqlPoint(x: 0.42628063375666425d, y: 0.4412829516702178d), new NpgsqlTypes.NpgsqlPoint(x: 0.12055969365453656d, y: 0.6864163500881508d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4505654199202812d, y: 0.8051926778227086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922538432059608d, y: 0.7279848982781268d), new NpgsqlTypes.NpgsqlPoint(x: 0.17838654791652397d, y: 0.3229287860486826d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6071361554635768d, y: 0.23955141319908202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645056189079881d, y: 0.9330702780975464d), new NpgsqlTypes.NpgsqlPoint(x: 0.1002238066490595d, y: 0.9822097751799667d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787249371219273d, y: 0.41577484871624437d), new NpgsqlTypes.NpgsqlPoint(x: 0.485747266191652d, y: 0.9099158228406726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45233186905477984d, y: 0.5311992212897457d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46982006051530745d, y: 0.2176338130913924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226504075648116d, y: 0.16568124544928065d), new NpgsqlTypes.NpgsqlPoint(x: 0.458031414814456d, y: 0.4050073710526907d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08727409216142346d, y: 0.6988812164116189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725068939171019d, y: 0.5890252729679719d), new NpgsqlTypes.NpgsqlPoint(x: 0.31507604842094683d, y: 0.07981785337161373d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49956635480661005d, y: 0.3238602516068342d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394491410439694d, y: 0.9931627249860187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609168219816716d, y: 0.018515466187586593d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477948424798246d, y: 0.22448688613768575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331553710756616d, y: 0.677684148959098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578017043319507d, y: 0.5884312704825327d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3253535482469895d, y: 0.08943028862493219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909709837075972d, y: 0.8239151142072196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544226447151633d, y: 0.04590731069917675d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.531711168628735d, y: 0.4072739451965294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357002079167353d, y: 0.9954085348573675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096332221052772d, y: 0.6307106642409245d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3897218206640516d, y: 0.26486260614840096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629332827770182d, y: 0.4138776075575772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885344807941253d, y: 0.8977377406600535d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9828634835458117d, y: 0.31863257146949986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060199096658561d, y: 0.8622844573189969d), new NpgsqlTypes.NpgsqlPoint(x: 0.281694080002593d, y: 0.33429690038916393d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24142479290247376d, y: 0.5487913041275767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856004115509795d, y: 0.020205856467602756d), new NpgsqlTypes.NpgsqlPoint(x: 0.1656048181351496d, y: 0.3256900651120921d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49265579093873246d, y: 0.22210978343015975d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125027332490996d, y: 0.9629045342975875d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014046466268081d, y: 0.051911951583694105d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022990213760733d, y: 0.09031097942962196d), new NpgsqlTypes.NpgsqlPoint(x: 0.27213603834432065d, y: 0.8773523895576237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485714460868667d, y: 0.638911337692542d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8499111429099017d, y: 0.8257891624151252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179028911989616d, y: 0.6163707380796175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194922787636284d, y: 0.8759614137687683d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3275894769989983d, y: 0.689562064341376d), new NpgsqlTypes.NpgsqlPoint(x: 0.57045783116206d, y: 0.008253788656068184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696655317850066d, y: 0.6259449978979577d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17760669009480723d, y: 0.8670331189463415d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466845496584884d, y: 0.9401823129418212d), new NpgsqlTypes.NpgsqlPoint(x: 0.10856570697971846d, y: 0.5685556021880557d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5808993388880154d, y: 0.22144122698307123d), new NpgsqlTypes.NpgsqlPoint(x: 0.0905460853458171d, y: 0.18908641521758773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029423149714316d, y: 0.42122340299701466d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14670466842567564d, y: 0.9772651790306214d), new NpgsqlTypes.NpgsqlPoint(x: 0.35051410585471854d, y: 0.35164214433193863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4525822586953703d, y: 0.05606243329586891d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03348609440805206d, y: 0.9830288310569116d), new NpgsqlTypes.NpgsqlPoint(x: 0.17432980878902926d, y: 0.39670978555534786d), new NpgsqlTypes.NpgsqlPoint(x: 0.10432982824732973d, y: 0.167621886955434d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6777857701389702d, y: 0.5347401490964715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133103683414089d, y: 0.22353652702544136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601450023418311d, y: 0.595248509747635d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8029729848740058d, y: 0.38095882651732804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374168998387217d, y: 0.28608405545922055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900967610474563d, y: 0.010156177103194386d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5903218903955727d, y: 0.613029687562407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932686952678457d, y: 0.1715154815549198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8129836698274526d, y: 0.830123438889477d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590744336160716d, y: 0.228736162664687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274277023746199d, y: 0.11305288521917811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573112845391754d, y: 0.7941408486411161d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.941788705070168d, y: 0.7420364282932943d), new NpgsqlTypes.NpgsqlPoint(x: 0.4148672363406891d, y: 0.8751547971318265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010018019302991d, y: 0.8837209124922859d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.488035557724359d, y: 0.7754209178346392d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388596878285642d, y: 0.8576682375931791d), new NpgsqlTypes.NpgsqlPoint(x: 0.2895742465807327d, y: 0.47438902698460084d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5837892664226313d, y: 0.9020832452103541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982598611059297d, y: 0.18440428495833772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529171107264912d, y: 0.022254074399918555d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9425299345955871d, y: 0.4313924552979218d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542400351056592d, y: 0.6638779902828819d), new NpgsqlTypes.NpgsqlPoint(x: 0.36681903023534d, y: 0.9205432048852158d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9030294625395692d, y: 0.00490524284369287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957019272782032d, y: 0.05725895959409322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389317503273786d, y: 0.6402146052593728d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42162933938403657d, y: 0.45933938341872993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734328274636806d, y: 0.864528346725586d), new NpgsqlTypes.NpgsqlPoint(x: 0.19445367952815584d, y: 0.17801118104947655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14463179002235682d, y: 0.4020876768856575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334650526749708d, y: 0.4949808602575144d), new NpgsqlTypes.NpgsqlPoint(x: 0.984432535726885d, y: 0.6606503305145429d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3597158918719028d, y: 0.6366659336903562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728146865449082d, y: 0.6009297635359397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375050615487762d, y: 0.7274889096318096d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0534746559281194d, y: 0.3365016751257148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553306848279595d, y: 0.9728022329775157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654313342975692d, y: 0.9584147963415532d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2301327422068603d, y: 0.31289018181597195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235280401437046d, y: 0.799927430265658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940082767796955d, y: 0.6954175541265964d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07251774710576853d, y: 0.2684983512633028d), new NpgsqlTypes.NpgsqlPoint(x: 0.668252167375124d, y: 0.5461842127669907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070513849792036d, y: 0.8790868191885038d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5998721132249853d, y: 0.24801047433073975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335256506239341d, y: 0.7811387688546667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390596073609111d, y: 0.10848776305004593d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5002065891957885d, y: 0.24326569671305687d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511543888272159d, y: 0.24974060621825034d), new NpgsqlTypes.NpgsqlPoint(x: 0.15652118620045563d, y: 0.06657796422786122d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7915233804924722d, y: 0.37596105104189437d), new NpgsqlTypes.NpgsqlPoint(x: 0.41094310861593886d, y: 0.6596365801181094d), new NpgsqlTypes.NpgsqlPoint(x: 0.15023303390284348d, y: 0.062276091503468356d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5475284585986018d, y: 0.06134262249596201d), new NpgsqlTypes.NpgsqlPoint(x: 0.08149552694608042d, y: 0.7889332025093468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686179812065036d, y: 0.1927249576558402d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7538894279820034d, y: 0.9812983600926166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863216073963943d, y: 0.6423992122646082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2027545679277617d, y: 0.9182644131193952d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4495067204678821d, y: 0.3476002601431507d), new NpgsqlTypes.NpgsqlPoint(x: 0.03385325577726217d, y: 0.7759814476539633d), new NpgsqlTypes.NpgsqlPoint(x: 0.26637123991629985d, y: 0.8739636080067572d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15468409524022697d, y: 0.9383674660568853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469637969181072d, y: 0.1871875452535876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9979045921489732d, y: 0.8694289008780619d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038178826791904874d, y: 0.45825778786319327d), new NpgsqlTypes.NpgsqlPoint(x: 0.10851572616676541d, y: 0.5350729028238127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853739655952862d, y: 0.43452646920992644d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.187346947890205d, y: 0.9331510288610391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411433440839748d, y: 0.25826612237167035d), new NpgsqlTypes.NpgsqlPoint(x: 0.36016822216739786d, y: 0.8347903801970022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20344239209454673d, y: 0.9690712865553058d), new NpgsqlTypes.NpgsqlPoint(x: 0.35068964734857755d, y: 0.8840953624685626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672516756448686d, y: 0.0403626897159437d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30500581840394103d, y: 0.24719921702627845d), new NpgsqlTypes.NpgsqlPoint(x: 0.026941426122726764d, y: 0.516878531061996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241297663710556d, y: 0.6282097516484395d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4076306031714574d, y: 0.40320132143258913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781982678204563d, y: 0.733260079118118d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323705877899851d, y: 0.6815676828238694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3450069048008324d, y: 0.9897469004547611d), new NpgsqlTypes.NpgsqlPoint(x: 0.05111316977380587d, y: 0.5306342304679359d), new NpgsqlTypes.NpgsqlPoint(x: 0.24079483381712752d, y: 0.8680019533639897d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7623839843878456d, y: 0.9193061532808959d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186052723711295d, y: 0.5073822792233246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638276202552711d, y: 0.6040089947236239d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7202320842754043d, y: 0.5760684115795004d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521830106970903d, y: 0.009337572893359902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7672888667446705d, y: 0.6681154923357747d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3053649457580291d, y: 0.2677071664939762d), new NpgsqlTypes.NpgsqlPoint(x: 0.04546221625624858d, y: 0.7362422385037031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532765845112062d, y: 0.10347343712618062d)))));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28831300195344d, y: 0.0929748172184065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729377503316047d, y: 0.9464436596097247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2481112567317576d, y: 0.26392397303159065d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77724645128919d, y: 0.016227515368352208d), new NpgsqlTypes.NpgsqlPoint(x: 0.26358336685075145d, y: 0.22177412050133005d), new NpgsqlTypes.NpgsqlPoint(x: 0.12607769854135076d, y: 0.7165216148849481d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38339116548650987d, y: 0.5415867879168583d), new NpgsqlTypes.NpgsqlPoint(x: 0.315380203267117d, y: 0.4905455849029532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194583584522468d, y: 0.7216909527534081d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11076308456254669d, y: 0.12160853828911833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222087068660112d, y: 0.026109044433501594d), new NpgsqlTypes.NpgsqlPoint(x: 0.48870150574658877d, y: 0.4104302704125685d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906641768857171d, y: 0.4467121244706509d), new NpgsqlTypes.NpgsqlPoint(x: 0.5520525562015579d, y: 0.49921836152985577d), new NpgsqlTypes.NpgsqlPoint(x: 0.2668804076703267d, y: 0.18768766776217805d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41601587122938377d, y: 0.37940311970794605d), new NpgsqlTypes.NpgsqlPoint(x: 0.31891912132907285d, y: 0.7267806454699454d), new NpgsqlTypes.NpgsqlPoint(x: 0.10754274391749641d, y: 0.037050411125227556d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4633397152076223d, y: 0.9886417951017633d), new NpgsqlTypes.NpgsqlPoint(x: 0.2422224506986682d, y: 0.28028157818148147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364224365530413d, y: 0.07340039323851733d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3552949751244383d, y: 0.5019669096647902d), new NpgsqlTypes.NpgsqlPoint(x: 0.750500293181955d, y: 0.5395638393590673d), new NpgsqlTypes.NpgsqlPoint(x: 0.48433028194043404d, y: 0.5141560500992332d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7105154890739028d, y: 0.7580154044718805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3013613547242767d, y: 0.8161196849842075d), new NpgsqlTypes.NpgsqlPoint(x: 0.14691487846466222d, y: 0.3330402881585043d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5984255034896624d, y: 0.02076928268754974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006040272184959d, y: 0.3271636600116107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746769468076411d, y: 0.48765430860876335d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6614018539150084d, y: 0.48893577702038193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202785371335617d, y: 0.7913793873902799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7173641907132036d, y: 0.6822394459474836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2890596461861711d, y: 0.844308945823373d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317563192650613d, y: 0.16141889087041206d), new NpgsqlTypes.NpgsqlPoint(x: 0.1548827707338094d, y: 0.0036357788742638064d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611900189310911d, y: 0.8685666646806884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837934194846987d, y: 0.736202608643477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690010093364385d, y: 0.6073896984997524d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7870139566464146d, y: 0.4419432311203253d), new NpgsqlTypes.NpgsqlPoint(x: 0.05815851164209218d, y: 0.2363902515947106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135238912399938d, y: 0.2590833509440881d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047891679742668725d, y: 0.465598781423018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9332993971699387d, y: 0.5312600122661618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516759039643164d, y: 0.5297206682223973d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6764512115245349d, y: 0.8870479649025143d), new NpgsqlTypes.NpgsqlPoint(x: 0.012801610529443619d, y: 0.054759425950354546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382377548756228d, y: 0.9917795023400938d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2274206264369475d, y: 0.03175457518059166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079875475600382d, y: 0.14220374515772405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426045209733511d, y: 0.34406121727801087d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4094407649250199d, y: 0.8589237692191429d), new NpgsqlTypes.NpgsqlPoint(x: 0.42628063375666425d, y: 0.4412829516702178d), new NpgsqlTypes.NpgsqlPoint(x: 0.12055969365453656d, y: 0.6864163500881508d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4505654199202812d, y: 0.8051926778227086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922538432059608d, y: 0.7279848982781268d), new NpgsqlTypes.NpgsqlPoint(x: 0.17838654791652397d, y: 0.3229287860486826d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6071361554635768d, y: 0.23955141319908202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645056189079881d, y: 0.9330702780975464d), new NpgsqlTypes.NpgsqlPoint(x: 0.1002238066490595d, y: 0.9822097751799667d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787249371219273d, y: 0.41577484871624437d), new NpgsqlTypes.NpgsqlPoint(x: 0.485747266191652d, y: 0.9099158228406726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45233186905477984d, y: 0.5311992212897457d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46982006051530745d, y: 0.2176338130913924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226504075648116d, y: 0.16568124544928065d), new NpgsqlTypes.NpgsqlPoint(x: 0.458031414814456d, y: 0.4050073710526907d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08727409216142346d, y: 0.6988812164116189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725068939171019d, y: 0.5890252729679719d), new NpgsqlTypes.NpgsqlPoint(x: 0.31507604842094683d, y: 0.07981785337161373d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49956635480661005d, y: 0.3238602516068342d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394491410439694d, y: 0.9931627249860187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609168219816716d, y: 0.018515466187586593d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477948424798246d, y: 0.22448688613768575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331553710756616d, y: 0.677684148959098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578017043319507d, y: 0.5884312704825327d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3253535482469895d, y: 0.08943028862493219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909709837075972d, y: 0.8239151142072196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544226447151633d, y: 0.04590731069917675d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.531711168628735d, y: 0.4072739451965294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357002079167353d, y: 0.9954085348573675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096332221052772d, y: 0.6307106642409245d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3897218206640516d, y: 0.26486260614840096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629332827770182d, y: 0.4138776075575772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885344807941253d, y: 0.8977377406600535d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9828634835458117d, y: 0.31863257146949986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060199096658561d, y: 0.8622844573189969d), new NpgsqlTypes.NpgsqlPoint(x: 0.281694080002593d, y: 0.33429690038916393d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24142479290247376d, y: 0.5487913041275767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856004115509795d, y: 0.020205856467602756d), new NpgsqlTypes.NpgsqlPoint(x: 0.1656048181351496d, y: 0.3256900651120921d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49265579093873246d, y: 0.22210978343015975d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125027332490996d, y: 0.9629045342975875d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014046466268081d, y: 0.051911951583694105d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022990213760733d, y: 0.09031097942962196d), new NpgsqlTypes.NpgsqlPoint(x: 0.27213603834432065d, y: 0.8773523895576237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485714460868667d, y: 0.638911337692542d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8499111429099017d, y: 0.8257891624151252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179028911989616d, y: 0.6163707380796175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194922787636284d, y: 0.8759614137687683d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3275894769989983d, y: 0.689562064341376d), new NpgsqlTypes.NpgsqlPoint(x: 0.57045783116206d, y: 0.008253788656068184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696655317850066d, y: 0.6259449978979577d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17760669009480723d, y: 0.8670331189463415d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466845496584884d, y: 0.9401823129418212d), new NpgsqlTypes.NpgsqlPoint(x: 0.10856570697971846d, y: 0.5685556021880557d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5808993388880154d, y: 0.22144122698307123d), new NpgsqlTypes.NpgsqlPoint(x: 0.0905460853458171d, y: 0.18908641521758773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029423149714316d, y: 0.42122340299701466d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14670466842567564d, y: 0.9772651790306214d), new NpgsqlTypes.NpgsqlPoint(x: 0.35051410585471854d, y: 0.35164214433193863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4525822586953703d, y: 0.05606243329586891d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03348609440805206d, y: 0.9830288310569116d), new NpgsqlTypes.NpgsqlPoint(x: 0.17432980878902926d, y: 0.39670978555534786d), new NpgsqlTypes.NpgsqlPoint(x: 0.10432982824732973d, y: 0.167621886955434d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6777857701389702d, y: 0.5347401490964715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133103683414089d, y: 0.22353652702544136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601450023418311d, y: 0.595248509747635d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8029729848740058d, y: 0.38095882651732804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374168998387217d, y: 0.28608405545922055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900967610474563d, y: 0.010156177103194386d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5903218903955727d, y: 0.613029687562407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932686952678457d, y: 0.1715154815549198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8129836698274526d, y: 0.830123438889477d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590744336160716d, y: 0.228736162664687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274277023746199d, y: 0.11305288521917811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573112845391754d, y: 0.7941408486411161d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.941788705070168d, y: 0.7420364282932943d), new NpgsqlTypes.NpgsqlPoint(x: 0.4148672363406891d, y: 0.8751547971318265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010018019302991d, y: 0.8837209124922859d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.488035557724359d, y: 0.7754209178346392d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388596878285642d, y: 0.8576682375931791d), new NpgsqlTypes.NpgsqlPoint(x: 0.2895742465807327d, y: 0.47438902698460084d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5837892664226313d, y: 0.9020832452103541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982598611059297d, y: 0.18440428495833772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529171107264912d, y: 0.022254074399918555d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9425299345955871d, y: 0.4313924552979218d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542400351056592d, y: 0.6638779902828819d), new NpgsqlTypes.NpgsqlPoint(x: 0.36681903023534d, y: 0.9205432048852158d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9030294625395692d, y: 0.00490524284369287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957019272782032d, y: 0.05725895959409322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389317503273786d, y: 0.6402146052593728d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42162933938403657d, y: 0.45933938341872993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734328274636806d, y: 0.864528346725586d), new NpgsqlTypes.NpgsqlPoint(x: 0.19445367952815584d, y: 0.17801118104947655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14463179002235682d, y: 0.4020876768856575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334650526749708d, y: 0.4949808602575144d), new NpgsqlTypes.NpgsqlPoint(x: 0.984432535726885d, y: 0.6606503305145429d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3597158918719028d, y: 0.6366659336903562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728146865449082d, y: 0.6009297635359397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375050615487762d, y: 0.7274889096318096d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0534746559281194d, y: 0.3365016751257148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553306848279595d, y: 0.9728022329775157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654313342975692d, y: 0.9584147963415532d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2301327422068603d, y: 0.31289018181597195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235280401437046d, y: 0.799927430265658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940082767796955d, y: 0.6954175541265964d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07251774710576853d, y: 0.2684983512633028d), new NpgsqlTypes.NpgsqlPoint(x: 0.668252167375124d, y: 0.5461842127669907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070513849792036d, y: 0.8790868191885038d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5998721132249853d, y: 0.24801047433073975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335256506239341d, y: 0.7811387688546667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390596073609111d, y: 0.10848776305004593d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5002065891957885d, y: 0.24326569671305687d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511543888272159d, y: 0.24974060621825034d), new NpgsqlTypes.NpgsqlPoint(x: 0.15652118620045563d, y: 0.06657796422786122d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7915233804924722d, y: 0.37596105104189437d), new NpgsqlTypes.NpgsqlPoint(x: 0.41094310861593886d, y: 0.6596365801181094d), new NpgsqlTypes.NpgsqlPoint(x: 0.15023303390284348d, y: 0.062276091503468356d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5475284585986018d, y: 0.06134262249596201d), new NpgsqlTypes.NpgsqlPoint(x: 0.08149552694608042d, y: 0.7889332025093468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686179812065036d, y: 0.1927249576558402d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7538894279820034d, y: 0.9812983600926166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863216073963943d, y: 0.6423992122646082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2027545679277617d, y: 0.9182644131193952d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4495067204678821d, y: 0.3476002601431507d), new NpgsqlTypes.NpgsqlPoint(x: 0.03385325577726217d, y: 0.7759814476539633d), new NpgsqlTypes.NpgsqlPoint(x: 0.26637123991629985d, y: 0.8739636080067572d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15468409524022697d, y: 0.9383674660568853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469637969181072d, y: 0.1871875452535876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9979045921489732d, y: 0.8694289008780619d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038178826791904874d, y: 0.45825778786319327d), new NpgsqlTypes.NpgsqlPoint(x: 0.10851572616676541d, y: 0.5350729028238127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853739655952862d, y: 0.43452646920992644d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.187346947890205d, y: 0.9331510288610391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411433440839748d, y: 0.25826612237167035d), new NpgsqlTypes.NpgsqlPoint(x: 0.36016822216739786d, y: 0.8347903801970022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20344239209454673d, y: 0.9690712865553058d), new NpgsqlTypes.NpgsqlPoint(x: 0.35068964734857755d, y: 0.8840953624685626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672516756448686d, y: 0.0403626897159437d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30500581840394103d, y: 0.24719921702627845d), new NpgsqlTypes.NpgsqlPoint(x: 0.026941426122726764d, y: 0.516878531061996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241297663710556d, y: 0.6282097516484395d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4076306031714574d, y: 0.40320132143258913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781982678204563d, y: 0.733260079118118d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323705877899851d, y: 0.6815676828238694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3450069048008324d, y: 0.9897469004547611d), new NpgsqlTypes.NpgsqlPoint(x: 0.05111316977380587d, y: 0.5306342304679359d), new NpgsqlTypes.NpgsqlPoint(x: 0.24079483381712752d, y: 0.8680019533639897d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7623839843878456d, y: 0.9193061532808959d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186052723711295d, y: 0.5073822792233246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638276202552711d, y: 0.6040089947236239d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7202320842754043d, y: 0.5760684115795004d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521830106970903d, y: 0.009337572893359902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7672888667446705d, y: 0.6681154923357747d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3053649457580291d, y: 0.2677071664939762d), new NpgsqlTypes.NpgsqlPoint(x: 0.04546221625624858d, y: 0.7362422385037031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532765845112062d, y: 0.10347343712618062d)))));//InnerModel.NullableValue

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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

