

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31405157297292063d, y: 0.5814860752849743d), new NpgsqlTypes.NpgsqlPoint(x: 0.35193088192868505d, y: 0.9131660581462165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536585834534214d, y: 0.13107895977124995d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11435346630581733d, y: 0.2750716739959721d), new NpgsqlTypes.NpgsqlPoint(x: 0.223599194844479d, y: 0.6420554299928436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5750339718777697d, y: 0.11094441820644041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8559576317403991d, y: 0.8112889962505399d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328964643199173d, y: 0.8105875303571258d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920537545142965d, y: 0.13821899630381695d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7188501029803775d, y: 0.836550436310656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844018663384501d, y: 0.5309666687324197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831164079339942d, y: 0.8543467434406915d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1337544841928664d, y: 0.40277710839335956d), new NpgsqlTypes.NpgsqlPoint(x: 0.195496733164352d, y: 0.9180564087927199d), new NpgsqlTypes.NpgsqlPoint(x: 0.701931777452888d, y: 0.7340919946810995d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5016269888343265d, y: 0.7276635332319862d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970238815252379d, y: 0.7078677061334989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7568672320157249d, y: 0.3464866679833506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.653067425210965d, y: 0.1079310230477234d), new NpgsqlTypes.NpgsqlPoint(x: 0.20192117166874668d, y: 0.39112271764659223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3584121139939075d, y: 0.9604235519099027d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13372186275386755d, y: 0.12079125572293092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8289409276958764d, y: 0.395997843004363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876685077615629d, y: 0.07076694246890347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24266465075606858d, y: 0.03441931970332435d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757283488266516d, y: 0.7516546783665018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9625895045517636d, y: 0.8697012964038807d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38706000250407513d, y: 0.09365440382712531d), new NpgsqlTypes.NpgsqlPoint(x: 0.518879687973835d, y: 0.8333583968522391d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356946072181756d, y: 0.3367229296058242d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3058219601333877d, y: 0.5340415324985343d), new NpgsqlTypes.NpgsqlPoint(x: 0.21055727513915012d, y: 0.6280115025038278d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875623470690128d, y: 0.786622662587189d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3210745678897341d, y: 0.20784513526962667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5064066749658052d, y: 0.15344802712188932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022011361454336d, y: 0.8188538658130692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28133804969752185d, y: 0.5775427463538835d), new NpgsqlTypes.NpgsqlPoint(x: 0.28400679207588586d, y: 0.045578871869282334d), new NpgsqlTypes.NpgsqlPoint(x: 0.11193591885646847d, y: 0.13718972699781917d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7534338438022095d, y: 0.0011867060010473107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526518764905714d, y: 0.7494069865791348d), new NpgsqlTypes.NpgsqlPoint(x: 0.3913079984761344d, y: 0.8822278539757806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.380030351611484d, y: 0.03455999637685092d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429304452020923d, y: 0.22476590863710233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807091980981263d, y: 0.0039038333296230743d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024679370813520007d, y: 0.24056895909054166d), new NpgsqlTypes.NpgsqlPoint(x: 0.14369654637182738d, y: 0.7291815184876261d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128783617211151d, y: 0.020510326034974602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9677318305110051d, y: 0.30470180077532494d), new NpgsqlTypes.NpgsqlPoint(x: 0.38819113113546533d, y: 0.09966019093672529d), new NpgsqlTypes.NpgsqlPoint(x: 0.5064743840609002d, y: 0.3960125966833379d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04250249928280525d, y: 0.5099428000000207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768051716434471d, y: 0.346162695733786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7422529599308442d, y: 0.3051207608208384d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2685919243663809d, y: 0.4901221466352508d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360533927455872d, y: 0.7544347439544992d), new NpgsqlTypes.NpgsqlPoint(x: 0.74234995980197d, y: 0.13524459139141976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7585614475247268d, y: 0.2736731163230134d), new NpgsqlTypes.NpgsqlPoint(x: 0.04424622869921513d, y: 0.987279942603788d), new NpgsqlTypes.NpgsqlPoint(x: 0.24569393964341002d, y: 0.47110009566730504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5031122046172891d, y: 0.7571706296482492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604221434551671d, y: 0.7731516236512731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078349941451579d, y: 0.9961051205035663d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.707023744908317d, y: 0.12938613744142813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165258516532462d, y: 0.9477300307534312d), new NpgsqlTypes.NpgsqlPoint(x: 0.10489330413960951d, y: 0.12443903983909166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9378388886962391d, y: 0.22077587374508767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225514300716186d, y: 0.09071725232475392d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594497898318632d, y: 0.05840922290420347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21788726682693726d, y: 0.7047020462474594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7892012646339148d, y: 0.8511208636699068d), new NpgsqlTypes.NpgsqlPoint(x: 0.15338344050946096d, y: 0.5627483937975803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5515171567959614d, y: 0.37972451746794256d), new NpgsqlTypes.NpgsqlPoint(x: 0.42577078892901465d, y: 0.9402442683405975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457992661643589d, y: 0.20384727590314933d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5331097917095552d, y: 0.29044301851402765d), new NpgsqlTypes.NpgsqlPoint(x: 0.17560039996543764d, y: 0.5580885678988647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107432159796979d, y: 0.5459859430687057d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35678928546351873d, y: 0.14536403475585324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8419102757486667d, y: 0.573255812338138d), new NpgsqlTypes.NpgsqlPoint(x: 0.33962945138403255d, y: 0.6172479679854356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6349680852610384d, y: 0.19156818584196666d), new NpgsqlTypes.NpgsqlPoint(x: 0.06659143202408568d, y: 0.2697969040031044d), new NpgsqlTypes.NpgsqlPoint(x: 0.13617790252615547d, y: 0.504956035543236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8696188808958074d, y: 0.3494776989184156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9576501217825315d, y: 0.5724077523094435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5210302832912741d, y: 0.820479515235421d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8047806089756494d, y: 0.4173846943291195d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744740916208822d, y: 0.9858901678508172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254531023178621d, y: 0.26520260081872316d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013335897771168947d, y: 0.8215701874960808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5983120065697954d, y: 0.37187441558079193d), new NpgsqlTypes.NpgsqlPoint(x: 0.38513263026527844d, y: 0.9191465961131046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.522594373502238d, y: 0.7362640980171153d), new NpgsqlTypes.NpgsqlPoint(x: 0.34341660847223454d, y: 0.40429961918333457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6867372065412497d, y: 0.3634617326571232d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007406867140176132d, y: 0.8281327103156317d), new NpgsqlTypes.NpgsqlPoint(x: 0.32437425069924897d, y: 0.738858399786972d), new NpgsqlTypes.NpgsqlPoint(x: 0.4611293846552774d, y: 0.6573590671244004d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9943255069282881d, y: 0.8080486976375794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770806796928844d, y: 0.2655943387296905d), new NpgsqlTypes.NpgsqlPoint(x: 0.15625736761380882d, y: 0.05553278126639438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9463301739718651d, y: 0.1862604744007632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365737913531265d, y: 0.208482674125973d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489800932237797d, y: 0.8442503204413837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9793171880924401d, y: 0.052420638768264194d), new NpgsqlTypes.NpgsqlPoint(x: 0.25292645254139645d, y: 0.336808967443449d), new NpgsqlTypes.NpgsqlPoint(x: 0.23809364274982914d, y: 0.14807333474145634d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8537213791879096d, y: 0.38629852126090913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5012714821536484d, y: 0.8467468960337629d), new NpgsqlTypes.NpgsqlPoint(x: 0.8890531370208418d, y: 0.8856417949220325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5894508713880505d, y: 0.8302704033110969d), new NpgsqlTypes.NpgsqlPoint(x: 0.4984014663491184d, y: 0.1333290179930663d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746785644716417d, y: 0.8546141215269775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43479371394673705d, y: 0.6863831521332511d), new NpgsqlTypes.NpgsqlPoint(x: 0.09630805185631186d, y: 0.3574491684114365d), new NpgsqlTypes.NpgsqlPoint(x: 0.25904479596894336d, y: 0.8378866982558391d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6015077573949544d, y: 0.5094846156929794d), new NpgsqlTypes.NpgsqlPoint(x: 0.779576510732776d, y: 0.7712910856287998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8971415681852992d, y: 0.29262737802154537d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507700502641779d, y: 0.947070750653612d), new NpgsqlTypes.NpgsqlPoint(x: 0.89756005293351d, y: 0.780755837391199d), new NpgsqlTypes.NpgsqlPoint(x: 0.062080091705409846d, y: 0.11093648127412392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5953231316113762d, y: 0.15859124350324838d), new NpgsqlTypes.NpgsqlPoint(x: 0.1979660937964125d, y: 0.1660001511581315d), new NpgsqlTypes.NpgsqlPoint(x: 0.516599338335713d, y: 0.1911179036072912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5308621152642189d, y: 0.6358461848952854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318729671357773d, y: 0.15833801282075421d), new NpgsqlTypes.NpgsqlPoint(x: 0.11787453684469407d, y: 0.2722417934914553d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.794246606636976d, y: 0.27734520686730757d), new NpgsqlTypes.NpgsqlPoint(x: 0.284182929328766d, y: 0.3471862105213751d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964804553173996d, y: 0.672062725936944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33391867002635034d, y: 0.2508116554740675d), new NpgsqlTypes.NpgsqlPoint(x: 0.2392383776320196d, y: 0.5615947805907693d), new NpgsqlTypes.NpgsqlPoint(x: 0.460864736338218d, y: 0.09259139486992429d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37644436343088494d, y: 0.008986653954630719d), new NpgsqlTypes.NpgsqlPoint(x: 0.9920345478626171d, y: 0.47709352055173193d), new NpgsqlTypes.NpgsqlPoint(x: 0.30486560462293444d, y: 0.9813922954625464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7392216680205101d, y: 0.9111274280918261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906251777949309d, y: 0.15220699756922285d), new NpgsqlTypes.NpgsqlPoint(x: 0.4523591060896479d, y: 0.2651039806618022d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1433901383709686d, y: 0.22315488015957652d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866068364436841d, y: 0.9830667299361847d), new NpgsqlTypes.NpgsqlPoint(x: 0.23230506773675252d, y: 0.6592839843954887d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15262538453468733d, y: 0.5667700643294726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117536378753974d, y: 0.23310455451826162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082477506966417d, y: 0.006248011538707021d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9727092015562356d, y: 0.8317495945790614d), new NpgsqlTypes.NpgsqlPoint(x: 0.25641414360440407d, y: 0.9227039215271841d), new NpgsqlTypes.NpgsqlPoint(x: 0.07510317310634373d, y: 0.915451708319046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6159723639129778d, y: 0.2577834297759789d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990930398005253d, y: 0.4294801527742065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570907027296837d, y: 0.39834662036224555d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9273867393975138d, y: 0.7111968753950686d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747083166589077d, y: 0.24385670352951183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9338282345625977d, y: 0.1000457709657584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0522806857432937d, y: 0.6801027076599085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177546957024793d, y: 0.5924540273018971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7018397700463144d, y: 0.4598885250925556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8409705838183518d, y: 0.35348972988746585d), new NpgsqlTypes.NpgsqlPoint(x: 0.19212326597545848d, y: 0.8970068476590825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260269990146186d, y: 0.8237292472916697d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6823523347352282d, y: 0.206379933642026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583919508384061d, y: 0.5579498740190214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7966196385124427d, y: 0.3289396809851449d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.679876725561573d, y: 0.8684562333504061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205750141686523d, y: 0.5074812750321883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695867201559207d, y: 0.9945202232197433d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5340259369432149d, y: 0.42864413372547594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3760506774011879d, y: 0.7077654111950077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7549348554620223d, y: 0.7559133515956327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8420934118819752d, y: 0.6623983044361276d), new NpgsqlTypes.NpgsqlPoint(x: 0.1741460890589649d, y: 0.1293966568379925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8759432697789697d, y: 0.7962711051912945d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6241151151462182d, y: 0.5904453069089252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059625560212573d, y: 0.3979407732445138d), new NpgsqlTypes.NpgsqlPoint(x: 0.03921205801008942d, y: 0.8715417394901696d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7640069815505152d, y: 0.3022690262795803d), new NpgsqlTypes.NpgsqlPoint(x: 0.41530930493924834d, y: 0.6942267795193321d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298745027716863d, y: 0.2578113957599466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23486102931065078d, y: 0.7916283504760363d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756548146205435d, y: 0.7999355304208312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397054061622047d, y: 0.22995912290316d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04703570500188137d, y: 0.25799016028588373d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144955686734504d, y: 0.10826394782115745d), new NpgsqlTypes.NpgsqlPoint(x: 0.7475361487032572d, y: 0.9682433614486577d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02145897070642855d, y: 0.5817700102790083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5373377936427625d, y: 0.9351286872802232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382231684760906d, y: 0.8899474095999108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3563695679861456d, y: 0.20669042560260986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624738228060033d, y: 0.4656555241346031d), new NpgsqlTypes.NpgsqlPoint(x: 0.17096616601293302d, y: 0.095076595201121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15884499967385912d, y: 0.9820910837964546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9589039552163792d, y: 0.4292840351148658d), new NpgsqlTypes.NpgsqlPoint(x: 0.2963478376944849d, y: 0.39400293648497675d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.288049730211008d, y: 0.6557081685349794d), new NpgsqlTypes.NpgsqlPoint(x: 0.49585889284847307d, y: 0.42874343924447544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060010985450746d, y: 0.9921677168185254d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17428994089956662d, y: 0.16957088582726854d), new NpgsqlTypes.NpgsqlPoint(x: 0.40833705033479895d, y: 0.29427578838707624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9998823201610849d, y: 0.08333716293779103d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12082222132733633d, y: 0.3439053776375729d), new NpgsqlTypes.NpgsqlPoint(x: 0.4777855057334306d, y: 0.12462562224695606d), new NpgsqlTypes.NpgsqlPoint(x: 0.0046863212891798955d, y: 0.7112716873960679d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04132378275429327d, y: 0.4540121209165482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961321362117557d, y: 0.06285623877065705d), new NpgsqlTypes.NpgsqlPoint(x: 0.155684608330523d, y: 0.5401868572866468d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0715147504390996d, y: 0.07806050260524589d), new NpgsqlTypes.NpgsqlPoint(x: 0.24408924027335988d, y: 0.6440404986765181d), new NpgsqlTypes.NpgsqlPoint(x: 0.8631935365331369d, y: 0.015459231148509334d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7722249859334085d, y: 0.9312248471515828d), new NpgsqlTypes.NpgsqlPoint(x: 0.1300406007667273d, y: 0.39842429448906247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019008247637988d, y: 0.5631006791420566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13014889879952996d, y: 0.09132156569154282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791769729766532d, y: 0.10273554719127609d), new NpgsqlTypes.NpgsqlPoint(x: 0.042661018808548556d, y: 0.43880916405986903d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7735492273573685d, y: 0.33226186779742306d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604306917624986d, y: 0.5258655282388058d), new NpgsqlTypes.NpgsqlPoint(x: 0.11769266911293697d, y: 0.15468193333982327d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9942580830961233d, y: 0.6715254057104849d), new NpgsqlTypes.NpgsqlPoint(x: 0.6329097407286379d, y: 0.8839022034314032d), new NpgsqlTypes.NpgsqlPoint(x: 0.43549085649989205d, y: 0.5613123079798306d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9379507676529466d, y: 0.13486493388840592d), new NpgsqlTypes.NpgsqlPoint(x: 0.4575972974655257d, y: 0.49763593081406765d), new NpgsqlTypes.NpgsqlPoint(x: 0.6697035120762173d, y: 0.8939207670444332d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8705685124287432d, y: 0.03994445874655539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381104805701412d, y: 0.3779082386528442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918817862521232d, y: 0.20833799326939928d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.970718830672199d, y: 0.9039758665115273d), new NpgsqlTypes.NpgsqlPoint(x: 0.06243012332090514d, y: 0.4264467525081198d), new NpgsqlTypes.NpgsqlPoint(x: 0.14524643538621163d, y: 0.8384499009333011d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4233005386843288d, y: 0.2575449954740041d), new NpgsqlTypes.NpgsqlPoint(x: 0.7752866286153857d, y: 0.6578154407043524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6434122921334092d, y: 0.3528229601658186d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8384887211710147d, y: 0.2181570143024072d), new NpgsqlTypes.NpgsqlPoint(x: 0.07136684051885567d, y: 0.05477699048626061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467984458010754d, y: 0.3510752357249568d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18381845223047133d, y: 0.6330006988077301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899051660724596d, y: 0.15660645379220373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4318567522617589d, y: 0.3912999831302678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15135405533010138d, y: 0.8539127935057144d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021652233481166d, y: 0.6331670013319454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827602851902372d, y: 0.9989599792103896d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7398134377737555d, y: 0.81007708030903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8757964507337054d, y: 0.15250105863871666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653302582681285d, y: 0.6114696653132087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.579018937314867d, y: 0.5067993990729954d), new NpgsqlTypes.NpgsqlPoint(x: 0.03683710014105579d, y: 0.058114033807332266d), new NpgsqlTypes.NpgsqlPoint(x: 0.13884348909408017d, y: 0.3455285845571098d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22289672820083428d, y: 0.1317696923790206d), new NpgsqlTypes.NpgsqlPoint(x: 0.22438658346515283d, y: 0.21067458870509037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7994275116999877d, y: 0.059304479874181526d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3461234175384321d, y: 0.4971282533527487d), new NpgsqlTypes.NpgsqlPoint(x: 0.20006040523036484d, y: 0.111029563682005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342810006121915d, y: 0.6670036821523242d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3670846416670611d, y: 0.019395666893944008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4087627999778993d, y: 0.2945516660671522d), new NpgsqlTypes.NpgsqlPoint(x: 0.46486966116844164d, y: 0.20400466010234797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8475562506104152d, y: 0.15712978366067076d), new NpgsqlTypes.NpgsqlPoint(x: 0.29237309284948565d, y: 0.8053108730999798d), new NpgsqlTypes.NpgsqlPoint(x: 0.2960114092298842d, y: 0.8175424778832886d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12772846177753538d, y: 0.6609962867409303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8984311731402486d, y: 0.20379253991751045d), new NpgsqlTypes.NpgsqlPoint(x: 0.5588652201051515d, y: 0.7115982425274567d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49432043233413214d, y: 0.9100190045992738d), new NpgsqlTypes.NpgsqlPoint(x: 0.2482717250784714d, y: 0.14153207637794274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3402141249405174d, y: 0.27728467152636405d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4772456563734898d, y: 0.6152832660510568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9727611935699357d, y: 0.6218681429463391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344550522404328d, y: 0.599900844953225d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07440805471879264d, y: 0.9210250494726558d), new NpgsqlTypes.NpgsqlPoint(x: 0.919770323557485d, y: 0.05195838281234888d), new NpgsqlTypes.NpgsqlPoint(x: 0.18760403431882533d, y: 0.4665892037072027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7662510111189966d, y: 0.9831849188145402d), new NpgsqlTypes.NpgsqlPoint(x: 0.12719065685534148d, y: 0.760627159263414d), new NpgsqlTypes.NpgsqlPoint(x: 0.46467585525484945d, y: 0.5425946646248692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7126462966969954d, y: 0.724197423381895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406113400575522d, y: 0.7758648338712338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3593870350043412d, y: 0.06079677730497923d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5484774575243775d, y: 0.11030715871921204d), new NpgsqlTypes.NpgsqlPoint(x: 0.3770009763813519d, y: 0.5750486342982936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422627639470506d, y: 0.972962333254108d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.039726914870594654d, y: 0.6451266322028703d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468033024352014d, y: 0.010152682434531934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513163916555777d, y: 0.3140981432925407d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9850727140548143d, y: 0.1555621618328189d), new NpgsqlTypes.NpgsqlPoint(x: 0.24468224422265916d, y: 0.9109116226592838d), new NpgsqlTypes.NpgsqlPoint(x: 0.40165479405025495d, y: 0.1290105297387415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9522463621246682d, y: 0.16629566418434283d), new NpgsqlTypes.NpgsqlPoint(x: 0.30939422129317784d, y: 0.411347556749033d), new NpgsqlTypes.NpgsqlPoint(x: 0.04692579564456978d, y: 0.42391588694646554d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2934282905582418d, y: 0.6624930924522234d), new NpgsqlTypes.NpgsqlPoint(x: 0.5401856940365227d, y: 0.054265450932283965d), new NpgsqlTypes.NpgsqlPoint(x: 0.4016040934764298d, y: 0.399837550329035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6781205476632749d, y: 0.23354878543930702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2416838575648108d, y: 0.642357987987125d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315311044245371d, y: 0.7319443386973282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45285439523824333d, y: 0.2504543235589447d), new NpgsqlTypes.NpgsqlPoint(x: 0.308210455485435d, y: 0.7247656604971253d), new NpgsqlTypes.NpgsqlPoint(x: 0.850115785634096d, y: 0.21886690827606747d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7519385187575017d, y: 0.7047494959256039d), new NpgsqlTypes.NpgsqlPoint(x: 0.21754570422487907d, y: 0.6249598416347039d), new NpgsqlTypes.NpgsqlPoint(x: 0.03355407307609226d, y: 0.2094146775731719d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29619892242453794d, y: 0.784081619709968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2716599556057241d, y: 0.8110675696145244d), new NpgsqlTypes.NpgsqlPoint(x: 0.04108756964882332d, y: 0.38867354888221806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7416015654724478d, y: 0.47916077315938577d), new NpgsqlTypes.NpgsqlPoint(x: 0.483157771669146d, y: 0.12462983602448174d), new NpgsqlTypes.NpgsqlPoint(x: 0.25852296959260657d, y: 0.43940151299912833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1114304134680858d, y: 0.18013857575016223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9446077696661879d, y: 0.5003735548736734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7272366369538934d, y: 0.63254769749522d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31974201889795706d, y: 0.15460037438172247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8943788047998684d, y: 0.0014997955680062791d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996323223150592d, y: 0.04735398914924949d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5902444820070982d, y: 0.7385923578017636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981689327769886d, y: 0.17990621400859874d), new NpgsqlTypes.NpgsqlPoint(x: 0.25436932837938997d, y: 0.7180122036763288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8688604430908882d, y: 0.39554625125046916d), new NpgsqlTypes.NpgsqlPoint(x: 0.0679102032982215d, y: 0.06101414949687667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964260697189631d, y: 0.560783904873195d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5378628933088181d, y: 0.7972716178520762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907904367440578d, y: 0.05376803681561093d), new NpgsqlTypes.NpgsqlPoint(x: 0.2412480163785875d, y: 0.14863643930924497d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1606329694108265d, y: 0.10485888562174772d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334092800952832d, y: 0.9488980962171394d), new NpgsqlTypes.NpgsqlPoint(x: 0.20545218752837724d, y: 0.41233119428106646d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12272790537600597d, y: 0.6609625081343738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7452933217813176d, y: 0.02446211056484593d), new NpgsqlTypes.NpgsqlPoint(x: 0.03923119497317695d, y: 0.4591772795134482d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9920603404150966d, y: 0.051173161671979606d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227227999172158d, y: 0.10844700249729544d), new NpgsqlTypes.NpgsqlPoint(x: 0.22298088342356304d, y: 0.02725610784172372d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4895537679370576d, y: 0.6831758192542844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6788611209676657d, y: 0.6599611359500248d), new NpgsqlTypes.NpgsqlPoint(x: 0.643907685475101d, y: 0.6150475851944099d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06795390379495503d, y: 0.6508450923687055d), new NpgsqlTypes.NpgsqlPoint(x: 0.26676080177229844d, y: 0.8992716848325094d), new NpgsqlTypes.NpgsqlPoint(x: 0.05175489252066079d, y: 0.0038254803187920405d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2212542418519169d, y: 0.9116767043587992d), new NpgsqlTypes.NpgsqlPoint(x: 0.44737950416991834d, y: 0.7988161230562631d), new NpgsqlTypes.NpgsqlPoint(x: 0.33531116136927575d, y: 0.27604584105779995d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27456809443350294d, y: 0.5775537626030411d), new NpgsqlTypes.NpgsqlPoint(x: 0.486637710067679d, y: 0.06949526954440954d), new NpgsqlTypes.NpgsqlPoint(x: 0.45814622304474295d, y: 0.6153049833453534d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7636801772935454d, y: 0.9223899789460666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036642677939678d, y: 0.35137057616781253d), new NpgsqlTypes.NpgsqlPoint(x: 0.72997277050136d, y: 0.45534677050206684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3694431447146108d, y: 0.9777973692678683d), new NpgsqlTypes.NpgsqlPoint(x: 0.1730695248130819d, y: 0.010106682571234704d), new NpgsqlTypes.NpgsqlPoint(x: 0.3596613574807558d, y: 0.9786872206303626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5916808478522262d, y: 0.9724392679104353d), new NpgsqlTypes.NpgsqlPoint(x: 0.09350857711758076d, y: 0.37750538678030865d), new NpgsqlTypes.NpgsqlPoint(x: 0.10440822703696173d, y: 0.9544486555555762d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14585574132858636d, y: 0.8588819789263797d), new NpgsqlTypes.NpgsqlPoint(x: 0.07361142409611077d, y: 0.3895682368871568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7556528557143445d, y: 0.7225591168326853d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13568115354995747d, y: 0.13848462660343386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647157320312495d, y: 0.4095051129018321d), new NpgsqlTypes.NpgsqlPoint(x: 0.2011261449537809d, y: 0.28897224612003747d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2746687003353131d, y: 0.5281136774913419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414557138427934d, y: 0.38557132234085534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074142308921114d, y: 0.4128133570039403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3157415141608455d, y: 0.9796512918454175d), new NpgsqlTypes.NpgsqlPoint(x: 0.207807308352718d, y: 0.9901889208747601d), new NpgsqlTypes.NpgsqlPoint(x: 0.9316336700558211d, y: 0.9750299664376574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13595604372356895d, y: 0.40049654138809176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7642017357586721d, y: 0.20244979739082936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275810059866111d, y: 0.013815403091187783d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5128605578980049d, y: 0.6893638031698218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280050902239061d, y: 0.008521628801430925d), new NpgsqlTypes.NpgsqlPoint(x: 0.0914831244159875d, y: 0.36420586070452754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5735594602952774d, y: 0.3197565865176042d), new NpgsqlTypes.NpgsqlPoint(x: 0.18246737217415265d, y: 0.8737201395476383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476795660950026d, y: 0.4677437294095299d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33568254384840845d, y: 0.10445237484608705d), new NpgsqlTypes.NpgsqlPoint(x: 0.4995274267094624d, y: 0.9159398689782373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8773037612424284d, y: 0.44151868051101706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843719802586642d, y: 0.39009274428526d), new NpgsqlTypes.NpgsqlPoint(x: 0.24545283887412495d, y: 0.6822464961012137d), new NpgsqlTypes.NpgsqlPoint(x: 0.729004741679159d, y: 0.988251666219762d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24817569492348523d, y: 0.9073295751993576d), new NpgsqlTypes.NpgsqlPoint(x: 0.008143393230094498d, y: 0.07723881589566473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543187720210508d, y: 0.7621156235272095d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45625736418844853d, y: 0.37044361876495036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056174097071668d, y: 0.2854118595598548d), new NpgsqlTypes.NpgsqlPoint(x: 0.007854955738818448d, y: 0.5367005255658771d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24803305276677945d, y: 0.5044487197227322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9708958401862019d, y: 0.8624660928234401d), new NpgsqlTypes.NpgsqlPoint(x: 0.20627991871612184d, y: 0.01917078371024694d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07077488851038627d, y: 0.5016597797500351d), new NpgsqlTypes.NpgsqlPoint(x: 0.09161455698240684d, y: 0.11495603668569143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636853145666524d, y: 0.1674959449474246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.900243379330698d, y: 0.8505873090695896d), new NpgsqlTypes.NpgsqlPoint(x: 0.24603709568473353d, y: 0.7152331179324884d), new NpgsqlTypes.NpgsqlPoint(x: 0.09050377158627687d, y: 0.8628350305552509d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903860568003531d, y: 0.38817094249298434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166209267787346d, y: 0.9537152663572996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242349537334707d, y: 0.1014837356983701d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5482315951361676d, y: 0.09227586206962302d), new NpgsqlTypes.NpgsqlPoint(x: 0.08581650414127939d, y: 0.8733705931462941d), new NpgsqlTypes.NpgsqlPoint(x: 0.9473156755417644d, y: 0.5982446308112265d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14730374211870612d, y: 0.033065047081962895d), new NpgsqlTypes.NpgsqlPoint(x: 0.33141644239732937d, y: 0.5816453591251022d), new NpgsqlTypes.NpgsqlPoint(x: 0.15198074421914254d, y: 0.8697288959956767d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8524891528741493d, y: 0.9801384573073526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6487612143981963d, y: 0.6986200513414964d), new NpgsqlTypes.NpgsqlPoint(x: 0.17572777239920012d, y: 0.6441195512448692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01322824674887857d, y: 0.5100741462881968d), new NpgsqlTypes.NpgsqlPoint(x: 0.34918751625993605d, y: 0.47283365293824065d), new NpgsqlTypes.NpgsqlPoint(x: 0.49900258672499087d, y: 0.775574367238803d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9919868945340905d, y: 0.9884896742088866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5348685354990519d, y: 0.6269561547248751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872611697428394d, y: 0.738329178007999d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6166588661521083d, y: 0.572555961017288d), new NpgsqlTypes.NpgsqlPoint(x: 0.09655595535504669d, y: 0.9699223893704156d), new NpgsqlTypes.NpgsqlPoint(x: 0.659805247777089d, y: 0.841361695722933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4734932180320368d, y: 0.8297039313439949d), new NpgsqlTypes.NpgsqlPoint(x: 0.1872058813052232d, y: 0.5363032424853783d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519394589459191d, y: 0.2755577060037142d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07749970279588703d, y: 0.3727023664410042d), new NpgsqlTypes.NpgsqlPoint(x: 0.967675475146301d, y: 0.9725217929512304d), new NpgsqlTypes.NpgsqlPoint(x: 0.34903937026832343d, y: 0.5351970319206989d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12505333098512472d, y: 0.5099767235321829d), new NpgsqlTypes.NpgsqlPoint(x: 0.24930042621439397d, y: 0.7572622891029792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8412778404731416d, y: 0.4309751856999784d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36763309518151654d, y: 0.9905537832055249d), new NpgsqlTypes.NpgsqlPoint(x: 0.24317525483334912d, y: 0.06198236991355488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302690575646028d, y: 0.08315061381192934d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8278763288845656d, y: 0.33015887685689926d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139214560607112d, y: 0.14945984067750961d), new NpgsqlTypes.NpgsqlPoint(x: 0.1311064626576549d, y: 0.27469110558100573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.603209105528309d, y: 0.31422005960515564d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064851608673074d, y: 0.4533095860207208d), new NpgsqlTypes.NpgsqlPoint(x: 0.19337244120461838d, y: 0.04522553363608761d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9733814583778324d, y: 0.6739605706188067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390607016908273d, y: 0.13989222356615005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139701260972087d, y: 0.09099273335317082d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17517662790976396d, y: 0.18743340235221106d), new NpgsqlTypes.NpgsqlPoint(x: 0.848668600738199d, y: 0.23980097444417747d), new NpgsqlTypes.NpgsqlPoint(x: 0.784220179393181d, y: 0.2938058234709152d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2933613168199791d, y: 0.3635601946138898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890795518340008d, y: 0.023865470945275913d), new NpgsqlTypes.NpgsqlPoint(x: 0.1881913816108678d, y: 0.0909125817941574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5280824204668493d, y: 0.05510542989839995d), new NpgsqlTypes.NpgsqlPoint(x: 0.20831681742503227d, y: 0.6637149947806047d), new NpgsqlTypes.NpgsqlPoint(x: 0.18641082105641194d, y: 0.5605191260852233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2645890717583794d, y: 0.31116995417649373d), new NpgsqlTypes.NpgsqlPoint(x: 0.13155282148123926d, y: 0.3245480599210574d), new NpgsqlTypes.NpgsqlPoint(x: 0.2946762781315976d, y: 0.16317232950972127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0050219473409345294d, y: 0.6649740856734978d), new NpgsqlTypes.NpgsqlPoint(x: 0.2868420942357053d, y: 0.8296189065910564d), new NpgsqlTypes.NpgsqlPoint(x: 0.032543843527096494d, y: 0.010895689533988673d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10477836055254608d, y: 0.24035450657719482d), new NpgsqlTypes.NpgsqlPoint(x: 0.2279461765444779d, y: 0.6101649899460845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913239445045083d, y: 0.3856784430127739d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5573005564360134d, y: 0.29031679213536077d), new NpgsqlTypes.NpgsqlPoint(x: 0.716763181368121d, y: 0.6056170596270264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7818949654575893d, y: 0.23557812554491586d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313776249204286d, y: 0.25477529160966683d), new NpgsqlTypes.NpgsqlPoint(x: 0.3776975699985602d, y: 0.23004782267881696d), new NpgsqlTypes.NpgsqlPoint(x: 0.01538118232433916d, y: 0.15530483535669626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23574830090128396d, y: 0.5028464070834899d), new NpgsqlTypes.NpgsqlPoint(x: 0.8310917311411263d, y: 0.947103949829145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9773864992235397d, y: 0.2351977436441871d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6908335475468804d, y: 0.34456826549603137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142105885027765d, y: 0.28663116533983024d), new NpgsqlTypes.NpgsqlPoint(x: 0.36536073873537156d, y: 0.24102229053520108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26511046837141605d, y: 0.12792815562773285d), new NpgsqlTypes.NpgsqlPoint(x: 0.11659167806119897d, y: 0.18871895775082737d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376357366405824d, y: 0.12751455960000813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7586075790867896d, y: 0.19803270874741308d), new NpgsqlTypes.NpgsqlPoint(x: 0.4304723785552449d, y: 0.21608076565539913d), new NpgsqlTypes.NpgsqlPoint(x: 0.48048774224825663d, y: 0.17560808839223807d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5248405187194259d, y: 0.054321016167562464d), new NpgsqlTypes.NpgsqlPoint(x: 0.05675869746750295d, y: 0.30008713245846896d), new NpgsqlTypes.NpgsqlPoint(x: 0.905471706376703d, y: 0.7248721384616207d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06622169610495121d, y: 0.48988794014164094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7648969077203042d, y: 0.5916069654322645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660513095473878d, y: 0.8998638254177688d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0004982776518428489d, y: 0.46812768521842063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996690948640743d, y: 0.004810600559354117d), new NpgsqlTypes.NpgsqlPoint(x: 0.15384508348551895d, y: 0.9568458004168282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6424912638579683d, y: 0.47651618743914015d), new NpgsqlTypes.NpgsqlPoint(x: 0.42926525129960047d, y: 0.5736399700418833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8990393586578788d, y: 0.8396727681324507d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30361132766180654d, y: 0.21176426880383203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729842270825617d, y: 0.8202675941975294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099385478913739d, y: 0.16776268912301773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.966571698286234d, y: 0.5258351064523098d), new NpgsqlTypes.NpgsqlPoint(x: 0.45971235823339285d, y: 0.16741767558085052d), new NpgsqlTypes.NpgsqlPoint(x: 0.04322499671625546d, y: 0.23999849564681386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9432038439973369d, y: 0.23356834327089415d), new NpgsqlTypes.NpgsqlPoint(x: 0.49755850972470606d, y: 0.753696571786853d), new NpgsqlTypes.NpgsqlPoint(x: 0.10328944578457033d, y: 0.9394689370078182d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09393692053776015d, y: 0.10530830325443652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3188435250394298d, y: 0.6977742270769152d), new NpgsqlTypes.NpgsqlPoint(x: 0.07021353529709029d, y: 0.04067739966039707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3296693886786448d, y: 0.818791176190603d), new NpgsqlTypes.NpgsqlPoint(x: 0.45823786574080183d, y: 0.09513501259720392d), new NpgsqlTypes.NpgsqlPoint(x: 0.1630740884705194d, y: 0.9077295111183897d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44054200591185366d, y: 0.1968826816519631d), new NpgsqlTypes.NpgsqlPoint(x: 0.08492256497829798d, y: 0.26862723203463557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207662969503824d, y: 0.1775026627235171d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5850824247168895d, y: 0.7584307984320328d), new NpgsqlTypes.NpgsqlPoint(x: 0.07569628275957041d, y: 0.4024888066686949d), new NpgsqlTypes.NpgsqlPoint(x: 0.4470920142447703d, y: 0.7350484987886321d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7865415278609337d, y: 0.6462927162737928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6434558820122472d, y: 0.8243688925025743d), new NpgsqlTypes.NpgsqlPoint(x: 0.24076871422777624d, y: 0.41358829297718813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4922211175632929d, y: 0.5803026351443236d), new NpgsqlTypes.NpgsqlPoint(x: 0.20432503076602715d, y: 0.2065241452004355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6581291429564542d, y: 0.8031953196152608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4330392350527783d, y: 0.9509160831610473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440586723432715d, y: 0.5316010485421444d), new NpgsqlTypes.NpgsqlPoint(x: 0.14252039118008153d, y: 0.7997274385455899d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40195487277741815d, y: 0.3549499145604923d), new NpgsqlTypes.NpgsqlPoint(x: 0.16789238630314685d, y: 0.24610116398609794d), new NpgsqlTypes.NpgsqlPoint(x: 0.369394891751031d, y: 0.12835907836711613d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156533487712862d, y: 0.3661213669717057d), new NpgsqlTypes.NpgsqlPoint(x: 0.9982843905989944d, y: 0.7882983149084827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580739276398613d, y: 0.5322248591840637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4952641665287161d, y: 0.19021694860965943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660773572658325d, y: 0.8786085131926646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688110215354884d, y: 0.19625719663280594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7325469137757714d, y: 0.20494086753609353d), new NpgsqlTypes.NpgsqlPoint(x: 0.38138388858357675d, y: 0.14534586580070064d), new NpgsqlTypes.NpgsqlPoint(x: 0.3397416172434592d, y: 0.8148647526957444d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6823486614728519d, y: 0.47655018805652727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9820728775631115d, y: 0.3900816246575448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6970875863166837d, y: 0.48302392279582684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27057594463216106d, y: 0.4455102146638832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046687614418617d, y: 0.7590171422397753d), new NpgsqlTypes.NpgsqlPoint(x: 0.33627147122498025d, y: 0.14565457261951364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8620117544495376d, y: 0.09498476942731204d), new NpgsqlTypes.NpgsqlPoint(x: 0.11738228997424394d, y: 0.7209338712434755d), new NpgsqlTypes.NpgsqlPoint(x: 0.6132207658176941d, y: 0.2507701459487548d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3153677889587684d, y: 0.1701045109835022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547524019684309d, y: 0.24984016689655075d), new NpgsqlTypes.NpgsqlPoint(x: 0.39620614495593354d, y: 0.15606979086965322d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050971175900488275d, y: 0.4827680327142625d), new NpgsqlTypes.NpgsqlPoint(x: 0.2995787680424099d, y: 0.9880512235947813d), new NpgsqlTypes.NpgsqlPoint(x: 0.18739705766410808d, y: 0.04317267235360245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051640665518186d, y: 0.428691047405768d), new NpgsqlTypes.NpgsqlPoint(x: 0.2704959159425486d, y: 0.4559391559185283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664994600225242d, y: 0.5434208779024159d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9809104057615459d, y: 0.3554248224303348d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405877249365911d, y: 0.4429750107900745d), new NpgsqlTypes.NpgsqlPoint(x: 0.28738640609031063d, y: 0.27894400789499885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04336750116598764d, y: 0.5699107886745683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7464063020954494d, y: 0.5614936841972131d), new NpgsqlTypes.NpgsqlPoint(x: 0.15731363216265037d, y: 0.6170615150451982d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32799014683498207d, y: 0.8121992107276821d), new NpgsqlTypes.NpgsqlPoint(x: 0.07280612846246959d, y: 0.4765838897262663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426106944143098d, y: 0.7877035581588139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01796942594274631d, y: 0.018591524125429637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673907672203647d, y: 0.4556343332350946d), new NpgsqlTypes.NpgsqlPoint(x: 0.2716682429430838d, y: 0.6699900016470928d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793095771717018d, y: 0.8412928642248437d), new NpgsqlTypes.NpgsqlPoint(x: 0.35142102205810655d, y: 0.7027276640824783d), new NpgsqlTypes.NpgsqlPoint(x: 0.8112160571243789d, y: 0.03863526849798937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2515654878017075d, y: 0.5992875865311296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9315515004094591d, y: 0.5385579219252388d), new NpgsqlTypes.NpgsqlPoint(x: 0.3237579993099292d, y: 0.8303204821795511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736515271101091d, y: 0.26686735869625255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5908374081272328d, y: 0.2265682331760227d), new NpgsqlTypes.NpgsqlPoint(x: 0.09865457388524268d, y: 0.8305725685364931d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3984937044935577d, y: 0.18320409912094715d), new NpgsqlTypes.NpgsqlPoint(x: 0.19617992768435466d, y: 0.34764623365604386d), new NpgsqlTypes.NpgsqlPoint(x: 0.10601223314530583d, y: 0.5822771841537061d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8065141815974691d, y: 0.6933288516190825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3515251763422731d, y: 0.5316285102104185d), new NpgsqlTypes.NpgsqlPoint(x: 0.34900070790559423d, y: 0.5343407501988398d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3708895312548146d, y: 0.6307167815036976d), new NpgsqlTypes.NpgsqlPoint(x: 0.47133240428096534d, y: 0.11329439188606749d), new NpgsqlTypes.NpgsqlPoint(x: 0.11194146183073872d, y: 0.44225884274557303d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3811152755762547d, y: 0.43542639069114675d), new NpgsqlTypes.NpgsqlPoint(x: 0.368661540253055d, y: 0.7536588347753266d), new NpgsqlTypes.NpgsqlPoint(x: 0.24375097729163742d, y: 0.361512639431238d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22287064702916726d, y: 0.0801253313127196d), new NpgsqlTypes.NpgsqlPoint(x: 0.692712833413368d, y: 0.19610224218515737d), new NpgsqlTypes.NpgsqlPoint(x: 0.48508904430149835d, y: 0.3877454212073428d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2283495701557694d, y: 0.7575296128101233d), new NpgsqlTypes.NpgsqlPoint(x: 0.2619780571300716d, y: 0.07348390309091835d), new NpgsqlTypes.NpgsqlPoint(x: 0.7758155826602281d, y: 0.7941437512543075d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06924410158609018d, y: 0.559633630400613d), new NpgsqlTypes.NpgsqlPoint(x: 0.5387865995084025d, y: 0.07952389227214851d), new NpgsqlTypes.NpgsqlPoint(x: 0.14123623528219298d, y: 0.2893141426407265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38268457914504883d, y: 0.4030489064162611d), new NpgsqlTypes.NpgsqlPoint(x: 0.23484825280688781d, y: 0.45891222013182165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528485396973092d, y: 0.16019663993675703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8509903322767097d, y: 0.7527242012882623d), new NpgsqlTypes.NpgsqlPoint(x: 0.05063484500057269d, y: 0.3380356313957128d), new NpgsqlTypes.NpgsqlPoint(x: 0.32647904431774155d, y: 0.1598183331654015d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33142757962195857d, y: 0.44486993491570204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557475921586004d, y: 0.2415551449683251d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699468436193821d, y: 0.5428523479913776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2644597582962813d, y: 0.5719108362462925d), new NpgsqlTypes.NpgsqlPoint(x: 0.11658546643589462d, y: 0.27530414892870103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820846943819539d, y: 0.5024799939077057d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3881954249830547d, y: 0.2715335584639085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8047754988619912d, y: 0.04173226852913392d), new NpgsqlTypes.NpgsqlPoint(x: 0.17811189521055482d, y: 0.7262378526131585d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6812977605965131d, y: 0.7567307848666487d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430288885426383d, y: 0.30513714098721956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5263714418145187d, y: 0.42703984496068614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3094740090639304d, y: 0.8456048595149567d), new NpgsqlTypes.NpgsqlPoint(x: 0.09787390051313605d, y: 0.06220499424247583d), new NpgsqlTypes.NpgsqlPoint(x: 0.3849687509408818d, y: 0.014692725268697027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.908749080551268d, y: 0.4434467186356389d), new NpgsqlTypes.NpgsqlPoint(x: 0.2266386862625741d, y: 0.8135699219582696d), new NpgsqlTypes.NpgsqlPoint(x: 0.6346768616207266d, y: 0.6143324527977891d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8998200561049614d, y: 0.9166050805377901d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231365232332324d, y: 0.01985317617919713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5755439257150621d, y: 0.32237842350020507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.729869827124051d, y: 0.5154934653829055d), new NpgsqlTypes.NpgsqlPoint(x: 0.861246208851443d, y: 0.6964134725372669d), new NpgsqlTypes.NpgsqlPoint(x: 0.5790906314137197d, y: 0.41287113024743705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2626566917982702d, y: 0.42086830705137357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045118369910584d, y: 0.30619947379860135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5845274613052259d, y: 0.09087330757056256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9495254567864415d, y: 0.7446996776453018d), new NpgsqlTypes.NpgsqlPoint(x: 0.13321752590697178d, y: 0.615664641270654d), new NpgsqlTypes.NpgsqlPoint(x: 0.26941417800840295d, y: 0.5309927781519818d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13634630111244062d, y: 0.5078938369280116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9908855668502197d, y: 0.6835984366336855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920343631855629d, y: 0.7613304599866877d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6882653503251492d, y: 0.22707695382907134d), new NpgsqlTypes.NpgsqlPoint(x: 0.39159101054042167d, y: 0.09974539120604098d), new NpgsqlTypes.NpgsqlPoint(x: 0.44461374111011187d, y: 0.30679932539942767d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11938417272537116d, y: 0.47059150357602275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459068289947657d, y: 0.1926555903359567d), new NpgsqlTypes.NpgsqlPoint(x: 0.08428090347476924d, y: 0.34380843277344697d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28147754900809985d, y: 0.3883895279236106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903287335219765d, y: 0.7982221525175042d), new NpgsqlTypes.NpgsqlPoint(x: 0.75739127432508d, y: 0.006087365413802059d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7005873446617085d, y: 0.6880462342389974d), new NpgsqlTypes.NpgsqlPoint(x: 0.47339636121192263d, y: 0.342261644371888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566190574015209d, y: 0.21555838737026234d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8919519117318763d, y: 0.45449257419018196d), new NpgsqlTypes.NpgsqlPoint(x: 0.21386570535378258d, y: 0.14600857830977765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180821605762841d, y: 0.34470114456846224d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.853300146344964d, y: 0.9322782240874312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8759024237936627d, y: 0.1482363225060035d), new NpgsqlTypes.NpgsqlPoint(x: 0.571459892359884d, y: 0.2551236674016454d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11764982068686747d, y: 0.9914040047546462d), new NpgsqlTypes.NpgsqlPoint(x: 0.09634637590896722d, y: 0.33854890664961623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6518740214443334d, y: 0.7881299385373292d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30514653465681885d, y: 0.6085212679278597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7207874668746733d, y: 0.33007010638797596d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643526193189505d, y: 0.7451850519545011d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07012985545275952d, y: 0.4765391769198183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602548397942259d, y: 0.19351902188560066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5216272356926975d, y: 0.13987585224654386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334753797896052d, y: 0.6540384529554402d), new NpgsqlTypes.NpgsqlPoint(x: 0.02416246092078378d, y: 0.2597637973587955d), new NpgsqlTypes.NpgsqlPoint(x: 0.4724255555403425d, y: 0.061137141203247314d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20820927724865135d, y: 0.38498251589103616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8562070560631018d, y: 0.6217290062827656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4471224658296822d, y: 0.619944522238056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4834666178597422d, y: 0.9356659911056984d), new NpgsqlTypes.NpgsqlPoint(x: 0.549164639494343d, y: 0.6434485432441465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4128540829704014d, y: 0.9595064333792237d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3737736685047829d, y: 0.3244428645639629d), new NpgsqlTypes.NpgsqlPoint(x: 0.17551375380915346d, y: 0.9209493744464475d), new NpgsqlTypes.NpgsqlPoint(x: 0.967405682450936d, y: 0.2794385641471284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04407162906899642d, y: 0.15057967308671383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262067193275767d, y: 0.794476142060703d), new NpgsqlTypes.NpgsqlPoint(x: 0.17645695397196515d, y: 0.7164698511608073d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39626392144177747d, y: 0.4730220444397668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567799465324613d, y: 0.9374936185729654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551983559890694d, y: 0.4739775092114247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1219039301190169d, y: 0.81103855832724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612813111275705d, y: 0.7896184888628953d), new NpgsqlTypes.NpgsqlPoint(x: 0.13888389073370944d, y: 0.816299628638787d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8733831931437894d, y: 0.10676226674016054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454726106501964d, y: 0.7389266949742753d), new NpgsqlTypes.NpgsqlPoint(x: 0.18106745166169402d, y: 0.7544435156029333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7749856741876322d, y: 0.7719010580435794d), new NpgsqlTypes.NpgsqlPoint(x: 0.49851754339457677d, y: 0.027384369969316702d), new NpgsqlTypes.NpgsqlPoint(x: 0.41834614528532255d, y: 0.686099084967468d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9109341163697197d, y: 0.9695784463313959d), new NpgsqlTypes.NpgsqlPoint(x: 0.23539118888247745d, y: 0.8545777465692137d), new NpgsqlTypes.NpgsqlPoint(x: 0.02613212679706889d, y: 0.10845273022723512d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22706819043810134d, y: 0.717843499398893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7348681231580012d, y: 0.5500635949709884d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571387595906285d, y: 0.30183185927910827d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8507589223150216d, y: 0.8668857815750057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8868798735241523d, y: 0.4878732125503007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8870209849096028d, y: 0.7107607990197694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4779333749217276d, y: 0.8134401475228519d), new NpgsqlTypes.NpgsqlPoint(x: 0.031173424699817653d, y: 0.42432844067457076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4323037662707545d, y: 0.5537294321723406d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307576869912317d, y: 0.6601623191475007d), new NpgsqlTypes.NpgsqlPoint(x: 0.1353916233070489d, y: 0.45259916427075186d), new NpgsqlTypes.NpgsqlPoint(x: 0.38727816363060685d, y: 0.38307641011311866d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12630773068251944d, y: 0.279008930323d), new NpgsqlTypes.NpgsqlPoint(x: 0.22005629809978688d, y: 0.5645054991708718d), new NpgsqlTypes.NpgsqlPoint(x: 0.2203053453554742d, y: 0.9487079715697414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7582724764241957d, y: 0.25544334119573364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479628676014941d, y: 0.9540841597678582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275041425765234d, y: 0.33553376640602384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9879336946486101d, y: 0.7722930968365108d), new NpgsqlTypes.NpgsqlPoint(x: 0.43648647060746093d, y: 0.8742468999587895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495284552497637d, y: 0.8931850753323506d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8227685642710646d, y: 0.0594936129790018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9428649601547872d, y: 0.49705942862785024d), new NpgsqlTypes.NpgsqlPoint(x: 0.003380063922737153d, y: 0.8868528587130518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.745143572576051d, y: 0.9410983968697963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6972200496546904d, y: 0.059302951874924736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396717190922172d, y: 0.40254882188136054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7526777967974679d, y: 0.685640006508681d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664808749483423d, y: 0.976910835301105d), new NpgsqlTypes.NpgsqlPoint(x: 0.15896485208551103d, y: 0.3131651915107051d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31570143820122987d, y: 0.3226572966072213d), new NpgsqlTypes.NpgsqlPoint(x: 0.719195607950849d, y: 0.289607447537939d), new NpgsqlTypes.NpgsqlPoint(x: 0.3626818333650971d, y: 0.8686527741694652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6439803411222733d, y: 0.02734481608783146d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171933219766063d, y: 0.6415574914874365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282652037945013d, y: 0.9338004578954795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5035283803464881d, y: 0.9744493710370072d), new NpgsqlTypes.NpgsqlPoint(x: 0.47261020502371254d, y: 0.3034469855641265d), new NpgsqlTypes.NpgsqlPoint(x: 0.44742675139537647d, y: 0.11047945067500631d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.72951565891084d, y: 0.48776905025911577d), new NpgsqlTypes.NpgsqlPoint(x: 0.8806220382359774d, y: 0.1299544611101784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5917968475594716d, y: 0.4059566436663312d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6884050982264748d, y: 0.19252660178329783d), new NpgsqlTypes.NpgsqlPoint(x: 0.35059678229627333d, y: 0.5652442405001653d), new NpgsqlTypes.NpgsqlPoint(x: 0.049589461454178085d, y: 0.8322499822343252d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.75442801042959d, y: 0.4735119345704777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965158837760335d, y: 0.6096409237328081d), new NpgsqlTypes.NpgsqlPoint(x: 0.21391846130119962d, y: 0.5256602406051739d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5660640567274852d, y: 0.471531111164161d), new NpgsqlTypes.NpgsqlPoint(x: 0.08223615599208889d, y: 0.5149133071856646d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620775050681456d, y: 0.5463070744914205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21855946580708596d, y: 0.6092294841585988d), new NpgsqlTypes.NpgsqlPoint(x: 0.13077146430720432d, y: 0.516519024775316d), new NpgsqlTypes.NpgsqlPoint(x: 0.3892555993909015d, y: 0.49086516414195047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9282327106361117d, y: 0.019794295049760047d), new NpgsqlTypes.NpgsqlPoint(x: 0.2618506074896487d, y: 0.019604718711841995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764795471293058d, y: 0.18900848370891077d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33065920479121047d, y: 0.9751153930507324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3854736215796586d, y: 0.4138764246196942d), new NpgsqlTypes.NpgsqlPoint(x: 0.4011045905267753d, y: 0.007520658393713298d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44760495839713355d, y: 0.894772789883357d), new NpgsqlTypes.NpgsqlPoint(x: 0.24133985915760425d, y: 0.5154333615890442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8685363685139711d, y: 0.7934742243647975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.537932542489925d, y: 0.8975003638265246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5753887400848708d, y: 0.9660874376002756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922633327028473d, y: 0.45423758261290115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5105664575016836d, y: 0.764362938028312d), new NpgsqlTypes.NpgsqlPoint(x: 0.29692503657366864d, y: 0.5810062532047026d), new NpgsqlTypes.NpgsqlPoint(x: 0.5222448849436421d, y: 0.6203440747984063d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5101388624301142d, y: 0.9255941140136306d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098809884097126d, y: 0.774728860718156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865508976491715d, y: 0.5551375240178833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9500370564892553d, y: 0.6336167570871167d), new NpgsqlTypes.NpgsqlPoint(x: 0.29128536375250047d, y: 0.4813280730484656d), new NpgsqlTypes.NpgsqlPoint(x: 0.3496783884135227d, y: 0.9109920962675588d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.918147922982006d, y: 0.586638138073401d), new NpgsqlTypes.NpgsqlPoint(x: 0.49615820144031175d, y: 0.56903724635796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725632529595563d, y: 0.8673769489811317d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7579410835731862d, y: 0.5579921828827216d), new NpgsqlTypes.NpgsqlPoint(x: 0.20798279235694583d, y: 0.2758342305697046d), new NpgsqlTypes.NpgsqlPoint(x: 0.0039466100382908875d, y: 0.8566867608518528d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5452980292777765d, y: 0.8547206410534578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6317031038513986d, y: 0.6002535914887808d), new NpgsqlTypes.NpgsqlPoint(x: 0.588843405376086d, y: 0.10955055098863153d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49959897917393015d, y: 0.5233353997604164d), new NpgsqlTypes.NpgsqlPoint(x: 0.17558206543064048d, y: 0.7096389489773134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130056393316384d, y: 0.047751298648031404d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08071684969524684d, y: 0.196414109554908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9214488804461713d, y: 0.937002245003058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188372933769741d, y: 0.48917517758970197d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6578888576342125d, y: 0.02641971147046307d), new NpgsqlTypes.NpgsqlPoint(x: 0.44986867077937176d, y: 0.5749465201297667d), new NpgsqlTypes.NpgsqlPoint(x: 0.15260153970622548d, y: 0.14983664175061606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8169348379845125d, y: 0.31761866006366335d), new NpgsqlTypes.NpgsqlPoint(x: 0.49334972173525793d, y: 0.8151274260436834d), new NpgsqlTypes.NpgsqlPoint(x: 0.11101148361558855d, y: 0.06917631982200945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41397966037571343d, y: 0.6654885171702783d), new NpgsqlTypes.NpgsqlPoint(x: 0.3796672450979609d, y: 0.08819877434620138d), new NpgsqlTypes.NpgsqlPoint(x: 0.14424466461418795d, y: 0.0453302063815616d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35328195989384537d, y: 0.36101716945420426d), new NpgsqlTypes.NpgsqlPoint(x: 0.2395073512004794d, y: 0.049509571398845265d), new NpgsqlTypes.NpgsqlPoint(x: 0.44237670846672983d, y: 0.8441771959634615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8281375784326376d, y: 0.5475272922502242d), new NpgsqlTypes.NpgsqlPoint(x: 0.49871210229647944d, y: 0.04245977237383258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260400784479971d, y: 0.08591496157743539d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8393160846536535d, y: 0.3791280304025866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2441294471104417d, y: 0.10875843587336775d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032768821697204d, y: 0.4180725433775081d)),

},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
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
            overrideAliasPrefixs: ["item1", "item2"],
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 139, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 165, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 142, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 39, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 157, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 121, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 13, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 18, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[32],_testData[34], false);
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
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPathpathArray2M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

