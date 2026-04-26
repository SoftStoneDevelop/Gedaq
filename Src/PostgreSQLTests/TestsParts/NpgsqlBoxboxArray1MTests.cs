

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
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7874197460479232d,right: 0.6071633440702995d,bottom: 0.307333837403476d,left: 0.4753491601801296d),
new NpgsqlTypes.NpgsqlBox(top: 0.290492653354961d,right: 0.42210110461796213d,bottom: 0.12071997785255639d,left: 0.17107993698525115d),
new NpgsqlTypes.NpgsqlBox(top: 0.23287930692618342d,right: 0.9159883260144848d,bottom: 0.13970963931119484d,left: 0.21416559649420797d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7808394394426865d,right: 0.40865584987891324d,bottom: 0.3239649330651604d,left: 0.11133194682544933d),
new NpgsqlTypes.NpgsqlBox(top: 0.5575041282757529d,right: 0.8349251031516759d,bottom: 0.031730016652238624d,left: 0.7905080432862945d),
new NpgsqlTypes.NpgsqlBox(top: 0.8061749449859835d,right: 0.675011571681706d,bottom: 0.2540605310057742d,left: 0.35471577871479365d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.781547340983368d,right: 0.8004562068029921d,bottom: 0.10489641312445552d,left: 0.1621844146062893d),
new NpgsqlTypes.NpgsqlBox(top: 0.9065169881398818d,right: 0.9423514486805641d,bottom: 0.38559190894249695d,left: 0.09248571247857607d),
new NpgsqlTypes.NpgsqlBox(top: 0.6082639889134489d,right: 0.5081753704376771d,bottom: 0.15598989551985587d,left: 0.3896199496310865d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4729012987128455d,right: 0.912164622093869d,bottom: 0.44460009000940337d,left: 0.4163911946159067d),
new NpgsqlTypes.NpgsqlBox(top: 0.06692416873163654d,right: 0.6562144106817975d,bottom: 0.0023778881394659335d,left: 0.43732064533986614d),
new NpgsqlTypes.NpgsqlBox(top: 0.45649792075237805d,right: 0.7808395283884625d,bottom: 0.3883228638834312d,left: 0.06182755234254056d),
new NpgsqlTypes.NpgsqlBox(top: 0.9715493765625527d,right: 0.5786121625065855d,bottom: 0.2880224246788461d,left: 0.4419491276209875d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1559044978284454d,right: 0.7614827694229448d,bottom: 0.0467292019002451d,left: 0.3797400840961729d),
new NpgsqlTypes.NpgsqlBox(top: 0.5641379805560539d,right: 0.43444548193285526d,bottom: 0.14712123628318508d,left: 0.24786768260222503d),
new NpgsqlTypes.NpgsqlBox(top: 0.9395202176170289d,right: 0.653198475104307d,bottom: 0.42389653762111545d,left: 0.16964837678404132d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7400185193746114d,right: 0.9840371102166631d,bottom: 0.6725866729861981d,left: 0.9028265018557112d),
new NpgsqlTypes.NpgsqlBox(top: 0.5494808482966372d,right: 0.5686305726490885d,bottom: 0.519039786808612d,left: 0.16650242362155332d),
new NpgsqlTypes.NpgsqlBox(top: 0.6317343231077267d,right: 0.43343199060784987d,bottom: 0.5806072007892432d,left: 0.171220481787702d),
new NpgsqlTypes.NpgsqlBox(top: 0.7986570008150384d,right: 0.3492283628673444d,bottom: 0.385958290048405d,left: 0.0961062466993835d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8275483985181266d,right: 0.7864549993712225d,bottom: 0.10523170896191669d,left: 0.1975826655559696d),
new NpgsqlTypes.NpgsqlBox(top: 0.75713263831276d,right: 0.3597715461192854d,bottom: 0.3763748298510714d,left: 0.024393729547306675d),
new NpgsqlTypes.NpgsqlBox(top: 0.815624596704052d,right: 0.9730538353385583d,bottom: 0.659629072649415d,left: 0.07834501603345123d),
new NpgsqlTypes.NpgsqlBox(top: 0.9794036180181006d,right: 0.63301353950973d,bottom: 0.045918230572713714d,left: 0.4820620762682739d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47374312597214185d,right: 0.4871667807935839d,bottom: 0.15245337628051636d,left: 0.09221903783730101d),
new NpgsqlTypes.NpgsqlBox(top: 0.959794011163227d,right: 0.7470449751579119d,bottom: 0.10603193515260723d,left: 0.16312948067070632d),
new NpgsqlTypes.NpgsqlBox(top: 0.7740248366981055d,right: 0.8430818668226602d,bottom: 0.12106894094334208d,left: 0.5558502142876999d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7953354782914234d,right: 0.7149486866137876d,bottom: 0.5610319738424945d,left: 0.6151347786912752d),
new NpgsqlTypes.NpgsqlBox(top: 0.5904645439055971d,right: 0.9891552884523312d,bottom: 0.4885022375648814d,left: 0.3312810317979954d),
new NpgsqlTypes.NpgsqlBox(top: 0.8398136079015688d,right: 0.6574701348166079d,bottom: 0.6545642735104287d,left: 0.2709751161647225d),
new NpgsqlTypes.NpgsqlBox(top: 0.8416463988373548d,right: 0.6791437855736299d,bottom: 0.21588057536402816d,left: 0.1096990237468971d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9743300965669793d,right: 0.6504557049025952d,bottom: 0.6189918784063367d,left: 0.4919596613941325d),
new NpgsqlTypes.NpgsqlBox(top: 0.49640316007833885d,right: 0.7203692958634449d,bottom: 0.2939800076291811d,left: 0.11722075049688419d),
new NpgsqlTypes.NpgsqlBox(top: 0.9401174062425924d,right: 0.8556670006682918d,bottom: 0.3270162978725498d,left: 0.19336086784390616d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2124069676565974d,right: 0.9987399850533357d,bottom: 0.15224959177943587d,left: 0.1731014174567862d),
new NpgsqlTypes.NpgsqlBox(top: 0.0879200306091209d,right: 0.9379639470663732d,bottom: 0.08738541010342438d,left: 0.37909178527117304d),
new NpgsqlTypes.NpgsqlBox(top: 0.9470766456150784d,right: 0.40787475042936105d,bottom: 0.9324668972584731d,left: 0.38631961087254174d),
new NpgsqlTypes.NpgsqlBox(top: 0.5245115268019436d,right: 0.7897283186613591d,bottom: 0.44741746270214344d,left: 0.7353924447039158d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.736830680933433d,right: 0.5121004927179126d,bottom: 0.07192978595418209d,left: 0.20395890666545513d),
new NpgsqlTypes.NpgsqlBox(top: 0.1763977391305087d,right: 0.814865418503661d,bottom: 0.1345847374629663d,left: 0.5299673234951244d),
new NpgsqlTypes.NpgsqlBox(top: 0.43335927308163d,right: 0.6937254161413121d,bottom: 0.29896377878018654d,left: 0.5061476614183232d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.523297445391903d,right: 0.7311192593055384d,bottom: 0.011261497125224507d,left: 0.6612810169992169d),
new NpgsqlTypes.NpgsqlBox(top: 0.18070819718739484d,right: 0.453315105969641d,bottom: 0.14484205575493547d,left: 0.17261797962846093d),
new NpgsqlTypes.NpgsqlBox(top: 0.31708690616457413d,right: 0.5032974805029823d,bottom: 0.17839462349238433d,left: 0.3682005168728891d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.11743834680041132d,right: 0.7637216405195223d,bottom: 0.0783535594589354d,left: 0.5978371040137603d),
new NpgsqlTypes.NpgsqlBox(top: 0.12995905225307902d,right: 0.07030158474044579d,bottom: 0.01095067704805841d,left: 0.049220668232159426d),
new NpgsqlTypes.NpgsqlBox(top: 0.8578940707706959d,right: 0.5673074556058664d,bottom: 0.8441560011584861d,left: 0.2351447953059651d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40316161039529796d,right: 0.7771497567923197d,bottom: 0.19112709037232956d,left: 0.13260818922987316d),
new NpgsqlTypes.NpgsqlBox(top: 0.8815709165989437d,right: 0.8026968151905487d,bottom: 0.47910212287037235d,left: 0.3959053984066445d),
new NpgsqlTypes.NpgsqlBox(top: 0.8730687589895062d,right: 0.9379481105628463d,bottom: 0.17164969619010373d,left: 0.08137969911270748d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9842371979469565d,right: 0.9361767534283124d,bottom: 0.5011931067424991d,left: 0.4479638583848178d),
new NpgsqlTypes.NpgsqlBox(top: 0.9507746560548278d,right: 0.9238399666693015d,bottom: 0.6703720341066951d,left: 0.331322835926686d),
new NpgsqlTypes.NpgsqlBox(top: 0.4914252618311785d,right: 0.24988115114282827d,bottom: 0.2707030363815912d,left: 0.11056192950172472d),
new NpgsqlTypes.NpgsqlBox(top: 0.6551769174330674d,right: 0.681090420049626d,bottom: 0.4487974378128129d,left: 0.6573898205713185d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3974624047170352d,right: 0.7577866466295214d,bottom: 0.24411058167346533d,left: 0.5626383185704854d),
new NpgsqlTypes.NpgsqlBox(top: 0.22674255349126482d,right: 0.6654013853774642d,bottom: 0.16671403027305143d,left: 0.5969508199000563d),
new NpgsqlTypes.NpgsqlBox(top: 0.8108993573545153d,right: 0.9556210000675165d,bottom: 0.648024299921122d,left: 0.10090761457671638d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8498494600100771d,right: 0.7253490957627221d,bottom: 0.4727439566205256d,left: 0.5754321289046053d),
new NpgsqlTypes.NpgsqlBox(top: 0.9563567800898898d,right: 0.9871608217926174d,bottom: 0.7711807327456172d,left: 0.5660753493815072d),
new NpgsqlTypes.NpgsqlBox(top: 0.3622754062291662d,right: 0.8739071322376801d,bottom: 0.08689034531041229d,left: 0.1217327188652435d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7245399302156663d,right: 0.5419848258070475d,bottom: 0.6234996843179624d,left: 0.0805007814715496d),
new NpgsqlTypes.NpgsqlBox(top: 0.7613780550392413d,right: 0.13752771004992181d,bottom: 0.35862098440719326d,left: 0.09905488399750773d),
new NpgsqlTypes.NpgsqlBox(top: 0.5467824980376622d,right: 0.9186621211928355d,bottom: 0.4459632416907954d,left: 0.2556464809781518d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6312307799732566d,right: 0.8690690461955176d,bottom: 0.6188391954315027d,left: 0.29902739494369324d),
new NpgsqlTypes.NpgsqlBox(top: 0.3791761383676516d,right: 0.9561592171307964d,bottom: 0.005399053592483716d,left: 0.06011385968797711d),
new NpgsqlTypes.NpgsqlBox(top: 0.8664701334821368d,right: 0.9137943858368696d,bottom: 0.43110791611066057d,left: 0.8038516816791779d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8475056894721689d,right: 0.696879924717179d,bottom: 0.08212907753477972d,left: 0.05151584468731574d),
new NpgsqlTypes.NpgsqlBox(top: 0.2572328889590143d,right: 0.9699195878568176d,bottom: 0.09401088211079911d,left: 0.7107065382972058d),
new NpgsqlTypes.NpgsqlBox(top: 0.7063833122453218d,right: 0.4965619633987879d,bottom: 0.14665100206340098d,left: 0.29095203334089315d),
new NpgsqlTypes.NpgsqlBox(top: 0.8332887609498231d,right: 0.6710041687185805d,bottom: 0.6641313713472732d,left: 0.6291950558518544d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7430322929131581d,right: 0.9802958180841448d,bottom: 0.20856717554412474d,left: 0.26647813156888844d),
new NpgsqlTypes.NpgsqlBox(top: 0.5051149504928963d,right: 0.35491077138292715d,bottom: 0.44587085306274776d,left: 0.3256842021483066d),
new NpgsqlTypes.NpgsqlBox(top: 0.416285561320789d,right: 0.7245969081245021d,bottom: 0.39911773924924576d,left: 0.20242945214432784d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6453858294873304d,right: 0.7668348150460649d,bottom: 0.2034202379208735d,left: 0.6922294841982491d),
new NpgsqlTypes.NpgsqlBox(top: 0.38875003042546763d,right: 0.2957793598159818d,bottom: 0.22447663774864135d,left: 0.12110715016573337d),
new NpgsqlTypes.NpgsqlBox(top: 0.5469615988686531d,right: 0.9173237069842629d,bottom: 0.5319679938412265d,left: 0.17804384705587395d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7691566291734104d,right: 0.8513434245561111d,bottom: 0.652817257045329d,left: 0.3352147502971069d),
new NpgsqlTypes.NpgsqlBox(top: 0.7556342337221293d,right: 0.42129202354536055d,bottom: 0.19020483228787477d,left: 0.3049035164370245d),
new NpgsqlTypes.NpgsqlBox(top: 0.7018133376776355d,right: 0.0951132667924709d,bottom: 0.44342296177626006d,left: 0.002795534710476111d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7400105285924925d,right: 0.7404904708705828d,bottom: 0.3132512757906071d,left: 0.1521631735627894d),
new NpgsqlTypes.NpgsqlBox(top: 0.8391186388825721d,right: 0.8926033131087651d,bottom: 0.12932445585059738d,left: 0.2525557126335698d),
new NpgsqlTypes.NpgsqlBox(top: 0.8781147392250291d,right: 0.6274408492644464d,bottom: 0.6375634469721313d,left: 0.009337357941676672d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6552324204504105d,right: 0.8724235411973106d,bottom: 0.10360037664014898d,left: 0.28536813097458713d),
new NpgsqlTypes.NpgsqlBox(top: 0.9707895355544821d,right: 0.5203083270135398d,bottom: 0.43959520790548223d,left: 0.36380309860079085d),
new NpgsqlTypes.NpgsqlBox(top: 0.9581518652119693d,right: 0.8438748423311272d,bottom: 0.05977207840465837d,left: 0.5512582769361658d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.963972893239332d,right: 0.5357594283165424d,bottom: 0.49062536896649034d,left: 0.47058296755685225d),
new NpgsqlTypes.NpgsqlBox(top: 0.8390836193185993d,right: 0.8465259471359153d,bottom: 0.6531625474972133d,left: 0.411937870328109d),
new NpgsqlTypes.NpgsqlBox(top: 0.47727530358453574d,right: 0.9833486492566282d,bottom: 0.2553849632176457d,left: 0.8347079987848289d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6251811865144513d,right: 0.9225099463866564d,bottom: 0.2172302517359027d,left: 0.19731530062290292d),
new NpgsqlTypes.NpgsqlBox(top: 0.7597070634339405d,right: 0.8883423257286334d,bottom: 0.11107345936087054d,left: 0.44805745522670914d),
new NpgsqlTypes.NpgsqlBox(top: 0.4099140571562966d,right: 0.29310644233410055d,bottom: 0.14943365715472723d,left: 0.2468818589222035d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6141839164798771d,right: 0.2817843816677783d,bottom: 0.18932508947192228d,left: 0.24612260664096386d),
new NpgsqlTypes.NpgsqlBox(top: 0.14455705065756497d,right: 0.8123496516665893d,bottom: 0.019134949192543216d,left: 0.1734236311152012d),
new NpgsqlTypes.NpgsqlBox(top: 0.42334142501124805d,right: 0.540984680949757d,bottom: 0.0770793970277136d,left: 0.4273854149334425d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5168857748446548d,right: 0.9917366536643835d,bottom: 0.48950486572629137d,left: 0.13505468139422228d),
new NpgsqlTypes.NpgsqlBox(top: 0.2181491461763545d,right: 0.8586039153218848d,bottom: 0.11885884518781997d,left: 0.5387412165446841d),
new NpgsqlTypes.NpgsqlBox(top: 0.7313327989113999d,right: 0.9296105765478796d,bottom: 0.14433891574189772d,left: 0.4770167162226612d),
new NpgsqlTypes.NpgsqlBox(top: 0.4874491624312153d,right: 0.7350229032170996d,bottom: 0.04816865374056445d,left: 0.3923803449955958d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8659577945445751d,right: 0.8617280764472501d,bottom: 0.23890840777800304d,left: 0.4095944038632934d),
new NpgsqlTypes.NpgsqlBox(top: 0.24453296167784921d,right: 0.7700439264562516d,bottom: 0.06324126141159325d,left: 0.5630289983830349d),
new NpgsqlTypes.NpgsqlBox(top: 0.574328061441429d,right: 0.7837929257964361d,bottom: 0.26145187564818373d,left: 0.7653021962709337d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.46687461123977625d,right: 0.7478511771011959d,bottom: 0.36780074310963906d,left: 0.16050593073143182d),
new NpgsqlTypes.NpgsqlBox(top: 0.7897323143702436d,right: 0.4325039577984081d,bottom: 0.1704796341657001d,left: 0.3503867804618529d),
new NpgsqlTypes.NpgsqlBox(top: 0.3453493399582537d,right: 0.33227025155741297d,bottom: 0.13123501359336787d,left: 0.32758735954893614d),
new NpgsqlTypes.NpgsqlBox(top: 0.902379901513287d,right: 0.8607724192267419d,bottom: 0.6819059607915503d,left: 0.7958268163259209d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9174365458194598d,right: 0.9745720032525597d,bottom: 0.9039456928929255d,left: 0.533012798405225d),
new NpgsqlTypes.NpgsqlBox(top: 0.46682034229958225d,right: 0.9193356409515303d,bottom: 0.2859604091297231d,left: 0.13425805271975488d),
new NpgsqlTypes.NpgsqlBox(top: 0.4471863722524625d,right: 0.8794677068424319d,bottom: 0.31114142147969825d,left: 0.5756269327054793d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8834052009707423d,right: 0.8988518022957156d,bottom: 0.5137760469500233d,left: 0.7930204139289568d),
new NpgsqlTypes.NpgsqlBox(top: 0.4147218218679609d,right: 0.37571141285119547d,bottom: 0.32443724997578594d,left: 0.03187413828268193d),
new NpgsqlTypes.NpgsqlBox(top: 0.6299410058948277d,right: 0.7275839678786893d,bottom: 0.28771081314029745d,left: 0.16102946971937715d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9205675253852004d,right: 0.49957438332981907d,bottom: 0.5282119545402552d,left: 0.4428493892984705d),
new NpgsqlTypes.NpgsqlBox(top: 0.5851634132130829d,right: 0.8490860742948264d,bottom: 0.018415335532765753d,left: 0.6141122506326222d),
new NpgsqlTypes.NpgsqlBox(top: 0.4520361686292006d,right: 0.9971164579709405d,bottom: 0.198048584473261d,left: 0.6650032721099451d),
new NpgsqlTypes.NpgsqlBox(top: 0.34729300792155493d,right: 0.5104231849035357d,bottom: 0.27921345752067417d,left: 0.5086531412199751d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8721046168675839d,right: 0.2056086272526939d,bottom: 0.3666887409874713d,left: 0.03746002653125369d),
new NpgsqlTypes.NpgsqlBox(top: 0.9607825095331053d,right: 0.6405350436137807d,bottom: 0.5764055781386784d,left: 0.3678453638777014d),
new NpgsqlTypes.NpgsqlBox(top: 0.5151050186090682d,right: 0.6209271061868703d,bottom: 0.20089379331874335d,left: 0.4865908506514707d),
new NpgsqlTypes.NpgsqlBox(top: 0.7526959303421941d,right: 0.9877937904260905d,bottom: 0.43182837790822226d,left: 0.09990056005671966d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6889480422126585d,right: 0.8725156849417285d,bottom: 0.36345502858979506d,left: 0.5621362755512815d),
new NpgsqlTypes.NpgsqlBox(top: 0.9171023254581541d,right: 0.5715550538379944d,bottom: 0.7782072059649365d,left: 0.5328838814149259d),
new NpgsqlTypes.NpgsqlBox(top: 0.4667218346865232d,right: 0.8445104867580007d,bottom: 0.4328809003813723d,left: 0.7740364497644519d),
new NpgsqlTypes.NpgsqlBox(top: 0.35683572630066884d,right: 0.979010269169819d,bottom: 0.03560345495974071d,left: 0.5952736934959318d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.945917401503737d,right: 0.18787314118557297d,bottom: 0.47094520050131883d,left: 0.002333520825692381d),
new NpgsqlTypes.NpgsqlBox(top: 0.4479775684766958d,right: 0.9385101200842595d,bottom: 0.0945191955047221d,left: 0.8110788775071144d),
new NpgsqlTypes.NpgsqlBox(top: 0.08055193820671591d,right: 0.41158290784751705d,bottom: 0.06623093429543425d,left: 0.3501375440472252d),
new NpgsqlTypes.NpgsqlBox(top: 0.6666775399111257d,right: 0.7979874335112839d,bottom: 0.2528372127318448d,left: 0.4025308887090947d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7671529939770688d,right: 0.4678302651969525d,bottom: 0.15805798361836376d,left: 0.15124135336271438d),
new NpgsqlTypes.NpgsqlBox(top: 0.8179628988244056d,right: 0.9127840203231834d,bottom: 0.6388736884525019d,left: 0.5390222959162521d),
new NpgsqlTypes.NpgsqlBox(top: 0.6128711079164839d,right: 0.423702121067857d,bottom: 0.3414674738974617d,left: 0.2823522160195471d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.776905869584644d,right: 0.391840014296599d,bottom: 0.36725762481654467d,left: 0.2972192081143571d),
new NpgsqlTypes.NpgsqlBox(top: 0.8359672280028637d,right: 0.3928461578512128d,bottom: 0.33504803678542605d,left: 0.17363979681105346d),
new NpgsqlTypes.NpgsqlBox(top: 0.582325255486471d,right: 0.471092608223845d,bottom: 0.2654356119992167d,left: 0.28210959088305354d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7615512533499808d,right: 0.8703169948650299d,bottom: 0.2626310735929588d,left: 0.5119859122861401d),
new NpgsqlTypes.NpgsqlBox(top: 0.9018962140966442d,right: 0.4791891728358998d,bottom: 0.8109047126067614d,left: 0.2486545788723441d),
new NpgsqlTypes.NpgsqlBox(top: 0.9910454188114629d,right: 0.4123742318117284d,bottom: 0.7480290130791473d,left: 0.03828612816088539d),
new NpgsqlTypes.NpgsqlBox(top: 0.7617646401068966d,right: 0.9768385700650624d,bottom: 0.08338973488015278d,left: 0.8689220663257896d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4416638549356362d,right: 0.4776753669586594d,bottom: 0.12107361935345773d,left: 0.47183338214545134d),
new NpgsqlTypes.NpgsqlBox(top: 0.8859525817777204d,right: 0.8301986871068948d,bottom: 0.8052625870995519d,left: 0.07625842919207848d),
new NpgsqlTypes.NpgsqlBox(top: 0.5913526508215763d,right: 0.20719627052216572d,bottom: 0.17359878053344235d,left: 0.058764501802342495d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9371026589328855d,right: 0.537986544764658d,bottom: 0.8573014961224108d,left: 0.38784209309484585d),
new NpgsqlTypes.NpgsqlBox(top: 0.46171084134360096d,right: 0.5977808527771682d,bottom: 0.3645159168995096d,left: 0.5126491850678597d),
new NpgsqlTypes.NpgsqlBox(top: 0.09255728735512192d,right: 0.6264951173708746d,bottom: 0.07266578896841858d,left: 0.48331432154009346d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7335169991255431d,right: 0.920511707947522d,bottom: 0.359406942182696d,left: 0.5120525188994833d),
new NpgsqlTypes.NpgsqlBox(top: 0.7385556505392581d,right: 0.902096890771914d,bottom: 0.54446068967778d,left: 0.17904833492911343d),
new NpgsqlTypes.NpgsqlBox(top: 0.5206990949747153d,right: 0.8316088949746453d,bottom: 0.3983319776913443d,left: 0.1543394563139271d),
new NpgsqlTypes.NpgsqlBox(top: 0.8901848110727953d,right: 0.6496410959218737d,bottom: 0.501370977973654d,left: 0.495455899181235d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9560965643192231d,right: 0.45887694633751674d,bottom: 0.44268732212594686d,left: 0.09784187598344607d),
new NpgsqlTypes.NpgsqlBox(top: 0.6487665053990288d,right: 0.4691191692649853d,bottom: 0.20686604084277238d,left: 0.16932342991753502d),
new NpgsqlTypes.NpgsqlBox(top: 0.4334259216505155d,right: 0.9007307143038669d,bottom: 0.09153316505606868d,left: 0.6767332055171112d),
new NpgsqlTypes.NpgsqlBox(top: 0.9682651869443318d,right: 0.44982802741415795d,bottom: 0.47267881783998955d,left: 0.2405766295497599d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8562831186543556d,right: 0.49107105778578763d,bottom: 0.7693792850997287d,left: 0.3877874797020171d),
new NpgsqlTypes.NpgsqlBox(top: 0.5734518001734439d,right: 0.8540982503208684d,bottom: 0.2468876420312479d,left: 0.5339868386383612d),
new NpgsqlTypes.NpgsqlBox(top: 0.7295750796711168d,right: 0.9083694115837562d,bottom: 0.23280547963282283d,left: 0.7177861690074877d),
new NpgsqlTypes.NpgsqlBox(top: 0.5704874992533355d,right: 0.7673724602114202d,bottom: 0.10124777908460414d,left: 0.05635862503300626d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9099500031235264d,right: 0.8886091080431701d,bottom: 0.24257348976905613d,left: 0.09290499183813228d),
new NpgsqlTypes.NpgsqlBox(top: 0.7117128862425744d,right: 0.43022305888075696d,bottom: 0.6537935859449432d,left: 0.27547629562924314d),
new NpgsqlTypes.NpgsqlBox(top: 0.7012860107470157d,right: 0.6326771356115697d,bottom: 0.016447559349487273d,left: 0.5468278222453393d),
new NpgsqlTypes.NpgsqlBox(top: 0.9144364381068983d,right: 0.8013363260150403d,bottom: 0.4344015469320148d,left: 0.24059023943222602d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.967451369454237d,right: 0.9753768450055901d,bottom: 0.38844686683952456d,left: 0.8444052817596999d),
new NpgsqlTypes.NpgsqlBox(top: 0.805136420143808d,right: 0.6711146294527601d,bottom: 0.013871807789385238d,left: 0.14680890615523523d),
new NpgsqlTypes.NpgsqlBox(top: 0.6260244083399691d,right: 0.6110778629428739d,bottom: 0.38461240909797156d,left: 0.2776106194490823d),
new NpgsqlTypes.NpgsqlBox(top: 0.6571887175684032d,right: 0.8407081029255798d,bottom: 0.15049316010193525d,left: 0.7554651864595132d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.282760391189392d,right: 0.4333994878665347d,bottom: 0.21767985997161254d,left: 0.4112969335829554d),
new NpgsqlTypes.NpgsqlBox(top: 0.4565309571154631d,right: 0.4180504787263678d,bottom: 0.06679884224969213d,left: 0.28274381567476603d),
new NpgsqlTypes.NpgsqlBox(top: 0.6133527652935772d,right: 0.5256871622183207d,bottom: 0.16047093426345804d,left: 0.1676070282684684d),
new NpgsqlTypes.NpgsqlBox(top: 0.8977333261775167d,right: 0.108933676351754d,bottom: 0.8521563116858004d,left: 0.02558496928142573d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4979135211545699d,right: 0.6960700848869982d,bottom: 0.30075330398945055d,left: 0.047545065113521745d),
new NpgsqlTypes.NpgsqlBox(top: 0.5168710161067307d,right: 0.9156168210630153d,bottom: 0.46879405664461027d,left: 0.8160396717676678d),
new NpgsqlTypes.NpgsqlBox(top: 0.8975765822056966d,right: 0.5484841018087677d,bottom: 0.514556877181303d,left: 0.017311975373428323d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47324594547386833d,right: 0.6715049400525722d,bottom: 0.01596762394590323d,left: 0.38852686646129986d),
new NpgsqlTypes.NpgsqlBox(top: 0.6587702218628804d,right: 0.8326317542384603d,bottom: 0.43059110649854004d,left: 0.6177397067899748d),
new NpgsqlTypes.NpgsqlBox(top: 0.504426450658151d,right: 0.32544246382350506d,bottom: 0.2892365708451142d,left: 0.32100387726096347d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8005185898332772d,right: 0.5229863036384792d,bottom: 0.01371743461527608d,left: 0.29621783444693495d),
new NpgsqlTypes.NpgsqlBox(top: 0.6809818879390557d,right: 0.82973874038214d,bottom: 0.34610521131622407d,left: 0.7194118026158487d),
new NpgsqlTypes.NpgsqlBox(top: 0.8174963181429383d,right: 0.6312881189480755d,bottom: 0.29703309434367575d,left: 0.5207956067634549d),
new NpgsqlTypes.NpgsqlBox(top: 0.929163845261562d,right: 0.8432690711670141d,bottom: 0.3944921107628736d,left: 0.7463968705109629d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7862062357305568d,right: 0.8684116257520453d,bottom: 0.7522331172955606d,left: 0.8169058803381472d),
new NpgsqlTypes.NpgsqlBox(top: 0.6095082506441879d,right: 0.7780375103046274d,bottom: 0.14148395842625883d,left: 0.4659973463313435d),
new NpgsqlTypes.NpgsqlBox(top: 0.8413111513866245d,right: 0.53691920086922d,bottom: 0.7127056023819555d,left: 0.038980460882430346d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3911189599121535d,right: 0.9457701703853757d,bottom: 0.06622995895452066d,left: 0.40976754113387037d),
new NpgsqlTypes.NpgsqlBox(top: 0.8494270002880043d,right: 0.6491505249722171d,bottom: 0.5073771061928251d,left: 0.6431495070265915d),
new NpgsqlTypes.NpgsqlBox(top: 0.935262849819051d,right: 0.6139527019387778d,bottom: 0.49553656543749713d,left: 0.5572287307855341d),
new NpgsqlTypes.NpgsqlBox(top: 0.6856444784906826d,right: 0.7803193356860563d,bottom: 0.27411140591276795d,left: 0.1028550882579291d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.29789480684344016d,right: 0.8973854512485403d,bottom: 0.0306986886412296d,left: 0.531487432170091d),
new NpgsqlTypes.NpgsqlBox(top: 0.21544257844954118d,right: 0.829353817186781d,bottom: 0.039374276003471875d,left: 0.7632197792647826d),
new NpgsqlTypes.NpgsqlBox(top: 0.5824544713415997d,right: 0.15963544860878254d,bottom: 0.3754705095732588d,left: 0.13244858459218534d),
new NpgsqlTypes.NpgsqlBox(top: 0.7945164440594498d,right: 0.9976936068456723d,bottom: 0.19655817590641733d,left: 0.9662934577931062d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6605507692051527d,right: 0.7103212988707717d,bottom: 0.011312991728735788d,left: 0.027779989502519697d),
new NpgsqlTypes.NpgsqlBox(top: 0.9413047528081209d,right: 0.9696808920413315d,bottom: 0.7679901007219427d,left: 0.24806256895391532d),
new NpgsqlTypes.NpgsqlBox(top: 0.8965517093045295d,right: 0.8010607704681095d,bottom: 0.07504044838843593d,left: 0.5735834855501526d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.28242974799610265d,right: 0.6993679649779823d,bottom: 0.23398773652243354d,left: 0.46892451726533413d),
new NpgsqlTypes.NpgsqlBox(top: 0.45284621445907147d,right: 0.823418165441673d,bottom: 0.134388786088513d,left: 0.4860453601911937d),
new NpgsqlTypes.NpgsqlBox(top: 0.244090128808231d,right: 0.09366503018322847d,bottom: 0.15879006004614105d,left: 0.05636484556873056d),
new NpgsqlTypes.NpgsqlBox(top: 0.43543345322602733d,right: 0.8227271707258712d,bottom: 0.048366589588763054d,left: 0.5935314977328576d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6144136025506365d,right: 0.6881951902875175d,bottom: 0.48315007067513605d,left: 0.17413325243211175d),
new NpgsqlTypes.NpgsqlBox(top: 0.8044529110223693d,right: 0.8343780312966542d,bottom: 0.4406291023756188d,left: 0.44102813869938784d),
new NpgsqlTypes.NpgsqlBox(top: 0.838371982583569d,right: 0.732054242799292d,bottom: 0.35548854550874787d,left: 0.6274920259560607d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12050870382299839d,right: 0.7264841180541128d,bottom: 0.0908827171293688d,left: 0.28149570516566047d),
new NpgsqlTypes.NpgsqlBox(top: 0.9085144778860154d,right: 0.5377000069602503d,bottom: 0.19408846278367042d,left: 0.40681790274581353d),
new NpgsqlTypes.NpgsqlBox(top: 0.180059884064535d,right: 0.8457520703051229d,bottom: 0.027403492823540154d,left: 0.5719751515412447d),
new NpgsqlTypes.NpgsqlBox(top: 0.6805135971815535d,right: 0.8883728837122349d,bottom: 0.6041135778514016d,left: 0.4539982961314616d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6386556031372069d,right: 0.5966859259579667d,bottom: 0.37365665225134903d,left: 0.43207766102753853d),
new NpgsqlTypes.NpgsqlBox(top: 0.9976177453603552d,right: 0.803099508765361d,bottom: 0.694617138023481d,left: 0.25260320744813747d),
new NpgsqlTypes.NpgsqlBox(top: 0.9494706785406821d,right: 0.5729062757860857d,bottom: 0.34313173218206183d,left: 0.3821021188853171d),
new NpgsqlTypes.NpgsqlBox(top: 0.7820103657959164d,right: 0.6534324380571106d,bottom: 0.41189514062010735d,left: 0.6456424795860038d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.11347877953381591d,right: 0.6293673796976758d,bottom: 0.06389334556849713d,left: 0.096299389657726d),
new NpgsqlTypes.NpgsqlBox(top: 0.5656701669885089d,right: 0.8990785183150753d,bottom: 0.3887423026838469d,left: 0.25929844061160834d),
new NpgsqlTypes.NpgsqlBox(top: 0.3109980847804853d,right: 0.9836778881015714d,bottom: 0.30363551965681856d,left: 0.2918525849150143d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7708338345442312d,right: 0.7940550504263154d,bottom: 0.3287751815132598d,left: 0.5254198460543278d),
new NpgsqlTypes.NpgsqlBox(top: 0.5116270196671022d,right: 0.3766994773062068d,bottom: 0.11121029948176431d,left: 0.13761684896758908d),
new NpgsqlTypes.NpgsqlBox(top: 0.9917942569334955d,right: 0.36645926817928354d,bottom: 0.7883660839703653d,left: 0.04252891408030979d),
new NpgsqlTypes.NpgsqlBox(top: 0.7645852458892209d,right: 0.5201636747241198d,bottom: 0.47901102266482154d,left: 0.45323066354898645d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6429143838835875d,right: 0.9700098234680015d,bottom: 0.40420850599746294d,left: 0.019259602250076946d),
new NpgsqlTypes.NpgsqlBox(top: 0.9946519110575403d,right: 0.5767978687090436d,bottom: 0.16694939122866048d,left: 0.19648443327966947d),
new NpgsqlTypes.NpgsqlBox(top: 0.6992246421109944d,right: 0.40055810725927854d,bottom: 0.16753696824643138d,left: 0.20801747624547262d),
new NpgsqlTypes.NpgsqlBox(top: 0.7896947859568287d,right: 0.19385388191345632d,bottom: 0.37759072010519357d,left: 0.15815422914669397d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9467977349180153d,right: 0.9272129428947835d,bottom: 0.3971392748832805d,left: 0.15870714853666457d),
new NpgsqlTypes.NpgsqlBox(top: 0.9123911124538435d,right: 0.9734172651200474d,bottom: 0.8869094375992363d,left: 0.6418640855125783d),
new NpgsqlTypes.NpgsqlBox(top: 0.8674934394077827d,right: 0.9027108076628637d,bottom: 0.6056507600720863d,left: 0.06600498347032147d),
new NpgsqlTypes.NpgsqlBox(top: 0.5685802304162662d,right: 0.3544940163436261d,bottom: 0.4286358207682792d,left: 0.16204898608627227d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5782751721155562d,right: 0.053765769561596066d,bottom: 0.37565436698947163d,left: 0.031745412960478725d),
new NpgsqlTypes.NpgsqlBox(top: 0.8857803069661268d,right: 0.9971017704579875d,bottom: 0.7169093646647274d,left: 0.30823940202983324d),
new NpgsqlTypes.NpgsqlBox(top: 0.7785358731301155d,right: 0.8653910959541196d,bottom: 0.2308669024273301d,left: 0.12418841446545548d),
new NpgsqlTypes.NpgsqlBox(top: 0.8990988563816414d,right: 0.6924310276371426d,bottom: 0.28566785176569254d,left: 0.00867642552928849d),
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
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9743300965669793d,right: 0.6504557049025952d,bottom: 0.6189918784063367d,left: 0.4919596613941325d),
new NpgsqlTypes.NpgsqlBox(top: 0.49640316007833885d,right: 0.7203692958634449d,bottom: 0.2939800076291811d,left: 0.11722075049688419d),
new NpgsqlTypes.NpgsqlBox(top: 0.9401174062425924d,right: 0.8556670006682918d,bottom: 0.3270162978725498d,left: 0.19336086784390616d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40316161039529796d,right: 0.7771497567923197d,bottom: 0.19112709037232956d,left: 0.13260818922987316d),
new NpgsqlTypes.NpgsqlBox(top: 0.8815709165989437d,right: 0.8026968151905487d,bottom: 0.47910212287037235d,left: 0.3959053984066445d),
new NpgsqlTypes.NpgsqlBox(top: 0.8730687589895062d,right: 0.9379481105628463d,bottom: 0.17164969619010373d,left: 0.08137969911270748d),
}));
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
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7245399302156663d,right: 0.5419848258070475d,bottom: 0.6234996843179624d,left: 0.0805007814715496d),
new NpgsqlTypes.NpgsqlBox(top: 0.7613780550392413d,right: 0.13752771004992181d,bottom: 0.35862098440719326d,left: 0.09905488399750773d),
new NpgsqlTypes.NpgsqlBox(top: 0.5467824980376622d,right: 0.9186621211928355d,bottom: 0.4459632416907954d,left: 0.2556464809781518d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6453858294873304d,right: 0.7668348150460649d,bottom: 0.2034202379208735d,left: 0.6922294841982491d),
new NpgsqlTypes.NpgsqlBox(top: 0.38875003042546763d,right: 0.2957793598159818d,bottom: 0.22447663774864135d,left: 0.12110715016573337d),
new NpgsqlTypes.NpgsqlBox(top: 0.5469615988686531d,right: 0.9173237069842629d,bottom: 0.5319679938412265d,left: 0.17804384705587395d),
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.963972893239332d,right: 0.5357594283165424d,bottom: 0.49062536896649034d,left: 0.47058296755685225d),
new NpgsqlTypes.NpgsqlBox(top: 0.8390836193185993d,right: 0.8465259471359153d,bottom: 0.6531625474972133d,left: 0.411937870328109d),
new NpgsqlTypes.NpgsqlBox(top: 0.47727530358453574d,right: 0.9833486492566282d,bottom: 0.2553849632176457d,left: 0.8347079987848289d),
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
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

                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 119, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatchAsync(connection, 24, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
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
                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatch(connection, 122, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

