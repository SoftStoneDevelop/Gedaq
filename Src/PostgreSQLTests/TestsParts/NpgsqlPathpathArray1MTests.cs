

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
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9716908015395638d, y: 0.7734215496983218d), new NpgsqlTypes.NpgsqlPoint(x: 0.17180978521268375d, y: 0.8513563369917225d), new NpgsqlTypes.NpgsqlPoint(x: 0.1748524588498096d, y: 0.09154502484368643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4655904895795201d, y: 0.6869275326590765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907608147019499d, y: 0.712671793456802d), new NpgsqlTypes.NpgsqlPoint(x: 0.45068412056956464d, y: 0.17170098354301389d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9404528862335819d, y: 0.8764437768421105d), new NpgsqlTypes.NpgsqlPoint(x: 0.2129537651900557d, y: 0.22064608764146187d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645475268579132d, y: 0.800078958009927d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049947817719454224d, y: 0.924918255644263d), new NpgsqlTypes.NpgsqlPoint(x: 0.11406587064845908d, y: 0.44271461588709604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332268560915769d, y: 0.7821617972470856d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02208398405852119d, y: 0.6909134234999467d), new NpgsqlTypes.NpgsqlPoint(x: 0.35654843360401867d, y: 0.9065956778107997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985247331982476d, y: 0.5175066844715054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6754240173232405d, y: 0.23093894149022065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6839609663150344d, y: 0.17176529987296507d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554665743520947d, y: 0.847911400522692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7635972719687353d, y: 0.8457726690890846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933537374793885d, y: 0.8747536627663989d), new NpgsqlTypes.NpgsqlPoint(x: 0.035945886377019454d, y: 0.9291513030151514d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9698281306869045d, y: 0.7833458331930447d), new NpgsqlTypes.NpgsqlPoint(x: 0.07731945619439351d, y: 0.7912162960800693d), new NpgsqlTypes.NpgsqlPoint(x: 0.4095533305238972d, y: 0.17029610397906458d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24607104572843352d, y: 0.49736626339396106d), new NpgsqlTypes.NpgsqlPoint(x: 0.02905610045676088d, y: 0.8615707263753759d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658771438787888d, y: 0.850829241768129d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7185570905339922d, y: 0.5912389541270301d), new NpgsqlTypes.NpgsqlPoint(x: 0.3459407031674596d, y: 0.07772100891068501d), new NpgsqlTypes.NpgsqlPoint(x: 0.15652435374949503d, y: 0.6378630132225767d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8510907678184716d, y: 0.4997002522666767d), new NpgsqlTypes.NpgsqlPoint(x: 0.43463973034424563d, y: 0.058742213225154605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8025107702244904d, y: 0.4154615108987184d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8678494940170938d, y: 0.11655815236564293d), new NpgsqlTypes.NpgsqlPoint(x: 0.627631844802111d, y: 0.25650829879384496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084064558518208d, y: 0.4322488656310084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21921101038027568d, y: 0.8410845452987917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671378998307082d, y: 0.15037550440634617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8375875922347454d, y: 0.790175777998656d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17418683334158436d, y: 0.2919732484831422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246039642577708d, y: 0.5627504845555324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738477225446942d, y: 0.8933663520910167d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6997449472618088d, y: 0.9089569614363149d), new NpgsqlTypes.NpgsqlPoint(x: 0.6877664981478803d, y: 0.3468927795568758d), new NpgsqlTypes.NpgsqlPoint(x: 0.0771191285627727d, y: 0.10471561525619832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6367646918480018d, y: 0.9528019003482808d), new NpgsqlTypes.NpgsqlPoint(x: 0.14406886415583808d, y: 0.8060515349541066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808309068321459d, y: 0.9968896720499998d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0252868070582577d, y: 0.3392368149282966d), new NpgsqlTypes.NpgsqlPoint(x: 0.34825719234592023d, y: 0.7444714419930598d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520116233168898d, y: 0.47596544598507884d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13205232644409115d, y: 0.3505018513846737d), new NpgsqlTypes.NpgsqlPoint(x: 0.3036988420487723d, y: 0.9361921486715339d), new NpgsqlTypes.NpgsqlPoint(x: 0.36760317656225006d, y: 0.6636489639018187d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9365070549976822d, y: 0.7066334444011717d), new NpgsqlTypes.NpgsqlPoint(x: 0.11535525436970095d, y: 0.7073360811030992d), new NpgsqlTypes.NpgsqlPoint(x: 0.711143271070224d, y: 0.5751327452282751d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9145679347352627d, y: 0.7576216990063257d), new NpgsqlTypes.NpgsqlPoint(x: 0.01479438159019375d, y: 0.6297042372594455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349877731983318d, y: 0.7656650600092691d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43164018893373d, y: 0.2173561924121502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433927163945372d, y: 0.843166722559088d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420235691373195d, y: 0.14936165275423485d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19795615007950595d, y: 0.040865815135755046d), new NpgsqlTypes.NpgsqlPoint(x: 0.2279121366302279d, y: 0.7028226244151495d), new NpgsqlTypes.NpgsqlPoint(x: 0.09793493824497213d, y: 0.40263086860636355d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0361106007710148d, y: 0.4853930396835703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463188288030169d, y: 0.0024358072107925066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2735270000860185d, y: 0.8930065670036972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38784521130240723d, y: 0.05603532900916686d), new NpgsqlTypes.NpgsqlPoint(x: 0.45657948572276097d, y: 0.9548127266819523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246201158809374d, y: 0.27266826224408736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06543982683812433d, y: 0.8363893615581427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5211234925758327d, y: 0.006540772508218717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6688743327400676d, y: 0.044679485333554925d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21370830873358138d, y: 0.7515879968729973d), new NpgsqlTypes.NpgsqlPoint(x: 0.8767601869924955d, y: 0.6151403303547439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5905352697812595d, y: 0.7655070289759536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6187115792693094d, y: 0.013468379943818776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6958328578796196d, y: 0.1821022095443552d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328256591540901d, y: 0.16532383313931154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04203089288444928d, y: 0.7893639758255476d), new NpgsqlTypes.NpgsqlPoint(x: 0.13081914354520208d, y: 0.6393646139408912d), new NpgsqlTypes.NpgsqlPoint(x: 0.36577258561985004d, y: 0.41787399828083205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5339922708790124d, y: 0.2668964161411833d), new NpgsqlTypes.NpgsqlPoint(x: 0.06027061391443245d, y: 0.4537354441765207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538825554332511d, y: 0.3776741665913814d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8912597864178946d, y: 0.02574872393955352d), new NpgsqlTypes.NpgsqlPoint(x: 0.07632963055428732d, y: 0.9253788702661639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139038236243846d, y: 0.9150512809583313d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09337703374785733d, y: 0.09246487576257889d), new NpgsqlTypes.NpgsqlPoint(x: 0.47540300117916323d, y: 0.5268701213855741d), new NpgsqlTypes.NpgsqlPoint(x: 0.16361371765362442d, y: 0.10882960443049683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21982608439458473d, y: 0.28996092549251307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4829550156922914d, y: 0.052496574007236174d), new NpgsqlTypes.NpgsqlPoint(x: 0.011203404717594956d, y: 0.3070799457483798d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28222949447714585d, y: 0.4629591039994291d), new NpgsqlTypes.NpgsqlPoint(x: 0.22826967059491787d, y: 0.7103126220781649d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759759663833246d, y: 0.6561036343301762d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49363264834643106d, y: 0.08649581832270747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623016424825233d, y: 0.09207429676670176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8215094512817167d, y: 0.37505863813558604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7956401468115852d, y: 0.20832490807180293d), new NpgsqlTypes.NpgsqlPoint(x: 0.22840332914269512d, y: 0.3553222608663894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078908905393754d, y: 0.4752247031244037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27936830834247073d, y: 0.9057123222393018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8594475747010786d, y: 0.7576612882364088d), new NpgsqlTypes.NpgsqlPoint(x: 0.379131603440934d, y: 0.5871092266767666d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6301030915319814d, y: 0.820240549917599d), new NpgsqlTypes.NpgsqlPoint(x: 0.3515339216214114d, y: 0.637816136432284d), new NpgsqlTypes.NpgsqlPoint(x: 0.18773321733600212d, y: 0.6950360497293071d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5282161737596912d, y: 0.09080156510870141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203440067843722d, y: 0.7431481876358905d), new NpgsqlTypes.NpgsqlPoint(x: 0.48081384620443124d, y: 0.4027239976994259d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1851327195594219d, y: 0.5535969179254218d), new NpgsqlTypes.NpgsqlPoint(x: 0.2352999426034108d, y: 0.7392174766080323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7505272411062138d, y: 0.9833113696374867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2531766717514541d, y: 0.8705338499839675d), new NpgsqlTypes.NpgsqlPoint(x: 0.39008704991389664d, y: 0.8969922048770451d), new NpgsqlTypes.NpgsqlPoint(x: 0.9582608943261951d, y: 0.79191231644756d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9204175294878296d, y: 0.06193361794977126d), new NpgsqlTypes.NpgsqlPoint(x: 0.2836411724400464d, y: 0.4619390299268863d), new NpgsqlTypes.NpgsqlPoint(x: 0.933876300657789d, y: 0.004239720015939752d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017529399970214854d, y: 0.8096448569958743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667351676721965d, y: 0.6281083482802304d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258379621773148d, y: 0.8035536165747069d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07381849309589661d, y: 0.636495238205823d), new NpgsqlTypes.NpgsqlPoint(x: 0.3252276791257158d, y: 0.5779852990998587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393845756302564d, y: 0.738776089226819d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3288643080851652d, y: 0.7459843280254406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214824951631878d, y: 0.4929677017464532d), new NpgsqlTypes.NpgsqlPoint(x: 0.1460289687219658d, y: 0.6816342656846877d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.889869618014504d, y: 0.7233482980153826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117239985660548d, y: 0.17438125185910103d), new NpgsqlTypes.NpgsqlPoint(x: 0.4283658397602217d, y: 0.8725291975306191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7308220487868555d, y: 0.48667911686672016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8338938892617913d, y: 0.7696046969424492d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966680002300086d, y: 0.7690701374256627d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2568346617933579d, y: 0.37274497858061073d), new NpgsqlTypes.NpgsqlPoint(x: 0.1911648241257824d, y: 0.5374356542948697d), new NpgsqlTypes.NpgsqlPoint(x: 0.31443700819108467d, y: 0.6137554353250556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48246488410324984d, y: 0.7856334095746683d), new NpgsqlTypes.NpgsqlPoint(x: 0.005500062906411807d, y: 0.6847945590879703d), new NpgsqlTypes.NpgsqlPoint(x: 0.74465507847203d, y: 0.8766808297903925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19570765299982174d, y: 0.7807938661319207d), new NpgsqlTypes.NpgsqlPoint(x: 0.4104188061992242d, y: 0.881651160418716d), new NpgsqlTypes.NpgsqlPoint(x: 0.47916068215788565d, y: 0.5726623845183922d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046944586147662504d, y: 0.12111936795667422d), new NpgsqlTypes.NpgsqlPoint(x: 0.4207339326822611d, y: 0.5479091395193338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8100151651329813d, y: 0.6093027518208219d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8824916132789414d, y: 0.36016589327077786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554468493286426d, y: 0.6621428384879166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370808141025809d, y: 0.5599561931224989d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2977973051684971d, y: 0.5178379451438684d), new NpgsqlTypes.NpgsqlPoint(x: 0.0779495388258572d, y: 0.6537111467967193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582766233404519d, y: 0.6405236446091698d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7520749770323224d, y: 0.42422896130696264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5504939885043646d, y: 0.5464820451306104d), new NpgsqlTypes.NpgsqlPoint(x: 0.49364760255768547d, y: 0.008831941512129293d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7251633145619445d, y: 0.5867970442340964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805673844087247d, y: 0.5747992928529353d), new NpgsqlTypes.NpgsqlPoint(x: 0.738181867142534d, y: 0.8223175959264868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4014894706430462d, y: 0.6120086466317135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556056131950191d, y: 0.8173980107020788d), new NpgsqlTypes.NpgsqlPoint(x: 0.2602730501157472d, y: 0.06731628464893047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04196915977813698d, y: 0.470277060398272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5695965684649859d, y: 0.9442720778750466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682311633483765d, y: 0.9127431694090323d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25698109406251723d, y: 0.6838957789964786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8686165781385898d, y: 0.6242911963997635d), new NpgsqlTypes.NpgsqlPoint(x: 0.27924996742621955d, y: 0.5081642230215565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33917002909836647d, y: 0.22921683107085267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6187355385161136d, y: 0.3301645767022452d), new NpgsqlTypes.NpgsqlPoint(x: 0.31895794754305296d, y: 0.41462748300514607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9052878960904844d, y: 0.020077557229340015d), new NpgsqlTypes.NpgsqlPoint(x: 0.2864193956218708d, y: 0.08664734007876662d), new NpgsqlTypes.NpgsqlPoint(x: 0.6606209842643275d, y: 0.21664555020872267d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16345359373299728d, y: 0.9626572861234355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931534237299146d, y: 0.9587083623029716d), new NpgsqlTypes.NpgsqlPoint(x: 0.07658053788242403d, y: 0.7901985712554372d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2214248150872905d, y: 0.16389584035599258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866786243642809d, y: 0.6101047092201447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9976407873276879d, y: 0.9472068130498791d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26837110737544745d, y: 0.0779410204276394d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110786708670516d, y: 0.5496518183618564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982275539007688d, y: 0.8606763130780967d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8995516035051031d, y: 0.8815673952813098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4910441604210849d, y: 0.6902713178969371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039022305456094d, y: 0.7990162700948009d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29728667134423337d, y: 0.48408032720870253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5847482730834344d, y: 0.5771145453790244d), new NpgsqlTypes.NpgsqlPoint(x: 0.005523448132096931d, y: 0.5548139908780289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9098662023601334d, y: 0.1793289553564802d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990840567854873d, y: 0.9172219976432091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906268020418753d, y: 0.11246928216287266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34369633471624395d, y: 0.1044154188261478d), new NpgsqlTypes.NpgsqlPoint(x: 0.914144170493122d, y: 0.3827906498345093d), new NpgsqlTypes.NpgsqlPoint(x: 0.10567502656918526d, y: 0.0538782867442571d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9634272734538987d, y: 0.6660653961781675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8657096130276839d, y: 0.35655717773551887d), new NpgsqlTypes.NpgsqlPoint(x: 0.991238660451286d, y: 0.23392199676148384d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08898830674178637d, y: 0.14684757890834665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5138449565336088d, y: 0.13159163238835458d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020072381947804d, y: 0.7502976545192885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7369713854775218d, y: 0.8128148760444198d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708218914067764d, y: 0.22754142367700414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236333559468743d, y: 0.9857523630420534d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45469785823353537d, y: 0.16694358425749167d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381414137047986d, y: 0.44755528798322597d), new NpgsqlTypes.NpgsqlPoint(x: 0.11280908001010526d, y: 0.2760981303793264d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8391486659712736d, y: 0.9251597541615336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673653675709588d, y: 0.06841928629869443d), new NpgsqlTypes.NpgsqlPoint(x: 0.1601185396351894d, y: 0.05943365860188177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4902260576915807d, y: 0.2446773849053705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5412319160827851d, y: 0.08719263494118568d), new NpgsqlTypes.NpgsqlPoint(x: 0.4787782645145331d, y: 0.5396918637404055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9845002370589188d, y: 0.07634668192180383d), new NpgsqlTypes.NpgsqlPoint(x: 0.1553900600913215d, y: 0.9768972420351157d), new NpgsqlTypes.NpgsqlPoint(x: 0.18574300804299937d, y: 0.18559577738404265d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7744746518253006d, y: 0.904556537030967d), new NpgsqlTypes.NpgsqlPoint(x: 0.4021103713114974d, y: 0.5515096977262379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211705922098227d, y: 0.9260861722438937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7834323892104865d, y: 0.06551531702634106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6556774523260732d, y: 0.31678192095942603d), new NpgsqlTypes.NpgsqlPoint(x: 0.33445196849380465d, y: 0.6560198195788948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5261488987959078d, y: 0.561620907247255d), new NpgsqlTypes.NpgsqlPoint(x: 0.20584106300852467d, y: 0.39722257381270243d), new NpgsqlTypes.NpgsqlPoint(x: 0.35236847758820267d, y: 0.41970140189106486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4042080261304195d, y: 0.8670683955909059d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357309392962128d, y: 0.3452867640898454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9764675384301779d, y: 0.6552588128853049d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45073338570560706d, y: 0.10152085210519146d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653844592532276d, y: 0.6519209010603124d), new NpgsqlTypes.NpgsqlPoint(x: 0.9352103644371829d, y: 0.7124415408765538d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4673734104896301d, y: 0.09235244944568155d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621383465037109d, y: 0.22979377324484218d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013461747017199377d, y: 0.772598396541421d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21449745582982171d, y: 0.14608299202208475d), new NpgsqlTypes.NpgsqlPoint(x: 0.2970038874092409d, y: 0.22788098057166517d), new NpgsqlTypes.NpgsqlPoint(x: 0.025372454883497153d, y: 0.10922010971200535d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4061716777920328d, y: 0.15375016154516719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345245513579577d, y: 0.4812464044139708d), new NpgsqlTypes.NpgsqlPoint(x: 0.17990465139715672d, y: 0.2306949083587796d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05032241737208576d, y: 0.9385962696920392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233363150798434d, y: 0.220611177847982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936351897818829d, y: 0.9411929305440181d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2969171973268533d, y: 0.5548332273707768d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088489075284213d, y: 0.8067810158939103d), new NpgsqlTypes.NpgsqlPoint(x: 0.02601590811502763d, y: 0.7282678596178526d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043701594732970195d, y: 0.9495365727461769d), new NpgsqlTypes.NpgsqlPoint(x: 0.36976957590643167d, y: 0.7196884606713522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074264606281312d, y: 0.7856636359400284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.075542022883896d, y: 0.5754020196758312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310918303309783d, y: 0.9634005977262375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407615427180452d, y: 0.4892099894421196d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8438177143572929d, y: 0.1704310721827741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876181270717988d, y: 0.8288624425929012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176295300276508d, y: 0.12051148328658912d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5969076048920994d, y: 0.6829982057570146d), new NpgsqlTypes.NpgsqlPoint(x: 0.21431854775860282d, y: 0.1766017699907263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8984344541939847d, y: 0.6052496482629396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9267502321209886d, y: 0.349366313832123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9659535126326293d, y: 0.4073364010946863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4570417439900676d, y: 0.388986516955518d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3338519037245393d, y: 0.8320419423462604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925673202812871d, y: 0.5362345580101772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8153740778235032d, y: 0.21833204085992863d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9493594215792078d, y: 0.4293358468824212d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931384074275762d, y: 0.036613111421303746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036875694520319d, y: 0.23800031678553402d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9200992356585467d, y: 0.33958303318613237d), new NpgsqlTypes.NpgsqlPoint(x: 0.46876646254313403d, y: 0.9496766495989148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886298428878499d, y: 0.2072682586953276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14463169217116978d, y: 0.22544510891919511d), new NpgsqlTypes.NpgsqlPoint(x: 0.27701878710910477d, y: 0.04730437975415358d), new NpgsqlTypes.NpgsqlPoint(x: 0.09740420497756475d, y: 0.6333444163821567d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22734041656429704d, y: 0.894179111339154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449171584485097d, y: 0.5660152017056582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9011412400978371d, y: 0.23837575294326108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1941880108347268d, y: 0.26156224561518504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836237080628673d, y: 0.34107925155697805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3063524268235597d, y: 0.7336957471358028d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9052717031308767d, y: 0.08068113297843926d), new NpgsqlTypes.NpgsqlPoint(x: 0.16170879397410776d, y: 0.6088070275648195d), new NpgsqlTypes.NpgsqlPoint(x: 0.21301675067635295d, y: 0.722853077318743d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7014579770172004d, y: 0.7311273001439046d), new NpgsqlTypes.NpgsqlPoint(x: 0.24746261986979d, y: 0.03230838798190627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5146103221687636d, y: 0.046215481222607324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7707500315856433d, y: 0.5286751597962965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223591773769171d, y: 0.4705667525273961d), new NpgsqlTypes.NpgsqlPoint(x: 0.2118017523133634d, y: 0.3867653176109115d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9379329412596483d, y: 0.1374513761542021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323783271594785d, y: 0.6396410114422894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319644228607929d, y: 0.8314340373115122d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5472376933658433d, y: 0.5363783374169989d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041590503101127d, y: 0.913428590608868d), new NpgsqlTypes.NpgsqlPoint(x: 0.43707401182680294d, y: 0.63417128753586d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03799675712130257d, y: 0.7845220217405541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367426446324235d, y: 0.7491429149520253d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139910954436077d, y: 0.7664456697198714d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511017681863619d, y: 0.3852861556668249d), new NpgsqlTypes.NpgsqlPoint(x: 0.45278914759333766d, y: 0.07704125571991949d), new NpgsqlTypes.NpgsqlPoint(x: 0.40224999989614374d, y: 0.46533876958049647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16713556718930267d, y: 0.7074930425739921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722846538334037d, y: 0.7465393841137327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411319787659751d, y: 0.14698933293666971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12096242291097037d, y: 0.877407020439782d), new NpgsqlTypes.NpgsqlPoint(x: 0.36821798034338393d, y: 0.8444864481657555d), new NpgsqlTypes.NpgsqlPoint(x: 0.014046085228531346d, y: 0.8028209198989016d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8037683989988621d, y: 0.9732611473715416d), new NpgsqlTypes.NpgsqlPoint(x: 0.2308695212778029d, y: 0.7642960677360506d), new NpgsqlTypes.NpgsqlPoint(x: 0.816505047480772d, y: 0.6794080158159571d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02601658444330812d, y: 0.1767755854523665d), new NpgsqlTypes.NpgsqlPoint(x: 0.07403586972305731d, y: 0.2743550020434523d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008324575617607577d, y: 0.04483327059589537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05075274399747698d, y: 0.7475098888449838d), new NpgsqlTypes.NpgsqlPoint(x: 0.30305470843982296d, y: 0.9609670137366247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9730215619160169d, y: 0.5851788110679574d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3222924455766001d, y: 0.7657227185897104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026431222213114d, y: 0.7180986928107255d), new NpgsqlTypes.NpgsqlPoint(x: 0.36534015070826953d, y: 0.7155495373875913d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2708572943974247d, y: 0.6432674919312215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9458014144400927d, y: 0.6981634254759865d), new NpgsqlTypes.NpgsqlPoint(x: 0.43326073966718626d, y: 0.5992906994615228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2512439135117239d, y: 0.591028845535844d), new NpgsqlTypes.NpgsqlPoint(x: 0.27060171104816655d, y: 0.31553462956339984d), new NpgsqlTypes.NpgsqlPoint(x: 0.2334019105461771d, y: 0.12382097110856194d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9876922944414078d, y: 0.9780158584581146d), new NpgsqlTypes.NpgsqlPoint(x: 0.06709877810433196d, y: 0.31630255028881793d), new NpgsqlTypes.NpgsqlPoint(x: 0.986572376227452d, y: 0.34630178340696915d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8180065735830498d, y: 0.42981092915260377d), new NpgsqlTypes.NpgsqlPoint(x: 0.46639263956990795d, y: 0.23802600365944004d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613714443109327d, y: 0.6464252537993259d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5777026054387987d, y: 0.9860003084437481d), new NpgsqlTypes.NpgsqlPoint(x: 0.14072553634385032d, y: 0.3581251351452146d), new NpgsqlTypes.NpgsqlPoint(x: 0.2003894493784616d, y: 0.7561366780203895d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5138299798651748d, y: 0.5045044713482424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364797189409934d, y: 0.26704544295502375d), new NpgsqlTypes.NpgsqlPoint(x: 0.012238780349546619d, y: 0.9069874965391664d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39734644148252507d, y: 0.329904384623782d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534746313231875d, y: 0.7035658920342931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141106902924044d, y: 0.7398774082378624d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4478977128407682d, y: 0.6503095876216337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772494332356748d, y: 0.8312819816812953d), new NpgsqlTypes.NpgsqlPoint(x: 0.28468910150854754d, y: 0.7176526282410097d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5491411747735666d, y: 0.588286741850522d), new NpgsqlTypes.NpgsqlPoint(x: 0.995574155086437d, y: 0.41115779596865d), new NpgsqlTypes.NpgsqlPoint(x: 0.583451728199087d, y: 0.2874147167871395d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18170316457276992d, y: 0.2322425758577219d), new NpgsqlTypes.NpgsqlPoint(x: 0.040409292927575224d, y: 0.44008869399735506d), new NpgsqlTypes.NpgsqlPoint(x: 0.2046761878736746d, y: 0.46182122910283396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.523755723771148d, y: 0.25890818052856335d), new NpgsqlTypes.NpgsqlPoint(x: 0.8470617495724581d, y: 0.055376984900646686d), new NpgsqlTypes.NpgsqlPoint(x: 0.20728227912114505d, y: 0.8699863579373868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008916513874481002d, y: 0.759457046608393d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809204272347182d, y: 0.10456966927419231d), new NpgsqlTypes.NpgsqlPoint(x: 0.21309605213442273d, y: 0.11511246246053364d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9819284258021092d, y: 0.5709353417424757d), new NpgsqlTypes.NpgsqlPoint(x: 0.056270009869350046d, y: 0.46167976689722334d), new NpgsqlTypes.NpgsqlPoint(x: 0.02686719976202656d, y: 0.6793961686130432d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4450480571523112d, y: 0.1814569163136147d), new NpgsqlTypes.NpgsqlPoint(x: 0.31924183323257105d, y: 0.7865742703200699d), new NpgsqlTypes.NpgsqlPoint(x: 0.14194516604958118d, y: 0.008012072229296452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5300609475751803d, y: 0.9181965371256725d), new NpgsqlTypes.NpgsqlPoint(x: 0.675337282055606d, y: 0.7025571010977312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998689238423574d, y: 0.25407790859255763d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39787036866925674d, y: 0.2149630258537506d), new NpgsqlTypes.NpgsqlPoint(x: 0.15532440984959217d, y: 0.18177680309527877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9808202932849812d, y: 0.10854030097478717d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7783343379661868d, y: 0.8711809246163661d), new NpgsqlTypes.NpgsqlPoint(x: 0.27246628926253047d, y: 0.06856049642585849d), new NpgsqlTypes.NpgsqlPoint(x: 0.2828645948938626d, y: 0.2762061780156255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02495767544936145d, y: 0.3227492659221717d), new NpgsqlTypes.NpgsqlPoint(x: 0.0026637990687965463d, y: 0.12860281151106612d), new NpgsqlTypes.NpgsqlPoint(x: 0.25939219640151256d, y: 0.06467583040611691d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3782624728888959d, y: 0.5394117903598465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594552183742799d, y: 0.32211641432871807d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441057591713176d, y: 0.007825609486668328d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8213556837762418d, y: 0.1865060522925791d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841272684251173d, y: 0.8100584950651075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242464780293532d, y: 0.8000933725248663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3681539518312018d, y: 0.09684549459897585d), new NpgsqlTypes.NpgsqlPoint(x: 0.13660904703638477d, y: 0.4593523067225963d), new NpgsqlTypes.NpgsqlPoint(x: 0.44744269607152887d, y: 0.9317923399192181d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5653353733929181d, y: 0.48066744742855416d), new NpgsqlTypes.NpgsqlPoint(x: 0.39272173274357436d, y: 0.6374436017034106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183455504993083d, y: 0.7084759969350067d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6413753480090797d, y: 0.5238690741205968d), new NpgsqlTypes.NpgsqlPoint(x: 0.4619436588772001d, y: 0.6640220140146735d), new NpgsqlTypes.NpgsqlPoint(x: 0.42847594399135525d, y: 0.5804278919233701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6602757461608126d, y: 0.6154987706921851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7030856096103126d, y: 0.8137070997411626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352567776391011d, y: 0.0033679181141075265d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5553619764163749d, y: 0.7213962750921871d), new NpgsqlTypes.NpgsqlPoint(x: 0.7170813078238967d, y: 0.9939664321638652d), new NpgsqlTypes.NpgsqlPoint(x: 0.03929771603980314d, y: 0.37054218080621903d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37666631998566646d, y: 0.9138860829118967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9143777355495214d, y: 0.5772158746016015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169293802345735d, y: 0.8986967171718622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28276382811300493d, y: 0.6361292631299429d), new NpgsqlTypes.NpgsqlPoint(x: 0.3073678160486537d, y: 0.22442178716225247d), new NpgsqlTypes.NpgsqlPoint(x: 0.10236573228414547d, y: 0.284633299892711d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7288464052871914d, y: 0.23692483964108546d), new NpgsqlTypes.NpgsqlPoint(x: 0.758382743445195d, y: 0.5007263596637839d), new NpgsqlTypes.NpgsqlPoint(x: 0.0015151367254893078d, y: 0.04149911626585201d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2895932289524775d, y: 0.6007079904336348d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406734111225479d, y: 0.9193952563677568d), new NpgsqlTypes.NpgsqlPoint(x: 0.24552565804015258d, y: 0.6392479490397525d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09972509519610029d, y: 0.5696551735391695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503784241409029d, y: 0.8555885204560095d), new NpgsqlTypes.NpgsqlPoint(x: 0.313416103397981d, y: 0.41873073522180626d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8255523327228957d, y: 0.01221115491410063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122686723854446d, y: 0.3177544904176708d), new NpgsqlTypes.NpgsqlPoint(x: 0.00283501869039271d, y: 0.6131342734314856d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09049206853701386d, y: 0.9159084502346085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3057637019712759d, y: 0.48939206555365755d), new NpgsqlTypes.NpgsqlPoint(x: 0.4770392755062993d, y: 0.3571834620654598d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41854066700156456d, y: 0.5046029766987682d), new NpgsqlTypes.NpgsqlPoint(x: 0.45229634402659136d, y: 0.7151642961420926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7414051825302789d, y: 0.3739294074604592d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5241073729619038d, y: 0.5939321122526507d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587719881603276d, y: 0.9162085976584604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6588864853322194d, y: 0.16277240780211077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7837751000347677d, y: 0.9035160545734525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8131766987792367d, y: 0.13771189645567306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3700700235683385d, y: 0.016903286554797115d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1572094244052341d, y: 0.20370843909316594d), new NpgsqlTypes.NpgsqlPoint(x: 0.24797232928695745d, y: 0.20532656941260974d), new NpgsqlTypes.NpgsqlPoint(x: 0.17687548395054875d, y: 0.7768882024707132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29054986895286006d, y: 0.6800937423289773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958034156968335d, y: 0.14364740922118147d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872312932445868d, y: 0.0187128583402022d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7209801524280346d, y: 0.8302950256475593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8099127067803381d, y: 0.38076311003124097d), new NpgsqlTypes.NpgsqlPoint(x: 0.48457212678765693d, y: 0.02482160329136729d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5897603243856472d, y: 0.3407173486541878d), new NpgsqlTypes.NpgsqlPoint(x: 0.12443800085917611d, y: 0.46067459709828873d), new NpgsqlTypes.NpgsqlPoint(x: 0.20510122357580252d, y: 0.45962551417792286d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9344275230041921d, y: 0.928753767561444d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129971660341709d, y: 0.5012108179831063d), new NpgsqlTypes.NpgsqlPoint(x: 0.987243864025016d, y: 0.3085034344494415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07992443605227961d, y: 0.6423718850540442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2528691011725205d, y: 0.2652416000057214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663316634137953d, y: 0.06194881766520921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20271659827936217d, y: 0.6825653540077674d), new NpgsqlTypes.NpgsqlPoint(x: 0.874399722105461d, y: 0.45566812101966025d), new NpgsqlTypes.NpgsqlPoint(x: 0.3633137156443581d, y: 0.20633200426042575d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49236428712790614d, y: 0.23850718505766755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529022583426203d, y: 0.11254945760905011d), new NpgsqlTypes.NpgsqlPoint(x: 0.30497781656139444d, y: 0.03261974711237192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5981914345705659d, y: 0.7848998841196846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5630916994108333d, y: 0.4758477351921647d), new NpgsqlTypes.NpgsqlPoint(x: 0.13918671123529336d, y: 0.40921999611571735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5767541210425327d, y: 0.39329191195331936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9734344411201669d, y: 0.014736705368387892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639682794841387d, y: 0.041712017140969726d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4127061931987751d, y: 0.17643996496420788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292620913731013d, y: 0.3587800949509409d), new NpgsqlTypes.NpgsqlPoint(x: 0.42373540913959284d, y: 0.042525903013927224d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6383612857920399d, y: 0.11757873302565358d), new NpgsqlTypes.NpgsqlPoint(x: 0.3877448436010581d, y: 0.8653965427038247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223562248074631d, y: 0.23280383811111582d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40266412601494905d, y: 0.0023931281557436623d), new NpgsqlTypes.NpgsqlPoint(x: 0.24910059289511455d, y: 0.9570705416385887d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396346751730246d, y: 0.0015593472067730874d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7406064599122614d, y: 0.2537832565749749d), new NpgsqlTypes.NpgsqlPoint(x: 0.26195347003270564d, y: 0.4255600957051089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4395884079696064d, y: 0.29854027270793715d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7703528224049558d, y: 0.5653000528595932d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256495141707604d, y: 0.8868592542622572d), new NpgsqlTypes.NpgsqlPoint(x: 0.25055203132011716d, y: 0.2531797047619204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5390937136978045d, y: 0.12253374733247135d), new NpgsqlTypes.NpgsqlPoint(x: 0.03438912369338776d, y: 0.08173451861434622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6793403458584396d, y: 0.41862043336889254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31742963008462055d, y: 0.2594740970254177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742050987326d, y: 0.8789336719127396d), new NpgsqlTypes.NpgsqlPoint(x: 0.07388657066998006d, y: 0.8048005227880428d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8499786538830248d, y: 0.36648887490192406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935063806012262d, y: 0.1990069050199782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8305600265655518d, y: 0.7901754987640578d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906935641302231d, y: 0.08988425295570612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966523689715863d, y: 0.9815640185684642d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342401841757293d, y: 0.42341184456821457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23836392245478388d, y: 0.8526059995849918d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200547166102226d, y: 0.4156875056594741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6099007912454103d, y: 0.8068689289553987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6739741491870257d, y: 0.5525384942731819d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935187909264628d, y: 0.41766645269141234d), new NpgsqlTypes.NpgsqlPoint(x: 0.2533405951438418d, y: 0.8727811026867783d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0011812116424408936d, y: 0.3659726747458312d), new NpgsqlTypes.NpgsqlPoint(x: 0.31847020399642756d, y: 0.49680463311828593d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787892351450197d, y: 0.37414718768158606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7549074477282541d, y: 0.7956557861023509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012346109983566d, y: 0.4374965299912812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074068447985796d, y: 0.2629415132594054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2630883182762369d, y: 0.22325525112465328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7135297179992726d, y: 0.13842241357940477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7718611921261479d, y: 0.8716379808960143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09582552667522826d, y: 0.4489601963724702d), new NpgsqlTypes.NpgsqlPoint(x: 0.17243168937281883d, y: 0.8024540944457581d), new NpgsqlTypes.NpgsqlPoint(x: 0.4383434436218653d, y: 0.5149796191982997d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2431436841703355d, y: 0.9539969731212197d), new NpgsqlTypes.NpgsqlPoint(x: 0.27120878292540207d, y: 0.20901893855166953d), new NpgsqlTypes.NpgsqlPoint(x: 0.12746086316507665d, y: 0.9184966569106232d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7171947283843927d, y: 0.809080700857046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874052358106523d, y: 0.06553042331133518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7871619599572425d, y: 0.8635775899594529d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23840899158128115d, y: 0.6741622331967176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825355452083103d, y: 0.9761539070481658d), new NpgsqlTypes.NpgsqlPoint(x: 0.06916360611358163d, y: 0.25436047807309814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4856543838992554d, y: 0.5120314088541396d), new NpgsqlTypes.NpgsqlPoint(x: 0.10108415760345868d, y: 0.30602538689184755d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937850440574876d, y: 0.33576058678944853d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8656193721971527d, y: 0.761198203873774d), new NpgsqlTypes.NpgsqlPoint(x: 0.3415013183795529d, y: 0.039074568065227355d), new NpgsqlTypes.NpgsqlPoint(x: 0.33858204739039466d, y: 0.8811747675950551d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08324669048114897d, y: 0.6813922437329489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965214499183096d, y: 0.3374894477303092d), new NpgsqlTypes.NpgsqlPoint(x: 0.2729239497150967d, y: 0.747105169890228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9332303095321681d, y: 0.828377637154443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3366840178449745d, y: 0.4587686101236058d), new NpgsqlTypes.NpgsqlPoint(x: 0.1646067651743719d, y: 0.48757862326364954d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3605511335786572d, y: 0.4680493193373656d), new NpgsqlTypes.NpgsqlPoint(x: 0.2491490825333681d, y: 0.5333201547294737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8546101889199795d, y: 0.1063773970261882d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2529820839460172d, y: 0.35598022878856095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6522219558729965d, y: 0.5337591637325763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5380888281310391d, y: 0.9727996447224938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9141075424999975d, y: 0.8444724090220554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8385228585661408d, y: 0.2126500241974053d), new NpgsqlTypes.NpgsqlPoint(x: 0.36367944535955266d, y: 0.22537668127769128d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09930868908403623d, y: 0.428981166866402d), new NpgsqlTypes.NpgsqlPoint(x: 0.12171106796330111d, y: 0.5425666844764644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034795555121422d, y: 0.092173364395301d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.984121736059678d, y: 0.14784825722454864d), new NpgsqlTypes.NpgsqlPoint(x: 0.3086141981173891d, y: 0.15414687896020873d), new NpgsqlTypes.NpgsqlPoint(x: 0.023164258246814673d, y: 0.5785524094975941d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08899077783350662d, y: 0.032744921954426576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554418091028576d, y: 0.7201009921589981d), new NpgsqlTypes.NpgsqlPoint(x: 0.09090813890305705d, y: 0.7485250853834138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3864194429279908d, y: 0.05853773329201928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460369783422089d, y: 0.5950132161086813d), new NpgsqlTypes.NpgsqlPoint(x: 0.4071467813524461d, y: 0.8125656662511704d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5272600688870809d, y: 0.07750682622195626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7047074299412927d, y: 0.7454814665487247d), new NpgsqlTypes.NpgsqlPoint(x: 0.329218185153324d, y: 0.7790640030931743d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9827782419768359d, y: 0.05903594460556805d), new NpgsqlTypes.NpgsqlPoint(x: 0.46180299240984624d, y: 0.684646910886295d), new NpgsqlTypes.NpgsqlPoint(x: 0.16049255715852895d, y: 0.7661620440174827d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07673128155997211d, y: 0.13276890505006034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8001383695183535d, y: 0.9827133710361189d), new NpgsqlTypes.NpgsqlPoint(x: 0.661231083265807d, y: 0.08888422519257677d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2651674354586254d, y: 0.5658283285243404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016264133049126d, y: 0.7287173630171654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523165658469789d, y: 0.5896384970502433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33606332350049206d, y: 0.3843518359717466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6237425556137142d, y: 0.8591118084300868d), new NpgsqlTypes.NpgsqlPoint(x: 0.01327463310926269d, y: 0.2621582969525901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4246924275087284d, y: 0.902004681117112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027605466907346d, y: 0.045741358890298955d), new NpgsqlTypes.NpgsqlPoint(x: 0.49256528049209336d, y: 0.9043186605893214d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5135822544373088d, y: 0.22181611985257432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9081221480791304d, y: 0.1598049836337695d), new NpgsqlTypes.NpgsqlPoint(x: 0.05696274657695999d, y: 0.9440697503482185d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3719046070198747d, y: 0.18390361513084785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842378042123968d, y: 0.12175595658421223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8826798572512239d, y: 0.947464718204078d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33819984381506496d, y: 0.6407387143348151d), new NpgsqlTypes.NpgsqlPoint(x: 0.22551402977900403d, y: 0.6594349144191837d), new NpgsqlTypes.NpgsqlPoint(x: 0.7382846957657041d, y: 0.5693143118244629d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4429247010753682d, y: 0.3498841393743929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8590648288353209d, y: 0.7863455523896604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849607570162151d, y: 0.5675501842865058d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7068699612110618d, y: 0.0775791509512701d), new NpgsqlTypes.NpgsqlPoint(x: 0.22464504404856245d, y: 0.03505032461522062d), new NpgsqlTypes.NpgsqlPoint(x: 0.11936349531144153d, y: 0.03601438937716506d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7332130166869497d, y: 0.18809957515073827d), new NpgsqlTypes.NpgsqlPoint(x: 0.890471118640079d, y: 0.9084037929334d), new NpgsqlTypes.NpgsqlPoint(x: 0.2734487432053426d, y: 0.7204103908193031d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1658025071591085d, y: 0.05187146214682303d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761173423634068d, y: 0.7701798039753097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6661711347478504d, y: 0.0023136343484387867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8241227199898932d, y: 0.24103253448827866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2029560858615299d, y: 0.47306631867088067d), new NpgsqlTypes.NpgsqlPoint(x: 0.3361282231099222d, y: 0.32839103252915003d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.686120424598998d, y: 0.8086293024613663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758048534265301d, y: 0.0010215958575896522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3227150547832689d, y: 0.7556897913593152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26657198873552246d, y: 0.10464225249347214d), new NpgsqlTypes.NpgsqlPoint(x: 0.6970089889741728d, y: 0.31710906817353157d), new NpgsqlTypes.NpgsqlPoint(x: 0.6325797267238187d, y: 0.9464651693255964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.950974596475394d, y: 0.925336615505608d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633541270049035d, y: 0.1369529615797892d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395670170235404d, y: 0.9427918548721552d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4266550286965729d, y: 0.02304313671194369d), new NpgsqlTypes.NpgsqlPoint(x: 0.2924115180309277d, y: 0.8849788371209568d), new NpgsqlTypes.NpgsqlPoint(x: 0.931657724817872d, y: 0.7297612768912239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07241508662724383d, y: 0.5771204398004601d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350930008785701d, y: 0.48955405432736854d), new NpgsqlTypes.NpgsqlPoint(x: 0.1507153686224213d, y: 0.5938956846154481d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6587340563388829d, y: 0.08423147522653407d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323821829210438d, y: 0.28768622462666993d), new NpgsqlTypes.NpgsqlPoint(x: 0.3769431638924219d, y: 0.7877053489620871d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7338022684678936d, y: 0.9710907993225312d), new NpgsqlTypes.NpgsqlPoint(x: 0.323283659625738d, y: 0.45726299928564096d), new NpgsqlTypes.NpgsqlPoint(x: 0.1559007864206473d, y: 0.6918425637398785d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6416475033070775d, y: 0.8795542396728725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5181057767861955d, y: 0.49823064311613297d), new NpgsqlTypes.NpgsqlPoint(x: 0.169466618279137d, y: 0.12685214608335238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5352076471486166d, y: 0.43993727454501663d), new NpgsqlTypes.NpgsqlPoint(x: 0.474372733712635d, y: 0.03650220821230121d), new NpgsqlTypes.NpgsqlPoint(x: 0.05292033402013363d, y: 0.7460672616734649d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8994086082006003d, y: 0.4247790633920169d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942319711381445d, y: 0.26042237722356987d), new NpgsqlTypes.NpgsqlPoint(x: 0.22251306356204403d, y: 0.6149703846631346d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28386485909169423d, y: 0.4905018948710742d), new NpgsqlTypes.NpgsqlPoint(x: 0.14003049312834914d, y: 0.9065895817191653d), new NpgsqlTypes.NpgsqlPoint(x: 0.44298998929308075d, y: 0.9528708203995977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4559094379024442d, y: 0.7727321413291848d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395203686264875d, y: 0.8435624825616344d), new NpgsqlTypes.NpgsqlPoint(x: 0.36560499511765554d, y: 0.7679875010516615d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7451540005872224d, y: 0.6490617503398642d), new NpgsqlTypes.NpgsqlPoint(x: 0.0432912466852764d, y: 0.053097166476499424d), new NpgsqlTypes.NpgsqlPoint(x: 0.21967280404221845d, y: 0.05761502360609794d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6478428978362574d, y: 0.42109179821507026d), new NpgsqlTypes.NpgsqlPoint(x: 0.4652585512776424d, y: 0.5291913247097683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7017595630504803d, y: 0.07815678376467816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36254188429484224d, y: 0.7738667316889882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772934237253188d, y: 0.9769523363823914d), new NpgsqlTypes.NpgsqlPoint(x: 0.3679374977541764d, y: 0.03266335985869273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24015613163761362d, y: 0.9622186513238749d), new NpgsqlTypes.NpgsqlPoint(x: 0.4592606381185149d, y: 0.8471826808720377d), new NpgsqlTypes.NpgsqlPoint(x: 0.2804855254559653d, y: 0.6851482116716276d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9141877836143824d, y: 0.705139213342613d), new NpgsqlTypes.NpgsqlPoint(x: 0.42546660772662814d, y: 0.35595661189499406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046454378662977d, y: 0.8845877601111425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003697191777401132d, y: 0.6846319126476759d), new NpgsqlTypes.NpgsqlPoint(x: 0.3244782545590227d, y: 0.3281241807742682d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938076826209753d, y: 0.7690960492110624d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8091597187814102d, y: 0.2920233835193111d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412075942725924d, y: 0.17321905422701123d), new NpgsqlTypes.NpgsqlPoint(x: 0.1894749073226255d, y: 0.35598292262581244d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5401632024977603d, y: 0.9802814791844431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140457149824982d, y: 0.668516458894648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013917754103063d, y: 0.028163720136048398d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2235575139288839d, y: 0.9569313459777536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343906695072393d, y: 0.93275234855422d), new NpgsqlTypes.NpgsqlPoint(x: 0.557951644630099d, y: 0.6720344153568673d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19802355824835716d, y: 0.2532200820587964d), new NpgsqlTypes.NpgsqlPoint(x: 0.38511320886080447d, y: 0.10276232983152112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822038253441778d, y: 0.18032367621533196d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4553989645130918d, y: 0.890084219188514d), new NpgsqlTypes.NpgsqlPoint(x: 0.2067937385868691d, y: 0.448722230208201d), new NpgsqlTypes.NpgsqlPoint(x: 0.16478650008793339d, y: 0.02444668052002874d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38488748618046786d, y: 0.9590633720587788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7041844261782862d, y: 0.06326586263209988d), new NpgsqlTypes.NpgsqlPoint(x: 0.36086837706689245d, y: 0.7674965557223826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39489446884511026d, y: 0.6199784630908667d), new NpgsqlTypes.NpgsqlPoint(x: 0.917971132874437d, y: 0.5030170981678584d), new NpgsqlTypes.NpgsqlPoint(x: 0.6292841971825036d, y: 0.9561964324609643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33261648911349273d, y: 0.8267310135187743d), new NpgsqlTypes.NpgsqlPoint(x: 0.3656567577739821d, y: 0.1560271688994347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2684675026940614d, y: 0.8989262059552471d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1459295262165473d, y: 0.5202392859940738d), new NpgsqlTypes.NpgsqlPoint(x: 0.13128960367138587d, y: 0.11785027296929518d), new NpgsqlTypes.NpgsqlPoint(x: 0.1269528194318169d, y: 0.4342822734100352d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24956261135108126d, y: 0.6189166166146403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526862347597906d, y: 0.7583709723900239d), new NpgsqlTypes.NpgsqlPoint(x: 0.36860489151279274d, y: 0.7254114729711296d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6135445009439492d, y: 0.9162965919745596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9276044441590056d, y: 0.9130546755482087d), new NpgsqlTypes.NpgsqlPoint(x: 0.28025698635737506d, y: 0.16642453120069667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7618871212302931d, y: 0.7019686041481009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471512299328317d, y: 0.13798718181591785d), new NpgsqlTypes.NpgsqlPoint(x: 0.012852801022484317d, y: 0.36896495788792305d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24404391146168103d, y: 0.7256558717904328d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818693980050734d, y: 0.2396225548472405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407248986034707d, y: 0.49555404380942214d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03916840811267486d, y: 0.4848449747276564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8589879918817656d, y: 0.7078024735376346d), new NpgsqlTypes.NpgsqlPoint(x: 0.022393213405253576d, y: 0.3247257002026195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007874123445883785d, y: 0.7928111536944852d), new NpgsqlTypes.NpgsqlPoint(x: 0.24161692935568369d, y: 0.3837160695411035d), new NpgsqlTypes.NpgsqlPoint(x: 0.639050560589471d, y: 0.0673287776111059d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6169747866402345d, y: 0.7784894748724527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998866773978336d, y: 0.7713991807069592d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693274033724556d, y: 0.7720577198111914d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32895431567609634d, y: 0.6317589321711338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531142401222561d, y: 0.4335186694534142d), new NpgsqlTypes.NpgsqlPoint(x: 0.21594783893864267d, y: 0.8688496959792283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23086019189480378d, y: 0.3001767054219736d), new NpgsqlTypes.NpgsqlPoint(x: 0.04792191496389986d, y: 0.4437895556951438d), new NpgsqlTypes.NpgsqlPoint(x: 0.05805671735660378d, y: 0.6241345924264265d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5125997294022144d, y: 0.9051320214740087d), new NpgsqlTypes.NpgsqlPoint(x: 0.20498105744569606d, y: 0.08405368002417157d), new NpgsqlTypes.NpgsqlPoint(x: 0.17894109001393876d, y: 0.17522696461600473d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6389362815286356d, y: 0.3557329322498892d), new NpgsqlTypes.NpgsqlPoint(x: 0.702456812198335d, y: 0.11087544025225848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993021317112803d, y: 0.7869976148256965d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13644348273772788d, y: 0.5150767274905058d), new NpgsqlTypes.NpgsqlPoint(x: 0.3013840946091828d, y: 0.9466843385057301d), new NpgsqlTypes.NpgsqlPoint(x: 0.3755270335635489d, y: 0.3686492992880561d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2913554299680079d, y: 0.368307161954615d), new NpgsqlTypes.NpgsqlPoint(x: 0.32837526527900496d, y: 0.25242864921192265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621219324004188d, y: 0.88997057468509d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.696084211740095d, y: 0.4868317965246244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4797385139286462d, y: 0.7002661095455891d), new NpgsqlTypes.NpgsqlPoint(x: 0.3302671993518401d, y: 0.7123407783829433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11454522861255956d, y: 0.7227096084033178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9539762791514746d, y: 0.8586706761142271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7799840860154139d, y: 0.22719245454785852d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40847094291662345d, y: 0.8937523636034725d), new NpgsqlTypes.NpgsqlPoint(x: 0.19740739408116625d, y: 0.8047631526048612d), new NpgsqlTypes.NpgsqlPoint(x: 0.04532975551608143d, y: 0.6908578511479897d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28222949447714585d, y: 0.4629591039994291d), new NpgsqlTypes.NpgsqlPoint(x: 0.22826967059491787d, y: 0.7103126220781649d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759759663833246d, y: 0.6561036343301762d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49363264834643106d, y: 0.08649581832270747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623016424825233d, y: 0.09207429676670176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8215094512817167d, y: 0.37505863813558604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7956401468115852d, y: 0.20832490807180293d), new NpgsqlTypes.NpgsqlPoint(x: 0.22840332914269512d, y: 0.3553222608663894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078908905393754d, y: 0.4752247031244037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27936830834247073d, y: 0.9057123222393018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8594475747010786d, y: 0.7576612882364088d), new NpgsqlTypes.NpgsqlPoint(x: 0.379131603440934d, y: 0.5871092266767666d)),
}));
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
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8824916132789414d, y: 0.36016589327077786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554468493286426d, y: 0.6621428384879166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370808141025809d, y: 0.5599561931224989d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2977973051684971d, y: 0.5178379451438684d), new NpgsqlTypes.NpgsqlPoint(x: 0.0779495388258572d, y: 0.6537111467967193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582766233404519d, y: 0.6405236446091698d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7520749770323224d, y: 0.42422896130696264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5504939885043646d, y: 0.5464820451306104d), new NpgsqlTypes.NpgsqlPoint(x: 0.49364760255768547d, y: 0.008831941512129293d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29728667134423337d, y: 0.48408032720870253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5847482730834344d, y: 0.5771145453790244d), new NpgsqlTypes.NpgsqlPoint(x: 0.005523448132096931d, y: 0.5548139908780289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9098662023601334d, y: 0.1793289553564802d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990840567854873d, y: 0.9172219976432091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906268020418753d, y: 0.11246928216287266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34369633471624395d, y: 0.1044154188261478d), new NpgsqlTypes.NpgsqlPoint(x: 0.914144170493122d, y: 0.3827906498345093d), new NpgsqlTypes.NpgsqlPoint(x: 0.10567502656918526d, y: 0.0538782867442571d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9634272734538987d, y: 0.6660653961781675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8657096130276839d, y: 0.35655717773551887d), new NpgsqlTypes.NpgsqlPoint(x: 0.991238660451286d, y: 0.23392199676148384d)),
}));
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22734041656429704d, y: 0.894179111339154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449171584485097d, y: 0.5660152017056582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9011412400978371d, y: 0.23837575294326108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1941880108347268d, y: 0.26156224561518504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836237080628673d, y: 0.34107925155697805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3063524268235597d, y: 0.7336957471358028d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9052717031308767d, y: 0.08068113297843926d), new NpgsqlTypes.NpgsqlPoint(x: 0.16170879397410776d, y: 0.6088070275648195d), new NpgsqlTypes.NpgsqlPoint(x: 0.21301675067635295d, y: 0.722853077318743d)),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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

                var models =  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 2, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
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
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatchAsync(connection, 6, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
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
                var models =  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatch(connection, 102, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

