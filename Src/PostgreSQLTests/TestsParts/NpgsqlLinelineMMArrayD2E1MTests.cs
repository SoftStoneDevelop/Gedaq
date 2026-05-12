

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
    internal partial interface INpgsqlLineMArraylineMMArrayD2
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD2 : INpgsqlLineMArraylineMMArrayD2
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD2E1M[] _testData = new NpgsqlLinelineMMArrayD2E1M[]
        {
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.47971459489920343d, b: 0.18347913114324932d, c: 0.3235057473873041d), new NpgsqlTypes.NpgsqlLine(a: 0.7303583663397747d, b: 0.585073582632126d, c: 0.21755174054283255d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06270436470368634d, b: 0.9046058377026576d, c: 0.6485291316968751d), new NpgsqlTypes.NpgsqlLine(a: 0.7478772802535969d, b: 0.4754553826693775d, c: 0.8503101410171078d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5788348970051694d, b: 0.683243092001633d, c: 0.14788338725175154d), new NpgsqlTypes.NpgsqlLine(a: 0.29572728887318545d, b: 0.07601300632147767d, c: 0.16739732231216753d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8069043568162869d, b: 0.9805626750798729d, c: 0.44188560386967013d), new NpgsqlTypes.NpgsqlLine(a: 0.5314183980897531d, b: 0.3386329258727758d, c: 0.6126382367247823d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.020260843668444384d, b: 0.34235819018549485d, c: 0.5809648872207236d), new NpgsqlTypes.NpgsqlLine(a: 0.8778512066433427d, b: 0.19786252110126867d, c: 0.051318086210318636d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6461619562347249d, b: 0.426794048334344d, c: 0.0056827359099271835d), new NpgsqlTypes.NpgsqlLine(a: 0.4550971003752291d, b: 0.6799746409175723d, c: 0.08005112754380117d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5688375557390729d, b: 0.2242542509747174d, c: 0.3166353293682127d), new NpgsqlTypes.NpgsqlLine(a: 0.6948280745670133d, b: 0.7240987986784039d, c: 0.9555461842904114d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.22536202647675152d, b: 0.9704575646073851d, c: 0.6864883465632438d), new NpgsqlTypes.NpgsqlLine(a: 0.8218566371247321d, b: 0.6520197978810631d, c: 0.1722194163394296d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2505024426703798d, b: 0.2984543765712464d, c: 0.2504063541135696d), new NpgsqlTypes.NpgsqlLine(a: 0.023796523085557242d, b: 0.10075972954703072d, c: 0.3276791727515581d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7663422259841576d, b: 0.027671801767743642d, c: 0.4128315783780493d), new NpgsqlTypes.NpgsqlLine(a: 0.1461819069853434d, b: 0.5068123050388234d, c: 0.039795134280622424d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12137304679600758d, b: 0.36014395937498334d, c: 0.4547761536012439d), new NpgsqlTypes.NpgsqlLine(a: 0.30549640509796216d, b: 0.2602849711722639d, c: 0.9536012901224941d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5454422453607499d, b: 0.3563898215133686d, c: 0.21786787109098482d), new NpgsqlTypes.NpgsqlLine(a: 0.06850997429671535d, b: 0.015811867057924367d, c: 0.5988717798250188d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9403186284027762d, b: 0.5987976769188446d, c: 0.8057024738409285d), new NpgsqlTypes.NpgsqlLine(a: 0.5171225084501082d, b: 0.7357339880949925d, c: 0.663527350027198d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.45425224905439665d, b: 0.21520975024254452d, c: 0.42890073975370935d), new NpgsqlTypes.NpgsqlLine(a: 0.7562543752524136d, b: 0.4480249882706906d, c: 0.41807953517918883d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.11348969781311291d, b: 0.38083114217564673d, c: 0.44960904528205725d), new NpgsqlTypes.NpgsqlLine(a: 0.6855208058198224d, b: 0.24427817965535503d, c: 0.818873904340106d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6499854204799824d, b: 0.00693344460688361d, c: 0.5886839167417882d), new NpgsqlTypes.NpgsqlLine(a: 0.9748413762175513d, b: 0.1265410255838294d, c: 0.44759768626225405d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9858198285011638d, b: 0.3615825215136944d, c: 0.6702686416238863d), new NpgsqlTypes.NpgsqlLine(a: 0.4005697115962482d, b: 0.3778756084503222d, c: 0.9520453783197403d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.254561963166939d, b: 0.2851242765415761d, c: 0.5491838035322991d), new NpgsqlTypes.NpgsqlLine(a: 0.8477056703984401d, b: 0.9511316049391615d, c: 0.8190240642858525d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9588409794280287d, b: 0.04571438555720553d, c: 0.06926568404018074d), new NpgsqlTypes.NpgsqlLine(a: 0.07583510601584997d, b: 0.6585450618736276d, c: 0.50288080811911d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6011450535671963d, b: 0.061996488263838634d, c: 0.6838586457463819d), new NpgsqlTypes.NpgsqlLine(a: 0.33959787093476235d, b: 0.23411422184502118d, c: 0.6331335920344703d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.708956314941344d, b: 0.26363756450979936d, c: 0.34688425606750517d), new NpgsqlTypes.NpgsqlLine(a: 0.41625697756782554d, b: 0.3102820431773432d, c: 0.3717073900714182d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.13027033169077107d, b: 0.7141914996120607d, c: 0.5796505224366693d), new NpgsqlTypes.NpgsqlLine(a: 0.04716885831830564d, b: 0.44646853060891933d, c: 0.2812324072147595d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7068176871220463d, b: 0.38320300857295675d, c: 0.24548926659858128d), new NpgsqlTypes.NpgsqlLine(a: 0.32021535947824065d, b: 0.38387540311559887d, c: 0.4492308549960279d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8070137178307487d, b: 0.5004745889776466d, c: 0.4935813743006511d), new NpgsqlTypes.NpgsqlLine(a: 0.8084303197061671d, b: 0.8357859222587111d, c: 0.6950085575499729d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6755770730079224d, b: 0.17664585423874934d, c: 0.9186102276948508d), new NpgsqlTypes.NpgsqlLine(a: 0.16370573799204746d, b: 0.9185314498212036d, c: 0.2756493623257903d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.596517561257358d, b: 0.012139479180971469d, c: 0.03180349320747d), new NpgsqlTypes.NpgsqlLine(a: 0.9602934000044825d, b: 0.5062943459086641d, c: 0.543169452640207d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.06161980735765693d, b: 0.9421355354080153d, c: 0.875579061548893d), new NpgsqlTypes.NpgsqlLine(a: 0.635294792368067d, b: 0.13484216776316782d, c: 0.42774881492288896d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.40767284842778495d, b: 0.9663722703788383d, c: 0.5912592926702553d), new NpgsqlTypes.NpgsqlLine(a: 0.42861433071405386d, b: 0.5160686488241744d, c: 0.5338720690676254d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8425021291845995d, b: 0.4318573324821994d, c: 0.9453321298078284d), new NpgsqlTypes.NpgsqlLine(a: 0.09059766376583989d, b: 0.49912412232229153d, c: 0.7721885867169852d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9601289057438569d, b: 0.4926940790343878d, c: 0.2893125546893184d), new NpgsqlTypes.NpgsqlLine(a: 0.8013751560541285d, b: 0.593089698769954d, c: 0.15968512408541768d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5430863436170573d, b: 0.2165160837921274d, c: 0.1821376261044283d), new NpgsqlTypes.NpgsqlLine(a: 0.37196938259173495d, b: 0.024517376344567188d, c: 0.8957611229119729d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3128425902735721d, b: 0.642094036315629d, c: 0.41974398253763867d), new NpgsqlTypes.NpgsqlLine(a: 0.7895057014428045d, b: 0.3515643823827944d, c: 0.215296016449397d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6473509692168207d, b: 0.8523534896735656d, c: 0.48808084676106545d), new NpgsqlTypes.NpgsqlLine(a: 0.06920267352092568d, b: 0.4428744456006647d, c: 0.5068280081428315d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9164464349388404d, b: 0.22101853101759827d, c: 0.8180304641631778d), new NpgsqlTypes.NpgsqlLine(a: 0.5853367508773184d, b: 0.9678120686276648d, c: 0.39839945352042183d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7243472526391922d, b: 0.08212093629649275d, c: 0.14620178736068112d), new NpgsqlTypes.NpgsqlLine(a: 0.276542104549682d, b: 0.487276690946874d, c: 0.8269722517648308d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6596473763807623d, b: 0.013985251305952517d, c: 0.39187086551081174d), new NpgsqlTypes.NpgsqlLine(a: 0.49034190081775d, b: 0.731516751424192d, c: 0.5633772765307974d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3248205653860933d, b: 0.767468106865294d, c: 0.9913171990874188d), new NpgsqlTypes.NpgsqlLine(a: 0.3874567586443649d, b: 0.13425342224219483d, c: 0.7638253021837953d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6756131133731725d, b: 0.020526428460911794d, c: 0.015795143794498978d), new NpgsqlTypes.NpgsqlLine(a: 0.15865648462820336d, b: 0.5503990443702015d, c: 0.3307831623044105d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6057574692009724d, b: 0.1931322486203807d, c: 0.5913316582707053d), new NpgsqlTypes.NpgsqlLine(a: 0.047306755325732586d, b: 0.11597814372825832d, c: 0.18686593435548526d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7311194834169674d, b: 0.04790079585133078d, c: 0.6909740673573354d), new NpgsqlTypes.NpgsqlLine(a: 0.8785699557646851d, b: 0.3059214812223552d, c: 0.6605204524111409d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1559288623270898d, b: 0.9406973998266404d, c: 0.3327837767534316d), new NpgsqlTypes.NpgsqlLine(a: 0.765163464490955d, b: 0.1846798838995417d, c: 0.11449366851365006d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.09014800217811059d, b: 0.9606526516969561d, c: 0.6127201526794112d), new NpgsqlTypes.NpgsqlLine(a: 0.1542262897728156d, b: 0.26548468233480615d, c: 0.23253603979974558d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7000984862466565d, b: 0.5920097007261014d, c: 0.7484942805793103d), new NpgsqlTypes.NpgsqlLine(a: 0.3198958732406505d, b: 0.982856945845198d, c: 0.5313279602538865d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.827377738058463d, b: 0.8510408959144141d, c: 0.7764422195688989d), new NpgsqlTypes.NpgsqlLine(a: 0.35905770540412474d, b: 0.501425849570851d, c: 0.3801094778861085d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.621178807369171d, b: 0.9239310782520789d, c: 0.49653079513608933d), new NpgsqlTypes.NpgsqlLine(a: 0.022415579974944033d, b: 0.9952832108031302d, c: 0.19851713713405938d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.19042657396189977d, b: 0.6782675377337996d, c: 0.034757670060278634d), new NpgsqlTypes.NpgsqlLine(a: 0.9077738771831785d, b: 0.08968933809734914d, c: 0.3071978079547891d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7084295578511908d, b: 0.6722207432090491d, c: 0.10267875048050012d), new NpgsqlTypes.NpgsqlLine(a: 0.752931209652452d, b: 0.2722220450364353d, c: 0.9552778455497524d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.16523743159664073d, b: 0.5791528692795912d, c: 0.9834805087456558d), new NpgsqlTypes.NpgsqlLine(a: 0.8810676778853402d, b: 0.4760702099398715d, c: 0.03637757659241658d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7130091581049652d, b: 0.12296071564866473d, c: 0.7826895136755316d), new NpgsqlTypes.NpgsqlLine(a: 0.328976948329615d, b: 0.858674328280018d, c: 0.5170098808580584d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6986632165484551d, b: 0.9865641929300235d, c: 0.7578509915456748d), new NpgsqlTypes.NpgsqlLine(a: 0.21360936893320792d, b: 0.05380022991973399d, c: 0.4290263634225796d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4939223898270477d, b: 0.7013054894229774d, c: 0.163893803915222d), new NpgsqlTypes.NpgsqlLine(a: 0.7068558237453364d, b: 0.3826467583940337d, c: 0.74900673493537d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7602140653721058d, b: 0.38915033350281913d, c: 0.17211188854370285d), new NpgsqlTypes.NpgsqlLine(a: 0.856101657351266d, b: 0.48102085746952983d, c: 0.24679558233639998d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.29481457662460786d, b: 0.32461300375163604d, c: 0.20227949429859637d), new NpgsqlTypes.NpgsqlLine(a: 0.10950773723124219d, b: 0.024793020126923637d, c: 0.18961303916019268d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8428373666776859d, b: 0.10770167148394516d, c: 0.2489936482134073d), new NpgsqlTypes.NpgsqlLine(a: 0.8220865553287294d, b: 0.2437402583502737d, c: 0.40381046159594614d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8730874687408305d, b: 0.530894937282654d, c: 0.49273401187036325d), new NpgsqlTypes.NpgsqlLine(a: 0.017655210744217498d, b: 0.097081756674259d, c: 0.9548477781369435d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9365270603790892d, b: 0.7366797336268271d, c: 0.18618467727980936d), new NpgsqlTypes.NpgsqlLine(a: 0.33689428013772516d, b: 0.9671237008853177d, c: 0.06923912916500863d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7659102492770455d, b: 0.03949947240896279d, c: 0.7632681171674192d), new NpgsqlTypes.NpgsqlLine(a: 0.9861533080641394d, b: 0.7674901267572136d, c: 0.14688006630506745d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.440183086203216d, b: 0.9252020027673439d, c: 0.639223633789558d), new NpgsqlTypes.NpgsqlLine(a: 0.9497586790627909d, b: 0.9092083057849641d, c: 0.4169227325954854d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.47351502449990934d, b: 0.9966948298873002d, c: 0.8432810319419616d), new NpgsqlTypes.NpgsqlLine(a: 0.49269881065861065d, b: 0.04210753341177487d, c: 0.8201773248638945d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5652965977511748d, b: 0.8978676526094029d, c: 0.9012179089483833d), new NpgsqlTypes.NpgsqlLine(a: 0.15968302581458071d, b: 0.5716088470179407d, c: 0.18466617609641056d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9284307480041823d, b: 0.1509470276856989d, c: 0.26027919263465427d), new NpgsqlTypes.NpgsqlLine(a: 0.8304304633249695d, b: 0.1587636830261413d, c: 0.21957917549986805d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9644367517564733d, b: 0.05104058391369992d, c: 0.7981430481320227d), new NpgsqlTypes.NpgsqlLine(a: 0.6880934563902008d, b: 0.7676702884627665d, c: 0.8106966323242178d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3155257671947448d, b: 0.3316422095045528d, c: 0.4187308265066477d), new NpgsqlTypes.NpgsqlLine(a: 0.1039781177605823d, b: 0.8862205817972625d, c: 0.22696144656679573d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6928763524141865d, b: 0.021689319642780203d, c: 0.5866878082238006d), new NpgsqlTypes.NpgsqlLine(a: 0.9055254243599743d, b: 0.501617547830924d, c: 0.5387756697141084d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.042608416942155336d, b: 0.4887321284558974d, c: 0.6752642967883015d), new NpgsqlTypes.NpgsqlLine(a: 0.7255381636128676d, b: 0.45481885344491535d, c: 0.822163086879502d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7202415508854664d, b: 0.5266197472231241d, c: 0.34389793020492443d), new NpgsqlTypes.NpgsqlLine(a: 0.9254224545974772d, b: 0.8673287283272373d, c: 0.08819067074031006d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.26951713171747493d, b: 0.17505161121090296d, c: 0.7814431245733244d), new NpgsqlTypes.NpgsqlLine(a: 0.21913736002793416d, b: 0.8701667091844063d, c: 0.4067454656203434d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23040476458262793d, b: 0.09436797068970182d, c: 0.19528565725456193d), new NpgsqlTypes.NpgsqlLine(a: 0.6634512836154063d, b: 0.9375183184301348d, c: 0.46818968268326233d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9910093414653403d, b: 0.28555470548323325d, c: 0.019816216923845054d), new NpgsqlTypes.NpgsqlLine(a: 0.5881719506019676d, b: 0.23353241275516567d, c: 0.6172080712301378d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4597773890028046d, b: 0.8314742361382284d, c: 0.08084029303646423d), new NpgsqlTypes.NpgsqlLine(a: 0.10925555150492039d, b: 0.5497818798485765d, c: 0.6142042187334423d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3698852697135917d, b: 0.8621671920773996d, c: 0.5117095954689133d), new NpgsqlTypes.NpgsqlLine(a: 0.2666235878722142d, b: 0.6599465630600605d, c: 0.8859082244155423d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.13491541130012596d, b: 0.8277411541085337d, c: 0.5460255884148896d), new NpgsqlTypes.NpgsqlLine(a: 0.5429674331271234d, b: 0.1728117174702981d, c: 0.5293414995057837d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.29797923940517124d, b: 0.751990085797805d, c: 0.60005598177151d), new NpgsqlTypes.NpgsqlLine(a: 0.5828674558458116d, b: 0.8148553087136966d, c: 0.8288509481303887d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.0689548416730974d, b: 0.3145093212118004d, c: 0.9372276768659937d), new NpgsqlTypes.NpgsqlLine(a: 0.931207998485279d, b: 0.4867526916931231d, c: 0.5133820144841058d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4951603935271547d, b: 0.8439023053784313d, c: 0.8271957008452548d), new NpgsqlTypes.NpgsqlLine(a: 0.47864144632127315d, b: 0.007400493626110172d, c: 0.3838799538477182d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8185645138141993d, b: 0.11305388496287794d, c: 0.43042561424783155d), new NpgsqlTypes.NpgsqlLine(a: 0.8914181610161699d, b: 0.6325821934619043d, c: 0.7036084494730422d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6023357560167512d, b: 0.16960076345973252d, c: 0.9790599354100774d), new NpgsqlTypes.NpgsqlLine(a: 0.7946368371702023d, b: 0.8640620181043618d, c: 0.9449552613587746d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.47116377372089946d, b: 0.36824210688901493d, c: 0.831609918884506d), new NpgsqlTypes.NpgsqlLine(a: 0.2986599893429539d, b: 0.29164729773267806d, c: 0.08540779504536988d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5948563094813086d, b: 0.4397973742615756d, c: 0.5829988938465784d), new NpgsqlTypes.NpgsqlLine(a: 0.5312051714670643d, b: 0.08096129632381166d, c: 0.2691439271810705d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.1557088127790489d, b: 0.41409966551342603d, c: 0.6079635276751022d), new NpgsqlTypes.NpgsqlLine(a: 0.2600107190210337d, b: 0.3856073669047857d, c: 0.510544122637385d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.17836509052665084d, b: 0.46277523627486994d, c: 0.2429740673686126d), new NpgsqlTypes.NpgsqlLine(a: 0.02053501116558598d, b: 0.13417658333770888d, c: 0.19517408974631423d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6190509220290816d, b: 0.6663282718096201d, c: 0.8846748829044824d), new NpgsqlTypes.NpgsqlLine(a: 0.38388753046584034d, b: 0.40222501117382803d, c: 0.9987487444886408d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5214070700900425d, b: 0.17488023644043205d, c: 0.8336935264016945d), new NpgsqlTypes.NpgsqlLine(a: 0.7633104076169224d, b: 0.2203435417893319d, c: 0.09472178044036139d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6917546743207922d, b: 0.415527515685315d, c: 0.941113306641751d), new NpgsqlTypes.NpgsqlLine(a: 0.14882469338587623d, b: 0.9271764236159288d, c: 0.8858960466160735d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.35314427006947147d, b: 0.5043178429466032d, c: 0.49389175379852d), new NpgsqlTypes.NpgsqlLine(a: 0.35455761777049133d, b: 0.623290913050242d, c: 0.6808129979403179d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.11712427468349451d, b: 0.5092847019428767d, c: 0.530716165637534d), new NpgsqlTypes.NpgsqlLine(a: 0.5462932242996028d, b: 0.07790396969688362d, c: 0.12190857942651356d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5172792409419998d, b: 0.014259194209250703d, c: 0.5499015908842197d), new NpgsqlTypes.NpgsqlLine(a: 0.04582946423660528d, b: 0.07068108728286149d, c: 0.05661222651726883d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9408309117473416d, b: 0.2181508408773155d, c: 0.2795356944444002d), new NpgsqlTypes.NpgsqlLine(a: 0.37629582091459135d, b: 0.6101529960879812d, c: 0.8588236055591801d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2749822902553768d, b: 0.7707268978877456d, c: 0.028605789112333135d), new NpgsqlTypes.NpgsqlLine(a: 0.6860892426534894d, b: 0.8611369839429482d, c: 0.6102345373699587d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7279524607141756d, b: 0.12452567389175451d, c: 0.21324030423850848d), new NpgsqlTypes.NpgsqlLine(a: 0.7006601353933061d, b: 0.2934196643510435d, c: 0.5991863515507457d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6963399233477147d, b: 0.4762914484764068d, c: 0.7840638514667551d), new NpgsqlTypes.NpgsqlLine(a: 0.22042870008939175d, b: 0.19347851360540513d, c: 0.01035023227592613d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9499608284573847d, b: 0.6504952872231992d, c: 0.859929359330308d), new NpgsqlTypes.NpgsqlLine(a: 0.5309709412034829d, b: 0.9441140935383666d, c: 0.185792873081999d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7144463220188914d, b: 0.6954925807544347d, c: 0.8074188589728968d), new NpgsqlTypes.NpgsqlLine(a: 0.0035020939369441173d, b: 0.17495354840834432d, c: 0.3154027574733793d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7473183244967462d, b: 0.813970660421248d, c: 0.09719154662346008d), new NpgsqlTypes.NpgsqlLine(a: 0.3566839586123305d, b: 0.5677540892264561d, c: 0.5936230165957389d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6509615274488869d, b: 0.87769027559459d, c: 0.335199852289082d), new NpgsqlTypes.NpgsqlLine(a: 0.005829031665973927d, b: 0.93000161478321d, c: 0.6056696762388623d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.554774050868777d, b: 0.88834733375701d, c: 0.362520159314648d), new NpgsqlTypes.NpgsqlLine(a: 0.26076323470323637d, b: 0.6483651044591454d, c: 0.4826405620350289d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6187377031114956d, b: 0.5429218004427717d, c: 0.44321639760194065d), new NpgsqlTypes.NpgsqlLine(a: 0.17137698166727533d, b: 0.3499715028486112d, c: 0.8916753617957661d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23116615853773137d, b: 0.3023303720158357d, c: 0.5425641304906919d), new NpgsqlTypes.NpgsqlLine(a: 0.2913250298571315d, b: 0.9729259172621745d, c: 0.6733493769334449d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12812746184791513d, b: 0.7530060976532151d, c: 0.36856228548865844d), new NpgsqlTypes.NpgsqlLine(a: 0.9521332214966187d, b: 0.2541336050272699d, c: 0.6726446281810693d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.47327132223154644d, b: 0.2662745719647617d, c: 0.45416321891726097d), new NpgsqlTypes.NpgsqlLine(a: 0.1575770487228204d, b: 0.46445468635337783d, c: 0.7245254610682194d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7518001394532495d, b: 0.5128539450181552d, c: 0.7836040895637153d), new NpgsqlTypes.NpgsqlLine(a: 0.30369535621844623d, b: 0.1140128072589297d, c: 0.046255567178436374d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7639854317672568d, b: 0.8216909813103999d, c: 0.11229892950204368d), new NpgsqlTypes.NpgsqlLine(a: 0.584339856160855d, b: 0.9704992745264304d, c: 0.5450496329748918d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9926286387245796d, b: 0.9467577815771103d, c: 0.9482150014999975d), new NpgsqlTypes.NpgsqlLine(a: 0.7888031996766961d, b: 0.28671296826188963d, c: 0.6318613274503129d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7860847662717475d, b: 0.06345909579224607d, c: 0.698548682015122d), new NpgsqlTypes.NpgsqlLine(a: 0.7757837295240881d, b: 0.6735480976990039d, c: 0.5416214842705114d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12350616693861138d, b: 0.4340526285598383d, c: 0.9160128019108835d), new NpgsqlTypes.NpgsqlLine(a: 0.8053353418001391d, b: 0.5200186666821043d, c: 0.13813535009663314d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.31631105649644076d, b: 0.6000954765350389d, c: 0.6478994824802542d), new NpgsqlTypes.NpgsqlLine(a: 0.3950094761533145d, b: 0.06723504193280117d, c: 0.41633569396585035d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8411586380728562d, b: 0.6757268145295913d, c: 0.9569925016537001d), new NpgsqlTypes.NpgsqlLine(a: 0.575291617494365d, b: 0.3265359856598584d, c: 0.843038533837359d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.31432123227088526d, b: 0.958728989498198d, c: 0.06121013112754625d), new NpgsqlTypes.NpgsqlLine(a: 0.45496945347588225d, b: 0.8670878748203986d, c: 0.533882012399651d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9435000670765359d, b: 0.7733887074839141d, c: 0.14061950388138356d), new NpgsqlTypes.NpgsqlLine(a: 0.6625521667916774d, b: 0.270368868892059d, c: 0.8678392484939237d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6820300261452089d, b: 0.9767379261922146d, c: 0.6793624908431126d), new NpgsqlTypes.NpgsqlLine(a: 0.9085615908498798d, b: 0.3289734047666777d, c: 0.11149425156980142d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9712357429088134d, b: 0.9415176710348264d, c: 0.14922124530964054d), new NpgsqlTypes.NpgsqlLine(a: 0.9565552631375677d, b: 0.8397080091570982d, c: 0.3846785714846126d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5128674256340777d, b: 0.6667042945383418d, c: 0.7036249445829431d), new NpgsqlTypes.NpgsqlLine(a: 0.318301136055666d, b: 0.7277378903479192d, c: 0.6527780963857469d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.48581634167153254d, b: 0.8989670828801783d, c: 0.06647012355004567d), new NpgsqlTypes.NpgsqlLine(a: 0.32542399200434247d, b: 0.7091282424731601d, c: 0.7797330267729728d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7866901775790252d, b: 0.8107627357955326d, c: 0.3154001161547878d), new NpgsqlTypes.NpgsqlLine(a: 0.04746853964477893d, b: 0.12132364987145894d, c: 0.1824986034374d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.10617229889963331d, b: 0.09073464905550532d, c: 0.26876909528077153d), new NpgsqlTypes.NpgsqlLine(a: 0.2919309105522129d, b: 0.5392787137074443d, c: 0.7674933515132452d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4550886819179828d, b: 0.659208776575279d, c: 0.30804988049222626d), new NpgsqlTypes.NpgsqlLine(a: 0.3048720683899916d, b: 0.08614192009508848d, c: 0.6535543860561389d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3742593372604186d, b: 0.6177242185985904d, c: 0.5846536022137503d), new NpgsqlTypes.NpgsqlLine(a: 0.36730228440833146d, b: 0.9334078294887712d, c: 0.33041208751733975d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8029990561242951d, b: 0.8930832911487293d, c: 0.7543930376141904d), new NpgsqlTypes.NpgsqlLine(a: 0.2794005827943381d, b: 0.15369694508888976d, c: 0.09506112762952057d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.24678236978563073d, b: 0.8407755962338618d, c: 0.9766930041738323d), new NpgsqlTypes.NpgsqlLine(a: 0.48533889382186224d, b: 0.7665377431608354d, c: 0.39972022722877976d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9229175417561689d, b: 0.06030134252505237d, c: 0.19298881885770902d), new NpgsqlTypes.NpgsqlLine(a: 0.03133700882515633d, b: 0.7007330989625653d, c: 0.4854392624535614d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.05935082629337973d, b: 0.7981947797475127d, c: 0.24948344690143875d), new NpgsqlTypes.NpgsqlLine(a: 0.30574368721360223d, b: 0.5988172630766643d, c: 0.7440085443294906d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.981895411064072d, b: 0.8471829575463226d, c: 0.8728466529882157d), new NpgsqlTypes.NpgsqlLine(a: 0.8662473654600878d, b: 0.7025055985629799d, c: 0.1912494900955738d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.521011554947215d, b: 0.24685246381723858d, c: 0.033734954583496735d), new NpgsqlTypes.NpgsqlLine(a: 0.41884974507233885d, b: 0.9612942771387225d, c: 0.042387855495586546d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06364698060490848d, b: 0.1903643306478483d, c: 0.30357359882529544d), new NpgsqlTypes.NpgsqlLine(a: 0.47556080102927645d, b: 0.058834317794070445d, c: 0.9074169368351029d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8861990811389313d, b: 0.42776186998894716d, c: 0.24492319637854598d), new NpgsqlTypes.NpgsqlLine(a: 0.6601680407650418d, b: 0.875926901333772d, c: 0.2349790419070228d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.044076453176119634d, b: 0.4661254071811205d, c: 0.25693510804946285d), new NpgsqlTypes.NpgsqlLine(a: 0.8394400990145418d, b: 0.553599227757056d, c: 0.658076035554542d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.06742828074043683d, b: 0.8578787323675537d, c: 0.4328088663933013d), new NpgsqlTypes.NpgsqlLine(a: 0.784185159479846d, b: 0.9621111018345981d, c: 0.7562895999072315d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.38831044579795015d, b: 0.8372197365857733d, c: 0.5069568775524113d), new NpgsqlTypes.NpgsqlLine(a: 0.5876426613870347d, b: 0.8451826970522419d, c: 0.778340904969805d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6489889313061327d, b: 0.28582073530583685d, c: 0.7287190743561284d), new NpgsqlTypes.NpgsqlLine(a: 0.7160944907567148d, b: 0.03670830192571439d, c: 0.5358033994704219d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6930996013631984d, b: 0.666734403876029d, c: 0.5842529372046598d), new NpgsqlTypes.NpgsqlLine(a: 0.2634039931974388d, b: 0.2630875257422469d, c: 0.6278735465284283d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.01328390313241501d, b: 0.23516321769247672d, c: 0.9757829752110261d), new NpgsqlTypes.NpgsqlLine(a: 0.7427782599040337d, b: 0.8735106854013517d, c: 0.8474445570000367d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9658165436478988d, b: 0.3162075273455557d, c: 0.6235192468647542d), new NpgsqlTypes.NpgsqlLine(a: 0.9366107539170098d, b: 0.5179518869200014d, c: 0.673675536760713d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8639432978913854d, b: 0.49221260543912504d, c: 0.8187120788452568d), new NpgsqlTypes.NpgsqlLine(a: 0.257735592160069d, b: 0.5636950823934029d, c: 0.7974326770260229d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9216240915044497d, b: 0.19305898962184997d, c: 0.9466567522171064d), new NpgsqlTypes.NpgsqlLine(a: 0.8068632897554303d, b: 0.24480081100039874d, c: 0.13639222474474777d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3745462285167481d, b: 0.3557883871161549d, c: 0.7519693707743538d), new NpgsqlTypes.NpgsqlLine(a: 0.24793123866897593d, b: 0.32835442536858406d, c: 0.3064174578751241d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23701796730682723d, b: 0.5231055898689367d, c: 0.8541775640441125d), new NpgsqlTypes.NpgsqlLine(a: 0.8397613290625896d, b: 0.05821411741105176d, c: 0.10094179618611798d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.30073970410437556d, b: 0.9092448314495118d, c: 0.4706410642662293d), new NpgsqlTypes.NpgsqlLine(a: 0.07602432466903175d, b: 0.18057929019861485d, c: 0.6383457665233412d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.033081255374647234d, b: 0.5642183467504749d, c: 0.9597240534675253d), new NpgsqlTypes.NpgsqlLine(a: 0.5849478096991579d, b: 0.4892807701281492d, c: 0.24431883803285093d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4934476214555401d, b: 0.8690957222344637d, c: 0.3344167461423042d), new NpgsqlTypes.NpgsqlLine(a: 0.09203987702690486d, b: 0.16511382141521602d, c: 0.5345021684143517d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9528314278595723d, b: 0.9828583653891586d, c: 0.7162197344898708d), new NpgsqlTypes.NpgsqlLine(a: 0.865103745657577d, b: 0.023602960162737663d, c: 0.5338457194224914d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7731116064931107d, b: 0.15974586394971002d, c: 0.42494359926702563d), new NpgsqlTypes.NpgsqlLine(a: 0.4990646088626597d, b: 0.023533319041617262d, c: 0.002920087247374581d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7040904639039103d, b: 0.18560808189610878d, c: 0.27069234777936213d), new NpgsqlTypes.NpgsqlLine(a: 0.0499875300751218d, b: 0.980310928407674d, c: 0.16129138714958302d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5413369164269154d, b: 0.8848624245528812d, c: 0.35429490216251647d), new NpgsqlTypes.NpgsqlLine(a: 0.7051470877041296d, b: 0.32440694145594173d, c: 0.8089630787184233d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7697911213892225d, b: 0.24823381176620318d, c: 0.8759512885778684d), new NpgsqlTypes.NpgsqlLine(a: 0.27954222493141423d, b: 0.8972622189687861d, c: 0.9039379969999686d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2817629897375248d, b: 0.4673684062390585d, c: 0.5480328083793472d), new NpgsqlTypes.NpgsqlLine(a: 0.06690659593255965d, b: 0.4293857499548487d, c: 0.9481544789129922d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7416640960608737d, b: 0.5659074713369744d, c: 0.3963064223749563d), new NpgsqlTypes.NpgsqlLine(a: 0.7064788934358528d, b: 0.17293794111683736d, c: 0.3032101508086671d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6211576777614267d, b: 0.3756886649821737d, c: 0.09208044579082597d), new NpgsqlTypes.NpgsqlLine(a: 0.8361566929284999d, b: 0.8746898390216388d, c: 0.9651300304397123d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5754806706862454d, b: 0.03577073538825937d, c: 0.5945532615183006d), new NpgsqlTypes.NpgsqlLine(a: 0.9442077389831294d, b: 0.8025583285035403d, c: 0.933501316413239d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8320068574889633d, b: 0.8040136306564566d, c: 0.8848841134387546d), new NpgsqlTypes.NpgsqlLine(a: 0.8039630643466211d, b: 0.6044046048525109d, c: 0.6920542385803833d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.33528568780726753d, b: 0.21857869713807643d, c: 0.36627047930961243d), new NpgsqlTypes.NpgsqlLine(a: 0.15253760050291454d, b: 0.08526980078006274d, c: 0.1173358493919271d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.10013701902936867d, b: 0.7712012250122354d, c: 0.9435267091979808d), new NpgsqlTypes.NpgsqlLine(a: 0.7920050099947448d, b: 0.09277253544765818d, c: 0.5467465904084697d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8929194645504228d, b: 0.6790764402862556d, c: 0.2300411781235947d), new NpgsqlTypes.NpgsqlLine(a: 0.24963886470601682d, b: 0.8901223201022803d, c: 0.3680978147712999d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8691768237958658d, b: 0.7011276055164668d, c: 0.27408224007089677d), new NpgsqlTypes.NpgsqlLine(a: 0.13279268459995663d, b: 0.9032282605262963d, c: 0.6167612152460626d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.45909708722016274d, b: 0.31451332142322075d, c: 0.31299559509520036d), new NpgsqlTypes.NpgsqlLine(a: 0.22584002518980828d, b: 0.3152198488038951d, c: 0.09510919452089095d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9483910260354446d, b: 0.623370490335479d, c: 0.6588356585023628d), new NpgsqlTypes.NpgsqlLine(a: 0.5664107550178384d, b: 0.2272240606758562d, c: 0.914959027178042d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9333584941287443d, b: 0.22811997053906263d, c: 0.7249381037865421d), new NpgsqlTypes.NpgsqlLine(a: 0.6106518642052347d, b: 0.3866299551921645d, c: 0.4285367243687762d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4012702321001357d, b: 0.1786617941168548d, c: 0.3934511860544603d), new NpgsqlTypes.NpgsqlLine(a: 0.7413855779167008d, b: 0.7253367929953608d, c: 0.8198318694141499d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.16985146137268325d, b: 0.10150883098231978d, c: 0.365356550067212d), new NpgsqlTypes.NpgsqlLine(a: 0.7987548136741183d, b: 0.0077579414374819855d, c: 0.35068362487732774d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.06446828606921584d, b: 0.6610088978060636d, c: 0.3624954757460084d), new NpgsqlTypes.NpgsqlLine(a: 0.1205653259491517d, b: 0.09113602025332113d, c: 0.07352380232467826d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.42447217581440544d, b: 0.7450305876844094d, c: 0.34360680702809354d), new NpgsqlTypes.NpgsqlLine(a: 0.3904415381776398d, b: 0.4271786012263715d, c: 0.5339311757037878d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7173651233241147d, b: 0.5149616808083586d, c: 0.22804154165574786d), new NpgsqlTypes.NpgsqlLine(a: 0.5694857515113497d, b: 0.6626077287351243d, c: 0.31891452244242413d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.1292761811388925d, b: 0.02633046976272757d, c: 0.6962596251454749d), new NpgsqlTypes.NpgsqlLine(a: 0.6053834141082554d, b: 0.6723347847084766d, c: 0.3939664032634237d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.09768527756826206d, b: 0.20718749427850602d, c: 0.9018213381480416d), new NpgsqlTypes.NpgsqlLine(a: 0.12363595958953111d, b: 0.7201904680702395d, c: 0.4905308204163946d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.209464825319715d, b: 0.8886476324485104d, c: 0.37361790863927025d), new NpgsqlTypes.NpgsqlLine(a: 0.42743552949910646d, b: 0.6534634079182204d, c: 0.34907652463818606d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5430863436170573d, b: 0.2165160837921274d, c: 0.1821376261044283d), new NpgsqlTypes.NpgsqlLine(a: 0.37196938259173495d, b: 0.024517376344567188d, c: 0.8957611229119729d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3128425902735721d, b: 0.642094036315629d, c: 0.41974398253763867d), new NpgsqlTypes.NpgsqlLine(a: 0.7895057014428045d, b: 0.3515643823827944d, c: 0.215296016449397d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7243472526391922d, b: 0.08212093629649275d, c: 0.14620178736068112d), new NpgsqlTypes.NpgsqlLine(a: 0.276542104549682d, b: 0.487276690946874d, c: 0.8269722517648308d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6596473763807623d, b: 0.013985251305952517d, c: 0.39187086551081174d), new NpgsqlTypes.NpgsqlLine(a: 0.49034190081775d, b: 0.731516751424192d, c: 0.5633772765307974d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.621178807369171d, b: 0.9239310782520789d, c: 0.49653079513608933d), new NpgsqlTypes.NpgsqlLine(a: 0.022415579974944033d, b: 0.9952832108031302d, c: 0.19851713713405938d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.19042657396189977d, b: 0.6782675377337996d, c: 0.034757670060278634d), new NpgsqlTypes.NpgsqlLine(a: 0.9077738771831785d, b: 0.08968933809734914d, c: 0.3071978079547891d), }, }));
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8730874687408305d, b: 0.530894937282654d, c: 0.49273401187036325d), new NpgsqlTypes.NpgsqlLine(a: 0.017655210744217498d, b: 0.097081756674259d, c: 0.9548477781369435d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9365270603790892d, b: 0.7366797336268271d, c: 0.18618467727980936d), new NpgsqlTypes.NpgsqlLine(a: 0.33689428013772516d, b: 0.9671237008853177d, c: 0.06923912916500863d), }, }));
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 128, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 111, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 25, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 115, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 73, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 77, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 108, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
FROM public.binary_npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI), typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

