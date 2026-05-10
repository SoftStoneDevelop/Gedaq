

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5042000556488792d, y: 0.8736241076609191d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6203845726706474d, y: 0.7470696063106547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.733848924421366d, y: 0.8244300716805651d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3394940827128843d, y: 0.1177494449479809d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9739546584358673d, y: 0.36759041329739794d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30725593633803416d, y: 0.5236782149342275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4333022617274285d, y: 0.48859003469758344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8929833243788026d, y: 0.35031737031600685d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1835717497432764d, y: 0.2091043359937984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2210871006538947d, y: 0.9360400260755869d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5279987101002154d, y: 0.1437566595935299d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.86975214616165d, y: 0.128303970836131d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19958894042329733d, y: 0.6825947993870205d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7646695996826162d, y: 0.045631965056392776d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7385358574565812d, y: 0.39762562894020703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6727850875842076d, y: 0.5599105243288329d),
new NpgsqlTypes.NpgsqlPoint(x: 0.759303415543269d, y: 0.07787420572464021d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38880656177094874d, y: 0.17105098022453125d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.730666714045051d, y: 0.3880674122449258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1410296162294684d, y: 0.805274810123211d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8977059174886962d, y: 0.0020466210189507006d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6939654047345818d, y: 0.6322993095655042d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8418872204459452d, y: 0.03313875596363847d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6963020448394664d, y: 0.2353906954819529d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0833648626055361d, y: 0.9471741822886306d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2852376110622228d, y: 0.22975697250563065d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9209787027938844d, y: 0.030472832737922784d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2631812003586895d, y: 0.7328057733316738d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5636977849473533d, y: 0.25486290494768604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7816752561060208d, y: 0.8876025825234993d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4120849804771516d, y: 0.7212903359020049d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4314764487133026d, y: 0.6834058203128179d),
new NpgsqlTypes.NpgsqlPoint(x: 0.011728413219943112d, y: 0.5825886033247346d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5115980689167439d, y: 0.20858932189271162d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1461623056822554d, y: 0.7983051769850862d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7733085778935266d, y: 0.5329519768549418d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34100043121900525d, y: 0.9188313666977814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26047086807659015d, y: 0.9236454192466123d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33519206743179697d, y: 0.04397020802857865d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41346498597905224d, y: 0.8257010842164576d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5850788103448679d, y: 0.9843038640746904d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8668046714674951d, y: 0.05206556561349995d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10721459789791776d, y: 0.6941252772573945d),
new NpgsqlTypes.NpgsqlPoint(x: 0.288881736655729d, y: 0.17637999580294428d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33555752145526463d, y: 0.709644572313043d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6242127358026491d, y: 0.3269285783893534d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7247610113176197d, y: 0.09131555830056914d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20811620403889264d, y: 0.9533936949667096d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2748723207836078d, y: 0.8010398052595427d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11357469367454032d, y: 0.6199445682762974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7464902635298909d, y: 0.21245661378532144d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38321308382994135d, y: 0.15910184352359036d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28937336705724137d, y: 0.39894837917400294d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2911079222053685d, y: 0.04423819992946432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.936425209074292d, y: 0.6113854464758893d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6886376481552116d, y: 0.10881875660961415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9847134793732014d, y: 0.09277848641048025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3296828424169519d, y: 0.3341007992893884d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.705376464534671d, y: 0.4889281247959355d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9217646800181517d, y: 0.5248577787487926d),
new NpgsqlTypes.NpgsqlPoint(x: 0.781296395980815d, y: 0.08419005204245822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36114002888838215d, y: 0.5313037907904959d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47569771541337214d, y: 0.7214775756036549d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16048710484284523d, y: 0.15868353642001953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7555541499678166d, y: 0.8111816863060344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9934410130686843d, y: 0.6095695956775303d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8469902294461765d, y: 0.8806748232478127d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9450246050565912d, y: 0.5982289447470125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7617343095097008d, y: 0.41872836844684d),
new NpgsqlTypes.NpgsqlPoint(x: 0.047437489512244135d, y: 0.7026186155059337d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4019899096517251d, y: 0.47135671683277425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5448193493593451d, y: 0.08526195971085448d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33409453497785124d, y: 0.8996635547809884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6198660615247638d, y: 0.4723007589908237d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42479750951157436d, y: 0.7936515902880742d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8850015119357509d, y: 0.20388751470899857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8036526207923309d, y: 0.27559929529716987d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5901090553845365d, y: 0.32170118981091744d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11450685451453502d, y: 0.28331520972373236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1209237516685675d, y: 0.43742378581741004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09054335945079872d, y: 0.6211346190043995d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.557474054079752d, y: 0.2892617846740476d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5849200598277531d, y: 0.3431967350616315d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7299695295966582d, y: 0.6717031336705815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1908176371219834d, y: 0.5441265435379008d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4023384749587178d, y: 0.7375250692627354d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4775096635540199d, y: 0.6230078812188693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8867838887494898d, y: 0.7504953932997175d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42637600046854074d, y: 0.6937155326495463d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5028610047041872d, y: 0.021975458309875573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6752245159043001d, y: 0.6466814243125808d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12282920026053756d, y: 0.821124371894172d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.975374965624085d, y: 0.4671378695518047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04674608905210065d, y: 0.49971512319861877d),
new NpgsqlTypes.NpgsqlPoint(x: 0.679979857852228d, y: 0.7364873514731775d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5031107152608503d, y: 0.49753852623390804d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33743910980558234d, y: 0.6415709758320386d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5525215804760234d, y: 0.5731771771693881d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5040413653318916d, y: 0.48132717048246487d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.005648837503279602d, y: 0.49359876605627595d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8669443978605675d, y: 0.7321616547467049d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7757126985099403d, y: 0.5318843161053651d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6418813563814431d, y: 0.11327620590801712d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03278700612752805d, y: 0.9933780505213898d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2565387766028223d, y: 0.5609630752943553d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6443201600435561d, y: 0.5806714117953861d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7913237509101494d, y: 0.9369173145549315d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4911454823640875d, y: 0.41399663282626376d),
new NpgsqlTypes.NpgsqlPoint(x: 0.401303599590739d, y: 0.7714252123904453d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9456540478842508d, y: 0.27657787830655667d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25563649459513094d, y: 0.32323889705713793d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9645756654122587d, y: 0.6642413167957645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9853426502292454d, y: 0.7116594291708256d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19811800398163082d, y: 0.24791380478716274d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6094454455948447d, y: 0.36600489981918594d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10187977152264138d, y: 0.7560535776297218d),
new NpgsqlTypes.NpgsqlPoint(x: 0.926500875730984d, y: 0.7483346921721017d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23615698142959618d, y: 0.02730565277542807d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24383950044190494d, y: 0.8305460150959468d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1789328302697153d, y: 0.7965992713162886d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7552740834246349d, y: 0.9396204534119665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3547077735008368d, y: 0.625322236145884d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6803166648874305d, y: 0.16075147289682956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9160617740846526d, y: 0.4578537370077447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5890739427438397d, y: 0.9413565187535993d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6653324403429037d, y: 0.6728638280874432d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8468738705144212d, y: 0.6708706342306794d),
new NpgsqlTypes.NpgsqlPoint(x: 0.033236158046660136d, y: 0.6652952874342799d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7310299090432252d, y: 0.3537514803608043d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8099019991876357d, y: 0.4721631689107696d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8768691155654353d, y: 0.579529025308481d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46919440778808275d, y: 0.12838249266200163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5413625822638055d, y: 0.5930789934559227d),
new NpgsqlTypes.NpgsqlPoint(x: 0.600516079022571d, y: 0.2553665896959263d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8171266315166297d, y: 0.47364516001232204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.517710612352781d, y: 0.004624097798824667d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22685487813807026d, y: 0.9890664144160403d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.732125337492188d, y: 0.7995328124094315d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03197433751391543d, y: 0.43490447791688225d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9457250029506276d, y: 0.7776304580057091d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14686157221403462d, y: 0.03225897113687615d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32898494596501004d, y: 0.1508232954966423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9988730730499763d, y: 0.3977180457163534d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6141575320746027d, y: 0.37519841598575454d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.790276156365342d, y: 0.43707785592387327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04278248275420227d, y: 0.7099173648830125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6058998783208142d, y: 0.0031497576753150014d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7519422673413552d, y: 0.2444855781515307d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8348463383009262d, y: 0.7991793508267374d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5298757487128245d, y: 0.9800340533548499d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6744314627807667d, y: 0.8770031384548506d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.035754476736716945d, y: 0.21652226508608996d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1615581227567403d, y: 0.7292034872576261d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4100832591203998d, y: 0.7594090378214701d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6508193481949609d, y: 0.9896071312381961d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8505436354530611d, y: 0.6439701438815045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12046105137361163d, y: 0.14430249089705505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.638217798465465d, y: 0.5618245768704248d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3083332964074387d, y: 0.4644895034804193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4390410817060073d, y: 0.5198044557381527d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9751707088926032d, y: 0.06320198194517401d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7388967197454774d, y: 0.13774084522846297d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14721007664802643d, y: 0.6804808603468111d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6139442982023786d, y: 0.25922174025650724d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2814939543385361d, y: 0.8105102163037643d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4401753147094819d, y: 0.5784363918841677d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5755924400645845d, y: 0.5576991729696293d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3580955478811425d, y: 0.3981192621871348d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31044297160818357d, y: 0.32898766988122186d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5636811583840735d, y: 0.9422119533027196d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1393983193524282d, y: 0.9179079679868216d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24674777964706418d, y: 0.018787901588359746d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8012411649464033d, y: 0.9150545516205763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12211552644944679d, y: 0.4639776572552421d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9378240459746476d, y: 0.25250048400699876d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7941511492608698d, y: 0.14056805240308157d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8914309120356226d, y: 0.10201911205791803d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11709557308861174d, y: 0.7205776226106515d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3910990967832284d, y: 0.11026061875569204d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.804520045596308d, y: 0.8545153896381065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3071677148455322d, y: 0.8392348263219725d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3059001067568383d, y: 0.9689402954979588d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12525368181500363d, y: 0.026819447147365394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8810409545424652d, y: 0.4853236612209042d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06451002132277595d, y: 0.14936150938796877d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11804601379096424d, y: 0.2716605945075764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7611558759648901d, y: 0.38450539393375516d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6338247810298026d, y: 0.8270645616073834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19405204545940002d, y: 0.31584879916670205d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2802581317029562d, y: 0.01974133871170125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12407305479942432d, y: 0.8282866214102065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4387989827161364d, y: 0.3252405668187349d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1419493102691013d, y: 0.9345184312184265d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4915038497054818d, y: 0.975808297559152d),
new NpgsqlTypes.NpgsqlPoint(x: 0.453495809256963d, y: 0.4774695460284706d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9657666230322376d, y: 0.25906999701059075d),
new NpgsqlTypes.NpgsqlPoint(x: 0.059870433808817736d, y: 0.36770954583940063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.499677111708993d, y: 0.5550413079281833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49105711222410486d, y: 0.42542247271896616d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3176095811194519d, y: 0.018307639896802064d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9307703045190528d, y: 0.175999763885744d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33662564608778667d, y: 0.922580094627761d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8489585831345933d, y: 0.2969922140099599d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2602117292097068d, y: 0.8089451961094499d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4261204135597496d, y: 0.5979588585858999d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1303909796652435d, y: 0.1751642135475131d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32891585923139643d, y: 0.23735092494565446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9279626293369643d, y: 0.2560223023214009d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6577320097888925d, y: 0.2955076236328573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2506903315098389d, y: 0.06942357818928713d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3463996569469975d, y: 0.6744974277875843d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5794843188157536d, y: 0.5551417857022117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2178651339788027d, y: 0.17123093195048156d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8480664036285603d, y: 0.789253765515612d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8701574823079171d, y: 0.4590149429074065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34581537922963623d, y: 0.7022294962551655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7837968710787558d, y: 0.3316290599962466d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8984913735513482d, y: 0.8636242980505858d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5449249390515241d, y: 0.7919060884979058d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47244720919084604d, y: 0.7763806155103388d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10067624884436044d, y: 0.4317606171671634d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9230844844131362d, y: 0.8230148248192338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4029758204184062d, y: 0.08933089642644221d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7845449726377639d, y: 0.1697678757533907d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06353334628005602d, y: 0.6929987036716869d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37286116380022216d, y: 0.9261204720125618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16897806315327957d, y: 0.28077732864195526d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9556583712956268d, y: 0.41188077810163426d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2593496935284365d, y: 0.9581302881607769d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36566034630806055d, y: 0.15977635694602188d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5747995715584773d, y: 0.37609444811521464d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08547453330867427d, y: 0.029555270152203494d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.76885580477088d, y: 0.5345473425975872d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15243007024741329d, y: 0.21027654249010652d),
new NpgsqlTypes.NpgsqlPoint(x: 0.942512238428939d, y: 0.8036757934108447d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6060886495780864d, y: 0.19421162333659847d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7854523575670984d, y: 0.11331628092724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8224690262713996d, y: 0.6795871220404439d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36457731213283673d, y: 0.3268146772587397d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7263297943142045d, y: 0.4337982161548991d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6202585131924897d, y: 0.255044360696712d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6932393666980182d, y: 0.40182849160066725d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4025378631710298d, y: 0.8126849161051055d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1755830575614422d, y: 0.5841627728032488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8784345156887868d, y: 0.11394973572345934d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9727369679188578d, y: 0.36876494248117375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8044607990716588d, y: 0.34477499582814763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6276273167064018d, y: 0.42321450236055425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5938295435811617d, y: 0.2423826066568483d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5538451432171722d, y: 0.7687000752677066d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7851955148027588d, y: 0.8334819494174199d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6304383230126949d, y: 0.19064143948494272d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9385024328147352d, y: 0.5992965736219981d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4914361266006858d, y: 0.9985842243986285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6862163729551173d, y: 0.6426557828800307d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.770293756048601d, y: 0.8287653661790526d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22607320195788316d, y: 0.11505196905022952d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6784395259140664d, y: 0.054192919554139074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23125771105553383d, y: 0.4084830009591798d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.838109765395008d, y: 0.6090002003058477d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48348439444085267d, y: 0.998112471531929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2829398889237169d, y: 0.4674223597478745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5630796220637888d, y: 0.6844817300761508d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2891970780409978d, y: 0.3998720645595133d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08699366395331831d, y: 0.06413901002130229d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12559711331686396d, y: 0.02857824615779392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24722102858343864d, y: 0.8882379002493441d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12370774303887411d, y: 0.32869814102498096d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10169274303933262d, y: 0.33888246920182896d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08285628450569027d, y: 0.18684629648764206d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.283505932789305d, y: 0.25835642634504397d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8837706923211512d, y: 0.48882171907180894d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3626075396943278d, y: 0.5185375124177668d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7136972132503534d, y: 0.6627398320885458d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5370781550420989d, y: 0.6467963675807359d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7520796171409543d, y: 0.5152991001298671d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7958597872761407d, y: 0.6959193408616441d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 187,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22558220710476895d, y: 0.6672591588515275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7040969422515017d, y: 0.011611439538027568d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9944438532796859d, y: 0.6250777322509801d),
new NpgsqlTypes.NpgsqlPoint(x: 0.911357867939096d, y: 0.9863703081483943d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21917903054258003d, y: 0.753741647738338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9625268297239634d, y: 0.5855738929335941d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2317807833220572d, y: 0.163018701533982d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38834699424270214d, y: 0.22204006564669443d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 196,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6206821733040079d, y: 0.42099639289733537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5898229528478245d, y: 0.8335456104658024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3246939561490464d, y: 0.4129695676149536d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33555752145526463d, y: 0.709644572313043d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6242127358026491d, y: 0.3269285783893534d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7247610113176197d, y: 0.09131555830056914d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20811620403889264d, y: 0.9533936949667096d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47569771541337214d, y: 0.7214775756036549d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16048710484284523d, y: 0.15868353642001953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7555541499678166d, y: 0.8111816863060344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9934410130686843d, y: 0.6095695956775303d),
}));
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5901090553845365d, y: 0.32170118981091744d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11450685451453502d, y: 0.28331520972373236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1209237516685675d, y: 0.43742378581741004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09054335945079872d, y: 0.6211346190043995d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.975374965624085d, y: 0.4671378695518047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04674608905210065d, y: 0.49971512319861877d),
new NpgsqlTypes.NpgsqlPoint(x: 0.679979857852228d, y: 0.7364873514731775d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 177;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 59, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 59, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 170, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 79, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 91, 170))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 79, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 179);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI), typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                await ((INpgsqlPointArraypointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                ((INpgsqlPointArraypointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointArraypointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

