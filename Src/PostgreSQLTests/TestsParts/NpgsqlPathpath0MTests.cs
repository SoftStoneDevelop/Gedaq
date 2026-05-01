

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
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35209537341659025d, y: 0.47546663114156706d), new NpgsqlTypes.NpgsqlPoint(x: 0.25571090538974184d, y: 0.7028979753616468d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345882858796333d, y: 0.12183233927927406d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9446148040001185d, y: 0.9309741886439206d), new NpgsqlTypes.NpgsqlPoint(x: 0.08685333639852d, y: 0.581969363609585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856039877012188d, y: 0.3072731944452498d)),
},
            new NpgsqlPathpath0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5175448125630463d, y: 0.17277784720058997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564735309963228d, y: 0.7020774064865353d), new NpgsqlTypes.NpgsqlPoint(x: 0.12321006166786141d, y: 0.748264763294212d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48576069845450964d, y: 0.8525628240804018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647291894006673d, y: 0.4592804749134033d), new NpgsqlTypes.NpgsqlPoint(x: 0.007675222708932838d, y: 0.2506470254086842d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20052294103808155d, y: 0.25854847654061586d), new NpgsqlTypes.NpgsqlPoint(x: 0.014356117681621705d, y: 0.9176021040102161d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638983111146528d, y: 0.8481632732114008d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48192887029670106d, y: 0.5528658822237705d), new NpgsqlTypes.NpgsqlPoint(x: 0.1446583000101369d, y: 0.7747865311368274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263761330030682d, y: 0.23837321756203111d)),
},
            new NpgsqlPathpath0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3026162220494498d, y: 0.350477568837372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234842779755631d, y: 0.46197472017873187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984536761061119d, y: 0.8548491058347933d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2042011999121407d, y: 0.6053828490848101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560086391795662d, y: 0.2571046721433803d), new NpgsqlTypes.NpgsqlPoint(x: 0.722208512439015d, y: 0.8906977725651746d)),
},
            new NpgsqlPathpath0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9879972456257489d, y: 0.8606907216211344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664313050853986d, y: 0.5924936656361857d), new NpgsqlTypes.NpgsqlPoint(x: 0.24504163216651553d, y: 0.7083991627492888d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5405667379259562d, y: 0.14245042634857263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7175883767782174d, y: 0.886056733530023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303406183510233d, y: 0.43497556699223494d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2623953686848459d, y: 0.7423832635779105d), new NpgsqlTypes.NpgsqlPoint(x: 0.865191602394138d, y: 0.6535004040052159d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932811336169064d, y: 0.47596456810896126d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9290229601915437d, y: 0.5929683781985692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114234399379076d, y: 0.962339763120254d), new NpgsqlTypes.NpgsqlPoint(x: 0.44864817126051526d, y: 0.028937226137559557d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3542113823087214d, y: 0.4684579465623122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216950437163246d, y: 0.5269984527525277d), new NpgsqlTypes.NpgsqlPoint(x: 0.22838599579068197d, y: 0.810543676671176d)),
},
            new NpgsqlPathpath0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8866248778701266d, y: 0.11780038051625574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393984969654555d, y: 0.6517120729783036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603389356268242d, y: 0.6826237449461715d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4613291472553669d, y: 0.9824815824035356d), new NpgsqlTypes.NpgsqlPoint(x: 0.33252876825302147d, y: 0.5145467200320647d), new NpgsqlTypes.NpgsqlPoint(x: 0.16431925465441788d, y: 0.8686603775800343d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9193464016678929d, y: 0.8395275115302098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7683511469036414d, y: 0.7726116163244684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054706752652582d, y: 0.48142561341034995d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09847288537037147d, y: 0.23894577852904808d), new NpgsqlTypes.NpgsqlPoint(x: 0.10113588790305472d, y: 0.9867304123614179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263849818453603d, y: 0.7415998942290022d)),
},
            new NpgsqlPathpath0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014154311573025935d, y: 0.9116102331846594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3804621258338441d, y: 0.49308127318517303d), new NpgsqlTypes.NpgsqlPoint(x: 0.535510031446168d, y: 0.24990191001023399d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061811278452529095d, y: 0.6699179235540644d), new NpgsqlTypes.NpgsqlPoint(x: 0.08977946973137874d, y: 0.5714571889154871d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941469639757565d, y: 0.4365432045331863d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6828495608405527d, y: 0.15642953722082054d), new NpgsqlTypes.NpgsqlPoint(x: 0.802501305242633d, y: 0.013476057359143367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525868063247042d, y: 0.9517715708889356d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06270145854937381d, y: 0.5776064608483001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973403183977285d, y: 0.8209824142475202d), new NpgsqlTypes.NpgsqlPoint(x: 0.46069148035785534d, y: 0.35508824164980535d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48880445334498135d, y: 0.7292197949761421d), new NpgsqlTypes.NpgsqlPoint(x: 0.042381527252825735d, y: 0.7913206677536091d), new NpgsqlTypes.NpgsqlPoint(x: 0.06942785109884586d, y: 0.964990808101224d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1878554264176382d, y: 0.5726895173082798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977636361173062d, y: 0.4774936850831366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399420934877246d, y: 0.278677737859649d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7940774613881583d, y: 0.07829531419898894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239357416084402d, y: 0.5312150114273236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927804290584832d, y: 0.8978594736187294d)),
},
            new NpgsqlPathpath0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9803505750575678d, y: 0.5658328206774463d), new NpgsqlTypes.NpgsqlPoint(x: 0.06209988343296258d, y: 0.016163363765037686d), new NpgsqlTypes.NpgsqlPoint(x: 0.45810623114290927d, y: 0.4289169202425369d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47564916978786376d, y: 0.16766459102510767d), new NpgsqlTypes.NpgsqlPoint(x: 0.06532020621839685d, y: 0.9647832976345639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106539445069431d, y: 0.13310249245054895d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9971823376893558d, y: 0.3614925411771295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238436569001013d, y: 0.49956905231678206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583300551600973d, y: 0.6214297998836543d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34213278444859074d, y: 0.8407429210338329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517497547892134d, y: 0.3223216649468513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653372476287576d, y: 0.5542162961661293d)),
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044752833674538d, y: 0.1597831343548387d), new NpgsqlTypes.NpgsqlPoint(x: 0.895369374810868d, y: 0.5107852773529568d), new NpgsqlTypes.NpgsqlPoint(x: 0.46811734163187924d, y: 0.25116238309932404d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9854007689247826d, y: 0.40587023240876896d), new NpgsqlTypes.NpgsqlPoint(x: 0.874151524285368d, y: 0.598805038818441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623354589831462d, y: 0.6581308748399669d)),
},
            new NpgsqlPathpath0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22574106187899023d, y: 0.23695843880974166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5212740236583479d, y: 0.26155836480504635d), new NpgsqlTypes.NpgsqlPoint(x: 0.45292225666313324d, y: 0.8124334906306977d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18520126019803673d, y: 0.4661370703640124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402170165850944d, y: 0.9672887031594577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4627124647529113d, y: 0.018063124774899353d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6549453095739549d, y: 0.7830603481144292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221859230197322d, y: 0.13472439026644312d), new NpgsqlTypes.NpgsqlPoint(x: 0.22012201459308023d, y: 0.8099538005456491d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02046513574965092d, y: 0.6166428721406704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5594396680098803d, y: 0.6664638346135123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599124824449499d, y: 0.25572448519891533d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2922915225546696d, y: 0.7476714971422934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651408389626732d, y: 0.38998717854779186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796151537373757d, y: 0.21539567831637652d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21338762683056212d, y: 0.8410617691856964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4609558096396349d, y: 0.5022330542037134d), new NpgsqlTypes.NpgsqlPoint(x: 0.3233719926409543d, y: 0.15412520114695327d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47446985437360323d, y: 0.03469375070030967d), new NpgsqlTypes.NpgsqlPoint(x: 0.39408975228188403d, y: 0.3389189402390119d), new NpgsqlTypes.NpgsqlPoint(x: 0.29777610621445805d, y: 0.11796633995003558d)),
},
            new NpgsqlPathpath0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9457303131302934d, y: 0.7478131598436553d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843226059263851d, y: 0.6346517611601376d), new NpgsqlTypes.NpgsqlPoint(x: 0.46794430007947574d, y: 0.373502445511697d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8238263512897884d, y: 0.6085875902268565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846375698352777d, y: 0.6603600377075239d), new NpgsqlTypes.NpgsqlPoint(x: 0.3973461904450971d, y: 0.5969688926256768d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5418345008460176d, y: 0.039748909407689936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843708018304888d, y: 0.5759268329824668d), new NpgsqlTypes.NpgsqlPoint(x: 0.22910251903393353d, y: 0.943859110231315d)),
},
            new NpgsqlPathpath0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521297026153608d, y: 0.13571557135433698d), new NpgsqlTypes.NpgsqlPoint(x: 0.030042161726432703d, y: 0.12376400379496177d), new NpgsqlTypes.NpgsqlPoint(x: 0.2568915568775767d, y: 0.6038463318583838d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788293128880531d, y: 0.556460707597535d), new NpgsqlTypes.NpgsqlPoint(x: 0.1391857820788236d, y: 0.6871874195192079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14245791853339185d, y: 0.34118266376828665d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33350527078427994d, y: 0.9909842863270056d), new NpgsqlTypes.NpgsqlPoint(x: 0.44875040504923003d, y: 0.5210192604239664d), new NpgsqlTypes.NpgsqlPoint(x: 0.88830096898542d, y: 0.8000442975015459d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.575553768275364d, y: 0.11596621858868283d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761053022681085d, y: 0.3672532054244614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296962712517393d, y: 0.12554972965275246d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08620576849519612d, y: 0.22060067532261873d), new NpgsqlTypes.NpgsqlPoint(x: 0.555985944515628d, y: 0.05190219511184058d), new NpgsqlTypes.NpgsqlPoint(x: 0.16899316613625215d, y: 0.12994792666802624d)),
},
            new NpgsqlPathpath0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6981516154345798d, y: 0.9497982480320768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868285533672938d, y: 0.06004273288340489d), new NpgsqlTypes.NpgsqlPoint(x: 0.662342713730677d, y: 0.6266638937520316d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33485934140261175d, y: 0.5264005878235185d), new NpgsqlTypes.NpgsqlPoint(x: 0.057857585242479415d, y: 0.5687463600810885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001048028309042d, y: 0.5056064431160803d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3030891334897179d, y: 0.38192880399727447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4187425386071626d, y: 0.1276264583179917d), new NpgsqlTypes.NpgsqlPoint(x: 0.35691877759503443d, y: 0.9712047599219875d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1766195764105586d, y: 0.7774045181853118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725774220044268d, y: 0.5425522982665213d), new NpgsqlTypes.NpgsqlPoint(x: 0.27147782469145854d, y: 0.10909003796515993d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4971977956178143d, y: 0.9315152555252635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663090597960199d, y: 0.45605434398770106d), new NpgsqlTypes.NpgsqlPoint(x: 0.27326232061315425d, y: 0.7432344306253247d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2560689036422167d, y: 0.7971830809528032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5479761142998704d, y: 0.9084232743733632d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436418052793761d, y: 0.0059361410569044315d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22299693185573644d, y: 0.7117657889086229d), new NpgsqlTypes.NpgsqlPoint(x: 0.5919673483450357d, y: 0.8738765973353481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879075115225596d, y: 0.43800816317682667d)),
},
            new NpgsqlPathpath0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8044107603807604d, y: 0.753709187584006d), new NpgsqlTypes.NpgsqlPoint(x: 0.719128148764767d, y: 0.27637014900714074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664618364049832d, y: 0.27308689822903287d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046977918482109415d, y: 0.2504928045053306d), new NpgsqlTypes.NpgsqlPoint(x: 0.07740907058197499d, y: 0.5401826832327037d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420540332207605d, y: 0.5490339163765142d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18576364454673255d, y: 0.6593719417758322d), new NpgsqlTypes.NpgsqlPoint(x: 0.47679242480768425d, y: 0.639948874341045d), new NpgsqlTypes.NpgsqlPoint(x: 0.2227892285234716d, y: 0.7800778833425385d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.224615406399156d, y: 0.24332295524022896d), new NpgsqlTypes.NpgsqlPoint(x: 0.37261823354220847d, y: 0.23645463763379393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060871702435462d, y: 0.7528281443841689d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9356246636533905d, y: 0.7582217957860197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534181678266044d, y: 0.21456178178825502d), new NpgsqlTypes.NpgsqlPoint(x: 0.14418969988550612d, y: 0.4063001628726859d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06992129971568928d, y: 0.8250427316540535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800285852909845d, y: 0.05459718049457807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7992917143521189d, y: 0.12006466028888518d)),
},
            new NpgsqlPathpath0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.984136898768366d, y: 0.2105157521555131d), new NpgsqlTypes.NpgsqlPoint(x: 0.5645812657956593d, y: 0.7892052729514013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486519854384569d, y: 0.1489816461146477d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6233595655805338d, y: 0.14935440156212265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960612429573947d, y: 0.535707591561014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143909893649365d, y: 0.0026741989162846203d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8562523803507812d, y: 0.8313812524615303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665168503716705d, y: 0.07592767725296146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364672943860608d, y: 0.9092227724337347d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.990963904811562d, y: 0.7878906173570628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231120497441295d, y: 0.8409955102287862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570531147008029d, y: 0.14868372956512532d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.649686353539856d, y: 0.6815013355558932d), new NpgsqlTypes.NpgsqlPoint(x: 0.47286127873440553d, y: 0.060357645890701694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395881103610399d, y: 0.8262972228369636d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4695633639572456d, y: 0.6119374637147514d), new NpgsqlTypes.NpgsqlPoint(x: 0.02346351594407825d, y: 0.578655376964386d), new NpgsqlTypes.NpgsqlPoint(x: 0.11314352215537016d, y: 0.44826849106017175d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44249261259371286d, y: 0.583006664688494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865041143884451d, y: 0.569844198526881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038494886451872d, y: 0.8198442505642396d)),
},
            new NpgsqlPathpath0M
{
    Id = 180,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07322954208777044d, y: 0.5404261316974946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693631928944377d, y: 0.8922481455957895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754662669980463d, y: 0.7073920017646577d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 181,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7951823884568169d, y: 0.6389070120157734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940109337664276d, y: 0.8501950058712086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143687242601776d, y: 0.039254027731590035d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9899080626465472d, y: 0.34678559236554274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7994168122592763d, y: 0.8490116652889592d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881367412862624d, y: 0.3161578784999568d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47412890523755724d, y: 0.2316593174714766d), new NpgsqlTypes.NpgsqlPoint(x: 0.32633305585421224d, y: 0.012443804367065492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122276467992545d, y: 0.8849117391327046d)),
},
            new NpgsqlPathpath0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006895657118501153d, y: 0.07855364651949226d), new NpgsqlTypes.NpgsqlPoint(x: 0.25784215700972235d, y: 0.9070925342485475d), new NpgsqlTypes.NpgsqlPoint(x: 0.598920006211906d, y: 0.4612892140874888d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 187,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43536756891646744d, y: 0.16980264158921599d), new NpgsqlTypes.NpgsqlPoint(x: 0.47203855331291944d, y: 0.6778458116224796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553597910927659d, y: 0.14670644626809404d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36854202502915967d, y: 0.7208656306640092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327652300393105d, y: 0.6744690028230892d), new NpgsqlTypes.NpgsqlPoint(x: 0.33025479853085604d, y: 0.9788508541852845d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5236907373145103d, y: 0.7575643770954698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804484556176221d, y: 0.0009973413373101092d), new NpgsqlTypes.NpgsqlPoint(x: 0.09752042972233621d, y: 0.14096816788405886d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 193,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316310750749927d, y: 0.4056818281609299d), new NpgsqlTypes.NpgsqlPoint(x: 0.2290543645702393d, y: 0.37248421468990534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599211624167803d, y: 0.9740994847666417d)),
    ModelInner = null,
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3542113823087214d, y: 0.4684579465623122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216950437163246d, y: 0.5269984527525277d), new NpgsqlTypes.NpgsqlPoint(x: 0.22838599579068197d, y: 0.810543676671176d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09847288537037147d, y: 0.23894577852904808d), new NpgsqlTypes.NpgsqlPoint(x: 0.10113588790305472d, y: 0.9867304123614179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263849818453603d, y: 0.7415998942290022d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7940774613881583d, y: 0.07829531419898894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239357416084402d, y: 0.5312150114273236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927804290584832d, y: 0.8978594736187294d))));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34213278444859074d, y: 0.8407429210338329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517497547892134d, y: 0.3223216649468513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653372476287576d, y: 0.5542162961661293d))));
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 115, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 94, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 107, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 107, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 159, query1, 183, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 95, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[32],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 88, 181))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 148, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

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
                NpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35209537341659025d, y: 0.47546663114156706d), new NpgsqlTypes.NpgsqlPoint(x: 0.25571090538974184d, y: 0.7028979753616468d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345882858796333d, y: 0.12183233927927406d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9446148040001185d, y: 0.9309741886439206d), new NpgsqlTypes.NpgsqlPoint(x: 0.08685333639852d, y: 0.581969363609585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856039877012188d, y: 0.3072731944452498d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5175448125630463d, y: 0.17277784720058997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564735309963228d, y: 0.7020774064865353d), new NpgsqlTypes.NpgsqlPoint(x: 0.12321006166786141d, y: 0.748264763294212d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48576069845450964d, y: 0.8525628240804018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647291894006673d, y: 0.4592804749134033d), new NpgsqlTypes.NpgsqlPoint(x: 0.007675222708932838d, y: 0.2506470254086842d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20052294103808155d, y: 0.25854847654061586d), new NpgsqlTypes.NpgsqlPoint(x: 0.014356117681621705d, y: 0.9176021040102161d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638983111146528d, y: 0.8481632732114008d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48192887029670106d, y: 0.5528658822237705d), new NpgsqlTypes.NpgsqlPoint(x: 0.1446583000101369d, y: 0.7747865311368274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263761330030682d, y: 0.23837321756203111d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3026162220494498d, y: 0.350477568837372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234842779755631d, y: 0.46197472017873187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984536761061119d, y: 0.8548491058347933d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2042011999121407d, y: 0.6053828490848101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560086391795662d, y: 0.2571046721433803d), new NpgsqlTypes.NpgsqlPoint(x: 0.722208512439015d, y: 0.8906977725651746d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9879972456257489d, y: 0.8606907216211344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664313050853986d, y: 0.5924936656361857d), new NpgsqlTypes.NpgsqlPoint(x: 0.24504163216651553d, y: 0.7083991627492888d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5405667379259562d, y: 0.14245042634857263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7175883767782174d, y: 0.886056733530023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303406183510233d, y: 0.43497556699223494d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2623953686848459d, y: 0.7423832635779105d), new NpgsqlTypes.NpgsqlPoint(x: 0.865191602394138d, y: 0.6535004040052159d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932811336169064d, y: 0.47596456810896126d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9290229601915437d, y: 0.5929683781985692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114234399379076d, y: 0.962339763120254d), new NpgsqlTypes.NpgsqlPoint(x: 0.44864817126051526d, y: 0.028937226137559557d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3542113823087214d, y: 0.4684579465623122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216950437163246d, y: 0.5269984527525277d), new NpgsqlTypes.NpgsqlPoint(x: 0.22838599579068197d, y: 0.810543676671176d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8866248778701266d, y: 0.11780038051625574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393984969654555d, y: 0.6517120729783036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603389356268242d, y: 0.6826237449461715d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4613291472553669d, y: 0.9824815824035356d), new NpgsqlTypes.NpgsqlPoint(x: 0.33252876825302147d, y: 0.5145467200320647d), new NpgsqlTypes.NpgsqlPoint(x: 0.16431925465441788d, y: 0.8686603775800343d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9193464016678929d, y: 0.8395275115302098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7683511469036414d, y: 0.7726116163244684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054706752652582d, y: 0.48142561341034995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09847288537037147d, y: 0.23894577852904808d), new NpgsqlTypes.NpgsqlPoint(x: 0.10113588790305472d, y: 0.9867304123614179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263849818453603d, y: 0.7415998942290022d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014154311573025935d, y: 0.9116102331846594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3804621258338441d, y: 0.49308127318517303d), new NpgsqlTypes.NpgsqlPoint(x: 0.535510031446168d, y: 0.24990191001023399d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061811278452529095d, y: 0.6699179235540644d), new NpgsqlTypes.NpgsqlPoint(x: 0.08977946973137874d, y: 0.5714571889154871d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941469639757565d, y: 0.4365432045331863d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6828495608405527d, y: 0.15642953722082054d), new NpgsqlTypes.NpgsqlPoint(x: 0.802501305242633d, y: 0.013476057359143367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525868063247042d, y: 0.9517715708889356d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06270145854937381d, y: 0.5776064608483001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973403183977285d, y: 0.8209824142475202d), new NpgsqlTypes.NpgsqlPoint(x: 0.46069148035785534d, y: 0.35508824164980535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48880445334498135d, y: 0.7292197949761421d), new NpgsqlTypes.NpgsqlPoint(x: 0.042381527252825735d, y: 0.7913206677536091d), new NpgsqlTypes.NpgsqlPoint(x: 0.06942785109884586d, y: 0.964990808101224d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1878554264176382d, y: 0.5726895173082798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977636361173062d, y: 0.4774936850831366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399420934877246d, y: 0.278677737859649d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7940774613881583d, y: 0.07829531419898894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239357416084402d, y: 0.5312150114273236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927804290584832d, y: 0.8978594736187294d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9803505750575678d, y: 0.5658328206774463d), new NpgsqlTypes.NpgsqlPoint(x: 0.06209988343296258d, y: 0.016163363765037686d), new NpgsqlTypes.NpgsqlPoint(x: 0.45810623114290927d, y: 0.4289169202425369d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47564916978786376d, y: 0.16766459102510767d), new NpgsqlTypes.NpgsqlPoint(x: 0.06532020621839685d, y: 0.9647832976345639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106539445069431d, y: 0.13310249245054895d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9971823376893558d, y: 0.3614925411771295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238436569001013d, y: 0.49956905231678206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583300551600973d, y: 0.6214297998836543d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34213278444859074d, y: 0.8407429210338329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517497547892134d, y: 0.3223216649468513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653372476287576d, y: 0.5542162961661293d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044752833674538d, y: 0.1597831343548387d), new NpgsqlTypes.NpgsqlPoint(x: 0.895369374810868d, y: 0.5107852773529568d), new NpgsqlTypes.NpgsqlPoint(x: 0.46811734163187924d, y: 0.25116238309932404d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9854007689247826d, y: 0.40587023240876896d), new NpgsqlTypes.NpgsqlPoint(x: 0.874151524285368d, y: 0.598805038818441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623354589831462d, y: 0.6581308748399669d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22574106187899023d, y: 0.23695843880974166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5212740236583479d, y: 0.26155836480504635d), new NpgsqlTypes.NpgsqlPoint(x: 0.45292225666313324d, y: 0.8124334906306977d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18520126019803673d, y: 0.4661370703640124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402170165850944d, y: 0.9672887031594577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4627124647529113d, y: 0.018063124774899353d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6549453095739549d, y: 0.7830603481144292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221859230197322d, y: 0.13472439026644312d), new NpgsqlTypes.NpgsqlPoint(x: 0.22012201459308023d, y: 0.8099538005456491d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02046513574965092d, y: 0.6166428721406704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5594396680098803d, y: 0.6664638346135123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599124824449499d, y: 0.25572448519891533d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2922915225546696d, y: 0.7476714971422934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651408389626732d, y: 0.38998717854779186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796151537373757d, y: 0.21539567831637652d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21338762683056212d, y: 0.8410617691856964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4609558096396349d, y: 0.5022330542037134d), new NpgsqlTypes.NpgsqlPoint(x: 0.3233719926409543d, y: 0.15412520114695327d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47446985437360323d, y: 0.03469375070030967d), new NpgsqlTypes.NpgsqlPoint(x: 0.39408975228188403d, y: 0.3389189402390119d), new NpgsqlTypes.NpgsqlPoint(x: 0.29777610621445805d, y: 0.11796633995003558d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9457303131302934d, y: 0.7478131598436553d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843226059263851d, y: 0.6346517611601376d), new NpgsqlTypes.NpgsqlPoint(x: 0.46794430007947574d, y: 0.373502445511697d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8238263512897884d, y: 0.6085875902268565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846375698352777d, y: 0.6603600377075239d), new NpgsqlTypes.NpgsqlPoint(x: 0.3973461904450971d, y: 0.5969688926256768d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5418345008460176d, y: 0.039748909407689936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843708018304888d, y: 0.5759268329824668d), new NpgsqlTypes.NpgsqlPoint(x: 0.22910251903393353d, y: 0.943859110231315d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521297026153608d, y: 0.13571557135433698d), new NpgsqlTypes.NpgsqlPoint(x: 0.030042161726432703d, y: 0.12376400379496177d), new NpgsqlTypes.NpgsqlPoint(x: 0.2568915568775767d, y: 0.6038463318583838d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788293128880531d, y: 0.556460707597535d), new NpgsqlTypes.NpgsqlPoint(x: 0.1391857820788236d, y: 0.6871874195192079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14245791853339185d, y: 0.34118266376828665d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33350527078427994d, y: 0.9909842863270056d), new NpgsqlTypes.NpgsqlPoint(x: 0.44875040504923003d, y: 0.5210192604239664d), new NpgsqlTypes.NpgsqlPoint(x: 0.88830096898542d, y: 0.8000442975015459d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.575553768275364d, y: 0.11596621858868283d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761053022681085d, y: 0.3672532054244614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296962712517393d, y: 0.12554972965275246d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08620576849519612d, y: 0.22060067532261873d), new NpgsqlTypes.NpgsqlPoint(x: 0.555985944515628d, y: 0.05190219511184058d), new NpgsqlTypes.NpgsqlPoint(x: 0.16899316613625215d, y: 0.12994792666802624d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6981516154345798d, y: 0.9497982480320768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868285533672938d, y: 0.06004273288340489d), new NpgsqlTypes.NpgsqlPoint(x: 0.662342713730677d, y: 0.6266638937520316d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33485934140261175d, y: 0.5264005878235185d), new NpgsqlTypes.NpgsqlPoint(x: 0.057857585242479415d, y: 0.5687463600810885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001048028309042d, y: 0.5056064431160803d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3030891334897179d, y: 0.38192880399727447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4187425386071626d, y: 0.1276264583179917d), new NpgsqlTypes.NpgsqlPoint(x: 0.35691877759503443d, y: 0.9712047599219875d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1766195764105586d, y: 0.7774045181853118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725774220044268d, y: 0.5425522982665213d), new NpgsqlTypes.NpgsqlPoint(x: 0.27147782469145854d, y: 0.10909003796515993d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4971977956178143d, y: 0.9315152555252635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663090597960199d, y: 0.45605434398770106d), new NpgsqlTypes.NpgsqlPoint(x: 0.27326232061315425d, y: 0.7432344306253247d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2560689036422167d, y: 0.7971830809528032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5479761142998704d, y: 0.9084232743733632d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436418052793761d, y: 0.0059361410569044315d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22299693185573644d, y: 0.7117657889086229d), new NpgsqlTypes.NpgsqlPoint(x: 0.5919673483450357d, y: 0.8738765973353481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879075115225596d, y: 0.43800816317682667d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8044107603807604d, y: 0.753709187584006d), new NpgsqlTypes.NpgsqlPoint(x: 0.719128148764767d, y: 0.27637014900714074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664618364049832d, y: 0.27308689822903287d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046977918482109415d, y: 0.2504928045053306d), new NpgsqlTypes.NpgsqlPoint(x: 0.07740907058197499d, y: 0.5401826832327037d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420540332207605d, y: 0.5490339163765142d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18576364454673255d, y: 0.6593719417758322d), new NpgsqlTypes.NpgsqlPoint(x: 0.47679242480768425d, y: 0.639948874341045d), new NpgsqlTypes.NpgsqlPoint(x: 0.2227892285234716d, y: 0.7800778833425385d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.224615406399156d, y: 0.24332295524022896d), new NpgsqlTypes.NpgsqlPoint(x: 0.37261823354220847d, y: 0.23645463763379393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060871702435462d, y: 0.7528281443841689d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9356246636533905d, y: 0.7582217957860197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534181678266044d, y: 0.21456178178825502d), new NpgsqlTypes.NpgsqlPoint(x: 0.14418969988550612d, y: 0.4063001628726859d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06992129971568928d, y: 0.8250427316540535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800285852909845d, y: 0.05459718049457807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7992917143521189d, y: 0.12006466028888518d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.984136898768366d, y: 0.2105157521555131d), new NpgsqlTypes.NpgsqlPoint(x: 0.5645812657956593d, y: 0.7892052729514013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486519854384569d, y: 0.1489816461146477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6233595655805338d, y: 0.14935440156212265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960612429573947d, y: 0.535707591561014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143909893649365d, y: 0.0026741989162846203d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8562523803507812d, y: 0.8313812524615303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665168503716705d, y: 0.07592767725296146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364672943860608d, y: 0.9092227724337347d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.990963904811562d, y: 0.7878906173570628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231120497441295d, y: 0.8409955102287862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570531147008029d, y: 0.14868372956512532d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.649686353539856d, y: 0.6815013355558932d), new NpgsqlTypes.NpgsqlPoint(x: 0.47286127873440553d, y: 0.060357645890701694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395881103610399d, y: 0.8262972228369636d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4695633639572456d, y: 0.6119374637147514d), new NpgsqlTypes.NpgsqlPoint(x: 0.02346351594407825d, y: 0.578655376964386d), new NpgsqlTypes.NpgsqlPoint(x: 0.11314352215537016d, y: 0.44826849106017175d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44249261259371286d, y: 0.583006664688494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865041143884451d, y: 0.569844198526881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038494886451872d, y: 0.8198442505642396d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07322954208777044d, y: 0.5404261316974946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693631928944377d, y: 0.8922481455957895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754662669980463d, y: 0.7073920017646577d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7951823884568169d, y: 0.6389070120157734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940109337664276d, y: 0.8501950058712086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143687242601776d, y: 0.039254027731590035d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9899080626465472d, y: 0.34678559236554274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7994168122592763d, y: 0.8490116652889592d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881367412862624d, y: 0.3161578784999568d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47412890523755724d, y: 0.2316593174714766d), new NpgsqlTypes.NpgsqlPoint(x: 0.32633305585421224d, y: 0.012443804367065492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122276467992545d, y: 0.8849117391327046d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006895657118501153d, y: 0.07855364651949226d), new NpgsqlTypes.NpgsqlPoint(x: 0.25784215700972235d, y: 0.9070925342485475d), new NpgsqlTypes.NpgsqlPoint(x: 0.598920006211906d, y: 0.4612892140874888d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43536756891646744d, y: 0.16980264158921599d), new NpgsqlTypes.NpgsqlPoint(x: 0.47203855331291944d, y: 0.6778458116224796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553597910927659d, y: 0.14670644626809404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36854202502915967d, y: 0.7208656306640092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327652300393105d, y: 0.6744690028230892d), new NpgsqlTypes.NpgsqlPoint(x: 0.33025479853085604d, y: 0.9788508541852845d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5236907373145103d, y: 0.7575643770954698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804484556176221d, y: 0.0009973413373101092d), new NpgsqlTypes.NpgsqlPoint(x: 0.09752042972233621d, y: 0.14096816788405886d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316310750749927d, y: 0.4056818281609299d), new NpgsqlTypes.NpgsqlPoint(x: 0.2290543645702393d, y: 0.37248421468990534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599211624167803d, y: 0.9740994847666417d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35209537341659025d, y: 0.47546663114156706d), new NpgsqlTypes.NpgsqlPoint(x: 0.25571090538974184d, y: 0.7028979753616468d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345882858796333d, y: 0.12183233927927406d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9446148040001185d, y: 0.9309741886439206d), new NpgsqlTypes.NpgsqlPoint(x: 0.08685333639852d, y: 0.581969363609585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856039877012188d, y: 0.3072731944452498d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5175448125630463d, y: 0.17277784720058997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564735309963228d, y: 0.7020774064865353d), new NpgsqlTypes.NpgsqlPoint(x: 0.12321006166786141d, y: 0.748264763294212d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48576069845450964d, y: 0.8525628240804018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647291894006673d, y: 0.4592804749134033d), new NpgsqlTypes.NpgsqlPoint(x: 0.007675222708932838d, y: 0.2506470254086842d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20052294103808155d, y: 0.25854847654061586d), new NpgsqlTypes.NpgsqlPoint(x: 0.014356117681621705d, y: 0.9176021040102161d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638983111146528d, y: 0.8481632732114008d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48192887029670106d, y: 0.5528658822237705d), new NpgsqlTypes.NpgsqlPoint(x: 0.1446583000101369d, y: 0.7747865311368274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263761330030682d, y: 0.23837321756203111d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3026162220494498d, y: 0.350477568837372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234842779755631d, y: 0.46197472017873187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984536761061119d, y: 0.8548491058347933d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2042011999121407d, y: 0.6053828490848101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560086391795662d, y: 0.2571046721433803d), new NpgsqlTypes.NpgsqlPoint(x: 0.722208512439015d, y: 0.8906977725651746d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9879972456257489d, y: 0.8606907216211344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664313050853986d, y: 0.5924936656361857d), new NpgsqlTypes.NpgsqlPoint(x: 0.24504163216651553d, y: 0.7083991627492888d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5405667379259562d, y: 0.14245042634857263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7175883767782174d, y: 0.886056733530023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303406183510233d, y: 0.43497556699223494d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2623953686848459d, y: 0.7423832635779105d), new NpgsqlTypes.NpgsqlPoint(x: 0.865191602394138d, y: 0.6535004040052159d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932811336169064d, y: 0.47596456810896126d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9290229601915437d, y: 0.5929683781985692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114234399379076d, y: 0.962339763120254d), new NpgsqlTypes.NpgsqlPoint(x: 0.44864817126051526d, y: 0.028937226137559557d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3542113823087214d, y: 0.4684579465623122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216950437163246d, y: 0.5269984527525277d), new NpgsqlTypes.NpgsqlPoint(x: 0.22838599579068197d, y: 0.810543676671176d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8866248778701266d, y: 0.11780038051625574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393984969654555d, y: 0.6517120729783036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603389356268242d, y: 0.6826237449461715d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4613291472553669d, y: 0.9824815824035356d), new NpgsqlTypes.NpgsqlPoint(x: 0.33252876825302147d, y: 0.5145467200320647d), new NpgsqlTypes.NpgsqlPoint(x: 0.16431925465441788d, y: 0.8686603775800343d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9193464016678929d, y: 0.8395275115302098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7683511469036414d, y: 0.7726116163244684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054706752652582d, y: 0.48142561341034995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09847288537037147d, y: 0.23894577852904808d), new NpgsqlTypes.NpgsqlPoint(x: 0.10113588790305472d, y: 0.9867304123614179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263849818453603d, y: 0.7415998942290022d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014154311573025935d, y: 0.9116102331846594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3804621258338441d, y: 0.49308127318517303d), new NpgsqlTypes.NpgsqlPoint(x: 0.535510031446168d, y: 0.24990191001023399d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061811278452529095d, y: 0.6699179235540644d), new NpgsqlTypes.NpgsqlPoint(x: 0.08977946973137874d, y: 0.5714571889154871d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941469639757565d, y: 0.4365432045331863d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6828495608405527d, y: 0.15642953722082054d), new NpgsqlTypes.NpgsqlPoint(x: 0.802501305242633d, y: 0.013476057359143367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525868063247042d, y: 0.9517715708889356d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06270145854937381d, y: 0.5776064608483001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973403183977285d, y: 0.8209824142475202d), new NpgsqlTypes.NpgsqlPoint(x: 0.46069148035785534d, y: 0.35508824164980535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48880445334498135d, y: 0.7292197949761421d), new NpgsqlTypes.NpgsqlPoint(x: 0.042381527252825735d, y: 0.7913206677536091d), new NpgsqlTypes.NpgsqlPoint(x: 0.06942785109884586d, y: 0.964990808101224d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1878554264176382d, y: 0.5726895173082798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977636361173062d, y: 0.4774936850831366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399420934877246d, y: 0.278677737859649d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7940774613881583d, y: 0.07829531419898894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239357416084402d, y: 0.5312150114273236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927804290584832d, y: 0.8978594736187294d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9803505750575678d, y: 0.5658328206774463d), new NpgsqlTypes.NpgsqlPoint(x: 0.06209988343296258d, y: 0.016163363765037686d), new NpgsqlTypes.NpgsqlPoint(x: 0.45810623114290927d, y: 0.4289169202425369d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47564916978786376d, y: 0.16766459102510767d), new NpgsqlTypes.NpgsqlPoint(x: 0.06532020621839685d, y: 0.9647832976345639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106539445069431d, y: 0.13310249245054895d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9971823376893558d, y: 0.3614925411771295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238436569001013d, y: 0.49956905231678206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583300551600973d, y: 0.6214297998836543d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34213278444859074d, y: 0.8407429210338329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517497547892134d, y: 0.3223216649468513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653372476287576d, y: 0.5542162961661293d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044752833674538d, y: 0.1597831343548387d), new NpgsqlTypes.NpgsqlPoint(x: 0.895369374810868d, y: 0.5107852773529568d), new NpgsqlTypes.NpgsqlPoint(x: 0.46811734163187924d, y: 0.25116238309932404d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9854007689247826d, y: 0.40587023240876896d), new NpgsqlTypes.NpgsqlPoint(x: 0.874151524285368d, y: 0.598805038818441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623354589831462d, y: 0.6581308748399669d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22574106187899023d, y: 0.23695843880974166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5212740236583479d, y: 0.26155836480504635d), new NpgsqlTypes.NpgsqlPoint(x: 0.45292225666313324d, y: 0.8124334906306977d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18520126019803673d, y: 0.4661370703640124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402170165850944d, y: 0.9672887031594577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4627124647529113d, y: 0.018063124774899353d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6549453095739549d, y: 0.7830603481144292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221859230197322d, y: 0.13472439026644312d), new NpgsqlTypes.NpgsqlPoint(x: 0.22012201459308023d, y: 0.8099538005456491d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02046513574965092d, y: 0.6166428721406704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5594396680098803d, y: 0.6664638346135123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599124824449499d, y: 0.25572448519891533d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2922915225546696d, y: 0.7476714971422934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651408389626732d, y: 0.38998717854779186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796151537373757d, y: 0.21539567831637652d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21338762683056212d, y: 0.8410617691856964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4609558096396349d, y: 0.5022330542037134d), new NpgsqlTypes.NpgsqlPoint(x: 0.3233719926409543d, y: 0.15412520114695327d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47446985437360323d, y: 0.03469375070030967d), new NpgsqlTypes.NpgsqlPoint(x: 0.39408975228188403d, y: 0.3389189402390119d), new NpgsqlTypes.NpgsqlPoint(x: 0.29777610621445805d, y: 0.11796633995003558d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9457303131302934d, y: 0.7478131598436553d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843226059263851d, y: 0.6346517611601376d), new NpgsqlTypes.NpgsqlPoint(x: 0.46794430007947574d, y: 0.373502445511697d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8238263512897884d, y: 0.6085875902268565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846375698352777d, y: 0.6603600377075239d), new NpgsqlTypes.NpgsqlPoint(x: 0.3973461904450971d, y: 0.5969688926256768d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5418345008460176d, y: 0.039748909407689936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843708018304888d, y: 0.5759268329824668d), new NpgsqlTypes.NpgsqlPoint(x: 0.22910251903393353d, y: 0.943859110231315d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521297026153608d, y: 0.13571557135433698d), new NpgsqlTypes.NpgsqlPoint(x: 0.030042161726432703d, y: 0.12376400379496177d), new NpgsqlTypes.NpgsqlPoint(x: 0.2568915568775767d, y: 0.6038463318583838d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788293128880531d, y: 0.556460707597535d), new NpgsqlTypes.NpgsqlPoint(x: 0.1391857820788236d, y: 0.6871874195192079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14245791853339185d, y: 0.34118266376828665d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33350527078427994d, y: 0.9909842863270056d), new NpgsqlTypes.NpgsqlPoint(x: 0.44875040504923003d, y: 0.5210192604239664d), new NpgsqlTypes.NpgsqlPoint(x: 0.88830096898542d, y: 0.8000442975015459d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.575553768275364d, y: 0.11596621858868283d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761053022681085d, y: 0.3672532054244614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296962712517393d, y: 0.12554972965275246d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08620576849519612d, y: 0.22060067532261873d), new NpgsqlTypes.NpgsqlPoint(x: 0.555985944515628d, y: 0.05190219511184058d), new NpgsqlTypes.NpgsqlPoint(x: 0.16899316613625215d, y: 0.12994792666802624d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6981516154345798d, y: 0.9497982480320768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868285533672938d, y: 0.06004273288340489d), new NpgsqlTypes.NpgsqlPoint(x: 0.662342713730677d, y: 0.6266638937520316d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33485934140261175d, y: 0.5264005878235185d), new NpgsqlTypes.NpgsqlPoint(x: 0.057857585242479415d, y: 0.5687463600810885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001048028309042d, y: 0.5056064431160803d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3030891334897179d, y: 0.38192880399727447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4187425386071626d, y: 0.1276264583179917d), new NpgsqlTypes.NpgsqlPoint(x: 0.35691877759503443d, y: 0.9712047599219875d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1766195764105586d, y: 0.7774045181853118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725774220044268d, y: 0.5425522982665213d), new NpgsqlTypes.NpgsqlPoint(x: 0.27147782469145854d, y: 0.10909003796515993d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4971977956178143d, y: 0.9315152555252635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663090597960199d, y: 0.45605434398770106d), new NpgsqlTypes.NpgsqlPoint(x: 0.27326232061315425d, y: 0.7432344306253247d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2560689036422167d, y: 0.7971830809528032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5479761142998704d, y: 0.9084232743733632d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436418052793761d, y: 0.0059361410569044315d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22299693185573644d, y: 0.7117657889086229d), new NpgsqlTypes.NpgsqlPoint(x: 0.5919673483450357d, y: 0.8738765973353481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879075115225596d, y: 0.43800816317682667d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8044107603807604d, y: 0.753709187584006d), new NpgsqlTypes.NpgsqlPoint(x: 0.719128148764767d, y: 0.27637014900714074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664618364049832d, y: 0.27308689822903287d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046977918482109415d, y: 0.2504928045053306d), new NpgsqlTypes.NpgsqlPoint(x: 0.07740907058197499d, y: 0.5401826832327037d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420540332207605d, y: 0.5490339163765142d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18576364454673255d, y: 0.6593719417758322d), new NpgsqlTypes.NpgsqlPoint(x: 0.47679242480768425d, y: 0.639948874341045d), new NpgsqlTypes.NpgsqlPoint(x: 0.2227892285234716d, y: 0.7800778833425385d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.224615406399156d, y: 0.24332295524022896d), new NpgsqlTypes.NpgsqlPoint(x: 0.37261823354220847d, y: 0.23645463763379393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060871702435462d, y: 0.7528281443841689d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9356246636533905d, y: 0.7582217957860197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534181678266044d, y: 0.21456178178825502d), new NpgsqlTypes.NpgsqlPoint(x: 0.14418969988550612d, y: 0.4063001628726859d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06992129971568928d, y: 0.8250427316540535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800285852909845d, y: 0.05459718049457807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7992917143521189d, y: 0.12006466028888518d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.984136898768366d, y: 0.2105157521555131d), new NpgsqlTypes.NpgsqlPoint(x: 0.5645812657956593d, y: 0.7892052729514013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486519854384569d, y: 0.1489816461146477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6233595655805338d, y: 0.14935440156212265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960612429573947d, y: 0.535707591561014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143909893649365d, y: 0.0026741989162846203d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8562523803507812d, y: 0.8313812524615303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665168503716705d, y: 0.07592767725296146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364672943860608d, y: 0.9092227724337347d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.990963904811562d, y: 0.7878906173570628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231120497441295d, y: 0.8409955102287862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570531147008029d, y: 0.14868372956512532d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.649686353539856d, y: 0.6815013355558932d), new NpgsqlTypes.NpgsqlPoint(x: 0.47286127873440553d, y: 0.060357645890701694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395881103610399d, y: 0.8262972228369636d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4695633639572456d, y: 0.6119374637147514d), new NpgsqlTypes.NpgsqlPoint(x: 0.02346351594407825d, y: 0.578655376964386d), new NpgsqlTypes.NpgsqlPoint(x: 0.11314352215537016d, y: 0.44826849106017175d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44249261259371286d, y: 0.583006664688494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865041143884451d, y: 0.569844198526881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038494886451872d, y: 0.8198442505642396d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07322954208777044d, y: 0.5404261316974946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693631928944377d, y: 0.8922481455957895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754662669980463d, y: 0.7073920017646577d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7951823884568169d, y: 0.6389070120157734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940109337664276d, y: 0.8501950058712086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143687242601776d, y: 0.039254027731590035d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9899080626465472d, y: 0.34678559236554274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7994168122592763d, y: 0.8490116652889592d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881367412862624d, y: 0.3161578784999568d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47412890523755724d, y: 0.2316593174714766d), new NpgsqlTypes.NpgsqlPoint(x: 0.32633305585421224d, y: 0.012443804367065492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122276467992545d, y: 0.8849117391327046d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006895657118501153d, y: 0.07855364651949226d), new NpgsqlTypes.NpgsqlPoint(x: 0.25784215700972235d, y: 0.9070925342485475d), new NpgsqlTypes.NpgsqlPoint(x: 0.598920006211906d, y: 0.4612892140874888d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43536756891646744d, y: 0.16980264158921599d), new NpgsqlTypes.NpgsqlPoint(x: 0.47203855331291944d, y: 0.6778458116224796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553597910927659d, y: 0.14670644626809404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36854202502915967d, y: 0.7208656306640092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327652300393105d, y: 0.6744690028230892d), new NpgsqlTypes.NpgsqlPoint(x: 0.33025479853085604d, y: 0.9788508541852845d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5236907373145103d, y: 0.7575643770954698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804484556176221d, y: 0.0009973413373101092d), new NpgsqlTypes.NpgsqlPoint(x: 0.09752042972233621d, y: 0.14096816788405886d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316310750749927d, y: 0.4056818281609299d), new NpgsqlTypes.NpgsqlPoint(x: 0.2290543645702393d, y: 0.37248421468990534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599211624167803d, y: 0.9740994847666417d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI), typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

