

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
    internal partial interface INpgsqlPolygonListpolygonListD1
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonListD1 : INpgsqlPolygonListpolygonListD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonListD1E2M[] _testData = new NpgsqlPolygonpolygonListD1E2M[]
        {
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007665181900027629d, y: 0.2832060241082104d), new NpgsqlTypes.NpgsqlPoint(x: 0.4164820084322969d, y: 0.26166591697329666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3294170932776809d, y: 0.40881274891727626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7056257479184288d, y: 0.11869586560985679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4354076181761145d, y: 0.4881309599082603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457013325786201d, y: 0.6823360218641968d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.035101642170273784d, y: 0.16099856366829035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890588821427956d, y: 0.3227856643851973d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232679462959541d, y: 0.7037171882017004d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8886802787766653d, y: 0.9914863910820795d), new NpgsqlTypes.NpgsqlPoint(x: 0.21350762931620293d, y: 0.756092259925209d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654453811951717d, y: 0.1335587091734981d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8807072425048545d, y: 0.3073557879655364d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181572143964579d, y: 0.45318678548212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684061908704503d, y: 0.8942108754227354d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48702996046245506d, y: 0.008241658517415429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457892558388443d, y: 0.5938733347046514d), new NpgsqlTypes.NpgsqlPoint(x: 0.16346158725771598d, y: 0.5282139592181283d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5473543146639049d, y: 0.9148077892505719d), new NpgsqlTypes.NpgsqlPoint(x: 0.009346579020243051d, y: 0.035899885389574004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440705146352059d, y: 0.555033635532837d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6420120301772406d, y: 0.3902112482743687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3368055920607921d, y: 0.7823192293187813d), new NpgsqlTypes.NpgsqlPoint(x: 0.04376625178214255d, y: 0.4984566569859764d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2268387926080655d, y: 0.8974215083778284d), new NpgsqlTypes.NpgsqlPoint(x: 0.766128721636411d, y: 0.22773147437025465d), new NpgsqlTypes.NpgsqlPoint(x: 0.42012097645177804d, y: 0.0263396368106269d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.746980893158288d, y: 0.9693470949371288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857536396372809d, y: 0.5355728364633514d), new NpgsqlTypes.NpgsqlPoint(x: 0.719959181254078d, y: 0.3478971304597661d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7800149440800078d, y: 0.36608236411296013d), new NpgsqlTypes.NpgsqlPoint(x: 0.3731958460711309d, y: 0.9149236002212201d), new NpgsqlTypes.NpgsqlPoint(x: 0.7264960580129103d, y: 0.8942713003449425d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38270046448584016d, y: 0.49241040444565587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5983012583008728d, y: 0.7676580036128444d), new NpgsqlTypes.NpgsqlPoint(x: 0.44611573823744d, y: 0.9646573363050187d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3929849954240273d, y: 0.884496351397833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7344360175394493d, y: 0.7668595857020006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564977960272127d, y: 0.665045009400756d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28343954361018275d, y: 0.2748703681022925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523777798038336d, y: 0.012203910212294056d), new NpgsqlTypes.NpgsqlPoint(x: 0.055133926410075196d, y: 0.18638591470777843d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4404323995288786d, y: 0.7224273797967363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7620879807348528d, y: 0.13268717477910907d), new NpgsqlTypes.NpgsqlPoint(x: 0.2091839882266212d, y: 0.361786642015526d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3932853782455705d, y: 0.8925607920697464d), new NpgsqlTypes.NpgsqlPoint(x: 0.03011906539215259d, y: 0.8342359085073574d), new NpgsqlTypes.NpgsqlPoint(x: 0.1910000233022333d, y: 0.5137752347240248d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6150920806110238d, y: 0.8858588824851238d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735911191130131d, y: 0.7417433965555359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779728777466668d, y: 0.44885341573447934d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8069349945373289d, y: 0.337243348990686d), new NpgsqlTypes.NpgsqlPoint(x: 0.11483300259253482d, y: 0.1249901599404335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1809636229854117d, y: 0.8718598521526338d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8423701365364055d, y: 0.937819866623383d), new NpgsqlTypes.NpgsqlPoint(x: 0.10212211443648622d, y: 0.6138561929477558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517076524840201d, y: 0.9994921991240374d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021171335283501236d, y: 0.7548259321721252d), new NpgsqlTypes.NpgsqlPoint(x: 0.45374324304932034d, y: 0.6834147182050384d), new NpgsqlTypes.NpgsqlPoint(x: 0.665760816033401d, y: 0.6316658704296778d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003214390919689d, y: 0.8092664435218417d), new NpgsqlTypes.NpgsqlPoint(x: 0.09356364693032204d, y: 0.4620738984013941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932534925436711d, y: 0.5909758380129237d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9994141869231277d, y: 0.7614031603003018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9423433444127183d, y: 0.9237162594660062d), new NpgsqlTypes.NpgsqlPoint(x: 0.4784432732131113d, y: 0.8140325043471717d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7311481110957342d, y: 0.7440762529399052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7146924190560706d, y: 0.47000427712588955d), new NpgsqlTypes.NpgsqlPoint(x: 0.08811925537039211d, y: 0.26623646644819476d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.610536248425355d, y: 0.5577415965862229d), new NpgsqlTypes.NpgsqlPoint(x: 0.965660533326577d, y: 0.6416990412332776d), new NpgsqlTypes.NpgsqlPoint(x: 0.3697470305831603d, y: 0.2942364430705575d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2672196217397549d, y: 0.12350550138694094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531666034845962d, y: 0.6626707845633727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3502231146804343d, y: 0.5439461322652077d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23864021817267522d, y: 0.1382238420707006d), new NpgsqlTypes.NpgsqlPoint(x: 0.21196391697726769d, y: 0.7788064026938308d), new NpgsqlTypes.NpgsqlPoint(x: 0.19154683131757222d, y: 0.7942895975266169d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8229407346888977d, y: 0.4925894476116103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561315238534969d, y: 0.69793798258493d), new NpgsqlTypes.NpgsqlPoint(x: 0.052533853749834325d, y: 0.8651165868967482d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1438622741788932d, y: 0.007943178604639556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8682502468922009d, y: 0.6139936021054121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8181853521407134d, y: 0.5467192101161397d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.691521870923128d, y: 0.40434169645882223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464931427027477d, y: 0.10591582255239451d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756765528695406d, y: 0.6861895017462483d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6970151666458846d, y: 0.34005085025751713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7506929056094156d, y: 0.4441885941868333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5750350657890775d, y: 0.3662104312110246d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8341659375953342d, y: 0.3421146069475858d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241620020562427d, y: 0.24686687636801563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4481962812950252d, y: 0.82292041883232d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5569854986289011d, y: 0.3382874218315711d), new NpgsqlTypes.NpgsqlPoint(x: 0.581179826345358d, y: 0.6652479279141711d), new NpgsqlTypes.NpgsqlPoint(x: 0.05472534878115687d, y: 0.8814853283818758d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07138052141233586d, y: 0.3958639643526214d), new NpgsqlTypes.NpgsqlPoint(x: 0.29971497052599283d, y: 0.5277469712698025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051320299069001d, y: 0.48471639517724485d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8277605153394961d, y: 0.22050153312191234d), new NpgsqlTypes.NpgsqlPoint(x: 0.12580012143281483d, y: 0.4287050888914171d), new NpgsqlTypes.NpgsqlPoint(x: 0.2684647815140718d, y: 0.3438390838790155d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010791399572037452d, y: 0.2128471630612172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6131740514035867d, y: 0.5091482612552447d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803654890398065d, y: 0.7518745870746597d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23217676566898438d, y: 0.4338130699390774d), new NpgsqlTypes.NpgsqlPoint(x: 0.11417325059013095d, y: 0.14131535801159656d), new NpgsqlTypes.NpgsqlPoint(x: 0.31924037315732146d, y: 0.6572915941726644d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7001332243235139d, y: 0.8864349348609764d), new NpgsqlTypes.NpgsqlPoint(x: 0.29791362303637325d, y: 0.08838455564880154d), new NpgsqlTypes.NpgsqlPoint(x: 0.20362531822791485d, y: 0.049387044734612306d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05226973214885955d, y: 0.1457252841065486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900230179395532d, y: 0.46187195072659115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8727539083498893d, y: 0.9769814756374382d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.907688323139343d, y: 0.1797057625177464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624132370276967d, y: 0.5553279077902739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423117316002626d, y: 0.4985893049927268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04434408666012357d, y: 0.004339137537260118d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101745017300551d, y: 0.1286048847739567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9257294516437246d, y: 0.6410174543303298d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6082394811018403d, y: 0.24120668586925464d), new NpgsqlTypes.NpgsqlPoint(x: 0.001308984454877371d, y: 0.4974841529261561d), new NpgsqlTypes.NpgsqlPoint(x: 0.9977810335835394d, y: 0.7307232896646162d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813243522100199d, y: 0.7662973110079377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6919465502002903d, y: 0.04063865725747806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116694800346773d, y: 0.6675981942169344d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.029317276629970745d, y: 0.3865498989680356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294901926025536d, y: 0.4903403775921641d), new NpgsqlTypes.NpgsqlPoint(x: 0.9697339301575882d, y: 0.29939314860520794d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02202184993650136d, y: 0.7791168567654607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711071438381817d, y: 0.7264875194326195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3656781761471476d, y: 0.6656478901936752d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7651850174137838d, y: 0.504989710997416d), new NpgsqlTypes.NpgsqlPoint(x: 0.027083485703230825d, y: 0.78264456576518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964356640796096d, y: 0.7692018942889277d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15886018080074904d, y: 0.6096987314845603d), new NpgsqlTypes.NpgsqlPoint(x: 0.42967147307146336d, y: 0.9033433096770044d), new NpgsqlTypes.NpgsqlPoint(x: 0.20250302006797782d, y: 0.43902340019181796d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06987402009794497d, y: 0.5580816240018682d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797700899217303d, y: 0.25360851184918487d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590165715594478d, y: 0.7330824957143323d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8836123199190244d, y: 0.7527397909420322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649732610522629d, y: 0.7152869053256586d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740326260357168d, y: 0.5357669649848553d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0933383151841567d, y: 0.2229792501358442d), new NpgsqlTypes.NpgsqlPoint(x: 0.1425950402289179d, y: 0.2351446881284711d), new NpgsqlTypes.NpgsqlPoint(x: 0.046215575675346066d, y: 0.49256326367495795d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8959627800032757d, y: 0.7866960735442812d), new NpgsqlTypes.NpgsqlPoint(x: 0.8060449934058219d, y: 0.9143141307457039d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799968109806036d, y: 0.8813620672143097d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6471638856578987d, y: 0.4588363005939231d), new NpgsqlTypes.NpgsqlPoint(x: 0.13275297747918013d, y: 0.2878002331358067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664576891268853d, y: 0.30754166274842676d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9940720761286738d, y: 0.6262088168481773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469460745237735d, y: 0.8864787421961536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923313695739865d, y: 0.7467431967345608d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.999132401222042d, y: 0.795670586409365d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457230858556724d, y: 0.5248990595279515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677994180483841d, y: 0.37865996739640084d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19185410719164986d, y: 0.27329961618273246d), new NpgsqlTypes.NpgsqlPoint(x: 0.9585390292223407d, y: 0.09037005369145179d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131707104696337d, y: 0.9314458156462815d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6248443524046238d, y: 0.04329867676463528d), new NpgsqlTypes.NpgsqlPoint(x: 0.2145571359687687d, y: 0.28415564692475437d), new NpgsqlTypes.NpgsqlPoint(x: 0.003152360672755705d, y: 0.2960146482363193d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5002986450485576d, y: 0.38021353111724654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3072720483180824d, y: 0.20961128380975236d), new NpgsqlTypes.NpgsqlPoint(x: 0.354841983815555d, y: 0.10113711622313648d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7347280519791287d, y: 0.23009204574360465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9416986583048346d, y: 0.4327739201391507d), new NpgsqlTypes.NpgsqlPoint(x: 0.4479993127506672d, y: 0.9828172763770877d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.356798082622623d, y: 0.49877267427931615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124023746113944d, y: 0.9826245856561762d), new NpgsqlTypes.NpgsqlPoint(x: 0.971294897757004d, y: 0.3091750438545956d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13600604941481986d, y: 0.4395909859285302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7052919926375424d, y: 0.022759509280169787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292621919976271d, y: 0.44209410228167023d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6552170367336981d, y: 0.0006728739481958179d), new NpgsqlTypes.NpgsqlPoint(x: 0.29450111374319143d, y: 0.5294765937767065d), new NpgsqlTypes.NpgsqlPoint(x: 0.47145884095200086d, y: 0.875171931316584d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8756617203197347d, y: 0.870991903216045d), new NpgsqlTypes.NpgsqlPoint(x: 0.26622428095450734d, y: 0.12615173922250622d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738587134929361d, y: 0.7385716696109332d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.79886521983826d, y: 0.0821039391332411d), new NpgsqlTypes.NpgsqlPoint(x: 0.947548643294512d, y: 0.39001085160905613d), new NpgsqlTypes.NpgsqlPoint(x: 0.22237400370300342d, y: 0.8357741590009224d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08452242936382703d, y: 0.17335806763130424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7052235218882257d, y: 0.2759027629574362d), new NpgsqlTypes.NpgsqlPoint(x: 0.2859262905732398d, y: 0.48661534011448826d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6854363455476726d, y: 0.3376502007502278d), new NpgsqlTypes.NpgsqlPoint(x: 0.14415389803331702d, y: 0.41308197980680805d), new NpgsqlTypes.NpgsqlPoint(x: 0.34754222577428806d, y: 0.19524797004418126d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.537972534531327d, y: 0.07093225804104064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7908585484370224d, y: 0.23040869021496124d), new NpgsqlTypes.NpgsqlPoint(x: 0.448677979757622d, y: 0.3455454633274212d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1808958255382278d, y: 0.8101718571413935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335818049292937d, y: 0.13793629023873522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365699101112352d, y: 0.21263750539689008d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2792380383670414d, y: 0.0232090639041298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6484172001348858d, y: 0.6011929988301705d), new NpgsqlTypes.NpgsqlPoint(x: 0.09912583702878563d, y: 0.24560997803532658d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8347817622613566d, y: 0.9297894391165155d), new NpgsqlTypes.NpgsqlPoint(x: 0.26611949670489055d, y: 0.7562032825057593d), new NpgsqlTypes.NpgsqlPoint(x: 0.4940343184111916d, y: 0.4371849965731971d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28866432447221735d, y: 0.0020493294507850646d), new NpgsqlTypes.NpgsqlPoint(x: 0.011466035903715643d, y: 0.01707456197877044d), new NpgsqlTypes.NpgsqlPoint(x: 0.46687791926866584d, y: 0.22175466438090496d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19546342425989438d, y: 0.8931671786061173d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581147199487628d, y: 0.897861316657594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397398387518993d, y: 0.625486535988838d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7022552224703685d, y: 0.4084243718038181d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275556448052143d, y: 0.2957736768726823d), new NpgsqlTypes.NpgsqlPoint(x: 0.5360915634443157d, y: 0.2844330101490322d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09195582286167436d, y: 0.7577180170913396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743772294243957d, y: 0.21587778637184785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913045223661938d, y: 0.6068858404664369d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3476993288314405d, y: 0.19655346941880847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570551681421449d, y: 0.980916958433484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9315866382869596d, y: 0.4431588585779187d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8931925338640695d, y: 0.4956053612270942d), new NpgsqlTypes.NpgsqlPoint(x: 0.08481799752152397d, y: 0.21329839469963197d), new NpgsqlTypes.NpgsqlPoint(x: 0.1803083304708134d, y: 0.1882015987390303d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5899080797100568d, y: 0.14158941092570698d), new NpgsqlTypes.NpgsqlPoint(x: 0.441821862585692d, y: 0.17202238914743984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8716213785500558d, y: 0.9331923677211151d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15268714254898685d, y: 0.432110782889744d), new NpgsqlTypes.NpgsqlPoint(x: 0.47290865067466403d, y: 0.8231564589410434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880976718523733d, y: 0.48775120478320744d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1340173996527928d, y: 0.23930931128161925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894001506619335d, y: 0.04192645242802007d), new NpgsqlTypes.NpgsqlPoint(x: 0.3137518906824148d, y: 0.19734266987527838d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6664815693973187d, y: 0.8109081980954624d), new NpgsqlTypes.NpgsqlPoint(x: 0.497522803453629d, y: 0.033074790372020435d), new NpgsqlTypes.NpgsqlPoint(x: 0.46218555946871887d, y: 0.8814173801268443d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7772525532331245d, y: 0.012920653144061323d), new NpgsqlTypes.NpgsqlPoint(x: 0.6696032880085797d, y: 0.23400353161088672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876857368018842d, y: 0.20948390031662234d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.587184426979749d, y: 0.05779837867084847d), new NpgsqlTypes.NpgsqlPoint(x: 0.24022356440934423d, y: 0.08047351145555415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6034170071990494d, y: 0.5332585669937323d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7798558465889659d, y: 0.8904771569979225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5773157352968176d, y: 0.9007421485351305d), new NpgsqlTypes.NpgsqlPoint(x: 0.34851883966487807d, y: 0.5182701366723099d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1463794380335276d, y: 0.6818502708917018d), new NpgsqlTypes.NpgsqlPoint(x: 0.13003674422723388d, y: 0.23344125186443265d), new NpgsqlTypes.NpgsqlPoint(x: 0.03150402724360524d, y: 0.6278830456836867d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0725321019785019d, y: 0.7404926334845923d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861412802826462d, y: 0.3317334846996548d), new NpgsqlTypes.NpgsqlPoint(x: 0.011400787734545337d, y: 0.8155365397836901d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3907872922055369d, y: 0.8618660467160639d), new NpgsqlTypes.NpgsqlPoint(x: 0.16150314067904603d, y: 0.42075666018545854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8246713375573312d, y: 0.8931268363413741d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4036143871945198d, y: 0.6893930288927799d), new NpgsqlTypes.NpgsqlPoint(x: 0.42688096935201125d, y: 0.646686245457291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768209270593091d, y: 0.05702442547574649d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8584650348151476d, y: 0.7681596673102521d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420574912887081d, y: 0.9479731687152242d), new NpgsqlTypes.NpgsqlPoint(x: 0.024170279943805162d, y: 0.10883331100399973d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7895164527035272d, y: 0.7269671238066193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5968451555604518d, y: 0.8652995905713001d), new NpgsqlTypes.NpgsqlPoint(x: 0.13640282234380063d, y: 0.11874588548170106d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0713717794675286d, y: 0.3773782403509244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351452690625265d, y: 0.15578620078218797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9933599279301008d, y: 0.09635265644148994d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24242308229838072d, y: 0.0359701925388376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594383431627881d, y: 0.7266151999728365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3949693405793443d, y: 0.5594885149191616d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5182320890478754d, y: 0.41693582483201275d), new NpgsqlTypes.NpgsqlPoint(x: 0.790418023417198d, y: 0.7119008853674038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178104359455188d, y: 0.032641277039757166d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6646916165655812d, y: 0.44801014645894366d), new NpgsqlTypes.NpgsqlPoint(x: 0.42448104417455657d, y: 0.20938624828516184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536584087847938d, y: 0.15282503080491494d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2588780948370971d, y: 0.7709494968159506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563700055964732d, y: 0.3630357605008011d), new NpgsqlTypes.NpgsqlPoint(x: 0.806319786679756d, y: 0.7115522484094374d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09804583052588256d, y: 0.13127160827089135d), new NpgsqlTypes.NpgsqlPoint(x: 0.4422922073353597d, y: 0.5750372635609508d), new NpgsqlTypes.NpgsqlPoint(x: 0.30230885808054053d, y: 0.6525204597082123d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32285855473911684d, y: 0.2370764064278924d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871495782496737d, y: 0.16416115803265185d), new NpgsqlTypes.NpgsqlPoint(x: 0.3849403390287317d, y: 0.4590628130330293d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1844915072645379d, y: 0.09502207247074812d), new NpgsqlTypes.NpgsqlPoint(x: 0.33054506708146114d, y: 0.36008950923786276d), new NpgsqlTypes.NpgsqlPoint(x: 0.5149107451454704d, y: 0.14408608838123715d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9376141578671211d, y: 0.8225367107946987d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635238315399295d, y: 0.09790642178668307d), new NpgsqlTypes.NpgsqlPoint(x: 0.17627680285588854d, y: 0.242478283404421d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09682085218230674d, y: 0.5644653350080784d), new NpgsqlTypes.NpgsqlPoint(x: 0.022428481515793464d, y: 0.5800930200876842d), new NpgsqlTypes.NpgsqlPoint(x: 0.15968403327119496d, y: 0.545457680726748d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2756130256877124d, y: 0.44558590140301413d), new NpgsqlTypes.NpgsqlPoint(x: 0.6007693871889375d, y: 0.26413327368437867d), new NpgsqlTypes.NpgsqlPoint(x: 0.39239754117715586d, y: 0.779527490454842d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3699514994453714d, y: 0.9663768551319745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497112576191197d, y: 0.8235238822693826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319478486961342d, y: 0.48664572219468116d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3154050239110663d, y: 0.5844192312008937d), new NpgsqlTypes.NpgsqlPoint(x: 0.838670151036861d, y: 0.22499653610375026d), new NpgsqlTypes.NpgsqlPoint(x: 0.669302117039529d, y: 0.5669836097962203d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12202405444461562d, y: 0.653380326669798d), new NpgsqlTypes.NpgsqlPoint(x: 0.02367850905516622d, y: 0.253539559305639d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613342294939796d, y: 0.6734071755252632d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6586865904350303d, y: 0.12539631764344772d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943280365658611d, y: 0.5142384502649266d), new NpgsqlTypes.NpgsqlPoint(x: 0.21039353246448866d, y: 0.8221896906857807d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29963565538899883d, y: 0.9883935890976919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394734490653613d, y: 0.5811474980711359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378245751011714d, y: 0.7193630797003052d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28669115407588364d, y: 0.8422519427190174d), new NpgsqlTypes.NpgsqlPoint(x: 0.6501038630251376d, y: 0.29963970284011d), new NpgsqlTypes.NpgsqlPoint(x: 0.1654080440127127d, y: 0.36988471041029847d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21911792605395441d, y: 0.22340894241866027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172862129833311d, y: 0.645836074950714d), new NpgsqlTypes.NpgsqlPoint(x: 0.16961794925856655d, y: 0.06136222566253835d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6259029177791047d, y: 0.544547000849756d), new NpgsqlTypes.NpgsqlPoint(x: 0.8916421454439484d, y: 0.5786536065278877d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388089913454637d, y: 0.6468988476085392d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6592844365231747d, y: 0.19652993990751222d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599588456514024d, y: 0.7175412969638381d), new NpgsqlTypes.NpgsqlPoint(x: 0.12441050433114542d, y: 0.1335525578571698d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15326361246770037d, y: 0.2337107619470108d), new NpgsqlTypes.NpgsqlPoint(x: 0.006109846755803283d, y: 0.733610542187781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891694790220872d, y: 0.23665283081982136d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6149625956575848d, y: 0.19243347552802348d), new NpgsqlTypes.NpgsqlPoint(x: 0.04949041457194825d, y: 0.04595655121570008d), new NpgsqlTypes.NpgsqlPoint(x: 0.07307099147704144d, y: 0.14420704636936676d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3560365110021516d, y: 0.03773999358178226d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866732549294195d, y: 0.8451933576686289d), new NpgsqlTypes.NpgsqlPoint(x: 0.39490361893728954d, y: 0.4945767096162549d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8039926417260455d, y: 0.9715995727105965d), new NpgsqlTypes.NpgsqlPoint(x: 0.09962524667432382d, y: 0.4494945012743784d), new NpgsqlTypes.NpgsqlPoint(x: 0.2804185348308529d, y: 0.12386274110011442d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8806651201857655d, y: 0.4619331027944382d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759590744016665d, y: 0.9631069746418375d), new NpgsqlTypes.NpgsqlPoint(x: 0.3080849978898629d, y: 0.08707589883535116d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16173350118939667d, y: 0.30951074450599403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143062984765594d, y: 0.5553796033422136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749864458433815d, y: 0.3892034355113183d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8445397098428528d, y: 0.08939649911969216d), new NpgsqlTypes.NpgsqlPoint(x: 0.41831346697238425d, y: 0.4375163465593628d), new NpgsqlTypes.NpgsqlPoint(x: 0.668428747879035d, y: 0.929348186826505d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7033003215252936d, y: 0.41607383811963616d), new NpgsqlTypes.NpgsqlPoint(x: 0.45613508000855796d, y: 0.3010672277298658d), new NpgsqlTypes.NpgsqlPoint(x: 0.11464647263320937d, y: 0.677602218245663d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10841701852745522d, y: 0.03010717972858712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989761989162838d, y: 0.49008004205950406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062093991681158d, y: 0.4919865260975196d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4123408524778066d, y: 0.8090745547284813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5739567359128074d, y: 0.9454221161903185d), new NpgsqlTypes.NpgsqlPoint(x: 0.07299213162855223d, y: 0.7690868562824016d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012235895848752731d, y: 0.7246128431611458d), new NpgsqlTypes.NpgsqlPoint(x: 0.8620261897406174d, y: 0.908644441231317d), new NpgsqlTypes.NpgsqlPoint(x: 0.31788340869006826d, y: 0.465714947850721d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3757388087583182d, y: 0.6337556783453677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969867115241054d, y: 0.3645467159690541d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575398470554535d, y: 0.8684242782501874d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3274039409007833d, y: 0.2721164880436151d), new NpgsqlTypes.NpgsqlPoint(x: 0.3224342704406462d, y: 0.6059716687135028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335417890391709d, y: 0.8512175563681456d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7481109512795816d, y: 0.03366857039498039d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026936884367142d, y: 0.007207480836679658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250270178438469d, y: 0.6711655737028072d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6145846076503011d, y: 0.9942912489566634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396319923870087d, y: 0.9165141509840226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853217995671127d, y: 0.5333184502216983d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9898264843859075d, y: 0.010358578304295873d), new NpgsqlTypes.NpgsqlPoint(x: 0.011667573546199739d, y: 0.4731292667364402d), new NpgsqlTypes.NpgsqlPoint(x: 0.31035131840380514d, y: 0.31984585212221206d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40186414020236194d, y: 0.10958649728834369d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385373366580425d, y: 0.16043053985742495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3707069038939661d, y: 0.5311521895458243d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4558570646170643d, y: 0.7112133229747769d), new NpgsqlTypes.NpgsqlPoint(x: 0.17369447024474483d, y: 0.36402288041369946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747957441673074d, y: 0.8191648907049324d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.528432110414822d, y: 0.9451638231019468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9976019418469415d, y: 0.5937127725560728d), new NpgsqlTypes.NpgsqlPoint(x: 0.04892026962895624d, y: 0.9211026425111779d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.026660214540145d, y: 0.3070596913236763d), new NpgsqlTypes.NpgsqlPoint(x: 0.28244577531733994d, y: 0.7687114240458434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337805221733889d, y: 0.08225196371928845d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18660252305067482d, y: 0.13807744041442938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896143868941589d, y: 0.5479750720575782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868513641137098d, y: 0.23539026501207672d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5708510745548627d, y: 0.9640928018786455d), new NpgsqlTypes.NpgsqlPoint(x: 0.16527256167249904d, y: 0.9766173596375087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273274176574593d, y: 0.7027561757311985d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.945559521789289d, y: 0.5859117010136106d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987792768309627d, y: 0.20182073823714475d), new NpgsqlTypes.NpgsqlPoint(x: 0.4147982075030575d, y: 0.9087626786393368d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3914497803105975d, y: 0.8926213383699083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827461244715854d, y: 0.5040569298378617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822487152563206d, y: 0.7408296085553248d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10531273407397002d, y: 0.9850093482820094d), new NpgsqlTypes.NpgsqlPoint(x: 0.28111511075023365d, y: 0.05691278004882783d), new NpgsqlTypes.NpgsqlPoint(x: 0.6819039377567268d, y: 0.4748013388116289d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27027938315143085d, y: 0.4671490050290966d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914585246212198d, y: 0.3740160505119027d), new NpgsqlTypes.NpgsqlPoint(x: 0.09973074538044269d, y: 0.9224246718849756d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12454734339767415d, y: 0.45930236613271247d), new NpgsqlTypes.NpgsqlPoint(x: 0.21703080511046025d, y: 0.389443554004259d), new NpgsqlTypes.NpgsqlPoint(x: 0.305770445154939d, y: 0.6435766969911757d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.998449752982763d, y: 0.03725030930379636d), new NpgsqlTypes.NpgsqlPoint(x: 0.46345765471220135d, y: 0.6828566741331329d), new NpgsqlTypes.NpgsqlPoint(x: 0.1844081297962289d, y: 0.9925833131731372d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14863921157828341d, y: 0.32412407929556897d), new NpgsqlTypes.NpgsqlPoint(x: 0.03342194947831567d, y: 0.7544121661224372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112517233803619d, y: 0.7812672375539002d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6429880846351005d, y: 0.6591405554870718d), new NpgsqlTypes.NpgsqlPoint(x: 0.40766253599383473d, y: 0.9782555731605533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178272153144196d, y: 0.3562575552137428d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41685155887245773d, y: 0.20357403135789787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5144177955864847d, y: 0.07060482055261563d), new NpgsqlTypes.NpgsqlPoint(x: 0.319654339364872d, y: 0.9571542736087492d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9169343625244238d, y: 0.3479828755938552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613026087284281d, y: 0.4691702234479158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222915050413852d, y: 0.510248999243988d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8486309209162076d, y: 0.4576614661406806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176092244090584d, y: 0.22800649846003185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635315132809689d, y: 0.6183858176208458d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8669764896022204d, y: 0.395132699270072d), new NpgsqlTypes.NpgsqlPoint(x: 0.07958635454040963d, y: 0.7650794640854113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6052342701268425d, y: 0.08059328687119904d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17005706513352503d, y: 0.7511927613499624d), new NpgsqlTypes.NpgsqlPoint(x: 0.28093485824256814d, y: 0.754126933891959d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164696431349749d, y: 0.6650895256432792d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28682592079021474d, y: 0.1958713391315008d), new NpgsqlTypes.NpgsqlPoint(x: 0.36532674114069785d, y: 0.009037189255427736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692465250103358d, y: 0.610301444799691d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8561050019148686d, y: 0.6848465120822025d), new NpgsqlTypes.NpgsqlPoint(x: 0.38953095022122597d, y: 0.21344474172271377d), new NpgsqlTypes.NpgsqlPoint(x: 0.664834048962283d, y: 0.39884207946299055d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6451654358186545d, y: 0.5138055963161393d), new NpgsqlTypes.NpgsqlPoint(x: 0.37322735636385074d, y: 0.807827012523864d), new NpgsqlTypes.NpgsqlPoint(x: 0.16972156276772976d, y: 0.8411696307556699d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6786081553810898d, y: 0.9949876228953736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6831408352815106d, y: 0.5768778958547658d), new NpgsqlTypes.NpgsqlPoint(x: 0.25986414317775963d, y: 0.6189193512430577d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07294250074430453d, y: 0.9418557967706446d), new NpgsqlTypes.NpgsqlPoint(x: 0.2147883119794015d, y: 0.6211104500725383d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182968265939928d, y: 0.5355304305790162d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07358253202087206d, y: 0.6109364322744071d), new NpgsqlTypes.NpgsqlPoint(x: 0.5400721594461183d, y: 0.27920488734981164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7481917163930359d, y: 0.7692681553101279d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23387540978171972d, y: 0.6175995803010769d), new NpgsqlTypes.NpgsqlPoint(x: 0.013906479907369151d, y: 0.7393985045996653d), new NpgsqlTypes.NpgsqlPoint(x: 0.1712798267813883d, y: 0.16898887118258576d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.917130843079899d, y: 0.5442616459654676d), new NpgsqlTypes.NpgsqlPoint(x: 0.461688931671803d, y: 0.07745846330348527d), new NpgsqlTypes.NpgsqlPoint(x: 0.5583725234680837d, y: 0.3512841169096764d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6926181411266462d, y: 0.47366970747502135d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106579608444059d, y: 0.6248837419059128d), new NpgsqlTypes.NpgsqlPoint(x: 0.7195966421595938d, y: 0.16336771329638133d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42065363617845697d, y: 0.8339536754168783d), new NpgsqlTypes.NpgsqlPoint(x: 0.29942348183289735d, y: 0.5608677052821744d), new NpgsqlTypes.NpgsqlPoint(x: 0.4343457834711054d, y: 0.06268613446975202d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21000757961099448d, y: 0.531193572501822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085779325103662d, y: 0.5424831577418359d), new NpgsqlTypes.NpgsqlPoint(x: 0.7494990686718915d, y: 0.44573319358246954d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5347816193106077d, y: 0.0010757873430510267d), new NpgsqlTypes.NpgsqlPoint(x: 0.061704452653980946d, y: 0.8365659968770296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900058249865078d, y: 0.4608572611346402d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1455339929773407d, y: 0.9374664333970794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942486205589985d, y: 0.21274365302242693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199203261649107d, y: 0.9083879786461857d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7474785189421115d, y: 0.6027858618171511d), new NpgsqlTypes.NpgsqlPoint(x: 0.5241035312373394d, y: 0.4761303869002199d), new NpgsqlTypes.NpgsqlPoint(x: 0.29311779203115207d, y: 0.051820029214243d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5246035805838157d, y: 0.23857498795010623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8392608949722367d, y: 0.4049966158770354d), new NpgsqlTypes.NpgsqlPoint(x: 0.07882474391489858d, y: 0.5706323581066518d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14649468278603228d, y: 0.6400121752869634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191764391403878d, y: 0.2981098787504065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171211453101163d, y: 0.0968711384599209d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7257694924976772d, y: 0.42220910559889224d), new NpgsqlTypes.NpgsqlPoint(x: 0.0930414133704418d, y: 0.8736282140910064d), new NpgsqlTypes.NpgsqlPoint(x: 0.607409126406389d, y: 0.8916215381862239d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.515419541670562d, y: 0.8835246157106637d), new NpgsqlTypes.NpgsqlPoint(x: 0.40941624394341425d, y: 0.4956582426071793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8228570683637595d, y: 0.19193002462851239d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6266245970047362d, y: 0.12156169338411138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334381740492149d, y: 0.9397811386588382d), new NpgsqlTypes.NpgsqlPoint(x: 0.21168850941296324d, y: 0.042609442351951965d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.799806456126337d, y: 0.8504095759540176d), new NpgsqlTypes.NpgsqlPoint(x: 0.16887645348508928d, y: 0.011569115659900597d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399432353242066d, y: 0.7407096772527879d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05148212269109276d, y: 0.49818814920155685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9459386166376089d, y: 0.7816226894062037d), new NpgsqlTypes.NpgsqlPoint(x: 0.9172913827755578d, y: 0.21057656749045017d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9813401910645595d, y: 0.4834753797157567d), new NpgsqlTypes.NpgsqlPoint(x: 0.21316709974598502d, y: 0.35319246962963646d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933261837974587d, y: 0.30258285926519823d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7696353671842137d, y: 0.5142627916422484d), new NpgsqlTypes.NpgsqlPoint(x: 0.021460141288447976d, y: 0.9114974872760021d), new NpgsqlTypes.NpgsqlPoint(x: 0.3799526971022821d, y: 0.25254296327594616d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8527602151599819d, y: 0.04252776457287277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7493786720835502d, y: 0.194490512496016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535936687691683d, y: 0.473562205494347d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8719662381009156d, y: 0.13542898114744328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3341049885146714d, y: 0.5845120623908386d), new NpgsqlTypes.NpgsqlPoint(x: 0.018444792211784855d, y: 0.2498814802072703d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9444633608077975d, y: 0.6266466598872599d), new NpgsqlTypes.NpgsqlPoint(x: 0.08352238310730342d, y: 0.650603525067199d), new NpgsqlTypes.NpgsqlPoint(x: 0.21326899330786797d, y: 0.7098262359314054d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8757695376546257d, y: 0.3127148248354561d), new NpgsqlTypes.NpgsqlPoint(x: 0.47015097973129627d, y: 0.06012650341132908d), new NpgsqlTypes.NpgsqlPoint(x: 0.8318953980151967d, y: 0.09623048121421096d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2716279822945895d, y: 0.7038469596554312d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404749835843253d, y: 0.24144274665558962d), new NpgsqlTypes.NpgsqlPoint(x: 0.24041478112709114d, y: 0.6486964691586753d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8244001158198071d, y: 0.6203704760303468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583700714671819d, y: 0.5818486053664119d), new NpgsqlTypes.NpgsqlPoint(x: 0.3450092610802429d, y: 0.6883206104950228d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9027857944866534d, y: 0.6747444028528186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171672470839355d, y: 0.3898719980387768d), new NpgsqlTypes.NpgsqlPoint(x: 0.4414723162947184d, y: 0.5105454768870589d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03640031302855129d, y: 0.30550061729627986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5620675995168446d, y: 0.3553827421410417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326882169098554d, y: 0.5706943170977964d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7907660134103714d, y: 0.9610441076674977d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108273858206414d, y: 0.7200912769496475d), new NpgsqlTypes.NpgsqlPoint(x: 0.01318978214504185d, y: 0.7318760669449903d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3326616115585638d, y: 0.9625052251645987d), new NpgsqlTypes.NpgsqlPoint(x: 0.3805189805486643d, y: 0.20086892898788644d), new NpgsqlTypes.NpgsqlPoint(x: 0.12564266316031591d, y: 0.7587826742811897d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5382747407878831d, y: 0.311616009725855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8603781886335848d, y: 0.014277326819139513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544699536580074d, y: 0.4921801662117983d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5001605733015584d, y: 0.9644083409017453d), new NpgsqlTypes.NpgsqlPoint(x: 0.1495771166908545d, y: 0.87809366371667d), new NpgsqlTypes.NpgsqlPoint(x: 0.007037655871828363d, y: 0.9073439202776564d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5583924780953574d, y: 0.1072257210842148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627384724783774d, y: 0.3573037036102994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9141401821222119d, y: 0.3136422715756101d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3745953695999755d, y: 0.6510978905343353d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206403097884633d, y: 0.41033774879590845d), new NpgsqlTypes.NpgsqlPoint(x: 0.21155138083040548d, y: 0.6443082904087446d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7796974523564203d, y: 0.040039333430123225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410944058509987d, y: 0.8659730478702337d), new NpgsqlTypes.NpgsqlPoint(x: 0.11683088848450196d, y: 0.07275486425782418d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2717267924428357d, y: 0.7592457038970708d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274874313593338d, y: 0.6309886422265897d), new NpgsqlTypes.NpgsqlPoint(x: 0.88737876324461d, y: 0.0615799036206226d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7769025457934768d, y: 0.39194366713123063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117979344579594d, y: 0.08865486138108358d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192792468284648d, y: 0.9365517757172042d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.637510595175925d, y: 0.3712686768160288d), new NpgsqlTypes.NpgsqlPoint(x: 0.18433034580966867d, y: 0.27084388073695753d), new NpgsqlTypes.NpgsqlPoint(x: 0.288982031411415d, y: 0.6122667688822112d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.574573857422399d, y: 0.2849679564328491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9119289434725524d, y: 0.8551030625168639d), new NpgsqlTypes.NpgsqlPoint(x: 0.479775374249917d, y: 0.5948484809026275d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9497975852262593d, y: 0.6090161771134712d), new NpgsqlTypes.NpgsqlPoint(x: 0.944792144094724d, y: 0.6725380814938617d), new NpgsqlTypes.NpgsqlPoint(x: 0.832138682162312d, y: 0.6759554339130784d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4924560396363288d, y: 0.7240109498492471d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999149224898545d, y: 0.5191787924550556d), new NpgsqlTypes.NpgsqlPoint(x: 0.23882739996739477d, y: 0.590667900847511d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16597962560186408d, y: 0.9426861392008445d), new NpgsqlTypes.NpgsqlPoint(x: 0.013933943282191996d, y: 0.5691501741126211d), new NpgsqlTypes.NpgsqlPoint(x: 0.1594743635368182d, y: 0.6364755890446245d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8877387587714596d, y: 0.048641061638049155d), new NpgsqlTypes.NpgsqlPoint(x: 0.4269882499719112d, y: 0.8502257007715873d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005699802287220113d, y: 0.9277017424759447d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2186711374052014d, y: 0.3611842546386054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9721290591643411d, y: 0.2928264268631027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082232522811916d, y: 0.6864168467847087d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5817160529459477d, y: 0.09081471503139182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2857493012104497d, y: 0.27929638452696826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485176423210028d, y: 0.8148600148106189d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.667686983987376d, y: 0.9345680712267036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2582580488324622d, y: 0.21631920770246105d), new NpgsqlTypes.NpgsqlPoint(x: 0.19989379101226135d, y: 0.5150026462186321d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12625538788423063d, y: 0.37426099634830057d), new NpgsqlTypes.NpgsqlPoint(x: 0.6909151776692052d, y: 0.5451528404869594d), new NpgsqlTypes.NpgsqlPoint(x: 0.22047242462148464d, y: 0.5241188116890865d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.039649223377073994d, y: 0.005137299116003802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3562306278871803d, y: 0.9764867793293377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303079599324185d, y: 0.9799108957400723d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2538026672979057d, y: 0.3183864061365441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722874667236098d, y: 0.3874078011458514d), new NpgsqlTypes.NpgsqlPoint(x: 0.13961723541984994d, y: 0.31070536263221915d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05860239164110237d, y: 0.23714360693235836d), new NpgsqlTypes.NpgsqlPoint(x: 0.45373659763140983d, y: 0.009878432377625534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5886609185889825d, y: 0.7103224360063445d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43369937172386896d, y: 0.48128061784012843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024692211786381d, y: 0.06737942421267962d), new NpgsqlTypes.NpgsqlPoint(x: 0.07668007857102355d, y: 0.3268183858796341d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16368572737139364d, y: 0.3538858442295739d), new NpgsqlTypes.NpgsqlPoint(x: 0.12851265681410184d, y: 0.190104021902057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5802436379764984d, y: 0.1800728826700181d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5680712765780815d, y: 0.19191688185555267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4513610553502042d, y: 0.7915270926918572d), new NpgsqlTypes.NpgsqlPoint(x: 0.2835803009811766d, y: 0.17253353825638829d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41595775875174246d, y: 0.9950052499477263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2300697569750051d, y: 0.14088974827970324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462001867025459d, y: 0.031600383424769674d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5095651246726396d, y: 0.7988560706854948d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401709163599894d, y: 0.2961648383096853d), new NpgsqlTypes.NpgsqlPoint(x: 0.790603119471599d, y: 0.11056386242245075d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15077864705950528d, y: 0.25410596534583374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628866545598474d, y: 0.4763422649302609d), new NpgsqlTypes.NpgsqlPoint(x: 0.08139002037296494d, y: 0.2002628965268186d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3763478288239356d, y: 0.4739946753294849d), new NpgsqlTypes.NpgsqlPoint(x: 0.4469203577104002d, y: 0.4337525197451616d), new NpgsqlTypes.NpgsqlPoint(x: 0.23453940580006916d, y: 0.36862119344108546d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09800331745629975d, y: 0.8990962275436118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445462548639942d, y: 0.601116941326867d), new NpgsqlTypes.NpgsqlPoint(x: 0.4042251591905778d, y: 0.6847653382372454d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5152655856456143d, y: 0.9087976584799592d), new NpgsqlTypes.NpgsqlPoint(x: 0.36883822043931414d, y: 0.7218876892163925d), new NpgsqlTypes.NpgsqlPoint(x: 0.31379294955595116d, y: 0.9166880237807119d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6507495370546398d, y: 0.8923007344830267d), new NpgsqlTypes.NpgsqlPoint(x: 0.2173677609710647d, y: 0.47654866034104304d), new NpgsqlTypes.NpgsqlPoint(x: 0.3033249192615436d, y: 0.0923662649235073d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05175827013635237d, y: 0.7507020936423666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077413285588273d, y: 0.6069166541245632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226222753768643d, y: 0.29005259403922967d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5191486679486693d, y: 0.6490783307154625d), new NpgsqlTypes.NpgsqlPoint(x: 0.07436653705984886d, y: 0.8750471035419408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694540275200774d, y: 0.35508333405438264d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7463907430930868d, y: 0.09900497405017017d), new NpgsqlTypes.NpgsqlPoint(x: 0.4345250475614678d, y: 0.7025026408313607d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288870714789763d, y: 0.8165610858498673d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19046328568160298d, y: 0.5602934833773593d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871168308987182d, y: 0.125536551887385d), new NpgsqlTypes.NpgsqlPoint(x: 0.42454129015879527d, y: 0.43961890462970055d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4922159424295274d, y: 0.15028095044869916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5029814407241522d, y: 0.9105940251807064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307492425230329d, y: 0.21915395200562426d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8620827079545819d, y: 0.23450595624789838d), new NpgsqlTypes.NpgsqlPoint(x: 0.246551623529481d, y: 0.0535756084773189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790896061007569d, y: 0.09925032976743087d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9112974221725177d, y: 0.7829370515499849d), new NpgsqlTypes.NpgsqlPoint(x: 0.03001232510875229d, y: 0.23662393573079965d), new NpgsqlTypes.NpgsqlPoint(x: 0.78592743179579d, y: 0.25724668190843936d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8794793202099581d, y: 0.08293049538424724d), new NpgsqlTypes.NpgsqlPoint(x: 0.4887358146307087d, y: 0.8984705294208263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9896991110444399d, y: 0.20676601595026123d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.450096066812931d, y: 0.3717560580667467d), new NpgsqlTypes.NpgsqlPoint(x: 0.007639782055193112d, y: 0.8114341012104194d), new NpgsqlTypes.NpgsqlPoint(x: 0.22164349281463236d, y: 0.27984274126477227d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6509429433323188d, y: 0.716559122414528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278751337636122d, y: 0.5582471800138966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1792190863414217d, y: 0.7229496910189805d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.077683901353362d, y: 0.4017046657049749d), new NpgsqlTypes.NpgsqlPoint(x: 0.2519782686139096d, y: 0.5420509824936433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656902715345326d, y: 0.3102168732919377d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870023753238764d, y: 0.3020446760694081d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194991828000242d, y: 0.8386519967595082d), new NpgsqlTypes.NpgsqlPoint(x: 0.5034550817082113d, y: 0.3621555051163775d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26765631908300314d, y: 0.37961224815467665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6000329015642445d, y: 0.6462554142091153d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676293693973771d, y: 0.7082863003948942d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8822144804583362d, y: 0.7716001175078016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993833114136387d, y: 0.7368599852846694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249871340024803d, y: 0.03580760381413384d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23393148468727676d, y: 0.1167500280330177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3287889609093989d, y: 0.929618097703077d), new NpgsqlTypes.NpgsqlPoint(x: 0.1599021710986953d, y: 0.4286431455549773d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019880099911940285d, y: 0.209244949559369d), new NpgsqlTypes.NpgsqlPoint(x: 0.5588500936519568d, y: 0.524103198410001d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590726232532603d, y: 0.841549789567031d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9661162410004311d, y: 0.2644018768395634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9368014696650788d, y: 0.8546045221339938d), new NpgsqlTypes.NpgsqlPoint(x: 0.47681059053041697d, y: 0.5640456156810675d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07514762512679296d, y: 0.5836357074661398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506607548445112d, y: 0.7188543888663025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499092087017129d, y: 0.31635774292236896d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9769922241223502d, y: 0.6197313581516307d), new NpgsqlTypes.NpgsqlPoint(x: 0.597169292833071d, y: 0.6759681488149044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397344695528044d, y: 0.405897092420871d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3686691102859272d, y: 0.44910310399608366d), new NpgsqlTypes.NpgsqlPoint(x: 0.9478394228157927d, y: 0.4192219305922159d), new NpgsqlTypes.NpgsqlPoint(x: 0.307473470633006d, y: 0.07943143734257996d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5142742495395448d, y: 0.9967705694310028d), new NpgsqlTypes.NpgsqlPoint(x: 0.0985845368318169d, y: 0.893174234369482d), new NpgsqlTypes.NpgsqlPoint(x: 0.04618919399183807d, y: 0.9070894521516852d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6002001394185345d, y: 0.44383570444647324d), new NpgsqlTypes.NpgsqlPoint(x: 0.48233773301839056d, y: 0.636409814777022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184537743945242d, y: 0.6706922585432391d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43348337844226914d, y: 0.14111210776017347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275932366921464d, y: 0.8383284063666372d), new NpgsqlTypes.NpgsqlPoint(x: 0.37333465999677906d, y: 0.5660473405108942d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5642516597601475d, y: 0.458305027858821d), new NpgsqlTypes.NpgsqlPoint(x: 0.6523701662741999d, y: 0.44945486530382395d), new NpgsqlTypes.NpgsqlPoint(x: 0.08256214314815158d, y: 0.844337433434626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9095028972981684d, y: 0.3376835070388904d), new NpgsqlTypes.NpgsqlPoint(x: 0.636309209170217d, y: 0.18843387833951197d), new NpgsqlTypes.NpgsqlPoint(x: 0.3130547340143145d, y: 0.15243512779851154d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09676546642527328d, y: 0.6534588968093125d), new NpgsqlTypes.NpgsqlPoint(x: 0.484203245155859d, y: 0.34743242521439743d), new NpgsqlTypes.NpgsqlPoint(x: 0.31152227022287293d, y: 0.6571103868109077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333977842142599d, y: 0.32315053425095797d), new NpgsqlTypes.NpgsqlPoint(x: 0.896681168775677d, y: 0.6380088766685413d), new NpgsqlTypes.NpgsqlPoint(x: 0.03927537183185503d, y: 0.3228394534939323d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0295678198390813d, y: 0.7648645211622581d), new NpgsqlTypes.NpgsqlPoint(x: 0.12588058280858605d, y: 0.13526926962069974d), new NpgsqlTypes.NpgsqlPoint(x: 0.37157846200878364d, y: 0.7378408539505695d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6625415753358589d, y: 0.8833113783500415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765527635726545d, y: 0.3257256894111823d), new NpgsqlTypes.NpgsqlPoint(x: 0.964493591898648d, y: 0.2338415451179502d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6565169606184897d, y: 0.2706891628556173d), new NpgsqlTypes.NpgsqlPoint(x: 0.29736146806450414d, y: 0.6436832301445993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799108526287456d, y: 0.5380785607882994d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7291763372768661d, y: 0.9939977098788263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2926102023340582d, y: 0.8464044741024105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777062494131028d, y: 0.0427030552137756d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15160571860583394d, y: 0.011550037098066679d), new NpgsqlTypes.NpgsqlPoint(x: 0.26457492120943316d, y: 0.11061524725414462d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934119537707631d, y: 0.2958415198642995d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5873730250107587d, y: 0.9154808693336827d), new NpgsqlTypes.NpgsqlPoint(x: 0.07335465387230722d, y: 0.558193997765996d), new NpgsqlTypes.NpgsqlPoint(x: 0.09755207256832721d, y: 0.7616353256700221d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16129480600779078d, y: 0.08598622904412223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4006113534978569d, y: 0.039395848785876764d), new NpgsqlTypes.NpgsqlPoint(x: 0.049405131021838744d, y: 0.991039565313528d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9792918816402089d, y: 0.7994024154656582d), new NpgsqlTypes.NpgsqlPoint(x: 0.10622802879677129d, y: 0.7655273626207472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197127022012188d, y: 0.28648787646165796d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8104283122362137d, y: 0.9833252342272454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3731782216100179d, y: 0.4596216631518527d), new NpgsqlTypes.NpgsqlPoint(x: 0.23560694873656096d, y: 0.937083253660391d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9014788905212194d, y: 0.6995158916789589d), new NpgsqlTypes.NpgsqlPoint(x: 0.14631686210399653d, y: 0.23028886476905008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394480252532589d, y: 0.496829203852295d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6668011779024909d, y: 0.3823588183842376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843509174781334d, y: 0.0344005302711351d), new NpgsqlTypes.NpgsqlPoint(x: 0.882062569134473d, y: 0.36568861447725665d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7896193557519812d, y: 0.308409092763389d), new NpgsqlTypes.NpgsqlPoint(x: 0.6178956989508092d, y: 0.5027538623807078d), new NpgsqlTypes.NpgsqlPoint(x: 0.2732369388441689d, y: 0.8875162039687832d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9198132748660037d, y: 0.9406848877590464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760352963627289d, y: 0.6889050543521303d), new NpgsqlTypes.NpgsqlPoint(x: 0.45746954751963d, y: 0.9700044413980851d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7280759392617232d, y: 0.9058741917557436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9170915590687068d, y: 0.3928428148913289d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003676090727837d, y: 0.3468210118160924d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8220245948509193d, y: 0.06694077744094762d), new NpgsqlTypes.NpgsqlPoint(x: 0.4065877106542627d, y: 0.4383514060003926d), new NpgsqlTypes.NpgsqlPoint(x: 0.1634722314693886d, y: 0.34723110352042963d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005771639376722981d, y: 0.8460674863679076d), new NpgsqlTypes.NpgsqlPoint(x: 0.5079776652621932d, y: 0.060612686675418304d), new NpgsqlTypes.NpgsqlPoint(x: 0.18695877969653785d, y: 0.9411822807721387d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48684874637702924d, y: 0.31333883657571737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326343541458084d, y: 0.4664803299149286d), new NpgsqlTypes.NpgsqlPoint(x: 0.47541573075269195d, y: 0.1842573780238269d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3720161942810636d, y: 0.2812695972972892d), new NpgsqlTypes.NpgsqlPoint(x: 0.30555979349290574d, y: 0.610500894094079d), new NpgsqlTypes.NpgsqlPoint(x: 0.23201043156707035d, y: 0.36628744364253174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15117175955953077d, y: 0.6837185157367988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172328487342608d, y: 0.3386571503838305d), new NpgsqlTypes.NpgsqlPoint(x: 0.4266702735520326d, y: 0.6722022222566556d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8726697684704311d, y: 0.3349838892980582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649260356534919d, y: 0.4553080612617676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7426637218033727d, y: 0.7214692778548709d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5671467812583335d, y: 0.22641358255097377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194242462647569d, y: 0.34049555228803363d), new NpgsqlTypes.NpgsqlPoint(x: 0.622859228765173d, y: 0.10787545064611292d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1678791968719514d, y: 0.5246875120415007d), new NpgsqlTypes.NpgsqlPoint(x: 0.4702717403257797d, y: 0.5914631372553637d), new NpgsqlTypes.NpgsqlPoint(x: 0.04451860429531129d, y: 0.4972196392357471d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32033403194217946d, y: 0.4777000277381457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5405571883344625d, y: 0.18999641079083118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172306571393672d, y: 0.987595517432596d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9139404335224615d, y: 0.5430651481028976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7522963855304143d, y: 0.2417000351239037d), new NpgsqlTypes.NpgsqlPoint(x: 0.44069403986923716d, y: 0.9562820249540976d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2562097433301741d, y: 0.9196028057775943d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444195963475364d, y: 0.24067375629890397d), new NpgsqlTypes.NpgsqlPoint(x: 0.3941543798351732d, y: 0.3135886380617431d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41726173056425797d, y: 0.6644240020257501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415767309231458d, y: 0.6290766038594731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761445032913225d, y: 0.9562991669188213d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36202531650822267d, y: 0.11617643806092426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813665192165965d, y: 0.5882326299545158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528578814881192d, y: 0.3795533501383589d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.892370163548286d, y: 0.49466263742129213d), new NpgsqlTypes.NpgsqlPoint(x: 0.08457037109446397d, y: 0.08169331271438662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641856758390774d, y: 0.6052904236041727d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09964304402317592d, y: 0.7223301576227468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9407664238352175d, y: 0.8540263997160313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3822791769242748d, y: 0.2088453354892177d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3810171558469503d, y: 0.09029218617200352d), new NpgsqlTypes.NpgsqlPoint(x: 0.26522352324386633d, y: 0.7482338914475534d), new NpgsqlTypes.NpgsqlPoint(x: 0.9909801286330261d, y: 0.03618628837950799d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7979256788293789d, y: 0.09864110013658034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678393461914294d, y: 0.1653867732237666d), new NpgsqlTypes.NpgsqlPoint(x: 0.09155090690296042d, y: 0.59904591918054d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7724854035807927d, y: 0.801346525383997d), new NpgsqlTypes.NpgsqlPoint(x: 0.3446988554626723d, y: 0.8330874171521421d), new NpgsqlTypes.NpgsqlPoint(x: 0.6368760798114337d, y: 0.2584650202144029d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4800206029886096d, y: 0.3469842379250777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409827206396395d, y: 0.6750692143032282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3879403051101489d, y: 0.6495243345290367d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11387764251654242d, y: 0.03470369753893965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334068325260816d, y: 0.27777737932835633d), new NpgsqlTypes.NpgsqlPoint(x: 0.3744522388251563d, y: 0.36907675455477174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32813113356585144d, y: 0.6929317121143003d), new NpgsqlTypes.NpgsqlPoint(x: 0.19522880459639325d, y: 0.9308476512282562d), new NpgsqlTypes.NpgsqlPoint(x: 0.254722485025367d, y: 0.6615640250912235d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
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

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 76, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 135, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 59, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 107, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 147, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 35, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 4, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatch(connection, 45, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2M),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI), typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

