

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD2
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD2 : INpgsqlPolygonMArraypolygonMMArrayD2
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD2E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD2E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018372761994498554d, y: 0.03842520566614982d), new NpgsqlTypes.NpgsqlPoint(x: 0.2769539241818887d, y: 0.8149567783508029d), new NpgsqlTypes.NpgsqlPoint(x: 0.2701983949754123d, y: 0.2969538259840172d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06673140097759811d, y: 0.02290025256263739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8037521410391473d, y: 0.8168733856420279d), new NpgsqlTypes.NpgsqlPoint(x: 0.19775282054672216d, y: 0.03284889084495923d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9418485945352131d, y: 0.12667592850640153d), new NpgsqlTypes.NpgsqlPoint(x: 0.31763469430571545d, y: 0.2805250108648174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106660991404689d, y: 0.9509558645937729d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8328478041544075d, y: 0.4687869435454637d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367016579277705d, y: 0.9165504976332896d), new NpgsqlTypes.NpgsqlPoint(x: 0.0363636070237795d, y: 0.0255636601845024d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1317198507354208d, y: 0.26592238545405533d), new NpgsqlTypes.NpgsqlPoint(x: 0.4231367889477873d, y: 0.5513524314833708d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470862417472182d, y: 0.8551706769223287d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1191867541668461d, y: 0.1235826906639177d), new NpgsqlTypes.NpgsqlPoint(x: 0.14614772569588808d, y: 0.521926202289768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276959923537507d, y: 0.20291166255609716d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044956101191299336d, y: 0.6984328027124086d), new NpgsqlTypes.NpgsqlPoint(x: 0.923825598091419d, y: 0.6328822976493855d), new NpgsqlTypes.NpgsqlPoint(x: 0.3786354830782641d, y: 0.8210162476579675d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07114541951222886d, y: 0.8287225499210118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242709063667337d, y: 0.06783671850090722d), new NpgsqlTypes.NpgsqlPoint(x: 0.11084678819583915d, y: 0.1522417404236469d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9868954287512374d, y: 0.2646900484115624d), new NpgsqlTypes.NpgsqlPoint(x: 0.2167108192595255d, y: 0.18114897116056794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6602485449786287d, y: 0.5989498752007716d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.95953099311446d, y: 0.6038823528598353d), new NpgsqlTypes.NpgsqlPoint(x: 0.3101975513928694d, y: 0.5738934839515737d), new NpgsqlTypes.NpgsqlPoint(x: 0.20406602199959456d, y: 0.9473267228609181d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32890884977343793d, y: 0.21784130798107748d), new NpgsqlTypes.NpgsqlPoint(x: 0.2693760212437234d, y: 0.8248546256517635d), new NpgsqlTypes.NpgsqlPoint(x: 0.2423799946116859d, y: 0.803082420853657d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9995163141355813d, y: 0.14898840665957325d), new NpgsqlTypes.NpgsqlPoint(x: 0.21069161823359428d, y: 0.4677775278139834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859440396280739d, y: 0.44192537557587463d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8375782290378878d, y: 0.015066155491487265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5638375020926507d, y: 0.36334939239994113d), new NpgsqlTypes.NpgsqlPoint(x: 0.2784056258423522d, y: 0.8387465716736761d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5482703595366678d, y: 0.6443451583135925d), new NpgsqlTypes.NpgsqlPoint(x: 0.23740029393795126d, y: 0.9503734372212973d), new NpgsqlTypes.NpgsqlPoint(x: 0.23888250780570508d, y: 0.899017625758312d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6359650027702247d, y: 0.5567261512633828d), new NpgsqlTypes.NpgsqlPoint(x: 0.987470695067305d, y: 0.729205928402207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520840535712201d, y: 0.4204414960923073d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11333095825370587d, y: 0.7919795228936295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6516570971349309d, y: 0.050609168488015666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5412781065241473d, y: 0.6722970794468588d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47055367913043367d, y: 0.799169632120728d), new NpgsqlTypes.NpgsqlPoint(x: 0.30429928409652607d, y: 0.36514551029892084d), new NpgsqlTypes.NpgsqlPoint(x: 0.142414181352857d, y: 0.5482422163935876d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04785844274542739d, y: 0.6204699371204646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631864561474939d, y: 0.8963518133610155d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457847477529827d, y: 0.3509236697656911d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3035308510678585d, y: 0.34531975136958537d), new NpgsqlTypes.NpgsqlPoint(x: 0.21681594280497973d, y: 0.9121906580619742d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086399046620779d, y: 0.3459714336041533d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05013834407830364d, y: 0.5209945764000283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3719930238756606d, y: 0.21389242976954093d), new NpgsqlTypes.NpgsqlPoint(x: 0.34086776701707433d, y: 0.6494138701866212d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9483358775638319d, y: 0.6018728586641193d), new NpgsqlTypes.NpgsqlPoint(x: 0.07142470196423056d, y: 0.8376090364393282d), new NpgsqlTypes.NpgsqlPoint(x: 0.0384008165691927d, y: 0.5862946907198916d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8710021456778559d, y: 0.14780286743665294d), new NpgsqlTypes.NpgsqlPoint(x: 0.11185765550701787d, y: 0.24027346141551398d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936233742222645d, y: 0.5101911300234289d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6609237184919434d, y: 0.8078100384343335d), new NpgsqlTypes.NpgsqlPoint(x: 0.11337391768319782d, y: 0.2947148589488434d), new NpgsqlTypes.NpgsqlPoint(x: 0.18983443403505784d, y: 0.7819705104701199d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.905250384205318d, y: 0.628753999422756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180461790303813d, y: 0.34559375576475904d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594981872813666d, y: 0.8695743463272971d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0980900579780366d, y: 0.48291689520800585d), new NpgsqlTypes.NpgsqlPoint(x: 0.4283031338708969d, y: 0.30476944697957664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6317033324123762d, y: 0.7903467945409787d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12097384332924399d, y: 0.5583151542430124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3196801480307653d, y: 0.8197393980767755d), new NpgsqlTypes.NpgsqlPoint(x: 0.45649500828401923d, y: 0.055634053738389366d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1255211781514196d, y: 0.45921005950561866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4791529719768274d, y: 0.22840485726742932d), new NpgsqlTypes.NpgsqlPoint(x: 0.868417023588797d, y: 0.5143142594335085d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1729085863930766d, y: 0.0095719709727341d), new NpgsqlTypes.NpgsqlPoint(x: 0.911337250788738d, y: 0.47587583629286734d), new NpgsqlTypes.NpgsqlPoint(x: 0.495363519890751d, y: 0.9907887092452694d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5736292128583687d, y: 0.04048975257540022d), new NpgsqlTypes.NpgsqlPoint(x: 0.1808683228276995d, y: 0.9130855650819838d), new NpgsqlTypes.NpgsqlPoint(x: 0.07596883804371934d, y: 0.5306203404914872d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3232669320100783d, y: 0.8993448435405467d), new NpgsqlTypes.NpgsqlPoint(x: 0.2795757169213796d, y: 0.6213142438204061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9011655082577708d, y: 0.868110242132058d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7060513991091023d, y: 0.28766763851320243d), new NpgsqlTypes.NpgsqlPoint(x: 0.3635782545712247d, y: 0.29069863889116976d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624551939366667d, y: 0.5790129989563357d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6487679278038734d, y: 0.892352474698646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7422098159571153d, y: 0.7683676869920157d), new NpgsqlTypes.NpgsqlPoint(x: 0.17865969920858582d, y: 0.3314670911785397d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.035979949326246374d, y: 0.06755510080278859d), new NpgsqlTypes.NpgsqlPoint(x: 0.35235581041763475d, y: 0.10893414997788764d), new NpgsqlTypes.NpgsqlPoint(x: 0.038734616208468076d, y: 0.0334351965106946d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5710450646209251d, y: 0.4609057785045322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9893058861541554d, y: 0.24172622600583205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279496518610868d, y: 0.5103155068151036d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32513826771300514d, y: 0.7587930090618096d), new NpgsqlTypes.NpgsqlPoint(x: 0.587546713963661d, y: 0.43011467795933167d), new NpgsqlTypes.NpgsqlPoint(x: 0.4396555704595828d, y: 0.6325352306059552d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6584245151383972d, y: 0.31083753256846003d), new NpgsqlTypes.NpgsqlPoint(x: 0.3178601431407182d, y: 0.2116808969097297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6179494572311662d, y: 0.37078733396209784d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15601113324452742d, y: 0.29327362668223256d), new NpgsqlTypes.NpgsqlPoint(x: 0.15177879997652788d, y: 0.8367538678641891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6150960619019269d, y: 0.8222996699615595d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.521985243155639d, y: 0.43914284494693123d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802723563070382d, y: 0.7171694670492268d), new NpgsqlTypes.NpgsqlPoint(x: 0.10508512951337412d, y: 0.38690230761064603d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33822288845611503d, y: 0.5675273521016261d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490190556879966d, y: 0.05409942276180124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200044609249188d, y: 0.8060203818638197d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34141151560453964d, y: 0.6029031109996104d), new NpgsqlTypes.NpgsqlPoint(x: 0.42133837573340294d, y: 0.08811703102446766d), new NpgsqlTypes.NpgsqlPoint(x: 0.2403402310326791d, y: 0.3086907209153009d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31105165726961814d, y: 0.6609890650909848d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187430042548721d, y: 0.20013362115866307d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349169115453527d, y: 0.8155048846926125d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2123589517850527d, y: 0.5834163746261831d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366795275056973d, y: 0.280382687950157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785740976494568d, y: 0.5323832263653662d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5198439379593395d, y: 0.09860302739023852d), new NpgsqlTypes.NpgsqlPoint(x: 0.10979398458616263d, y: 0.2788775562302652d), new NpgsqlTypes.NpgsqlPoint(x: 0.0803490587258926d, y: 0.27803713784228434d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3020100986870058d, y: 0.6422978124335864d), new NpgsqlTypes.NpgsqlPoint(x: 0.22296506175365838d, y: 0.2963757390373942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530629953979311d, y: 0.5972744490084393d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4169241483644781d, y: 0.6341837516547392d), new NpgsqlTypes.NpgsqlPoint(x: 0.8193464035590791d, y: 0.37211448316896734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515835170745815d, y: 0.8687770279721728d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9634848283616664d, y: 0.9826381618054267d), new NpgsqlTypes.NpgsqlPoint(x: 0.8688083200545706d, y: 0.8154481910481617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898377564907135d, y: 0.2310981174962855d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8642928359587466d, y: 0.0804814376417825d), new NpgsqlTypes.NpgsqlPoint(x: 0.795412262432641d, y: 0.8270636146888215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7642183946248713d, y: 0.10744208064662253d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4921862839033303d, y: 0.33467289034015846d), new NpgsqlTypes.NpgsqlPoint(x: 0.24000139360729256d, y: 0.8839198222003195d), new NpgsqlTypes.NpgsqlPoint(x: 0.9112437382251695d, y: 0.685492331159036d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6503770429428212d, y: 0.7762872104567791d), new NpgsqlTypes.NpgsqlPoint(x: 0.7052580542512356d, y: 0.17814790197139363d), new NpgsqlTypes.NpgsqlPoint(x: 0.36128923095305443d, y: 0.03795641170412112d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8896798662489354d, y: 0.2556880133933047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654697168759083d, y: 0.5401504774263743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9367958269437747d, y: 0.35569569123535305d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4991327282621728d, y: 0.29159687589231575d), new NpgsqlTypes.NpgsqlPoint(x: 0.14471755895271976d, y: 0.779684614312983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5480890081455879d, y: 0.21101751224295995d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5563708936267692d, y: 0.04717065840313506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7350059536455106d, y: 0.05926246357129883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286937963905737d, y: 0.5833632583863981d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5676243854067553d, y: 0.9285780629708322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860662584615739d, y: 0.18643989626644986d), new NpgsqlTypes.NpgsqlPoint(x: 0.23854874252943614d, y: 0.4201404449258187d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7280958815204662d, y: 0.6175730712037917d), new NpgsqlTypes.NpgsqlPoint(x: 0.39060185733594055d, y: 0.856460762909273d), new NpgsqlTypes.NpgsqlPoint(x: 0.6795366299540716d, y: 0.7678549908155716d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46876144199144065d, y: 0.8498734579861655d), new NpgsqlTypes.NpgsqlPoint(x: 0.08946759157535444d, y: 0.4474554862527088d), new NpgsqlTypes.NpgsqlPoint(x: 0.15548476181672188d, y: 0.14120408970717302d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0975628404477542d, y: 0.3171214980881748d), new NpgsqlTypes.NpgsqlPoint(x: 0.16141586310387013d, y: 0.09977913579916131d), new NpgsqlTypes.NpgsqlPoint(x: 0.1564673869169232d, y: 0.9299667031383198d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9081197687845005d, y: 0.13394581694871333d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494299706912396d, y: 0.9330331288387066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295180444526465d, y: 0.1221614091961184d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2407889852073648d, y: 0.6572911346902064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314029053692131d, y: 0.12347719705318494d), new NpgsqlTypes.NpgsqlPoint(x: 0.4917461555002599d, y: 0.3939275196165839d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7993139027597008d, y: 0.03226344189054775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482898511781711d, y: 0.2680609431309955d), new NpgsqlTypes.NpgsqlPoint(x: 0.07952908882286114d, y: 0.08251705794082798d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15550500720002736d, y: 0.41137589014340137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6788974833643576d, y: 0.8425748850066074d), new NpgsqlTypes.NpgsqlPoint(x: 0.41709595966896573d, y: 0.04692207554595618d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39574758457370485d, y: 0.8596183149397255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517751191380016d, y: 0.13724182958406606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418048615727576d, y: 0.02430239608072371d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6627038804921883d, y: 0.005044630893291324d), new NpgsqlTypes.NpgsqlPoint(x: 0.36472714672697504d, y: 0.6374671248643081d), new NpgsqlTypes.NpgsqlPoint(x: 0.27946484643567704d, y: 0.026904746892296383d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21060799695160914d, y: 0.5497065704225073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976903442017345d, y: 0.5771001434119235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374415497349807d, y: 0.9300741819465185d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4127033137410715d, y: 0.0565506388588084d), new NpgsqlTypes.NpgsqlPoint(x: 0.44030294590139296d, y: 0.31178397421421866d), new NpgsqlTypes.NpgsqlPoint(x: 0.019112644937209655d, y: 0.9140609231248545d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6926153951200947d, y: 0.5822672894456896d), new NpgsqlTypes.NpgsqlPoint(x: 0.05374099290464651d, y: 0.5837008391725546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205657415377397d, y: 0.5648168930821682d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3648584587696736d, y: 0.8669164496756081d), new NpgsqlTypes.NpgsqlPoint(x: 0.8150390927447191d, y: 0.033448294554278d), new NpgsqlTypes.NpgsqlPoint(x: 0.25713753490797886d, y: 0.17622673378395926d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6820204695299349d, y: 0.4039917244397988d), new NpgsqlTypes.NpgsqlPoint(x: 0.17748034650619293d, y: 0.9302755222974239d), new NpgsqlTypes.NpgsqlPoint(x: 0.25864799787945636d, y: 0.057591767387844994d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6746608207990636d, y: 0.8178608611811943d), new NpgsqlTypes.NpgsqlPoint(x: 0.18952189256852592d, y: 0.016835290584901186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5663074134210118d, y: 0.6546366729043607d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6341682907223177d, y: 0.16470183137001382d), new NpgsqlTypes.NpgsqlPoint(x: 0.17983567134731138d, y: 0.9795799316783644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8940105297876528d, y: 0.5669621836618794d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44711627864226633d, y: 0.5233092876306336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7759251479194406d, y: 0.9576860562661325d), new NpgsqlTypes.NpgsqlPoint(x: 0.21782786483753735d, y: 0.746592418905876d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13321928728990673d, y: 0.8542146631812739d), new NpgsqlTypes.NpgsqlPoint(x: 0.334055502628698d, y: 0.3621379693759309d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294441822172741d, y: 0.3001611321151981d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09028071605039811d, y: 0.7835494668534999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404274770268321d, y: 0.03836502312903245d), new NpgsqlTypes.NpgsqlPoint(x: 0.29994443003416016d, y: 0.7349345191509643d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.921774113315324d, y: 0.5849300706200935d), new NpgsqlTypes.NpgsqlPoint(x: 0.08910821647532674d, y: 0.9820076976501269d), new NpgsqlTypes.NpgsqlPoint(x: 0.41751183373395984d, y: 0.6730809946071299d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8600939155590603d, y: 0.1043043984694727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567304438154567d, y: 0.8503704844204477d), new NpgsqlTypes.NpgsqlPoint(x: 0.2450036121810234d, y: 0.4291298061535973d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.792315650177256d, y: 0.5982788755474239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7377952778026151d, y: 0.6495512325413804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3724637157913544d, y: 0.09341011210142558d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36074310420300637d, y: 0.16221312897950269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264780996264809d, y: 0.630362415378024d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569988605866607d, y: 0.7399081285849581d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6985677417561722d, y: 0.5251631814533797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941267783277275d, y: 0.11434668323115105d), new NpgsqlTypes.NpgsqlPoint(x: 0.46800253008924686d, y: 0.20222476519359256d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18040846487269813d, y: 0.5840269414873306d), new NpgsqlTypes.NpgsqlPoint(x: 0.41115825219390423d, y: 0.550296552298507d), new NpgsqlTypes.NpgsqlPoint(x: 0.24748182405056374d, y: 0.2368665519296851d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8400504764661245d, y: 0.14560961397732586d), new NpgsqlTypes.NpgsqlPoint(x: 0.4918007908458485d, y: 0.3293032526384523d), new NpgsqlTypes.NpgsqlPoint(x: 0.1006318409749899d, y: 0.6501092776238244d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6565933802201436d, y: 0.45435881987688886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652539966136277d, y: 0.9627887161391249d), new NpgsqlTypes.NpgsqlPoint(x: 0.07205546959107889d, y: 0.9304012854449066d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21899577513459167d, y: 0.493113411609859d), new NpgsqlTypes.NpgsqlPoint(x: 0.1548713694781625d, y: 0.7230720789581085d), new NpgsqlTypes.NpgsqlPoint(x: 0.49159489493271635d, y: 0.36395957970451764d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44234209824215454d, y: 0.26667662516492996d), new NpgsqlTypes.NpgsqlPoint(x: 0.8627128358592218d, y: 0.17530156631187588d), new NpgsqlTypes.NpgsqlPoint(x: 0.14638424469303069d, y: 0.8810505551250426d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42852339420421537d, y: 0.8321606933934756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897571394441196d, y: 0.8907119040033946d), new NpgsqlTypes.NpgsqlPoint(x: 0.4938573025738803d, y: 0.6716779472554184d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10030178066637518d, y: 0.7462063597738706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5744454238846338d, y: 0.4727764548282517d), new NpgsqlTypes.NpgsqlPoint(x: 0.17359568339677767d, y: 0.19395291687464233d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5251829232218603d, y: 0.4343315122020551d), new NpgsqlTypes.NpgsqlPoint(x: 0.965799808244247d, y: 0.15537072249539774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216856531951945d, y: 0.30383582772383844d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9731729126893996d, y: 0.20318049293825136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799961834241561d, y: 0.6708652422523119d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935552613335922d, y: 0.9160264506965902d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7489984140457756d, y: 0.1290239378575374d), new NpgsqlTypes.NpgsqlPoint(x: 0.2051851020974258d, y: 0.5817079367725156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794241284516711d, y: 0.08660349587925442d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30503019545694654d, y: 0.661180232761636d), new NpgsqlTypes.NpgsqlPoint(x: 0.32413051461599696d, y: 0.3471857574754088d), new NpgsqlTypes.NpgsqlPoint(x: 0.39208310261748003d, y: 0.25042738577952695d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8783266649794207d, y: 0.025319295822013088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463711426802938d, y: 0.0482141508306726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540301759044038d, y: 0.8365973266658733d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.261305171198431d, y: 0.4700561294973268d), new NpgsqlTypes.NpgsqlPoint(x: 0.021283443403388835d, y: 0.4907652946791302d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089563326988837d, y: 0.8118704296795991d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18173849100710915d, y: 0.7370396185443526d), new NpgsqlTypes.NpgsqlPoint(x: 0.39141489216093395d, y: 0.7943718882859923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188454248392354d, y: 0.25861593835130325d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2749292277521631d, y: 0.5971640845956063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025124772587584d, y: 0.669556915327646d), new NpgsqlTypes.NpgsqlPoint(x: 0.1446609265037212d, y: 0.5389116977144542d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31995096427571024d, y: 0.04438549078882981d), new NpgsqlTypes.NpgsqlPoint(x: 0.602963298091621d, y: 0.7691015390374866d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731145713864186d, y: 0.6547007699488905d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37588847054928143d, y: 0.059600765909243125d), new NpgsqlTypes.NpgsqlPoint(x: 0.34257709217622456d, y: 0.4779556668992322d), new NpgsqlTypes.NpgsqlPoint(x: 0.08630739157988865d, y: 0.6701881656786195d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3040316784312863d, y: 0.2917195830355578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991790283157297d, y: 0.27354718278645107d), new NpgsqlTypes.NpgsqlPoint(x: 0.1754682920724402d, y: 0.5972328530845015d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48363636483255534d, y: 0.9083842098038126d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349162951074127d, y: 0.7465719512503004d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621757645315167d, y: 0.16520056135142858d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.820832632278498d, y: 0.7858845699500491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793516059612453d, y: 0.8815764678331838d), new NpgsqlTypes.NpgsqlPoint(x: 0.41661901988156713d, y: 0.0015601670325636752d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6055246860594483d, y: 0.45254124286832054d), new NpgsqlTypes.NpgsqlPoint(x: 0.3388003335363696d, y: 0.623918525319624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551298632686938d, y: 0.2238971205313134d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3228859007210101d, y: 0.3152524622742878d), new NpgsqlTypes.NpgsqlPoint(x: 0.42221830640982794d, y: 0.151111885363427d), new NpgsqlTypes.NpgsqlPoint(x: 0.4410970922193197d, y: 0.08946256926687934d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811306737197633d, y: 0.09161200905537958d), new NpgsqlTypes.NpgsqlPoint(x: 0.18667469073083187d, y: 0.38780195085116753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341744641459055d, y: 0.9479434150192794d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4792976628633989d, y: 0.36409215994754485d), new NpgsqlTypes.NpgsqlPoint(x: 0.679791792427059d, y: 0.4452857689150186d), new NpgsqlTypes.NpgsqlPoint(x: 0.21478513860698734d, y: 0.7026390230181336d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1167656025307523d, y: 0.04335001504196434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8648162932879778d, y: 0.8497978513469081d), new NpgsqlTypes.NpgsqlPoint(x: 0.3578241185496358d, y: 0.35541222815136675d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1989571479363308d, y: 0.9553647902069319d), new NpgsqlTypes.NpgsqlPoint(x: 0.032827203862291654d, y: 0.36940559476097823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745540134625412d, y: 0.4366572424143095d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10041403297140339d, y: 0.8340825084029461d), new NpgsqlTypes.NpgsqlPoint(x: 0.8246291092220424d, y: 0.2654885047486445d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603997442292714d, y: 0.03830158511964954d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6014822509704373d, y: 0.32699726136195806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887081485133607d, y: 0.42596980420981145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3986619540706374d, y: 0.9627025773314168d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3119986492250031d, y: 0.5482615017058179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9475660941130847d, y: 0.023958854640145355d), new NpgsqlTypes.NpgsqlPoint(x: 0.28458710121228203d, y: 0.3760039411841307d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9169601576370178d, y: 0.4207733640251986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887832806134738d, y: 0.6653914454111935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039816377578844d, y: 0.42372507991067876d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4134541551880624d, y: 0.1577942243283481d), new NpgsqlTypes.NpgsqlPoint(x: 0.4217721086321141d, y: 0.2909062599267416d), new NpgsqlTypes.NpgsqlPoint(x: 0.4939892197424508d, y: 0.18031816406792656d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16205524567121588d, y: 0.9978355807332567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4572689141632692d, y: 0.6817903888365403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568551523605078d, y: 0.23636055857273242d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0303074567112529d, y: 0.718652850462154d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491376507408663d, y: 0.5625936464929562d), new NpgsqlTypes.NpgsqlPoint(x: 0.48931634473981844d, y: 0.7287046297480884d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3774197513487556d, y: 0.6100258447204631d), new NpgsqlTypes.NpgsqlPoint(x: 0.4173457374815325d, y: 0.40258402622629463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9650426760208837d, y: 0.21730638187442308d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3718588049386182d, y: 0.008172699382080428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122380579122271d, y: 0.386696814217082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137994252280325d, y: 0.006846871810855526d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15688946453936636d, y: 0.21706306153095112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563367180507929d, y: 0.9645473840857347d), new NpgsqlTypes.NpgsqlPoint(x: 0.515642690230588d, y: 0.32476630038829335d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5130657898361082d, y: 0.11866291887680958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6466321710960838d, y: 0.44719224980347916d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151675284598255d, y: 0.9218755501490142d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19261297362153218d, y: 0.12724858150906138d), new NpgsqlTypes.NpgsqlPoint(x: 0.2039254148491192d, y: 0.25613525258645287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6524626095924985d, y: 0.6409227753397795d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.497069836148357d, y: 0.8515836470438264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972760651252738d, y: 0.20259841833737702d), new NpgsqlTypes.NpgsqlPoint(x: 0.3295760678572437d, y: 0.6808961737230289d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23212290029713378d, y: 0.1092644669117191d), new NpgsqlTypes.NpgsqlPoint(x: 0.8443736323530374d, y: 0.2758700717374696d), new NpgsqlTypes.NpgsqlPoint(x: 0.2516508748960239d, y: 0.03052556635866066d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5969053912686688d, y: 0.9711931267777669d), new NpgsqlTypes.NpgsqlPoint(x: 0.413664594990764d, y: 0.2394143979008143d), new NpgsqlTypes.NpgsqlPoint(x: 0.35077642269239706d, y: 0.9160735113024345d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32196269673098943d, y: 0.4973708554032994d), new NpgsqlTypes.NpgsqlPoint(x: 0.759361250603141d, y: 0.9085706147317756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989760072566102d, y: 0.571313439223836d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8213386031624583d, y: 0.4663396140574291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892071571259966d, y: 0.26828782509456783d), new NpgsqlTypes.NpgsqlPoint(x: 0.14964954243863848d, y: 0.5362479585476748d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9225678906132933d, y: 0.21060018800610525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425189256045694d, y: 0.1306852326343948d), new NpgsqlTypes.NpgsqlPoint(x: 0.027942617941211556d, y: 0.9709346408547734d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9067003870171966d, y: 0.5516428868111048d), new NpgsqlTypes.NpgsqlPoint(x: 0.14858156853152038d, y: 0.6083255638113928d), new NpgsqlTypes.NpgsqlPoint(x: 0.31573647718307385d, y: 0.8929490528099129d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6040425530380453d, y: 0.21806184071566814d), new NpgsqlTypes.NpgsqlPoint(x: 0.788669442296199d, y: 0.1705101584867318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679469319317372d, y: 0.5688966129520608d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3362352248795055d, y: 0.3465915507392925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616688025351381d, y: 0.3265046309199189d), new NpgsqlTypes.NpgsqlPoint(x: 0.3740631466551495d, y: 0.8975931683116837d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7748108669841004d, y: 0.7551079601844951d), new NpgsqlTypes.NpgsqlPoint(x: 0.08831431608717555d, y: 0.4095443540643956d), new NpgsqlTypes.NpgsqlPoint(x: 0.028642128727344063d, y: 0.8226037241510398d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7986134523375392d, y: 0.6297543048655796d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413333647059742d, y: 0.007753645295452527d), new NpgsqlTypes.NpgsqlPoint(x: 0.14645310869486539d, y: 0.8930821391318032d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6864646208546547d, y: 0.08548466675488986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859278923626331d, y: 0.14952388241672243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6300870595166863d, y: 0.2498970092946513d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3113352846794062d, y: 0.3653987176056869d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338590947501417d, y: 0.40282458867934023d), new NpgsqlTypes.NpgsqlPoint(x: 0.18699269360578308d, y: 0.022060505716126166d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7236065210767323d, y: 0.9609601841329913d), new NpgsqlTypes.NpgsqlPoint(x: 0.007315970860951815d, y: 0.49712832689928743d), new NpgsqlTypes.NpgsqlPoint(x: 0.037828302972226835d, y: 0.8211338069113506d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40273697634668837d, y: 0.13194429148879516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9084269156978205d, y: 0.3626433744300198d), new NpgsqlTypes.NpgsqlPoint(x: 0.20715521792387215d, y: 0.5925238499439275d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47548059926185526d, y: 0.9517701201312622d), new NpgsqlTypes.NpgsqlPoint(x: 0.9748162738057773d, y: 0.18732470836678805d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644739128751915d, y: 0.5196887386957929d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6250886925866616d, y: 0.9986399231821804d), new NpgsqlTypes.NpgsqlPoint(x: 0.15666147220184556d, y: 0.8065127894506849d), new NpgsqlTypes.NpgsqlPoint(x: 0.6268637047507474d, y: 0.7935762638725233d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6038571273087664d, y: 0.1784461304620686d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793355394161072d, y: 0.3564313037504264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6873252533057508d, y: 0.8179433035085548d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44409602291634354d, y: 0.9591034053625306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283897358415101d, y: 0.6196968401102761d), new NpgsqlTypes.NpgsqlPoint(x: 0.4016309930235732d, y: 0.7193895643311127d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4395441244538191d, y: 0.44374577613348787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699619438111569d, y: 0.40031819797376267d), new NpgsqlTypes.NpgsqlPoint(x: 0.16583108760713017d, y: 0.8980235044288021d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.452481647498013d, y: 0.5748284884886876d), new NpgsqlTypes.NpgsqlPoint(x: 0.654048595548797d, y: 0.7091664305499427d), new NpgsqlTypes.NpgsqlPoint(x: 0.985315896327323d, y: 0.9371487553570662d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09429644841656004d, y: 0.625741116804337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6621467128310463d, y: 0.5748515616271764d), new NpgsqlTypes.NpgsqlPoint(x: 0.32150147608515d, y: 0.9033317170096031d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5472467472052377d, y: 0.48489310652282147d), new NpgsqlTypes.NpgsqlPoint(x: 0.16371179837912053d, y: 0.5166397317246153d), new NpgsqlTypes.NpgsqlPoint(x: 0.37456179090742625d, y: 0.6248447261542801d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7479595456899255d, y: 0.9888471845892477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880694188546116d, y: 0.8644634127481259d), new NpgsqlTypes.NpgsqlPoint(x: 0.2001310192405984d, y: 0.8393988461252806d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6844776564531219d, y: 0.8326669519786002d), new NpgsqlTypes.NpgsqlPoint(x: 0.8849638734504096d, y: 0.9487350429244594d), new NpgsqlTypes.NpgsqlPoint(x: 0.0683658137534443d, y: 0.5154077584514184d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9230863676935555d, y: 0.8619609565061284d), new NpgsqlTypes.NpgsqlPoint(x: 0.1208188405765136d, y: 0.041975399785356804d), new NpgsqlTypes.NpgsqlPoint(x: 0.11110275395254776d, y: 0.290813947458073d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5875260426763051d, y: 0.7692976414812498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304190723058981d, y: 0.40414538606825734d), new NpgsqlTypes.NpgsqlPoint(x: 0.029350138112678503d, y: 0.33263712801776557d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18571737304446645d, y: 0.648009102251996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7279133955018537d, y: 0.847926676989657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805850285438641d, y: 0.4833083674397203d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9692289282125998d, y: 0.33659134735400087d), new NpgsqlTypes.NpgsqlPoint(x: 0.21442303533670415d, y: 0.42482149206785624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511262299889794d, y: 0.2573537121675309d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7580877985184776d, y: 0.7675940283053078d), new NpgsqlTypes.NpgsqlPoint(x: 0.11308640414243676d, y: 0.6141949974170849d), new NpgsqlTypes.NpgsqlPoint(x: 0.2644745688773774d, y: 0.7955074134934824d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4661035500719839d, y: 0.6665555387903084d), new NpgsqlTypes.NpgsqlPoint(x: 0.9484373432581129d, y: 0.55034908427873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905656538379278d, y: 0.11124369236256837d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04040104067487049d, y: 0.2179264971015772d), new NpgsqlTypes.NpgsqlPoint(x: 0.21561524000551646d, y: 0.3243332269686863d), new NpgsqlTypes.NpgsqlPoint(x: 0.2432623750078684d, y: 0.5272948234170982d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31947246539618135d, y: 0.7432741396199383d), new NpgsqlTypes.NpgsqlPoint(x: 0.40228604602157947d, y: 0.6070242216516714d), new NpgsqlTypes.NpgsqlPoint(x: 0.683917246757667d, y: 0.03873403333666081d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013299226006119547d, y: 0.6239977014721092d), new NpgsqlTypes.NpgsqlPoint(x: 0.11433478979462475d, y: 0.1950261587737192d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454702646757479d, y: 0.37691351007389984d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4913187070008441d, y: 0.23051488104680218d), new NpgsqlTypes.NpgsqlPoint(x: 0.336735447499099d, y: 0.05976131948491881d), new NpgsqlTypes.NpgsqlPoint(x: 0.3639890206135792d, y: 0.20364489633919802d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6847928352591799d, y: 0.9925988271855454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935807360704077d, y: 0.4142941976959167d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866464389314955d, y: 0.36196386985830975d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6493671715355285d, y: 0.796551595660785d), new NpgsqlTypes.NpgsqlPoint(x: 0.4107330226769095d, y: 0.48068401315600784d), new NpgsqlTypes.NpgsqlPoint(x: 0.4293936457735076d, y: 0.7443934277149926d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47756832074192146d, y: 0.8329515409533912d), new NpgsqlTypes.NpgsqlPoint(x: 0.547647590107108d, y: 0.1054794600388671d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814089605853823d, y: 0.19974595657991523d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9476087768291687d, y: 0.548546809135353d), new NpgsqlTypes.NpgsqlPoint(x: 0.29548005315863735d, y: 0.20459740665525217d), new NpgsqlTypes.NpgsqlPoint(x: 0.20472356771732114d, y: 0.2378103771403267d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8056263856616801d, y: 0.9099203064588972d), new NpgsqlTypes.NpgsqlPoint(x: 0.04367772060707387d, y: 0.26384786540881555d), new NpgsqlTypes.NpgsqlPoint(x: 0.10926011125696256d, y: 0.4002061156382988d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8176450254875425d, y: 0.6847712440707865d), new NpgsqlTypes.NpgsqlPoint(x: 0.0034254918642883103d, y: 0.3531130120909812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5689401307221245d, y: 0.7332463539197273d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4733744746076133d, y: 0.04718662642440952d), new NpgsqlTypes.NpgsqlPoint(x: 0.07150119077264672d, y: 0.33094473392961243d), new NpgsqlTypes.NpgsqlPoint(x: 0.1744139012245487d, y: 0.651856955451737d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7495012835792294d, y: 0.5987124422253209d), new NpgsqlTypes.NpgsqlPoint(x: 0.20803558792566545d, y: 0.5701424123080683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647235781558289d, y: 0.183562209234313d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9617285643591923d, y: 0.7804826808927996d), new NpgsqlTypes.NpgsqlPoint(x: 0.18302152532213778d, y: 0.269405659575523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971784685904247d, y: 0.9632316117916349d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36159095652620443d, y: 0.9735094782883746d), new NpgsqlTypes.NpgsqlPoint(x: 0.30414567163426565d, y: 0.6202831910815712d), new NpgsqlTypes.NpgsqlPoint(x: 0.21437246534184662d, y: 0.5147841720422759d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12048414460753654d, y: 0.5959266400298656d), new NpgsqlTypes.NpgsqlPoint(x: 0.1052791159509d, y: 0.8757546500334356d), new NpgsqlTypes.NpgsqlPoint(x: 0.7363408445728147d, y: 0.17580619819177024d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028681049073480125d, y: 0.9856439947508318d), new NpgsqlTypes.NpgsqlPoint(x: 0.31036013308771926d, y: 0.697819248353466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7084115472767386d, y: 0.32436343222711195d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8019833544133472d, y: 0.2306977011054845d), new NpgsqlTypes.NpgsqlPoint(x: 0.22991241288348163d, y: 0.9656781975768244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503590028054066d, y: 0.5763365405859664d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.893926292728699d, y: 0.2434139306572377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4266844879557862d, y: 0.5391937988604694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5414359110157889d, y: 0.7387586240507135d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.630660777095686d, y: 0.6765506714041157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8780916382950132d, y: 0.36521036761703307d), new NpgsqlTypes.NpgsqlPoint(x: 0.9745743785877437d, y: 0.13464921850893763d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7160108204699938d, y: 0.31105940519272923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3564026917908941d, y: 0.5429857105415221d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445659709704781d, y: 0.5072993853449511d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9774437574009534d, y: 0.03233379491957189d), new NpgsqlTypes.NpgsqlPoint(x: 0.4603325372783361d, y: 0.7120581798451243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534884898372583d, y: 0.9970106048691791d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9802334480083612d, y: 0.5769728479372715d), new NpgsqlTypes.NpgsqlPoint(x: 0.05553104936277364d, y: 0.06420773969547477d), new NpgsqlTypes.NpgsqlPoint(x: 0.42007715612972574d, y: 0.012172479496581623d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9844422305634025d, y: 0.8044768429926069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8640281152299817d, y: 0.3457847996074753d), new NpgsqlTypes.NpgsqlPoint(x: 0.3109872899924274d, y: 0.03990190494137047d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9673566421322622d, y: 0.2894776579045747d), new NpgsqlTypes.NpgsqlPoint(x: 0.38431819106408904d, y: 0.31279302277996723d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798130734124488d, y: 0.4467747600668711d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7053972238052074d, y: 0.5378480530067928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9252253506265851d, y: 0.30162951660133164d), new NpgsqlTypes.NpgsqlPoint(x: 0.3474530940654015d, y: 0.5903951787608069d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9455177819559089d, y: 0.43510494070996397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152428268597833d, y: 0.9672391728839368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230723964082947d, y: 0.2152450529641211d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5123699201624202d, y: 0.14551068234465414d), new NpgsqlTypes.NpgsqlPoint(x: 0.39590998225004015d, y: 0.4349716391848034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822669838601135d, y: 0.04100818805825479d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8960076539684201d, y: 0.8199051147704303d), new NpgsqlTypes.NpgsqlPoint(x: 0.2933188815431981d, y: 0.26167778795434793d), new NpgsqlTypes.NpgsqlPoint(x: 0.32727590356020686d, y: 0.6918758286617394d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.855074109120818d, y: 0.7315625504853388d), new NpgsqlTypes.NpgsqlPoint(x: 0.3469357576930834d, y: 0.3725629745092174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590783107802044d, y: 0.28212496282608446d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.061931986176056886d, y: 0.22385801066175792d), new NpgsqlTypes.NpgsqlPoint(x: 0.832955746038887d, y: 0.7558956919307911d), new NpgsqlTypes.NpgsqlPoint(x: 0.40973668644364536d, y: 0.09401081196745165d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.803675095492945d, y: 0.6660464447060485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811124275118735d, y: 0.20470924842841487d), new NpgsqlTypes.NpgsqlPoint(x: 0.43338957636927056d, y: 0.5280318434344516d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43684696132502643d, y: 0.5867229621171745d), new NpgsqlTypes.NpgsqlPoint(x: 0.217707162558318d, y: 0.5734527431474532d), new NpgsqlTypes.NpgsqlPoint(x: 0.31080654151330955d, y: 0.07497999357994212d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21534622064421005d, y: 0.5459464939511446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808651510375977d, y: 0.30616286318487007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076455592089469d, y: 0.9952715156367354d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3595878876253308d, y: 0.4153842330737867d), new NpgsqlTypes.NpgsqlPoint(x: 0.1351985877650026d, y: 0.5417282953519079d), new NpgsqlTypes.NpgsqlPoint(x: 0.9564890738949662d, y: 0.0832664405727579d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35775324599492764d, y: 0.8533952525590546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3065920395944447d, y: 0.23562765178347167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464188074551972d, y: 0.5498354501303588d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8602772460986834d, y: 0.6348280729636838d), new NpgsqlTypes.NpgsqlPoint(x: 0.3000260333298601d, y: 0.28130410914656356d), new NpgsqlTypes.NpgsqlPoint(x: 0.061243257261728634d, y: 0.3279442835672858d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4833135913459897d, y: 0.4233864153704284d), new NpgsqlTypes.NpgsqlPoint(x: 0.36546216747543736d, y: 0.791720633506754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932900748060195d, y: 0.39575429850639454d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18629497363324055d, y: 0.12518939869230883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983653814172575d, y: 0.2995963317324565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159797483726859d, y: 0.9101898564183022d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9836444985235688d, y: 0.7813804753306155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6824556873710614d, y: 0.21213919100074152d), new NpgsqlTypes.NpgsqlPoint(x: 0.2746966178926149d, y: 0.7918440620575906d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9057061963876085d, y: 0.24674265058766942d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398860556680927d, y: 0.9527189331308131d), new NpgsqlTypes.NpgsqlPoint(x: 0.2555521311838369d, y: 0.9664652379549452d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3615797250072579d, y: 0.957558178423474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8533351787781503d, y: 0.3884880068015981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344558261290521d, y: 0.1833530052958947d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2528716505641341d, y: 0.41139413233360167d), new NpgsqlTypes.NpgsqlPoint(x: 0.023930060971432243d, y: 0.37731666170938505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2792543941744413d, y: 0.2808666652711337d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7260905250714069d, y: 0.05553136687142324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3951410651557059d, y: 0.24485622669834994d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606107447866446d, y: 0.30254735840705915d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7514780834126387d, y: 0.7642188536468076d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681413665000989d, y: 0.7284516766003953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9076119156415428d, y: 0.7079317204898382d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5607536706546425d, y: 0.7716548309378433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6996281422667011d, y: 0.5482738492357567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4871396528994133d, y: 0.4078741670533834d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6794276493472009d, y: 0.9464763559259478d), new NpgsqlTypes.NpgsqlPoint(x: 0.3055105421218002d, y: 0.18739226999184733d), new NpgsqlTypes.NpgsqlPoint(x: 0.33748181296110713d, y: 0.45405056152325385d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.841959537069464d, y: 0.6583615958821819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8492057241822007d, y: 0.8575921236920523d), new NpgsqlTypes.NpgsqlPoint(x: 0.41846513764901394d, y: 0.5044393568395144d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17576745336298394d, y: 0.5101296246387609d), new NpgsqlTypes.NpgsqlPoint(x: 0.09129666782379187d, y: 0.9502643570097029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6635984990478293d, y: 0.4752311135224193d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9343956501514541d, y: 0.1850414634254801d), new NpgsqlTypes.NpgsqlPoint(x: 0.970041409618761d, y: 0.9648091500629882d), new NpgsqlTypes.NpgsqlPoint(x: 0.1830062818275785d, y: 0.29635517122013755d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6895724996279389d, y: 0.8342166307169163d), new NpgsqlTypes.NpgsqlPoint(x: 0.09051316735003379d, y: 0.7583559421528133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9476991033486324d, y: 0.21689610728850084d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.551475487752267d, y: 0.6830024365696876d), new NpgsqlTypes.NpgsqlPoint(x: 0.23671390738266795d, y: 0.8834560877305571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065716042424298d, y: 0.6794814613167343d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41198406370478813d, y: 0.7125453907466963d), new NpgsqlTypes.NpgsqlPoint(x: 0.01940297748015174d, y: 0.9736886077835274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570742610138591d, y: 0.33977348972199606d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35528232446684305d, y: 0.9351934987756254d), new NpgsqlTypes.NpgsqlPoint(x: 0.19619840572229463d, y: 0.46172275378696515d), new NpgsqlTypes.NpgsqlPoint(x: 0.29413484717351135d, y: 0.7698125801337118d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010537328291980175d, y: 0.01119941476182773d), new NpgsqlTypes.NpgsqlPoint(x: 0.17704096613083053d, y: 0.7949637882105124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3742239486134852d, y: 0.2668368947067822d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9397208351650167d, y: 0.27904943921264436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896881365058317d, y: 0.156369801270281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633411501744408d, y: 0.5708468129313058d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0038454133926180134d, y: 0.544240894347814d), new NpgsqlTypes.NpgsqlPoint(x: 0.12354860121038069d, y: 0.26903110124745055d), new NpgsqlTypes.NpgsqlPoint(x: 0.2644778892958355d, y: 0.8190854951222462d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7688132620204097d, y: 0.7524980294666802d), new NpgsqlTypes.NpgsqlPoint(x: 0.0020645952928916023d, y: 0.9008179333189945d), new NpgsqlTypes.NpgsqlPoint(x: 0.19086298232163368d, y: 0.9066725642482926d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3655110643045286d, y: 0.8047196064560997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266024490760109d, y: 0.1782053879943083d), new NpgsqlTypes.NpgsqlPoint(x: 0.9045814482457238d, y: 0.5297414720937413d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9981510915661089d, y: 0.1350391184188009d), new NpgsqlTypes.NpgsqlPoint(x: 0.06345297125550398d, y: 0.0077574020814240585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933968480708903d, y: 0.23889524127727912d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4229370492707445d, y: 0.8355520603367788d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036450446355785d, y: 0.3566530406933185d), new NpgsqlTypes.NpgsqlPoint(x: 0.6029950151891031d, y: 0.34627780876148384d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35040409556556584d, y: 0.2085563213562276d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973556549118249d, y: 0.22697150578548575d), new NpgsqlTypes.NpgsqlPoint(x: 0.3535520433889199d, y: 0.8003408482729522d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33616859166649693d, y: 0.8546709203054265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7336635421775315d, y: 0.1366036040877162d), new NpgsqlTypes.NpgsqlPoint(x: 0.4186910463722965d, y: 0.22051712046928384d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1875849785788598d, y: 0.6484700753199415d), new NpgsqlTypes.NpgsqlPoint(x: 0.4887635401248859d, y: 0.7123252417593484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9162702826032646d, y: 0.7104325374970223d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12016678586596985d, y: 0.17536223618029445d), new NpgsqlTypes.NpgsqlPoint(x: 0.20621384938929876d, y: 0.8180006507239813d), new NpgsqlTypes.NpgsqlPoint(x: 0.519111119829296d, y: 0.6024045372650518d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2998987273727979d, y: 0.5713189859958929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8868090725402925d, y: 0.4438183812044868d), new NpgsqlTypes.NpgsqlPoint(x: 0.11339073255713672d, y: 0.359333206398451d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4832713032361894d, y: 0.8946536749524611d), new NpgsqlTypes.NpgsqlPoint(x: 0.647919050369835d, y: 0.24990635443722942d), new NpgsqlTypes.NpgsqlPoint(x: 0.4427477327343501d, y: 0.5525386215563781d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.029788079876740592d, y: 0.6289721987872903d), new NpgsqlTypes.NpgsqlPoint(x: 0.1316593078090118d, y: 0.2657375902513177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5504516584130299d, y: 0.5120042017037847d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9928096935201928d, y: 0.9475387303973201d), new NpgsqlTypes.NpgsqlPoint(x: 0.6234309580971105d, y: 0.12074788938485148d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553399719944343d, y: 0.8994762233351299d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831912921049844d, y: 0.6223228052490254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6992937149465844d, y: 0.7412124991277903d), new NpgsqlTypes.NpgsqlPoint(x: 0.10921177550207994d, y: 0.14272419814057036d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9546896247720443d, y: 0.6770183322710952d), new NpgsqlTypes.NpgsqlPoint(x: 0.30056522435544974d, y: 0.16966788847035585d), new NpgsqlTypes.NpgsqlPoint(x: 0.19974071191858733d, y: 0.7310666159993731d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8115585708331183d, y: 0.465102754111951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201287816886565d, y: 0.18409063526258485d), new NpgsqlTypes.NpgsqlPoint(x: 0.07298740705774398d, y: 0.10517619142805601d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.337419544759181d, y: 0.2541458991126486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672182729844203d, y: 0.5404649384779634d), new NpgsqlTypes.NpgsqlPoint(x: 0.635101408730597d, y: 0.8240079444901902d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.837012533130217d, y: 0.41506896877216093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972369626016049d, y: 0.713362072207479d), new NpgsqlTypes.NpgsqlPoint(x: 0.17173976698257776d, y: 0.693687101510311d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.025283766141881325d, y: 0.9174045009059465d), new NpgsqlTypes.NpgsqlPoint(x: 0.19560200753083623d, y: 0.6278326340360622d), new NpgsqlTypes.NpgsqlPoint(x: 0.9773219130908453d, y: 0.245751753139836d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9020009065579092d, y: 0.5829932311773609d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843020354385384d, y: 0.7060662292935658d), new NpgsqlTypes.NpgsqlPoint(x: 0.32259625586595453d, y: 0.04361925791744137d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7057522936926733d, y: 0.35862826147593885d), new NpgsqlTypes.NpgsqlPoint(x: 0.11382702512931808d, y: 0.42172237036522575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121760131004705d, y: 0.2967220991309516d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5793436261414562d, y: 0.5270192396359494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554887088272856d, y: 0.4192522602238886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505952442552228d, y: 0.819166210303128d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12864232434840628d, y: 0.37374535986708024d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248658807399216d, y: 0.21058934153875086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277869981482964d, y: 0.1823748136348452d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7581545868336805d, y: 0.6144407033319506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658319001316931d, y: 0.43145678814022215d), new NpgsqlTypes.NpgsqlPoint(x: 0.489668781995379d, y: 0.6760460583465857d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.347521715745415d, y: 0.18534897984286314d), new NpgsqlTypes.NpgsqlPoint(x: 0.07036527035426365d, y: 0.3383283449462995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962624585313073d, y: 0.10153009994348339d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8947843397732029d, y: 0.9139799907098196d), new NpgsqlTypes.NpgsqlPoint(x: 0.1552098854245907d, y: 0.47714927548794916d), new NpgsqlTypes.NpgsqlPoint(x: 0.42377599963227897d, y: 0.7602239784888944d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1555763821677275d, y: 0.9555898094963143d), new NpgsqlTypes.NpgsqlPoint(x: 0.325680964877876d, y: 0.8210740858072275d), new NpgsqlTypes.NpgsqlPoint(x: 0.13093040882295048d, y: 0.05149009820976003d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2306116586705279d, y: 0.2528201926635646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5028914848202877d, y: 0.6872082425711582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5347850617584265d, y: 0.2698208439766948d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9505252711422677d, y: 0.14110031435900017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291702423578329d, y: 0.7216568216206652d), new NpgsqlTypes.NpgsqlPoint(x: 0.4966068030990016d, y: 0.8222397359429244d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5335614009438308d, y: 0.3969827023925018d), new NpgsqlTypes.NpgsqlPoint(x: 0.11494195191732337d, y: 0.674179883448391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977379162382227d, y: 0.6472076117444375d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13191456326051898d, y: 0.3766606042785624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134045648908033d, y: 0.5799912554549714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439252472671068d, y: 0.7838087179672065d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3023542239647127d, y: 0.9100919206749203d), new NpgsqlTypes.NpgsqlPoint(x: 0.19103066202444297d, y: 0.5321671194354343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447171506722743d, y: 0.5889063482517082d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6537672610056692d, y: 0.2726600527314629d), new NpgsqlTypes.NpgsqlPoint(x: 0.936895528948167d, y: 0.19680253809756354d), new NpgsqlTypes.NpgsqlPoint(x: 0.05246988123182439d, y: 0.5953102604328596d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11218592870936261d, y: 0.6663450467279064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267367761483607d, y: 0.09790305516559972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921295781267056d, y: 0.9111720950636288d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21768702686139252d, y: 0.30049136643397156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884069488415374d, y: 0.4103359996870495d), new NpgsqlTypes.NpgsqlPoint(x: 0.41550941841612843d, y: 0.3279823886980042d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.829647189399618d, y: 0.6773475434493449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7055010871543566d, y: 0.21556973196219187d), new NpgsqlTypes.NpgsqlPoint(x: 0.807869628304544d, y: 0.41494113845977587d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15324970632206825d, y: 0.2837952405080727d), new NpgsqlTypes.NpgsqlPoint(x: 0.29410870228735553d, y: 0.8660498851405479d), new NpgsqlTypes.NpgsqlPoint(x: 0.12401244892489638d, y: 0.9081291137197065d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42220697561849563d, y: 0.24831842906989654d), new NpgsqlTypes.NpgsqlPoint(x: 0.49707830301339295d, y: 0.2882094950789513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343976682359332d, y: 0.13382448328436203d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9241230590743316d, y: 0.08820042167836684d), new NpgsqlTypes.NpgsqlPoint(x: 0.0049832964131490964d, y: 0.5318812731614672d), new NpgsqlTypes.NpgsqlPoint(x: 0.2638120877619128d, y: 0.9515865655072522d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48870302607327865d, y: 0.5326822008221784d), new NpgsqlTypes.NpgsqlPoint(x: 0.11479838508952067d, y: 0.3902586460576968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2747695779356236d, y: 0.7695405660036903d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23922410837001074d, y: 0.750695095630217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7427997187197818d, y: 0.43109226665892375d), new NpgsqlTypes.NpgsqlPoint(x: 0.22272799299903523d, y: 0.6878480479339104d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9094180494455723d, y: 0.4972858986365152d), new NpgsqlTypes.NpgsqlPoint(x: 0.35977306726783087d, y: 0.7350344268211864d), new NpgsqlTypes.NpgsqlPoint(x: 0.452351796391645d, y: 0.2260634590432502d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4640789771425885d, y: 0.3014443954278464d), new NpgsqlTypes.NpgsqlPoint(x: 0.03710720372455745d, y: 0.9931240273540365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194027665528138d, y: 0.2897689030805144d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9540033879988631d, y: 0.03797408513126199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374474750890804d, y: 0.17373005399858732d), new NpgsqlTypes.NpgsqlPoint(x: 0.0177147764595752d, y: 0.7162990723704715d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6705397520146378d, y: 0.5843003775343031d), new NpgsqlTypes.NpgsqlPoint(x: 0.12338820372842974d, y: 0.3406348330585819d), new NpgsqlTypes.NpgsqlPoint(x: 0.11842382811736296d, y: 0.44219951545153524d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24199197128358807d, y: 0.40288395667324295d), new NpgsqlTypes.NpgsqlPoint(x: 0.14916059809720317d, y: 0.5800355853364005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9254243397860292d, y: 0.9224020606715145d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9906919273559274d, y: 0.717292046779885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824160952954706d, y: 0.1344486870749455d), new NpgsqlTypes.NpgsqlPoint(x: 0.1693863052489678d, y: 0.7086099052901423d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11377626225984594d, y: 0.9976923199917704d), new NpgsqlTypes.NpgsqlPoint(x: 0.942135783478154d, y: 0.29610696795316727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572813748290794d, y: 0.4151639480949574d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6189951051221044d, y: 0.5183124204707678d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262911336545963d, y: 0.6212169466739551d), new NpgsqlTypes.NpgsqlPoint(x: 0.41494661714805414d, y: 0.9796859750982576d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24933085627998464d, y: 0.6051572881960516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026045719919276d, y: 0.8077637868176094d), new NpgsqlTypes.NpgsqlPoint(x: 0.02827606600947541d, y: 0.7277280937853433d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3499408333935131d, y: 0.08912407500023944d), new NpgsqlTypes.NpgsqlPoint(x: 0.20748612888649876d, y: 0.009949651204609666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294498240902571d, y: 0.9966984804334874d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3414271463737941d, y: 0.056961646729156934d), new NpgsqlTypes.NpgsqlPoint(x: 0.24385724056351976d, y: 0.5147932995503123d), new NpgsqlTypes.NpgsqlPoint(x: 0.20840410208617577d, y: 0.8523354078656709d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10849353854736044d, y: 0.37515332312192284d), new NpgsqlTypes.NpgsqlPoint(x: 0.20605828960968642d, y: 0.47328085589903d), new NpgsqlTypes.NpgsqlPoint(x: 0.34558890369409545d, y: 0.0026298096219562472d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5237497082543608d, y: 0.3821363185766833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658206561677011d, y: 0.7889000051897779d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988241668253349d, y: 0.17678951337844762d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7514696506590222d, y: 0.23293556015542782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106399356103897d, y: 0.14701711111830218d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566528433945549d, y: 0.8747125943269358d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6271908786380457d, y: 0.8408315751772354d), new NpgsqlTypes.NpgsqlPoint(x: 0.12253262927379038d, y: 0.11594193665326247d), new NpgsqlTypes.NpgsqlPoint(x: 0.4717727332112137d, y: 0.8938352537053238d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47296342502886324d, y: 0.03734684662094667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757987841442187d, y: 0.439366788499276d), new NpgsqlTypes.NpgsqlPoint(x: 0.0050927534371361105d, y: 0.5268972448607971d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9355580737908563d, y: 0.012549858079012655d), new NpgsqlTypes.NpgsqlPoint(x: 0.882549513479416d, y: 0.8559530472798381d), new NpgsqlTypes.NpgsqlPoint(x: 0.44819904209217043d, y: 0.26035457115191407d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1439317362181305d, y: 0.413782050881075d), new NpgsqlTypes.NpgsqlPoint(x: 0.122673690920861d, y: 0.5826862721622827d), new NpgsqlTypes.NpgsqlPoint(x: 0.8208319633237658d, y: 0.5919523509443503d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5857164970994162d, y: 0.9907928776307927d), new NpgsqlTypes.NpgsqlPoint(x: 0.36228058005751873d, y: 0.2562063110738052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089307893954616d, y: 0.5769241491765275d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6201298342319691d, y: 0.4452473553809426d), new NpgsqlTypes.NpgsqlPoint(x: 0.15732367732198282d, y: 0.4193750879808217d), new NpgsqlTypes.NpgsqlPoint(x: 0.04656198301080783d, y: 0.7015348586379447d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8720660000119456d, y: 0.3608284548632441d), new NpgsqlTypes.NpgsqlPoint(x: 0.008184139050651407d, y: 0.4777469982115863d), new NpgsqlTypes.NpgsqlPoint(x: 0.3622810837247842d, y: 0.6892628191596348d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9259626788882881d, y: 0.6297269816785405d), new NpgsqlTypes.NpgsqlPoint(x: 0.41527292091871115d, y: 0.7857196752933782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7000307962785522d, y: 0.5645976055162059d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06403658377289678d, y: 0.41918286684310135d), new NpgsqlTypes.NpgsqlPoint(x: 0.074671036284089d, y: 0.3882355166801552d), new NpgsqlTypes.NpgsqlPoint(x: 0.4866584902823359d, y: 0.571895569800987d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35059571165537706d, y: 0.5830997544049674d), new NpgsqlTypes.NpgsqlPoint(x: 0.015885204114668983d, y: 0.5059247137733063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734120212165607d, y: 0.12606398993634294d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5000335162141818d, y: 0.5626173859722546d), new NpgsqlTypes.NpgsqlPoint(x: 0.060870110846052206d, y: 0.8608794165285465d), new NpgsqlTypes.NpgsqlPoint(x: 0.5329032653876898d, y: 0.30315576975276315d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9015135713180228d, y: 0.30935512050777403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614847992950243d, y: 0.8753037175811921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526800986596579d, y: 0.1290639253384135d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7063845289982916d, y: 0.8572733072070267d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056548931168094d, y: 0.9226077391424592d), new NpgsqlTypes.NpgsqlPoint(x: 0.1684247879865396d, y: 0.5060786746780287d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0014353398639823656d, y: 0.006391592520100242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079642261400193d, y: 0.2843994292627935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9416326846619519d, y: 0.33239422327378043d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6133892271508798d, y: 0.7833672604301145d), new NpgsqlTypes.NpgsqlPoint(x: 0.00633788499735688d, y: 0.46553691702336086d), new NpgsqlTypes.NpgsqlPoint(x: 0.2411632833066012d, y: 0.6926318470048426d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8874256789047719d, y: 0.30631632200349124d), new NpgsqlTypes.NpgsqlPoint(x: 0.48516891333939083d, y: 0.06142304956487188d), new NpgsqlTypes.NpgsqlPoint(x: 0.09926847994058852d, y: 0.33975462818384705d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7700719680831423d, y: 0.3722150930690533d), new NpgsqlTypes.NpgsqlPoint(x: 0.45786295310466474d, y: 0.383911388919423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386367906608592d, y: 0.8797555545824933d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9327072149179807d, y: 0.6503552958815404d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038279287012751d, y: 0.2179831317233505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131320489245981d, y: 0.966979254255868d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6397313296620505d, y: 0.46971652123948093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255589526529445d, y: 0.6369424364648021d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568544198542227d, y: 0.4685565713530673d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9981497969505727d, y: 0.943519221804707d), new NpgsqlTypes.NpgsqlPoint(x: 0.18114653000074576d, y: 0.7470162992071476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764450530612777d, y: 0.9201338345919686d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5392367571636068d, y: 0.167861897020941d), new NpgsqlTypes.NpgsqlPoint(x: 0.05356842101413439d, y: 0.28339909096716676d), new NpgsqlTypes.NpgsqlPoint(x: 0.24030391939646767d, y: 0.6671757128509772d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40013267502476335d, y: 0.5572864749320284d), new NpgsqlTypes.NpgsqlPoint(x: 0.12107453412859326d, y: 0.21687790206616875d), new NpgsqlTypes.NpgsqlPoint(x: 0.8061310396741551d, y: 0.171594830451271d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09315123230708833d, y: 0.5939923709396928d), new NpgsqlTypes.NpgsqlPoint(x: 0.04730274257725098d, y: 0.5646279321019164d), new NpgsqlTypes.NpgsqlPoint(x: 0.34930003808330956d, y: 0.044746708809939584d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3280676216889725d, y: 0.44078279258570563d), new NpgsqlTypes.NpgsqlPoint(x: 0.710588800533646d, y: 0.7852360101546526d), new NpgsqlTypes.NpgsqlPoint(x: 0.10568683806147572d, y: 0.14988660187419534d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12271216753036662d, y: 0.8898062687051959d), new NpgsqlTypes.NpgsqlPoint(x: 0.2375302752352768d, y: 0.5016341836481866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566201255356286d, y: 0.22233426868614026d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.603827717753025d, y: 0.8423009995638915d), new NpgsqlTypes.NpgsqlPoint(x: 0.10319120721431685d, y: 0.8083884504735719d), new NpgsqlTypes.NpgsqlPoint(x: 0.9189231627852028d, y: 0.28349280876477534d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8225586712918578d, y: 0.9742241542316424d), new NpgsqlTypes.NpgsqlPoint(x: 0.26928218845104723d, y: 0.10051839465449752d), new NpgsqlTypes.NpgsqlPoint(x: 0.2916988199327766d, y: 0.27276104505519494d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33736291646611927d, y: 0.1980678853319492d), new NpgsqlTypes.NpgsqlPoint(x: 0.17018701981788298d, y: 0.1517880467341346d), new NpgsqlTypes.NpgsqlPoint(x: 0.5419553085911364d, y: 0.019374286189975942d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3323837551901364d, y: 0.8396611986037779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4094539987828506d, y: 0.4667778309256625d), new NpgsqlTypes.NpgsqlPoint(x: 0.029919943268741145d, y: 0.33627094249599576d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00464921850816824d, y: 0.2354075200965492d), new NpgsqlTypes.NpgsqlPoint(x: 0.2644864101702008d, y: 0.9230056829316278d), new NpgsqlTypes.NpgsqlPoint(x: 0.20631863828958508d, y: 0.8822369884893684d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7753517610338497d, y: 0.33512018437097923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333323886940448d, y: 0.718919863017257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039585145864218d, y: 0.04698198232596029d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6377417757438938d, y: 0.2553436196612868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906258924373056d, y: 0.9968692184528799d), new NpgsqlTypes.NpgsqlPoint(x: 0.4213883607355373d, y: 0.14723380509900075d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5142727672420215d, y: 0.7613330025737066d), new NpgsqlTypes.NpgsqlPoint(x: 0.025500819707307887d, y: 0.785676829096247d), new NpgsqlTypes.NpgsqlPoint(x: 0.47608431356351966d, y: 0.05609312917278575d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7154503748941582d, y: 0.48478435518764207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143821234216415d, y: 0.20871195402374776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7563346926906108d, y: 0.2799617791869816d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012088631980302633d, y: 0.8356686777888888d), new NpgsqlTypes.NpgsqlPoint(x: 0.11024746938143581d, y: 0.7183447332403419d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134619715688417d, y: 0.9305161030970617d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28793385747391d, y: 0.2956355495404883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5067015268924502d, y: 0.7447091999718801d), new NpgsqlTypes.NpgsqlPoint(x: 0.8529222721418779d, y: 0.8994045905864015d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26242240386779825d, y: 0.3477231245454242d), new NpgsqlTypes.NpgsqlPoint(x: 0.28910526266538783d, y: 0.8914431144709877d), new NpgsqlTypes.NpgsqlPoint(x: 0.10992264021528197d, y: 0.8708613766139947d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8634318080588634d, y: 0.9327165901400658d), new NpgsqlTypes.NpgsqlPoint(x: 0.872147279226149d, y: 0.14378998212552419d), new NpgsqlTypes.NpgsqlPoint(x: 0.11587786923927679d, y: 0.973534145726134d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9712580540774751d, y: 0.8218060344537366d), new NpgsqlTypes.NpgsqlPoint(x: 0.6744736584204652d, y: 0.01656048655969089d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518742965860342d, y: 0.8560204148901901d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10810085007600234d, y: 0.5639347781610022d), new NpgsqlTypes.NpgsqlPoint(x: 0.4375921079467824d, y: 0.6479464741230726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663227855119213d, y: 0.72515158275816d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5521884675070641d, y: 0.38313287663266105d), new NpgsqlTypes.NpgsqlPoint(x: 0.033536668270750636d, y: 0.4646656248730202d), new NpgsqlTypes.NpgsqlPoint(x: 0.08281468614881071d, y: 0.1850010002802318d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6605417245608721d, y: 0.6176928087884248d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921383312623191d, y: 0.25062805706649294d), new NpgsqlTypes.NpgsqlPoint(x: 0.8351727912769056d, y: 0.31927242501931297d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34482936092670746d, y: 0.8254666190431706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624033662406873d, y: 0.46582737798838103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6028156759381387d, y: 0.4702330134114697d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3832890435377203d, y: 0.07767392413177143d), new NpgsqlTypes.NpgsqlPoint(x: 0.3492155282008662d, y: 0.07684739901059157d), new NpgsqlTypes.NpgsqlPoint(x: 0.736808838866219d, y: 0.49584048315580154d)), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31105165726961814d, y: 0.6609890650909848d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187430042548721d, y: 0.20013362115866307d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349169115453527d, y: 0.8155048846926125d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2123589517850527d, y: 0.5834163746261831d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366795275056973d, y: 0.280382687950157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785740976494568d, y: 0.5323832263653662d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5198439379593395d, y: 0.09860302739023852d), new NpgsqlTypes.NpgsqlPoint(x: 0.10979398458616263d, y: 0.2788775562302652d), new NpgsqlTypes.NpgsqlPoint(x: 0.0803490587258926d, y: 0.27803713784228434d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3020100986870058d, y: 0.6422978124335864d), new NpgsqlTypes.NpgsqlPoint(x: 0.22296506175365838d, y: 0.2963757390373942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530629953979311d, y: 0.5972744490084393d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5676243854067553d, y: 0.9285780629708322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860662584615739d, y: 0.18643989626644986d), new NpgsqlTypes.NpgsqlPoint(x: 0.23854874252943614d, y: 0.4201404449258187d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7280958815204662d, y: 0.6175730712037917d), new NpgsqlTypes.NpgsqlPoint(x: 0.39060185733594055d, y: 0.856460762909273d), new NpgsqlTypes.NpgsqlPoint(x: 0.6795366299540716d, y: 0.7678549908155716d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46876144199144065d, y: 0.8498734579861655d), new NpgsqlTypes.NpgsqlPoint(x: 0.08946759157535444d, y: 0.4474554862527088d), new NpgsqlTypes.NpgsqlPoint(x: 0.15548476181672188d, y: 0.14120408970717302d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0975628404477542d, y: 0.3171214980881748d), new NpgsqlTypes.NpgsqlPoint(x: 0.16141586310387013d, y: 0.09977913579916131d), new NpgsqlTypes.NpgsqlPoint(x: 0.1564673869169232d, y: 0.9299667031383198d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5251829232218603d, y: 0.4343315122020551d), new NpgsqlTypes.NpgsqlPoint(x: 0.965799808244247d, y: 0.15537072249539774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216856531951945d, y: 0.30383582772383844d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9731729126893996d, y: 0.20318049293825136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799961834241561d, y: 0.6708652422523119d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935552613335922d, y: 0.9160264506965902d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7489984140457756d, y: 0.1290239378575374d), new NpgsqlTypes.NpgsqlPoint(x: 0.2051851020974258d, y: 0.5817079367725156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794241284516711d, y: 0.08660349587925442d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30503019545694654d, y: 0.661180232761636d), new NpgsqlTypes.NpgsqlPoint(x: 0.32413051461599696d, y: 0.3471857574754088d), new NpgsqlTypes.NpgsqlPoint(x: 0.39208310261748003d, y: 0.25042738577952695d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 57, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 61, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 138, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 145, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 99, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI), typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

