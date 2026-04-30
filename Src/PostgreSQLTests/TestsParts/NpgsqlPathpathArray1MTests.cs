

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36638916453429915d, y: 0.5281488815855402d), new NpgsqlTypes.NpgsqlPoint(x: 0.3009391338748115d, y: 0.8283185882346716d), new NpgsqlTypes.NpgsqlPoint(x: 0.22757183849723805d, y: 0.9241037269978203d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030518979022506665d, y: 0.07724412068118547d), new NpgsqlTypes.NpgsqlPoint(x: 0.066150748183475d, y: 0.20273619237380203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283217070390487d, y: 0.648296924277479d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3910944170201909d, y: 0.16680443511208698d), new NpgsqlTypes.NpgsqlPoint(x: 0.25857959677832965d, y: 0.0961086312214744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7146965728955244d, y: 0.5264482347601565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.726567812198979d, y: 0.24645888190119647d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060815518610469d, y: 0.1986795261539437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370432747394488d, y: 0.593792461640673d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3743951445798773d, y: 0.7795422476588545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3501749867642123d, y: 0.6860408616674525d), new NpgsqlTypes.NpgsqlPoint(x: 0.33582229678287423d, y: 0.4875810463385877d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8114285097394526d, y: 0.5100881184415978d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436942663393965d, y: 0.02999845216284558d), new NpgsqlTypes.NpgsqlPoint(x: 0.7794020091715069d, y: 0.8086649033927873d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.481222283000755d, y: 0.33194693462106073d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977228854173198d, y: 0.9965493638047884d), new NpgsqlTypes.NpgsqlPoint(x: 0.8194931001654954d, y: 0.6733945528368208d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31838143479079406d, y: 0.5496943837616183d), new NpgsqlTypes.NpgsqlPoint(x: 0.30510919058275077d, y: 0.43335064105453514d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730958419944046d, y: 0.9517089582027844d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23815273324841657d, y: 0.9708332809924295d), new NpgsqlTypes.NpgsqlPoint(x: 0.19309325112149156d, y: 0.6063682320761283d), new NpgsqlTypes.NpgsqlPoint(x: 0.32079136088387716d, y: 0.05485701119211939d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4824948089337123d, y: 0.5615227115527041d), new NpgsqlTypes.NpgsqlPoint(x: 0.25040107797806277d, y: 0.7524364753011497d), new NpgsqlTypes.NpgsqlPoint(x: 0.4039288002367196d, y: 0.3556286331101781d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6386510933828938d, y: 0.09710716383855356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6193029879710295d, y: 0.20385357070615084d), new NpgsqlTypes.NpgsqlPoint(x: 0.48195763966555205d, y: 0.8245729483873822d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8267519080564348d, y: 0.8179866196901048d), new NpgsqlTypes.NpgsqlPoint(x: 0.1592681495889009d, y: 0.844276640358328d), new NpgsqlTypes.NpgsqlPoint(x: 0.44820134914626264d, y: 0.7758681043862248d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3099408272275198d, y: 0.8390460573249859d), new NpgsqlTypes.NpgsqlPoint(x: 0.2517939971932811d, y: 0.05950378817536972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8577347116002113d, y: 0.33090949524567403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3026728600950892d, y: 0.8116737259414245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851468949667543d, y: 0.8698883861118952d), new NpgsqlTypes.NpgsqlPoint(x: 0.18735078828376572d, y: 0.18216851009086665d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9978719048699037d, y: 0.18723954325890058d), new NpgsqlTypes.NpgsqlPoint(x: 0.41643376581369296d, y: 0.9772612356747029d), new NpgsqlTypes.NpgsqlPoint(x: 0.3010708811238477d, y: 0.5778648593454548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48996704420438664d, y: 0.8195866597475264d), new NpgsqlTypes.NpgsqlPoint(x: 0.19860275918658332d, y: 0.16094012822880588d), new NpgsqlTypes.NpgsqlPoint(x: 0.10996634156895946d, y: 0.997570600188186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6662817244721927d, y: 0.7359868706028884d), new NpgsqlTypes.NpgsqlPoint(x: 0.001581683861807015d, y: 0.8337011420539645d), new NpgsqlTypes.NpgsqlPoint(x: 0.5752205793542785d, y: 0.17305439256456878d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7386158213879065d, y: 0.6396220999882999d), new NpgsqlTypes.NpgsqlPoint(x: 0.29377224012822745d, y: 0.8709736714719954d), new NpgsqlTypes.NpgsqlPoint(x: 0.946646399272203d, y: 0.20174441090063622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9415254368102304d, y: 0.30477096731918774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936432590549094d, y: 0.48227407984701953d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570733296655536d, y: 0.8445106931579351d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3006550649859835d, y: 0.2639223981475859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7492421225223617d, y: 0.11332053258987851d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139130882153541d, y: 0.3681595936831986d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3256458262165671d, y: 0.882275297736526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7705713766532901d, y: 0.6325289775995099d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394354423989947d, y: 0.6959841749106163d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8970303664600352d, y: 0.3656280181763709d), new NpgsqlTypes.NpgsqlPoint(x: 0.3587044995396177d, y: 0.364306309044526d), new NpgsqlTypes.NpgsqlPoint(x: 0.18828760464259864d, y: 0.7497342181984629d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1808345682097533d, y: 0.2080532246991985d), new NpgsqlTypes.NpgsqlPoint(x: 0.2822586120131334d, y: 0.15427744029008394d), new NpgsqlTypes.NpgsqlPoint(x: 0.2772801815147403d, y: 0.8714751842407706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04077373897057868d, y: 0.7715860621943023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178271710729001d, y: 0.3835981709914208d), new NpgsqlTypes.NpgsqlPoint(x: 0.17215823975238576d, y: 0.17694083596030308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9160945559294161d, y: 0.4674359777985847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303357685628191d, y: 0.3449273736280162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875334720886395d, y: 0.8135566455372011d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3822822480382049d, y: 0.28372541084633385d), new NpgsqlTypes.NpgsqlPoint(x: 0.020678004781141013d, y: 0.0926657444218747d), new NpgsqlTypes.NpgsqlPoint(x: 0.2748581916350207d, y: 0.017857501522924535d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.229240436915078d, y: 0.46937439231604516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105963342312475d, y: 0.3056652185427924d), new NpgsqlTypes.NpgsqlPoint(x: 0.611421692454582d, y: 0.18508474411004827d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1281111431123776d, y: 0.3218725540432974d), new NpgsqlTypes.NpgsqlPoint(x: 0.18797510398171424d, y: 0.17720748096758465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651403052471662d, y: 0.7705605267626678d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.954799196102648d, y: 0.9986900246637342d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008581795642703d, y: 0.7459903729231674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004642091302252d, y: 0.43391295200474245d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07773810782528356d, y: 0.753625029652783d), new NpgsqlTypes.NpgsqlPoint(x: 0.29411685431323764d, y: 0.16443611700394078d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544888638921087d, y: 0.06354791498174484d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11305287653665297d, y: 0.012649810027132724d), new NpgsqlTypes.NpgsqlPoint(x: 0.30958406355131696d, y: 0.14169540645058165d), new NpgsqlTypes.NpgsqlPoint(x: 0.555033379514614d, y: 0.7626934272779362d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3694787309957188d, y: 0.0495929945282223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063450438406498d, y: 0.4269271536249748d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560761423387848d, y: 0.6154733124221012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5828168604090396d, y: 0.20933438662110881d), new NpgsqlTypes.NpgsqlPoint(x: 0.26733451510671635d, y: 0.13297868231501353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930758631265472d, y: 0.4463720797498161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030170266107904853d, y: 0.4881995202824124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901384648010819d, y: 0.0575702548079422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6824246277805981d, y: 0.33269058012072505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4055646770449197d, y: 0.2545562854459379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577089387881057d, y: 0.36201597104082317d), new NpgsqlTypes.NpgsqlPoint(x: 0.19355290116689694d, y: 0.5535907538598183d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08230130324873397d, y: 0.21052527280023192d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734947646883692d, y: 0.03689840343500783d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535872112442777d, y: 0.16385913597246826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9881951345336795d, y: 0.712716907638152d), new NpgsqlTypes.NpgsqlPoint(x: 0.21594939462338514d, y: 0.8853545960385301d), new NpgsqlTypes.NpgsqlPoint(x: 0.1629413877889151d, y: 0.29516136897239564d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7554282639179913d, y: 0.652024476703841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342102645184855d, y: 0.3969341738486559d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609648794251605d, y: 0.6165027230918146d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45830345129591044d, y: 0.18199895501125474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8100126106900705d, y: 0.22683662964968665d), new NpgsqlTypes.NpgsqlPoint(x: 0.9102398556838607d, y: 0.5314907796842464d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1322150515848517d, y: 0.23135037027127903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600769352137126d, y: 0.597376150726424d), new NpgsqlTypes.NpgsqlPoint(x: 0.004856214880645471d, y: 0.4841949452764249d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6668511903964396d, y: 0.35789689341230824d), new NpgsqlTypes.NpgsqlPoint(x: 0.10057218236658683d, y: 0.7621890042818726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530815266763885d, y: 0.62474276887286d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5402926520640781d, y: 0.10562961972316842d), new NpgsqlTypes.NpgsqlPoint(x: 0.3070325347024423d, y: 0.2848483863130783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5653244388743359d, y: 0.9935838531908935d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13923029458085423d, y: 0.6770193290468507d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203614196571961d, y: 0.8403648302127653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926296666274565d, y: 0.6046104403701235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641917023742318d, y: 0.2928066680976277d), new NpgsqlTypes.NpgsqlPoint(x: 0.01204228094801596d, y: 0.5695264726593149d), new NpgsqlTypes.NpgsqlPoint(x: 0.23281499469121059d, y: 0.8961043180925913d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3782455982638848d, y: 0.07195140571433356d), new NpgsqlTypes.NpgsqlPoint(x: 0.29424152531824277d, y: 0.8715012986992595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844184428767803d, y: 0.012346034882331769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9483835020955014d, y: 0.11818941341278721d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442424675410739d, y: 0.8923111224576235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4463469473020022d, y: 0.4622204737042639d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47911325107409986d, y: 0.27928616243790216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6925096707915547d, y: 0.024330941971344444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766227710214254d, y: 0.23587185539392252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9236767698096118d, y: 0.1862490164822933d), new NpgsqlTypes.NpgsqlPoint(x: 0.3686246333348815d, y: 0.9995767801767507d), new NpgsqlTypes.NpgsqlPoint(x: 0.05282643461835668d, y: 0.03589354003878453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08070073258138544d, y: 0.4635330458597797d), new NpgsqlTypes.NpgsqlPoint(x: 0.26816446975928165d, y: 0.09228092086769024d), new NpgsqlTypes.NpgsqlPoint(x: 0.31310969853933635d, y: 0.8520826605818749d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27688533669390447d, y: 0.30818972739565054d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597749975703952d, y: 0.8178643347299137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521292724797425d, y: 0.10479697933123588d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.755966054722781d, y: 0.786355922572834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694628822500214d, y: 0.8267662568046571d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555377521527455d, y: 0.13808367924661225d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47418703284729924d, y: 0.6876115989055566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035678174120935d, y: 0.7122319558943478d), new NpgsqlTypes.NpgsqlPoint(x: 0.053588586000755d, y: 0.5151569076111625d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8910055032679804d, y: 0.28670131640855023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266643229492972d, y: 0.6376007865688769d), new NpgsqlTypes.NpgsqlPoint(x: 0.21558569878854306d, y: 0.2959748486695434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9495354850106541d, y: 0.6326290028753938d), new NpgsqlTypes.NpgsqlPoint(x: 0.49343408406303146d, y: 0.655046855737845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842735795594686d, y: 0.9046031420361563d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.64969918571986d, y: 0.46226210962013015d), new NpgsqlTypes.NpgsqlPoint(x: 0.23734090765102622d, y: 0.35618036668417496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080684535886933d, y: 0.2580818107864645d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7065163573298165d, y: 0.2606463824169939d), new NpgsqlTypes.NpgsqlPoint(x: 0.3713177259530993d, y: 0.3543330279209649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324222273896551d, y: 0.16170604511066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22012406033132426d, y: 0.10196654451658693d), new NpgsqlTypes.NpgsqlPoint(x: 0.6861446827495701d, y: 0.6978912933588121d), new NpgsqlTypes.NpgsqlPoint(x: 0.851680407973289d, y: 0.6178888904941482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042242465450456956d, y: 0.9501175574251359d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008167997771074d, y: 0.32485408195339116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5102477375977633d, y: 0.672266013948116d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.533938512788632d, y: 0.40213566566914516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6765428087200424d, y: 0.4806750493702793d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646160005215804d, y: 0.3435005943455356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36561208776277565d, y: 0.38915536569919584d), new NpgsqlTypes.NpgsqlPoint(x: 0.2163993764721457d, y: 0.3613945737005968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8574502954873964d, y: 0.9845815293030331d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5980178596351506d, y: 0.47195187010332895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3419450968317769d, y: 0.7680674925424646d), new NpgsqlTypes.NpgsqlPoint(x: 0.005316107223465094d, y: 0.27159992390441323d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7693830055040427d, y: 0.25813623839016264d), new NpgsqlTypes.NpgsqlPoint(x: 0.05729967544759773d, y: 0.13507776994232967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268185161672421d, y: 0.524409784745302d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.567752726915845d, y: 0.3859725782314257d), new NpgsqlTypes.NpgsqlPoint(x: 0.50741880395486d, y: 0.5863766139576501d), new NpgsqlTypes.NpgsqlPoint(x: 0.8290738307918295d, y: 0.33709899699898316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8728150362756202d, y: 0.5510973477890739d), new NpgsqlTypes.NpgsqlPoint(x: 0.11643043198270309d, y: 0.37288769581236014d), new NpgsqlTypes.NpgsqlPoint(x: 0.35769248247843544d, y: 0.6463663273619691d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32674129048494527d, y: 0.36358022746666185d), new NpgsqlTypes.NpgsqlPoint(x: 0.042226304264618375d, y: 0.08576305175852639d), new NpgsqlTypes.NpgsqlPoint(x: 0.23755976336119933d, y: 0.5991128340436095d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9760665140741831d, y: 0.20328901105670405d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767823004269713d, y: 0.4026218801402007d), new NpgsqlTypes.NpgsqlPoint(x: 0.791415987026673d, y: 0.4524518990056908d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02948788022295512d, y: 0.5179759843015901d), new NpgsqlTypes.NpgsqlPoint(x: 0.26963895117190617d, y: 0.8837940767513649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8263503534919985d, y: 0.9939109960989553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9472372055748568d, y: 0.005807118207086348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864380772469125d, y: 0.7650656856742647d), new NpgsqlTypes.NpgsqlPoint(x: 0.4399459065972694d, y: 0.39884927084722177d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5655284254437463d, y: 0.02657283119326781d), new NpgsqlTypes.NpgsqlPoint(x: 0.23826648245526738d, y: 0.7311847516655137d), new NpgsqlTypes.NpgsqlPoint(x: 0.07404075966239476d, y: 0.06341353843563569d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5093564003147782d, y: 0.4424990610611069d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758883292325387d, y: 0.0004587359653035472d), new NpgsqlTypes.NpgsqlPoint(x: 0.785310463256601d, y: 0.9495454596659606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5509304834218941d, y: 0.37181203092577353d), new NpgsqlTypes.NpgsqlPoint(x: 0.04044499995398165d, y: 0.6579033345583628d), new NpgsqlTypes.NpgsqlPoint(x: 0.08741349362931583d, y: 0.7053534922427181d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48013792784370823d, y: 0.5053861590064465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197681886039807d, y: 0.700284667437319d), new NpgsqlTypes.NpgsqlPoint(x: 0.9221305218929358d, y: 0.5520226842321725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.875302760534492d, y: 0.5350044153611456d), new NpgsqlTypes.NpgsqlPoint(x: 0.2750105618868266d, y: 0.5059766090605405d), new NpgsqlTypes.NpgsqlPoint(x: 0.17753448174636077d, y: 0.9175944712751554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4497406816070717d, y: 0.6832493751529227d), new NpgsqlTypes.NpgsqlPoint(x: 0.16776138873400015d, y: 0.12878728266834594d), new NpgsqlTypes.NpgsqlPoint(x: 0.36276628860699667d, y: 0.9945642196245337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.176878169648078d, y: 0.6397556519602821d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020206085812407d, y: 0.9149608217097273d), new NpgsqlTypes.NpgsqlPoint(x: 0.3666720138825198d, y: 0.8532811490138658d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1763900667438122d, y: 0.7956160724882447d), new NpgsqlTypes.NpgsqlPoint(x: 0.534331769953764d, y: 0.20017432135503532d), new NpgsqlTypes.NpgsqlPoint(x: 0.22091146003794027d, y: 0.7537219948533253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9940167144504587d, y: 0.2416942799413342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680103748737984d, y: 0.9181117542583481d), new NpgsqlTypes.NpgsqlPoint(x: 0.38439960606544377d, y: 0.5773769342875821d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9028292321701722d, y: 0.03737355277782728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2831626334323024d, y: 0.5176968499096557d), new NpgsqlTypes.NpgsqlPoint(x: 0.934581645939367d, y: 0.5850724977506293d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2828719402972514d, y: 0.9425990168028209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866586465746892d, y: 0.773053123560548d), new NpgsqlTypes.NpgsqlPoint(x: 0.5907966877736495d, y: 0.07192431460267701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5217022248431809d, y: 0.12851827618563672d), new NpgsqlTypes.NpgsqlPoint(x: 0.555480513756954d, y: 0.8469298221813416d), new NpgsqlTypes.NpgsqlPoint(x: 0.12134054680727924d, y: 0.6090857754941644d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.911240018008283d, y: 0.7733066972870433d), new NpgsqlTypes.NpgsqlPoint(x: 0.16824514147366054d, y: 0.14783096730132816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562776743238318d, y: 0.681903398312594d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4673314617529375d, y: 0.5947033168321562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4229217213738259d, y: 0.3618602670653882d), new NpgsqlTypes.NpgsqlPoint(x: 0.0311161610533488d, y: 0.5593171132874961d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.812119721305806d, y: 0.9061511749447183d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534479080593691d, y: 0.3171593011795498d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843738052503892d, y: 0.870528889263178d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.735306478296872d, y: 0.5857526935621594d), new NpgsqlTypes.NpgsqlPoint(x: 0.2097483521754956d, y: 0.9690660675723667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8488710421273488d, y: 0.8537015752123615d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.896751058793159d, y: 0.4125095634471124d), new NpgsqlTypes.NpgsqlPoint(x: 0.45442577628106484d, y: 0.9533466506948398d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816641157199809d, y: 0.3475576233482268d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42828205887679804d, y: 0.5684946696851767d), new NpgsqlTypes.NpgsqlPoint(x: 0.35772215077949265d, y: 0.5266865223790702d), new NpgsqlTypes.NpgsqlPoint(x: 0.05707180447321547d, y: 0.24027503382226822d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7221850384914723d, y: 0.02027655726276756d), new NpgsqlTypes.NpgsqlPoint(x: 0.07244800486250114d, y: 0.16278140234552496d), new NpgsqlTypes.NpgsqlPoint(x: 0.3006145440046092d, y: 0.03145076594542029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.810062079370957d, y: 0.06247377818024502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440656146657551d, y: 0.48109549605936774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8139278197729002d, y: 0.4664741388666721d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0932412453915955d, y: 0.4709100445962716d), new NpgsqlTypes.NpgsqlPoint(x: 0.47862155873758616d, y: 0.32499141277306953d), new NpgsqlTypes.NpgsqlPoint(x: 0.14460756782933837d, y: 0.7573867150797219d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19842581584485486d, y: 0.5764683407830831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9775427774267024d, y: 0.3430871343678017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5481444494930737d, y: 0.21280495428896073d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6424083836849286d, y: 0.5689752317733029d), new NpgsqlTypes.NpgsqlPoint(x: 0.384338990785544d, y: 0.42779719216390677d), new NpgsqlTypes.NpgsqlPoint(x: 0.0913990927298095d, y: 0.9112093427570083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6459784220435516d, y: 0.8579219982353005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9625735740731751d, y: 0.0636790224914705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466659279949605d, y: 0.19295549874669105d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4564268534348477d, y: 0.5665411909863282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345220181441144d, y: 0.36282598433941493d), new NpgsqlTypes.NpgsqlPoint(x: 0.16446961354406098d, y: 0.15388166774264223d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.412140108958036d, y: 0.30143328609395237d), new NpgsqlTypes.NpgsqlPoint(x: 0.608849497863858d, y: 0.39083039704116174d), new NpgsqlTypes.NpgsqlPoint(x: 0.27664256713991975d, y: 0.4149622682873748d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6557363814149035d, y: 0.5662234510605573d), new NpgsqlTypes.NpgsqlPoint(x: 0.28247256781409646d, y: 0.7167671047495751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686707404953175d, y: 0.12240431927579842d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5488919661978834d, y: 0.6335440722664647d), new NpgsqlTypes.NpgsqlPoint(x: 0.46060436167966334d, y: 0.9521476814835781d), new NpgsqlTypes.NpgsqlPoint(x: 0.3222169278401902d, y: 0.3466414964102771d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9725755297324274d, y: 0.22574775436664796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011909639512634d, y: 0.39405281996148456d), new NpgsqlTypes.NpgsqlPoint(x: 0.381166574049285d, y: 0.08483846460231004d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5446399362434641d, y: 0.23816165007716417d), new NpgsqlTypes.NpgsqlPoint(x: 0.45311743344325617d, y: 0.8573389909674691d), new NpgsqlTypes.NpgsqlPoint(x: 0.19031031853095515d, y: 0.5091689509310603d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.732149817521057d, y: 0.875390006551967d), new NpgsqlTypes.NpgsqlPoint(x: 0.05921927612544409d, y: 0.634141080225109d), new NpgsqlTypes.NpgsqlPoint(x: 0.0411006605683899d, y: 0.5762690075277299d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8237089336202557d, y: 0.44247564250592064d), new NpgsqlTypes.NpgsqlPoint(x: 0.12309705180828179d, y: 0.23756070071873325d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568757818145003d, y: 0.6277388590695773d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7649304594125249d, y: 0.4400580876219674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472137365321323d, y: 0.9352883753552633d), new NpgsqlTypes.NpgsqlPoint(x: 0.31125320607213347d, y: 0.8195834905127786d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3141088868836899d, y: 0.19627635531994359d), new NpgsqlTypes.NpgsqlPoint(x: 0.2778307932387347d, y: 0.025545275857464023d), new NpgsqlTypes.NpgsqlPoint(x: 0.39234741663640493d, y: 0.919170664334649d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4526124176193883d, y: 0.558166793185949d), new NpgsqlTypes.NpgsqlPoint(x: 0.00389225228276191d, y: 0.5535770216170636d), new NpgsqlTypes.NpgsqlPoint(x: 0.19577996388207053d, y: 0.5624579698742121d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7437555006854953d, y: 0.5735865139509305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078282515174736d, y: 0.4977825605154458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5510979930725448d, y: 0.9110829158823972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7051165841401791d, y: 0.7328762961083847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642201371363893d, y: 0.24098567010220717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059604078450254d, y: 0.23446186721049211d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8927437168267061d, y: 0.18415741377683748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688583681756026d, y: 0.6689665727672983d), new NpgsqlTypes.NpgsqlPoint(x: 0.0016951677070627946d, y: 0.6564625102832254d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8064603491304838d, y: 0.43761373248545776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7160868266612862d, y: 0.3004477890477816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629949708919777d, y: 0.4971918507853521d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2506935700792332d, y: 0.2024351919108287d), new NpgsqlTypes.NpgsqlPoint(x: 0.465819720933881d, y: 0.027152152924535655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9937337063478305d, y: 0.26170614440159956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5211897676192869d, y: 0.0592310789427718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5311145215586712d, y: 0.18594018259712497d), new NpgsqlTypes.NpgsqlPoint(x: 0.13908442019944134d, y: 0.7856701096441913d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5039072682877141d, y: 0.12770753113457634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389814628300618d, y: 0.011237026510160453d), new NpgsqlTypes.NpgsqlPoint(x: 0.5818481867824912d, y: 0.420288463233085d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24486932139291306d, y: 0.4040319578793058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101795910572563d, y: 0.8896069697639007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930485908680479d, y: 0.9624410535450292d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38580399586831726d, y: 0.7831165009210634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903538247924534d, y: 0.30191427003435145d), new NpgsqlTypes.NpgsqlPoint(x: 0.23296198386593348d, y: 0.35069843814228707d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14790887782087336d, y: 0.8831495856365925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9153304460568041d, y: 0.538519315255198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421546393327562d, y: 0.28548941233418423d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9523019646041108d, y: 0.19276821763859264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021212318120405d, y: 0.5783473582922155d), new NpgsqlTypes.NpgsqlPoint(x: 0.06340702619600969d, y: 0.19066784245251345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3907716742096171d, y: 0.09089291956562584d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150434481940757d, y: 0.5448559827302941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823365442640853d, y: 0.6036126135184303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8858754511017431d, y: 0.5355335105280226d), new NpgsqlTypes.NpgsqlPoint(x: 0.37411188001795037d, y: 0.4098529095705933d), new NpgsqlTypes.NpgsqlPoint(x: 0.024993453088141382d, y: 0.8577694261722236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9705261798203927d, y: 0.6749903673447587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929479390364786d, y: 0.0995926942312313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3062195263842604d, y: 0.6692670512834279d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4376539240588513d, y: 0.18520829304263653d), new NpgsqlTypes.NpgsqlPoint(x: 0.28364100559099814d, y: 0.2939710606201138d), new NpgsqlTypes.NpgsqlPoint(x: 0.03604108892013502d, y: 0.19385935816484934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15730919679339195d, y: 0.4254303890610479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6364838606916039d, y: 0.2790735790425578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7694907872790863d, y: 0.08396397561351432d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.999960374640402d, y: 0.7565670476936801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9221156051292759d, y: 0.5281798884459015d), new NpgsqlTypes.NpgsqlPoint(x: 0.9330089510746903d, y: 0.5862480379919135d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35488444972365984d, y: 0.8056112007499814d), new NpgsqlTypes.NpgsqlPoint(x: 0.15519357709471127d, y: 0.4580080328056446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7104044878346086d, y: 0.7872610917313019d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2973831326044032d, y: 0.0518504640817915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8188269978211749d, y: 0.9990141048814895d), new NpgsqlTypes.NpgsqlPoint(x: 0.4536071933525684d, y: 0.8619635694308213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7777496495852573d, y: 0.11700017432366538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435273913159006d, y: 0.7440511240210175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460213026714649d, y: 0.7537730493182859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9800294204873166d, y: 0.11582142446139032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5590149181047316d, y: 0.7899749680244872d), new NpgsqlTypes.NpgsqlPoint(x: 0.4779390500242199d, y: 0.5154715786805067d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5904301048357677d, y: 0.15018638367152093d), new NpgsqlTypes.NpgsqlPoint(x: 0.3422168978396348d, y: 0.1904875645796682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288923955339716d, y: 0.24562498513516084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6419210976214459d, y: 0.40375566520538286d), new NpgsqlTypes.NpgsqlPoint(x: 0.16491203118699393d, y: 0.9441256181657891d), new NpgsqlTypes.NpgsqlPoint(x: 0.292271406133371d, y: 0.21651499992201906d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8657907030154122d, y: 0.03960965260342686d), new NpgsqlTypes.NpgsqlPoint(x: 0.17257079335511682d, y: 0.684497130452105d), new NpgsqlTypes.NpgsqlPoint(x: 0.580379425315028d, y: 0.7458381457397982d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43675787997694615d, y: 0.24482941108382994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813285902203619d, y: 0.04095992661355874d), new NpgsqlTypes.NpgsqlPoint(x: 0.4472259407441346d, y: 0.35378233196704256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2576634742396151d, y: 0.06156429474986258d), new NpgsqlTypes.NpgsqlPoint(x: 0.464752503554285d, y: 0.29637712706021646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277647909918601d, y: 0.29114682203288733d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5832357033898024d, y: 0.003449440067130105d), new NpgsqlTypes.NpgsqlPoint(x: 0.05834680215306798d, y: 0.0344865633519037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587468386439328d, y: 0.42920113080639055d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8973831056319868d, y: 0.027815497345191287d), new NpgsqlTypes.NpgsqlPoint(x: 0.27373009015095007d, y: 0.7469226184861376d), new NpgsqlTypes.NpgsqlPoint(x: 0.3859511143176416d, y: 0.5772034394997188d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8432117821120894d, y: 0.5514539310329477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849232252230505d, y: 0.32940115031276174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7756236225105161d, y: 0.34810135576270484d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5556822017475047d, y: 0.6435251503177658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595943226296263d, y: 0.49600127213265666d), new NpgsqlTypes.NpgsqlPoint(x: 0.012054857602365576d, y: 0.5077835491909659d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5542805640402568d, y: 0.034298676943515294d), new NpgsqlTypes.NpgsqlPoint(x: 0.45948035661347497d, y: 0.6506689313160187d), new NpgsqlTypes.NpgsqlPoint(x: 0.12979569563929327d, y: 0.39306464308692957d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7260977938921445d, y: 0.5987627929517765d), new NpgsqlTypes.NpgsqlPoint(x: 0.6997939578048563d, y: 0.030945496276347573d), new NpgsqlTypes.NpgsqlPoint(x: 0.32938872928583085d, y: 0.0913366657245065d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7718892685096694d, y: 0.08680240984028187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245144927023586d, y: 0.47642938762372533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923920888495425d, y: 0.4453531175785981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5380061267457706d, y: 0.6604555775021118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6503969804380855d, y: 0.15073490683351798d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454171352573568d, y: 0.30615291396679445d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18725875857543972d, y: 0.5141535546246223d), new NpgsqlTypes.NpgsqlPoint(x: 0.24729315710481892d, y: 0.4572582988726146d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662340730215465d, y: 0.19360393332597337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06210543410848801d, y: 0.34231394150835637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7756024407290937d, y: 0.10333166509981773d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512536401507561d, y: 0.13795004443671122d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051568648673912d, y: 0.2335721256547243d), new NpgsqlTypes.NpgsqlPoint(x: 0.3043032598573623d, y: 0.17174357031488485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9476595324556254d, y: 0.09799924644110769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6863595887525491d, y: 0.9189915691942471d), new NpgsqlTypes.NpgsqlPoint(x: 0.4872538288848649d, y: 0.8216940453394479d), new NpgsqlTypes.NpgsqlPoint(x: 0.938712355665847d, y: 0.8758403002047764d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9289153818785361d, y: 0.025902152379115306d), new NpgsqlTypes.NpgsqlPoint(x: 0.1583224930767455d, y: 0.1520968506620871d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147956685217642d, y: 0.5123915404269885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.631693398564937d, y: 0.3628610833068696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7879377570419889d, y: 0.253199416441241d), new NpgsqlTypes.NpgsqlPoint(x: 0.5926865514319234d, y: 0.5092474290884962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08670146665195422d, y: 0.06636475992917523d), new NpgsqlTypes.NpgsqlPoint(x: 0.738542435085136d, y: 0.7934712443498126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020407792363963d, y: 0.1665834185262095d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.980901416508118d, y: 0.8985702461267766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532507225826718d, y: 0.38656677564264075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277696366121271d, y: 0.8266169536908254d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5704085318154967d, y: 0.11730409937850406d), new NpgsqlTypes.NpgsqlPoint(x: 0.21835256866061792d, y: 0.28119986521680274d), new NpgsqlTypes.NpgsqlPoint(x: 0.35899292431594976d, y: 0.9137768340514597d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9842178005918854d, y: 0.6430846532672705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5936985880964889d, y: 0.08313097379722856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082748885889066d, y: 0.5026638269352269d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.353080099287828d, y: 0.9228217705226778d), new NpgsqlTypes.NpgsqlPoint(x: 0.464847515877043d, y: 0.5232049899845489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575283041430772d, y: 0.4341897919590928d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2022463008552876d, y: 0.7517786629818674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373791968015924d, y: 0.9987815060361377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4670992349378692d, y: 0.6965943002992698d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34932277002171996d, y: 0.2312070037194297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8291500861266815d, y: 0.9053814323205921d), new NpgsqlTypes.NpgsqlPoint(x: 0.992918574034331d, y: 0.9114616740057921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28231263334341783d, y: 0.6682287669404416d), new NpgsqlTypes.NpgsqlPoint(x: 0.00510871851697281d, y: 0.626182071620744d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254651179378902d, y: 0.08894319560153552d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16013269077192183d, y: 0.17337862567440432d), new NpgsqlTypes.NpgsqlPoint(x: 0.6368550511342536d, y: 0.5845781695619897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417314505950211d, y: 0.9046112483884121d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15685677046748336d, y: 0.66432336558759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586385771642211d, y: 0.31185901741652255d), new NpgsqlTypes.NpgsqlPoint(x: 0.09406091075391043d, y: 0.6209350589318309d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33608590082470335d, y: 0.06536501252121008d), new NpgsqlTypes.NpgsqlPoint(x: 0.15324735648125887d, y: 0.515452493763769d), new NpgsqlTypes.NpgsqlPoint(x: 0.1387306901110471d, y: 0.4605661356856676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.801060356434573d, y: 0.8063802973292354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5224981412001611d, y: 0.44913547611651605d), new NpgsqlTypes.NpgsqlPoint(x: 0.04995913084818515d, y: 0.7336543472834879d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4510421727194779d, y: 0.2814821525313964d), new NpgsqlTypes.NpgsqlPoint(x: 0.02172738632319471d, y: 0.36063881256435726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5606423776220204d, y: 0.5733404387856483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4455632888418595d, y: 0.8759976183108505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2619388343058371d, y: 0.5675113982347308d), new NpgsqlTypes.NpgsqlPoint(x: 0.43771781348705385d, y: 0.4815388728051254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7711214189051947d, y: 0.25689727182144195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439919683141954d, y: 0.21179542791270634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025093371455937d, y: 0.41636534904108136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5558744313779272d, y: 0.7570023610798908d), new NpgsqlTypes.NpgsqlPoint(x: 0.35842127241066446d, y: 0.3787376877192875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9548981266726984d, y: 0.5282189820160886d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1741386661333899d, y: 0.5390184286572746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171625935243336d, y: 0.7014399969839488d), new NpgsqlTypes.NpgsqlPoint(x: 0.16972861623004964d, y: 0.18644428323563744d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7291809871960196d, y: 0.3123395198162716d), new NpgsqlTypes.NpgsqlPoint(x: 0.159329748614783d, y: 0.5075350105383871d), new NpgsqlTypes.NpgsqlPoint(x: 0.2890803826605264d, y: 0.9359915430342878d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4374210036938345d, y: 0.7494706266990957d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093854129896637d, y: 0.8880383628484512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8995032381804895d, y: 0.19479904093591371d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6953728826766219d, y: 0.034050180897642224d), new NpgsqlTypes.NpgsqlPoint(x: 0.34527020604805136d, y: 0.27127088530113164d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596880497806019d, y: 0.9980603835473855d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1892137174867432d, y: 0.579617698291413d), new NpgsqlTypes.NpgsqlPoint(x: 0.679242404785206d, y: 0.9166414831848313d), new NpgsqlTypes.NpgsqlPoint(x: 0.006471652271565098d, y: 0.11316249078848029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4724365447823732d, y: 0.06695119455778187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5735652090150648d, y: 0.15514687457382315d), new NpgsqlTypes.NpgsqlPoint(x: 0.4365215538518358d, y: 0.6613512749978294d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1082084352918935d, y: 0.7180332331517766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517067482910929d, y: 0.08260421524626504d), new NpgsqlTypes.NpgsqlPoint(x: 0.29630111988678876d, y: 0.5606096361150523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6600357995070568d, y: 0.2957005673559603d), new NpgsqlTypes.NpgsqlPoint(x: 0.06627109658293207d, y: 0.252383286223292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888105248468422d, y: 0.6039877181782307d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48468622178613463d, y: 0.04850614236037287d), new NpgsqlTypes.NpgsqlPoint(x: 0.25107136772346594d, y: 0.030828545568008847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867880372071826d, y: 0.20345902925092307d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4997761379521034d, y: 0.06324195175403025d), new NpgsqlTypes.NpgsqlPoint(x: 0.44051191535646295d, y: 0.2124805439772044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7697265936761861d, y: 0.8584216773876748d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9767367412812169d, y: 0.3792578895968106d), new NpgsqlTypes.NpgsqlPoint(x: 0.605392528315246d, y: 0.6073638732840293d), new NpgsqlTypes.NpgsqlPoint(x: 0.232644677553957d, y: 0.5429726105012394d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2108276640123643d, y: 0.8585862187069909d), new NpgsqlTypes.NpgsqlPoint(x: 0.00798608936549594d, y: 0.22465415857902615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3104887033986631d, y: 0.6401616228339959d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08198805507128237d, y: 0.7408236390761127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9075113207835384d, y: 0.8095743948538436d), new NpgsqlTypes.NpgsqlPoint(x: 0.628309718722707d, y: 0.9151861480235126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030381734835040253d, y: 0.5509835491944446d), new NpgsqlTypes.NpgsqlPoint(x: 0.0902895185837661d, y: 0.572308191912213d), new NpgsqlTypes.NpgsqlPoint(x: 0.06773671412492555d, y: 0.5884014339045812d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9948378614309193d, y: 0.8822498764717449d), new NpgsqlTypes.NpgsqlPoint(x: 0.2180304189217248d, y: 0.19319731490152214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973734971511633d, y: 0.6449012645445862d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0575455047278185d, y: 0.5765201728947881d), new NpgsqlTypes.NpgsqlPoint(x: 0.3755549981113038d, y: 0.37501505676637104d), new NpgsqlTypes.NpgsqlPoint(x: 0.26225319541981873d, y: 0.22562238460713202d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1502239428725035d, y: 0.8657385044719049d), new NpgsqlTypes.NpgsqlPoint(x: 0.4111506833539422d, y: 0.5425242992605581d), new NpgsqlTypes.NpgsqlPoint(x: 0.595558653486566d, y: 0.057698784876361486d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40127429471383125d, y: 0.13133978540985725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9124842952800896d, y: 0.5262988675819343d), new NpgsqlTypes.NpgsqlPoint(x: 0.7403277423828851d, y: 0.2524063307837452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6931434807146978d, y: 0.2810837753796478d), new NpgsqlTypes.NpgsqlPoint(x: 0.31315081789168697d, y: 0.3517144500646332d), new NpgsqlTypes.NpgsqlPoint(x: 0.36838641816906703d, y: 0.5160887112274326d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29983735591102456d, y: 0.7784467645236144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7492973521075901d, y: 0.7465590122954942d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267998248694121d, y: 0.6893657851250037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24359185624801072d, y: 0.45999672780958145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6075606506425728d, y: 0.6495704145180964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6591583466808677d, y: 0.7252519726082781d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3984197477618058d, y: 0.8424375306547964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8744278053824237d, y: 0.5161586830318301d), new NpgsqlTypes.NpgsqlPoint(x: 0.46838751517448907d, y: 0.07281438363230375d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8134890860470281d, y: 0.06320555877190082d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085372612791065d, y: 0.9814078467989101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638118162360891d, y: 0.20336600850798392d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7064443749533788d, y: 0.7049573598183235d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641461563404168d, y: 0.0002148355534652424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5748027745898362d, y: 0.3765379700458463d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770287549776215d, y: 0.37833892480546527d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726636594336832d, y: 0.33396218502383623d), new NpgsqlTypes.NpgsqlPoint(x: 0.4558981366218098d, y: 0.23439126768150487d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7291930370646127d, y: 0.9116614656072926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7736125919507776d, y: 0.5029661153034064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172250826854226d, y: 0.9461211393779316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38025116890787247d, y: 0.8853580161282606d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335847107067704d, y: 0.507400169490475d), new NpgsqlTypes.NpgsqlPoint(x: 0.20296402008128522d, y: 0.01684831400604192d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3276882643997534d, y: 0.358247296020186d), new NpgsqlTypes.NpgsqlPoint(x: 0.4933670569114291d, y: 0.12993454664160342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054199086302835d, y: 0.649176521103107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48405540147885984d, y: 0.8131975509059527d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860904047316514d, y: 0.9812426554274599d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250772924441053d, y: 0.20756292009432942d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007949607905943123d, y: 0.39912447373423465d), new NpgsqlTypes.NpgsqlPoint(x: 0.21350031170371397d, y: 0.786037482022501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5513178994739619d, y: 0.4006226029071056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08713142768059234d, y: 0.3693989069046151d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493521942062153d, y: 0.0997668866775483d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105319957155899d, y: 0.6262524008287443d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.929475461168508d, y: 0.40481783991406184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606574414824857d, y: 0.16006494622138512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651364332578648d, y: 0.3137432305034463d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9783282759088903d, y: 0.6457880510561865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718158038921209d, y: 0.8635114464435706d), new NpgsqlTypes.NpgsqlPoint(x: 0.16561746073769468d, y: 0.04976575778122472d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7711984150367125d, y: 0.312146105299242d), new NpgsqlTypes.NpgsqlPoint(x: 0.988600016803621d, y: 0.2197646329030063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749611905338076d, y: 0.1303608007739725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8751496174754559d, y: 0.602202579450145d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788951596021453d, y: 0.5827746445870107d), new NpgsqlTypes.NpgsqlPoint(x: 0.975155809367217d, y: 0.48274654877896594d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00934574806570676d, y: 0.9226897483737786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5819075846158015d, y: 0.9712025500884587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089703978529779d, y: 0.9283720679906037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906603405096465d, y: 0.7871875314964025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6868543344223618d, y: 0.7979994595227118d), new NpgsqlTypes.NpgsqlPoint(x: 0.32969820850970255d, y: 0.7899203730568505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21834642851657382d, y: 0.21840757520409038d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754449890682292d, y: 0.6386271265602523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9602440915368589d, y: 0.17001611124429894d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22997111633474132d, y: 0.1414551046011332d), new NpgsqlTypes.NpgsqlPoint(x: 0.2612921737131647d, y: 0.30487030321096575d), new NpgsqlTypes.NpgsqlPoint(x: 0.4338985333127321d, y: 0.39539805389226446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45247895276446026d, y: 0.3757367926243639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9399608662905016d, y: 0.06302541402720585d), new NpgsqlTypes.NpgsqlPoint(x: 0.29510417526297406d, y: 0.34406959076314825d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07549308032453406d, y: 0.5248710828593446d), new NpgsqlTypes.NpgsqlPoint(x: 0.23666404663230434d, y: 0.2336237223479375d), new NpgsqlTypes.NpgsqlPoint(x: 0.046699642917691464d, y: 0.38716434602728433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8873102295459333d, y: 0.07727963743993005d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235773898843991d, y: 0.917362847088346d), new NpgsqlTypes.NpgsqlPoint(x: 0.879516449627557d, y: 0.5611782193212026d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6293420129616285d, y: 0.7825384317371237d), new NpgsqlTypes.NpgsqlPoint(x: 0.10933230364917845d, y: 0.5036965330945148d), new NpgsqlTypes.NpgsqlPoint(x: 0.35483996269037654d, y: 0.8552785492719832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.788686074349269d, y: 0.943188027954319d), new NpgsqlTypes.NpgsqlPoint(x: 0.004647197514139667d, y: 0.7508199417934347d), new NpgsqlTypes.NpgsqlPoint(x: 0.24224836580323783d, y: 0.5021090813432947d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3351027115032338d, y: 0.6343885612599226d), new NpgsqlTypes.NpgsqlPoint(x: 0.0650239544581035d, y: 0.8629758412908028d), new NpgsqlTypes.NpgsqlPoint(x: 0.01264973945332759d, y: 0.7048765840052901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38779636387710426d, y: 0.6649842949448003d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836255166511441d, y: 0.795958758152478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567756826156712d, y: 0.46139858104034603d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40415906865380735d, y: 0.5813159186709179d), new NpgsqlTypes.NpgsqlPoint(x: 0.43864296386338897d, y: 0.6047575243699083d), new NpgsqlTypes.NpgsqlPoint(x: 0.90137339590903d, y: 0.6036874721186518d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2720358517820747d, y: 0.5796725274686967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249373485970622d, y: 0.3371374176359623d), new NpgsqlTypes.NpgsqlPoint(x: 0.669735985888899d, y: 0.7466533252942893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7422311434693205d, y: 0.07370133229636022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422313607623397d, y: 0.5818367560313255d), new NpgsqlTypes.NpgsqlPoint(x: 0.28127204407366957d, y: 0.7382268284279107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05134514613927221d, y: 0.6056379398237954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5909082159861837d, y: 0.8749727991770304d), new NpgsqlTypes.NpgsqlPoint(x: 0.839425479746178d, y: 0.7016877048597099d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39108483303099817d, y: 0.20447120237336547d), new NpgsqlTypes.NpgsqlPoint(x: 0.37083234604591986d, y: 0.2792135549201802d), new NpgsqlTypes.NpgsqlPoint(x: 0.7052518102353476d, y: 0.42147952788460274d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3412351338502786d, y: 0.034065591079606605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158945802362884d, y: 0.27679922687094805d), new NpgsqlTypes.NpgsqlPoint(x: 0.9252574678180697d, y: 0.20852290592463896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4910805205160692d, y: 0.6840317367673404d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940794061772909d, y: 0.4592060188737038d), new NpgsqlTypes.NpgsqlPoint(x: 0.3841340871788711d, y: 0.0862540738179689d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050525154800559d, y: 0.6364961955406008d), new NpgsqlTypes.NpgsqlPoint(x: 0.09013975098543625d, y: 0.13123202359538522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770343107180357d, y: 0.43593900795302176d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9274238687622712d, y: 0.8267280138728793d), new NpgsqlTypes.NpgsqlPoint(x: 0.14875690745635506d, y: 0.2998271257273204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8779815907965691d, y: 0.0649187515924009d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10100761287228788d, y: 0.1815546286011135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8870895443418416d, y: 0.7039362389869044d), new NpgsqlTypes.NpgsqlPoint(x: 0.04076313630383699d, y: 0.6693612816528735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9951685682579506d, y: 0.37467396995516056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991187454053053d, y: 0.515972738200626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8666281107068438d, y: 0.3005617792374936d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.738840446570493d, y: 0.40294307303996824d), new NpgsqlTypes.NpgsqlPoint(x: 0.11291755743385112d, y: 0.3480738084341528d), new NpgsqlTypes.NpgsqlPoint(x: 0.938674216533834d, y: 0.34442904489912063d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13923029458085423d, y: 0.6770193290468507d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203614196571961d, y: 0.8403648302127653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926296666274565d, y: 0.6046104403701235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641917023742318d, y: 0.2928066680976277d), new NpgsqlTypes.NpgsqlPoint(x: 0.01204228094801596d, y: 0.5695264726593149d), new NpgsqlTypes.NpgsqlPoint(x: 0.23281499469121059d, y: 0.8961043180925913d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3782455982638848d, y: 0.07195140571433356d), new NpgsqlTypes.NpgsqlPoint(x: 0.29424152531824277d, y: 0.8715012986992595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844184428767803d, y: 0.012346034882331769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9483835020955014d, y: 0.11818941341278721d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442424675410739d, y: 0.8923111224576235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4463469473020022d, y: 0.4622204737042639d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7065163573298165d, y: 0.2606463824169939d), new NpgsqlTypes.NpgsqlPoint(x: 0.3713177259530993d, y: 0.3543330279209649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324222273896551d, y: 0.16170604511066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22012406033132426d, y: 0.10196654451658693d), new NpgsqlTypes.NpgsqlPoint(x: 0.6861446827495701d, y: 0.6978912933588121d), new NpgsqlTypes.NpgsqlPoint(x: 0.851680407973289d, y: 0.6178888904941482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042242465450456956d, y: 0.9501175574251359d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008167997771074d, y: 0.32485408195339116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5102477375977633d, y: 0.672266013948116d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1763900667438122d, y: 0.7956160724882447d), new NpgsqlTypes.NpgsqlPoint(x: 0.534331769953764d, y: 0.20017432135503532d), new NpgsqlTypes.NpgsqlPoint(x: 0.22091146003794027d, y: 0.7537219948533253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9940167144504587d, y: 0.2416942799413342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680103748737984d, y: 0.9181117542583481d), new NpgsqlTypes.NpgsqlPoint(x: 0.38439960606544377d, y: 0.5773769342875821d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9028292321701722d, y: 0.03737355277782728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2831626334323024d, y: 0.5176968499096557d), new NpgsqlTypes.NpgsqlPoint(x: 0.934581645939367d, y: 0.5850724977506293d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 35;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 20;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 124;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 97, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 47, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

