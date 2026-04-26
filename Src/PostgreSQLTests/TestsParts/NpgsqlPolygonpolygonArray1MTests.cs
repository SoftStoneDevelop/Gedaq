

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21281068572060147d, y: 0.6272356770662372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434716582232751d, y: 0.2504172074050276d), new NpgsqlTypes.NpgsqlPoint(x: 0.09516561090323594d, y: 0.16415956754754135d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2049429920952014d, y: 0.4689028967231188d), new NpgsqlTypes.NpgsqlPoint(x: 0.7718732484567689d, y: 0.2820950944610692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6762524738816258d, y: 0.4484643821987331d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.204787523291308d, y: 0.6596114212340244d), new NpgsqlTypes.NpgsqlPoint(x: 0.035824424900354646d, y: 0.9458520316150517d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513321059578897d, y: 0.7465493151216525d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7532162737749968d, y: 0.03322193906959947d), new NpgsqlTypes.NpgsqlPoint(x: 0.2926122969576851d, y: 0.567931140223602d), new NpgsqlTypes.NpgsqlPoint(x: 0.35805446127137097d, y: 0.9842908315161424d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37083818241865585d, y: 0.8783538126840916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6446209520554738d, y: 0.128535082350821d), new NpgsqlTypes.NpgsqlPoint(x: 0.3932098593236988d, y: 0.482456030797499d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08309898707773922d, y: 0.9515738436587619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6903863821922301d, y: 0.9753375998094438d), new NpgsqlTypes.NpgsqlPoint(x: 0.26702075214210963d, y: 0.40461246934872064d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43404371199207425d, y: 0.9263495687485278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613260247157109d, y: 0.986880613954757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7166938164203531d, y: 0.8397644276973493d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6439301174299646d, y: 0.2855238320905735d), new NpgsqlTypes.NpgsqlPoint(x: 0.6108372515372058d, y: 0.1008414166274354d), new NpgsqlTypes.NpgsqlPoint(x: 0.30223064201091776d, y: 0.8307797356187623d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5993007799797367d, y: 0.35865527374929584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9713127597733325d, y: 0.3173419000288038d), new NpgsqlTypes.NpgsqlPoint(x: 0.4037345645192514d, y: 0.5887535191952565d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07180743384322597d, y: 0.8570885562717211d), new NpgsqlTypes.NpgsqlPoint(x: 0.07048376441887905d, y: 0.5257223902028421d), new NpgsqlTypes.NpgsqlPoint(x: 0.1141649713769679d, y: 0.10054797420657091d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7779427500055531d, y: 0.8519213573087605d), new NpgsqlTypes.NpgsqlPoint(x: 0.36779211571351034d, y: 0.2984306170687364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625920326935955d, y: 0.46692000936101774d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8523760388213721d, y: 0.8310256293814807d), new NpgsqlTypes.NpgsqlPoint(x: 0.1913593227837389d, y: 0.9828355217368894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155564803916309d, y: 0.26334859817951517d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01389517606304047d, y: 0.9941104685962519d), new NpgsqlTypes.NpgsqlPoint(x: 0.18337959600056197d, y: 0.7223771943283764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840315762954962d, y: 0.4431870241204242d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7258871708127806d, y: 0.08018315973070111d), new NpgsqlTypes.NpgsqlPoint(x: 0.6491905896805206d, y: 0.6255096503826911d), new NpgsqlTypes.NpgsqlPoint(x: 0.026439372540011052d, y: 0.5297696077672012d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1332767365983708d, y: 0.7800141947723136d), new NpgsqlTypes.NpgsqlPoint(x: 0.13033527712556714d, y: 0.7388727604291939d), new NpgsqlTypes.NpgsqlPoint(x: 0.04272904271930489d, y: 0.694561858227322d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32440319586634925d, y: 0.07562245322006256d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652964692671099d, y: 0.8265576412004481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863060427434209d, y: 0.5610501215079836d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.964399313263263d, y: 0.3074309676402194d), new NpgsqlTypes.NpgsqlPoint(x: 0.0645163390761695d, y: 0.9629680710089861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373458486139465d, y: 0.5209147943318558d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23089458815077457d, y: 0.6525793888039733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982745753161816d, y: 0.31150651763708537d), new NpgsqlTypes.NpgsqlPoint(x: 0.29056153167977994d, y: 0.4619559993579945d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2689259275797452d, y: 0.5638328606854107d), new NpgsqlTypes.NpgsqlPoint(x: 0.1324942757629619d, y: 0.17023545962314202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9205283802838454d, y: 0.30240776365976596d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5010921164381081d, y: 0.4255725914995936d), new NpgsqlTypes.NpgsqlPoint(x: 0.46719752418138627d, y: 0.854056012220021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5697996606981985d, y: 0.8265185631547468d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9571045013411708d, y: 0.27709426154565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6926540982678754d, y: 0.5788416935664908d), new NpgsqlTypes.NpgsqlPoint(x: 0.188440166979706d, y: 0.5442127571702784d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5802973892065446d, y: 0.37190407078057797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7430476055342091d, y: 0.98686867082274d), new NpgsqlTypes.NpgsqlPoint(x: 0.39155012687338797d, y: 0.8447483982248661d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20014674899095064d, y: 0.4932029083346321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9495163265756694d, y: 0.72816790917887d), new NpgsqlTypes.NpgsqlPoint(x: 0.5828872337549593d, y: 0.9996399064966964d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3748784401134009d, y: 0.5122790073464626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990033563261754d, y: 0.3410241988614029d), new NpgsqlTypes.NpgsqlPoint(x: 0.07537332100685024d, y: 0.5457760197420968d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10681506494470583d, y: 0.9725689944361635d), new NpgsqlTypes.NpgsqlPoint(x: 0.4269495204048144d, y: 0.35458499713957514d), new NpgsqlTypes.NpgsqlPoint(x: 0.578308591810503d, y: 0.738439170358532d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7953768358006339d, y: 0.7107872285841382d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667558255837275d, y: 0.0856735732697178d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867754988864386d, y: 0.4114059743983107d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3512928175162261d, y: 0.8595937323451385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6217131178899363d, y: 0.1520732474446338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911593252394536d, y: 0.06097329021187936d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06051507483902241d, y: 0.4462856348231352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6015624465235213d, y: 0.1230221701536316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5067864197732128d, y: 0.07133092667453744d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052973674486262445d, y: 0.6878576512626148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8704380286023917d, y: 0.34555418916789593d), new NpgsqlTypes.NpgsqlPoint(x: 0.880601196332347d, y: 0.4178533128332579d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8317086449290683d, y: 0.5257642329157313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694243428105566d, y: 0.23503471132645093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8650446131401209d, y: 0.8965028997151718d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8463719529944903d, y: 0.26254912617983517d), new NpgsqlTypes.NpgsqlPoint(x: 0.19206281572359363d, y: 0.8537530665584254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703907983853111d, y: 0.002708883957053154d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41894683945441424d, y: 0.7874688511896013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6212076832153475d, y: 0.4124038296917035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808678849983398d, y: 0.5205649018495017d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6520955640532664d, y: 0.9485344157666183d), new NpgsqlTypes.NpgsqlPoint(x: 0.45099150914503083d, y: 0.35234584751680964d), new NpgsqlTypes.NpgsqlPoint(x: 0.06858267238869242d, y: 0.059879095039456764d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5223904438962464d, y: 0.24593042782064245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903123155399649d, y: 0.763310063982896d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987673927808174d, y: 0.57318811215899d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6404264056952239d, y: 0.566644083058068d), new NpgsqlTypes.NpgsqlPoint(x: 0.022748072904794414d, y: 0.25410900883589704d), new NpgsqlTypes.NpgsqlPoint(x: 0.39262892128349103d, y: 0.5154528893773632d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1112193340434604d, y: 0.9153536192770526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594075600698965d, y: 0.9001287504792626d), new NpgsqlTypes.NpgsqlPoint(x: 0.27988835251032396d, y: 0.8980655766863485d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7341723643136894d, y: 0.2542414431328833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6559956946149068d, y: 0.330019025363525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8682384392012773d, y: 0.8805812372222849d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1435097236883266d, y: 0.9202002129313819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8719670551398017d, y: 0.26730952663258d), new NpgsqlTypes.NpgsqlPoint(x: 0.2131409925842669d, y: 0.19502802015496945d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9847839139670954d, y: 0.1755607669164867d), new NpgsqlTypes.NpgsqlPoint(x: 0.33642545799723567d, y: 0.6116881222610548d), new NpgsqlTypes.NpgsqlPoint(x: 0.19188178562912073d, y: 0.12685879949315038d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6715421103372265d, y: 0.10511847449681688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5684884260501692d, y: 0.32392275399301107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088581499173162d, y: 0.21163827757576104d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030044531311984035d, y: 0.8982099500971733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4707164700339851d, y: 0.49476507542040526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8435171164204308d, y: 0.016039085938481135d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7825416732286793d, y: 0.643997882369237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790620724001564d, y: 0.9277874827480656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6281352610881569d, y: 0.29504721157198377d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32701425961190556d, y: 0.3816612710835945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547795931499197d, y: 0.4615952414736183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9120707714347973d, y: 0.7005496640569678d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6355814570494966d, y: 0.9025396425409917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988185009750189d, y: 0.5503989743111902d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639605763716237d, y: 0.4069806901025361d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4419900740208563d, y: 0.8706303383873607d), new NpgsqlTypes.NpgsqlPoint(x: 0.79871294435637d, y: 0.03236657810088994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623370049300652d, y: 0.7579199987656583d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9018748675535956d, y: 0.04360306050618867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856324462676793d, y: 0.5314042330071121d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393202695460458d, y: 0.22417582832734095d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7172126837206421d, y: 0.15949915087366917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096989463435593d, y: 0.6092568717259366d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758599739884057d, y: 0.37666556073418855d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10727195069353523d, y: 0.005789950350466477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7910988328666216d, y: 0.4121660714727893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7615893436246596d, y: 0.4947412409907387d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8905828959501163d, y: 0.4609130299568429d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276591574600533d, y: 0.198354774922068d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842489202019185d, y: 0.5506178616552181d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4720407447258792d, y: 0.7188143781726866d), new NpgsqlTypes.NpgsqlPoint(x: 0.39054108543037847d, y: 0.8981531177524918d), new NpgsqlTypes.NpgsqlPoint(x: 0.3283188285979922d, y: 0.7492070727489369d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5282887497825962d, y: 0.26466626724949593d), new NpgsqlTypes.NpgsqlPoint(x: 0.38961952566965685d, y: 0.32362724466284754d), new NpgsqlTypes.NpgsqlPoint(x: 0.029203034908143577d, y: 0.2381390245389723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6222188007249492d, y: 0.30070116224488885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136070634093786d, y: 0.6732688118831047d), new NpgsqlTypes.NpgsqlPoint(x: 0.10733032322150449d, y: 0.9551736545478696d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04809377225090583d, y: 0.6994096162937152d), new NpgsqlTypes.NpgsqlPoint(x: 0.18324884224308347d, y: 0.9541990251810935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129712847939657d, y: 0.6501442239932261d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5086526629027138d, y: 0.37858616906298925d), new NpgsqlTypes.NpgsqlPoint(x: 0.2969921961847951d, y: 0.5212575220096551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303417237175949d, y: 0.31156752060422144d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.728124119244633d, y: 0.5517967152098684d), new NpgsqlTypes.NpgsqlPoint(x: 0.15865489977309577d, y: 0.6768753366364004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971044780818698d, y: 0.4607584260385319d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7457642118418737d, y: 0.3003036481508873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8684193879647906d, y: 0.9033280868681566d), new NpgsqlTypes.NpgsqlPoint(x: 0.2745966672265028d, y: 0.4871112378346776d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8946159386920037d, y: 0.8443160680029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139186423162667d, y: 0.8313765064431666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089532892306522d, y: 0.31110963125980906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03695749787567537d, y: 0.25212196659787034d), new NpgsqlTypes.NpgsqlPoint(x: 0.09066356266798792d, y: 0.5929147784769864d), new NpgsqlTypes.NpgsqlPoint(x: 0.47119003180294183d, y: 0.8223011481478705d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5589647468600872d, y: 0.9301136028616016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4907301688810862d, y: 0.5955000530340746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569695879093368d, y: 0.568191367333449d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4518704374672917d, y: 0.6988702374756819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121915667646031d, y: 0.26368699459949696d), new NpgsqlTypes.NpgsqlPoint(x: 0.23298355216979438d, y: 0.10722755763757397d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.057698775669493996d, y: 0.6098274998405626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637778553909185d, y: 0.267303882888522d), new NpgsqlTypes.NpgsqlPoint(x: 0.40866499646971044d, y: 0.5908258582154371d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9950452274340126d, y: 0.6595230850375312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4339412302445085d, y: 0.3683441677394128d), new NpgsqlTypes.NpgsqlPoint(x: 0.879828807434593d, y: 0.26673187809216004d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21269384373796885d, y: 0.03820661518970081d), new NpgsqlTypes.NpgsqlPoint(x: 0.5278167615457505d, y: 0.9027189946924361d), new NpgsqlTypes.NpgsqlPoint(x: 0.2313344689859087d, y: 0.8152160782989984d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34499997426132434d, y: 0.28188680146034695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9545405262718872d, y: 0.17660845227089805d), new NpgsqlTypes.NpgsqlPoint(x: 0.82106457478112d, y: 0.5696167741691974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9372787061551241d, y: 0.34592907364036296d), new NpgsqlTypes.NpgsqlPoint(x: 0.22534158970685358d, y: 0.27320977792370227d), new NpgsqlTypes.NpgsqlPoint(x: 0.49076352086106756d, y: 0.7476248115968814d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9024593252245144d, y: 0.3906159042819448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725027826325747d, y: 0.8249184055164722d), new NpgsqlTypes.NpgsqlPoint(x: 0.196352071764183d, y: 0.9815550340105468d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25717811050498296d, y: 0.9732871861314405d), new NpgsqlTypes.NpgsqlPoint(x: 0.20251517114781092d, y: 0.2950495523339639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611542499107018d, y: 0.3172734061299983d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6337544306246914d, y: 0.736759290693814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134857251937425d, y: 0.43573999450670475d), new NpgsqlTypes.NpgsqlPoint(x: 0.2839305850166466d, y: 0.6147219299445819d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014468602968381705d, y: 0.518511676787656d), new NpgsqlTypes.NpgsqlPoint(x: 0.07081560764404182d, y: 0.9101425199632525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6581838107133761d, y: 0.26651146851760465d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38044412774205516d, y: 0.18368221791712203d), new NpgsqlTypes.NpgsqlPoint(x: 0.6557097457673262d, y: 0.205902039974876d), new NpgsqlTypes.NpgsqlPoint(x: 0.327901996583266d, y: 0.1575876620567368d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06260022681185706d, y: 0.1563677699890783d), new NpgsqlTypes.NpgsqlPoint(x: 0.49074946485732585d, y: 0.6766042714901798d), new NpgsqlTypes.NpgsqlPoint(x: 0.3923489729345443d, y: 0.6260075849704299d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.040340333337737344d, y: 0.4723092869759271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4220172725632012d, y: 0.12686041160285688d), new NpgsqlTypes.NpgsqlPoint(x: 0.2695434900691396d, y: 0.1391519444939262d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3156044258192512d, y: 0.8796285456334363d), new NpgsqlTypes.NpgsqlPoint(x: 0.13507655170052235d, y: 0.8921111315001439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958991578452467d, y: 0.7076956166623519d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16999294233261686d, y: 0.3342542455849421d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396400774695589d, y: 0.19278974276790262d), new NpgsqlTypes.NpgsqlPoint(x: 0.08734079138576833d, y: 0.14600793516625177d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5593895082031036d, y: 0.49838360045601504d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066090591489342d, y: 0.8264663110723118d), new NpgsqlTypes.NpgsqlPoint(x: 0.08474199920439951d, y: 0.4076825431571617d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4726786452423345d, y: 0.7795432769250624d), new NpgsqlTypes.NpgsqlPoint(x: 0.41927650942848316d, y: 0.3946046608883247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493332916775034d, y: 0.5151825544263121d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8362898587765465d, y: 0.25237046516800665d), new NpgsqlTypes.NpgsqlPoint(x: 0.08228952468640471d, y: 0.6399179918952259d), new NpgsqlTypes.NpgsqlPoint(x: 0.18334611797050682d, y: 0.6423971080873401d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33084061740657933d, y: 0.4120178525176723d), new NpgsqlTypes.NpgsqlPoint(x: 0.021588443473400498d, y: 0.14191607317690003d), new NpgsqlTypes.NpgsqlPoint(x: 0.3548361909398673d, y: 0.4713181692889227d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3538584108644721d, y: 0.38743937298661246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904950184675272d, y: 0.5803131612622885d), new NpgsqlTypes.NpgsqlPoint(x: 0.26742621862157157d, y: 0.9799285196734856d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46102997747098806d, y: 0.8842129112199653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762356613885897d, y: 0.7398345899931522d), new NpgsqlTypes.NpgsqlPoint(x: 0.863649182303037d, y: 0.5262134297339107d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43220952524269984d, y: 0.7316534275829787d), new NpgsqlTypes.NpgsqlPoint(x: 0.44922541132082905d, y: 0.8643636086656584d), new NpgsqlTypes.NpgsqlPoint(x: 0.18228861959108256d, y: 0.5483637321025404d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13926671829887716d, y: 0.2616457726969835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626828990538533d, y: 0.4446835812219211d), new NpgsqlTypes.NpgsqlPoint(x: 0.23730061680034886d, y: 0.7401706592021929d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9545328321726603d, y: 0.8144252923386983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8849190746564625d, y: 0.6461021373955471d), new NpgsqlTypes.NpgsqlPoint(x: 0.15731834317449056d, y: 0.160521597147128d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8268692185161807d, y: 0.23602614871645478d), new NpgsqlTypes.NpgsqlPoint(x: 0.17605434928012265d, y: 0.2593093547321914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805792773310219d, y: 0.24614013056103623d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07806644937961349d, y: 0.15168032439916235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190812314956187d, y: 0.876832370660495d), new NpgsqlTypes.NpgsqlPoint(x: 0.14172235437605818d, y: 0.8344704879387974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4926777267095884d, y: 0.781988437466143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554793927706726d, y: 0.25318069023063794d), new NpgsqlTypes.NpgsqlPoint(x: 0.46870911684939287d, y: 0.5027809946935925d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9029874500698628d, y: 0.9757996125327343d), new NpgsqlTypes.NpgsqlPoint(x: 0.16517525499018437d, y: 0.6944289611469644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372403291434214d, y: 0.7337923538553226d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023619991722483635d, y: 0.8045919213852769d), new NpgsqlTypes.NpgsqlPoint(x: 0.29999079482033864d, y: 0.4786642164982249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227948646739535d, y: 0.39723984001765134d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5719679522883083d, y: 0.212654025772275d), new NpgsqlTypes.NpgsqlPoint(x: 0.32334959859359613d, y: 0.7350894382138082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023756233461497d, y: 0.7407128009292336d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3703784872514436d, y: 0.7159423928378776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665671162083214d, y: 0.588337989495316d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938063211618263d, y: 0.6695116893743183d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16839620276405076d, y: 0.2559823010514839d), new NpgsqlTypes.NpgsqlPoint(x: 0.5411071518863857d, y: 0.6669223700226985d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936283042234863d, y: 0.9022977397274691d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24083534553719643d, y: 0.20262282017079913d), new NpgsqlTypes.NpgsqlPoint(x: 0.30333838500952637d, y: 0.09285018550808766d), new NpgsqlTypes.NpgsqlPoint(x: 0.006366523981070182d, y: 0.9555693245996948d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6401260557988477d, y: 0.002360250387356322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747192941205743d, y: 0.8625382175748014d), new NpgsqlTypes.NpgsqlPoint(x: 0.41323839983608535d, y: 0.27613289438660926d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32875393032981426d, y: 0.972803739320965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286208021559407d, y: 0.7307641796763691d), new NpgsqlTypes.NpgsqlPoint(x: 0.10996359826705615d, y: 0.9499813328661897d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8621327196889071d, y: 0.4360790712495054d), new NpgsqlTypes.NpgsqlPoint(x: 0.43171586492214353d, y: 0.17059228824245753d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235730245902056d, y: 0.05321649833754116d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8876503204488716d, y: 0.9267871256725323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927705042910894d, y: 0.1406719182370778d), new NpgsqlTypes.NpgsqlPoint(x: 0.994017632951668d, y: 0.6707094214548992d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937160245173451d, y: 0.11343275600304992d), new NpgsqlTypes.NpgsqlPoint(x: 0.038595899669343514d, y: 0.6616271296545975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2396906832437029d, y: 0.8284307845228251d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3327722037235096d, y: 0.9872943775850807d), new NpgsqlTypes.NpgsqlPoint(x: 0.46692795689992805d, y: 0.5234702984484089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779917336588372d, y: 0.21135478250765438d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12307069576571283d, y: 0.4314458488201871d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645095187297647d, y: 0.39378681729140363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449061612156386d, y: 0.6130756721971456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8678276786741591d, y: 0.4855642859947811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616328824369661d, y: 0.8151418186520926d), new NpgsqlTypes.NpgsqlPoint(x: 0.39234456212333424d, y: 0.6385535032812925d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8437765284708221d, y: 0.9654418620060116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9149225280574901d, y: 0.7931843605091611d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390241698996592d, y: 0.7882448753879364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32998224771819284d, y: 0.3578512836678208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8320420768944587d, y: 0.6076901967095157d), new NpgsqlTypes.NpgsqlPoint(x: 0.48011172426505333d, y: 0.9128621539061177d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8795377226115126d, y: 0.7998662165765802d), new NpgsqlTypes.NpgsqlPoint(x: 0.16145583128628327d, y: 0.030882166383081167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686877790759253d, y: 0.9681495707081293d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.872080769849357d, y: 0.3825519360958183d), new NpgsqlTypes.NpgsqlPoint(x: 0.35179100109214256d, y: 0.7302526573906661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161995528184011d, y: 0.702219885481405d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.824604719030756d, y: 0.037303953677376156d), new NpgsqlTypes.NpgsqlPoint(x: 0.37068008192290136d, y: 0.8628648416739402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663177964994897d, y: 0.5192743850506787d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21705515821849386d, y: 0.4863654931037814d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853450108706647d, y: 0.7380183626207997d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025893384971599d, y: 0.035206728146196076d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8176044119121716d, y: 0.5915794789919745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491699429779834d, y: 0.5055952568250334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714282890410397d, y: 0.90124819723808d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8616923280061162d, y: 0.5594518747947858d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015451874505265d, y: 0.5304057927017172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848711755361832d, y: 0.10429756301309057d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19154147227318497d, y: 0.8649711788788689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2734711460166508d, y: 0.632326387999381d), new NpgsqlTypes.NpgsqlPoint(x: 0.27006683945186793d, y: 0.11869748352794196d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7185119617056133d, y: 0.053034037557595726d), new NpgsqlTypes.NpgsqlPoint(x: 0.16789394581694972d, y: 0.5914494858141561d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131715578700249d, y: 0.03900990361866863d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0802952037587169d, y: 0.8037048195074961d), new NpgsqlTypes.NpgsqlPoint(x: 0.387357118517635d, y: 0.649391752308692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267512386216388d, y: 0.03562377684693219d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4838861859559014d, y: 0.9703849842535516d), new NpgsqlTypes.NpgsqlPoint(x: 0.17136523566670392d, y: 0.7964840839891963d), new NpgsqlTypes.NpgsqlPoint(x: 0.3484796556518428d, y: 0.7541167812400432d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9908106679529266d, y: 0.9338081368303419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8137819154638819d, y: 0.9257360803514343d), new NpgsqlTypes.NpgsqlPoint(x: 0.1561624752551799d, y: 0.22689631762162865d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8651256255584606d, y: 0.7042668164473127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002470767046729d, y: 0.2320129273629169d), new NpgsqlTypes.NpgsqlPoint(x: 0.49384919380104364d, y: 0.8457760269831099d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4991951609978371d, y: 0.1756171916166297d), new NpgsqlTypes.NpgsqlPoint(x: 0.11614074386823259d, y: 0.054708869244857516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701889231018504d, y: 0.38750140326183236d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6896671924134504d, y: 0.567450535237275d), new NpgsqlTypes.NpgsqlPoint(x: 0.03448934810600168d, y: 0.5582205054081244d), new NpgsqlTypes.NpgsqlPoint(x: 0.49160645163251204d, y: 0.35180971301055575d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6283948419589047d, y: 0.5682700005876139d), new NpgsqlTypes.NpgsqlPoint(x: 0.3506033289688788d, y: 0.9020107739773068d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068495919469433d, y: 0.20216223499568897d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38533993366035124d, y: 0.6266568155659054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5928344297980935d, y: 0.5930616073922677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143417072461485d, y: 0.14863329035820638d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8047497388180836d, y: 0.36056614776616147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307631813088718d, y: 0.9580180860585594d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971778641612856d, y: 0.6320550041445546d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32006684667649077d, y: 0.055852795098647934d), new NpgsqlTypes.NpgsqlPoint(x: 0.43490101231096767d, y: 0.6323681292898101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874686411905515d, y: 0.3698555487357106d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16930816741513688d, y: 0.7643206383175167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9602208654021954d, y: 0.01818004351872715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5886874347773354d, y: 0.47512050470830836d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2431094457974725d, y: 0.8634988671112008d), new NpgsqlTypes.NpgsqlPoint(x: 0.36582763941711616d, y: 0.6146029034282555d), new NpgsqlTypes.NpgsqlPoint(x: 0.22738812477604864d, y: 0.3124264691314492d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01808397985875454d, y: 0.8145187776890703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310135127869612d, y: 0.145580887181197d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443209892158688d, y: 0.18802207362211554d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.829452386886397d, y: 0.33562644274271713d), new NpgsqlTypes.NpgsqlPoint(x: 0.07530628587550903d, y: 0.5448828216043133d), new NpgsqlTypes.NpgsqlPoint(x: 0.0958557754497481d, y: 0.1516746958339994d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31745769096024923d, y: 0.9185772003161768d), new NpgsqlTypes.NpgsqlPoint(x: 0.059742662980791006d, y: 0.5673428290050598d), new NpgsqlTypes.NpgsqlPoint(x: 0.05016549908834733d, y: 0.08798507637472486d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.765097092469898d, y: 0.46248006353183346d), new NpgsqlTypes.NpgsqlPoint(x: 0.41194713546353257d, y: 0.9464081052167435d), new NpgsqlTypes.NpgsqlPoint(x: 0.38109240342833084d, y: 0.2064200954701455d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9651606959812427d, y: 0.7639734757232084d), new NpgsqlTypes.NpgsqlPoint(x: 0.860406265932864d, y: 0.6653940238593414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231014499932605d, y: 0.1067421341591176d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6643777711594754d, y: 0.7420837400312845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9818349979441503d, y: 0.5654885073660231d), new NpgsqlTypes.NpgsqlPoint(x: 0.7207155696539309d, y: 0.32704549943578887d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.050481613461248576d, y: 0.04165529469034579d), new NpgsqlTypes.NpgsqlPoint(x: 0.32472981615439356d, y: 0.37203693096050683d), new NpgsqlTypes.NpgsqlPoint(x: 0.747604393891062d, y: 0.9821825942186877d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7293127626151669d, y: 0.8286996880837001d), new NpgsqlTypes.NpgsqlPoint(x: 0.25921958161382497d, y: 0.8555280443726933d), new NpgsqlTypes.NpgsqlPoint(x: 0.10897429285513072d, y: 0.2365605290629148d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6350056382024463d, y: 0.9144025435609098d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128524156414853d, y: 0.0771425191508689d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599176465804321d, y: 0.37217085647289294d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03186264731931132d, y: 0.5590009752099304d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856636131009809d, y: 0.6775832108845332d), new NpgsqlTypes.NpgsqlPoint(x: 0.45903688925045083d, y: 0.9361149052238483d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.441178828817268d, y: 0.5234354098751444d), new NpgsqlTypes.NpgsqlPoint(x: 0.19121618155165565d, y: 0.26584031111242445d), new NpgsqlTypes.NpgsqlPoint(x: 0.12548707821999872d, y: 0.48777549445419166d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3340782568318179d, y: 0.4065865615481117d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942693739244339d, y: 0.3813486167689255d), new NpgsqlTypes.NpgsqlPoint(x: 0.49424138311416577d, y: 0.6770435079798008d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9477188392927846d, y: 0.9004421694160298d), new NpgsqlTypes.NpgsqlPoint(x: 0.17401717543334116d, y: 0.6457021588894173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5361109225785008d, y: 0.37102337320249956d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22093003789537935d, y: 0.5018138529469773d), new NpgsqlTypes.NpgsqlPoint(x: 0.683611637642206d, y: 0.6363176853413599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6485770594330784d, y: 0.15008035665792596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24035690072290083d, y: 0.362670174684522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393606873534809d, y: 0.5275464313833421d), new NpgsqlTypes.NpgsqlPoint(x: 0.3358799655760386d, y: 0.8228108303490672d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19677444234391628d, y: 0.7475037988630426d), new NpgsqlTypes.NpgsqlPoint(x: 0.30365531112879063d, y: 0.9341612193173571d), new NpgsqlTypes.NpgsqlPoint(x: 0.47665966456612374d, y: 0.43262206831259487d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04245358442965197d, y: 0.01652270914266507d), new NpgsqlTypes.NpgsqlPoint(x: 0.8466039833589819d, y: 0.5554102063710047d), new NpgsqlTypes.NpgsqlPoint(x: 0.4668291187460357d, y: 0.6960531569417665d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47508411461227396d, y: 0.4175269440192584d), new NpgsqlTypes.NpgsqlPoint(x: 0.8684679980784787d, y: 0.7037851088596401d), new NpgsqlTypes.NpgsqlPoint(x: 0.2950398592347826d, y: 0.4915836515522862d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6684397756552181d, y: 0.5613637303784025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152291083280792d, y: 0.9389397527028615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780070745794414d, y: 0.10053488835191704d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9504704563238815d, y: 0.4059102355328933d), new NpgsqlTypes.NpgsqlPoint(x: 0.42790935767678384d, y: 0.8857672570191975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8579565798568156d, y: 0.7315583878310796d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6525552745868054d, y: 0.7520016486948757d), new NpgsqlTypes.NpgsqlPoint(x: 0.46372844973877303d, y: 0.632846359716443d), new NpgsqlTypes.NpgsqlPoint(x: 0.33533622651278217d, y: 0.24068883018989473d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8002307102596061d, y: 0.2494549913193499d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751410115740779d, y: 0.05146959702850451d), new NpgsqlTypes.NpgsqlPoint(x: 0.07462465248133832d, y: 0.1788864904696046d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7538655830330463d, y: 0.3809167433811601d), new NpgsqlTypes.NpgsqlPoint(x: 0.5637774246145959d, y: 0.13992562528551056d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598601896548974d, y: 0.5226043452454459d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7357231575457785d, y: 0.6018217732736749d), new NpgsqlTypes.NpgsqlPoint(x: 0.34772299910837656d, y: 0.5673326062276164d), new NpgsqlTypes.NpgsqlPoint(x: 0.023974639770001138d, y: 0.0907296388762523d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6520682166114997d, y: 0.019801478479022916d), new NpgsqlTypes.NpgsqlPoint(x: 0.12820414953642034d, y: 0.13389642079019282d), new NpgsqlTypes.NpgsqlPoint(x: 0.044791101823913326d, y: 0.8373748498089812d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2947358389293615d, y: 0.26121729812234695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523680759954348d, y: 0.5513435854695329d), new NpgsqlTypes.NpgsqlPoint(x: 0.22843744723257442d, y: 0.39101652897678796d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7002066667789337d, y: 0.8201186082940094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947391541341527d, y: 0.48378910629682403d), new NpgsqlTypes.NpgsqlPoint(x: 0.31018253308367294d, y: 0.6933040965428542d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6449183532676799d, y: 0.6201260536071328d), new NpgsqlTypes.NpgsqlPoint(x: 0.5189188487170268d, y: 0.3871631889114945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8870295648951179d, y: 0.06864800965618667d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7684528144248638d, y: 0.4978906231094601d), new NpgsqlTypes.NpgsqlPoint(x: 0.5129682603906444d, y: 0.9468495028448809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4169567383809757d, y: 0.9167057139564062d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6216483397023476d, y: 0.5923160294296165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345083403893462d, y: 0.44741847141990654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808950726779358d, y: 0.05959986802305406d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5574128374893821d, y: 0.683906159185457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5500571029852499d, y: 0.21538413044118354d), new NpgsqlTypes.NpgsqlPoint(x: 0.3734770134308998d, y: 0.07348901308559319d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4223332158053885d, y: 0.8394586962363292d), new NpgsqlTypes.NpgsqlPoint(x: 0.2758472392749417d, y: 0.2842802232479513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6700182155835077d, y: 0.5275678481602807d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6485660134523692d, y: 0.11201620740226081d), new NpgsqlTypes.NpgsqlPoint(x: 0.11941452394567886d, y: 0.48854303314124203d), new NpgsqlTypes.NpgsqlPoint(x: 0.2803368636107182d, y: 0.8717891839997278d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2016922361094201d, y: 0.1206995434761442d), new NpgsqlTypes.NpgsqlPoint(x: 0.37363422955239445d, y: 0.8021918961759865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675530506242607d, y: 0.6420597993094985d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07555463501814241d, y: 0.7643297736636921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7257265516223064d, y: 0.9824947109905909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9665177568512996d, y: 0.8529692286912273d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2773767984640333d, y: 0.7993937633458595d), new NpgsqlTypes.NpgsqlPoint(x: 0.19501615077842904d, y: 0.7304408774679546d), new NpgsqlTypes.NpgsqlPoint(x: 0.04765793800197193d, y: 0.0844682220309807d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.787998243793633d, y: 0.4744430240908972d), new NpgsqlTypes.NpgsqlPoint(x: 0.4497561879784383d, y: 0.24992474862335856d), new NpgsqlTypes.NpgsqlPoint(x: 0.437254485462393d, y: 0.5402814103872154d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43999674801607536d, y: 0.9816806617662939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6658682147760627d, y: 0.3647157386287303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7208055687265537d, y: 0.25985374771583736d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40811965344022494d, y: 0.29727728289209865d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002616896056677d, y: 0.5705415715398143d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335866771112513d, y: 0.9739083517647206d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027715995730277387d, y: 0.9877769661922337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6884900601101661d, y: 0.657037763829609d), new NpgsqlTypes.NpgsqlPoint(x: 0.4922373665383991d, y: 0.15734969702401147d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5033040450949398d, y: 0.2107179731178339d), new NpgsqlTypes.NpgsqlPoint(x: 0.42171905975836244d, y: 0.30053980649713263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867530753370606d, y: 0.13208321807934853d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42764559863537743d, y: 0.23246025707718754d), new NpgsqlTypes.NpgsqlPoint(x: 0.3486610734214136d, y: 0.650671931303776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9026420194460113d, y: 0.02085394380048755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46639977131729105d, y: 0.5378103613067955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173685172798415d, y: 0.9338143106773606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616875041507531d, y: 0.5692561146397935d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9964306014328167d, y: 0.7787445240535531d), new NpgsqlTypes.NpgsqlPoint(x: 0.48901047157305055d, y: 0.9009095982189583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4910344892006434d, y: 0.14509049065241386d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06682264314151798d, y: 0.5011148075410655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171357760816148d, y: 0.17587549717737516d), new NpgsqlTypes.NpgsqlPoint(x: 0.3018490061326917d, y: 0.9366303849772332d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6533051328336238d, y: 0.12375860134076744d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904606209307856d, y: 0.9885330968717471d), new NpgsqlTypes.NpgsqlPoint(x: 0.04195315933771815d, y: 0.5865501560437067d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.977057917967819d, y: 0.9745589483146218d), new NpgsqlTypes.NpgsqlPoint(x: 0.4084970840044658d, y: 0.5025014266746084d), new NpgsqlTypes.NpgsqlPoint(x: 0.0020704929155889173d, y: 0.504472031606763d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7946308870537678d, y: 0.5795125478673079d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437048029011129d, y: 0.7652413357364749d), new NpgsqlTypes.NpgsqlPoint(x: 0.34263134620014124d, y: 0.0642974666688163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5914573015953585d, y: 0.04700632138176175d), new NpgsqlTypes.NpgsqlPoint(x: 0.1382147313558657d, y: 0.006270382447694622d), new NpgsqlTypes.NpgsqlPoint(x: 0.39929468821705605d, y: 0.9791931777549655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.990930098257726d, y: 0.24236415354147456d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442069113365205d, y: 0.6343499480608537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304725268717013d, y: 0.14970280666765434d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6426316959673187d, y: 0.8989043123852902d), new NpgsqlTypes.NpgsqlPoint(x: 0.5916303905723003d, y: 0.44380540534896606d), new NpgsqlTypes.NpgsqlPoint(x: 0.7548975396777146d, y: 0.20149859118931235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5992269895765243d, y: 0.8035185754877896d), new NpgsqlTypes.NpgsqlPoint(x: 0.47195217894102215d, y: 0.07720624620070782d), new NpgsqlTypes.NpgsqlPoint(x: 0.14563684934983034d, y: 0.9758986862473168d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9995302433481759d, y: 0.9589009104785785d), new NpgsqlTypes.NpgsqlPoint(x: 0.40597184715896706d, y: 0.8248268018586002d), new NpgsqlTypes.NpgsqlPoint(x: 0.29095599386417315d, y: 0.5962903049826869d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6422194527264936d, y: 0.8366285869367314d), new NpgsqlTypes.NpgsqlPoint(x: 0.4535816631392897d, y: 0.8313808225748509d), new NpgsqlTypes.NpgsqlPoint(x: 0.6590293079592677d, y: 0.5973513792751298d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9553455814937374d, y: 0.6747092952280981d), new NpgsqlTypes.NpgsqlPoint(x: 0.14100438956644923d, y: 0.13185451893943512d), new NpgsqlTypes.NpgsqlPoint(x: 0.66129092971099d, y: 0.6529181127979388d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7116867599247169d, y: 0.6273127862228781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7453121331056234d, y: 0.31281592072679276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606301266900527d, y: 0.46158714848910176d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9245876962958501d, y: 0.9253427571167888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3482970241214426d, y: 0.7345465764397315d), new NpgsqlTypes.NpgsqlPoint(x: 0.4802114610234026d, y: 0.12039077507995632d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6071853370944102d, y: 0.7337935832712774d), new NpgsqlTypes.NpgsqlPoint(x: 0.317778310400165d, y: 0.934460632033178d), new NpgsqlTypes.NpgsqlPoint(x: 0.1049922001995871d, y: 0.18314135541624166d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811623680832951d, y: 0.7274289513581531d), new NpgsqlTypes.NpgsqlPoint(x: 0.08336780909952579d, y: 0.981003780603338d), new NpgsqlTypes.NpgsqlPoint(x: 0.27866684822492593d, y: 0.7242174657578314d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.827740189049863d, y: 0.22355688114292793d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570161457944546d, y: 0.8536982875993504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738628948210595d, y: 0.23548025501602587d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5944229990228559d, y: 0.5432208659122303d), new NpgsqlTypes.NpgsqlPoint(x: 0.17104298664363737d, y: 0.3531181587590342d), new NpgsqlTypes.NpgsqlPoint(x: 0.06180197302061852d, y: 0.5233479254069849d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4780293426240336d, y: 0.12703562779813216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7374339037788429d, y: 0.892166568776206d), new NpgsqlTypes.NpgsqlPoint(x: 0.42323640701192444d, y: 0.38827007235864697d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9752877068190399d, y: 0.25190644624975966d), new NpgsqlTypes.NpgsqlPoint(x: 0.769931876327571d, y: 0.3230435171911793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053876216994546d, y: 0.7239069870089498d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6087421044395218d, y: 0.40680563289744953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9775946886218825d, y: 0.7033661425283728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9960705288714742d, y: 0.5737273368490742d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6295296895538548d, y: 0.15262733406125328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9607361327842469d, y: 0.9067457521330761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458512806932171d, y: 0.30924095816805075d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8391222121407804d, y: 0.9171432088128157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465132884156846d, y: 0.5214402537721768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7917784279702483d, y: 0.7403583526753142d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5982978750676246d, y: 0.7084856890683557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4709900249289911d, y: 0.5763399761257961d), new NpgsqlTypes.NpgsqlPoint(x: 0.11870897924591639d, y: 0.1329437609102344d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6379566633991216d, y: 0.5369360582834594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583140881751065d, y: 0.15905441066291504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882319185608029d, y: 0.26247928998887216d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29319955541004294d, y: 0.5440240242799625d), new NpgsqlTypes.NpgsqlPoint(x: 0.11652943968429064d, y: 0.06819790949761118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6127932280192749d, y: 0.9739470659038617d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3643967122434618d, y: 0.8137427802874911d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554944553599272d, y: 0.20785755849062792d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004285922608572d, y: 0.8694580469856799d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6366408856307691d, y: 0.40176029193725227d), new NpgsqlTypes.NpgsqlPoint(x: 0.06428629510633754d, y: 0.10587269294483848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558110384027878d, y: 0.35522158997357456d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007586374280351693d, y: 0.5315460494799604d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581812424750968d, y: 0.7301897742002519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680456745361168d, y: 0.0038986363015250936d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5729391131987004d, y: 0.9584711603442612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7211523718481787d, y: 0.0026410103197016532d), new NpgsqlTypes.NpgsqlPoint(x: 0.053186516210351864d, y: 0.920436355772187d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1421371104071898d, y: 0.14082344617667997d), new NpgsqlTypes.NpgsqlPoint(x: 0.16322002765062316d, y: 0.9534807531206851d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235239335415924d, y: 0.7604456692044073d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3232838953509062d, y: 0.9721346566597983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593979397850009d, y: 0.3516835689114488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6283802368517373d, y: 0.7605338293823608d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5609432926865447d, y: 0.9127914496801027d), new NpgsqlTypes.NpgsqlPoint(x: 0.4241312338193568d, y: 0.8084796047254242d), new NpgsqlTypes.NpgsqlPoint(x: 0.025072535796623274d, y: 0.7812865785631398d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4217660575428346d, y: 0.7155148598894149d), new NpgsqlTypes.NpgsqlPoint(x: 0.2434823633488009d, y: 0.44209453413054045d), new NpgsqlTypes.NpgsqlPoint(x: 0.26547391234393747d, y: 0.5930378866888488d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.532381930765748d, y: 0.45841466608953896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409861473961269d, y: 0.6729660078219672d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808593446738153d, y: 0.7728718554093333d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08087105629093627d, y: 0.45175441737719235d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209837000653008d, y: 0.8220856088429043d), new NpgsqlTypes.NpgsqlPoint(x: 0.8293791716394223d, y: 0.08507943275213392d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8064202117479917d, y: 0.3028807253555176d), new NpgsqlTypes.NpgsqlPoint(x: 0.08365058353054877d, y: 0.24001110695503025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409817529006524d, y: 0.16695807229299753d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6205770227660735d, y: 0.9075685928521225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479778650651407d, y: 0.902801846164386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367446267201222d, y: 0.92263826261065d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.641833506692259d, y: 0.6153559339600204d), new NpgsqlTypes.NpgsqlPoint(x: 0.04806743220819654d, y: 0.43574745610762033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695766939549494d, y: 0.766161103929211d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7435501596756807d, y: 0.2203721209214411d), new NpgsqlTypes.NpgsqlPoint(x: 0.7921048015175909d, y: 0.8341124569760366d), new NpgsqlTypes.NpgsqlPoint(x: 0.503569581622091d, y: 0.7141406606607412d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23902269775418483d, y: 0.5030722091916153d), new NpgsqlTypes.NpgsqlPoint(x: 0.08720097682306849d, y: 0.2028285164209419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258442994336866d, y: 0.6938208365551488d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5565387594926267d, y: 0.4005985408967687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8946124787001776d, y: 0.7531584408460572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6992530063101178d, y: 0.7122998985840809d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5611773873682453d, y: 0.703158263982124d), new NpgsqlTypes.NpgsqlPoint(x: 0.022209619310535333d, y: 0.672326714778013d), new NpgsqlTypes.NpgsqlPoint(x: 0.843783979905724d, y: 0.25126365115006477d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6399024384922262d, y: 0.24563426568176372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3418427889037937d, y: 0.07257469343503409d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739112002595602d, y: 0.38826644575127456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8131122527517064d, y: 0.7683336792365157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4819935544004641d, y: 0.39831547965167236d), new NpgsqlTypes.NpgsqlPoint(x: 0.0007366880571754164d, y: 0.21303067088614924d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7450114358159167d, y: 0.7519716243427084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764006030394957d, y: 0.8963223004464973d), new NpgsqlTypes.NpgsqlPoint(x: 0.38327853604621853d, y: 0.19696226082280466d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2872006733122353d, y: 0.13243563908289913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573524110500278d, y: 0.3526494353479893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430316382048512d, y: 0.845981541220268d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3422399350837452d, y: 0.27341982126641406d), new NpgsqlTypes.NpgsqlPoint(x: 0.742370805275326d, y: 0.8280993188783435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409091620176211d, y: 0.2322445603082851d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5175094511468669d, y: 0.2808168088827161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9790486396912341d, y: 0.9992568660989019d), new NpgsqlTypes.NpgsqlPoint(x: 0.6804878506688345d, y: 0.312541296916537d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45172820129002766d, y: 0.813546402322603d), new NpgsqlTypes.NpgsqlPoint(x: 0.028920728065166434d, y: 0.994289077880125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4089686985729526d, y: 0.11289516827097479d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7152063293341433d, y: 0.8285730768151645d), new NpgsqlTypes.NpgsqlPoint(x: 0.2665601192063233d, y: 0.3236258050792544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9471496707223196d, y: 0.07288548650588611d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42248573202509365d, y: 0.09014081597744883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183897373733448d, y: 0.834198696002393d), new NpgsqlTypes.NpgsqlPoint(x: 0.690225141047655d, y: 0.3792618923206055d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6021258802549206d, y: 0.36412986981450624d), new NpgsqlTypes.NpgsqlPoint(x: 0.06528682972351207d, y: 0.18162324491805237d), new NpgsqlTypes.NpgsqlPoint(x: 0.07770724785364869d, y: 0.9043206480324878d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08278570427345966d, y: 0.8240138770648994d), new NpgsqlTypes.NpgsqlPoint(x: 0.15489389680796617d, y: 0.6357984419542815d), new NpgsqlTypes.NpgsqlPoint(x: 0.4000004729853396d, y: 0.7189345578676217d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49454869584145345d, y: 0.8353721636955448d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020119348270419d, y: 0.143105323792591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020672469290958d, y: 0.15830210113867027d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7343459291856409d, y: 0.4878999540548513d), new NpgsqlTypes.NpgsqlPoint(x: 0.7889918131992353d, y: 0.1890704167915752d), new NpgsqlTypes.NpgsqlPoint(x: 0.794722710414235d, y: 0.38907543787835097d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19324380504758998d, y: 0.12948939689784222d), new NpgsqlTypes.NpgsqlPoint(x: 0.013323482870279735d, y: 0.31966624306710933d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248839706872713d, y: 0.9588994504250158d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7769533962066895d, y: 0.296953026721424d), new NpgsqlTypes.NpgsqlPoint(x: 0.2225292869017833d, y: 0.9717206271636527d), new NpgsqlTypes.NpgsqlPoint(x: 0.14831264161084678d, y: 0.18636917188288082d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8742414452850024d, y: 0.6623797605034413d), new NpgsqlTypes.NpgsqlPoint(x: 0.535798338440671d, y: 0.8158083970475961d), new NpgsqlTypes.NpgsqlPoint(x: 0.6235228918330535d, y: 0.7500192799871093d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23100330796861546d, y: 0.012751406583622171d), new NpgsqlTypes.NpgsqlPoint(x: 0.44910306416456003d, y: 0.9222822513218242d), new NpgsqlTypes.NpgsqlPoint(x: 0.14243547807983648d, y: 0.23188324050399511d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5682722465057637d, y: 0.5484299368884977d), new NpgsqlTypes.NpgsqlPoint(x: 0.713165028812487d, y: 0.3088584222921802d), new NpgsqlTypes.NpgsqlPoint(x: 0.5348481251010644d, y: 0.5464139866385996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7975644858277543d, y: 0.06474731360674912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6823601892537147d, y: 0.8358440302171789d), new NpgsqlTypes.NpgsqlPoint(x: 0.9853227194224217d, y: 0.5530451482489617d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9082852645197035d, y: 0.9852564534590856d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500099849130994d, y: 0.38947048692257047d), new NpgsqlTypes.NpgsqlPoint(x: 0.25488283552021684d, y: 0.5800255137011558d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34769341322367764d, y: 0.4977265913892158d), new NpgsqlTypes.NpgsqlPoint(x: 0.758053453460214d, y: 0.4340096800285429d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757430105416064d, y: 0.30520106536596614d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9647878250786304d, y: 0.6819664880932058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110755786984662d, y: 0.14565275595284943d), new NpgsqlTypes.NpgsqlPoint(x: 0.728369039500402d, y: 0.15201712111899002d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7333338983099263d, y: 0.4823319800832496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8763445708066667d, y: 0.1565805618483258d), new NpgsqlTypes.NpgsqlPoint(x: 0.44166981320569254d, y: 0.4458614032581225d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10163387901085508d, y: 0.4318933542977391d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092841616295898d, y: 0.3580463175702874d), new NpgsqlTypes.NpgsqlPoint(x: 0.6726778243060779d, y: 0.12337317298774353d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3577582937572866d, y: 0.32648883710296284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459287190347485d, y: 0.03404861829788686d), new NpgsqlTypes.NpgsqlPoint(x: 0.03842878995890053d, y: 0.6957741121030877d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37391151398151523d, y: 0.8870362854173401d), new NpgsqlTypes.NpgsqlPoint(x: 0.3016172050565893d, y: 0.5933403062735829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846128105877836d, y: 0.4865600559460169d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14083591771957493d, y: 0.5426867258954422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7548919093885208d, y: 0.07320601113560221d), new NpgsqlTypes.NpgsqlPoint(x: 0.24364967195151344d, y: 0.644078883903853d)),
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32701425961190556d, y: 0.3816612710835945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547795931499197d, y: 0.4615952414736183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9120707714347973d, y: 0.7005496640569678d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6355814570494966d, y: 0.9025396425409917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988185009750189d, y: 0.5503989743111902d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639605763716237d, y: 0.4069806901025361d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4419900740208563d, y: 0.8706303383873607d), new NpgsqlTypes.NpgsqlPoint(x: 0.79871294435637d, y: 0.03236657810088994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623370049300652d, y: 0.7579199987656583d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9018748675535956d, y: 0.04360306050618867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856324462676793d, y: 0.5314042330071121d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393202695460458d, y: 0.22417582832734095d)),
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34499997426132434d, y: 0.28188680146034695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9545405262718872d, y: 0.17660845227089805d), new NpgsqlTypes.NpgsqlPoint(x: 0.82106457478112d, y: 0.5696167741691974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9372787061551241d, y: 0.34592907364036296d), new NpgsqlTypes.NpgsqlPoint(x: 0.22534158970685358d, y: 0.27320977792370227d), new NpgsqlTypes.NpgsqlPoint(x: 0.49076352086106756d, y: 0.7476248115968814d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9024593252245144d, y: 0.3906159042819448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725027826325747d, y: 0.8249184055164722d), new NpgsqlTypes.NpgsqlPoint(x: 0.196352071764183d, y: 0.9815550340105468d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25717811050498296d, y: 0.9732871861314405d), new NpgsqlTypes.NpgsqlPoint(x: 0.20251517114781092d, y: 0.2950495523339639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611542499107018d, y: 0.3172734061299983d)),
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
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.040340333337737344d, y: 0.4723092869759271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4220172725632012d, y: 0.12686041160285688d), new NpgsqlTypes.NpgsqlPoint(x: 0.2695434900691396d, y: 0.1391519444939262d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3156044258192512d, y: 0.8796285456334363d), new NpgsqlTypes.NpgsqlPoint(x: 0.13507655170052235d, y: 0.8921111315001439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958991578452467d, y: 0.7076956166623519d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16999294233261686d, y: 0.3342542455849421d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396400774695589d, y: 0.19278974276790262d), new NpgsqlTypes.NpgsqlPoint(x: 0.08734079138576833d, y: 0.14600793516625177d)),
}));
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43220952524269984d, y: 0.7316534275829787d), new NpgsqlTypes.NpgsqlPoint(x: 0.44922541132082905d, y: 0.8643636086656584d), new NpgsqlTypes.NpgsqlPoint(x: 0.18228861959108256d, y: 0.5483637321025404d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13926671829887716d, y: 0.2616457726969835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626828990538533d, y: 0.4446835812219211d), new NpgsqlTypes.NpgsqlPoint(x: 0.23730061680034886d, y: 0.7401706592021929d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9545328321726603d, y: 0.8144252923386983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8849190746564625d, y: 0.6461021373955471d), new NpgsqlTypes.NpgsqlPoint(x: 0.15731834317449056d, y: 0.160521597147128d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8268692185161807d, y: 0.23602614871645478d), new NpgsqlTypes.NpgsqlPoint(x: 0.17605434928012265d, y: 0.2593093547321914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805792773310219d, y: 0.24614013056103623d)),
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
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023619991722483635d, y: 0.8045919213852769d), new NpgsqlTypes.NpgsqlPoint(x: 0.29999079482033864d, y: 0.4786642164982249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227948646739535d, y: 0.39723984001765134d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5719679522883083d, y: 0.212654025772275d), new NpgsqlTypes.NpgsqlPoint(x: 0.32334959859359613d, y: 0.7350894382138082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023756233461497d, y: 0.7407128009292336d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3703784872514436d, y: 0.7159423928378776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665671162083214d, y: 0.588337989495316d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938063211618263d, y: 0.6695116893743183d)),
}));
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 107, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 40, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
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
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 54, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatch(connection, 12, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[2], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[3], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[4], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[29], false);
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
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

