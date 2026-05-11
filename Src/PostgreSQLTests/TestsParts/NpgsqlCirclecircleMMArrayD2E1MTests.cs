

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
    internal partial interface INpgsqlCircleMArraycircleMMArrayD2
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMMArrayD2 : INpgsqlCircleMArraycircleMMArrayD2
    {


#region TestData

        private readonly NpgsqlCirclecircleMMArrayD2E1M[] _testData = new NpgsqlCirclecircleMMArrayD2E1M[]
        {
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6548345687875411d, y: 0.7014188371118864d), radius: 0.4167768807153567d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07104231369215386d, y: 0.9421582535296943d), radius: 0.7457822609911985d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5510247299589295d, y: 0.5348038371891657d), radius: 0.2577794909508918d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5107760208100066d, y: 0.9914607570780075d), radius: 0.273361083562759d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20749005814011423d, y: 0.8193325246240878d), radius: 0.37550231947359547d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33818041137212584d, y: 0.029051068059033902d), radius: 0.013956383057350807d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5350127175881988d, y: 0.6386551225720177d), radius: 0.3217166162169943d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32827627774723045d, y: 0.6354973184538547d), radius: 0.41273608220305325d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986253708449325d, y: 0.3697243979407949d), radius: 0.9968892229768327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4348618864909167d, y: 0.287505134189335d), radius: 0.7663964539819439d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45528514836599665d, y: 0.09473638494010506d), radius: 0.6725788892974887d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15905237511380788d, y: 0.7815925998513075d), radius: 0.5199856285756524d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7418646397518243d, y: 0.41792227026880846d), radius: 0.8580893206933717d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6669644476046102d, y: 0.046140279629440006d), radius: 0.5381638594736962d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6573854390301122d, y: 0.18664532136431822d), radius: 0.0036695200216128043d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5377975280766875d, y: 0.6788247198048342d), radius: 0.7709062663743627d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8653646724164659d, y: 0.5361383216592345d), radius: 0.43077860474679985d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726730148390119d, y: 0.1326251647978982d), radius: 0.5773893605429109d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6426583221476289d, y: 0.025705647041782576d), radius: 0.292218413395381d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9227112752917704d, y: 0.4381684507245872d), radius: 0.9534964647849979d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06085247075098821d, y: 0.9460624131671834d), radius: 0.3110758916709756d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9276936862920347d, y: 0.640342321733651d), radius: 0.7071008212206179d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47388269648388504d, y: 0.30697075835883314d), radius: 0.7643910522315082d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3603217693481482d, y: 0.4645209822559029d), radius: 0.6991170398751991d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9484858643709893d, y: 0.4775804655773992d), radius: 0.22970628110063562d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07751374072461414d, y: 0.7144828820375319d), radius: 0.26832209706695187d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5911662483936319d, y: 0.9877263870053297d), radius: 0.33026245551947386d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11237519823381159d, y: 0.563312289030556d), radius: 0.7908868820241425d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0050062221393493145d, y: 0.5581291486109923d), radius: 0.9006693616758356d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5534265207774303d, y: 0.09614733484195026d), radius: 0.439112433071126d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2666714116735289d, y: 0.868709203762258d), radius: 0.47859589726190055d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5511365632177289d, y: 0.7166802048608522d), radius: 0.2987727029227837d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3505546289406063d, y: 0.6274871457441065d), radius: 0.7010529089325215d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5362911392236918d, y: 0.45870845000558347d), radius: 0.14277460118163565d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.641489831118987d, y: 0.27376587026537225d), radius: 0.6548326813884712d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20186656650244916d, y: 0.1500109283063793d), radius: 0.748170363146415d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02737079251294572d, y: 0.6527140820416627d), radius: 0.1965144412627161d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6762608683053989d, y: 0.2609963668744274d), radius: 0.08537202350950712d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1054840523097994d, y: 0.3777227013036919d), radius: 0.1952838363994328d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2064932394975676d, y: 0.31366243360627655d), radius: 0.44639542339663996d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1530400897380887d, y: 0.0017733847593306429d), radius: 0.080170325732412d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8645073301901993d, y: 0.7088667832938381d), radius: 0.8531666418090452d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6578521372005153d, y: 0.09295345126726373d), radius: 0.35165326332036795d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39028324739857867d, y: 0.4364743514729822d), radius: 0.343287112972404d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7310969368488691d, y: 0.40832635291017394d), radius: 0.00031244788249240596d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9875730971234158d, y: 0.9711430601654814d), radius: 0.5670436147916951d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5669946172034612d, y: 0.29171189710303713d), radius: 0.29210904336113297d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3433044383181386d, y: 0.5188299313754903d), radius: 0.7355804173738927d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.627932265954255d, y: 0.3859170511128548d), radius: 0.14559223417967115d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7284115728207985d, y: 0.16357128648341845d), radius: 0.5913336125411007d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8808006071276546d, y: 0.8465837253050026d), radius: 0.9149716998584878d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17913072276714848d, y: 0.28601371935199016d), radius: 0.4494089163021159d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5495332298321635d, y: 0.6297129547491941d), radius: 0.785442468117725d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11408225715694142d, y: 4.881339091056258E-05d), radius: 0.5269252719434518d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7108530622544278d, y: 0.8951520511993908d), radius: 0.9364780316701499d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8259091233184009d, y: 0.5476237726143243d), radius: 0.2748864013479173d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4937855418386645d, y: 0.028392725685494002d), radius: 0.034669687230570734d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7909095436366567d, y: 0.09526583925135124d), radius: 0.5698103422940404d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9188818442529312d, y: 0.19685349246162254d), radius: 0.2534768910464055d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7286356829539987d, y: 0.49449267090623883d), radius: 0.950367200172394d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25703769447011293d, y: 0.702445002389339d), radius: 0.7110185089851446d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4317468315595542d, y: 0.9393494290263883d), radius: 0.6356057374183168d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9895960568176005d, y: 0.4218527875449809d), radius: 0.3098653736055538d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4932829668123978d, y: 0.42217573853877777d), radius: 0.8666202303638877d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11814272427594052d, y: 0.2592716484488853d), radius: 0.3907728227380749d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3152546890093739d, y: 0.6505335564857228d), radius: 0.04619569720773786d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7945599350661662d, y: 0.9670745288238607d), radius: 0.08867382647132638d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0617994920013748d, y: 0.3822792806223163d), radius: 0.7587684036777892d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6098098171992448d, y: 0.7883417501365318d), radius: 0.3006290033104623d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7636022493395588d, y: 0.808561312125025d), radius: 0.22704169543478891d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9129772445528413d, y: 0.8585763237261389d), radius: 0.5508080379462453d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8288103060076426d, y: 0.0010697260591859825d), radius: 0.7991364812806844d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07760611026995134d, y: 0.14623613769231947d), radius: 0.731667595638345d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1250637536316388d, y: 0.4451280573753862d), radius: 0.49445920388819076d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11207893949241188d, y: 0.9679731899780973d), radius: 0.7137838409808528d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7043868084680208d, y: 0.6130101312281875d), radius: 0.00526137715380115d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9007471226068664d, y: 0.25995186663164194d), radius: 0.8643068802012474d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8175852711366273d, y: 0.23437335161271544d), radius: 0.060901833704412156d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43555978826973085d, y: 0.9779634854211392d), radius: 0.6824581941641887d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20365016338169006d, y: 0.49337678799460694d), radius: 0.6429607210590017d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7170097989785859d, y: 0.9927576275390696d), radius: 0.23945477620251265d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7147247390214257d, y: 0.7613545916490413d), radius: 0.47037295874003693d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9168228884987509d, y: 0.7855079242750632d), radius: 0.8261376390963041d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2227470183128164d, y: 0.09798974803401062d), radius: 0.4218444617753061d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6609484012143018d, y: 0.33642299643989815d), radius: 0.29577987145155715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8286625068589606d, y: 0.006313637972943931d), radius: 0.6505865468259063d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.741716369995408d, y: 0.15933934358885726d), radius: 0.31966047794013197d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8272235265254797d, y: 0.09792288205318544d), radius: 0.6728777450781626d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8321386186349095d, y: 0.23907805948257266d), radius: 0.08230722568796356d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9333524669192671d, y: 0.22215416697431656d), radius: 0.967792343627394d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49200406658398754d, y: 0.31377065746967026d), radius: 0.3597742052416705d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7176702902590965d, y: 0.29050833122687625d), radius: 0.3231884113567237d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9442540862691069d, y: 0.5455592580706383d), radius: 0.10434738424458279d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.952224771016776d, y: 0.7024306911735503d), radius: 0.4707002409682284d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9714723048639624d, y: 0.7504103725496435d), radius: 0.5154913800251584d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6041241497009413d, y: 0.09465302313663715d), radius: 0.17768685601000023d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6298243695746334d, y: 0.7015200772929049d), radius: 0.8812261623851405d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021174045791871876d, y: 0.8634103495845741d), radius: 0.8258113967761187d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6027415002665666d, y: 0.32931705278698553d), radius: 0.5668725102408338d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5029715039432396d, y: 0.8574878561003286d), radius: 0.20847262921650433d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29393371822359826d, y: 0.5239335092601569d), radius: 0.9945194711639649d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7461027840880247d, y: 0.6317061003233364d), radius: 0.714860704283681d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37198256951803943d, y: 0.8483990864648209d), radius: 0.4312184724408259d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7651139676377117d, y: 0.6985178751363628d), radius: 0.7028803864786377d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39552628687988534d, y: 0.857114902098739d), radius: 0.642300696177306d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.871616590573996d, y: 0.046902132027424104d), radius: 0.9944690834097358d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15021790013140746d, y: 0.23009830006654242d), radius: 0.32124273024978467d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018177735270348605d, y: 0.37387947557190826d), radius: 0.4335925052808688d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30023233786539794d, y: 0.5275677550827805d), radius: 0.009382439657967478d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1323471797204654d, y: 0.5563766578377911d), radius: 0.5501098901529786d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.872352196535852d, y: 0.5354185111734159d), radius: 0.5071194577681776d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49986491735812566d, y: 0.115525455982737d), radius: 0.21403634652056358d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8171459610203516d, y: 0.24981251341132082d), radius: 0.05298304370062512d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9612530934967536d, y: 0.20307740015509335d), radius: 0.8803552878750169d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7554488609871297d, y: 0.3280086990507497d), radius: 0.7072366088260617d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31337955347082325d, y: 0.3323722630396585d), radius: 0.8658162536286175d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7472023693275426d, y: 0.9247702499076991d), radius: 0.5106120674402808d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17064209454179702d, y: 0.4825268570790554d), radius: 0.8379922285807287d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12347604498957288d, y: 0.9941695151662701d), radius: 0.479173208998544d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3249084676875543d, y: 0.1509496240305116d), radius: 0.5105884787243524d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41875986070562443d, y: 0.6308363048420138d), radius: 0.132439683630582d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21383240322842179d, y: 0.9497653398044876d), radius: 0.6984406495905474d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4457511422694689d, y: 0.719302368065846d), radius: 0.958483316608256d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5617918447202269d, y: 0.7761163200924606d), radius: 0.8271293915306791d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4497219456724474d, y: 0.3887858091854025d), radius: 0.10743749454660756d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4423627068036903d, y: 0.47757128695367534d), radius: 0.6756430934070682d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45126573789877356d, y: 0.1181656207230024d), radius: 0.1110778105560104d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5192962057357182d, y: 0.5545865488640744d), radius: 0.23383892123456063d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40247112982447086d, y: 0.2840910941432083d), radius: 0.4340374706178223d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5694159242542967d, y: 0.9782965049146408d), radius: 0.8946813033274621d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39672002192749445d, y: 0.5000113712984826d), radius: 0.952477093897027d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009160013820931123d, y: 0.6920411561211037d), radius: 0.34066117684696096d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7508470718215869d, y: 0.24472921543313908d), radius: 0.32640412310669d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49812470288172206d, y: 0.5348336071778498d), radius: 0.0792316333047346d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43737027332026845d, y: 0.6942844138112493d), radius: 0.6479294660157151d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07698223557671124d, y: 0.6317011897871532d), radius: 0.7330521390795542d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26232318194056825d, y: 0.14670964529354202d), radius: 0.8540927552776012d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5226870067893923d, y: 0.41965460739984894d), radius: 0.8777411709812505d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41194508297572074d, y: 0.6745909701131437d), radius: 0.17082688716722938d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5203710998504193d, y: 0.7398033009919822d), radius: 0.6654561849921368d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6479531759341118d, y: 0.33080630947487066d), radius: 0.9189007007059093d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1722233369501125d, y: 0.21361743764484986d), radius: 0.02010548962759695d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4450470201186706d, y: 0.27484815505788895d), radius: 0.7013126105102492d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7894046920963218d, y: 0.2665012544185591d), radius: 0.3813520441253251d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.500227218032285d, y: 0.6296387204223697d), radius: 0.08410877013904039d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8001267817519812d, y: 0.44080101420581286d), radius: 0.48706772873179005d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9848166753384724d, y: 0.8436818083374753d), radius: 0.3434500781620434d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7279041058153448d, y: 0.04323551850270879d), radius: 0.3501548834389656d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07327804451667752d, y: 0.7337321082940873d), radius: 0.2165172819143666d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.740878008855964d, y: 0.2211159506876973d), radius: 0.8127768343976307d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30017161601681985d, y: 0.987865921761275d), radius: 0.6209511623248428d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40831444153023666d, y: 0.462048123247496d), radius: 0.6052497754387676d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5496054368037028d, y: 0.8582802704240966d), radius: 0.3586307163563972d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7377671559667612d, y: 0.41144564155044694d), radius: 0.5093567981596272d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4869490098855175d, y: 0.08519065795793257d), radius: 0.32994829803140757d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5848823520430863d, y: 0.5525136484966523d), radius: 0.15809737469155827d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6709121872922336d, y: 0.2980975830578576d), radius: 0.8427169658658773d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7390443248749364d, y: 0.3909613363169254d), radius: 0.6431903308587794d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9562225405516079d, y: 0.46635376162117625d), radius: 0.3415848143673683d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3398768848448639d, y: 0.2948164432407111d), radius: 0.27455628548280964d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8218915199877848d, y: 0.8702856972717571d), radius: 0.3969946997065482d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35015779568017535d, y: 0.9408887675604033d), radius: 0.9580403244046362d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36697217483403377d, y: 0.5056595169582512d), radius: 0.08961186605361426d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8541315955682408d, y: 0.9695998926719318d), radius: 0.34706936221546936d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15408663990815308d, y: 0.9944343431438357d), radius: 0.8040781356338174d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.74843680476192d, y: 0.13910904419687742d), radius: 0.44942391876871557d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05087172790647021d, y: 0.7761680147958644d), radius: 0.0829501478080854d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121604571230335d, y: 0.11283692253897781d), radius: 0.16678907594657177d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0824338762990775d, y: 0.7760337011248974d), radius: 0.4018096893580575d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20035083455028846d, y: 0.9737021670317654d), radius: 0.2068763221365988d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10923204524839991d, y: 0.7197301566704248d), radius: 0.05157194332382653d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8872527486519179d, y: 0.8629034196537756d), radius: 0.09229295845148422d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7843806175767185d, y: 0.23940665957887963d), radius: 0.6413759774938174d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4725038101561232d, y: 0.8775384308032963d), radius: 0.453135741512532d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29094088045160327d, y: 0.8463554351716924d), radius: 0.7873033064963315d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4474679347337259d, y: 0.11090998578098976d), radius: 0.6733605287612777d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6656800399998007d, y: 0.016945397920890337d), radius: 0.9335514362318893d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5065430322420473d, y: 0.504466478276656d), radius: 0.548900845086661d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2299757025881103d, y: 0.476444698380284d), radius: 0.09755288102605453d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8423519236113247d, y: 0.4140466533264653d), radius: 0.35307882402930413d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6529497219468098d, y: 0.5982659753802777d), radius: 0.031207716621433734d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3771334537294221d, y: 0.4327140217839641d), radius: 0.29828853742690775d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7323437789313189d, y: 0.6122193104367537d), radius: 0.6763308230785735d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7241238213721412d, y: 0.9631560986500828d), radius: 0.827534514662424d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10371320659559491d, y: 0.5395716227992879d), radius: 0.17009200866974983d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15371283630969224d, y: 0.0802513021352611d), radius: 0.5201699776184064d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.413304973071584d, y: 0.6243728322476751d), radius: 0.25465259137657936d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9656553269636349d, y: 0.6858926291716222d), radius: 0.39232269605062664d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6425463141569725d, y: 0.889145712383364d), radius: 0.7590743446551361d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6141625700685094d, y: 0.16412047908712457d), radius: 0.15841282926613032d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32732657138996013d, y: 0.8811054372114255d), radius: 0.6170788945838865d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1807908048412311d, y: 0.5253651451546032d), radius: 0.3131273471004342d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0978910100780821d, y: 0.1091992806056109d), radius: 0.46438618654105335d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10516807728028854d, y: 0.15680324951214875d), radius: 0.4629892858632433d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5079333256123997d, y: 0.9316399065493951d), radius: 0.4260438088479709d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9627684074990365d, y: 0.4838526558685261d), radius: 0.967354733665054d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7622986426647487d, y: 0.6708057164397254d), radius: 0.9513672976167546d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6192485962578306d, y: 0.5474443861364051d), radius: 0.35251292061571626d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42967380755688034d, y: 0.27526539983193177d), radius: 0.36490863742034885d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2235308901560077d, y: 0.352606967429574d), radius: 0.5698941148918806d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09612817429701837d, y: 0.274751700410779d), radius: 0.08647172495227018d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8737796831450352d, y: 0.1600564652436567d), radius: 0.4304700574082362d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.788244623461151d, y: 0.8528944702936776d), radius: 0.35786391539848783d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12348762290738413d, y: 0.9446716851694725d), radius: 0.8448235705152887d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18742973988034883d, y: 0.6013233715531269d), radius: 0.5920857482708249d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26979979144207933d, y: 0.8929140827677865d), radius: 0.8713447730344455d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7960626054509228d, y: 0.07806654024279114d), radius: 0.5638193431534334d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5826254651986583d, y: 0.20527403338272598d), radius: 0.6141199014176468d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.56219590096413d, y: 0.8568155419688295d), radius: 0.19844507618296225d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42193658106203547d, y: 0.7058136379735006d), radius: 0.6754485887390694d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22351204536497793d, y: 0.047014493806705304d), radius: 0.41176383406545625d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9839784326949362d, y: 0.7104430451401366d), radius: 0.79990224908864d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12655582565769674d, y: 0.22559771505442028d), radius: 0.5633118734377166d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24671782750333482d, y: 0.7599684834189178d), radius: 0.9938671327883478d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8206297857141127d, y: 0.160967154784044d), radius: 0.7128655527893559d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6541761624286792d, y: 0.8704841879365032d), radius: 0.6447755092925781d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5341476893978293d, y: 0.7134835662689613d), radius: 0.7223570717056074d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02031494277366397d, y: 0.31426618713966215d), radius: 0.49923552486321054d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9585837049119174d, y: 0.41747510477648875d), radius: 0.6262412150571782d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8815477864466879d, y: 0.9835789906465418d), radius: 0.1876786503562936d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06882620071336287d, y: 0.710248847056398d), radius: 0.8878154752864361d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36326757242018115d, y: 0.688287163293702d), radius: 0.627538725890209d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7144165861810962d, y: 0.6967276704916234d), radius: 0.44462939735700313d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048659025040252324d, y: 0.0035789881822670955d), radius: 0.36161366212345514d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9106323247885202d, y: 0.6503769465766999d), radius: 0.7297698021211377d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1387769211603742d, y: 0.18995040660627738d), radius: 0.5634613904586976d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9103084546230661d, y: 0.8912534008680807d), radius: 0.3343716096375715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9691871724580161d, y: 0.9192777690873536d), radius: 0.42628534914583704d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13996788097365065d, y: 0.5109261959109582d), radius: 0.7942810449888615d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29894677474251063d, y: 0.500400859459664d), radius: 0.12491452078474419d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33712955675279d, y: 0.9525365499899365d), radius: 0.9511608598578627d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.839604711589256d, y: 0.0870708528009283d), radius: 0.7542387039274857d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06634210277377939d, y: 0.07103925075940187d), radius: 0.20772838240962566d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7122369969973137d, y: 0.07728737492490867d), radius: 0.8149763622789524d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24919367393220115d, y: 0.8416576167164747d), radius: 0.7976556650591172d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4021220160704353d, y: 0.5712492455102088d), radius: 0.8144767806535919d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7579305800622153d, y: 0.9451278852309739d), radius: 0.5994181026614095d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5817394506523561d, y: 0.323083587952256d), radius: 0.15512992280572924d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7726993213229715d, y: 0.6029344321720734d), radius: 0.17841116678893143d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1600719150866775d, y: 0.33668917234999063d), radius: 0.28402664918860876d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04739501809196911d, y: 0.8251534711231286d), radius: 0.9863633794611761d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8466078330580277d, y: 0.4457770688148266d), radius: 0.04933540148287041d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06740156329544855d, y: 0.19397595655605582d), radius: 0.916363514262586d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763098567000287d, y: 0.3625684369868769d), radius: 0.9616173752846242d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11917959189055882d, y: 0.3945790632449615d), radius: 0.013600580236084903d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5052654713901829d, y: 0.21178433530719043d), radius: 0.36580191078227886d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3969944218040071d, y: 0.6075739963386394d), radius: 0.193474248462557d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6422035220410903d, y: 0.033465532318443736d), radius: 0.6264304288060756d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10975443612234947d, y: 0.9124518278351986d), radius: 0.7741053373996198d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6756292287084209d, y: 0.6155721842304285d), radius: 0.23002752558974127d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9024310412426395d, y: 0.32461859209113786d), radius: 0.18695696719630395d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4711996004819643d, y: 0.5142698825698263d), radius: 0.10398455516456229d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9200018568007966d, y: 0.2776725333039193d), radius: 0.336121914796493d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8875690035088046d, y: 0.2647482827722617d), radius: 0.818996118142161d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028503881769481598d, y: 0.9519555753189927d), radius: 0.9977310734656857d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45416876631501935d, y: 0.5682053598679282d), radius: 0.9080319057817697d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 175,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2895254007086505d, y: 0.6106436781167502d), radius: 0.5228386812273061d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.167510188258723d, y: 0.8557359895797498d), radius: 0.8762670271388469d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6352082258821913d, y: 0.7431048301454031d), radius: 0.9140183135510458d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18570170434805022d, y: 0.7379934389115348d), radius: 0.6544909865209428d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9317617403577906d, y: 0.7920325187125874d), radius: 0.22161684632205148d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5597150998494843d, y: 0.38797299390733786d), radius: 0.009137101248291923d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7321684487117602d, y: 0.9302233211438761d), radius: 0.6611100359659807d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9048091835958075d, y: 0.7854329289178372d), radius: 0.7183840474405278d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0786900051212065d, y: 0.9776809583487968d), radius: 0.9185622487138698d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24278306521661597d, y: 0.06956973618038198d), radius: 0.24274208484468696d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4517530522449942d, y: 0.10540789005936446d), radius: 0.833626852956573d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8114148805860226d, y: 0.768986278518373d), radius: 0.051317501356869966d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 182,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.186010697242165d, y: 0.5515059660383045d), radius: 0.9934507296423352d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05149472778806896d, y: 0.06411253952759255d), radius: 0.15298790741609614d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18614488663768858d, y: 0.024785504440068884d), radius: 0.3696503137948316d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07818524881642974d, y: 0.4280977762793393d), radius: 0.8027487625370215d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4217307155007699d, y: 0.8081763098296368d), radius: 0.11444883502210557d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25328126886999347d, y: 0.7331604628415183d), radius: 0.23508943919542324d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09854052097314048d, y: 0.5611061364399073d), radius: 0.24292014780094384d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47065867000912276d, y: 0.313522615860359d), radius: 0.3830730471687728d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 185,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5342821447568803d, y: 0.6660854251968975d), radius: 0.0636182391681609d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16913788464936463d, y: 0.4593097708274012d), radius: 0.040822668190855116d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.033855783811869156d, y: 0.5334262773196277d), radius: 0.7621238300608821d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4152352473909685d, y: 0.6556459753164513d), radius: 0.9352300326362711d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14129810919623143d, y: 0.9079588502062748d), radius: 0.6001266473784809d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7247223890941982d, y: 0.517373218375824d), radius: 0.8690504297937375d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13178413808808487d, y: 0.2980541489506784d), radius: 0.9008611265039538d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10400276430905231d, y: 0.6797642561289725d), radius: 0.8356450484270763d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9452732639431908d, y: 0.7963507479200492d), radius: 0.9788879246486212d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6090587755990509d, y: 0.7972253055234371d), radius: 0.35279884678125273d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17235738834214054d, y: 0.4451905766287364d), radius: 0.7233827509160542d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7245558588573094d, y: 0.45792447611729503d), radius: 0.37839989659262663d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 189,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9812981368663825d, y: 0.4224882683279283d), radius: 0.9859563998833034d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1444872448461635d, y: 0.21136307469865356d), radius: 0.616376423557687d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19865518427971252d, y: 0.4754301094044142d), radius: 0.4104976419586446d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9168496281787389d, y: 0.6900330705712138d), radius: 0.6182381719258505d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02039434453965805d, y: 0.8063218196942527d), radius: 0.7007561093342675d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7774031728467091d, y: 0.6067187249045207d), radius: 0.6676290320364099d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05031046879670342d, y: 0.9598820781980648d), radius: 0.4408815814878546d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7225243649217274d, y: 0.15028999120616182d), radius: 0.28823166059897976d), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5495332298321635d, y: 0.6297129547491941d), radius: 0.785442468117725d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11408225715694142d, y: 4.881339091056258E-05d), radius: 0.5269252719434518d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7108530622544278d, y: 0.8951520511993908d), radius: 0.9364780316701499d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8259091233184009d, y: 0.5476237726143243d), radius: 0.2748864013479173d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6609484012143018d, y: 0.33642299643989815d), radius: 0.29577987145155715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8286625068589606d, y: 0.006313637972943931d), radius: 0.6505865468259063d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.741716369995408d, y: 0.15933934358885726d), radius: 0.31966047794013197d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8272235265254797d, y: 0.09792288205318544d), radius: 0.6728777450781626d), }, }));
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD2E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD2E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr2.Value = 6;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 132;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 137, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 22, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 101, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 17, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 175, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI), typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

