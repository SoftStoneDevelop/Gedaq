

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
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20247671320682215d, b: 0.004349660914402365d, c: 0.22911083942071342d),
new NpgsqlTypes.NpgsqlLine(a: 0.7917851331821406d, b: 0.7698796833266227d, c: 0.6456254847101806d),
new NpgsqlTypes.NpgsqlLine(a: 0.811120067315194d, b: 0.7690112226895987d, c: 0.7341165359775372d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2364806433608897d, b: 0.3251554267082182d, c: 0.490061720911644d),
new NpgsqlTypes.NpgsqlLine(a: 0.7795285327882794d, b: 0.4182842780675792d, c: 0.45744292286620203d),
new NpgsqlTypes.NpgsqlLine(a: 0.8921914752449555d, b: 0.9018144451781157d, c: 0.1628998562705326d),
new NpgsqlTypes.NpgsqlLine(a: 0.5502277849793568d, b: 0.8078936080690966d, c: 0.25588788077475233d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8027431018012063d, b: 0.62874995688918d, c: 0.07255295550328367d),
new NpgsqlTypes.NpgsqlLine(a: 0.5910512766996958d, b: 0.7648355686050384d, c: 0.5857625257366318d),
new NpgsqlTypes.NpgsqlLine(a: 0.2205581309767326d, b: 0.3867700605709963d, c: 0.8858395432101782d),
new NpgsqlTypes.NpgsqlLine(a: 0.006824987604847288d, b: 0.726586359902105d, c: 0.13532079377895911d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9964547612413676d, b: 0.7665980574077731d, c: 0.018843655015579497d),
new NpgsqlTypes.NpgsqlLine(a: 0.9531404721573609d, b: 0.3505845298517962d, c: 0.6562286963203441d),
new NpgsqlTypes.NpgsqlLine(a: 0.5770418541580253d, b: 0.36907188561611926d, c: 0.27478637446432563d),
new NpgsqlTypes.NpgsqlLine(a: 0.46546539626081374d, b: 0.8500423374812974d, c: 0.27790635994856017d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5103828970622644d, b: 0.5391835840700188d, c: 0.2832723910964495d),
new NpgsqlTypes.NpgsqlLine(a: 0.5942802509431846d, b: 0.7517954774653758d, c: 0.25444576003297503d),
new NpgsqlTypes.NpgsqlLine(a: 0.29270247994642007d, b: 0.8943920212921761d, c: 0.9896502250458361d),
new NpgsqlTypes.NpgsqlLine(a: 0.28005431891302235d, b: 0.6518477075353564d, c: 0.10803941408673268d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25227296148496603d, b: 0.8056411092828346d, c: 0.003243708483727792d),
new NpgsqlTypes.NpgsqlLine(a: 0.055147811533883595d, b: 0.7326586957648814d, c: 0.6411384351927379d),
new NpgsqlTypes.NpgsqlLine(a: 0.5526919001100931d, b: 0.0013754302806341379d, c: 0.04918752383761649d),
new NpgsqlTypes.NpgsqlLine(a: 0.6671648228730309d, b: 0.2643745190509237d, c: 0.8750688691127003d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2475694338443799d, b: 0.7602863100532554d, c: 0.1355614196185183d),
new NpgsqlTypes.NpgsqlLine(a: 0.4069749543804727d, b: 0.9130951916408097d, c: 0.5384785984198739d),
new NpgsqlTypes.NpgsqlLine(a: 0.05634504707065868d, b: 0.9908591570036348d, c: 0.18274758555415682d),
new NpgsqlTypes.NpgsqlLine(a: 0.5416990364014703d, b: 0.26965343569359146d, c: 0.8295129418586176d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.44734112922941416d, b: 0.5262788672603296d, c: 0.5781471173618352d),
new NpgsqlTypes.NpgsqlLine(a: 0.8084905845444079d, b: 0.012750059401966607d, c: 0.21606562251152617d),
new NpgsqlTypes.NpgsqlLine(a: 0.9947123696947204d, b: 0.8852907959133688d, c: 0.7115450176934994d),
new NpgsqlTypes.NpgsqlLine(a: 0.6815603249777914d, b: 0.7181039395919954d, c: 0.5053975374426394d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23353467764619795d, b: 0.6741998017595535d, c: 0.5465606601578378d),
new NpgsqlTypes.NpgsqlLine(a: 0.9828465555553166d, b: 0.5128523805195437d, c: 0.7586827516211478d),
new NpgsqlTypes.NpgsqlLine(a: 0.210354648311172d, b: 0.06138187015214902d, c: 0.666404510100759d),
new NpgsqlTypes.NpgsqlLine(a: 0.19414053077390026d, b: 0.7504640885492861d, c: 0.9620950651785335d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.013585324565353551d, b: 0.38528179319113676d, c: 0.7338579312849379d),
new NpgsqlTypes.NpgsqlLine(a: 0.7170658670371178d, b: 0.3214986036112296d, c: 0.6663997621108108d),
new NpgsqlTypes.NpgsqlLine(a: 0.6097059949861173d, b: 0.025764117688505395d, c: 0.8831085106545545d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2485361040715065d, b: 0.17608244679476137d, c: 0.43468466135251893d),
new NpgsqlTypes.NpgsqlLine(a: 0.7250127978752479d, b: 0.6909065641643224d, c: 0.760592671482867d),
new NpgsqlTypes.NpgsqlLine(a: 0.5046276097435967d, b: 0.561855235928728d, c: 0.5077254446153728d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9308545946378358d, b: 0.8441884762684506d, c: 0.55444067327685d),
new NpgsqlTypes.NpgsqlLine(a: 0.9078860432072678d, b: 0.9751356481159934d, c: 0.41267063592810316d),
new NpgsqlTypes.NpgsqlLine(a: 0.2571767222997884d, b: 0.7898547032065354d, c: 0.47155015402515565d),
new NpgsqlTypes.NpgsqlLine(a: 0.742437737457917d, b: 0.97074557142383d, c: 0.38589220354582787d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5341944272129366d, b: 0.10639295589873499d, c: 0.5685953875632157d),
new NpgsqlTypes.NpgsqlLine(a: 0.1955565711920365d, b: 0.6945086114895243d, c: 0.43544493270183815d),
new NpgsqlTypes.NpgsqlLine(a: 0.8997780487405446d, b: 0.5961886619832719d, c: 0.8984194431191573d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6974644274345746d, b: 0.3037577377915104d, c: 0.36780157779036426d),
new NpgsqlTypes.NpgsqlLine(a: 0.7540507364128967d, b: 0.7921381478652301d, c: 0.23994138612749327d),
new NpgsqlTypes.NpgsqlLine(a: 0.9452865371228564d, b: 0.02345116394400626d, c: 0.2038399098851068d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2372338835310488d, b: 0.685536689353043d, c: 0.5150728461876207d),
new NpgsqlTypes.NpgsqlLine(a: 0.8506954212499824d, b: 0.5813018550184591d, c: 0.6331048718816823d),
new NpgsqlTypes.NpgsqlLine(a: 0.6538191621346199d, b: 0.44733180392198624d, c: 0.7969204477126286d),
new NpgsqlTypes.NpgsqlLine(a: 0.3779102146551091d, b: 0.9451454111885482d, c: 0.6133379032126417d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.35211940616688786d, b: 0.3999712996842715d, c: 0.5430174829073102d),
new NpgsqlTypes.NpgsqlLine(a: 0.9118368873559439d, b: 0.23472689239554567d, c: 0.6334956457274067d),
new NpgsqlTypes.NpgsqlLine(a: 0.676693519425966d, b: 0.9114689739024356d, c: 0.8245617313631513d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9108076151793423d, b: 0.13847786303291154d, c: 0.883985309951422d),
new NpgsqlTypes.NpgsqlLine(a: 0.15127648012572814d, b: 0.39775875537551664d, c: 0.3390301792092063d),
new NpgsqlTypes.NpgsqlLine(a: 0.764580446302322d, b: 0.33611515162438865d, c: 0.2962475412385558d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09941023121708248d, b: 0.7240239813057089d, c: 0.5572968517729582d),
new NpgsqlTypes.NpgsqlLine(a: 0.16863910634901302d, b: 0.613880546247417d, c: 0.10381558366235932d),
new NpgsqlTypes.NpgsqlLine(a: 0.08662185149650314d, b: 0.06395516051869865d, c: 0.15249574579089398d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.37186741087161523d, b: 0.17153362620272294d, c: 0.5694141893793894d),
new NpgsqlTypes.NpgsqlLine(a: 0.013705625416543299d, b: 0.7728854566296044d, c: 0.08287303548883296d),
new NpgsqlTypes.NpgsqlLine(a: 0.4715128109757759d, b: 0.1004932990309988d, c: 0.37717315332371737d),
new NpgsqlTypes.NpgsqlLine(a: 0.006197318621057546d, b: 0.4858419517359053d, c: 0.8622830305677465d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24254257244162025d, b: 0.2966427057762987d, c: 0.2982096087526295d),
new NpgsqlTypes.NpgsqlLine(a: 0.5803945866916193d, b: 0.4495689515890249d, c: 0.3064699704485786d),
new NpgsqlTypes.NpgsqlLine(a: 0.5600584821181126d, b: 0.6690592367214333d, c: 0.05513135076580744d),
new NpgsqlTypes.NpgsqlLine(a: 0.3214994697153174d, b: 0.6394609665788369d, c: 0.27177383686965595d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39739689084606145d, b: 0.4273571243514075d, c: 0.9659830431618442d),
new NpgsqlTypes.NpgsqlLine(a: 0.32085746275633986d, b: 0.03820983904932218d, c: 0.9588153991450128d),
new NpgsqlTypes.NpgsqlLine(a: 0.5845105851339589d, b: 0.9527799953593115d, c: 0.8504684002858568d),
new NpgsqlTypes.NpgsqlLine(a: 0.6795416375479328d, b: 0.2179731059421135d, c: 0.5722974648037521d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.812027783461543d, b: 0.012453626291318631d, c: 0.9968544630977921d),
new NpgsqlTypes.NpgsqlLine(a: 0.5509289828165331d, b: 0.6364331798977584d, c: 0.45960330848089714d),
new NpgsqlTypes.NpgsqlLine(a: 0.010867102703341902d, b: 0.28713736228137376d, c: 0.22984715433431047d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7902717566683057d, b: 0.104414386689475d, c: 0.7976745263571089d),
new NpgsqlTypes.NpgsqlLine(a: 0.4720378740641694d, b: 0.8815131472418672d, c: 0.9664885669910976d),
new NpgsqlTypes.NpgsqlLine(a: 0.2246490696575797d, b: 0.976276453700589d, c: 0.13801552072909706d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.017675021783817635d, b: 0.4771120679755525d, c: 0.6018315134603345d),
new NpgsqlTypes.NpgsqlLine(a: 0.6993556864603939d, b: 0.7682386612064931d, c: 0.452752822265274d),
new NpgsqlTypes.NpgsqlLine(a: 0.19340856999383926d, b: 0.3010331859315474d, c: 0.38714445536995523d),
new NpgsqlTypes.NpgsqlLine(a: 0.9941381674173754d, b: 0.9818016437383981d, c: 0.340465597907872d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5271517399744303d, b: 0.7041979854114705d, c: 0.7247266082834524d),
new NpgsqlTypes.NpgsqlLine(a: 0.6456714606810835d, b: 0.23209417882869054d, c: 0.01461370982158805d),
new NpgsqlTypes.NpgsqlLine(a: 0.29412165721413d, b: 0.35617623282809185d, c: 0.01829873060785059d),
new NpgsqlTypes.NpgsqlLine(a: 0.7966885676012851d, b: 0.32645988924555125d, c: 0.24002736858388873d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25433298931822346d, b: 0.40311922995352656d, c: 0.9955582999037433d),
new NpgsqlTypes.NpgsqlLine(a: 0.065533690616972d, b: 0.2774266503031154d, c: 0.22365661041719975d),
new NpgsqlTypes.NpgsqlLine(a: 0.8914957693687773d, b: 0.6109999459103408d, c: 0.7536916973701073d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6756276373454629d, b: 0.8145944603468143d, c: 0.8463611293181433d),
new NpgsqlTypes.NpgsqlLine(a: 0.4169383916656547d, b: 0.6417259427092237d, c: 0.06927738893557267d),
new NpgsqlTypes.NpgsqlLine(a: 0.020687788198463508d, b: 0.3887737971242392d, c: 0.8761363654332913d),
new NpgsqlTypes.NpgsqlLine(a: 0.6169394223416197d, b: 0.4903808935614584d, c: 0.25733461888853415d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6294678565619173d, b: 0.6951829400712053d, c: 0.5752330644945403d),
new NpgsqlTypes.NpgsqlLine(a: 0.18685275674645108d, b: 0.5430751219720565d, c: 0.5584832038627152d),
new NpgsqlTypes.NpgsqlLine(a: 0.773844724695678d, b: 0.873237746623439d, c: 0.3256025465343181d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5428448997519535d, b: 0.8907897192570888d, c: 0.6049375754239139d),
new NpgsqlTypes.NpgsqlLine(a: 0.3624962745357826d, b: 0.21373001591526086d, c: 0.9869410436367897d),
new NpgsqlTypes.NpgsqlLine(a: 0.5239371653080264d, b: 0.17375973400396216d, c: 0.5188483611031547d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.796382189933765d, b: 0.8916303541429904d, c: 0.23256312494157527d),
new NpgsqlTypes.NpgsqlLine(a: 0.03400025754210845d, b: 0.14738222576811288d, c: 0.383943474141464d),
new NpgsqlTypes.NpgsqlLine(a: 0.5513462922423764d, b: 0.8963824607136461d, c: 0.17396237484261445d),
new NpgsqlTypes.NpgsqlLine(a: 0.7985697773622421d, b: 0.548373323576845d, c: 0.6546093984116974d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41160928842838185d, b: 0.991099309167026d, c: 0.13039867307733233d),
new NpgsqlTypes.NpgsqlLine(a: 0.15679388309345244d, b: 0.6946266605863232d, c: 0.15892444290596963d),
new NpgsqlTypes.NpgsqlLine(a: 0.9241318245081388d, b: 0.5442565332309499d, c: 0.09368659245720512d),
new NpgsqlTypes.NpgsqlLine(a: 0.9375507621650632d, b: 0.8587037552847677d, c: 0.8384310449633571d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22257230151586604d, b: 0.6184101432300704d, c: 0.41809421293213966d),
new NpgsqlTypes.NpgsqlLine(a: 0.722687956537992d, b: 0.15279341236035626d, c: 0.8107790070190255d),
new NpgsqlTypes.NpgsqlLine(a: 0.34102691191454837d, b: 0.8403367283083383d, c: 0.563597878479848d),
new NpgsqlTypes.NpgsqlLine(a: 0.5039258156138661d, b: 0.5821315644185139d, c: 0.47890168812022504d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7348130690243595d, b: 0.46438124701016537d, c: 0.10924934904097161d),
new NpgsqlTypes.NpgsqlLine(a: 0.02867980218383026d, b: 0.06179189959411202d, c: 0.6895050443524893d),
new NpgsqlTypes.NpgsqlLine(a: 0.5647902173180812d, b: 0.712058994925735d, c: 0.8845250218783609d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2124727950901235d, b: 0.5598665276232669d, c: 0.6966551547216344d),
new NpgsqlTypes.NpgsqlLine(a: 0.4530732700124597d, b: 0.5685525767299634d, c: 0.35833596531616174d),
new NpgsqlTypes.NpgsqlLine(a: 0.5544659882498753d, b: 0.43404434803833514d, c: 0.8110534664656459d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22408765583417656d, b: 0.03423655313279195d, c: 0.11301878357332795d),
new NpgsqlTypes.NpgsqlLine(a: 0.9915645077968777d, b: 0.2589936758040209d, c: 0.08891999242355686d),
new NpgsqlTypes.NpgsqlLine(a: 0.968058173763598d, b: 0.49529438193993525d, c: 0.8814302471630695d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3198543356200503d, b: 0.5931389014420992d, c: 0.5039773083257527d),
new NpgsqlTypes.NpgsqlLine(a: 0.4997739638168728d, b: 0.8058393958354915d, c: 0.22945726584641224d),
new NpgsqlTypes.NpgsqlLine(a: 0.336205596998275d, b: 0.2159914830263655d, c: 0.1826484310643227d),
new NpgsqlTypes.NpgsqlLine(a: 0.340509276049453d, b: 0.9499833383785595d, c: 0.07265125274913109d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8641598581399598d, b: 0.8414311676526971d, c: 0.9211505794376508d),
new NpgsqlTypes.NpgsqlLine(a: 0.6298177793098664d, b: 0.4939541420834648d, c: 0.273835854350321d),
new NpgsqlTypes.NpgsqlLine(a: 0.4651209338038359d, b: 0.1922355712476045d, c: 0.6553455592605649d),
new NpgsqlTypes.NpgsqlLine(a: 0.7812123330361848d, b: 0.8719709652351069d, c: 0.8982797430545637d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9348455039910046d, b: 0.2591232457582867d, c: 0.33142571390178655d),
new NpgsqlTypes.NpgsqlLine(a: 0.6664315821315723d, b: 0.7161992919471538d, c: 0.2861004240485233d),
new NpgsqlTypes.NpgsqlLine(a: 0.5201143510075097d, b: 0.2699994136294125d, c: 0.6267872814266406d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16836539375300097d, b: 0.39224499533828583d, c: 0.03288287594341344d),
new NpgsqlTypes.NpgsqlLine(a: 0.1886063189214937d, b: 0.9131033938794259d, c: 0.11357453274121931d),
new NpgsqlTypes.NpgsqlLine(a: 0.9941291377393789d, b: 0.583362624217962d, c: 0.36120325765550687d),
new NpgsqlTypes.NpgsqlLine(a: 0.556838784899728d, b: 0.22890008808248163d, c: 0.02707029756237256d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21126127427425445d, b: 0.36911721518347007d, c: 0.768743710853526d),
new NpgsqlTypes.NpgsqlLine(a: 0.26652625900758664d, b: 0.5127182770639327d, c: 0.5657162257424404d),
new NpgsqlTypes.NpgsqlLine(a: 0.5052235960576034d, b: 0.6873164970520717d, c: 0.7148700227892226d),
new NpgsqlTypes.NpgsqlLine(a: 0.9296658167947234d, b: 0.33273781240959d, c: 0.6607671179598871d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05759163069750961d, b: 0.5493572539792352d, c: 0.7379198381109207d),
new NpgsqlTypes.NpgsqlLine(a: 0.9363352159846221d, b: 0.41271392023488174d, c: 0.3632664363749549d),
new NpgsqlTypes.NpgsqlLine(a: 0.015767318401715857d, b: 0.016971402965394455d, c: 0.057863591668428915d),
new NpgsqlTypes.NpgsqlLine(a: 0.41633666480659937d, b: 0.6845382102188303d, c: 0.3130616383458239d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8456812851212775d, b: 0.8844750164160784d, c: 0.6248420347243938d),
new NpgsqlTypes.NpgsqlLine(a: 0.122392969425414d, b: 0.18988816768693395d, c: 0.4532764438814859d),
new NpgsqlTypes.NpgsqlLine(a: 0.9162103442749088d, b: 0.9192888417388637d, c: 0.7668362507545152d),
new NpgsqlTypes.NpgsqlLine(a: 0.9794184742524346d, b: 0.4759916371499143d, c: 0.6200771533302153d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5223521226067946d, b: 0.14450685899347704d, c: 0.5839103761328063d),
new NpgsqlTypes.NpgsqlLine(a: 0.06991239167499663d, b: 0.9556675771742003d, c: 0.3283939069592178d),
new NpgsqlTypes.NpgsqlLine(a: 0.9896074575946546d, b: 0.7855823507495256d, c: 0.0668187281743291d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23947188843848988d, b: 0.05453040355376326d, c: 0.6795410852611383d),
new NpgsqlTypes.NpgsqlLine(a: 0.9061838669812982d, b: 0.28117813073703235d, c: 0.418901800528817d),
new NpgsqlTypes.NpgsqlLine(a: 0.4254070854213928d, b: 0.09433441001371323d, c: 0.5961122978210244d),
new NpgsqlTypes.NpgsqlLine(a: 0.16184698485065874d, b: 0.8085614771409598d, c: 0.6153438763028045d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.925916473012978d, b: 0.7393127692467659d, c: 0.22033770219105542d),
new NpgsqlTypes.NpgsqlLine(a: 0.8115954205738986d, b: 0.6610879576668084d, c: 0.12820285133341913d),
new NpgsqlTypes.NpgsqlLine(a: 0.45403124298408004d, b: 0.8701839299477034d, c: 0.29070034011373624d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2465950700688876d, b: 0.12347771030193111d, c: 0.6727203089147188d),
new NpgsqlTypes.NpgsqlLine(a: 0.6625767420670221d, b: 0.3113265185485936d, c: 0.10053246172033747d),
new NpgsqlTypes.NpgsqlLine(a: 0.6854686429244995d, b: 0.5045507480691639d, c: 0.2863795768810522d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3292763734585479d, b: 0.43147072553298615d, c: 0.04446444483652501d),
new NpgsqlTypes.NpgsqlLine(a: 0.15088284569794064d, b: 0.7229096857562529d, c: 0.33364833114467385d),
new NpgsqlTypes.NpgsqlLine(a: 0.4837856744423885d, b: 0.8822486029448007d, c: 0.8506851407933862d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9433521569209684d, b: 0.3389095070920829d, c: 0.27846923013762226d),
new NpgsqlTypes.NpgsqlLine(a: 0.3857303141044487d, b: 0.6747902054824617d, c: 0.8171419229389679d),
new NpgsqlTypes.NpgsqlLine(a: 0.34245036684993935d, b: 0.8386378867362322d, c: 0.47137024272848027d),
new NpgsqlTypes.NpgsqlLine(a: 0.6573378725807837d, b: 0.29803248357796874d, c: 0.9509354964680757d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9219171473888418d, b: 0.17618040743894403d, c: 0.21237510492678457d),
new NpgsqlTypes.NpgsqlLine(a: 0.21944895952304033d, b: 0.8196414618733451d, c: 0.7339228676446011d),
new NpgsqlTypes.NpgsqlLine(a: 0.6204740349547828d, b: 0.5967678468308247d, c: 0.02781790988516919d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1323151135295907d, b: 0.8224741614101089d, c: 0.7336330343285773d),
new NpgsqlTypes.NpgsqlLine(a: 0.3043558541503696d, b: 0.5188739296422574d, c: 0.21081971768697372d),
new NpgsqlTypes.NpgsqlLine(a: 0.7956433628442395d, b: 0.07064461940616207d, c: 0.39206555644503593d),
new NpgsqlTypes.NpgsqlLine(a: 0.4922574140098285d, b: 0.8049953191950155d, c: 0.7537434340667658d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9679204391456574d, b: 0.173962380501275d, c: 0.1960643685060619d),
new NpgsqlTypes.NpgsqlLine(a: 0.636292828394757d, b: 0.10638044229371069d, c: 0.5973103228193056d),
new NpgsqlTypes.NpgsqlLine(a: 0.8981744614022635d, b: 0.18646114108575262d, c: 0.0027192599678400597d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.532827692826266d, b: 0.03679670956514369d, c: 0.9868798975195717d),
new NpgsqlTypes.NpgsqlLine(a: 0.8876193161269681d, b: 0.9156626418069534d, c: 0.9479239652472241d),
new NpgsqlTypes.NpgsqlLine(a: 0.6943791138017663d, b: 0.974769845011489d, c: 0.9485017490055612d),
new NpgsqlTypes.NpgsqlLine(a: 0.4233244631462304d, b: 0.4667993525754177d, c: 0.2807686223211867d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41337278834304636d, b: 0.6611132086366291d, c: 0.21928366902923813d),
new NpgsqlTypes.NpgsqlLine(a: 0.6513630579507884d, b: 0.7384698125795022d, c: 0.11032161050778566d),
new NpgsqlTypes.NpgsqlLine(a: 0.4095706183491219d, b: 0.3669905373251804d, c: 0.620784829400701d),
new NpgsqlTypes.NpgsqlLine(a: 0.13014683999722765d, b: 0.6903189923693933d, c: 0.3957614514676592d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43387388800754345d, b: 0.20523238986044545d, c: 0.9120775149868329d),
new NpgsqlTypes.NpgsqlLine(a: 0.8105674047136d, b: 0.8103910293244121d, c: 0.5404699599049043d),
new NpgsqlTypes.NpgsqlLine(a: 0.14625220936334493d, b: 0.1810622147397114d, c: 0.668609453264801d),
new NpgsqlTypes.NpgsqlLine(a: 0.9775181571907977d, b: 0.8692727575354542d, c: 0.5360615290328722d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7856620575162672d, b: 0.09491851255217465d, c: 0.07447417183812033d),
new NpgsqlTypes.NpgsqlLine(a: 0.31937104489642476d, b: 0.14175955959884334d, c: 0.534421859283936d),
new NpgsqlTypes.NpgsqlLine(a: 0.23680172081118456d, b: 0.781303686713876d, c: 0.5287665277711537d),
new NpgsqlTypes.NpgsqlLine(a: 0.17592213892713138d, b: 0.8360618025432567d, c: 0.4400483652251459d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14827595739324495d, b: 0.16578390450527736d, c: 0.56343932373881d),
new NpgsqlTypes.NpgsqlLine(a: 0.24293054536013914d, b: 0.4461001529604909d, c: 0.054046015213238374d),
new NpgsqlTypes.NpgsqlLine(a: 0.6759831491022682d, b: 0.25486076342455555d, c: 0.016871100896162616d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8233050354936224d, b: 0.5833352198483843d, c: 0.24718225978807762d),
new NpgsqlTypes.NpgsqlLine(a: 0.6191746188954798d, b: 0.5220562595919496d, c: 0.30669777788172414d),
new NpgsqlTypes.NpgsqlLine(a: 0.24184291385647538d, b: 0.4634506821450268d, c: 0.38598336194753646d),
new NpgsqlTypes.NpgsqlLine(a: 0.349058145325425d, b: 0.2752857842348556d, c: 0.18293667653925794d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8589244445190541d, b: 0.2019342854747197d, c: 0.16551173042716016d),
new NpgsqlTypes.NpgsqlLine(a: 0.3959979802238025d, b: 0.25999278507630574d, c: 0.8577735687228227d),
new NpgsqlTypes.NpgsqlLine(a: 0.8372790357415343d, b: 0.6399734380504892d, c: 0.25752298043907573d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41791522880595944d, b: 0.4130620050544631d, c: 0.1677881945926757d),
new NpgsqlTypes.NpgsqlLine(a: 0.5555836846649952d, b: 0.12130851348007499d, c: 0.5232524850246522d),
new NpgsqlTypes.NpgsqlLine(a: 0.1373194480164036d, b: 0.8743805702859636d, c: 0.6437585177963151d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7872877293567834d, b: 0.496044864124806d, c: 0.09729882034463777d),
new NpgsqlTypes.NpgsqlLine(a: 0.25409374752985725d, b: 0.7426370731816401d, c: 0.8760272405313059d),
new NpgsqlTypes.NpgsqlLine(a: 0.8935338962581272d, b: 0.26837362485323357d, c: 0.9541981540020518d),
new NpgsqlTypes.NpgsqlLine(a: 0.7162579909261676d, b: 0.5886204341972263d, c: 0.9878175131668504d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2921373195993995d, b: 0.06915496303104662d, c: 0.39537006338505154d),
new NpgsqlTypes.NpgsqlLine(a: 0.8131491629859d, b: 0.5438019896193695d, c: 0.9524630758218798d),
new NpgsqlTypes.NpgsqlLine(a: 0.0031628705866946216d, b: 0.40700532137471934d, c: 0.21144149556896774d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5092981987132854d, b: 0.4441413239910307d, c: 0.21804463612181657d),
new NpgsqlTypes.NpgsqlLine(a: 0.969143675467719d, b: 0.56790431966166d, c: 0.2331529880172828d),
new NpgsqlTypes.NpgsqlLine(a: 0.6583143897237808d, b: 0.6889807239362785d, c: 0.49939054712945563d),
new NpgsqlTypes.NpgsqlLine(a: 0.9015353453026159d, b: 0.5147641300629056d, c: 0.4597257847450955d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38254695075339595d, b: 0.056578207421008386d, c: 0.8823443693797789d),
new NpgsqlTypes.NpgsqlLine(a: 0.7152209262706273d, b: 0.9917236423517185d, c: 0.05498748135445719d),
new NpgsqlTypes.NpgsqlLine(a: 0.33582004489495143d, b: 0.8874579452511181d, c: 0.2625008262014732d),
new NpgsqlTypes.NpgsqlLine(a: 0.4334511645066931d, b: 0.7154931432428243d, c: 0.3679988930424086d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16062121088872172d, b: 0.13999351773387292d, c: 0.22390396433716375d),
new NpgsqlTypes.NpgsqlLine(a: 0.08023041956641419d, b: 0.35902607386411756d, c: 0.8233818583599116d),
new NpgsqlTypes.NpgsqlLine(a: 0.9182779330052642d, b: 0.5685504121964075d, c: 0.5310048070633555d),
new NpgsqlTypes.NpgsqlLine(a: 0.35856574192152946d, b: 0.20345861076646676d, c: 0.34513207599086704d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8454455911995431d, b: 0.45446614578373756d, c: 0.6538699960856628d),
new NpgsqlTypes.NpgsqlLine(a: 0.5496945966773336d, b: 0.023511464872023158d, c: 0.6962600636284156d),
new NpgsqlTypes.NpgsqlLine(a: 0.03648899139526074d, b: 0.6374968698666966d, c: 0.2729529329713495d),
new NpgsqlTypes.NpgsqlLine(a: 0.6408826247470113d, b: 0.548899414556336d, c: 0.6100734570983164d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8113340982016282d, b: 0.4903830583696306d, c: 0.08992739348195788d),
new NpgsqlTypes.NpgsqlLine(a: 0.43378713020753723d, b: 0.7107982992433104d, c: 0.2432979857149017d),
new NpgsqlTypes.NpgsqlLine(a: 0.06593375445504301d, b: 0.8749999916803172d, c: 0.10854764591494104d),
new NpgsqlTypes.NpgsqlLine(a: 0.868675426354811d, b: 0.6320076669073835d, c: 0.7992697608722055d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5681589451449388d, b: 0.6058420508135967d, c: 0.5793750625324056d),
new NpgsqlTypes.NpgsqlLine(a: 0.641783560216597d, b: 0.33378737910003253d, c: 0.8233165165719801d),
new NpgsqlTypes.NpgsqlLine(a: 0.3910769711711417d, b: 0.8989482600472802d, c: 0.7999197133067357d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5368000801594365d, b: 0.322713440197409d, c: 0.7164366039247486d),
new NpgsqlTypes.NpgsqlLine(a: 0.8979830753483089d, b: 0.047239111581712456d, c: 0.2546189872264628d),
new NpgsqlTypes.NpgsqlLine(a: 0.9959622025152576d, b: 0.6290205705503763d, c: 0.4057061405347191d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7959617084981314d, b: 0.3810966913500393d, c: 0.8978382824977481d),
new NpgsqlTypes.NpgsqlLine(a: 0.3506071259929855d, b: 0.030938853849915127d, c: 0.009380961216539752d),
new NpgsqlTypes.NpgsqlLine(a: 0.4964926540854525d, b: 0.9161920975165262d, c: 0.23449185319745347d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8436282079174166d, b: 0.2234094645208642d, c: 0.376773436236551d),
new NpgsqlTypes.NpgsqlLine(a: 0.42566830618478924d, b: 0.6949502734840187d, c: 0.2698425536970155d),
new NpgsqlTypes.NpgsqlLine(a: 0.3302116512377882d, b: 0.5486982213212748d, c: 0.776217134270436d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7090244139351198d, b: 0.00453853219652256d, c: 0.14380239175712628d),
new NpgsqlTypes.NpgsqlLine(a: 0.0891341186155522d, b: 0.2755143723888639d, c: 0.11697426075579864d),
new NpgsqlTypes.NpgsqlLine(a: 0.8142724793956151d, b: 0.7997796469911989d, c: 0.5997786659262233d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9653724398766473d, b: 0.8559315326297144d, c: 0.04479680267119923d),
new NpgsqlTypes.NpgsqlLine(a: 0.124187960641445d, b: 0.3803492075012741d, c: 0.3206213634890285d),
new NpgsqlTypes.NpgsqlLine(a: 0.4861020635253306d, b: 0.9858553452879221d, c: 0.2851394829569315d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6984659050349683d, b: 0.902730851970346d, c: 0.594019019592545d),
new NpgsqlTypes.NpgsqlLine(a: 0.4092383042755131d, b: 0.43279076727249244d, c: 0.4521855962458736d),
new NpgsqlTypes.NpgsqlLine(a: 0.48418277209944005d, b: 0.9249621171117319d, c: 0.6643816971693398d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2213983332496442d, b: 0.921691648834323d, c: 0.9962422238639365d),
new NpgsqlTypes.NpgsqlLine(a: 0.47807371868235293d, b: 0.0873068110663513d, c: 0.8167111086606555d),
new NpgsqlTypes.NpgsqlLine(a: 0.9778523250779176d, b: 0.868477390424993d, c: 0.4070050546225721d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2519064187737866d, b: 0.11115317247721501d, c: 0.5430320271213442d),
new NpgsqlTypes.NpgsqlLine(a: 0.7542723008629862d, b: 0.5704655124161495d, c: 0.6747725027425091d),
new NpgsqlTypes.NpgsqlLine(a: 0.6886959066676116d, b: 0.5796596736469839d, c: 0.10681006517142477d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7254994109160945d, b: 0.220307226280544d, c: 0.737720337020657d),
new NpgsqlTypes.NpgsqlLine(a: 0.3450049248718675d, b: 0.9966770233579219d, c: 0.39850034181464244d),
new NpgsqlTypes.NpgsqlLine(a: 0.23367464187084674d, b: 0.8089850069809356d, c: 0.04836741153964719d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24300228608560204d, b: 0.43509428886173096d, c: 0.4727124396142065d),
new NpgsqlTypes.NpgsqlLine(a: 0.29012809852089094d, b: 0.1225198871931521d, c: 0.4760933053017954d),
new NpgsqlTypes.NpgsqlLine(a: 0.937970080827409d, b: 0.46706390241584383d, c: 0.631539980315173d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 175,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4830626301910035d, b: 0.4762747499503732d, c: 0.49668989036347d),
new NpgsqlTypes.NpgsqlLine(a: 0.7836344944668523d, b: 0.33171201984628806d, c: 0.12282796437925081d),
new NpgsqlTypes.NpgsqlLine(a: 0.5374978587610186d, b: 0.4726016142769337d, c: 0.38302337483033944d),
new NpgsqlTypes.NpgsqlLine(a: 0.6552064434598442d, b: 0.6574639093823625d, c: 0.07281884725023569d),
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
new NpgsqlTypes.NpgsqlLine(a: 0.03199480427628931d, b: 0.40939390605234016d, c: 0.5888831310609584d),
new NpgsqlTypes.NpgsqlLine(a: 0.8085647967240894d, b: 0.29190948628808666d, c: 0.29008696971084824d),
new NpgsqlTypes.NpgsqlLine(a: 0.15005371422155256d, b: 0.4047218482915368d, c: 0.8114885525821841d),
new NpgsqlTypes.NpgsqlLine(a: 0.8181139349070797d, b: 0.744475155548143d, c: 0.7105783705794164d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24786317892322363d, b: 0.2897459538454833d, c: 0.37139419885482927d),
new NpgsqlTypes.NpgsqlLine(a: 0.24361835217023575d, b: 0.6804492443541056d, c: 0.7209497990183973d),
new NpgsqlTypes.NpgsqlLine(a: 0.04759275827254961d, b: 0.13471952668389098d, c: 0.16244571238638394d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1944137885720697d, b: 0.8684386957356064d, c: 0.37159019205288535d),
new NpgsqlTypes.NpgsqlLine(a: 0.37052663380652806d, b: 0.03658834215236084d, c: 0.2543962539372462d),
new NpgsqlTypes.NpgsqlLine(a: 0.5372005160892684d, b: 0.9986024271375741d, c: 0.07757246763328762d),
new NpgsqlTypes.NpgsqlLine(a: 0.09167137831930317d, b: 0.9022574077403673d, c: 0.608568515043434d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28098147330087464d, b: 0.4328906672808476d, c: 0.10832776032940261d),
new NpgsqlTypes.NpgsqlLine(a: 0.6714735040874451d, b: 0.04769592639096243d, c: 0.5626835291606138d),
new NpgsqlTypes.NpgsqlLine(a: 0.5435558196328472d, b: 0.8630502520539094d, c: 0.13651276778176136d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7546906106911754d, b: 0.6198261288332808d, c: 0.49398356715028013d),
new NpgsqlTypes.NpgsqlLine(a: 0.5194173533348737d, b: 0.3091862767278638d, c: 0.7766814563904533d),
new NpgsqlTypes.NpgsqlLine(a: 0.30621361532340097d, b: 0.18556392666877863d, c: 0.794589083742845d),
new NpgsqlTypes.NpgsqlLine(a: 0.2590142218455316d, b: 0.42185372790969333d, c: 0.9760279316900451d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9308545946378358d, b: 0.8441884762684506d, c: 0.55444067327685d),
new NpgsqlTypes.NpgsqlLine(a: 0.9078860432072678d, b: 0.9751356481159934d, c: 0.41267063592810316d),
new NpgsqlTypes.NpgsqlLine(a: 0.2571767222997884d, b: 0.7898547032065354d, c: 0.47155015402515565d),
new NpgsqlTypes.NpgsqlLine(a: 0.742437737457917d, b: 0.97074557142383d, c: 0.38589220354582787d),
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.35211940616688786d, b: 0.3999712996842715d, c: 0.5430174829073102d),
new NpgsqlTypes.NpgsqlLine(a: 0.9118368873559439d, b: 0.23472689239554567d, c: 0.6334956457274067d),
new NpgsqlTypes.NpgsqlLine(a: 0.676693519425966d, b: 0.9114689739024356d, c: 0.8245617313631513d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09941023121708248d, b: 0.7240239813057089d, c: 0.5572968517729582d),
new NpgsqlTypes.NpgsqlLine(a: 0.16863910634901302d, b: 0.613880546247417d, c: 0.10381558366235932d),
new NpgsqlTypes.NpgsqlLine(a: 0.08662185149650314d, b: 0.06395516051869865d, c: 0.15249574579089398d),
}));
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine(a: 0.812027783461543d, b: 0.012453626291318631d, c: 0.9968544630977921d),
new NpgsqlTypes.NpgsqlLine(a: 0.5509289828165331d, b: 0.6364331798977584d, c: 0.45960330848089714d),
new NpgsqlTypes.NpgsqlLine(a: 0.010867102703341902d, b: 0.28713736228137376d, c: 0.22984715433431047d),
}));
                nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6756276373454629d, b: 0.8145944603468143d, c: 0.8463611293181433d),
new NpgsqlTypes.NpgsqlLine(a: 0.4169383916656547d, b: 0.6417259427092237d, c: 0.06927738893557267d),
new NpgsqlTypes.NpgsqlLine(a: 0.020687788198463508d, b: 0.3887737971242392d, c: 0.8761363654332913d),
new NpgsqlTypes.NpgsqlLine(a: 0.6169394223416197d, b: 0.4903808935614584d, c: 0.25733461888853415d),
}));
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41160928842838185d, b: 0.991099309167026d, c: 0.13039867307733233d),
new NpgsqlTypes.NpgsqlLine(a: 0.15679388309345244d, b: 0.6946266605863232d, c: 0.15892444290596963d),
new NpgsqlTypes.NpgsqlLine(a: 0.9241318245081388d, b: 0.5442565332309499d, c: 0.09368659245720512d),
new NpgsqlTypes.NpgsqlLine(a: 0.9375507621650632d, b: 0.8587037552847677d, c: 0.8384310449633571d),
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 99, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 129, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 145, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 138, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 154, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 145, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 145, query1, 129, query2))
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 57, query1, 166, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 175, 122))
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 67, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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

