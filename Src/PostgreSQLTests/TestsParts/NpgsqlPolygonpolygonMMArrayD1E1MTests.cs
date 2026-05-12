

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD1
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD1 : INpgsqlPolygonMArraypolygonMMArrayD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD1E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD1E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.763126609281074d, y: 0.46911886707434347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547827353090362d, y: 0.7424303338437193d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664549564629517d, y: 0.4497666771124107d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9280602125450548d, y: 0.9615358027300872d), new NpgsqlTypes.NpgsqlPoint(x: 0.029380160597233473d, y: 0.260415347741598d), new NpgsqlTypes.NpgsqlPoint(x: 0.2474335798040167d, y: 0.6749826536623247d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13443799112359123d, y: 0.5322836570942012d), new NpgsqlTypes.NpgsqlPoint(x: 0.39569530180057166d, y: 0.4712971864029508d), new NpgsqlTypes.NpgsqlPoint(x: 0.47134217972266923d, y: 0.8132992302761469d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.796297846008829d, y: 0.10402625466300364d), new NpgsqlTypes.NpgsqlPoint(x: 0.542541536702492d, y: 0.3641125419945105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673800868744759d, y: 0.9377796569255464d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8423949626968972d, y: 0.5795582990056807d), new NpgsqlTypes.NpgsqlPoint(x: 0.1477321207216712d, y: 0.6012375139806446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908051141124681d, y: 0.97513406591823d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07184181720473026d, y: 0.05063410956133252d), new NpgsqlTypes.NpgsqlPoint(x: 0.16766784957026493d, y: 0.14355445540923417d), new NpgsqlTypes.NpgsqlPoint(x: 0.41791062689562364d, y: 0.6767307927189564d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04246648834882949d, y: 0.6721189840250853d), new NpgsqlTypes.NpgsqlPoint(x: 0.2892427981070298d, y: 0.07875879821018172d), new NpgsqlTypes.NpgsqlPoint(x: 0.39483464261844337d, y: 0.2173850021116458d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9717948022087153d, y: 0.26686022433769474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342804469749776d, y: 0.6875951731966958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338586500382453d, y: 0.34911484433254214d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9551679838579463d, y: 0.7154182643083836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4900163307233084d, y: 0.830157068614745d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207335891738801d, y: 0.39170894418992275d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6458734337072637d, y: 0.3849181987421788d), new NpgsqlTypes.NpgsqlPoint(x: 0.6734154846801647d, y: 0.42861999001196505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733013575703655d, y: 0.11605287748210213d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13658416011163765d, y: 0.6717083691775978d), new NpgsqlTypes.NpgsqlPoint(x: 0.17414538449800665d, y: 0.4989202717474387d), new NpgsqlTypes.NpgsqlPoint(x: 0.42665911227971987d, y: 0.6889392767462608d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.031465629929053995d, y: 0.7241118598837425d), new NpgsqlTypes.NpgsqlPoint(x: 0.4900397773171751d, y: 0.08330756650798299d), new NpgsqlTypes.NpgsqlPoint(x: 0.6687810374880746d, y: 0.4135419585227238d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3467145011542796d, y: 0.07707631945545212d), new NpgsqlTypes.NpgsqlPoint(x: 0.4145244238975586d, y: 0.19019451814254562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869316688149363d, y: 0.5899706028221253d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9926205423033028d, y: 0.7593532037139405d), new NpgsqlTypes.NpgsqlPoint(x: 0.00040771895472613284d, y: 0.7538518138533449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561279979472118d, y: 0.7817308511515513d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7346170230498404d, y: 0.14198829898785736d), new NpgsqlTypes.NpgsqlPoint(x: 0.3983851582111575d, y: 0.7883552774149998d), new NpgsqlTypes.NpgsqlPoint(x: 0.7839362368559682d, y: 0.5945353841850786d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.771576577665018d, y: 0.8229485259809707d), new NpgsqlTypes.NpgsqlPoint(x: 0.12367093646852201d, y: 0.10319559669079281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233451722426723d, y: 0.16723736328778027d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9654531797219109d, y: 0.7205271827975076d), new NpgsqlTypes.NpgsqlPoint(x: 0.891586553748081d, y: 0.2208784248038267d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449409554655317d, y: 0.5052868738022123d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7422712657723146d, y: 0.14723619757082407d), new NpgsqlTypes.NpgsqlPoint(x: 0.2959423206794868d, y: 0.526637000303098d), new NpgsqlTypes.NpgsqlPoint(x: 0.356443138454011d, y: 0.8357812814734222d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8464434715355273d, y: 0.7892052375550634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464315779978913d, y: 0.8712841724770659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838260962126503d, y: 0.4699460257671797d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15857862194747152d, y: 0.6106239390008447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9478900508772119d, y: 0.0002382884066018942d), new NpgsqlTypes.NpgsqlPoint(x: 0.11381828272387884d, y: 0.604518324139533d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9858940719228773d, y: 0.13261670224639766d), new NpgsqlTypes.NpgsqlPoint(x: 0.419415322971162d, y: 0.9329991473699712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784426526629942d, y: 0.10613110240314594d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5698046454910927d, y: 0.9489635150775899d), new NpgsqlTypes.NpgsqlPoint(x: 0.16039503471838912d, y: 0.22394270795020177d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011157631653908d, y: 0.9714961678224179d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36831768410340116d, y: 0.046101069432289976d), new NpgsqlTypes.NpgsqlPoint(x: 0.40830885070276335d, y: 0.6876120058605563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807873546976117d, y: 0.8121425178502534d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04773268269523878d, y: 0.7223762846919595d), new NpgsqlTypes.NpgsqlPoint(x: 0.1465576754281369d, y: 0.4639094327646569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6545897576260776d, y: 0.9859376028600696d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10119359887063495d, y: 0.3123473545766583d), new NpgsqlTypes.NpgsqlPoint(x: 0.7625639576519577d, y: 0.6887915451726973d), new NpgsqlTypes.NpgsqlPoint(x: 0.13929617500495373d, y: 0.7869526603508055d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09040411481089672d, y: 0.04703300138710487d), new NpgsqlTypes.NpgsqlPoint(x: 0.49526808133058786d, y: 0.775886651714628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256407289081467d, y: 0.03653490783322311d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7024087038706579d, y: 0.48880810757714255d), new NpgsqlTypes.NpgsqlPoint(x: 0.45567844998601104d, y: 0.09682612218975195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6857956379038019d, y: 0.5847806588443197d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02351543545148982d, y: 0.6637137318137684d), new NpgsqlTypes.NpgsqlPoint(x: 0.732328560130659d, y: 0.7584841004120285d), new NpgsqlTypes.NpgsqlPoint(x: 0.2836333463727525d, y: 0.41642960649220406d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7091151122575373d, y: 0.2703736414094383d), new NpgsqlTypes.NpgsqlPoint(x: 0.04208139695044033d, y: 0.02265557629660786d), new NpgsqlTypes.NpgsqlPoint(x: 0.3258664123271613d, y: 0.7942822220312635d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6251028318156612d, y: 0.8125162519754818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7075766646388609d, y: 0.25683157359311193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6130977230661296d, y: 0.7470250378685039d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7326788683516177d, y: 0.9732096425444775d), new NpgsqlTypes.NpgsqlPoint(x: 0.16657642575644227d, y: 0.9707328063751752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6188447629356902d, y: 0.7160983242092176d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9405035466339416d, y: 0.2580002858474154d), new NpgsqlTypes.NpgsqlPoint(x: 0.2724789296625363d, y: 0.01362016551271017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3646577666831964d, y: 0.7393488555657854d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9940136308934421d, y: 0.9576605210387829d), new NpgsqlTypes.NpgsqlPoint(x: 0.763352527088424d, y: 0.35504664858735646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7875388843201842d, y: 0.4794221255318719d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7613999687426759d, y: 0.7323565996353603d), new NpgsqlTypes.NpgsqlPoint(x: 0.42725022318483385d, y: 0.21342263592859922d), new NpgsqlTypes.NpgsqlPoint(x: 0.31142728963904887d, y: 0.4295496965531723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.352049227786819d, y: 0.9960502405233588d), new NpgsqlTypes.NpgsqlPoint(x: 0.4062564191007121d, y: 0.39862866706201827d), new NpgsqlTypes.NpgsqlPoint(x: 0.2975021610164753d, y: 0.9226543599728623d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.873328646059635d, y: 0.18787706657507874d), new NpgsqlTypes.NpgsqlPoint(x: 0.24372654503878088d, y: 0.3974209348888008d), new NpgsqlTypes.NpgsqlPoint(x: 0.10172644554257182d, y: 0.3336031688838502d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5264179470686113d, y: 0.1743804685651077d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282974442913473d, y: 0.3003659513306891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6940152099645608d, y: 0.5927192986023938d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12680106351490228d, y: 0.26911925837422446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4247195941575149d, y: 0.9788406134490661d), new NpgsqlTypes.NpgsqlPoint(x: 0.17454837553477187d, y: 0.875796117526477d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25924974404502976d, y: 0.7320349233618042d), new NpgsqlTypes.NpgsqlPoint(x: 0.31047336623750554d, y: 0.09626925044708234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826522773554209d, y: 0.5074533663937804d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7717026329766135d, y: 0.841535978046255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472248154353437d, y: 0.11096134477847053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5111802647977505d, y: 0.3108837149299295d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7223618339820654d, y: 0.12346724938311604d), new NpgsqlTypes.NpgsqlPoint(x: 0.27990009716409625d, y: 0.7621142743185744d), new NpgsqlTypes.NpgsqlPoint(x: 0.914494590675855d, y: 0.8661024335348364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5702627012184079d, y: 0.056533327637860786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923988506471508d, y: 0.09829162834213423d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737742819632738d, y: 0.03157568591622428d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8346464590718452d, y: 0.017536499597907262d), new NpgsqlTypes.NpgsqlPoint(x: 0.889992603065083d, y: 0.24545634378290426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554962976287635d, y: 0.48714195868665755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2752159261218866d, y: 0.48867812377269093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217868595787009d, y: 0.9906538489020886d), new NpgsqlTypes.NpgsqlPoint(x: 0.1051588779033864d, y: 0.12937887146846627d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9627250388395667d, y: 0.9476265118434389d), new NpgsqlTypes.NpgsqlPoint(x: 0.9090782402941235d, y: 0.2897744162575536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9748793851259224d, y: 0.24590577574161976d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40845059443716103d, y: 0.9009645621055978d), new NpgsqlTypes.NpgsqlPoint(x: 0.028794187637748547d, y: 0.24307160596016897d), new NpgsqlTypes.NpgsqlPoint(x: 0.24520726106302648d, y: 0.30960753689423703d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09463892998879742d, y: 0.8088496975081512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628448195312803d, y: 0.06201718848249349d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702989055168451d, y: 0.9282239470403919d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8365127980830603d, y: 0.12213279844588631d), new NpgsqlTypes.NpgsqlPoint(x: 0.5925929117355372d, y: 0.08895138691457438d), new NpgsqlTypes.NpgsqlPoint(x: 0.704937939347436d, y: 0.788709611708038d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34222685355988847d, y: 0.63694099653523d), new NpgsqlTypes.NpgsqlPoint(x: 0.17319054481368068d, y: 0.2978966107193123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260648555714541d, y: 0.383754787526129d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4591704497731487d, y: 0.2180983115426386d), new NpgsqlTypes.NpgsqlPoint(x: 0.909279218785517d, y: 0.469401774940749d), new NpgsqlTypes.NpgsqlPoint(x: 0.6911156525174308d, y: 0.21848403475236544d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7005621361630329d, y: 0.42945737011511975d), new NpgsqlTypes.NpgsqlPoint(x: 0.0717253798227322d, y: 0.697816160442295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420998220854236d, y: 0.7246116136175665d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3767817937640986d, y: 0.38821404300018447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578259564522162d, y: 0.3884710128606723d), new NpgsqlTypes.NpgsqlPoint(x: 0.1725791217834134d, y: 0.5345415037918436d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7680855895632699d, y: 0.42265195953373424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453809654546221d, y: 0.20766588997287805d), new NpgsqlTypes.NpgsqlPoint(x: 0.12613015937854988d, y: 0.02017734367415369d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3831697730524105d, y: 0.46883224305561255d), new NpgsqlTypes.NpgsqlPoint(x: 0.12709312597070255d, y: 0.10720887153353953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757306406876891d, y: 0.6903144948228203d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42108387279512527d, y: 0.47771116743528297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350480802184176d, y: 0.9119565776601344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993858960548517d, y: 0.012516856399031995d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3461525191670247d, y: 0.1376987771984205d), new NpgsqlTypes.NpgsqlPoint(x: 0.23989602376919195d, y: 0.16441139843275998d), new NpgsqlTypes.NpgsqlPoint(x: 0.2056833121615419d, y: 0.4357072599516165d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23096540271062393d, y: 0.4146548795062477d), new NpgsqlTypes.NpgsqlPoint(x: 0.47400029653859854d, y: 0.19034911445952696d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435095637261963d, y: 0.8776697351596942d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5226933281621615d, y: 0.707270803840938d), new NpgsqlTypes.NpgsqlPoint(x: 0.1004044239943308d, y: 0.4335947720658804d), new NpgsqlTypes.NpgsqlPoint(x: 0.04199292511137853d, y: 0.1687452863134189d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9751096962645955d, y: 0.6425387886602308d), new NpgsqlTypes.NpgsqlPoint(x: 0.10583750939057168d, y: 0.9979467590679628d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244405149105758d, y: 0.17952412775437987d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2025852258215387d, y: 0.7922036854223656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607469358858192d, y: 0.1301587285545862d), new NpgsqlTypes.NpgsqlPoint(x: 0.02434532281737145d, y: 0.4414675066924584d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20577999486825338d, y: 0.8495258636301892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805544245287211d, y: 0.8195312162822833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5359650274846438d, y: 0.9914815241284659d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.569058578289707d, y: 0.5787522408369282d), new NpgsqlTypes.NpgsqlPoint(x: 0.28167807244634635d, y: 0.4354438233119272d), new NpgsqlTypes.NpgsqlPoint(x: 0.6834879289411229d, y: 0.6484598185619459d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3852198804761785d, y: 0.8737875222489401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789569481059884d, y: 0.2025914665402021d), new NpgsqlTypes.NpgsqlPoint(x: 0.09631728155634922d, y: 0.5932913871344685d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17778501750056852d, y: 0.44051461579119333d), new NpgsqlTypes.NpgsqlPoint(x: 0.006664202409075837d, y: 0.5536285667572955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013891090055237d, y: 0.8510489803646387d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22633624623346282d, y: 0.9101513031034287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388392024881379d, y: 0.9017265895502474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4340511720701715d, y: 0.7551679828995035d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9621069625879661d, y: 0.9771887063438285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848320144672432d, y: 0.9425349802700973d), new NpgsqlTypes.NpgsqlPoint(x: 0.43359673166458024d, y: 0.5102174909891731d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3977685700637198d, y: 0.848773876438958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628946495496834d, y: 0.7847364743410519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5401959014108405d, y: 0.48875517799566204d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32988370887564045d, y: 0.2894974741433163d), new NpgsqlTypes.NpgsqlPoint(x: 0.39311465114797983d, y: 0.7880231480981871d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695159738300713d, y: 0.997767623111372d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7515922058313785d, y: 0.953139317749719d), new NpgsqlTypes.NpgsqlPoint(x: 0.04855444967524514d, y: 0.7078865646838725d), new NpgsqlTypes.NpgsqlPoint(x: 0.49405615048632545d, y: 0.38726546437323195d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1588617022850305d, y: 0.0796729765137757d), new NpgsqlTypes.NpgsqlPoint(x: 0.05242349168910587d, y: 0.4134427405650488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245918330519785d, y: 0.7782128430626339d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34487120429603446d, y: 0.34041337377248226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977525357975345d, y: 0.566714506741811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923437196142948d, y: 0.07558960494601963d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.851301912917988d, y: 0.4777876872508313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9649628251907084d, y: 0.1262692270787351d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693015381456199d, y: 0.8370163560376098d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374365627392443d, y: 0.5344065275566958d), new NpgsqlTypes.NpgsqlPoint(x: 0.2103201852854183d, y: 0.3023136331758066d), new NpgsqlTypes.NpgsqlPoint(x: 0.882329159828571d, y: 0.7351291164803873d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7364056638642501d, y: 0.19294626428874107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924885316175029d, y: 0.7351207383336464d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309293738259135d, y: 0.7776057916552253d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5318829714067187d, y: 0.3008203932350336d), new NpgsqlTypes.NpgsqlPoint(x: 0.1210435069106256d, y: 0.566954382346218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138481144536585d, y: 0.6575588849560604d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4460776107138973d, y: 0.9211745666998428d), new NpgsqlTypes.NpgsqlPoint(x: 0.711542620227667d, y: 0.9319768555426846d), new NpgsqlTypes.NpgsqlPoint(x: 0.3544480113502816d, y: 0.31554249047421157d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23542787658431086d, y: 0.034298899437530395d), new NpgsqlTypes.NpgsqlPoint(x: 0.20155536112040284d, y: 0.3773069005256756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5983269254825736d, y: 0.13513032203728803d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4318483913657635d, y: 0.378759273955374d), new NpgsqlTypes.NpgsqlPoint(x: 0.15430184027228588d, y: 0.6784574567858008d), new NpgsqlTypes.NpgsqlPoint(x: 0.46423935614198586d, y: 0.612637371363795d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9492131622550247d, y: 0.34098286367980557d), new NpgsqlTypes.NpgsqlPoint(x: 0.16534722220254738d, y: 0.4491348687687716d), new NpgsqlTypes.NpgsqlPoint(x: 0.20569309198327468d, y: 0.07492193345316789d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47088623221913406d, y: 0.11464842766022065d), new NpgsqlTypes.NpgsqlPoint(x: 0.33498437387308266d, y: 0.597172595029778d), new NpgsqlTypes.NpgsqlPoint(x: 0.11356841970623355d, y: 0.9728901399539209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7998080621770749d, y: 0.4770330642169709d), new NpgsqlTypes.NpgsqlPoint(x: 0.03364370517470072d, y: 0.9737142840307224d), new NpgsqlTypes.NpgsqlPoint(x: 0.06642305472125942d, y: 0.6411089732481501d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6287315385612524d, y: 0.14999625798666727d), new NpgsqlTypes.NpgsqlPoint(x: 0.25623713158298544d, y: 0.33396024572710925d), new NpgsqlTypes.NpgsqlPoint(x: 0.488014166083238d, y: 0.573207346548196d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23300143546184549d, y: 0.27952107779691504d), new NpgsqlTypes.NpgsqlPoint(x: 0.48773836605061227d, y: 0.8618104186735097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805549065151264d, y: 0.5339377255618303d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16528866765945083d, y: 0.09802926414274815d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769952726249534d, y: 0.8853677793715717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115487363933998d, y: 0.920175816817059d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831442496398269d, y: 0.40762488013266385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3422383940745385d, y: 0.6212634497645139d), new NpgsqlTypes.NpgsqlPoint(x: 0.3505594922485358d, y: 0.05168189292021097d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8407436926535985d, y: 0.8466184043866906d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795170472160728d, y: 0.026088154324343305d), new NpgsqlTypes.NpgsqlPoint(x: 0.051278513331373676d, y: 0.5867799952761021d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9868308647643373d, y: 0.9612964496625065d), new NpgsqlTypes.NpgsqlPoint(x: 0.02376857715044456d, y: 0.47944704750306844d), new NpgsqlTypes.NpgsqlPoint(x: 0.15938376593020886d, y: 0.07188782189146126d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8418053309647644d, y: 0.8221123969917821d), new NpgsqlTypes.NpgsqlPoint(x: 0.02860830722393215d, y: 0.5266720624195896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6639927009188821d, y: 0.6027651900505747d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46064499738589193d, y: 0.9816542348117245d), new NpgsqlTypes.NpgsqlPoint(x: 0.04322742123736334d, y: 0.9787044887015055d), new NpgsqlTypes.NpgsqlPoint(x: 0.32537753247988366d, y: 0.6162688949304969d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9624406979641915d, y: 0.388638668591028d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474713706981724d, y: 0.7652958203297451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254169838709292d, y: 0.42291016015950067d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12422454984004028d, y: 0.5554646745097439d), new NpgsqlTypes.NpgsqlPoint(x: 0.2542078608661965d, y: 0.21006045085184089d), new NpgsqlTypes.NpgsqlPoint(x: 0.7043498192847567d, y: 0.12906009406502394d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4518368298958664d, y: 0.45742164645471195d), new NpgsqlTypes.NpgsqlPoint(x: 0.03192262504878174d, y: 0.22522585195155564d), new NpgsqlTypes.NpgsqlPoint(x: 0.18572438718911288d, y: 0.26025346530850213d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4914931749212561d, y: 0.5162965982752302d), new NpgsqlTypes.NpgsqlPoint(x: 0.36991337107254707d, y: 0.41926884306667755d), new NpgsqlTypes.NpgsqlPoint(x: 0.022084609336519234d, y: 0.39302063846460333d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7597630430569308d, y: 0.4742977903165704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096963715041654d, y: 0.8558017441898d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672963575353871d, y: 0.746478927286754d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9049896439484463d, y: 0.6593060988855735d), new NpgsqlTypes.NpgsqlPoint(x: 0.13554574840638856d, y: 0.11395248950554637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6028228587186703d, y: 0.802881008144035d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2125112579299736d, y: 0.9840498311991397d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960692248098096d, y: 0.9924675281139426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403518909832083d, y: 0.7594398978587826d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2824540577016085d, y: 0.03855211020452254d), new NpgsqlTypes.NpgsqlPoint(x: 0.3421654914624791d, y: 0.2537945326482369d), new NpgsqlTypes.NpgsqlPoint(x: 0.14167979272059616d, y: 0.34936462775949506d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7047207665732771d, y: 0.11254744911197423d), new NpgsqlTypes.NpgsqlPoint(x: 0.92051038754238d, y: 0.7205385386589442d), new NpgsqlTypes.NpgsqlPoint(x: 0.4161173785559612d, y: 0.18430741633093783d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8638479501894861d, y: 0.17723004776691598d), new NpgsqlTypes.NpgsqlPoint(x: 0.27125317148188455d, y: 0.5439307022072034d), new NpgsqlTypes.NpgsqlPoint(x: 0.7011787469512742d, y: 0.6469777712609373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8215106997266605d, y: 0.27517868759426267d), new NpgsqlTypes.NpgsqlPoint(x: 0.38070593527347185d, y: 0.3972691925521066d), new NpgsqlTypes.NpgsqlPoint(x: 0.33192727381866705d, y: 0.4311559923847824d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16782376874596006d, y: 0.6316461170274649d), new NpgsqlTypes.NpgsqlPoint(x: 0.285088172138557d, y: 0.33855330917002446d), new NpgsqlTypes.NpgsqlPoint(x: 0.36144407728554506d, y: 0.24539599622733088d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36701248113619145d, y: 0.11334194722006152d), new NpgsqlTypes.NpgsqlPoint(x: 0.11646255380685622d, y: 0.3225419613833711d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389118240382497d, y: 0.36513939697087905d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10700962182295637d, y: 0.5400762344167873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746825850576992d, y: 0.9502383856838722d), new NpgsqlTypes.NpgsqlPoint(x: 0.14696219480954553d, y: 0.6522368749543209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2844511268393861d, y: 0.05000939668624049d), new NpgsqlTypes.NpgsqlPoint(x: 0.990905427690982d, y: 0.41439766891082985d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018906489223884d, y: 0.09918304586982074d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12117185784721696d, y: 0.9380583265116401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6901494414698579d, y: 0.8968124424809758d), new NpgsqlTypes.NpgsqlPoint(x: 0.28940284239202596d, y: 0.3819064846031197d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08963436536637004d, y: 0.7907480049047564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419683098984035d, y: 0.5121371832095895d), new NpgsqlTypes.NpgsqlPoint(x: 0.33152812370237816d, y: 0.1705700753835655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9012090168422251d, y: 0.020163596858885025d), new NpgsqlTypes.NpgsqlPoint(x: 0.17106030924298732d, y: 0.05426145641469127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782203632242666d, y: 0.11743432443452151d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4456529262872747d, y: 0.9326488984765032d), new NpgsqlTypes.NpgsqlPoint(x: 0.06721053835390411d, y: 0.08602807163411774d), new NpgsqlTypes.NpgsqlPoint(x: 0.1116349028261252d, y: 0.1041690141322591d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47500901640359716d, y: 0.7962022579515092d), new NpgsqlTypes.NpgsqlPoint(x: 0.3549497627999123d, y: 0.5632278473235606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766715199185838d, y: 0.6969132545768927d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27202328112318874d, y: 0.42542227408442423d), new NpgsqlTypes.NpgsqlPoint(x: 0.812755296730812d, y: 0.14673827872642553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359901619109813d, y: 0.6066587003583106d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28628740707480205d, y: 0.23903368857694496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5941029681322544d, y: 0.604483859323373d), new NpgsqlTypes.NpgsqlPoint(x: 0.33746578040441133d, y: 0.5992375875986695d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.409725471752335d, y: 0.14784651959085626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934067465054362d, y: 0.04891523664912911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445498480587262d, y: 0.9022632186264751d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718697378475654d, y: 0.7944028176050499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278022421914146d, y: 0.7713515143794197d), new NpgsqlTypes.NpgsqlPoint(x: 0.7314875255711355d, y: 0.6696579745687892d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9369434198070488d, y: 0.7483841546556783d), new NpgsqlTypes.NpgsqlPoint(x: 0.4711376944655731d, y: 0.7717761125294517d), new NpgsqlTypes.NpgsqlPoint(x: 0.21181556472012242d, y: 0.42244983458703467d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48125208408306597d, y: 0.48415048518339776d), new NpgsqlTypes.NpgsqlPoint(x: 0.531644734198203d, y: 0.838594818184107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317966701151832d, y: 0.2390566466714683d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20633774088987d, y: 0.26651716450480756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9353231970644578d, y: 0.041506817934025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381198123235694d, y: 0.9544462572807543d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03593451011463711d, y: 0.5590116867608137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9755213729868729d, y: 0.6476116910371886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268634359005277d, y: 0.7587618724805527d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7007424467161608d, y: 0.5119813429890616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184265619229348d, y: 0.6800143344201393d), new NpgsqlTypes.NpgsqlPoint(x: 0.03793710446623988d, y: 0.009632166129262654d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6112204718433446d, y: 0.9845276413888168d), new NpgsqlTypes.NpgsqlPoint(x: 0.7573016993352297d, y: 0.8378396560997927d), new NpgsqlTypes.NpgsqlPoint(x: 0.18350576251258544d, y: 0.5795112341569039d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.696718166618906d, y: 0.7090909631797978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397943042805009d, y: 0.026743535509936467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8131392479236497d, y: 0.010023077349993748d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5460921725410118d, y: 0.6101540075721917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824408094668086d, y: 0.19675451782484732d), new NpgsqlTypes.NpgsqlPoint(x: 0.13987418311424638d, y: 0.6565618608557678d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7196805705194231d, y: 0.4646802057439776d), new NpgsqlTypes.NpgsqlPoint(x: 0.26253031254015735d, y: 0.32549003482083627d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874844407468032d, y: 0.4202595522967173d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7540091923319892d, y: 0.6585401539560459d), new NpgsqlTypes.NpgsqlPoint(x: 0.402469771834406d, y: 0.09343221396360102d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606988913309598d, y: 0.984303799632081d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3635943662158877d, y: 0.07278366373908007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061733690731817d, y: 0.23455680399580414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481105126104114d, y: 0.5044644071958144d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18160465105564727d, y: 0.08793919711988418d), new NpgsqlTypes.NpgsqlPoint(x: 0.3249258147515237d, y: 0.6710873598811694d), new NpgsqlTypes.NpgsqlPoint(x: 0.4306901292745833d, y: 0.93034117390558d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40981617063887377d, y: 0.2566224730684784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8873249893954089d, y: 0.4637330854889651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973199982457692d, y: 0.23017350301950446d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10594967062826366d, y: 0.5608481911669057d), new NpgsqlTypes.NpgsqlPoint(x: 0.15936210386739247d, y: 0.7802350343283267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231195879133375d, y: 0.8714716360891834d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8535163664006009d, y: 0.7574208801038923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6153493551267236d, y: 0.8127985364846269d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089889982252373d, y: 0.4354334303853534d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4389018647569135d, y: 0.6461726082638147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8670718349926844d, y: 0.09143243969955717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426118763234834d, y: 0.6050934359840574d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08188377398076996d, y: 0.7457093936166244d), new NpgsqlTypes.NpgsqlPoint(x: 0.21333798556011707d, y: 0.6823311770942878d), new NpgsqlTypes.NpgsqlPoint(x: 0.49221619799958594d, y: 0.3838586343573622d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05947546637721468d, y: 0.507149247206904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7212230597725404d, y: 0.29224836744867644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412423651906525d, y: 0.6721495511901805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429322949855428d, y: 0.9743048572641131d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486071801847051d, y: 0.9878277746502762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8323453523832377d, y: 0.05420269597061467d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45375503245893867d, y: 0.8166804245833422d), new NpgsqlTypes.NpgsqlPoint(x: 0.55835752298967d, y: 0.0003425343198519837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603472633096128d, y: 0.7919303119842196d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40181874109354154d, y: 0.16399270342066008d), new NpgsqlTypes.NpgsqlPoint(x: 0.3568581756203789d, y: 0.8204728119227247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3500381187723087d, y: 0.037158230910103396d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2957504683381438d, y: 0.41244100810327156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462970920847979d, y: 0.9135781458911054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2756642564869092d, y: 0.3171450116819683d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6094432604463411d, y: 0.8386339848708836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6335270774742794d, y: 0.6056710092660041d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091008308162607d, y: 0.7713759979555486d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1931458026608388d, y: 0.18416165542754237d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525683979759241d, y: 0.2576850299225887d), new NpgsqlTypes.NpgsqlPoint(x: 0.3633884273436392d, y: 0.5215384788298456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9004049228272046d, y: 0.22019517304223268d), new NpgsqlTypes.NpgsqlPoint(x: 0.20127702696706695d, y: 0.13671227169450917d), new NpgsqlTypes.NpgsqlPoint(x: 0.35472110750390107d, y: 0.3045136950075842d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.407094261420338d, y: 0.10347986908380702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511123141857029d, y: 0.9515961759806385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914390109941638d, y: 0.7488112362670959d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4672064637700353d, y: 0.32161439215646925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7049496042837213d, y: 0.37611041022126324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243471572771595d, y: 0.6709834953169814d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2373368476824399d, y: 0.6184642024737815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038595342051293d, y: 0.014793117336018624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8368972187963593d, y: 0.45912634426817256d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6609407179744655d, y: 0.5026680805216447d), new NpgsqlTypes.NpgsqlPoint(x: 0.7816744453043927d, y: 0.5575235009838992d), new NpgsqlTypes.NpgsqlPoint(x: 0.277693685803001d, y: 0.13727562958833384d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8331731556976117d, y: 0.3234188945498293d), new NpgsqlTypes.NpgsqlPoint(x: 0.09955664513248652d, y: 0.18877189964635965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267457066284174d, y: 0.9896623438284099d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8348142629661959d, y: 0.7441916782736717d), new NpgsqlTypes.NpgsqlPoint(x: 0.32742426939166447d, y: 0.8105763884044257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771252329525815d, y: 0.9988560630177868d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6369674615248908d, y: 0.749388821540258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552855722455326d, y: 0.5760773242380555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5132868660646058d, y: 0.22897032734515266d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.749326821501394d, y: 0.7031960811172203d), new NpgsqlTypes.NpgsqlPoint(x: 0.13028321016404731d, y: 0.23416251492180573d), new NpgsqlTypes.NpgsqlPoint(x: 0.04945720435099199d, y: 0.6927514010893475d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7513182012831714d, y: 0.3967625683177799d), new NpgsqlTypes.NpgsqlPoint(x: 0.8583753922046657d, y: 0.012903713808022244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4548045869558113d, y: 0.9449658124356923d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7843380568262918d, y: 0.08183946467156378d), new NpgsqlTypes.NpgsqlPoint(x: 0.45347470832183234d, y: 0.0896720772666636d), new NpgsqlTypes.NpgsqlPoint(x: 0.07816182975782171d, y: 0.6377870968544467d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2511488601751587d, y: 0.09157351282107662d), new NpgsqlTypes.NpgsqlPoint(x: 0.24288228420721125d, y: 0.49284325766332593d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761386614666776d, y: 0.2828047196951088d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5162776496328103d, y: 0.9018059408667932d), new NpgsqlTypes.NpgsqlPoint(x: 0.595686245552227d, y: 0.15414592906968427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641619454086433d, y: 0.6685952068454772d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8603252201481035d, y: 0.5699722638755285d), new NpgsqlTypes.NpgsqlPoint(x: 0.1164701096945916d, y: 0.44543711272568864d), new NpgsqlTypes.NpgsqlPoint(x: 0.8847579817406648d, y: 0.6836731566769072d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8526485742730178d, y: 0.7010858235617309d), new NpgsqlTypes.NpgsqlPoint(x: 0.8280966705714013d, y: 0.9325704213700978d), new NpgsqlTypes.NpgsqlPoint(x: 0.6262354224859904d, y: 0.7475887541358958d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8358547573089814d, y: 0.6880851936652812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867367831830239d, y: 0.6663406761785825d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534339037390261d, y: 0.0815018257397685d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7833236516289315d, y: 0.12918876007137958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805760229943829d, y: 0.6697007169268184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159419208068969d, y: 0.5877124003506671d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06952609719687464d, y: 0.769365873964189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8124078141630359d, y: 0.4781207993315659d), new NpgsqlTypes.NpgsqlPoint(x: 0.47418945482004804d, y: 0.28253324659289425d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6158580422740134d, y: 0.5440713100637254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8503731765390655d, y: 0.7541693359366417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3773142694051671d, y: 0.1819927419014501d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017800524858791578d, y: 0.756207938330377d), new NpgsqlTypes.NpgsqlPoint(x: 0.46980504611091756d, y: 0.2381701574598164d), new NpgsqlTypes.NpgsqlPoint(x: 0.472856835308594d, y: 0.6913207144372029d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.883108886128596d, y: 0.8126581010526128d), new NpgsqlTypes.NpgsqlPoint(x: 0.43954188404285466d, y: 0.45877357154411424d), new NpgsqlTypes.NpgsqlPoint(x: 0.08374025467387747d, y: 0.673259376315478d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20815039865876728d, y: 0.5287114809213715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4737642455194363d, y: 0.5321424818645888d), new NpgsqlTypes.NpgsqlPoint(x: 0.6841675075151895d, y: 0.3115648940804743d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4655993072380883d, y: 0.6046084083589577d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243747776237149d, y: 0.09296240147637813d), new NpgsqlTypes.NpgsqlPoint(x: 0.41294579118918784d, y: 0.850806660111582d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3037551439686552d, y: 0.28623436919434886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5967461173437583d, y: 0.7194758674422684d), new NpgsqlTypes.NpgsqlPoint(x: 0.44807534199349186d, y: 0.17671371501223576d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1914699080466461d, y: 0.46280194524262297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6776874123076644d, y: 0.7237057122015764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9506133762261544d, y: 0.6142655469499502d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46269300122141077d, y: 0.5090052879571636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367696099248236d, y: 0.9949572164874868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9585498754428894d, y: 0.027373284564831013d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15745530218356552d, y: 0.4054467833712758d), new NpgsqlTypes.NpgsqlPoint(x: 0.44209392714964446d, y: 0.29530233176979326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522234787258658d, y: 0.33369210530459126d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5857902570929273d, y: 0.1437483082263057d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296809200615348d, y: 0.6229253111459042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6922939194454666d, y: 0.5651210944744645d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8931637899036627d, y: 0.11687966254018234d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246964866189733d, y: 0.5722022140821081d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240532481902149d, y: 0.11836379728258428d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4164577374608984d, y: 0.8584764920617495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6179469632738155d, y: 0.9083281504306003d), new NpgsqlTypes.NpgsqlPoint(x: 0.4187746657291199d, y: 0.5762648340823177d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6263217538929232d, y: 0.0031619575553476498d), new NpgsqlTypes.NpgsqlPoint(x: 0.24791754438633906d, y: 0.7301104189223484d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845816804021727d, y: 0.06512171604351813d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40242366600804047d, y: 0.13673167385074836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4249320039537181d, y: 0.4439879092775241d), new NpgsqlTypes.NpgsqlPoint(x: 0.8636233656633133d, y: 0.484038535627371d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7772412496658769d, y: 0.9995329439991443d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751644226335094d, y: 0.7041574674457793d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215348682154709d, y: 0.03580655006413436d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8370787970709375d, y: 0.07796961745582165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409932905646952d, y: 0.8266254339449756d), new NpgsqlTypes.NpgsqlPoint(x: 0.11602403669225281d, y: 0.7808134315249554d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8127577444990014d, y: 0.8299071246699485d), new NpgsqlTypes.NpgsqlPoint(x: 0.07756098250905752d, y: 0.9420554497244632d), new NpgsqlTypes.NpgsqlPoint(x: 0.981235641276641d, y: 0.386536747546776d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7164138911864478d, y: 0.29268723478535075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8152365897426334d, y: 0.1805821264704004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8410494896841277d, y: 0.007456697452142835d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9765784927490202d, y: 0.09494852798901421d), new NpgsqlTypes.NpgsqlPoint(x: 0.06100064020025886d, y: 0.46551388963051976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185485484345432d, y: 0.44794857126675625d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31086255187637846d, y: 0.30379448540847476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301459359287489d, y: 0.6764297853886805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5563638012126131d, y: 0.36258451853384865d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9767733328857614d, y: 0.18757189840288524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3388778414831134d, y: 0.06261047935353314d), new NpgsqlTypes.NpgsqlPoint(x: 0.007495375361959877d, y: 0.34293099784591863d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1873995289579924d, y: 0.40763051439747755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7100343878439613d, y: 0.2003673913321823d), new NpgsqlTypes.NpgsqlPoint(x: 0.39100971499042425d, y: 0.4312830102656625d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.697309787927633d, y: 0.11102666866277444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524899918612579d, y: 0.8503330892129461d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183749764344555d, y: 0.3961676110870481d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5877509590719312d, y: 0.8458307294561217d), new NpgsqlTypes.NpgsqlPoint(x: 0.17314133819489397d, y: 0.33339117239840055d), new NpgsqlTypes.NpgsqlPoint(x: 0.35096610748287527d, y: 0.5331953987296846d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9348731318801783d, y: 0.6475068448236762d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273122794956602d, y: 0.6727051240698924d), new NpgsqlTypes.NpgsqlPoint(x: 0.46595584527313927d, y: 0.9572060850920803d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36808073054380774d, y: 0.486198371374886d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655880852533459d, y: 0.3264103554534634d), new NpgsqlTypes.NpgsqlPoint(x: 0.17592381806837065d, y: 0.45395460270550103d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4781079286247796d, y: 0.7475691213017578d), new NpgsqlTypes.NpgsqlPoint(x: 0.2817853698697671d, y: 0.9922732053063348d), new NpgsqlTypes.NpgsqlPoint(x: 0.71716611824325d, y: 0.24808479405300676d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6349708641336853d, y: 0.20911867798264971d), new NpgsqlTypes.NpgsqlPoint(x: 0.36253218135976484d, y: 0.5863141454042113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7360447814605688d, y: 0.812189798833545d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1690004021334821d, y: 0.7791747370912523d), new NpgsqlTypes.NpgsqlPoint(x: 0.17439272132000627d, y: 0.32280228694960167d), new NpgsqlTypes.NpgsqlPoint(x: 0.4231302041224275d, y: 0.9450512993481301d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04550313697481234d, y: 0.7377171015532743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903596601277018d, y: 0.0484191787850613d), new NpgsqlTypes.NpgsqlPoint(x: 0.19571087751584604d, y: 0.7217219209783059d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3334654479364175d, y: 0.7375663573579936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287326541170348d, y: 0.5392894993650484d), new NpgsqlTypes.NpgsqlPoint(x: 0.16129394642271255d, y: 0.8942058332867364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9879203953570008d, y: 0.15167394569810422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6240061635399542d, y: 0.3480687451693033d), new NpgsqlTypes.NpgsqlPoint(x: 0.24877217310637867d, y: 0.4801744125771171d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4464324424748082d, y: 0.9935512456636242d), new NpgsqlTypes.NpgsqlPoint(x: 0.2464506144868902d, y: 0.4940076432306848d), new NpgsqlTypes.NpgsqlPoint(x: 0.783157166548736d, y: 0.8626241420680043d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18701343636585066d, y: 0.23021545213536387d), new NpgsqlTypes.NpgsqlPoint(x: 0.45489408274348253d, y: 0.5809600126788337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3848634148148573d, y: 0.03649518978260302d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8671898694506914d, y: 0.601803683963728d), new NpgsqlTypes.NpgsqlPoint(x: 0.32497421037854823d, y: 0.5287726784617457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6691074883946687d, y: 0.11232130133548235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3148456349815958d, y: 0.16488246688794428d), new NpgsqlTypes.NpgsqlPoint(x: 0.2106229864688557d, y: 0.750661300226108d), new NpgsqlTypes.NpgsqlPoint(x: 0.33372802831729576d, y: 0.06522998605732777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5946029368330525d, y: 0.5385740218957662d), new NpgsqlTypes.NpgsqlPoint(x: 0.13526401767366258d, y: 0.3931083857573985d), new NpgsqlTypes.NpgsqlPoint(x: 0.04034409634670533d, y: 0.3016666462443869d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1583428778495619d, y: 0.4483251780138823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770290877144542d, y: 0.9342849669080667d), new NpgsqlTypes.NpgsqlPoint(x: 0.02428022472180158d, y: 0.6163336908709238d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52768293742456d, y: 0.15659645758963336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673292362903627d, y: 0.1025792998419971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7839174904123277d, y: 0.7476046379233431d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4160908787676295d, y: 0.6362405801165102d), new NpgsqlTypes.NpgsqlPoint(x: 0.0378876752000864d, y: 0.6716031346962575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372775258912329d, y: 0.10024671846350053d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.956006293065814d, y: 0.5848237303158403d), new NpgsqlTypes.NpgsqlPoint(x: 0.07636464865458992d, y: 0.3691384803669965d), new NpgsqlTypes.NpgsqlPoint(x: 0.38046504552994054d, y: 0.3810432318271898d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.195996648117439d, y: 0.000801601022183962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4301863876465447d, y: 0.7231821512952068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4593385938412148d, y: 0.23531835835948822d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6199551202294783d, y: 0.25991862808870125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761324661757771d, y: 0.24967389617785618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7434025106507548d, y: 0.8080343751514072d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8905017372079455d, y: 0.8603529986651202d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785779457902468d, y: 0.9597240931100878d), new NpgsqlTypes.NpgsqlPoint(x: 0.37308362396725625d, y: 0.4069332662284275d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8953461848715412d, y: 0.7613009136188923d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016843061523794d, y: 0.7202040911968426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8966602629352709d, y: 0.7649169532982414d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7226427751187267d, y: 0.11884332280392762d), new NpgsqlTypes.NpgsqlPoint(x: 0.43692168445799506d, y: 0.6411750133809093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4029386144401127d, y: 0.26077946760778814d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.585871223034925d, y: 0.8661677447799426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139531940364011d, y: 0.7405923356565065d), new NpgsqlTypes.NpgsqlPoint(x: 0.24520020328114223d, y: 0.06613778558161765d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6507301258676651d, y: 0.2372663850157556d), new NpgsqlTypes.NpgsqlPoint(x: 0.2119433116362549d, y: 0.60858556296642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243023046598417d, y: 0.28457004014863907d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10746177956786018d, y: 0.8204378200829157d), new NpgsqlTypes.NpgsqlPoint(x: 0.48980284992341794d, y: 0.1339567089099234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684861586593998d, y: 0.2957175717465418d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.766661161386413d, y: 0.04554526052365493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316631516617941d, y: 0.2344091778768429d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693010786851016d, y: 0.019290526177195066d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39840062236722307d, y: 0.7130932433010243d), new NpgsqlTypes.NpgsqlPoint(x: 0.19452594351070296d, y: 0.06995486304134191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7174070831090876d, y: 0.9912554916124211d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33375464501657637d, y: 0.9210826045188106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9380125107827626d, y: 0.8986168097395657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8058263599381165d, y: 0.27259562685446104d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5327607024791929d, y: 0.9370184694307124d), new NpgsqlTypes.NpgsqlPoint(x: 0.385875921461728d, y: 0.9930540788271639d), new NpgsqlTypes.NpgsqlPoint(x: 0.504244852494745d, y: 0.7020631681230761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9814405220041578d, y: 0.5470391272946687d), new NpgsqlTypes.NpgsqlPoint(x: 0.623392945142848d, y: 0.5549404371869399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145994269340439d, y: 0.9928192318931938d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5816179984410808d, y: 0.3584316562721762d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719095108251376d, y: 0.2489981206103674d), new NpgsqlTypes.NpgsqlPoint(x: 0.1205780415978176d, y: 0.1077886169838419d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3129319952011148d, y: 0.7517985610586354d), new NpgsqlTypes.NpgsqlPoint(x: 0.18883336190494437d, y: 0.891362457383504d), new NpgsqlTypes.NpgsqlPoint(x: 0.02642463349613078d, y: 0.830302634408302d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30136108676790996d, y: 0.8125389734166066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045793743684987d, y: 0.5193072276409245d), new NpgsqlTypes.NpgsqlPoint(x: 0.38473531879933986d, y: 0.322466271292427d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09485144614553498d, y: 0.6290818004181213d), new NpgsqlTypes.NpgsqlPoint(x: 0.09357441298246827d, y: 0.5689110764754973d), new NpgsqlTypes.NpgsqlPoint(x: 0.3220889025593252d, y: 0.06506573641626523d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7849856894310627d, y: 0.17184136712440534d), new NpgsqlTypes.NpgsqlPoint(x: 0.0015272811918747298d, y: 0.9508315462735432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172207153083865d, y: 0.5816792944210133d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7604474632072065d, y: 0.4346104418417426d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187700139996526d, y: 0.496274836183508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705087755738723d, y: 0.43697472225541556d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36167263470004485d, y: 0.044295187354158605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994890615942818d, y: 0.08890134623794643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355289565188019d, y: 0.18643861900598557d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7667671228434567d, y: 0.8830786139273709d), new NpgsqlTypes.NpgsqlPoint(x: 0.24531859259586697d, y: 0.05864227180864379d), new NpgsqlTypes.NpgsqlPoint(x: 0.16088573429133224d, y: 0.5822722882715105d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9395390311299459d, y: 0.5869170346131353d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291518455451458d, y: 0.6064076858720686d), new NpgsqlTypes.NpgsqlPoint(x: 0.669550716128304d, y: 0.5086108354595977d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8642723958666423d, y: 0.6252705033372427d), new NpgsqlTypes.NpgsqlPoint(x: 0.44368944836818536d, y: 0.26079774206029027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5289084312110283d, y: 0.7585743556295899d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6562861357269262d, y: 0.7886698205784224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465269293788231d, y: 0.7480516617757627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9667797295934979d, y: 0.8115093424212853d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8812492610647044d, y: 0.6579231335862837d), new NpgsqlTypes.NpgsqlPoint(x: 0.0824948005882612d, y: 0.9765699892211372d), new NpgsqlTypes.NpgsqlPoint(x: 0.2546411514964264d, y: 0.9046992108886867d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3875400917070134d, y: 0.35295696342534977d), new NpgsqlTypes.NpgsqlPoint(x: 0.5164514787336977d, y: 0.9365521286751596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7494536671552144d, y: 0.48082430386828434d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5133355882623302d, y: 0.7086331781224997d), new NpgsqlTypes.NpgsqlPoint(x: 0.18636401427373328d, y: 0.532660367683125d), new NpgsqlTypes.NpgsqlPoint(x: 0.2776021609032867d, y: 0.6565871299739608d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3496159723767591d, y: 0.8592143778825809d), new NpgsqlTypes.NpgsqlPoint(x: 0.49847645637236726d, y: 0.36889929027989754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276600677542233d, y: 0.9671977656740848d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18682556282701646d, y: 0.022290602451563002d), new NpgsqlTypes.NpgsqlPoint(x: 0.01488557570918514d, y: 0.4037303317427656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6421087356968131d, y: 0.5705469326383587d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0009646588775897857d, y: 0.5807439203809233d), new NpgsqlTypes.NpgsqlPoint(x: 0.593256254418785d, y: 0.13914693070488804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556747372274166d, y: 0.13669082982438807d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30577743156710835d, y: 0.6315875690427002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910985255372619d, y: 0.7132349643848852d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204463635660264d, y: 0.09675975237673362d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6750196797320885d, y: 0.5171454099823893d), new NpgsqlTypes.NpgsqlPoint(x: 0.18237144798239524d, y: 0.2887106198785905d), new NpgsqlTypes.NpgsqlPoint(x: 0.2446215812206456d, y: 0.9485765401695495d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0911618994632033d, y: 0.39645487005682245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275904804089279d, y: 0.9356193711068254d), new NpgsqlTypes.NpgsqlPoint(x: 0.00033551997435754544d, y: 0.5025222473829865d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43167705546571955d, y: 0.38757376277241384d), new NpgsqlTypes.NpgsqlPoint(x: 0.12376138168453898d, y: 0.5229398681931812d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701994057239272d, y: 0.10644894536999439d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.81740466361024d, y: 0.07851271320479625d), new NpgsqlTypes.NpgsqlPoint(x: 0.07893888447088371d, y: 0.7427623567037597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7718992158490645d, y: 0.9850326801786992d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0022602599299433868d, y: 0.09554449048591973d), new NpgsqlTypes.NpgsqlPoint(x: 0.640466969828297d, y: 0.7040516033562942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8537179244155976d, y: 0.852721342144407d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6785910515932098d, y: 0.2846657853716512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9818657281203479d, y: 0.8557983597656189d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454965684059752d, y: 0.00043687612466869474d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.827291443926166d, y: 0.2916628655252409d), new NpgsqlTypes.NpgsqlPoint(x: 0.10315470431739282d, y: 0.9883481704547254d), new NpgsqlTypes.NpgsqlPoint(x: 0.44879144220761347d, y: 0.48352224854740145d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6717465461358444d, y: 0.4081588322388028d), new NpgsqlTypes.NpgsqlPoint(x: 0.21084325483914412d, y: 0.7910819048718435d), new NpgsqlTypes.NpgsqlPoint(x: 0.10262905495589159d, y: 0.0721151665646359d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022464062649471206d, y: 0.7162447210401016d), new NpgsqlTypes.NpgsqlPoint(x: 0.35011935233636304d, y: 0.023313673638514554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8510388248937263d, y: 0.32290731779311643d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.060927542966756065d, y: 0.9730883500282467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8648524521793091d, y: 0.9449817561543156d), new NpgsqlTypes.NpgsqlPoint(x: 0.22078400100816598d, y: 0.8939951479615377d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49750243177218323d, y: 0.9333295244777418d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809525788123737d, y: 0.9461189213462656d), new NpgsqlTypes.NpgsqlPoint(x: 0.0874866212489307d, y: 0.20876288342314664d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26884009616442217d, y: 0.44981013654356594d), new NpgsqlTypes.NpgsqlPoint(x: 0.10239733088132186d, y: 0.5704859167604405d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935202480536623d, y: 0.7804876977138147d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18527880216233272d, y: 0.05942325153163963d), new NpgsqlTypes.NpgsqlPoint(x: 0.12143899192282981d, y: 0.35950863130785626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282378268205665d, y: 0.9456859482682838d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6351126845337376d, y: 0.4913248935577933d), new NpgsqlTypes.NpgsqlPoint(x: 0.4919853153220449d, y: 0.657437246539321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128890426791476d, y: 0.05764800681740956d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9840212337727324d, y: 0.6989406133060864d), new NpgsqlTypes.NpgsqlPoint(x: 0.013047724676326755d, y: 0.09628447985527133d), new NpgsqlTypes.NpgsqlPoint(x: 0.79523343138451d, y: 0.735167914345817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3715889515605374d, y: 0.1710104334519611d), new NpgsqlTypes.NpgsqlPoint(x: 0.780437375677682d, y: 0.9624537916629237d), new NpgsqlTypes.NpgsqlPoint(x: 0.1222114314973336d, y: 0.28295960216059013d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6935476331727585d, y: 0.8802806976386908d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686456010356569d, y: 0.478273832723795d), new NpgsqlTypes.NpgsqlPoint(x: 0.19704924160862802d, y: 0.6007768627491155d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23355635918913742d, y: 0.2824548955138966d), new NpgsqlTypes.NpgsqlPoint(x: 0.15954056852002962d, y: 0.0017187595166128222d), new NpgsqlTypes.NpgsqlPoint(x: 0.971185099638151d, y: 0.4514224525280006d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3507941692043043d, y: 0.09460562333697142d), new NpgsqlTypes.NpgsqlPoint(x: 0.37130242508061706d, y: 0.40302439332044127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652324473481491d, y: 0.12527026055947044d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14041838673119045d, y: 0.2712216461140031d), new NpgsqlTypes.NpgsqlPoint(x: 0.20554186795429263d, y: 0.5104062909577671d), new NpgsqlTypes.NpgsqlPoint(x: 0.1496223567355518d, y: 0.4254074546485467d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5164406253263356d, y: 0.6232203102487238d), new NpgsqlTypes.NpgsqlPoint(x: 0.4857772449461678d, y: 0.3929950456959469d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904132017957318d, y: 0.4932563616859579d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41624111570800804d, y: 0.11093417600330413d), new NpgsqlTypes.NpgsqlPoint(x: 0.20851295263675484d, y: 0.700173629122151d), new NpgsqlTypes.NpgsqlPoint(x: 0.8447276193569061d, y: 0.9868074643166552d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7233181789673591d, y: 0.4408620680499029d), new NpgsqlTypes.NpgsqlPoint(x: 0.41912086581205976d, y: 0.580213720925449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4773069552499243d, y: 0.10280221609854501d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7028623838777018d, y: 0.012971270607971097d), new NpgsqlTypes.NpgsqlPoint(x: 0.16953604737161576d, y: 0.6499914323572077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885471554456522d, y: 0.6225583626497878d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.766135540646358d, y: 0.30490890462375597d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027222791778254d, y: 0.529527474999185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5533397515082672d, y: 0.41746716615005086d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 191,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8680947450331534d, y: 0.1312737055697374d), new NpgsqlTypes.NpgsqlPoint(x: 0.696455743501808d, y: 0.45611284843211897d), new NpgsqlTypes.NpgsqlPoint(x: 0.8040318571301938d, y: 0.48102707999181216d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6259363118642712d, y: 0.3307201368640702d), new NpgsqlTypes.NpgsqlPoint(x: 0.8715413699033396d, y: 0.17861140452160407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822717954800663d, y: 0.24506750808063582d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8047060607206749d, y: 0.38311536661230483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397273333101414d, y: 0.580068101730528d), new NpgsqlTypes.NpgsqlPoint(x: 0.815548539797867d, y: 0.5305240891296528d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9852979746376858d, y: 0.7223461837425742d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531860549280303d, y: 0.27180673971142566d), new NpgsqlTypes.NpgsqlPoint(x: 0.42637024717390115d, y: 0.7041984560483608d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 197,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30003013163039327d, y: 0.43517437728080655d), new NpgsqlTypes.NpgsqlPoint(x: 0.27890199723896936d, y: 0.6815372896014256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981545661985833d, y: 0.9064805365539161d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4077515161664905d, y: 0.3909930392708363d), new NpgsqlTypes.NpgsqlPoint(x: 0.15660969919458323d, y: 0.06988822844910703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7577737742526771d, y: 0.5726996704608585d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5996701779503169d, y: 0.880893405105779d), new NpgsqlTypes.NpgsqlPoint(x: 0.7593874832168467d, y: 0.9569188209874174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673698169034964d, y: 0.17448201431443333d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33580168285219303d, y: 0.9527625122836193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345875062258265d, y: 0.09484823455064928d), new NpgsqlTypes.NpgsqlPoint(x: 0.64665777095946d, y: 0.08278023475232144d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7121266096376944d, y: 0.6538389324709093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8995723800698777d, y: 0.05854827320730882d), new NpgsqlTypes.NpgsqlPoint(x: 0.24300883336169687d, y: 0.02653062630738945d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735346770671312d, y: 0.9520209734922338d), new NpgsqlTypes.NpgsqlPoint(x: 0.012110886025279544d, y: 0.547830768037933d), new NpgsqlTypes.NpgsqlPoint(x: 0.045487660615008974d, y: 0.685991809962301d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9029555193129095d, y: 0.3513530511189805d), new NpgsqlTypes.NpgsqlPoint(x: 0.2873003285878265d, y: 0.9011351334281175d), new NpgsqlTypes.NpgsqlPoint(x: 0.29935887632933134d, y: 0.1781719453733318d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40022810742092163d, y: 0.12185996762570872d), new NpgsqlTypes.NpgsqlPoint(x: 0.27626655228457186d, y: 0.6818231112602301d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122709437636484d, y: 0.04249291844046743d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7255602498872044d, y: 0.8500028923564595d), new NpgsqlTypes.NpgsqlPoint(x: 0.36954894711777664d, y: 0.2844289142885281d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842342801807652d, y: 0.37004234461970775d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8846086170662097d, y: 0.5816094340193921d), new NpgsqlTypes.NpgsqlPoint(x: 0.9072510614617794d, y: 0.42712301589193646d), new NpgsqlTypes.NpgsqlPoint(x: 0.40656356360613266d, y: 0.5459790022509002d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16233340480252634d, y: 0.21883575317537818d), new NpgsqlTypes.NpgsqlPoint(x: 0.37742710226261933d, y: 0.24255406219611952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988814591448192d, y: 0.9570205237635094d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 203,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5041760655590907d, y: 0.06471310764699734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350987294789791d, y: 0.8870910540332425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8299253808368903d, y: 0.17248822987116275d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19537290907184468d, y: 0.19471607074856478d), new NpgsqlTypes.NpgsqlPoint(x: 0.9118591308144796d, y: 0.6514340481971075d), new NpgsqlTypes.NpgsqlPoint(x: 0.10814934785086472d, y: 0.24246881657175012d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9303497106290837d, y: 0.15883128846304506d), new NpgsqlTypes.NpgsqlPoint(x: 0.11371207530093075d, y: 0.46942009004409135d), new NpgsqlTypes.NpgsqlPoint(x: 0.559034394506681d, y: 0.3155800949983132d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)), 
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
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7223618339820654d, y: 0.12346724938311604d), new NpgsqlTypes.NpgsqlPoint(x: 0.27990009716409625d, y: 0.7621142743185744d), new NpgsqlTypes.NpgsqlPoint(x: 0.914494590675855d, y: 0.8661024335348364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5702627012184079d, y: 0.056533327637860786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923988506471508d, y: 0.09829162834213423d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737742819632738d, y: 0.03157568591622428d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8346464590718452d, y: 0.017536499597907262d), new NpgsqlTypes.NpgsqlPoint(x: 0.889992603065083d, y: 0.24545634378290426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554962976287635d, y: 0.48714195868665755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2752159261218866d, y: 0.48867812377269093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217868595787009d, y: 0.9906538489020886d), new NpgsqlTypes.NpgsqlPoint(x: 0.1051588779033864d, y: 0.12937887146846627d)),
}));
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7680855895632699d, y: 0.42265195953373424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453809654546221d, y: 0.20766588997287805d), new NpgsqlTypes.NpgsqlPoint(x: 0.12613015937854988d, y: 0.02017734367415369d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3831697730524105d, y: 0.46883224305561255d), new NpgsqlTypes.NpgsqlPoint(x: 0.12709312597070255d, y: 0.10720887153353953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757306406876891d, y: 0.6903144948228203d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42108387279512527d, y: 0.47771116743528297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350480802184176d, y: 0.9119565776601344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993858960548517d, y: 0.012516856399031995d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3461525191670247d, y: 0.1376987771984205d), new NpgsqlTypes.NpgsqlPoint(x: 0.23989602376919195d, y: 0.16441139843275998d), new NpgsqlTypes.NpgsqlPoint(x: 0.2056833121615419d, y: 0.4357072599516165d)),
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.851301912917988d, y: 0.4777876872508313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9649628251907084d, y: 0.1262692270787351d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693015381456199d, y: 0.8370163560376098d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374365627392443d, y: 0.5344065275566958d), new NpgsqlTypes.NpgsqlPoint(x: 0.2103201852854183d, y: 0.3023136331758066d), new NpgsqlTypes.NpgsqlPoint(x: 0.882329159828571d, y: 0.7351291164803873d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7364056638642501d, y: 0.19294626428874107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924885316175029d, y: 0.7351207383336464d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309293738259135d, y: 0.7776057916552253d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5318829714067187d, y: 0.3008203932350336d), new NpgsqlTypes.NpgsqlPoint(x: 0.1210435069106256d, y: 0.566954382346218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138481144536585d, y: 0.6575588849560604d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9492131622550247d, y: 0.34098286367980557d), new NpgsqlTypes.NpgsqlPoint(x: 0.16534722220254738d, y: 0.4491348687687716d), new NpgsqlTypes.NpgsqlPoint(x: 0.20569309198327468d, y: 0.07492193345316789d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47088623221913406d, y: 0.11464842766022065d), new NpgsqlTypes.NpgsqlPoint(x: 0.33498437387308266d, y: 0.597172595029778d), new NpgsqlTypes.NpgsqlPoint(x: 0.11356841970623355d, y: 0.9728901399539209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7998080621770749d, y: 0.4770330642169709d), new NpgsqlTypes.NpgsqlPoint(x: 0.03364370517470072d, y: 0.9737142840307224d), new NpgsqlTypes.NpgsqlPoint(x: 0.06642305472125942d, y: 0.6411089732481501d)),
}));
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 172;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 66, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 163, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 98, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 116, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 5, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 135, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI), typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

