

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
    internal partial interface INpgsqlLineMArraylineMMArrayD1
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD1 : INpgsqlLineMArraylineMMArrayD1
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD1E1M[] _testData = new NpgsqlLinelineMMArrayD1E1M[]
        {
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4944934573041265d, b: 0.38684440978187884d, c: 0.26670352942492814d),
new NpgsqlTypes.NpgsqlLine(a: 0.08926694798065749d, b: 0.4476051423214109d, c: 0.7721414980124189d),
new NpgsqlTypes.NpgsqlLine(a: 0.777098834140595d, b: 0.5381265242797555d, c: 0.040657638807312435d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.599468015698646d, b: 0.3342802302518598d, c: 0.7221652295928784d),
new NpgsqlTypes.NpgsqlLine(a: 0.2014506890415687d, b: 0.3853767944628518d, c: 0.6938876004028918d),
new NpgsqlTypes.NpgsqlLine(a: 0.3361185445380419d, b: 0.1873332685782927d, c: 0.20064622746640715d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07248140649680268d, b: 0.10100862277491718d, c: 0.7073132862587613d),
new NpgsqlTypes.NpgsqlLine(a: 0.6706154257941335d, b: 0.569405376620311d, c: 0.3522228624385252d),
new NpgsqlTypes.NpgsqlLine(a: 0.01659442296522262d, b: 0.9281850190075993d, c: 0.7126507407063246d),
new NpgsqlTypes.NpgsqlLine(a: 0.169872338670933d, b: 0.7276286429452901d, c: 0.7489207073922672d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29053099617840716d, b: 0.6838014743682729d, c: 0.017552502307497053d),
new NpgsqlTypes.NpgsqlLine(a: 0.34926943198410587d, b: 0.34224388233928227d, c: 0.9070485326138383d),
new NpgsqlTypes.NpgsqlLine(a: 0.27914445567405854d, b: 0.5361702077345929d, c: 0.9228078710190672d),
new NpgsqlTypes.NpgsqlLine(a: 0.2024146589819117d, b: 0.4790837204585031d, c: 0.48586904615576587d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07156873514697648d, b: 0.0009021210237212252d, c: 0.6872007349510308d),
new NpgsqlTypes.NpgsqlLine(a: 0.2996333237225065d, b: 0.638435029842332d, c: 0.9572408450405686d),
new NpgsqlTypes.NpgsqlLine(a: 0.5366727152535659d, b: 0.3137949011989325d, c: 0.9454738965654695d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5146387635010933d, b: 0.7625469325228746d, c: 0.8303359503366412d),
new NpgsqlTypes.NpgsqlLine(a: 0.981197897252613d, b: 0.9455715558136429d, c: 0.4289247675670247d),
new NpgsqlTypes.NpgsqlLine(a: 0.5423023671428907d, b: 0.07991469247441618d, c: 0.32869506729536513d),
new NpgsqlTypes.NpgsqlLine(a: 0.5238748299033787d, b: 0.5875842080439733d, c: 0.11721853362849188d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6493441830230711d, b: 0.635093537590089d, c: 0.755599419178743d),
new NpgsqlTypes.NpgsqlLine(a: 0.2859579630842568d, b: 0.6317477478551038d, c: 0.2702553258968994d),
new NpgsqlTypes.NpgsqlLine(a: 0.6782826051876116d, b: 0.6782498780464195d, c: 0.424692470080842d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7218613439026466d, b: 0.4508211671842174d, c: 0.3234522213435359d),
new NpgsqlTypes.NpgsqlLine(a: 0.21291426489473475d, b: 0.8040731052176753d, c: 0.6568207732570722d),
new NpgsqlTypes.NpgsqlLine(a: 0.690513574457282d, b: 0.5155254838809539d, c: 0.9400272967124547d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6686179041452991d, b: 0.5725078050059007d, c: 0.2072262990368765d),
new NpgsqlTypes.NpgsqlLine(a: 0.2654250742821316d, b: 0.5256771450218978d, c: 0.9175191225721034d),
new NpgsqlTypes.NpgsqlLine(a: 0.6851529842056097d, b: 0.15204394986052505d, c: 0.8250291923797372d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9404053238324203d, b: 0.0634218549675567d, c: 0.5356020868042528d),
new NpgsqlTypes.NpgsqlLine(a: 0.9582460645802137d, b: 0.8809411941625499d, c: 0.5162441658125674d),
new NpgsqlTypes.NpgsqlLine(a: 0.5550738971528715d, b: 0.47302627061565083d, c: 0.08362031506236134d),
new NpgsqlTypes.NpgsqlLine(a: 0.2963303368443164d, b: 0.024989266887411876d, c: 0.7148897891837237d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7965556215012136d, b: 0.04668605170533913d, c: 0.9909759108494866d),
new NpgsqlTypes.NpgsqlLine(a: 0.6302999446485965d, b: 0.29317239094409175d, c: 0.5447294879451796d),
new NpgsqlTypes.NpgsqlLine(a: 0.7248283699496872d, b: 0.5467737360803707d, c: 0.008551444198762637d),
new NpgsqlTypes.NpgsqlLine(a: 0.9762215052586731d, b: 0.8360755864920059d, c: 0.5822112780752967d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.202042431408186d, b: 0.7634973911785522d, c: 0.8704038394829648d),
new NpgsqlTypes.NpgsqlLine(a: 0.25743012631205675d, b: 0.9761937573527499d, c: 0.9350729651363726d),
new NpgsqlTypes.NpgsqlLine(a: 0.9929281842315958d, b: 0.21110292309911072d, c: 0.8529235195088221d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.595391046253996d, b: 0.6394588427232367d, c: 0.7551725210679541d),
new NpgsqlTypes.NpgsqlLine(a: 0.9092227247680701d, b: 0.20731225359728944d, c: 0.8410229294811412d),
new NpgsqlTypes.NpgsqlLine(a: 0.9212956801476154d, b: 0.384350756576436d, c: 0.32949436194512316d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4928093340258237d, b: 0.33978183435215625d, c: 0.7418972712618512d),
new NpgsqlTypes.NpgsqlLine(a: 0.8997371972301171d, b: 0.4715187924518587d, c: 0.8573593351127012d),
new NpgsqlTypes.NpgsqlLine(a: 0.4378380531574636d, b: 0.005981386340859762d, c: 0.9231979823451862d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6584603820447724d, b: 0.7275312096159289d, c: 0.5426082984576096d),
new NpgsqlTypes.NpgsqlLine(a: 0.5261239005540154d, b: 0.8907341606238621d, c: 0.046279332680620566d),
new NpgsqlTypes.NpgsqlLine(a: 0.7858295954346621d, b: 0.002231783893717698d, c: 0.5264187422389158d),
new NpgsqlTypes.NpgsqlLine(a: 0.7728907795750897d, b: 0.010163466511034502d, c: 0.9955669166305693d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2645837705868479d, b: 0.8789009557335913d, c: 0.4663970269947534d),
new NpgsqlTypes.NpgsqlLine(a: 0.06842690391464978d, b: 0.928755850996068d, c: 0.06932698881267185d),
new NpgsqlTypes.NpgsqlLine(a: 0.5317287148518273d, b: 0.01483739656058003d, c: 0.29471570619932286d),
new NpgsqlTypes.NpgsqlLine(a: 0.5664574816078313d, b: 0.09068787986514448d, c: 0.8209714723993717d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9385682472879566d, b: 0.7140425200189425d, c: 0.021384905036465396d),
new NpgsqlTypes.NpgsqlLine(a: 0.6706586335052604d, b: 0.65586151091771d, c: 0.1165699483432272d),
new NpgsqlTypes.NpgsqlLine(a: 0.0175040775041182d, b: 0.6500306186411199d, c: 0.008399311990601399d),
new NpgsqlTypes.NpgsqlLine(a: 0.26142394811082925d, b: 0.17610757506752506d, c: 0.8033566640087685d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.863648606009316d, b: 0.1004661926726671d, c: 0.550675129293957d),
new NpgsqlTypes.NpgsqlLine(a: 0.8305125429364439d, b: 0.215976544174998d, c: 0.4799805027095728d),
new NpgsqlTypes.NpgsqlLine(a: 0.8838788383576116d, b: 0.34569227402325586d, c: 0.45393196617289877d),
new NpgsqlTypes.NpgsqlLine(a: 0.44804109444863494d, b: 0.24686889681001034d, c: 0.867859298932573d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5015413625266218d, b: 0.08480612352290418d, c: 0.20952442432465868d),
new NpgsqlTypes.NpgsqlLine(a: 0.6546372714376955d, b: 0.06550929666251415d, c: 0.1912884985982638d),
new NpgsqlTypes.NpgsqlLine(a: 5.7577601108027565E-06d, b: 0.705201856324812d, c: 0.5211240497899667d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8419079624684794d, b: 0.6496247781857349d, c: 0.3063384962573401d),
new NpgsqlTypes.NpgsqlLine(a: 0.17941140108728704d, b: 0.2245331467063667d, c: 0.6974565244912444d),
new NpgsqlTypes.NpgsqlLine(a: 0.9823366956011705d, b: 0.6857589166559668d, c: 0.22059641192774992d),
new NpgsqlTypes.NpgsqlLine(a: 0.8274823062365442d, b: 0.2537797042382417d, c: 0.3796201583211479d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.282446988260055d, b: 0.3597550981082409d, c: 0.030020319215186442d),
new NpgsqlTypes.NpgsqlLine(a: 0.8786125805514057d, b: 0.4756487657505426d, c: 0.7818201197064402d),
new NpgsqlTypes.NpgsqlLine(a: 0.12719940481795233d, b: 0.7631633087922991d, c: 0.2227300270789102d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5099776591894853d, b: 0.8684928550905671d, c: 0.48221664562122457d),
new NpgsqlTypes.NpgsqlLine(a: 0.4297841823665808d, b: 0.3381136361333933d, c: 0.3232027777251536d),
new NpgsqlTypes.NpgsqlLine(a: 0.09595922472100349d, b: 0.23897145832845967d, c: 0.20077574803723675d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.327922049995623d, b: 0.3311179595543574d, c: 0.3857028610897111d),
new NpgsqlTypes.NpgsqlLine(a: 0.2661313934837034d, b: 0.41747756104619727d, c: 0.1008726598591555d),
new NpgsqlTypes.NpgsqlLine(a: 0.488399411513734d, b: 0.8509771945031203d, c: 0.908308344617074d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.004246649856873508d, b: 0.844487784278062d, c: 0.8610361520665238d),
new NpgsqlTypes.NpgsqlLine(a: 0.5899471619699969d, b: 0.36577628982536436d, c: 0.06065403818006465d),
new NpgsqlTypes.NpgsqlLine(a: 0.2180626190103322d, b: 0.17275740644933724d, c: 0.6282909510535405d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7644142116992321d, b: 0.48303068274212835d, c: 0.33279827808051654d),
new NpgsqlTypes.NpgsqlLine(a: 0.7690387296657955d, b: 0.7719524239954059d, c: 0.43439204354523253d),
new NpgsqlTypes.NpgsqlLine(a: 0.25417150690500645d, b: 0.1644068682125105d, c: 0.33321233562776786d),
new NpgsqlTypes.NpgsqlLine(a: 0.37856527928997163d, b: 0.3020448122566112d, c: 0.21915085968501735d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2148473206461855d, b: 0.2794204118241863d, c: 0.8326317393832693d),
new NpgsqlTypes.NpgsqlLine(a: 0.0365114124413497d, b: 0.1885968739727989d, c: 0.9943973950434327d),
new NpgsqlTypes.NpgsqlLine(a: 0.3984272020005951d, b: 0.27341544012652086d, c: 0.3067831153793802d),
new NpgsqlTypes.NpgsqlLine(a: 0.6527663481725879d, b: 0.2934325389493063d, c: 0.4636172582210828d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9212644783603886d, b: 0.5307813016419596d, c: 0.0186031000635003d),
new NpgsqlTypes.NpgsqlLine(a: 0.4398701877710909d, b: 0.160077834788795d, c: 0.5981769820758668d),
new NpgsqlTypes.NpgsqlLine(a: 0.1780717102197169d, b: 0.6924702141233642d, c: 0.8570244144389558d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6787270409831903d, b: 0.3216432354944757d, c: 0.9098248943978321d),
new NpgsqlTypes.NpgsqlLine(a: 0.3954119775992775d, b: 0.7954427300094487d, c: 0.11387843330512559d),
new NpgsqlTypes.NpgsqlLine(a: 0.10927319791219559d, b: 0.949502881243586d, c: 0.6549319243050608d),
new NpgsqlTypes.NpgsqlLine(a: 0.5215020024896978d, b: 0.980294724132871d, c: 0.5791545232382246d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5369109769490452d, b: 0.4309435628394127d, c: 0.36992784376354515d),
new NpgsqlTypes.NpgsqlLine(a: 0.6731350807085169d, b: 0.9174281084262578d, c: 0.04779289743452053d),
new NpgsqlTypes.NpgsqlLine(a: 0.03804307710311572d, b: 0.34399905277915777d, c: 0.019608075370397438d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23982701455282462d, b: 0.395947784152605d, c: 0.19758925651123282d),
new NpgsqlTypes.NpgsqlLine(a: 0.6864353779006944d, b: 0.010414139034349734d, c: 0.262267873561823d),
new NpgsqlTypes.NpgsqlLine(a: 0.8466197053051165d, b: 0.551419716128115d, c: 0.4133880257986303d),
new NpgsqlTypes.NpgsqlLine(a: 0.2686947736283365d, b: 0.5678878019215504d, c: 0.9046976850353992d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31217013333763355d, b: 0.8044674693381151d, c: 0.10530812787676991d),
new NpgsqlTypes.NpgsqlLine(a: 0.7244037993330562d, b: 0.001690602232588323d, c: 0.9282115351893963d),
new NpgsqlTypes.NpgsqlLine(a: 0.23248790176065104d, b: 0.9224453675944732d, c: 0.21218686298454326d),
new NpgsqlTypes.NpgsqlLine(a: 0.7844291339376047d, b: 0.943640062366521d, c: 0.8740387126933705d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5342037158728435d, b: 0.259381494154194d, c: 0.015346575550153063d),
new NpgsqlTypes.NpgsqlLine(a: 0.7750682132344976d, b: 0.8390325550589433d, c: 0.10977636851159855d),
new NpgsqlTypes.NpgsqlLine(a: 0.030001938939438366d, b: 0.011707449754463695d, c: 0.6017995317132309d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08584209366545559d, b: 0.022687184069415278d, c: 0.45708685766498136d),
new NpgsqlTypes.NpgsqlLine(a: 0.5578402975205968d, b: 0.8185099087346016d, c: 0.6374349813179053d),
new NpgsqlTypes.NpgsqlLine(a: 0.43993179566103824d, b: 0.9426579570942107d, c: 0.38880901433823867d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09237159340095258d, b: 0.9434524385893011d, c: 0.36763079108762375d),
new NpgsqlTypes.NpgsqlLine(a: 0.6094025127571024d, b: 0.9592118523245942d, c: 0.14942618805434638d),
new NpgsqlTypes.NpgsqlLine(a: 0.320672895213967d, b: 0.8525330686288072d, c: 0.4083606410362486d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3688116064125474d, b: 0.4938786694986639d, c: 0.1855381426656797d),
new NpgsqlTypes.NpgsqlLine(a: 0.9229882106065924d, b: 0.3463622507942823d, c: 0.3592937049275229d),
new NpgsqlTypes.NpgsqlLine(a: 0.39588501815440624d, b: 0.1857394141499259d, c: 0.6414186538585677d),
new NpgsqlTypes.NpgsqlLine(a: 0.5695019129018802d, b: 0.10428038665366579d, c: 0.8235572126491268d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.612220224547386d, b: 0.7113056896025073d, c: 0.3359385650809438d),
new NpgsqlTypes.NpgsqlLine(a: 0.38052781734731034d, b: 0.14836626058694036d, c: 0.7659667884863931d),
new NpgsqlTypes.NpgsqlLine(a: 0.5688924328579931d, b: 0.3712157578695904d, c: 0.38063586542366223d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9483417157139704d, b: 0.05801982723616461d, c: 0.8847622359452001d),
new NpgsqlTypes.NpgsqlLine(a: 0.8852650249803017d, b: 0.23346797485881088d, c: 0.5653095772558567d),
new NpgsqlTypes.NpgsqlLine(a: 0.23726512974105818d, b: 0.3035968566620155d, c: 0.011857853149508268d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9854167561049327d, b: 0.9101736201838031d, c: 0.6303451439550312d),
new NpgsqlTypes.NpgsqlLine(a: 0.7673733013597129d, b: 0.2810242141492748d, c: 0.3929865550215864d),
new NpgsqlTypes.NpgsqlLine(a: 0.5285600847844819d, b: 0.22470175247474566d, c: 0.8375097750119043d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17013873610421737d, b: 0.3818591518174478d, c: 0.07877671687839649d),
new NpgsqlTypes.NpgsqlLine(a: 0.412207455440899d, b: 0.48225833322096257d, c: 0.0049788387108480325d),
new NpgsqlTypes.NpgsqlLine(a: 0.4874597785589182d, b: 0.3470122169260894d, c: 0.15234453388942215d),
new NpgsqlTypes.NpgsqlLine(a: 0.0950806111624295d, b: 0.38933661087611104d, c: 0.15006794747547847d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3878048280511137d, b: 0.114912595122586d, c: 0.45810634943614703d),
new NpgsqlTypes.NpgsqlLine(a: 0.627131191197892d, b: 0.8021754229693572d, c: 0.056913198790794595d),
new NpgsqlTypes.NpgsqlLine(a: 0.46277192370876574d, b: 0.08332331030289863d, c: 0.9999377673512252d),
new NpgsqlTypes.NpgsqlLine(a: 0.7595245428388806d, b: 0.8900916151300893d, c: 0.9184090387064078d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7971170684924037d, b: 0.9968247110548755d, c: 0.1907091253248876d),
new NpgsqlTypes.NpgsqlLine(a: 0.28270744906244405d, b: 0.2879770831496008d, c: 0.7049746234945684d),
new NpgsqlTypes.NpgsqlLine(a: 0.3968481014562336d, b: 0.3267467127542968d, c: 0.588206330732172d),
new NpgsqlTypes.NpgsqlLine(a: 0.1291178972077105d, b: 0.06912966586585056d, c: 0.6737850840215246d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.899250309736513d, b: 0.5657008191366445d, c: 0.1709670034047125d),
new NpgsqlTypes.NpgsqlLine(a: 0.10314158339863366d, b: 0.39765648229706574d, c: 0.854536416012856d),
new NpgsqlTypes.NpgsqlLine(a: 0.04955061634491298d, b: 0.7217646305292115d, c: 0.24398585081111868d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8043150447536834d, b: 0.9859401236762675d, c: 0.7444272601724845d),
new NpgsqlTypes.NpgsqlLine(a: 0.916998442475119d, b: 0.4907971117911345d, c: 0.8699359311654496d),
new NpgsqlTypes.NpgsqlLine(a: 0.4989503684825498d, b: 0.44155046091661754d, c: 0.20176557239188586d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8173280445973097d, b: 0.2453265467784621d, c: 0.9762850200450653d),
new NpgsqlTypes.NpgsqlLine(a: 0.5561140091480161d, b: 0.23383085670234105d, c: 0.1619517344107816d),
new NpgsqlTypes.NpgsqlLine(a: 0.5436429675425163d, b: 0.1206595030494283d, c: 0.9649852158035958d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3507021841909884d, b: 0.6565843626368627d, c: 0.3997030122267179d),
new NpgsqlTypes.NpgsqlLine(a: 0.21416564897906765d, b: 0.3651505859507099d, c: 0.4409004611098879d),
new NpgsqlTypes.NpgsqlLine(a: 0.22190111496880804d, b: 0.832122180833045d, c: 0.3860805149555775d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7589143554637342d, b: 0.5070672736293727d, c: 0.05616385784160305d),
new NpgsqlTypes.NpgsqlLine(a: 0.4288709688847647d, b: 0.24467727303748832d, c: 0.36110396705784176d),
new NpgsqlTypes.NpgsqlLine(a: 0.856153854820992d, b: 0.3982149014161239d, c: 0.8822903684283411d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01001051636666006d, b: 0.18462157717218974d, c: 0.6227293089378781d),
new NpgsqlTypes.NpgsqlLine(a: 0.529251605203136d, b: 0.051769206142051716d, c: 0.5678980600955534d),
new NpgsqlTypes.NpgsqlLine(a: 0.5252662591192845d, b: 0.892608288046702d, c: 0.6115586339804454d),
new NpgsqlTypes.NpgsqlLine(a: 0.8263801477914811d, b: 0.8200223471306523d, c: 0.8594468459058525d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.040084466563430676d, b: 0.43765415174992095d, c: 0.9690897285980766d),
new NpgsqlTypes.NpgsqlLine(a: 0.3276909262216361d, b: 0.3244753361035685d, c: 0.0688533406608205d),
new NpgsqlTypes.NpgsqlLine(a: 0.9231391916759142d, b: 0.28211091618311734d, c: 0.327084833774409d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8085443994671279d, b: 0.8833084564500376d, c: 0.937527951136197d),
new NpgsqlTypes.NpgsqlLine(a: 0.35310832525154656d, b: 0.24956192439032365d, c: 0.4450088387419302d),
new NpgsqlTypes.NpgsqlLine(a: 0.5694849705282348d, b: 0.6068502855366531d, c: 0.7606954833046625d),
new NpgsqlTypes.NpgsqlLine(a: 0.5300475192591181d, b: 0.18891414102347026d, c: 0.4441818550125929d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7630177755783951d, b: 0.6200005063010797d, c: 0.09503584547096156d),
new NpgsqlTypes.NpgsqlLine(a: 0.0678234156382419d, b: 0.24731741777934757d, c: 0.49412206291987104d),
new NpgsqlTypes.NpgsqlLine(a: 0.8353382023974111d, b: 0.32769924077576673d, c: 0.11410890841713017d),
new NpgsqlTypes.NpgsqlLine(a: 0.4103058603367218d, b: 0.20028767401019265d, c: 0.1766560362848888d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1533947178356958d, b: 0.0646206871323376d, c: 0.9887363597392425d),
new NpgsqlTypes.NpgsqlLine(a: 0.06039967213002617d, b: 0.5999449469377529d, c: 0.22701439569533421d),
new NpgsqlTypes.NpgsqlLine(a: 0.4197292421264577d, b: 0.8349760531797951d, c: 0.5067856861512255d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46857728894841877d, b: 0.5161640326408466d, c: 0.2991208375912565d),
new NpgsqlTypes.NpgsqlLine(a: 0.9411466967147585d, b: 0.14512179048607743d, c: 0.10464222063113915d),
new NpgsqlTypes.NpgsqlLine(a: 0.14991481649490146d, b: 0.19010347579769205d, c: 0.10421011605482422d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3568072289470706d, b: 0.9470505746726054d, c: 0.6538162795541063d),
new NpgsqlTypes.NpgsqlLine(a: 0.9230109062331339d, b: 0.050433569301644776d, c: 0.8424937467781796d),
new NpgsqlTypes.NpgsqlLine(a: 0.8320803868595281d, b: 0.19890682141734706d, c: 0.9238197163783055d),
new NpgsqlTypes.NpgsqlLine(a: 0.529630222535d, b: 0.44595161704736996d, c: 0.0639658802054841d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18945846030985214d, b: 0.0446560691553064d, c: 0.7146025055469118d),
new NpgsqlTypes.NpgsqlLine(a: 0.8551597727676806d, b: 0.5512928612748842d, c: 0.10673041901175284d),
new NpgsqlTypes.NpgsqlLine(a: 0.980852624289975d, b: 0.5584198174612508d, c: 0.8262494056507329d),
new NpgsqlTypes.NpgsqlLine(a: 0.8108361329814354d, b: 0.4992669497215244d, c: 0.7173721193277623d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6811842093081311d, b: 0.17350198035542574d, c: 0.2869526956103735d),
new NpgsqlTypes.NpgsqlLine(a: 0.43301752005770355d, b: 0.5852196140574423d, c: 0.7394427890203492d),
new NpgsqlTypes.NpgsqlLine(a: 0.41067826391176754d, b: 0.4162404921878683d, c: 0.058472824333241635d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23039597474458573d, b: 0.15233516096444633d, c: 0.4979691847647948d),
new NpgsqlTypes.NpgsqlLine(a: 0.6081736073063448d, b: 0.733023035478688d, c: 0.629434607911239d),
new NpgsqlTypes.NpgsqlLine(a: 0.363381586298682d, b: 0.6230061936349776d, c: 0.4164694915360593d),
new NpgsqlTypes.NpgsqlLine(a: 0.39975375769996824d, b: 0.8886928947889026d, c: 0.4478527984346783d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04019552462836706d, b: 0.9532237006720371d, c: 0.5192001518069094d),
new NpgsqlTypes.NpgsqlLine(a: 0.6575332390850064d, b: 0.73870313099075d, c: 0.14226252290158692d),
new NpgsqlTypes.NpgsqlLine(a: 0.2704196255063791d, b: 0.8759880544937372d, c: 0.6520246556730043d),
new NpgsqlTypes.NpgsqlLine(a: 0.4125755648919658d, b: 0.3306717972873322d, c: 0.5509717166726906d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9469892152818697d, b: 0.36652920038789183d, c: 0.6019302813066413d),
new NpgsqlTypes.NpgsqlLine(a: 0.43574546102568246d, b: 0.28343779623986276d, c: 0.5703061067055005d),
new NpgsqlTypes.NpgsqlLine(a: 0.7683492342544508d, b: 0.5611780731589903d, c: 0.25627505121701255d),
new NpgsqlTypes.NpgsqlLine(a: 0.927803670621073d, b: 0.8687567984324623d, c: 0.7297118018640691d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3660024658986578d, b: 0.17659301354522627d, c: 0.91864392394491d),
new NpgsqlTypes.NpgsqlLine(a: 0.0650946597452855d, b: 0.44884347035695416d, c: 0.6639855856702926d),
new NpgsqlTypes.NpgsqlLine(a: 0.9154991426643556d, b: 0.8069323247818434d, c: 0.7008315841034688d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.045170289533844055d, b: 0.6833893711193593d, c: 0.644948192205423d),
new NpgsqlTypes.NpgsqlLine(a: 0.9866459566592749d, b: 0.39672221315923917d, c: 0.854228871340552d),
new NpgsqlTypes.NpgsqlLine(a: 0.6846146566536885d, b: 0.041892730687162705d, c: 0.8701132297698895d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07854781402955768d, b: 0.023813603140222628d, c: 0.6619976622140565d),
new NpgsqlTypes.NpgsqlLine(a: 0.9032177714130569d, b: 0.4673206861070709d, c: 0.8357665984373998d),
new NpgsqlTypes.NpgsqlLine(a: 0.02819660817876357d, b: 0.9225530718735329d, c: 0.23299712549895069d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8027089849428718d, b: 0.5436658608477982d, c: 0.7151662986894125d),
new NpgsqlTypes.NpgsqlLine(a: 0.2051428463127375d, b: 0.8968503002125412d, c: 0.6514940194458394d),
new NpgsqlTypes.NpgsqlLine(a: 0.9633450674853639d, b: 0.5862483123391921d, c: 0.1918611272448162d),
new NpgsqlTypes.NpgsqlLine(a: 0.35864747244815276d, b: 0.7495820861829001d, c: 0.6481061108539485d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.624969904634273d, b: 0.4378466813720744d, c: 0.28885751562543205d),
new NpgsqlTypes.NpgsqlLine(a: 0.848901866754129d, b: 0.11242324711824447d, c: 0.24788656747069493d),
new NpgsqlTypes.NpgsqlLine(a: 0.8553877256729285d, b: 0.62541987956344d, c: 0.8298594248710008d),
new NpgsqlTypes.NpgsqlLine(a: 0.003728532797995343d, b: 0.47713666295164214d, c: 0.9990274097728552d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5720000640476658d, b: 0.03081968689016501d, c: 0.3257653877035033d),
new NpgsqlTypes.NpgsqlLine(a: 0.9072702953773137d, b: 0.707322820180984d, c: 0.6705761710291143d),
new NpgsqlTypes.NpgsqlLine(a: 0.23432192236072913d, b: 0.23995767317857053d, c: 0.711721678649177d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6774411602547268d, b: 0.5017049206548565d, c: 0.5791146569324284d),
new NpgsqlTypes.NpgsqlLine(a: 0.7606732360205615d, b: 0.8621339392054046d, c: 0.6584949977671161d),
new NpgsqlTypes.NpgsqlLine(a: 0.14985162575714428d, b: 0.7662352836630043d, c: 0.17900425011575916d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2717526797942812d, b: 0.5778988530408434d, c: 0.38742793955953314d),
new NpgsqlTypes.NpgsqlLine(a: 0.40738455934103646d, b: 0.8536979078289275d, c: 0.4729772950783778d),
new NpgsqlTypes.NpgsqlLine(a: 0.9732012464786022d, b: 0.9842967748577373d, c: 0.25549476273194827d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.94185190562229d, b: 0.3184827845005944d, c: 0.5022224995972427d),
new NpgsqlTypes.NpgsqlLine(a: 0.8458309114012834d, b: 0.7922521652838579d, c: 0.6008920723621681d),
new NpgsqlTypes.NpgsqlLine(a: 0.09213146315192478d, b: 0.5816534431709993d, c: 0.221828817298528d),
new NpgsqlTypes.NpgsqlLine(a: 0.0015951537506967428d, b: 0.1647294643851387d, c: 0.06020275778562556d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5418687704157545d, b: 0.3934319256490222d, c: 0.5148108471457333d),
new NpgsqlTypes.NpgsqlLine(a: 0.42033595702339577d, b: 0.40227224714182097d, c: 0.1863877117031285d),
new NpgsqlTypes.NpgsqlLine(a: 0.7262852244694837d, b: 0.4426150913706982d, c: 0.2000905957846062d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1941512752812562d, b: 0.16378263828466144d, c: 0.6760176348867348d),
new NpgsqlTypes.NpgsqlLine(a: 0.9376982566339235d, b: 0.1279347645029223d, c: 0.035096958626578356d),
new NpgsqlTypes.NpgsqlLine(a: 0.6403100033891158d, b: 0.04769487219404012d, c: 0.6859750775205588d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19705638339190634d, b: 0.12304268646726269d, c: 0.08125649486546926d),
new NpgsqlTypes.NpgsqlLine(a: 0.6208549589421603d, b: 0.5777974687652294d, c: 0.8647328800171825d),
new NpgsqlTypes.NpgsqlLine(a: 0.7835317005216766d, b: 0.17461553702202304d, c: 0.5777617520889905d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.696406204823589d, b: 0.4559763076386891d, c: 0.9810716704503729d),
new NpgsqlTypes.NpgsqlLine(a: 0.47465030157391874d, b: 0.1236397634833507d, c: 0.9646089795126023d),
new NpgsqlTypes.NpgsqlLine(a: 0.8354113102043906d, b: 0.6286190724972226d, c: 0.7608769988882923d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.000356673612118219d, b: 0.10502023311632913d, c: 0.024483614305607304d),
new NpgsqlTypes.NpgsqlLine(a: 0.6141277011855466d, b: 0.8329525006096778d, c: 0.3500715277672759d),
new NpgsqlTypes.NpgsqlLine(a: 0.5597534940479056d, b: 0.45769366016319724d, c: 0.3749591366683962d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.016201471172970994d, b: 0.8864278861155425d, c: 0.6596766565692568d),
new NpgsqlTypes.NpgsqlLine(a: 0.8489402719668043d, b: 0.5563172778030968d, c: 0.21250539673410473d),
new NpgsqlTypes.NpgsqlLine(a: 0.9903058439845938d, b: 0.039577321298058465d, c: 0.8134562198369658d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23934769328973104d, b: 0.8835569485144653d, c: 0.6650405252978212d),
new NpgsqlTypes.NpgsqlLine(a: 0.3859797324191573d, b: 0.19697697600162611d, c: 0.6338964910065138d),
new NpgsqlTypes.NpgsqlLine(a: 0.8042613592208476d, b: 0.9359882394797572d, c: 0.9973763854363485d),
new NpgsqlTypes.NpgsqlLine(a: 0.02691682680751284d, b: 0.7017957536198655d, c: 0.9985843911740759d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31794329730922644d, b: 0.9070069598556428d, c: 0.2467842806704572d),
new NpgsqlTypes.NpgsqlLine(a: 0.6749556892446419d, b: 0.4218127777234112d, c: 0.6583172230877888d),
new NpgsqlTypes.NpgsqlLine(a: 0.6566715308587727d, b: 0.3167503475667305d, c: 0.3473035992890292d),
new NpgsqlTypes.NpgsqlLine(a: 0.8605924941725366d, b: 0.8242852385720827d, c: 0.33837605330992293d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.90297185496449d, b: 0.5204506588318196d, c: 0.01646092010910194d),
new NpgsqlTypes.NpgsqlLine(a: 0.10183567124237325d, b: 0.35453952386378484d, c: 0.26339717622620096d),
new NpgsqlTypes.NpgsqlLine(a: 0.9187590779789744d, b: 0.040256022509312595d, c: 0.7424310211172098d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7151766490090791d, b: 0.9583949753073581d, c: 0.22011195968036623d),
new NpgsqlTypes.NpgsqlLine(a: 0.8221235939426879d, b: 0.6441587311852868d, c: 0.33841526426024926d),
new NpgsqlTypes.NpgsqlLine(a: 0.6789749204211473d, b: 0.7022317291560437d, c: 0.296021416789388d),
new NpgsqlTypes.NpgsqlLine(a: 0.8118632896130407d, b: 0.5807938386276921d, c: 0.9474284669775025d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8599363176349416d, b: 0.24851851754134646d, c: 0.6579374542763953d),
new NpgsqlTypes.NpgsqlLine(a: 0.2632995474363353d, b: 0.19842730203786885d, c: 0.6547561729263253d),
new NpgsqlTypes.NpgsqlLine(a: 0.27981945936075026d, b: 0.2966342758684011d, c: 0.969537411306159d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6881789106544184d, b: 0.8177770301819771d, c: 0.7424864163707954d),
new NpgsqlTypes.NpgsqlLine(a: 0.9107537708804662d, b: 0.16913025531206405d, c: 0.5496316061399522d),
new NpgsqlTypes.NpgsqlLine(a: 0.06358332370925479d, b: 0.8812044137935775d, c: 0.6943256517457193d),
new NpgsqlTypes.NpgsqlLine(a: 0.36093203229873816d, b: 0.8503222481296113d, c: 0.514628793710928d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8695209326986519d, b: 0.5356999595849067d, c: 0.9386437165924688d),
new NpgsqlTypes.NpgsqlLine(a: 0.7514789536691661d, b: 0.01132350341060151d, c: 0.06714757162296192d),
new NpgsqlTypes.NpgsqlLine(a: 0.4973365415940981d, b: 0.4266772667221983d, c: 0.5186129381536569d),
new NpgsqlTypes.NpgsqlLine(a: 0.3798239645657363d, b: 0.18748095000260356d, c: 0.7524977366873276d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12043426722720474d, b: 0.6407625088881579d, c: 0.6851097422280688d),
new NpgsqlTypes.NpgsqlLine(a: 0.6891854474785739d, b: 0.7263166683700806d, c: 0.5583165886424772d),
new NpgsqlTypes.NpgsqlLine(a: 0.3479149427437014d, b: 0.4524824995182466d, c: 0.9635995708405706d),
new NpgsqlTypes.NpgsqlLine(a: 0.3324710355264636d, b: 0.1727629843023606d, c: 0.05138653682615557d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4427390445397271d, b: 0.9426696650999195d, c: 0.6499576334447943d),
new NpgsqlTypes.NpgsqlLine(a: 0.550375466925552d, b: 0.9272003882028406d, c: 0.9470799934537161d),
new NpgsqlTypes.NpgsqlLine(a: 0.5692823132274792d, b: 0.04892272647039608d, c: 0.08291079813803126d),
new NpgsqlTypes.NpgsqlLine(a: 0.7469776442925505d, b: 0.07375717996021092d, c: 0.5197891966577315d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.565794767481076d, b: 0.5769856275779593d, c: 0.2826354661480571d),
new NpgsqlTypes.NpgsqlLine(a: 0.5839354836761339d, b: 0.2457276276026582d, c: 0.9035111911771883d),
new NpgsqlTypes.NpgsqlLine(a: 0.5103019944933753d, b: 0.15097856162309575d, c: 0.5150114167645206d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4741353832277144d, b: 0.261526949832498d, c: 0.4553726217058569d),
new NpgsqlTypes.NpgsqlLine(a: 0.05281517962175253d, b: 0.4180958698466538d, c: 0.5831612404264948d),
new NpgsqlTypes.NpgsqlLine(a: 0.024648016495354197d, b: 0.31613255528481266d, c: 0.6114621608912697d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
INSERT INTO public.npgsqllinelinemmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)), 
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
                methodParametrName: "npgsqllinelinemmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6584603820447724d, b: 0.7275312096159289d, c: 0.5426082984576096d),
