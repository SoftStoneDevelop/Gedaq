

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027601831876365113d, y: 0.7199009517307017d), radius: 0.13068667923233956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4997131517450176d, y: 0.6576665088058244d), radius: 0.4997814332491841d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5686471794878558d, y: 0.08247985291893001d), radius: 0.8806690049251887d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40315964169237894d, y: 0.9909428995755026d), radius: 0.6620797611561396d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.267054649338872d, y: 0.1534102292425633d), radius: 0.20544791932069484d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06651799275669878d, y: 0.1867432371951555d), radius: 0.8355311663961758d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6738719006053023d, y: 0.25332134500375914d), radius: 0.6126889352736623d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10348483745160997d, y: 0.09578681866042982d), radius: 0.09782346948219289d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4175125848792417d, y: 0.4461320304500421d), radius: 0.07457713811873179d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9523196670654278d, y: 0.4607536121073432d), radius: 0.7405010058767018d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5422882105720969d, y: 0.08079488704861892d), radius: 0.7336079101498801d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3959660149289319d, y: 0.5330505166095925d), radius: 0.5038933593128797d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8168050359216599d, y: 0.7015727981594886d), radius: 0.551624196440089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1368440224931985d, y: 0.7582778634932336d), radius: 0.31642588478404243d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44617588284358467d, y: 0.8839495568501832d), radius: 0.48836114510756723d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5649489401032965d, y: 0.686315294293823d), radius: 0.10936071738987885d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9184103869191366d, y: 0.9061818735555491d), radius: 0.17169754724134478d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8178351652314889d, y: 0.022911003150895226d), radius: 0.8491672355795282d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.265283570346624d, y: 0.306438400125427d), radius: 0.21567560998095447d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9482920398135501d, y: 0.5277224270529933d), radius: 0.45252569525637387d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12731590220121802d, y: 0.7824133249964206d), radius: 0.6645096662010849d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4324251486495063d, y: 0.6344233939973778d), radius: 0.9337441900536261d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08806012621042014d, y: 0.04118650642863608d), radius: 0.8458772538892794d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1147863364185927d, y: 0.7661885206377858d), radius: 0.9665060287080742d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35410314780626606d, y: 0.8340330376933512d), radius: 0.8005275769358766d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9992219802857428d, y: 0.03980042135968909d), radius: 0.6276335351223025d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8103250128618856d, y: 0.05788231373387698d), radius: 0.4147633119692461d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.906684826313994d, y: 0.10093299325225458d), radius: 0.1094781326678953d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47607615065205733d, y: 0.08158199389270104d), radius: 0.42439655050114045d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9922798036033983d, y: 0.4360412530682236d), radius: 0.434982565595055d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9328840514534862d, y: 0.5792113349693458d), radius: 0.37487127136287246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.458204596533588d, y: 0.9309144728662158d), radius: 0.4103434536457895d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1377084052863361d, y: 0.631348144710884d), radius: 0.053516806750635526d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916729454555689d, y: 0.010371539498437388d), radius: 0.27764199344020946d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8343222288717664d, y: 0.8181963428872753d), radius: 0.5725876300333995d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8998526499529196d, y: 0.3361827420365291d), radius: 0.9369352521181395d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.528449259713167d, y: 0.4941185943789451d), radius: 0.8466039300895813d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37053943152365554d, y: 0.8597219819757944d), radius: 0.9605805585386241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.994911079872413d, y: 0.1317272182056093d), radius: 0.40086740655730624d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2827267091065562d, y: 0.390211527462902d), radius: 0.8385850335017344d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4294780645637951d, y: 0.8281075927877309d), radius: 0.06781355922662202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7179402967813253d, y: 0.5008712134297112d), radius: 0.1760129479984851d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4309856694208918d, y: 0.7328671208034638d), radius: 0.31855779735306644d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940444396810591d, y: 0.6500143779563258d), radius: 0.8655443918258519d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35241427307749873d, y: 0.9010267049359045d), radius: 0.6009624155660805d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5836670843750197d, y: 0.9900331896489909d), radius: 0.19667584730642973d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5193202006764235d, y: 0.08345030089027372d), radius: 0.1338830210601365d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5942161535756827d, y: 0.9188698335819208d), radius: 0.19441225625040515d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7551866798448884d, y: 0.9231376528244862d), radius: 0.18579144596277997d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41557718574470937d, y: 0.37209742037086047d), radius: 0.9927489662767663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01371045557603423d, y: 0.3005541157166376d), radius: 0.6359845267238837d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9669392132420076d, y: 0.7682200280751684d), radius: 0.22006223841177108d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15506769071763227d, y: 0.7371143538379779d), radius: 0.5611419510788834d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3492949402692147d, y: 0.33762204569561205d), radius: 0.11497420847815021d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23310594498322823d, y: 0.20066423896527374d), radius: 0.2572495954479964d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5807752800404616d, y: 0.7975964200215773d), radius: 0.9484414668643403d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3025898165196269d, y: 0.9382727963287705d), radius: 0.6810861647049592d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8894765469995608d, y: 0.7958089880328978d), radius: 0.5821904556556895d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9463791513220575d, y: 0.07536140864556384d), radius: 0.44987744729365853d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6196670029901908d, y: 0.6645341783773802d), radius: 0.6153279215056321d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8942392227163195d, y: 0.4104750146430921d), radius: 0.7850061895997626d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49412266324802334d, y: 0.9482860998912301d), radius: 0.6321196446117007d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016797914476698428d, y: 0.01166018729930729d), radius: 0.04225175855032359d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8430934349833004d, y: 0.525811061744404d), radius: 0.7990921201289205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6608859390562182d, y: 0.5158443163398788d), radius: 0.5494461486184643d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05314889934595213d, y: 0.43644261646261173d), radius: 0.2151144569061082d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31690658390147597d, y: 0.4382540645492671d), radius: 0.7462096296693089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5764126737845097d, y: 0.6834832973924037d), radius: 0.7148139230036654d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2824843905834472d, y: 0.16225758305828264d), radius: 0.9931950939121109d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8513798118793322d, y: 0.5802666151459774d), radius: 0.5245259729319453d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9743338374162837d, y: 0.43287708317515405d), radius: 0.26337355744748714d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4401589921468988d, y: 0.5310859234621755d), radius: 0.7903604548472456d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3820692441498583d, y: 0.010616861086745977d), radius: 0.2851108482331902d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9801284404402585d, y: 0.2963986529547864d), radius: 0.9095044600648321d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7772146164860424d, y: 0.575359983615941d), radius: 0.0699247254015819d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2777821228622477d, y: 0.35161388488570655d), radius: 0.46979458277024144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7643401559199698d, y: 0.06562255807147388d), radius: 0.7014266426586944d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9450843749927224d, y: 0.8441626458029363d), radius: 0.9857852405448784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6262877301092663d, y: 0.8809704051089563d), radius: 0.03510420904865452d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23754146012846244d, y: 0.535657648846609d), radius: 0.8998116427276431d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2794318459475592d, y: 0.9576564574330453d), radius: 0.2670903119237735d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20577479335108217d, y: 0.2546765054724769d), radius: 0.7066659375032596d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9362690347114532d, y: 0.9714809557738849d), radius: 0.6993705711348316d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6410706334118802d, y: 0.8707154598336634d), radius: 0.41848791880223846d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6870171456472471d, y: 0.19621759193607702d), radius: 0.24227556190647792d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48035520584319247d, y: 0.13253737353155115d), radius: 0.0657827559522578d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48328047789464956d, y: 0.7800863005489872d), radius: 0.14459653253216032d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5175144623661336d, y: 0.08812319210485497d), radius: 0.2347042013363454d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4643469707940553d, y: 0.3840305804691744d), radius: 0.8253550568298843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13677692428614763d, y: 0.05761616989046858d), radius: 0.3899968193090221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8953238428034925d, y: 0.26783449964991124d), radius: 0.7092538346855588d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7870494724187607d, y: 0.04083743542191587d), radius: 0.4055030111022022d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8402046985871299d, y: 0.348895437896411d), radius: 0.8451023513560567d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5773996794579005d, y: 0.6775337081939953d), radius: 0.8223424572274939d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5142633682752807d, y: 0.9602961939628919d), radius: 0.21920551232479757d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7091001494244928d, y: 0.7075452667115977d), radius: 0.8399430025951002d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.343020030257997d, y: 0.39619521480345665d), radius: 0.7231418441615144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32633107891004576d, y: 0.39936461694790293d), radius: 0.3445257085388199d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21845135218931788d, y: 0.31236057851537147d), radius: 0.19997595106514865d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18181359064441316d, y: 0.08932828459974873d), radius: 0.9375905484518927d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7191308390936375d, y: 0.8762783692541216d), radius: 0.5184181816620523d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8063007685157658d, y: 0.16880461804615698d), radius: 0.566508117550674d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.611043683249811d, y: 0.1685946122652675d), radius: 0.8208920172484802d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7794169064541204d, y: 0.6755053257210866d), radius: 0.5135758635951186d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254390548774231d, y: 0.32660789238126586d), radius: 0.047112440438726755d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37086426502223246d, y: 0.8231553690476978d), radius: 0.7499597543638967d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.768731048924139d, y: 0.8750103680853849d), radius: 0.5573942802863048d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7261896768099778d, y: 0.7320472208312709d), radius: 0.6363088100900899d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7586249697230985d, y: 0.6314878506672195d), radius: 0.08579228447138842d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19244209138541013d, y: 0.8076922641680016d), radius: 0.025652615901597953d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06157446230260122d, y: 0.27868450476992335d), radius: 0.9063435725946222d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6151184655265179d, y: 0.6023056081650645d), radius: 0.3824308325290705d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.542535182984073d, y: 0.2564482211869995d), radius: 0.0045874305622961575d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14201839831422236d, y: 0.9325456478277794d), radius: 0.9023880786055632d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7907895477693941d, y: 0.8394515288824711d), radius: 0.5511914368991582d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4278208070781929d, y: 0.37618429647891904d), radius: 0.20391784666181267d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6206867796811253d, y: 0.6870692413218725d), radius: 0.12655781515935116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34671632282556664d, y: 0.1113312626994194d), radius: 0.055557107235124636d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4367773636980967d, y: 0.6864478004218539d), radius: 0.9429623845305947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5637732659582175d, y: 0.4689936563097844d), radius: 0.46134477776944993d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7154921004941488d, y: 0.06093318559945293d), radius: 0.11797359278392361d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8414527601639816d, y: 0.4828916532579991d), radius: 0.31458869414958357d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9320646742586347d, y: 0.7622893162998939d), radius: 0.26186541728501767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8889654593272214d, y: 0.24407310518677383d), radius: 0.6352353821970124d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3220130755603736d, y: 0.5131972197394943d), radius: 0.8123536390075813d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26702279921436956d, y: 0.26677893424863d), radius: 0.35758577731006425d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8435813507626003d, y: 0.01857187136102567d), radius: 0.2621987562289385d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5202594217881992d, y: 0.2963506173279754d), radius: 0.10398473192816315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34645972265928415d, y: 0.7603444505728639d), radius: 0.9101601542572774d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7052051202665052d, y: 0.7641395369226421d), radius: 0.42957003375616354d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08489237246270498d, y: 0.12298669276697372d), radius: 0.5167985204790574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5383972230750013d, y: 0.9720525112560461d), radius: 0.28056898398415453d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5913862939268328d, y: 0.5146695775587253d), radius: 0.31062692806854486d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06967611796654183d, y: 0.35000212489040616d), radius: 0.7293507338191677d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34069173390021323d, y: 0.5804126642228665d), radius: 0.04372762700857713d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6416894879730617d, y: 0.4761364794607782d), radius: 0.14448250195847845d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7588854903953174d, y: 0.3414708826212095d), radius: 0.8796834995114221d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9504789389709363d, y: 0.9256211496360831d), radius: 0.37944492406940955d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4885160850382132d, y: 0.19293399024967794d), radius: 0.6802462451975174d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0784942644581198d, y: 0.5418502958391801d), radius: 0.2580175530446174d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8830969156300983d, y: 0.9644337897969656d), radius: 0.5268630837853562d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21952324838715687d, y: 0.22306600793373454d), radius: 0.5581121319976325d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8482045942476542d, y: 0.3119420089973717d), radius: 0.19698895253901783d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12282220696496116d, y: 0.3208936053756062d), radius: 0.5236615720875356d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7733516486698517d, y: 0.9864077165083973d), radius: 0.021919573468546227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4728244176440912d, y: 0.47809239814702686d), radius: 0.8831207276647214d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8970878934009379d, y: 0.06980649377130499d), radius: 0.3245675158586584d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6191462170960013d, y: 0.2208043165105541d), radius: 0.43539661393856444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2044081590779484d, y: 0.9661817162914321d), radius: 0.47498230234163874d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07606600156743537d, y: 0.5973632213943939d), radius: 0.8806944352030325d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04863424745066547d, y: 0.7839633416195864d), radius: 0.4569691001434446d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7264404961113411d, y: 0.08015033089551382d), radius: 0.3170304580109472d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41952032182587584d, y: 0.4260038637475744d), radius: 0.9811557738725237d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8860203212739055d, y: 0.17669999414259152d), radius: 0.4331833360073024d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7528521604401945d, y: 0.11602582364206471d), radius: 0.7098226507882421d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7322366796591672d, y: 0.5824351070330829d), radius: 0.8141659629052684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6540067311666701d, y: 0.20887332716197948d), radius: 0.22929125100598924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9139488164753872d, y: 0.8802749363028315d), radius: 0.8024044179229656d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015535853895186413d, y: 0.29784030962120034d), radius: 0.8019004249728352d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1938909146481811d, y: 0.10923793207685739d), radius: 0.13502455023117033d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04503073291197923d, y: 0.6550739374380954d), radius: 0.6084402353873551d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6144342917628199d, y: 0.9563932574001718d), radius: 0.9803947956392417d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31520967261618016d, y: 0.7617147570787317d), radius: 0.7926670545344808d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6584330663269115d, y: 0.40415861071343806d), radius: 0.9481609563306918d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10361802836414546d, y: 0.32539664730683027d), radius: 0.18013500079336475d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5443745185862615d, y: 0.02590360731386454d), radius: 0.6463881283968292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13286094177415375d, y: 0.540592137626717d), radius: 0.3847558359767088d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9014697945182615d, y: 0.5900389355036658d), radius: 0.9427322669643947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8027167630697306d, y: 0.8695245800924076d), radius: 0.842535556287842d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9113877688352705d, y: 0.6060934502518559d), radius: 0.995280575693528d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2237069616664914d, y: 0.8844290099723979d), radius: 0.10270144178749918d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5966351442142422d, y: 0.6070470225494192d), radius: 0.43814654507272144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0908505465033057d, y: 0.5353899066597648d), radius: 0.2478676537140423d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2741042119651742d, y: 0.8418522296160688d), radius: 0.7781685117383766d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7311868687061747d, y: 0.9051163716810555d), radius: 0.743419058555193d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07330697994346635d, y: 0.693369638150874d), radius: 0.5443167184811805d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022166827604333195d, y: 0.13481233129296277d), radius: 0.8005920212196871d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6758627934713565d, y: 0.3213922913914591d), radius: 0.2602450749153966d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8449534275005626d, y: 0.34828650488821356d), radius: 0.3833260290344057d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36195691473699887d, y: 0.39082819628103704d), radius: 0.40354761278180784d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8296686438838654d, y: 0.17344852355547047d), radius: 0.574881760077843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12669217890284912d, y: 0.285865841670749d), radius: 0.8583426522633861d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031158309653402716d, y: 0.9873495160786229d), radius: 0.46100957590558833d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28913902295307303d, y: 0.026646226835786435d), radius: 0.40243937629486104d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19472772420214923d, y: 0.3086810350668697d), radius: 0.03941688227965645d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24327108300546219d, y: 0.47353312092801525d), radius: 0.3941663325566077d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36193419942515426d, y: 0.31662370164613884d), radius: 0.9131574056067715d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9952912955015326d, y: 0.6601895707392772d), radius: 0.3173964441512318d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.133941552334648d, y: 0.31742208247983505d), radius: 0.17724180436783055d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1674311158824221d, y: 0.32854453639036085d), radius: 0.16964801080699532d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8159864860382823d, y: 0.09466269526638615d), radius: 0.8661473122255529d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4392869209406993d, y: 0.7658950685049358d), radius: 0.8288297324906867d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05908135087388067d, y: 0.3038593796415652d), radius: 0.2308386242113194d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19131151289938475d, y: 0.4164766529039644d), radius: 0.759076818913703d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.046617488000139984d, y: 0.7613620246518218d), radius: 0.7810529816485858d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24419771515847677d, y: 0.007209488077613679d), radius: 0.4556325032622701d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.779418446029137d, y: 0.8185649904571323d), radius: 0.9908700782047868d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7716510177749047d, y: 0.9944387474933319d), radius: 0.08347162751901438d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6766976606839833d, y: 0.9804618465817528d), radius: 0.02450160978060012d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24553621216645083d, y: 0.15697183720732732d), radius: 0.28188328280543995d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.470270745403247d, y: 0.3630615456360553d), radius: 0.48645744020065107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4152137451971658d, y: 0.19930770204324533d), radius: 0.5115489360177634d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3441720436510922d, y: 0.5546379022786996d), radius: 0.6842058754007072d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7154781673006229d, y: 0.9188497105388527d), radius: 0.8839424395391478d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9107392054812826d, y: 0.431235754965019d), radius: 0.7622198085613444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.969848110822445d, y: 0.3097512996576678d), radius: 0.17703276150027925d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26746899757476383d, y: 0.4988406648325149d), radius: 0.9386501217221488d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0731192847114196d, y: 0.7803665567284157d), radius: 0.7057357110808667d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6992702149214978d, y: 0.9157501254802263d), radius: 0.4243501199362105d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9752493592808856d, y: 0.6059158146925618d), radius: 0.889696807314129d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3618963769185941d, y: 0.23660283442772778d), radius: 0.7858184434570817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5459441837674642d, y: 0.8255774490271208d), radius: 0.5929414814094981d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16319920938580912d, y: 0.7562033803834419d), radius: 0.9671148809866404d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9944723877248175d, y: 0.01535135524426845d), radius: 0.4698405476156057d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03689227079641921d, y: 0.02020840173583327d), radius: 0.49413191983164284d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5217686602902161d, y: 0.5367288739191165d), radius: 0.9878353753265378d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6700971300712725d, y: 0.7211444821907388d), radius: 0.2033559743111849d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6482369240891975d, y: 0.5724314518414014d), radius: 0.005355032445115815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20337497108104274d, y: 0.4914720478230623d), radius: 0.156608326519592d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.408555759516503d, y: 0.28465218999739994d), radius: 0.16390347855741794d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6450354169987371d, y: 0.8696529248087482d), radius: 0.6183940839394831d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8056215583027507d, y: 0.5213583216526223d), radius: 0.7876424095618104d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5482509511097496d, y: 0.04858025086726536d), radius: 0.13939165003622767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28229208285788643d, y: 0.8066667346037104d), radius: 0.46625104001901774d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25220365563661495d, y: 0.5290631534175859d), radius: 0.5748039192881119d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4156928871328399d, y: 0.9156017487233551d), radius: 0.6676059024370136d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3252917379404776d, y: 0.030821599236646513d), radius: 0.16001280695703068d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9383562506828738d, y: 0.9954052607863997d), radius: 0.9811532922037922d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7215252152847033d, y: 0.9153837855570183d), radius: 0.23441970701489967d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5521312131005398d, y: 0.8311134819975717d), radius: 0.20638816614344146d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08860922292132889d, y: 0.9210089536765139d), radius: 0.3358999055239328d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8172052846632182d, y: 0.6159452209550504d), radius: 0.4639710170941467d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5915430719736019d, y: 0.4841839926938494d), radius: 0.08635502267695461d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7000709852632185d, y: 0.4444979909658555d), radius: 0.4906361212295828d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9162100147622358d, y: 0.720988762827659d), radius: 0.20071644392627364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8541327514239384d, y: 0.3739541137302913d), radius: 0.10615953499451347d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8785833249551603d, y: 0.8808994680131961d), radius: 0.8226754637713148d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40539113770247615d, y: 0.45412696062027d), radius: 0.9754536857225944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1852302828563902d, y: 0.07900468299720453d), radius: 0.8777097426104551d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5398171924951756d, y: 0.20607843742257992d), radius: 0.6155475091696118d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5792115547792491d, y: 0.5133621584808732d), radius: 0.609922913763262d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9639837220991885d, y: 0.1584027987844968d), radius: 0.10492565678849908d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.876011225384262d, y: 0.29058143578293427d), radius: 0.9690960374027272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8609043948034885d, y: 0.8525659904379984d), radius: 0.09113443933655752d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7556396540346791d, y: 0.9809024306201397d), radius: 0.5592002281216769d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08541377209175616d, y: 0.9514952367650705d), radius: 0.27614714410412333d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5735683617919873d, y: 0.7804000597183883d), radius: 0.9489021467606157d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9296760063225261d, y: 0.2730469194596168d), radius: 0.3775904103048153d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14011969247049927d, y: 0.20522457461166277d), radius: 0.9860014030273367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5847809641731474d, y: 0.036015208094337225d), radius: 0.14326700539511417d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3477703737028569d, y: 0.4432270350705043d), radius: 0.22963324240958405d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8892621595502048d, y: 0.6271043670317368d), radius: 0.4368269077209864d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5566118842138829d, y: 0.5397905337469351d), radius: 0.6462948575486918d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6867909333824334d, y: 0.4454470508355869d), radius: 0.8996036006520803d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7548018045492112d, y: 0.662450753332905d), radius: 0.10001946244143944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37961057889130145d, y: 0.33539330003461454d), radius: 0.9562390907355656d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24774006862406828d, y: 0.6027287021711133d), radius: 0.30503107559506126d),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.528449259713167d, y: 0.4941185943789451d), radius: 0.8466039300895813d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37053943152365554d, y: 0.8597219819757944d), radius: 0.9605805585386241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.994911079872413d, y: 0.1317272182056093d), radius: 0.40086740655730624d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016797914476698428d, y: 0.01166018729930729d), radius: 0.04225175855032359d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8430934349833004d, y: 0.525811061744404d), radius: 0.7990921201289205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6608859390562182d, y: 0.5158443163398788d), radius: 0.5494461486184643d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8513798118793322d, y: 0.5802666151459774d), radius: 0.5245259729319453d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9743338374162837d, y: 0.43287708317515405d), radius: 0.26337355744748714d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4401589921468988d, y: 0.5310859234621755d), radius: 0.7903604548472456d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3820692441498583d, y: 0.010616861086745977d), radius: 0.2851108482331902d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7091001494244928d, y: 0.7075452667115977d), radius: 0.8399430025951002d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.343020030257997d, y: 0.39619521480345665d), radius: 0.7231418441615144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32633107891004576d, y: 0.39936461694790293d), radius: 0.3445257085388199d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 88, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 135, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 87, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 51, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 63, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 5, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 33, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1M>(15);

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
                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

