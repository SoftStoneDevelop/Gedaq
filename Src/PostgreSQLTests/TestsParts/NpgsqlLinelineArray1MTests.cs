

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
new NpgsqlTypes.NpgsqlLine(a: 0.5809378879998333d, b: 0.6355910245736253d, c: 0.0314663199781694d),
new NpgsqlTypes.NpgsqlLine(a: 0.08640687696465266d, b: 0.8703113048597275d, c: 0.8904424623362281d),
new NpgsqlTypes.NpgsqlLine(a: 0.8943587117265243d, b: 0.3116747798315753d, c: 0.8581698418606718d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.889048942978835d, b: 0.4232851794554172d, c: 0.7704377956417396d),
new NpgsqlTypes.NpgsqlLine(a: 0.12969788621577305d, b: 0.600358458918859d, c: 0.6057892192832824d),
new NpgsqlTypes.NpgsqlLine(a: 0.8461152223503672d, b: 0.8692772375736034d, c: 0.7529845538928387d),
new NpgsqlTypes.NpgsqlLine(a: 0.19245872989509538d, b: 0.455912204096414d, c: 0.9143578648432619d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6027427559364666d, b: 0.9795970869599951d, c: 0.8617574950381721d),
new NpgsqlTypes.NpgsqlLine(a: 0.6751696608282464d, b: 0.6901777672747368d, c: 0.1510805926104819d),
new NpgsqlTypes.NpgsqlLine(a: 0.684799036950206d, b: 0.5623903309159923d, c: 0.17986751433230552d),
new NpgsqlTypes.NpgsqlLine(a: 0.6602852900010086d, b: 0.22536976978545953d, c: 0.545326201845534d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9654302601557301d, b: 0.10211830651135434d, c: 0.9744733873847127d),
new NpgsqlTypes.NpgsqlLine(a: 0.7084782310539592d, b: 0.38213902462980187d, c: 0.08215626453182734d),
new NpgsqlTypes.NpgsqlLine(a: 0.22954114791785518d, b: 0.8921669406012778d, c: 0.11390896387412441d),
new NpgsqlTypes.NpgsqlLine(a: 0.06633868925620778d, b: 0.36920402611571923d, c: 0.8385637133297693d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5121312784987678d, b: 0.6384773380403426d, c: 0.8879306811996209d),
new NpgsqlTypes.NpgsqlLine(a: 0.4323244480570697d, b: 0.8559306683195183d, c: 0.6021998263923964d),
new NpgsqlTypes.NpgsqlLine(a: 0.2131247894507028d, b: 0.7282247895632488d, c: 0.951808048689727d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6431612193718158d, b: 0.45038396280039794d, c: 0.6507636690953185d),
new NpgsqlTypes.NpgsqlLine(a: 0.4174556436987056d, b: 0.9084944330395783d, c: 0.3469402932926008d),
new NpgsqlTypes.NpgsqlLine(a: 0.8948496286376849d, b: 0.1752708957182436d, c: 0.3149132480455755d),
new NpgsqlTypes.NpgsqlLine(a: 0.2565801641197146d, b: 0.26213144415862744d, c: 0.5728347414799545d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082881806878124d, b: 0.46777890938154376d, c: 0.1345384933778221d),
new NpgsqlTypes.NpgsqlLine(a: 0.9170533654194996d, b: 0.9606400201949334d, c: 0.2593711948709806d),
new NpgsqlTypes.NpgsqlLine(a: 0.1451145573882271d, b: 0.33285034696670146d, c: 0.6134334692228013d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8292540740436939d, b: 0.45551729597585633d, c: 0.7525978908083674d),
new NpgsqlTypes.NpgsqlLine(a: 0.2511815391299751d, b: 0.6746607725555173d, c: 0.2169683494109922d),
new NpgsqlTypes.NpgsqlLine(a: 0.7636229068086304d, b: 0.20214741607424724d, c: 0.5051323776455737d),
new NpgsqlTypes.NpgsqlLine(a: 0.48379107591296244d, b: 0.8730653273235164d, c: 0.028167824004137865d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4531441888148654d, b: 0.8498020986593599d, c: 0.8082478336278535d),
new NpgsqlTypes.NpgsqlLine(a: 0.9936957509636574d, b: 0.4277419343455403d, c: 0.952385594628441d),
new NpgsqlTypes.NpgsqlLine(a: 0.058463537994885795d, b: 0.7758750248119249d, c: 0.2146639942566405d),
new NpgsqlTypes.NpgsqlLine(a: 0.6122657372497123d, b: 0.8602591037466811d, c: 0.29921908086878535d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.02061572407295953d, b: 0.1541053296307272d, c: 0.5746890046620113d),
new NpgsqlTypes.NpgsqlLine(a: 0.7742230590905101d, b: 0.624812472335351d, c: 0.1587722524631473d),
new NpgsqlTypes.NpgsqlLine(a: 0.4516150705334935d, b: 0.5589120391830159d, c: 0.7197121393605572d),
new NpgsqlTypes.NpgsqlLine(a: 0.023696371601451882d, b: 0.3220091839125778d, c: 0.01953329220877764d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48951663326845307d, b: 0.7635729470448215d, c: 0.8505161594580425d),
new NpgsqlTypes.NpgsqlLine(a: 0.13495917173204575d, b: 0.6691208158417785d, c: 0.879492309952534d),
new NpgsqlTypes.NpgsqlLine(a: 0.8674962176915031d, b: 0.5269943001061719d, c: 0.06376993492254956d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3724801111026169d, b: 0.24253789909372347d, c: 0.4338054885478112d),
new NpgsqlTypes.NpgsqlLine(a: 0.6387923003348972d, b: 0.6086234127485021d, c: 0.2855867148106832d),
new NpgsqlTypes.NpgsqlLine(a: 0.7532020684179669d, b: 0.6860817534842437d, c: 0.2462919996097771d),
new NpgsqlTypes.NpgsqlLine(a: 0.46081271924375955d, b: 0.30468050754685283d, c: 0.4994915459316893d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14541324149468138d, b: 0.8187357544868095d, c: 0.32357444489455534d),
new NpgsqlTypes.NpgsqlLine(a: 0.7960397932336475d, b: 0.9140913888668352d, c: 0.16027509566673048d),
new NpgsqlTypes.NpgsqlLine(a: 0.640374648152233d, b: 0.518301980201618d, c: 0.0884969912182505d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5033652192547684d, b: 0.36787655192226243d, c: 0.18275911413473078d),
new NpgsqlTypes.NpgsqlLine(a: 0.44201785089564316d, b: 0.09978482437385827d, c: 0.537032652961817d),
new NpgsqlTypes.NpgsqlLine(a: 0.32799469270051274d, b: 0.18206997739379105d, c: 0.6756923950329519d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.13732788286713704d, b: 0.19916941675038324d, c: 0.6315208137257838d),
new NpgsqlTypes.NpgsqlLine(a: 0.17249282033034274d, b: 0.42086930576028203d, c: 0.22901100859788726d),
new NpgsqlTypes.NpgsqlLine(a: 0.5708958465660494d, b: 0.616193192282233d, c: 0.5225945383342225d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9553653048022747d, b: 0.9092701423120123d, c: 0.24014610768675115d),
new NpgsqlTypes.NpgsqlLine(a: 0.011509448244182319d, b: 0.2696624806501945d, c: 0.5144650362651393d),
new NpgsqlTypes.NpgsqlLine(a: 0.4343918343416895d, b: 0.5474810354531898d, c: 0.305677778798905d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7209490593706004d, b: 0.48894645696184413d, c: 0.793693962574236d),
new NpgsqlTypes.NpgsqlLine(a: 0.6547300956552682d, b: 0.4206013621562522d, c: 0.2632373454347743d),
new NpgsqlTypes.NpgsqlLine(a: 0.3862937440374663d, b: 0.6061373902199837d, c: 0.6628315433968303d),
new NpgsqlTypes.NpgsqlLine(a: 0.5999057891658047d, b: 0.9157245064181989d, c: 0.412024077048334d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6996007714046033d, b: 0.7957672171066181d, c: 0.27516340235311576d),
new NpgsqlTypes.NpgsqlLine(a: 0.05486300156778101d, b: 0.8955169502011081d, c: 0.9765576811214386d),
new NpgsqlTypes.NpgsqlLine(a: 0.5901278417943919d, b: 0.6392591883414164d, c: 0.20878302816325356d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8216571560447176d, b: 0.24384261466175516d, c: 0.9865891674683415d),
new NpgsqlTypes.NpgsqlLine(a: 0.08145126022642635d, b: 0.19211337881695867d, c: 0.2849120138721426d),
new NpgsqlTypes.NpgsqlLine(a: 0.09851466314950608d, b: 0.5247187572155928d, c: 0.8100132922590659d),
new NpgsqlTypes.NpgsqlLine(a: 0.7443000488501638d, b: 0.8255250844759501d, c: 0.032373779893152044d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.974435542616962d, b: 0.13608205204377632d, c: 0.32558035358356197d),
new NpgsqlTypes.NpgsqlLine(a: 0.7906591977883493d, b: 0.13864591659808667d, c: 0.8178689910019321d),
new NpgsqlTypes.NpgsqlLine(a: 0.39846034588925605d, b: 0.2831881431555481d, c: 0.571381338414618d),
new NpgsqlTypes.NpgsqlLine(a: 0.5671079596237979d, b: 0.8390499358495783d, c: 0.349932208861898d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18984683719647832d, b: 0.0051879080855855575d, c: 0.8429423201931784d),
new NpgsqlTypes.NpgsqlLine(a: 0.9160833861562208d, b: 0.6363364801788793d, c: 0.9765673322857366d),
new NpgsqlTypes.NpgsqlLine(a: 0.8856642873497113d, b: 0.24647139529966622d, c: 0.5788673969077529d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5033974139218517d, b: 0.6289136119785539d, c: 0.9116678593939926d),
new NpgsqlTypes.NpgsqlLine(a: 0.9097513849227539d, b: 0.0466109994163717d, c: 0.8387628413210508d),
new NpgsqlTypes.NpgsqlLine(a: 0.585044411255492d, b: 0.15241650450073063d, c: 0.5331619403729283d),
new NpgsqlTypes.NpgsqlLine(a: 0.3606002107936258d, b: 0.24315027034249992d, c: 0.5058061611718372d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861559048120531d, b: 0.3570313940442228d, c: 0.47990409835436953d),
new NpgsqlTypes.NpgsqlLine(a: 0.17966820721172416d, b: 0.22988500401077905d, c: 0.41868422393764815d),
new NpgsqlTypes.NpgsqlLine(a: 0.19203201302385808d, b: 0.9050451477556549d, c: 0.6476868913802775d),
new NpgsqlTypes.NpgsqlLine(a: 0.7154772601482227d, b: 0.5341748338579786d, c: 0.9920540975996304d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.723680855907672d, b: 0.9417562347310285d, c: 0.5594223445898808d),
new NpgsqlTypes.NpgsqlLine(a: 0.016477980303668538d, b: 0.6989240639869936d, c: 0.9872230015068554d),
new NpgsqlTypes.NpgsqlLine(a: 0.2960176916136078d, b: 0.8490076825843333d, c: 0.9517580173234603d),
new NpgsqlTypes.NpgsqlLine(a: 0.6169418239115055d, b: 0.1534529967018805d, c: 0.3288066048976551d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.818640660834031d, b: 0.8613289844493159d, c: 0.9271979231865017d),
new NpgsqlTypes.NpgsqlLine(a: 0.0038890240609296134d, b: 0.5685691622191589d, c: 0.937067851596899d),
new NpgsqlTypes.NpgsqlLine(a: 0.3937179163843443d, b: 0.05494542641187761d, c: 0.07207804720773636d),
new NpgsqlTypes.NpgsqlLine(a: 0.20381918913978736d, b: 0.3934358459740632d, c: 0.550925416635342d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5563000047672008d, b: 0.8184606969393098d, c: 0.43664613667470076d),
new NpgsqlTypes.NpgsqlLine(a: 0.577521281929923d, b: 0.7121378359371209d, c: 0.4576541174368639d),
new NpgsqlTypes.NpgsqlLine(a: 0.05411562146510107d, b: 0.22125400144678375d, c: 0.5475489814425678d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3283063149273343d, b: 0.17308628051701447d, c: 0.32420002393121694d),
new NpgsqlTypes.NpgsqlLine(a: 0.8559033903585137d, b: 0.48918037019436145d, c: 0.767188128291444d),
new NpgsqlTypes.NpgsqlLine(a: 0.06734870351838573d, b: 0.19529197216142313d, c: 0.28203417177992574d),
new NpgsqlTypes.NpgsqlLine(a: 0.2900284802391593d, b: 0.4196345897457635d, c: 0.14915595191497577d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9291356667310857d, b: 0.5755260427815436d, c: 0.6013585485731013d),
new NpgsqlTypes.NpgsqlLine(a: 0.7136772557033513d, b: 0.9905721162957696d, c: 0.7375593339554676d),
new NpgsqlTypes.NpgsqlLine(a: 0.23436503471201575d, b: 0.5640505547064736d, c: 0.48005139131899843d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8727430452443645d, b: 0.8206537163996952d, c: 0.7627279774564442d),
new NpgsqlTypes.NpgsqlLine(a: 0.6577510205475999d, b: 0.7238701083912568d, c: 0.6352480367713799d),
new NpgsqlTypes.NpgsqlLine(a: 0.34318922416840236d, b: 0.04665255096248777d, c: 0.5445784578448684d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07454497789646042d, b: 0.7497737199174367d, c: 0.30519430725643637d),
new NpgsqlTypes.NpgsqlLine(a: 0.5137843716972197d, b: 0.8240811888466153d, c: 0.5924662551838581d),
new NpgsqlTypes.NpgsqlLine(a: 0.3813273596895722d, b: 0.35748996318171256d, c: 0.08051600366538403d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8131039547041943d, b: 0.264424633927029d, c: 0.6285106220561524d),
new NpgsqlTypes.NpgsqlLine(a: 0.6189976683811013d, b: 0.4221463348683575d, c: 0.2408295343158945d),
new NpgsqlTypes.NpgsqlLine(a: 0.25120010177205065d, b: 0.23148553898560387d, c: 0.6389620564902602d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5459528745731358d, b: 0.8975453052604733d, c: 0.9769633257298761d),
new NpgsqlTypes.NpgsqlLine(a: 0.8876897367125565d, b: 0.9140094574815824d, c: 0.07226975613723674d),
new NpgsqlTypes.NpgsqlLine(a: 0.5254101423350676d, b: 0.5779299282220036d, c: 0.09115348977078641d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8106562233123643d, b: 0.6764080313860683d, c: 0.8232787807222297d),
new NpgsqlTypes.NpgsqlLine(a: 0.5024257705365511d, b: 0.3736533032843191d, c: 0.9032707614600386d),
new NpgsqlTypes.NpgsqlLine(a: 0.08976327988436672d, b: 0.9161659167570007d, c: 0.27225264715884356d),
new NpgsqlTypes.NpgsqlLine(a: 0.9897605565796604d, b: 0.35972551382256035d, c: 0.8761456477898598d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6619994435077369d, b: 0.5704074486226413d, c: 0.9539986653338374d),
new NpgsqlTypes.NpgsqlLine(a: 0.9461216627428699d, b: 0.17267328444366148d, c: 0.17769279345892153d),
new NpgsqlTypes.NpgsqlLine(a: 0.12098624027458371d, b: 0.5685732321151195d, c: 0.4006667996333123d),
new NpgsqlTypes.NpgsqlLine(a: 0.967585419928646d, b: 0.12494287132999415d, c: 0.47961163366487314d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7925005892440422d, b: 0.38297408196467975d, c: 0.9471351242421108d),
new NpgsqlTypes.NpgsqlLine(a: 0.7169990545283539d, b: 0.6980077985265644d, c: 0.27143742223882394d),
new NpgsqlTypes.NpgsqlLine(a: 0.598978410059253d, b: 0.7185989754879232d, c: 0.3208856958226969d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19287726215581114d, b: 0.19423592708899584d, c: 0.11400320046956314d),
new NpgsqlTypes.NpgsqlLine(a: 0.7554047997554997d, b: 0.8105229853738106d, c: 0.9576923592570707d),
new NpgsqlTypes.NpgsqlLine(a: 0.6777679788263067d, b: 0.9378695114360759d, c: 0.3149934088451969d),
new NpgsqlTypes.NpgsqlLine(a: 0.8246947353503138d, b: 0.15806615524971923d, c: 0.2713522375354136d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41414321775769714d, b: 0.19917192957584384d, c: 0.5646626742296296d),
new NpgsqlTypes.NpgsqlLine(a: 0.4600510559835457d, b: 0.08877920680068363d, c: 0.9292749654604842d),
new NpgsqlTypes.NpgsqlLine(a: 0.8512811723902789d, b: 0.6967999685082282d, c: 0.15001455523010931d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2550936535993906d, b: 0.4387067402060061d, c: 0.9932022919723068d),
new NpgsqlTypes.NpgsqlLine(a: 0.28062150529818874d, b: 0.029573247031898897d, c: 0.01811006772750534d),
new NpgsqlTypes.NpgsqlLine(a: 0.7391351450917513d, b: 0.2819920950831648d, c: 0.4516316407386486d),
new NpgsqlTypes.NpgsqlLine(a: 0.667841340511438d, b: 0.8266341170732384d, c: 0.2126694290176515d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24642717247649437d, b: 0.6120791216833148d, c: 0.4385656397760298d),
new NpgsqlTypes.NpgsqlLine(a: 0.4156227662036204d, b: 0.9875158968455002d, c: 0.42152520291965356d),
new NpgsqlTypes.NpgsqlLine(a: 0.45311068096897333d, b: 0.6410080803717355d, c: 0.1077860566522818d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.427470744439458d, b: 0.020459862344509916d, c: 0.7351970074556898d),
new NpgsqlTypes.NpgsqlLine(a: 0.18382452355933332d, b: 0.016349236331733907d, c: 0.8045854946259711d),
new NpgsqlTypes.NpgsqlLine(a: 0.9852720691043864d, b: 0.1745951021657346d, c: 0.6541356647250639d),
new NpgsqlTypes.NpgsqlLine(a: 0.16816373982780386d, b: 0.9064638141041397d, c: 0.23996190818820828d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.014296178830934592d, b: 0.1928279175365626d, c: 0.7328505740947695d),
new NpgsqlTypes.NpgsqlLine(a: 0.4627801554162533d, b: 0.03182062480026271d, c: 0.9970043489206786d),
new NpgsqlTypes.NpgsqlLine(a: 0.5581650890481006d, b: 0.9439469751815528d, c: 0.8334185322061308d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34523457899230614d, b: 0.07239653067083862d, c: 0.6741644209056903d),
new NpgsqlTypes.NpgsqlLine(a: 0.7642096660068429d, b: 0.2845819830708768d, c: 0.11618775156386307d),
new NpgsqlTypes.NpgsqlLine(a: 0.07505141414733563d, b: 0.9786327140732163d, c: 0.3190739296856345d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7997790453910043d, b: 0.8677180893125033d, c: 0.9880550205160301d),
new NpgsqlTypes.NpgsqlLine(a: 0.13033218078428732d, b: 0.34698211403836976d, c: 0.8690104992401956d),
new NpgsqlTypes.NpgsqlLine(a: 0.6073586356894172d, b: 0.9934554130466571d, c: 0.03797772950720324d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.630438254213026d, b: 0.12651294900667542d, c: 0.018786220962952016d),
new NpgsqlTypes.NpgsqlLine(a: 0.23368223501592666d, b: 0.6910346646357703d, c: 0.07899464269540735d),
new NpgsqlTypes.NpgsqlLine(a: 0.43685328250616373d, b: 0.06954392573742219d, c: 0.5872618712287687d),
new NpgsqlTypes.NpgsqlLine(a: 0.20503585217312026d, b: 0.387345431916133d, c: 0.5266150016319752d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.959498632719227d, b: 0.20436902083885078d, c: 0.09783033930056984d),
new NpgsqlTypes.NpgsqlLine(a: 0.4163411714748434d, b: 0.6498646466207821d, c: 0.9477239528679992d),
new NpgsqlTypes.NpgsqlLine(a: 0.4002337767990698d, b: 0.6518883458039149d, c: 0.7267766377885d),
new NpgsqlTypes.NpgsqlLine(a: 0.845744699320711d, b: 0.3695572834664499d, c: 0.550568653432996d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26682993771667507d, b: 0.10832841990127329d, c: 0.9443197436465701d),
new NpgsqlTypes.NpgsqlLine(a: 0.9786722776118508d, b: 0.8720573580784142d, c: 0.9349970820802628d),
new NpgsqlTypes.NpgsqlLine(a: 0.5074681226640483d, b: 0.5809666726563307d, c: 0.8224114734099686d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5683578720376765d, b: 0.49431621047485796d, c: 0.7661367233413817d),
new NpgsqlTypes.NpgsqlLine(a: 0.22613741044775704d, b: 0.0807113957719311d, c: 0.7433870702039407d),
new NpgsqlTypes.NpgsqlLine(a: 0.5069839026259757d, b: 0.9692160359113158d, c: 0.3196386656540592d),
new NpgsqlTypes.NpgsqlLine(a: 0.798514106995685d, b: 0.15775249161670402d, c: 0.4019894208044309d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4257872453075061d, b: 0.2465653741439634d, c: 0.8544306801293075d),
new NpgsqlTypes.NpgsqlLine(a: 0.42639249529654333d, b: 0.08467474566152866d, c: 0.0002851999397869287d),
new NpgsqlTypes.NpgsqlLine(a: 0.032249996363893585d, b: 0.7330379533671747d, c: 0.2364527118683386d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3272075938125d, b: 0.7383321557954182d, c: 0.6002964655791411d),
new NpgsqlTypes.NpgsqlLine(a: 0.16363575568643973d, b: 0.9218033582177062d, c: 0.1884708685234432d),
new NpgsqlTypes.NpgsqlLine(a: 0.4074673622102343d, b: 0.9948618406570854d, c: 0.7615982684092316d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8377722418999364d, b: 0.7424827391243304d, c: 0.3403153519258447d),
new NpgsqlTypes.NpgsqlLine(a: 0.07398702852826011d, b: 0.15824207763319498d, c: 0.1069606337763358d),
new NpgsqlTypes.NpgsqlLine(a: 0.809652944846306d, b: 0.2717428780037404d, c: 0.8381450480332431d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5137885624698487d, b: 0.3211250207672002d, c: 0.1354734870381733d),
new NpgsqlTypes.NpgsqlLine(a: 0.425556387771871d, b: 0.49618991634940735d, c: 0.6718238560995149d),
new NpgsqlTypes.NpgsqlLine(a: 0.8388769328904104d, b: 0.16643704182298968d, c: 0.7714449014965459d),
new NpgsqlTypes.NpgsqlLine(a: 0.6748617166456076d, b: 0.6149450651709824d, c: 0.41066961124332124d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5876958664161477d, b: 0.9403707290247023d, c: 0.4821506162234296d),
new NpgsqlTypes.NpgsqlLine(a: 0.4920489236882266d, b: 0.26589969483190845d, c: 0.41130521403376175d),
new NpgsqlTypes.NpgsqlLine(a: 0.6781908735518448d, b: 0.940744903410394d, c: 0.9382867741740731d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9800083046355658d, b: 0.6319772053509338d, c: 0.9559655520823074d),
new NpgsqlTypes.NpgsqlLine(a: 0.37623005737191983d, b: 0.37913252305772804d, c: 0.2058684769206015d),
new NpgsqlTypes.NpgsqlLine(a: 0.9122492700064128d, b: 0.17807002036399877d, c: 0.8419240669397087d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8961909625050415d, b: 0.3491009135858961d, c: 0.2386597984248785d),
new NpgsqlTypes.NpgsqlLine(a: 0.4888508565878694d, b: 0.46833056127268213d, c: 0.4699149028726569d),
new NpgsqlTypes.NpgsqlLine(a: 0.2938098139340668d, b: 0.3224688922814859d, c: 0.1301725413406406d),
new NpgsqlTypes.NpgsqlLine(a: 0.5160154604424128d, b: 0.6094691078470156d, c: 0.869067648442401d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6779555124908808d, b: 0.08287020909745002d, c: 0.5777874315602061d),
new NpgsqlTypes.NpgsqlLine(a: 0.10250169113869378d, b: 0.33011429784094704d, c: 0.16275533991668223d),
new NpgsqlTypes.NpgsqlLine(a: 0.5154417667151268d, b: 0.2198319887891108d, c: 0.8417490037273389d),
new NpgsqlTypes.NpgsqlLine(a: 0.947792167699324d, b: 0.4239358180150923d, c: 0.4397629488584659d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1420389731055387d, b: 0.9254720208141533d, c: 0.5841971506120638d),
new NpgsqlTypes.NpgsqlLine(a: 0.4146914710791424d, b: 0.5161008660794951d, c: 0.45520485811075595d),
new NpgsqlTypes.NpgsqlLine(a: 0.7846100639103575d, b: 0.17891160067388467d, c: 0.14195869655169213d),
new NpgsqlTypes.NpgsqlLine(a: 0.6678710239542887d, b: 0.18768949419536984d, c: 0.40393230603918484d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.729323144841401d, b: 0.42813751837169434d, c: 0.6987406333679734d),
new NpgsqlTypes.NpgsqlLine(a: 0.11422784303892264d, b: 0.09535354503918525d, c: 0.4475922740338464d),
new NpgsqlTypes.NpgsqlLine(a: 0.8332113807979268d, b: 0.4683293421331983d, c: 0.876554593767307d),
new NpgsqlTypes.NpgsqlLine(a: 0.882420296301217d, b: 0.8618458225913154d, c: 0.17392351346870172d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8996171180320578d, b: 0.46227213259965383d, c: 0.09443606812593697d),
new NpgsqlTypes.NpgsqlLine(a: 0.8171072426619572d, b: 0.7350511554010942d, c: 0.9213023314009372d),
new NpgsqlTypes.NpgsqlLine(a: 0.7776665457670808d, b: 0.4089729353715873d, c: 0.4692272685606276d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8022285487325417d, b: 0.28476805029198593d, c: 0.49064269400705063d),
new NpgsqlTypes.NpgsqlLine(a: 0.023068824966776202d, b: 0.21465446053892534d, c: 0.642597007206098d),
new NpgsqlTypes.NpgsqlLine(a: 0.14391772592173235d, b: 0.20497477803580533d, c: 0.2544564146931403d),
new NpgsqlTypes.NpgsqlLine(a: 0.3894848491770877d, b: 0.346995353115651d, c: 0.4743553871063225d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8921595959387811d, b: 0.5909668041624727d, c: 0.3466967027095613d),
new NpgsqlTypes.NpgsqlLine(a: 0.7668470872660816d, b: 0.9334086981251064d, c: 0.22371562815629886d),
new NpgsqlTypes.NpgsqlLine(a: 0.04508071390729729d, b: 0.6598025797201842d, c: 0.8317618443859021d),
new NpgsqlTypes.NpgsqlLine(a: 0.7247887154698751d, b: 0.9175649704871035d, c: 0.5661105137864956d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21025856600304205d, b: 0.2580197144185916d, c: 0.8173044164617483d),
new NpgsqlTypes.NpgsqlLine(a: 0.06397129524739731d, b: 0.8351273414033221d, c: 0.39237085397457105d),
new NpgsqlTypes.NpgsqlLine(a: 0.20693237844860846d, b: 0.20110535446302324d, c: 0.8823576292767096d),
new NpgsqlTypes.NpgsqlLine(a: 0.9968961874924037d, b: 0.2106681389210474d, c: 0.3250016282800534d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3982650065416977d, b: 0.7312066406348907d, c: 0.5281234779551934d),
new NpgsqlTypes.NpgsqlLine(a: 0.45687390020363217d, b: 0.5380618004929536d, c: 0.29380100201331705d),
new NpgsqlTypes.NpgsqlLine(a: 0.03166964255418292d, b: 0.9270993416124623d, c: 0.3165527853251897d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8822846608153853d, b: 0.8856594559777621d, c: 0.35553221550875613d),
new NpgsqlTypes.NpgsqlLine(a: 0.5328901869119311d, b: 0.011566473525381205d, c: 0.06592390949745475d),
new NpgsqlTypes.NpgsqlLine(a: 0.19526301120707423d, b: 0.5023143944720184d, c: 0.31529398311346746d),
new NpgsqlTypes.NpgsqlLine(a: 0.13402855911357092d, b: 0.9629775345177263d, c: 0.6098524167940245d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3689971140722559d, b: 0.47292881615247473d, c: 0.15281997134620728d),
new NpgsqlTypes.NpgsqlLine(a: 0.8428536964217715d, b: 0.8551492156186823d, c: 0.3277686250244739d),
new NpgsqlTypes.NpgsqlLine(a: 0.028539254707148687d, b: 0.16490215786351492d, c: 0.14691838806002366d),
new NpgsqlTypes.NpgsqlLine(a: 0.7034094360715912d, b: 0.9421033313495921d, c: 0.30428885897490177d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09226035660846821d, b: 0.16275579985017663d, c: 0.1708273045180524d),
new NpgsqlTypes.NpgsqlLine(a: 0.7115591313444642d, b: 0.1795470092850482d, c: 0.9268229202324941d),
new NpgsqlTypes.NpgsqlLine(a: 0.3039711366632244d, b: 0.3448027309092573d, c: 0.8168515617081594d),
new NpgsqlTypes.NpgsqlLine(a: 0.21849933023219004d, b: 0.11514594112465815d, c: 0.8114838788253875d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16685685013398666d, b: 0.6704501447953178d, c: 0.7651646007562345d),
new NpgsqlTypes.NpgsqlLine(a: 0.381440025640131d, b: 0.0565585137923752d, c: 0.3622984875285197d),
new NpgsqlTypes.NpgsqlLine(a: 0.11606196785794753d, b: 0.7195293653937667d, c: 0.9239696965191635d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6865167354318599d, b: 0.4905157574751716d, c: 0.5930519565860012d),
new NpgsqlTypes.NpgsqlLine(a: 0.892991031185204d, b: 0.5373465778869871d, c: 0.709428144881817d),
new NpgsqlTypes.NpgsqlLine(a: 0.40239903789211184d, b: 0.05110288965780596d, c: 0.8064013889420437d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.847299996437902d, b: 0.8432582218588204d, c: 0.4071013785545464d),
new NpgsqlTypes.NpgsqlLine(a: 0.3700412985321666d, b: 0.914462987371201d, c: 0.5369462178746747d),
new NpgsqlTypes.NpgsqlLine(a: 0.5601072140160049d, b: 0.06597535838997726d, c: 0.202029478796515d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9907576305325625d, b: 0.1412114556248426d, c: 0.32078166047648216d),
new NpgsqlTypes.NpgsqlLine(a: 0.9186225661584553d, b: 0.9995049226318262d, c: 0.6104323112328216d),
new NpgsqlTypes.NpgsqlLine(a: 0.3935783493542081d, b: 0.45570268105696543d, c: 0.27718956451627685d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6081003964507138d, b: 0.9740052198060885d, c: 0.35280007619636056d),
new NpgsqlTypes.NpgsqlLine(a: 0.7581798313843937d, b: 0.9097817100013418d, c: 0.544120970110608d),
new NpgsqlTypes.NpgsqlLine(a: 0.9419639245087497d, b: 0.6133949868176717d, c: 0.9689549829618588d),
new NpgsqlTypes.NpgsqlLine(a: 0.9261020923986126d, b: 0.7039015588730542d, c: 0.05660408689289931d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.36305228132391676d, b: 0.3843548853111576d, c: 0.5398720352965056d),
new NpgsqlTypes.NpgsqlLine(a: 0.38223248722955083d, b: 0.2275948144899329d, c: 0.7311175110776098d),
new NpgsqlTypes.NpgsqlLine(a: 0.720419781631642d, b: 0.2673608346773535d, c: 0.922298416816933d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.144390638490002d, b: 0.28935187645046756d, c: 0.8407524375828517d),
new NpgsqlTypes.NpgsqlLine(a: 0.7373408911686095d, b: 0.009950601091798572d, c: 0.43517881557283944d),
new NpgsqlTypes.NpgsqlLine(a: 0.11562728899628183d, b: 0.4052631027424124d, c: 0.4754382067487223d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.775204703463782d, b: 0.6560169965637279d, c: 0.06619543008223694d),
new NpgsqlTypes.NpgsqlLine(a: 0.4881822183346346d, b: 0.0816398711324241d, c: 0.5221794246476922d),
new NpgsqlTypes.NpgsqlLine(a: 0.09102576544547447d, b: 0.9414020172534752d, c: 0.7770060651893417d),
new NpgsqlTypes.NpgsqlLine(a: 0.7253491627237827d, b: 0.41561658999521045d, c: 0.4520644899396109d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.025599592280859507d, b: 0.5428850744445108d, c: 0.8126159574177896d),
new NpgsqlTypes.NpgsqlLine(a: 0.6066998487525014d, b: 0.8968391953659919d, c: 0.6275364857900609d),
new NpgsqlTypes.NpgsqlLine(a: 0.49455085346373695d, b: 0.20614728931027104d, c: 0.9203907421108523d),
new NpgsqlTypes.NpgsqlLine(a: 0.7987697648845169d, b: 0.48640981277844275d, c: 0.8164053365244094d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6430852411075189d, b: 0.737715838655799d, c: 0.5826392199433644d),
new NpgsqlTypes.NpgsqlLine(a: 0.07253475295462775d, b: 0.43937264385499886d, c: 0.7144817453394402d),
new NpgsqlTypes.NpgsqlLine(a: 0.6000967625074829d, b: 0.7563241293176647d, c: 0.9893097107215596d),
new NpgsqlTypes.NpgsqlLine(a: 0.07770302126210071d, b: 0.9754084732654219d, c: 0.629895166012716d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30696086281771495d, b: 0.9900952418571514d, c: 0.7728278023000273d),
new NpgsqlTypes.NpgsqlLine(a: 0.5623079479979519d, b: 0.6521356055030557d, c: 0.9342886390378284d),
new NpgsqlTypes.NpgsqlLine(a: 0.023822770940739812d, b: 0.8258220490580871d, c: 0.8232412438245568d),
new NpgsqlTypes.NpgsqlLine(a: 0.9161461732686875d, b: 0.2107260059809951d, c: 0.7362727020872704d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33265238502982164d, b: 0.6838394379750319d, c: 0.8749035340265214d),
new NpgsqlTypes.NpgsqlLine(a: 0.16712811405827188d, b: 0.5100812801497447d, c: 0.5445399664259698d),
new NpgsqlTypes.NpgsqlLine(a: 0.2619331157414816d, b: 0.8678023941909819d, c: 0.05915545451526938d),
new NpgsqlTypes.NpgsqlLine(a: 0.6278067658805458d, b: 0.051176256405832454d, c: 0.8712331152108744d),
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48951663326845307d, b: 0.7635729470448215d, c: 0.8505161594580425d),
new NpgsqlTypes.NpgsqlLine(a: 0.13495917173204575d, b: 0.6691208158417785d, c: 0.879492309952534d),
new NpgsqlTypes.NpgsqlLine(a: 0.8674962176915031d, b: 0.5269943001061719d, c: 0.06376993492254956d),
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
new NpgsqlTypes.NpgsqlLine(a: 0.5033652192547684d, b: 0.36787655192226243d, c: 0.18275911413473078d),
new NpgsqlTypes.NpgsqlLine(a: 0.44201785089564316d, b: 0.09978482437385827d, c: 0.537032652961817d),
new NpgsqlTypes.NpgsqlLine(a: 0.32799469270051274d, b: 0.18206997739379105d, c: 0.6756923950329519d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5563000047672008d, b: 0.8184606969393098d, c: 0.43664613667470076d),
new NpgsqlTypes.NpgsqlLine(a: 0.577521281929923d, b: 0.7121378359371209d, c: 0.4576541174368639d),
new NpgsqlTypes.NpgsqlLine(a: 0.05411562146510107d, b: 0.22125400144678375d, c: 0.5475489814425678d),
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
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 10, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 148, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[34], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 131, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 60, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[34], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 156, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 100, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[34], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
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