new NpgsqlTypes.NpgsqlLine(a: 0.5261239005540154d, b: 0.8907341606238621d, c: 0.046279332680620566d),
new NpgsqlTypes.NpgsqlLine(a: 0.7858295954346621d, b: 0.002231783893717698d, c: 0.5264187422389158d),
new NpgsqlTypes.NpgsqlLine(a: 0.7728907795750897d, b: 0.010163466511034502d, c: 0.9955669166305693d),
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8419079624684794d, b: 0.6496247781857349d, c: 0.3063384962573401d),
new NpgsqlTypes.NpgsqlLine(a: 0.17941140108728704d, b: 0.2245331467063667d, c: 0.6974565244912444d),
new NpgsqlTypes.NpgsqlLine(a: 0.9823366956011705d, b: 0.6857589166559668d, c: 0.22059641192774992d),
new NpgsqlTypes.NpgsqlLine(a: 0.8274823062365442d, b: 0.2537797042382417d, c: 0.3796201583211479d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                methodParametrName: "npgsqllinelinemmarrayd1e1mi_id", 
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
                nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5099776591894853d, b: 0.8684928550905671d, c: 0.48221664562122457d),
new NpgsqlTypes.NpgsqlLine(a: 0.4297841823665808d, b: 0.3381136361333933d, c: 0.3232027777251536d),
new NpgsqlTypes.NpgsqlLine(a: 0.09595922472100349d, b: 0.23897145832845967d, c: 0.20077574803723675d),
}));
                nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2148473206461855d, b: 0.2794204118241863d, c: 0.8326317393832693d),
new NpgsqlTypes.NpgsqlLine(a: 0.0365114124413497d, b: 0.1885968739727989d, c: 0.9943973950434327d),
new NpgsqlTypes.NpgsqlLine(a: 0.3984272020005951d, b: 0.27341544012652086d, c: 0.3067831153793802d),
new NpgsqlTypes.NpgsqlLine(a: 0.6527663481725879d, b: 0.2934325389493063d, c: 0.4636172582210828d),
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
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31217013333763355d, b: 0.8044674693381151d, c: 0.10530812787676991d),
new NpgsqlTypes.NpgsqlLine(a: 0.7244037993330562d, b: 0.001690602232588323d, c: 0.9282115351893963d),
new NpgsqlTypes.NpgsqlLine(a: 0.23248790176065104d, b: 0.9224453675944732d, c: 0.21218686298454326d),
new NpgsqlTypes.NpgsqlLine(a: 0.7844291339376047d, b: 0.943640062366521d, c: 0.8740387126933705d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD1E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD1E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 87, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 76, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 7, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 171, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 171, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 53, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
FROM public.binary_npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineMArraylineMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI), typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

