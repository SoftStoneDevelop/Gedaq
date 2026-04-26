

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8672879143757297d, y: 0.40127385966049156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060553988001833d, y: 0.5394046302638345d), new NpgsqlTypes.NpgsqlPoint(x: 0.13876014879387644d, y: 0.711492714578217d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7950827676969549d, y: 0.9247772546429334d), new NpgsqlTypes.NpgsqlPoint(x: 0.12446601307755001d, y: 0.7092107673759667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8498429551100185d, y: 0.9475587633451508d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5962480602085012d, y: 0.11045347609714051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522142977896475d, y: 0.5054703103658432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7273485847760588d, y: 0.8125517933186303d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5139461207860663d, y: 0.3370044962617882d), new NpgsqlTypes.NpgsqlPoint(x: 0.45491096226063976d, y: 0.924051676148531d), new NpgsqlTypes.NpgsqlPoint(x: 0.26245281652314356d, y: 0.8672186688378185d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7294448990651501d, y: 0.09367700142714952d), new NpgsqlTypes.NpgsqlPoint(x: 0.46921515668078984d, y: 0.8902405083431545d), new NpgsqlTypes.NpgsqlPoint(x: 0.02855120173308001d, y: 0.5272699896766506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6789803093501647d, y: 0.3903475737898373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4498854632846858d, y: 0.5979483710763112d), new NpgsqlTypes.NpgsqlPoint(x: 0.42508191224504244d, y: 0.8075628533507556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10643056924801575d, y: 0.48691639744068604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4262016955450112d, y: 0.8882596793233739d), new NpgsqlTypes.NpgsqlPoint(x: 0.455574134592464d, y: 0.8508744097880327d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12344417090461046d, y: 0.8446772509653179d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784902388306785d, y: 0.5670355771485145d), new NpgsqlTypes.NpgsqlPoint(x: 0.7399054324104983d, y: 0.3056294580004565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19230899766010012d, y: 0.6225721043783443d), new NpgsqlTypes.NpgsqlPoint(x: 0.41957236351751726d, y: 0.4655003096009368d), new NpgsqlTypes.NpgsqlPoint(x: 0.009143256995022386d, y: 0.21159172558169437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5522082963874761d, y: 0.3172118067479809d), new NpgsqlTypes.NpgsqlPoint(x: 0.32848066167350776d, y: 0.25306205901171663d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827243068891504d, y: 0.7432651577504739d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11172235024433286d, y: 0.5675040765789148d), new NpgsqlTypes.NpgsqlPoint(x: 0.4335843500280183d, y: 0.3462611346144141d), new NpgsqlTypes.NpgsqlPoint(x: 0.006497390254215696d, y: 0.2964464837244777d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7652453284946213d, y: 0.8234054712212605d), new NpgsqlTypes.NpgsqlPoint(x: 0.06449727309122999d, y: 0.7709292604257126d), new NpgsqlTypes.NpgsqlPoint(x: 0.3163333405160643d, y: 0.4920142688447433d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7939966650275087d, y: 0.7666549977557945d), new NpgsqlTypes.NpgsqlPoint(x: 0.646350144478397d, y: 0.7773073990172081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879359625867994d, y: 0.6490800134575908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7860346662025076d, y: 0.30679300225271233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7569063931157828d, y: 0.953811626703013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677607018399176d, y: 0.6697524345308625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18160858727049212d, y: 0.8142369568385833d), new NpgsqlTypes.NpgsqlPoint(x: 0.34518297298026857d, y: 0.6688350289108499d), new NpgsqlTypes.NpgsqlPoint(x: 0.08932473800329876d, y: 0.05735417706938828d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29275670035430645d, y: 0.11979478833314072d), new NpgsqlTypes.NpgsqlPoint(x: 0.8525716807283127d, y: 0.7112728194863613d), new NpgsqlTypes.NpgsqlPoint(x: 0.21187060085319298d, y: 0.7516973051226823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43718905437549893d, y: 0.07164131264433715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7982023213261632d, y: 0.06661192735210952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616291927966955d, y: 0.6382521046078072d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0109000622022134d, y: 0.6459016443577008d), new NpgsqlTypes.NpgsqlPoint(x: 0.08251387867192483d, y: 0.39911998625587797d), new NpgsqlTypes.NpgsqlPoint(x: 0.13805083790614092d, y: 0.947657942579195d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6427994347033978d, y: 0.6267583698331441d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228685064536266d, y: 0.022254167548445447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910452069230681d, y: 0.7286077028281582d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1549640987061237d, y: 0.09674922861707724d), new NpgsqlTypes.NpgsqlPoint(x: 0.33162880405043416d, y: 0.5642149386045722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575373392928752d, y: 0.45936939428316537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2856816268928988d, y: 0.35757288512408714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381262820627035d, y: 0.2655876372918604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199943868766299d, y: 0.7607904062461261d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7089923432501684d, y: 0.21901549154335875d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503065449266423d, y: 0.8083388519007959d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765466752148217d, y: 0.1927577212512387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3707248078171804d, y: 0.016150222651179158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972870831109922d, y: 0.4149645852051025d), new NpgsqlTypes.NpgsqlPoint(x: 0.4090006496091614d, y: 0.6845671447105707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2813896085821266d, y: 0.45899730785809445d), new NpgsqlTypes.NpgsqlPoint(x: 0.633904658209555d, y: 0.43191218311729207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608662835255946d, y: 0.5209916495371847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8801872659914236d, y: 0.37521341222246785d), new NpgsqlTypes.NpgsqlPoint(x: 0.4337038452788097d, y: 0.9846060809853278d), new NpgsqlTypes.NpgsqlPoint(x: 0.22861278631007587d, y: 0.365586774594154d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06861349480654055d, y: 0.41466614585098693d), new NpgsqlTypes.NpgsqlPoint(x: 0.38378767528894775d, y: 0.8238600635202945d), new NpgsqlTypes.NpgsqlPoint(x: 0.27033178874374586d, y: 0.653197761860745d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6045956541573969d, y: 0.636636582651052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472542235344778d, y: 0.06127907253494702d), new NpgsqlTypes.NpgsqlPoint(x: 0.1454950161462556d, y: 0.28838204990237415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11177598437945302d, y: 0.04488364793216337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086216981529251d, y: 0.19303346064616644d), new NpgsqlTypes.NpgsqlPoint(x: 0.05221197816235379d, y: 0.2658591913801812d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13773371316123373d, y: 0.0771246670327107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388587749680163d, y: 0.3776727448775865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132049710553389d, y: 0.7189802010183491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48502493809128633d, y: 0.4988501464090591d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364045309900222d, y: 0.44708318031235594d), new NpgsqlTypes.NpgsqlPoint(x: 0.14575177984109178d, y: 0.30883318653905756d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6340997316982373d, y: 0.3781357356296614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9395405992304874d, y: 0.5870103705838178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191160006977163d, y: 0.24030555379421303d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6175995683289007d, y: 0.6915094413449272d), new NpgsqlTypes.NpgsqlPoint(x: 0.06195388532637869d, y: 0.6229152934464507d), new NpgsqlTypes.NpgsqlPoint(x: 0.663835085309009d, y: 0.9635923573933031d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39395943726449545d, y: 0.16434558722309467d), new NpgsqlTypes.NpgsqlPoint(x: 0.20068507060437168d, y: 0.398521882669047d), new NpgsqlTypes.NpgsqlPoint(x: 0.1266822497409572d, y: 0.34310691916000924d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5623907733122339d, y: 0.8827195816870848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184043895623677d, y: 0.2791849265959928d), new NpgsqlTypes.NpgsqlPoint(x: 0.10758712856082919d, y: 0.45427573774077323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29667419855612676d, y: 0.0890511146106554d), new NpgsqlTypes.NpgsqlPoint(x: 0.39438150065365596d, y: 0.035615319065146034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515957412679443d, y: 0.08124970716372149d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04018731322952662d, y: 0.8700447084036527d), new NpgsqlTypes.NpgsqlPoint(x: 0.19746197089071804d, y: 0.003113506689119916d), new NpgsqlTypes.NpgsqlPoint(x: 0.839544399081755d, y: 0.9291459580216953d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8698882971567937d, y: 0.13068561814119606d), new NpgsqlTypes.NpgsqlPoint(x: 0.0441938636761634d, y: 0.15773436331476576d), new NpgsqlTypes.NpgsqlPoint(x: 0.9865068047274899d, y: 0.007807166413356548d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33561721732944716d, y: 0.9073449523849818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7033028164844901d, y: 0.30270005769773856d), new NpgsqlTypes.NpgsqlPoint(x: 0.3487826031987252d, y: 0.8867547515672494d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7859908635402684d, y: 0.48137415272735506d), new NpgsqlTypes.NpgsqlPoint(x: 0.343190260110277d, y: 0.36549043470757003d), new NpgsqlTypes.NpgsqlPoint(x: 0.048714297691594854d, y: 0.9572536662917839d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.714438151212501d, y: 0.39153581533238024d), new NpgsqlTypes.NpgsqlPoint(x: 0.14361046734809113d, y: 0.3959643470312023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9660877819960999d, y: 0.05928321041038853d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4356923520857475d, y: 0.34044539368711824d), new NpgsqlTypes.NpgsqlPoint(x: 0.27049946403032255d, y: 0.4164834773382624d), new NpgsqlTypes.NpgsqlPoint(x: 0.12046205393762455d, y: 0.5632306472978766d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7941964388822544d, y: 0.112533142015113d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243339508603715d, y: 0.15271338355274022d), new NpgsqlTypes.NpgsqlPoint(x: 0.34064818491294213d, y: 0.748147357824923d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6835602949014103d, y: 0.4013171135953916d), new NpgsqlTypes.NpgsqlPoint(x: 0.24265172870753393d, y: 0.1320174301303233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432592177800875d, y: 0.9084784744506754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7580932633505493d, y: 0.04905103523332566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9096471427091044d, y: 0.4798143949700162d), new NpgsqlTypes.NpgsqlPoint(x: 0.43832305593058096d, y: 0.590684582786772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16391030862188427d, y: 0.8935083537331117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8753521266746837d, y: 0.6033892616752182d), new NpgsqlTypes.NpgsqlPoint(x: 0.4172612589496789d, y: 0.343768313964258d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18549522925358708d, y: 0.4305273382666377d), new NpgsqlTypes.NpgsqlPoint(x: 0.31980726738295595d, y: 0.25506250582022594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3989788711903901d, y: 0.9837267027237767d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19458695743020382d, y: 0.34971209956661276d), new NpgsqlTypes.NpgsqlPoint(x: 0.777966351059303d, y: 0.5545891622033817d), new NpgsqlTypes.NpgsqlPoint(x: 0.20708624578093537d, y: 0.5937770024595851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34404477018257507d, y: 0.0015886564484943744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140867644519942d, y: 0.216181722918113d), new NpgsqlTypes.NpgsqlPoint(x: 0.21888755044535557d, y: 0.7230244370828319d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.529911348146482d, y: 0.6775555313814621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856456931046916d, y: 0.2684115760946989d), new NpgsqlTypes.NpgsqlPoint(x: 0.30881628558688523d, y: 0.585903528263982d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03102627279397241d, y: 0.850552095533446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125030688935209d, y: 0.4418091800829719d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406263340457979d, y: 0.11292528931980939d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39416644372572207d, y: 0.423954965763066d), new NpgsqlTypes.NpgsqlPoint(x: 0.12470089497087922d, y: 0.2643239381318553d), new NpgsqlTypes.NpgsqlPoint(x: 0.09917482654325582d, y: 0.1562827167597447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2718476555695962d, y: 0.7480501898154065d), new NpgsqlTypes.NpgsqlPoint(x: 0.7777811541916407d, y: 0.9288459683782384d), new NpgsqlTypes.NpgsqlPoint(x: 0.392394950508959d, y: 0.5602587284851898d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023760440713542774d, y: 0.15904393969286434d), new NpgsqlTypes.NpgsqlPoint(x: 0.33335278513512134d, y: 0.5750666401355451d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756692654297339d, y: 0.7135217327044879d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4870164830012006d, y: 0.5278399642608105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5148615735738126d, y: 0.8153328010994889d), new NpgsqlTypes.NpgsqlPoint(x: 0.9662046957106109d, y: 0.4229456155637751d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7286124476917437d, y: 0.9160412409126235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4212557586333645d, y: 0.8616034873040024d), new NpgsqlTypes.NpgsqlPoint(x: 0.2556064905838116d, y: 0.264394439809053d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2854587574528321d, y: 0.6021354183243819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087420281022454d, y: 0.08458171714018792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8950412691515683d, y: 0.9057323297637919d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9747431023318917d, y: 0.5477067129670036d), new NpgsqlTypes.NpgsqlPoint(x: 0.058825822717884724d, y: 0.8376409305677196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292113778639035d, y: 0.5486620792014608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8645152320913012d, y: 0.7005791425884385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528061958014248d, y: 0.41912199140564754d), new NpgsqlTypes.NpgsqlPoint(x: 0.25005867649063196d, y: 0.48220897086064396d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8127003343365439d, y: 0.7007739301977722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688828609402389d, y: 0.7545929675996225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140270779948155d, y: 0.3055592061645498d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1800405363928238d, y: 0.9414238336858374d), new NpgsqlTypes.NpgsqlPoint(x: 0.14709716451677712d, y: 0.5542490919332244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5098888520919818d, y: 0.22359421872358864d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843302477380149d, y: 0.0280530779542707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325978690847349d, y: 0.3916535012602307d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337106679298632d, y: 0.4894072705419904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8485776881420692d, y: 0.15184641773450902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270282880347123d, y: 0.042303744075474325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938048594502172d, y: 0.17680287131631d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016124775778769584d, y: 0.7842452301477857d), new NpgsqlTypes.NpgsqlPoint(x: 0.1715665335541109d, y: 0.7599876166531249d), new NpgsqlTypes.NpgsqlPoint(x: 0.9405817757082607d, y: 0.02942425215088773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8799967346110812d, y: 0.12821035354907873d), new NpgsqlTypes.NpgsqlPoint(x: 0.36451853105759424d, y: 0.4793723339038082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6909699364884329d, y: 0.6292191277212842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5950919976630304d, y: 0.794942333056576d), new NpgsqlTypes.NpgsqlPoint(x: 0.1433068748963101d, y: 0.4668776654547937d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504457019117021d, y: 0.7183282274512989d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5910201016810946d, y: 0.31699820543521706d), new NpgsqlTypes.NpgsqlPoint(x: 0.48055729811521597d, y: 0.8451636878391513d), new NpgsqlTypes.NpgsqlPoint(x: 0.31860867426903694d, y: 0.4216250749466275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.758277034266092d, y: 0.7098104248866342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7898144668797926d, y: 0.2763360372054362d), new NpgsqlTypes.NpgsqlPoint(x: 0.08121601907542042d, y: 0.7609703385202087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2618670227583957d, y: 0.45803292351943947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8719503067421132d, y: 0.6852800902223474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7818343412969975d, y: 0.7105545238943416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9182867045838191d, y: 0.060805464390717434d), new NpgsqlTypes.NpgsqlPoint(x: 0.28597953859616054d, y: 0.9906677887710146d), new NpgsqlTypes.NpgsqlPoint(x: 0.28890132307094507d, y: 0.89367267310724d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6037219355086256d, y: 0.18726587593479394d), new NpgsqlTypes.NpgsqlPoint(x: 0.0825622358185204d, y: 0.2914295407954438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604086582886051d, y: 0.9186346087256169d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18961841899613296d, y: 0.6679185412839664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6123526765072951d, y: 0.9158626992758357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1189059126108013d, y: 0.59702041629311d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16513999754138486d, y: 0.8118808042864002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547670441927941d, y: 0.4119590266139169d), new NpgsqlTypes.NpgsqlPoint(x: 0.2359057427922071d, y: 0.4331245028681251d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5498371751210351d, y: 0.8986362329980508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5490878460457976d, y: 0.05048010556179805d), new NpgsqlTypes.NpgsqlPoint(x: 0.10321553244639448d, y: 0.01317694144529269d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20557752504750781d, y: 0.44842131428118015d), new NpgsqlTypes.NpgsqlPoint(x: 0.25247419480457955d, y: 0.7361292704115364d), new NpgsqlTypes.NpgsqlPoint(x: 0.08400476668358647d, y: 0.27427021720030775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.569877265377926d, y: 0.8997289149550001d), new NpgsqlTypes.NpgsqlPoint(x: 0.11158243390850853d, y: 0.6397006868001753d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943489288505352d, y: 0.12636831965567707d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35237245190895694d, y: 0.1332984042446569d), new NpgsqlTypes.NpgsqlPoint(x: 0.9421842361342149d, y: 0.6029087117834013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479290287006201d, y: 0.4938574311826335d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19104190216563932d, y: 0.9480541563927546d), new NpgsqlTypes.NpgsqlPoint(x: 0.17194321200651175d, y: 0.6182107376553219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9687121153144422d, y: 0.4209952348137228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.382352634455457d, y: 0.12189090815330561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213569193238302d, y: 0.4085658171716786d), new NpgsqlTypes.NpgsqlPoint(x: 0.13549724021717957d, y: 0.8935901917725825d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015341167982402037d, y: 0.9641858690949306d), new NpgsqlTypes.NpgsqlPoint(x: 0.10099935081386124d, y: 0.9325984298536205d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943496578403751d, y: 0.45238964614610055d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734688882973209d, y: 0.9332680126219293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3928731077865676d, y: 0.8792462460098359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163102219801158d, y: 0.5478231088817592d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7440307905249333d, y: 0.36183034023884153d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386912029726111d, y: 0.67974403548374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4194719262176795d, y: 0.9440220653857982d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5114368408364249d, y: 0.4096408461637435d), new NpgsqlTypes.NpgsqlPoint(x: 0.473879410114197d, y: 0.5825607740042581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056503411075925d, y: 0.14658795106543066d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4249770559950403d, y: 0.7190742840032958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474805137807089d, y: 0.611170050841946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637162405815713d, y: 0.019260564661610635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4357174966647559d, y: 0.7758448481124878d), new NpgsqlTypes.NpgsqlPoint(x: 0.7074484541369411d, y: 0.615428466347611d), new NpgsqlTypes.NpgsqlPoint(x: 0.4258586100792362d, y: 0.46222519949562124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7302915580340592d, y: 0.8108601631377705d), new NpgsqlTypes.NpgsqlPoint(x: 0.18915458941557228d, y: 0.002560527575027338d), new NpgsqlTypes.NpgsqlPoint(x: 0.17470367574809265d, y: 0.9367679261939136d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5545991000240305d, y: 0.907326639356129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454071966301808d, y: 0.5115156326531956d), new NpgsqlTypes.NpgsqlPoint(x: 0.891442839342005d, y: 0.5675358830012419d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6310301774147579d, y: 0.6149940730259104d), new NpgsqlTypes.NpgsqlPoint(x: 0.49521224826312127d, y: 0.42151851410801044d), new NpgsqlTypes.NpgsqlPoint(x: 0.36013936919929024d, y: 0.6217037882191175d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20077543264361997d, y: 0.6543488476624977d), new NpgsqlTypes.NpgsqlPoint(x: 0.009560280574529512d, y: 0.26601959878029646d), new NpgsqlTypes.NpgsqlPoint(x: 0.16307659382610273d, y: 0.24670493997479737d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4195976836495693d, y: 0.16960902234220032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118206249121271d, y: 0.3990289456531574d), new NpgsqlTypes.NpgsqlPoint(x: 0.31999096548443384d, y: 0.5586712218688341d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8454279587428768d, y: 0.9670199092602134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6688231128444453d, y: 0.8463623130265545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859393312708285d, y: 0.48571082816782285d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37350871567499166d, y: 0.25365804014981697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494393512099622d, y: 0.31608148283854287d), new NpgsqlTypes.NpgsqlPoint(x: 0.4134647329182629d, y: 0.769646878160189d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7275416351022784d, y: 0.09678591741136211d), new NpgsqlTypes.NpgsqlPoint(x: 0.5270934395834289d, y: 0.15409925242336397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9509880029017413d, y: 0.3889054151818041d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6450275041378698d, y: 0.8761181829432364d), new NpgsqlTypes.NpgsqlPoint(x: 0.2214699040363346d, y: 0.18378572125116255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5333070165920857d, y: 0.623333448016293d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.388999827452443d, y: 0.7864068578431247d), new NpgsqlTypes.NpgsqlPoint(x: 0.048191565383990165d, y: 0.557794778660411d), new NpgsqlTypes.NpgsqlPoint(x: 0.22323068624357945d, y: 0.997741827176716d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9487818338389322d, y: 0.9019290674926975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818987072097186d, y: 0.25029651851975543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260042089657261d, y: 0.35249508426335174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10138123385847575d, y: 0.02152743516776745d), new NpgsqlTypes.NpgsqlPoint(x: 0.08994701854789733d, y: 0.08503484761976443d), new NpgsqlTypes.NpgsqlPoint(x: 0.17872191950516736d, y: 0.32446226369661757d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6164538533523302d, y: 0.520531065458507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107760442289917d, y: 0.38439162250925774d), new NpgsqlTypes.NpgsqlPoint(x: 0.634022943448649d, y: 0.0501346634342158d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9524486813883011d, y: 0.8937240125805448d), new NpgsqlTypes.NpgsqlPoint(x: 0.37580101267367017d, y: 0.26484527508951783d), new NpgsqlTypes.NpgsqlPoint(x: 0.7166174193970624d, y: 0.1801126647772301d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5991686262845999d, y: 0.25846903089686013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5803539010393108d, y: 0.26319690819456854d), new NpgsqlTypes.NpgsqlPoint(x: 0.11892190156700444d, y: 0.4420491362456451d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17017442856085918d, y: 0.22960981302443928d), new NpgsqlTypes.NpgsqlPoint(x: 0.4578977000601825d, y: 0.2266398620939738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6590983470272029d, y: 0.15610017393156705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.90075481512066d, y: 0.07851425314966198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8773343917422974d, y: 0.8958625682024015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659988000829053d, y: 0.1344458301321586d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15190365124606642d, y: 0.6948794493608905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458135055796089d, y: 0.8577966289698178d), new NpgsqlTypes.NpgsqlPoint(x: 0.39027764891545513d, y: 0.8129356505001951d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6372017588811805d, y: 0.041447847680366134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7989032987013774d, y: 0.47942825692999036d), new NpgsqlTypes.NpgsqlPoint(x: 0.8509618708607716d, y: 0.3454252345591413d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7990000939385687d, y: 0.8391191902363896d), new NpgsqlTypes.NpgsqlPoint(x: 0.918821472406573d, y: 0.5830460515064203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300011879479504d, y: 0.7849259986883311d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44583229660548995d, y: 0.472852067444972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9208718226379375d, y: 0.4882541473247848d), new NpgsqlTypes.NpgsqlPoint(x: 0.38885359275170617d, y: 0.23798930025807374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44790732338737016d, y: 0.9911245051220439d), new NpgsqlTypes.NpgsqlPoint(x: 0.980139020695606d, y: 0.0735433141219366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7690406193617276d, y: 0.14054059585595735d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5532745416964567d, y: 0.5330836152640949d), new NpgsqlTypes.NpgsqlPoint(x: 0.16505967382516729d, y: 0.7457805059485123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242646669381263d, y: 0.48366811722916137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7306165951682183d, y: 0.12644742504504425d), new NpgsqlTypes.NpgsqlPoint(x: 0.06218002267358713d, y: 0.45668696813437626d), new NpgsqlTypes.NpgsqlPoint(x: 0.2985640791910027d, y: 0.09402385221436715d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7846033957884261d, y: 0.6572608493794913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792841849846571d, y: 0.028866483244334495d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627791968144386d, y: 0.5002894054366762d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5382719634752329d, y: 0.5556528511560892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7504543530407437d, y: 0.1258066772319717d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535599554406831d, y: 0.520235287957038d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3823126691902783d, y: 0.07012660898409873d), new NpgsqlTypes.NpgsqlPoint(x: 0.19787153805334d, y: 0.5750374104543173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8661564584969113d, y: 0.8358626839385058d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25933637697363077d, y: 0.2230645657071625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8361889993038607d, y: 0.3410813377253036d), new NpgsqlTypes.NpgsqlPoint(x: 0.03263745392779416d, y: 0.9372674690122711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5524477795672754d, y: 0.45524947503748525d), new NpgsqlTypes.NpgsqlPoint(x: 0.28618402109382335d, y: 0.18809095889864536d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607277145175255d, y: 0.5278719236631655d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14309211080555573d, y: 0.9661131909023792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868380464873883d, y: 0.9166863340396232d), new NpgsqlTypes.NpgsqlPoint(x: 0.6325039849345259d, y: 0.2939327965959666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.825748162485067d, y: 0.22580744768057948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647992856439822d, y: 0.9712417091066758d), new NpgsqlTypes.NpgsqlPoint(x: 0.11313943538830751d, y: 0.367914822161574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9161633855901395d, y: 0.007761391612771118d), new NpgsqlTypes.NpgsqlPoint(x: 0.503164879329494d, y: 0.17334026532499813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8471331430672737d, y: 0.3967124451143339d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5002138608685918d, y: 0.6626312993579044d), new NpgsqlTypes.NpgsqlPoint(x: 0.414397541815281d, y: 0.7932011553212772d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623524343221523d, y: 0.5143109334164121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9869554686851503d, y: 0.5052620046010209d), new NpgsqlTypes.NpgsqlPoint(x: 0.24034027969011595d, y: 0.3890282821635268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356443135941291d, y: 0.6791607521539267d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09683247180460475d, y: 0.22217566856156667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7863291232387307d, y: 0.009303820993021406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620974170969178d, y: 0.09262153003364537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5194760357348339d, y: 0.3302550563547414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526286863275756d, y: 0.5432803328984355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139130752970607d, y: 0.9227994126340759d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26252339361095034d, y: 0.009286979202406176d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392940259176467d, y: 0.6528684182502553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413372961349769d, y: 0.5529366924892525d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8293156100209169d, y: 0.7758867472243859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825670950374215d, y: 0.537723524887092d), new NpgsqlTypes.NpgsqlPoint(x: 0.829264048618142d, y: 0.6370934005038977d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8104970589332418d, y: 0.6598412390176365d), new NpgsqlTypes.NpgsqlPoint(x: 0.27316203970922015d, y: 0.2550053651144334d), new NpgsqlTypes.NpgsqlPoint(x: 0.46834465513007695d, y: 0.07782334877301722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6580129330366256d, y: 0.8536396147078352d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746572641143431d, y: 0.16958030129616652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711967301125718d, y: 0.22330078768297634d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8032196134103353d, y: 0.84393572862647d), new NpgsqlTypes.NpgsqlPoint(x: 0.33685974800104834d, y: 0.8970805330631543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7519259633149237d, y: 0.34435718412995364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7558135735164111d, y: 0.5826033424459499d), new NpgsqlTypes.NpgsqlPoint(x: 0.01050495425589304d, y: 0.7353968242423498d), new NpgsqlTypes.NpgsqlPoint(x: 0.2810078108185077d, y: 0.9527597511491706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9636623403421875d, y: 0.8386197909115524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055898761702613d, y: 0.10264096821586743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242463362985615d, y: 0.24724090235963425d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19515466589006536d, y: 0.5895303470786858d), new NpgsqlTypes.NpgsqlPoint(x: 0.46725827336533965d, y: 0.599648222987916d), new NpgsqlTypes.NpgsqlPoint(x: 0.43840457136642874d, y: 0.303195954696986d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8082891114256483d, y: 0.33704678405948585d), new NpgsqlTypes.NpgsqlPoint(x: 0.008491157920796355d, y: 0.7097305471420867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3571885479635917d, y: 0.08203274876257471d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45070197399420076d, y: 0.9485901195250264d), new NpgsqlTypes.NpgsqlPoint(x: 0.46804638433806955d, y: 0.5025011965964874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5067398171142848d, y: 0.5236852181437129d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15699376597581738d, y: 0.37002326989420364d), new NpgsqlTypes.NpgsqlPoint(x: 0.011741965185045222d, y: 0.4524679177200096d), new NpgsqlTypes.NpgsqlPoint(x: 0.18308764196772254d, y: 0.9884994785331528d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44393656236701773d, y: 0.3841693155302557d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222741914500439d, y: 0.0006605246190234393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907564304167259d, y: 0.10187890321860438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8164338895238418d, y: 0.12534238836770473d), new NpgsqlTypes.NpgsqlPoint(x: 0.37470991936089226d, y: 0.6605976963334176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853378512877489d, y: 0.08774123394582634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.565570830041173d, y: 0.08974308550326371d), new NpgsqlTypes.NpgsqlPoint(x: 0.28012056205564884d, y: 0.951765234046215d), new NpgsqlTypes.NpgsqlPoint(x: 0.47656033521841856d, y: 0.21672568420310767d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5922445018198329d, y: 0.7575059593858278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557249464759353d, y: 0.011036118116466653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172074148601386d, y: 0.9627688189848066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05533448475438729d, y: 0.722077523544911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6589188056284409d, y: 0.2095041541495628d), new NpgsqlTypes.NpgsqlPoint(x: 0.046332510717119746d, y: 0.12811160351782247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7884496011743032d, y: 0.16547766590296753d), new NpgsqlTypes.NpgsqlPoint(x: 0.4055323284137363d, y: 0.1971618370105669d), new NpgsqlTypes.NpgsqlPoint(x: 0.6992532901523393d, y: 0.4167851090575454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09823714589640242d, y: 0.16202675130444555d), new NpgsqlTypes.NpgsqlPoint(x: 0.36100125844497577d, y: 0.39851460234585523d), new NpgsqlTypes.NpgsqlPoint(x: 0.27987439581769d, y: 0.9370217067815726d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6080754600171367d, y: 0.8274765761826557d), new NpgsqlTypes.NpgsqlPoint(x: 0.05286328901751913d, y: 0.5408239924851866d), new NpgsqlTypes.NpgsqlPoint(x: 0.24835612030997223d, y: 0.13859536725177957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5794293852662671d, y: 0.1190106601476838d), new NpgsqlTypes.NpgsqlPoint(x: 0.4570397148888582d, y: 0.6946129134147202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460486691775719d, y: 0.15840671012849838d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44292506845637747d, y: 0.7189836491353183d), new NpgsqlTypes.NpgsqlPoint(x: 0.65983772317515d, y: 0.5091574726228385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352698961124074d, y: 0.939755958043895d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4266303607415163d, y: 0.38548476091896355d), new NpgsqlTypes.NpgsqlPoint(x: 0.28512621133864813d, y: 0.6173609283990278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207337195604565d, y: 0.06882425468018738d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8765111910033357d, y: 0.2025345453761893d), new NpgsqlTypes.NpgsqlPoint(x: 0.17659991040113276d, y: 0.4525586565472808d), new NpgsqlTypes.NpgsqlPoint(x: 0.597456164302374d, y: 0.2606412935541853d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5311394990808148d, y: 0.8751080546503379d), new NpgsqlTypes.NpgsqlPoint(x: 0.24940027959887445d, y: 0.5573843603241981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5310606710900495d, y: 0.7714484507861415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8363456127123319d, y: 0.04685916498675813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659605408829405d, y: 0.7393233792166126d), new NpgsqlTypes.NpgsqlPoint(x: 0.2955843909587831d, y: 0.467942096583425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030845654641751707d, y: 0.3013805500172213d), new NpgsqlTypes.NpgsqlPoint(x: 0.12304108950782067d, y: 0.07607585211783541d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499026175718969d, y: 0.5067974426142838d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08660923475149385d, y: 0.20211737216325543d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078975986437533d, y: 0.2621851940392842d), new NpgsqlTypes.NpgsqlPoint(x: 0.5926596601041535d, y: 0.879111603875973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14447900758121623d, y: 0.17851987443546846d), new NpgsqlTypes.NpgsqlPoint(x: 0.3779686328503087d, y: 0.2115589062728962d), new NpgsqlTypes.NpgsqlPoint(x: 0.0851951766061354d, y: 0.682189081194381d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46614663694418734d, y: 0.38574616431697994d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301178505849689d, y: 0.44416148437665104d), new NpgsqlTypes.NpgsqlPoint(x: 0.49622439718327516d, y: 0.9795620688148876d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01798929083112688d, y: 0.9914164141427312d), new NpgsqlTypes.NpgsqlPoint(x: 0.40156620587106184d, y: 0.6882366976778097d), new NpgsqlTypes.NpgsqlPoint(x: 0.01416386909599443d, y: 0.7273330069731256d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9879016153957129d, y: 0.097700839031439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310877833422714d, y: 0.5073963933542606d), new NpgsqlTypes.NpgsqlPoint(x: 0.737442995183203d, y: 0.4516080347407815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20201635442683896d, y: 0.079043403902476d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137375581156776d, y: 0.7919125790586197d), new NpgsqlTypes.NpgsqlPoint(x: 0.3622266623873668d, y: 0.40489117308990397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3058210013015227d, y: 0.37653251330674875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590060255999217d, y: 0.5720683241888391d), new NpgsqlTypes.NpgsqlPoint(x: 0.14040149821878778d, y: 0.8822827976658518d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4610310598300361d, y: 0.6979074771420782d), new NpgsqlTypes.NpgsqlPoint(x: 0.07348085166069074d, y: 0.9248779818146317d), new NpgsqlTypes.NpgsqlPoint(x: 0.08353546656491162d, y: 0.418306061232677d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2897846181410203d, y: 0.8971444812191749d), new NpgsqlTypes.NpgsqlPoint(x: 0.7367099202653323d, y: 0.9868952366574267d), new NpgsqlTypes.NpgsqlPoint(x: 0.055846566618729d, y: 0.7058117695941651d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1950452584124166d, y: 0.1067116163693913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926076562220008d, y: 0.876122447160789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798276338495901d, y: 0.966939198144502d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5294553113956684d, y: 0.7216678300151675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729616125411809d, y: 0.4637582378401208d), new NpgsqlTypes.NpgsqlPoint(x: 0.46363345401624967d, y: 0.8334885764291468d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7029489524238064d, y: 0.09279617925357075d), new NpgsqlTypes.NpgsqlPoint(x: 0.044987456803114556d, y: 0.829791746754872d), new NpgsqlTypes.NpgsqlPoint(x: 0.11431637893950275d, y: 0.3333760642962599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4364059732991068d, y: 0.13992794177112644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225075240730811d, y: 0.82702338733831d), new NpgsqlTypes.NpgsqlPoint(x: 0.09162860253358185d, y: 0.10667405923503481d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6722082454043081d, y: 0.35631427697643436d), new NpgsqlTypes.NpgsqlPoint(x: 0.877108909435487d, y: 0.9846015936722152d), new NpgsqlTypes.NpgsqlPoint(x: 0.17411283582632187d, y: 0.6798140390732765d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8351035278605775d, y: 0.9858989638984383d), new NpgsqlTypes.NpgsqlPoint(x: 0.15571936159563304d, y: 0.4736874261047507d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747604585106084d, y: 0.14279776700729674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33389836668269934d, y: 0.7468065163355362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8105622831614953d, y: 0.6055061724107547d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976259560328943d, y: 0.6140500315595558d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9981758854981683d, y: 0.5889698779036716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7021873284203528d, y: 0.4742925239216802d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136281735492527d, y: 0.47056090865700284d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07282288029488004d, y: 0.007919215988126505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021480409186856d, y: 0.04209282976911022d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238430692238726d, y: 0.011816390763608076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030080272639630645d, y: 0.522332752260991d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156355981174651d, y: 0.47502200715718823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9245781038066754d, y: 0.8117792865689724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48625753530490934d, y: 0.2031085205172789d), new NpgsqlTypes.NpgsqlPoint(x: 0.3655689634459708d, y: 0.7244903355836929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975165164008638d, y: 0.32199882407563196d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08130461200604278d, y: 0.933470904106261d), new NpgsqlTypes.NpgsqlPoint(x: 0.26733951573786185d, y: 0.2512441659972685d), new NpgsqlTypes.NpgsqlPoint(x: 0.12189235008385191d, y: 0.5437449139720637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8516950858716482d, y: 0.7015393462581901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4867209748453618d, y: 0.22404558963598353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188235173869395d, y: 0.7118773245910243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.536823008711424d, y: 0.03158427039093514d), new NpgsqlTypes.NpgsqlPoint(x: 0.29467320555028276d, y: 0.2265776625651469d), new NpgsqlTypes.NpgsqlPoint(x: 0.48224429675465985d, y: 0.3153183575748578d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431610428566388d, y: 0.8627624899932788d), new NpgsqlTypes.NpgsqlPoint(x: 0.512894018062565d, y: 0.7313522977917555d), new NpgsqlTypes.NpgsqlPoint(x: 0.19104439800790107d, y: 0.031248646963773163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8427108855769305d, y: 0.648239037904329d), new NpgsqlTypes.NpgsqlPoint(x: 0.05035279943903648d, y: 0.37060543415008196d), new NpgsqlTypes.NpgsqlPoint(x: 0.23403084458899515d, y: 0.9509844040397255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3560933437714726d, y: 0.4051505339765925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872560338257358d, y: 0.5180335648860097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9945096671808684d, y: 0.13149176695800036d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7731349917189771d, y: 0.9729589014374169d), new NpgsqlTypes.NpgsqlPoint(x: 0.28041479442997075d, y: 0.008110153797287412d), new NpgsqlTypes.NpgsqlPoint(x: 0.17571933643326065d, y: 0.8678202501175087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5525562709664891d, y: 0.37289508556128936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971310125249012d, y: 0.02993177432612426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8191047920922602d, y: 0.4485642861028263d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7077069749540541d, y: 0.9074805402136168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8443739071699785d, y: 0.2406528799094504d), new NpgsqlTypes.NpgsqlPoint(x: 0.4745480515088999d, y: 0.9129612481758251d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7533096585466788d, y: 0.564147762680689d), new NpgsqlTypes.NpgsqlPoint(x: 0.5735201745426266d, y: 0.24829744250513985d), new NpgsqlTypes.NpgsqlPoint(x: 0.31102304790071256d, y: 0.66825738090943d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5964560867053015d, y: 0.7682211865402532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102988157351144d, y: 0.8383581476071857d), new NpgsqlTypes.NpgsqlPoint(x: 0.7238106938415682d, y: 0.6810156302859028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8190243784218896d, y: 0.612867057209306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3274670945168673d, y: 0.5265079405024076d), new NpgsqlTypes.NpgsqlPoint(x: 0.25626928658275716d, y: 0.136887460331928d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8811198440646714d, y: 0.5307046473496615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7197250965012256d, y: 0.19762046103645492d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437047595050168d, y: 0.8834824357070066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8355463749961333d, y: 0.8943633828652078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4206440724739766d, y: 0.5590007574617667d), new NpgsqlTypes.NpgsqlPoint(x: 0.18961219364783066d, y: 0.9470558079648729d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6223405008742572d, y: 0.8634187204259954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2843049625585712d, y: 0.5934551823491201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859345085841087d, y: 0.46618325575499986d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.983465234726292d, y: 0.04516950546474885d), new NpgsqlTypes.NpgsqlPoint(x: 0.37031427218158164d, y: 0.5957511485995229d), new NpgsqlTypes.NpgsqlPoint(x: 0.40653716516578753d, y: 0.30889968731166795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7544403726197402d, y: 0.2887149235812859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158104361052099d, y: 0.17578657980593526d), new NpgsqlTypes.NpgsqlPoint(x: 0.31674520921686766d, y: 0.7804319459495408d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28986502667907066d, y: 0.4013225797090846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5979737495055033d, y: 0.4104038964111809d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460573249889765d, y: 0.9678764752845447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6033168725571314d, y: 0.9678666216416875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750423829351032d, y: 0.3300067317264602d), new NpgsqlTypes.NpgsqlPoint(x: 0.3591210642138445d, y: 0.3950482156102403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9267778302263064d, y: 0.7526050783724672d), new NpgsqlTypes.NpgsqlPoint(x: 0.1032409784261018d, y: 0.9746370466895377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9546399326321148d, y: 0.9193449833992617d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9139955768094219d, y: 0.5048193688110308d), new NpgsqlTypes.NpgsqlPoint(x: 0.2284669597580926d, y: 0.6478996038675496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5771580146887804d, y: 0.6102329367694769d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4471887163754775d, y: 0.40381356987609673d), new NpgsqlTypes.NpgsqlPoint(x: 0.030728658273955767d, y: 0.32377357886339586d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370999599315732d, y: 0.9655377753460604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08218025639515214d, y: 0.2627580820716995d), new NpgsqlTypes.NpgsqlPoint(x: 0.905079081478223d, y: 0.7655137912042833d), new NpgsqlTypes.NpgsqlPoint(x: 0.1641904451509829d, y: 0.7422938224035661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7336004433444615d, y: 0.5478578881161551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927353018307894d, y: 0.9876019915791036d), new NpgsqlTypes.NpgsqlPoint(x: 0.8826260305064737d, y: 0.7026836359577016d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6447811451203453d, y: 0.6531291271785938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023366721861321d, y: 0.642612771316524d), new NpgsqlTypes.NpgsqlPoint(x: 0.11395375280550213d, y: 0.0833723167821473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18789839578529455d, y: 0.8946058969225943d), new NpgsqlTypes.NpgsqlPoint(x: 0.25788357502550596d, y: 0.9497165180589335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6959148436588055d, y: 0.8681603840867115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8075133354003264d, y: 0.3344529224893239d), new NpgsqlTypes.NpgsqlPoint(x: 0.43911302802296126d, y: 0.23994913205745705d), new NpgsqlTypes.NpgsqlPoint(x: 0.43525962856561895d, y: 0.36843596743316076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06677828235202721d, y: 0.7759925697535441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244705220411334d, y: 0.4087310607072401d), new NpgsqlTypes.NpgsqlPoint(x: 0.44858025840204674d, y: 0.9616148914792476d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005109962534289081d, y: 0.927139396639979d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643109154490972d, y: 0.42099904106585173d), new NpgsqlTypes.NpgsqlPoint(x: 0.3605517565652946d, y: 0.6412082415401326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2987933237199458d, y: 0.8476804556826745d), new NpgsqlTypes.NpgsqlPoint(x: 0.045365160655232106d, y: 0.2491961989766288d), new NpgsqlTypes.NpgsqlPoint(x: 0.24528304691392533d, y: 0.3671339997609431d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11530040840431066d, y: 0.8155914974718755d), new NpgsqlTypes.NpgsqlPoint(x: 0.880884164749396d, y: 0.9454290566027751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128641297154684d, y: 0.7712235228362238d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9724702573254917d, y: 0.25493889392115865d), new NpgsqlTypes.NpgsqlPoint(x: 0.7499985196677249d, y: 0.45218354417483686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6911091607029217d, y: 0.7051649032617282d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15914704447732253d, y: 0.2964599827920371d), new NpgsqlTypes.NpgsqlPoint(x: 0.4550118560806695d, y: 0.6392686521367068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095872277679496d, y: 0.36104499881716434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06834648918908104d, y: 0.7002824863298109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388250509439492d, y: 0.4132437891464519d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057676269905251d, y: 0.10048972738608386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03786316593714345d, y: 0.5894029473162086d), new NpgsqlTypes.NpgsqlPoint(x: 0.27556962021300135d, y: 0.8551631149487562d), new NpgsqlTypes.NpgsqlPoint(x: 0.2931732671206265d, y: 0.6064116995538904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9494449223103747d, y: 0.09181317763932428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6300770931723989d, y: 0.9403129843778705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993311908238732d, y: 0.46139611551668736d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019519005813363632d, y: 0.6813273866441742d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906113963449316d, y: 0.11760357386557452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050824214087309d, y: 0.7600841910742275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6658787842172685d, y: 0.66866277785461d), new NpgsqlTypes.NpgsqlPoint(x: 0.3344182153650799d, y: 0.3480277664633048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612132041783529d, y: 0.6056974162164687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957010968843521d, y: 0.16252280774293837d), new NpgsqlTypes.NpgsqlPoint(x: 0.12842135868960036d, y: 0.8197272922521976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617805097212238d, y: 0.7660215800873109d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21904148865524276d, y: 0.8788554488995319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7911106062998667d, y: 0.08732985468129673d), new NpgsqlTypes.NpgsqlPoint(x: 0.47803081848082507d, y: 0.9025354432012535d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8005549281355294d, y: 0.5910338370391345d), new NpgsqlTypes.NpgsqlPoint(x: 0.11255124940456784d, y: 0.01321783695790224d), new NpgsqlTypes.NpgsqlPoint(x: 0.424229499361259d, y: 0.9489984081970568d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2705076514371476d, y: 0.9100077724094972d), new NpgsqlTypes.NpgsqlPoint(x: 0.664255462165222d, y: 0.9724520817977962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746729511310279d, y: 0.8840410064507535d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41408538592116584d, y: 0.24915375348282331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366936941896739d, y: 0.1954808153604073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078885131004135d, y: 0.6635222338157352d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26632773916755914d, y: 0.03450991279297444d), new NpgsqlTypes.NpgsqlPoint(x: 0.47543260018456124d, y: 0.3824357807071581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553141514130782d, y: 0.6364488337807945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021141939729550918d, y: 0.3056407170845701d), new NpgsqlTypes.NpgsqlPoint(x: 0.40047691268722174d, y: 0.003361587097025165d), new NpgsqlTypes.NpgsqlPoint(x: 0.2040714437109319d, y: 0.9674092972257291d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9713799155790255d, y: 0.41335572146108235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383654974129198d, y: 0.8324479832017951d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617699277520086d, y: 0.9985798152268706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36161323790725275d, y: 0.6087953311089944d), new NpgsqlTypes.NpgsqlPoint(x: 0.2990812517733151d, y: 0.24688048108685612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117072430636536d, y: 0.6804436184030918d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41864565934812514d, y: 0.651917161742496d), new NpgsqlTypes.NpgsqlPoint(x: 0.4547082724839271d, y: 0.14549162383979208d), new NpgsqlTypes.NpgsqlPoint(x: 0.0603314353809602d, y: 0.3576190071421915d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38224757703201884d, y: 0.5860980605786912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7507736602137955d, y: 0.7606999026480127d), new NpgsqlTypes.NpgsqlPoint(x: 0.23482623616852194d, y: 0.7524367325801781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30256587322583406d, y: 0.21694628267940907d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499523623542315d, y: 0.6722994909484078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4489133490721805d, y: 0.8333989737863693d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9092886021121078d, y: 0.9415219932202249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482470710842243d, y: 0.911601976110165d), new NpgsqlTypes.NpgsqlPoint(x: 0.28600632317212815d, y: 0.20057540741003155d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46938939573232985d, y: 0.10667427308075894d), new NpgsqlTypes.NpgsqlPoint(x: 0.45917913656047693d, y: 0.5485368774330707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388742756923363d, y: 0.6991292728661904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22249228556381606d, y: 0.47455650482738665d), new NpgsqlTypes.NpgsqlPoint(x: 0.1317129726532299d, y: 0.7442212351777314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813183387545285d, y: 0.8957576129081606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33329398428696133d, y: 0.48647935245507923d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215830308326976d, y: 0.9584564508960765d), new NpgsqlTypes.NpgsqlPoint(x: 0.33307791840228507d, y: 0.939299658042458d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7175471518428627d, y: 0.8354969390652675d), new NpgsqlTypes.NpgsqlPoint(x: 0.31552147871385927d, y: 0.1515923969584243d), new NpgsqlTypes.NpgsqlPoint(x: 0.7444933660696803d, y: 0.17503550256178402d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6374142779478476d, y: 0.026360299327787606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051233762078714d, y: 0.8571821952100198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8443549366381093d, y: 0.8766829121085865d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010886197471808967d, y: 0.6587844384193553d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101656553287869d, y: 0.862761969094905d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841217285370992d, y: 0.2791325861653968d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26355389014144903d, y: 0.12764324945147465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4310917919005748d, y: 0.6489411943332719d), new NpgsqlTypes.NpgsqlPoint(x: 0.5916874365162046d, y: 0.2872024889029956d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7452131867837937d, y: 0.20713936634639807d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680991858465719d, y: 0.09459541345504918d), new NpgsqlTypes.NpgsqlPoint(x: 0.37397114883085025d, y: 0.4388296430442534d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023878613453250375d, y: 0.5110674346448878d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954471364258378d, y: 0.2650757320031254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9452671129943209d, y: 0.05621396893794295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8910294391174312d, y: 0.1938908062615241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9605286002632571d, y: 0.17361358665946014d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943763012293211d, y: 0.4490601027085388d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09900605020824271d, y: 0.5835451682939468d), new NpgsqlTypes.NpgsqlPoint(x: 0.625227185842073d, y: 0.18331630635681728d), new NpgsqlTypes.NpgsqlPoint(x: 0.37041935201393517d, y: 0.009443806596520443d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 20, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 139, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatchAsync(connection, 122, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatch(connection, 74, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

