

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
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.167461332871782d, y: 0.6425973760265599d), new NpgsqlTypes.NpgsqlPoint(x: 0.48309681407567884d, y: 0.03999846379709793d), new NpgsqlTypes.NpgsqlPoint(x: 0.28695899932912106d, y: 0.7833772896594678d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.786702919754457d, y: 0.5202317879654956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445253559816463d, y: 0.6583670887317244d), new NpgsqlTypes.NpgsqlPoint(x: 0.3895251566421206d, y: 0.9670915023150362d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3184620789424646d, y: 0.43264387430986706d), new NpgsqlTypes.NpgsqlPoint(x: 0.14725820444855964d, y: 0.6043470115789841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5119794953750164d, y: 0.5817611486266226d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6607919017151059d, y: 0.532988151534591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856645690356512d, y: 0.6667125240260258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028795282229355d, y: 0.2733434926007d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09670764849963143d, y: 0.16862385873109087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5980303294099594d, y: 0.8903529249839999d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636250896745683d, y: 0.13925389191370496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6550537390131997d, y: 0.18082376580267712d), new NpgsqlTypes.NpgsqlPoint(x: 0.412481181300522d, y: 0.3801944411408502d), new NpgsqlTypes.NpgsqlPoint(x: 0.13569790049178243d, y: 0.18728190666436573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03714309392289816d, y: 0.6528002877999901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8804075526440915d, y: 0.6560465262927989d), new NpgsqlTypes.NpgsqlPoint(x: 0.5391375337835206d, y: 0.7535703026955519d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9910481849412396d, y: 0.5904022756649326d), new NpgsqlTypes.NpgsqlPoint(x: 0.4433426275949689d, y: 0.4255267231788997d), new NpgsqlTypes.NpgsqlPoint(x: 0.11752373205360789d, y: 0.6121733842042215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3459394819167827d, y: 0.28932809138672544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159236181531314d, y: 0.4146555356246755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966297378896856d, y: 0.6265454137284496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07790428922851578d, y: 0.5370898377489572d), new NpgsqlTypes.NpgsqlPoint(x: 0.26537816529538927d, y: 0.7068613416448303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4675511839428852d, y: 0.9014285651256518d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7205113214347477d, y: 0.4165867814077501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437068727852261d, y: 0.3251518690606703d), new NpgsqlTypes.NpgsqlPoint(x: 0.49253579616397936d, y: 0.14188882406319991d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6689996070471653d, y: 0.8845027422984018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107213526645886d, y: 0.733183830907783d), new NpgsqlTypes.NpgsqlPoint(x: 0.695232225769663d, y: 0.35905593459789964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6090278380593226d, y: 0.4666262506822998d), new NpgsqlTypes.NpgsqlPoint(x: 0.27661227528688925d, y: 0.3539835888896786d), new NpgsqlTypes.NpgsqlPoint(x: 0.2844613825833453d, y: 0.8528655492238457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7399136189052425d, y: 0.7995642293103362d), new NpgsqlTypes.NpgsqlPoint(x: 0.2698602898633531d, y: 0.6990665044643287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687370333818826d, y: 0.1375732670841292d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6438037700657613d, y: 0.765908161642282d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418248509771252d, y: 0.25285531103007264d), new NpgsqlTypes.NpgsqlPoint(x: 0.10237398598281633d, y: 0.5812755818689702d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8344071430723198d, y: 0.665882821685201d), new NpgsqlTypes.NpgsqlPoint(x: 0.8541791639774331d, y: 0.3597647136279378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3649324140429868d, y: 0.15742231246466964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5745953300682191d, y: 0.30732999539929484d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377527793865994d, y: 0.8638244701992296d), new NpgsqlTypes.NpgsqlPoint(x: 0.11747212556616982d, y: 0.963145408281785d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5944597418530545d, y: 0.8894820119880995d), new NpgsqlTypes.NpgsqlPoint(x: 0.27265106215250134d, y: 0.2849533678455788d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934865901009659d, y: 0.29117758643599645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02484154296119212d, y: 0.1940343556038152d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171623355638469d, y: 0.5077481420575342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7498413576690107d, y: 0.02273104320041619d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9422827991201381d, y: 0.49888742673694186d), new NpgsqlTypes.NpgsqlPoint(x: 0.934240576894767d, y: 0.8509137222228067d), new NpgsqlTypes.NpgsqlPoint(x: 0.966589689762642d, y: 0.08074392474374348d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3560741374220405d, y: 0.22078820994761061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7666195206165309d, y: 0.5311023337284202d), new NpgsqlTypes.NpgsqlPoint(x: 0.17212050624919883d, y: 0.18044882406496932d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23871262082183964d, y: 0.6213231746212904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7030063057967393d, y: 0.6598211112013417d), new NpgsqlTypes.NpgsqlPoint(x: 0.03904529129808587d, y: 0.25149490997633994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0908007845569927d, y: 0.21835323505407167d), new NpgsqlTypes.NpgsqlPoint(x: 0.525908538091283d, y: 0.6014536802603604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161394216187322d, y: 0.16685959258044936d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.332124920218863d, y: 0.2986173362107216d), new NpgsqlTypes.NpgsqlPoint(x: 0.43426220276911054d, y: 0.7170425393029466d), new NpgsqlTypes.NpgsqlPoint(x: 0.28277448719141907d, y: 0.7002561223560961d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5893149463424345d, y: 0.8110581424413269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974354132404431d, y: 0.18113583363975239d), new NpgsqlTypes.NpgsqlPoint(x: 0.2766000348022992d, y: 0.4106890523823987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3091003805571393d, y: 0.7344875855894376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918866453101567d, y: 0.611546949044985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260539219118344d, y: 0.364120917700096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062424379207519d, y: 0.20900954239111103d), new NpgsqlTypes.NpgsqlPoint(x: 0.30907933286881906d, y: 0.0792974340402618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7874953237543566d, y: 0.7928445690696477d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3632672489008273d, y: 0.06539415114394698d), new NpgsqlTypes.NpgsqlPoint(x: 0.40522119770732123d, y: 0.5864707817490751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394748592995753d, y: 0.5442403201056416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6038429264014701d, y: 0.02208295770427504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5400555498158578d, y: 0.24815090573458776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253747618488944d, y: 0.3378844230876771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7896031981114369d, y: 0.6516299889551299d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541572153722721d, y: 0.5289157182986933d), new NpgsqlTypes.NpgsqlPoint(x: 0.4533578627469774d, y: 0.31527011902113156d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.900438579381811d, y: 0.36432673161853735d), new NpgsqlTypes.NpgsqlPoint(x: 0.2454970037822004d, y: 0.26184997780089503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294710277251846d, y: 0.6516151428830306d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7318151369881027d, y: 0.0780607499296071d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157174661922796d, y: 0.9023698976627489d), new NpgsqlTypes.NpgsqlPoint(x: 0.21643508837521774d, y: 0.21185700074043567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02247062788477594d, y: 0.38061994604464267d), new NpgsqlTypes.NpgsqlPoint(x: 0.25055230863970124d, y: 0.40466277890692703d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300984903869719d, y: 0.7760850250659598d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23468252804660072d, y: 0.5807445531368695d), new NpgsqlTypes.NpgsqlPoint(x: 0.34261201985489464d, y: 0.7514804730080678d), new NpgsqlTypes.NpgsqlPoint(x: 0.9549601572666697d, y: 0.6564661563094843d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7732779931458782d, y: 0.11051791306919334d), new NpgsqlTypes.NpgsqlPoint(x: 0.07737888189074615d, y: 0.7501141584383936d), new NpgsqlTypes.NpgsqlPoint(x: 0.12234121864149772d, y: 0.9327892027008448d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6142344701404251d, y: 0.36879893852250256d), new NpgsqlTypes.NpgsqlPoint(x: 0.059901988197774814d, y: 0.26126101013955805d), new NpgsqlTypes.NpgsqlPoint(x: 0.30537290198329836d, y: 0.7224073042722483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04972356351271057d, y: 0.05784470396773278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732377422791392d, y: 0.8900111887178951d), new NpgsqlTypes.NpgsqlPoint(x: 0.3346699884939678d, y: 0.8601097656450928d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8172331118921355d, y: 0.4722495448309606d), new NpgsqlTypes.NpgsqlPoint(x: 0.15994077112745209d, y: 0.8040614307997581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6605994394003332d, y: 0.28224978562151326d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6451655384984679d, y: 0.2321522039079722d), new NpgsqlTypes.NpgsqlPoint(x: 0.33776651797407753d, y: 0.9257454093452469d), new NpgsqlTypes.NpgsqlPoint(x: 0.07170673692425822d, y: 0.12427566449583627d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9939807149128014d, y: 0.005198210437951101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764642724079443d, y: 0.3293712888097551d), new NpgsqlTypes.NpgsqlPoint(x: 0.3034074023295197d, y: 0.30805812127524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09052493219719882d, y: 0.1944964621831664d), new NpgsqlTypes.NpgsqlPoint(x: 0.049937025429270254d, y: 0.46282210159556636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151137540020985d, y: 0.4920935018997856d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7874250972884204d, y: 0.3100405871126345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681444889498797d, y: 0.20537095044564013d), new NpgsqlTypes.NpgsqlPoint(x: 0.41856044891724264d, y: 0.8293746228809235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7175731748985413d, y: 0.023854259096391384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7214534711697674d, y: 0.10582225073682039d), new NpgsqlTypes.NpgsqlPoint(x: 0.1868437805937172d, y: 0.3214811046506577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011234023750343325d, y: 0.24147504544120013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801589059813552d, y: 0.08742193368899909d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624701503962398d, y: 0.6291216287645213d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4499732536076615d, y: 0.23525280889974254d), new NpgsqlTypes.NpgsqlPoint(x: 0.3422060866429091d, y: 0.8256922314081107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304068984134549d, y: 0.3729533973533966d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592942249001123d, y: 0.3604844393674179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829081101346278d, y: 0.6846954957816627d), new NpgsqlTypes.NpgsqlPoint(x: 0.2818063441822408d, y: 0.852550039078922d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6171562934414011d, y: 0.6189795526823966d), new NpgsqlTypes.NpgsqlPoint(x: 0.13478867176881193d, y: 0.17066833088227706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692432203775272d, y: 0.3448814075673746d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3244697821015561d, y: 0.7343670021872939d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239807159318184d, y: 0.7428502697797625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658618964774872d, y: 0.2215373299300023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.901384824200923d, y: 0.7810171579845454d), new NpgsqlTypes.NpgsqlPoint(x: 0.332749153240957d, y: 0.4750019343025994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626158443280209d, y: 0.5060890904542543d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9846221537632792d, y: 0.8806761439648473d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230500321357499d, y: 0.6661094836560134d), new NpgsqlTypes.NpgsqlPoint(x: 0.12163002077800122d, y: 0.47226934453938973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18153818729063942d, y: 0.12640174671148952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3173441622736546d, y: 0.10564265299368514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799867625845168d, y: 0.17962093074423957d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2803168370141932d, y: 0.006651011784086225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4548066287979995d, y: 0.011198871860676363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803926643872498d, y: 0.5988843208023217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2054503626182982d, y: 0.6004571644321698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7048727480909678d, y: 0.5631555793274651d), new NpgsqlTypes.NpgsqlPoint(x: 0.43480545347039257d, y: 0.7874873660945294d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7004070815236525d, y: 0.10390482072706386d), new NpgsqlTypes.NpgsqlPoint(x: 0.303136598722371d, y: 0.2602187375321824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058787533246611d, y: 0.9892910160680592d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5581909516252326d, y: 0.08984103781395192d), new NpgsqlTypes.NpgsqlPoint(x: 0.768890373536897d, y: 0.8758611841235514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4949150890946399d, y: 0.951292699593063d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7729486036604691d, y: 0.06657738194227647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5065991583541327d, y: 0.007945094730235858d), new NpgsqlTypes.NpgsqlPoint(x: 0.3860367277706688d, y: 0.42871905342095307d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8581679338703786d, y: 0.45955239550964866d), new NpgsqlTypes.NpgsqlPoint(x: 0.05050364711876554d, y: 0.7766344013349537d), new NpgsqlTypes.NpgsqlPoint(x: 0.26856549547611563d, y: 0.5619401084208872d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788646610068567d, y: 0.927759188502174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8662691053145326d, y: 0.975215024282725d), new NpgsqlTypes.NpgsqlPoint(x: 0.7698932506492405d, y: 0.25071347292644985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38525711324090295d, y: 0.553790620058274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8703135215177864d, y: 0.9282994917256715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105286242215074d, y: 0.469752929415168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792778698218051d, y: 0.6932592122000621d), new NpgsqlTypes.NpgsqlPoint(x: 0.758118446283259d, y: 0.816942473872637d), new NpgsqlTypes.NpgsqlPoint(x: 0.5312033786000586d, y: 0.8177699699740614d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7429694655913168d, y: 0.5414772892554488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8825041109785676d, y: 0.767969850125048d), new NpgsqlTypes.NpgsqlPoint(x: 0.459561763489827d, y: 0.5353288846933985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34571047195683435d, y: 0.07701841404628007d), new NpgsqlTypes.NpgsqlPoint(x: 0.37579755361077527d, y: 0.37966895338703444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334192189833774d, y: 0.6125522074642197d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6897785910969318d, y: 0.09730680341302989d), new NpgsqlTypes.NpgsqlPoint(x: 0.30291912857925296d, y: 0.9846338768297049d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283465174121006d, y: 0.25336785020329355d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19632892296263238d, y: 0.5073302447660986d), new NpgsqlTypes.NpgsqlPoint(x: 0.49386510204716905d, y: 0.4887918907077696d), new NpgsqlTypes.NpgsqlPoint(x: 0.20514640849497312d, y: 0.7792696790075616d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6635649361844961d, y: 0.22298928559586384d), new NpgsqlTypes.NpgsqlPoint(x: 0.25125745597498916d, y: 0.14499274782896798d), new NpgsqlTypes.NpgsqlPoint(x: 0.02116635841780634d, y: 0.08828025248840021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6340932939563978d, y: 0.4087217408444893d), new NpgsqlTypes.NpgsqlPoint(x: 0.11919718992403738d, y: 0.7189154455273193d), new NpgsqlTypes.NpgsqlPoint(x: 0.11888947123391214d, y: 0.04052936402434393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8109046707170374d, y: 0.8067582997619231d), new NpgsqlTypes.NpgsqlPoint(x: 0.43589902160670646d, y: 0.438233308975318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5189120798196974d, y: 0.9430306283876575d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13977284925122635d, y: 0.7187159711953092d), new NpgsqlTypes.NpgsqlPoint(x: 0.1122387187859546d, y: 0.09805994882169711d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848292813592864d, y: 0.6177072704469221d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4235263689887254d, y: 0.06727999943443641d), new NpgsqlTypes.NpgsqlPoint(x: 0.612462143946416d, y: 0.6653723092761195d), new NpgsqlTypes.NpgsqlPoint(x: 0.1295084648984518d, y: 0.6940158000888067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6744431934488111d, y: 0.62791161439467d), new NpgsqlTypes.NpgsqlPoint(x: 0.07160970042589343d, y: 0.16084191940127412d), new NpgsqlTypes.NpgsqlPoint(x: 0.06798098480083292d, y: 0.08134626809260215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.343068075582735d, y: 0.15219599855438182d), new NpgsqlTypes.NpgsqlPoint(x: 0.5138379672685476d, y: 0.4388338415310368d), new NpgsqlTypes.NpgsqlPoint(x: 0.6700271489051045d, y: 0.4955758772018334d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7155319964200266d, y: 0.6063314834154387d), new NpgsqlTypes.NpgsqlPoint(x: 0.2555141534118087d, y: 0.0650677711578671d), new NpgsqlTypes.NpgsqlPoint(x: 0.788801201946529d, y: 0.0967250652038032d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46637251569789506d, y: 0.9331601590245671d), new NpgsqlTypes.NpgsqlPoint(x: 0.14084403256217426d, y: 0.06516310125837066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165668743504818d, y: 0.011576774555723923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5138140006977281d, y: 0.7315924686651233d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409198269684808d, y: 0.9365709753133896d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159977831477968d, y: 0.6405937204827015d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16383630037494057d, y: 0.5665742562349202d), new NpgsqlTypes.NpgsqlPoint(x: 0.607704030533009d, y: 0.1421866194691015d), new NpgsqlTypes.NpgsqlPoint(x: 0.660896683908557d, y: 0.520618389306971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8370220161016262d, y: 0.9870003378363239d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457051572376121d, y: 0.3596337097267043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563619816135137d, y: 0.9996814178961837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6854406885636648d, y: 0.03471002885219732d), new NpgsqlTypes.NpgsqlPoint(x: 0.028584671561585506d, y: 0.0960467507602718d), new NpgsqlTypes.NpgsqlPoint(x: 0.07177553009897308d, y: 0.46900368507450085d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.399322212742538d, y: 0.572399342987537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887618067979134d, y: 0.24566058926073353d), new NpgsqlTypes.NpgsqlPoint(x: 0.015269414433722428d, y: 0.6254198364199177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8743143614780837d, y: 0.5985910624474288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35701440399041107d, y: 0.24609665798372582d), new NpgsqlTypes.NpgsqlPoint(x: 0.41855469326771877d, y: 0.707801455024696d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05054730637246285d, y: 0.10811964781679329d), new NpgsqlTypes.NpgsqlPoint(x: 0.11752417673455917d, y: 0.8909371823037743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730062905736096d, y: 0.8899475662416197d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2915189861352664d, y: 0.40793196850265867d), new NpgsqlTypes.NpgsqlPoint(x: 0.07018280811820676d, y: 0.6204297659577888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934675764067347d, y: 0.015801508753331084d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43438006039861043d, y: 0.9623827007729174d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616723366610918d, y: 0.689422472060863d), new NpgsqlTypes.NpgsqlPoint(x: 0.15568958321996207d, y: 0.6475857313338282d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4336077157643432d, y: 0.7636609543274856d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552730803702641d, y: 0.29885833184816635d), new NpgsqlTypes.NpgsqlPoint(x: 0.656044195541063d, y: 0.8491193177807922d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2712959378125208d, y: 0.49365289165947857d), new NpgsqlTypes.NpgsqlPoint(x: 0.3759283580013191d, y: 0.7159825218560096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585694711458685d, y: 0.33790955438898584d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7470022586815022d, y: 0.6448406687744269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7339453059642947d, y: 0.11716222793811548d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589147754476949d, y: 0.6080067072333479d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20999225663890508d, y: 0.4479142823448127d), new NpgsqlTypes.NpgsqlPoint(x: 0.14530212557093247d, y: 0.13111225622640255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6592339004401271d, y: 0.5742957982216531d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7536262991623475d, y: 0.4929564687143597d), new NpgsqlTypes.NpgsqlPoint(x: 0.6861489616491296d, y: 0.9340518025257701d), new NpgsqlTypes.NpgsqlPoint(x: 0.2933437370085875d, y: 0.643017771621754d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6438554896996286d, y: 0.5074961285151273d), new NpgsqlTypes.NpgsqlPoint(x: 0.22315749423763642d, y: 0.3865089871842926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998854567623851d, y: 0.07845599642641865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6391677229008539d, y: 0.45627404877350963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906366396557076d, y: 0.9178419442491137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711355260947778d, y: 0.649998700161037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03965640706534146d, y: 0.20316608699905303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357862332333005d, y: 0.8642022035287553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116624714915725d, y: 0.6813271646188535d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2329501318582673d, y: 0.6133067467243127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842353682057239d, y: 0.1045199181514459d), new NpgsqlTypes.NpgsqlPoint(x: 0.783442642546775d, y: 0.5501734606280922d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8534805357810974d, y: 0.372605322419588d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105794246835995d, y: 0.38303035653527095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2410284739288293d, y: 0.7355534527948061d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8045816802806797d, y: 0.8977173237481244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952471448469604d, y: 0.39504650907468064d), new NpgsqlTypes.NpgsqlPoint(x: 0.11490865480489076d, y: 0.45930511875933444d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9110042619168676d, y: 0.874273872245709d), new NpgsqlTypes.NpgsqlPoint(x: 0.3895497914990128d, y: 0.8753457058436471d), new NpgsqlTypes.NpgsqlPoint(x: 0.9689783169610408d, y: 0.16364954011273958d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5141452803251073d, y: 0.3553551962472077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665383727476261d, y: 0.5869134752218043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9585094625176732d, y: 0.3223350323766139d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5497782405566469d, y: 0.07952614947073233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638529259673457d, y: 0.968328206247476d), new NpgsqlTypes.NpgsqlPoint(x: 0.993459732770708d, y: 0.21195712834256397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21913633087279372d, y: 0.6777401679091666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5833458627483299d, y: 0.58004815056473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439789343228119d, y: 0.8384489352309707d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9786538565959509d, y: 0.7752711253704957d), new NpgsqlTypes.NpgsqlPoint(x: 0.26360564097366146d, y: 0.8876587423963892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5012037667317764d, y: 0.38050379848479066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5822491288665348d, y: 0.44583187564862636d), new NpgsqlTypes.NpgsqlPoint(x: 0.26527941850165426d, y: 0.07859886921741599d), new NpgsqlTypes.NpgsqlPoint(x: 0.18097562467019623d, y: 0.5568204810232359d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16883746092534757d, y: 0.5863254722490241d), new NpgsqlTypes.NpgsqlPoint(x: 0.4625830242901815d, y: 0.23791524586261936d), new NpgsqlTypes.NpgsqlPoint(x: 0.06948624387655267d, y: 0.34746588830034864d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6329371103530333d, y: 0.0018620790780592422d), new NpgsqlTypes.NpgsqlPoint(x: 0.17587638013028395d, y: 0.38755480530004216d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323589579775036d, y: 0.7718050051954276d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37749056209218634d, y: 0.6758228172320491d), new NpgsqlTypes.NpgsqlPoint(x: 0.33083612378213d, y: 0.5542149518814014d), new NpgsqlTypes.NpgsqlPoint(x: 0.5403174432607892d, y: 0.6287721449046212d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18516637741062758d, y: 0.9543445597055458d), new NpgsqlTypes.NpgsqlPoint(x: 0.7552505351659266d, y: 0.7360566468245512d), new NpgsqlTypes.NpgsqlPoint(x: 0.914919449850041d, y: 0.666983563435381d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9070225599224296d, y: 0.06807619898286232d), new NpgsqlTypes.NpgsqlPoint(x: 0.44281896943139387d, y: 0.3802641780826095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874572377055445d, y: 0.8335770615130147d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550382107973031d, y: 0.4353301823014175d), new NpgsqlTypes.NpgsqlPoint(x: 0.33423315191202063d, y: 0.24300548315193482d), new NpgsqlTypes.NpgsqlPoint(x: 0.2665764168870869d, y: 0.13303929804346104d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6509237796047285d, y: 0.14116243063209633d), new NpgsqlTypes.NpgsqlPoint(x: 0.49445380380102144d, y: 0.15077151368980635d), new NpgsqlTypes.NpgsqlPoint(x: 0.35437182373489695d, y: 0.4527037030249118d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9637236771473564d, y: 0.28240483228581936d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107920610499735d, y: 0.6108414140209159d), new NpgsqlTypes.NpgsqlPoint(x: 0.0570097240255274d, y: 0.5943693069154175d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8333920395193787d, y: 0.7980390567341997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111379298287859d, y: 0.5859047919260677d), new NpgsqlTypes.NpgsqlPoint(x: 0.24720331310714116d, y: 0.04120179582439931d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7111851927443558d, y: 0.1471955647839226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8109051132605705d, y: 0.9808007575272657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4230924248991421d, y: 0.29376529011327446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07193151427503752d, y: 0.5169032173344719d), new NpgsqlTypes.NpgsqlPoint(x: 0.26052955175168446d, y: 0.17461843303542424d), new NpgsqlTypes.NpgsqlPoint(x: 0.47905861493344826d, y: 0.019429730752906882d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6409909361628936d, y: 0.14379412568772287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9405018472948996d, y: 0.6128650532518342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139355149841893d, y: 0.5195042379941837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27797118778091345d, y: 0.7264970219105675d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691741852421346d, y: 0.16988528200663366d), new NpgsqlTypes.NpgsqlPoint(x: 0.4044636132700423d, y: 0.19579467964703323d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4144936109884976d, y: 0.4723245091161853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431228075644473d, y: 0.5239894142788398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729347421320043d, y: 0.5068457859988333d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22904438853285136d, y: 0.9001137000214618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932541984410076d, y: 0.3747434053610703d), new NpgsqlTypes.NpgsqlPoint(x: 0.507232734209141d, y: 0.873351975485026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09035183873130348d, y: 0.24757582915301712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743292776097561d, y: 0.8701569412835282d), new NpgsqlTypes.NpgsqlPoint(x: 0.441715220378464d, y: 0.40526913644560003d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23865772910220295d, y: 0.06549689802041292d), new NpgsqlTypes.NpgsqlPoint(x: 0.08183385405556765d, y: 0.27057111128797695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5810460657573978d, y: 0.43014904861388603d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2378283710641803d, y: 0.6127944642036037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255002814155911d, y: 0.8786780151757401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5311685101118844d, y: 0.7453318322255696d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8645732267234425d, y: 0.4290642695659507d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167130749219124d, y: 0.12771831973670666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3473014456276534d, y: 0.001850337679520142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.967862364610061d, y: 0.5324405117512243d), new NpgsqlTypes.NpgsqlPoint(x: 0.037819532474512085d, y: 0.8744644777132129d), new NpgsqlTypes.NpgsqlPoint(x: 0.894311146351334d, y: 0.42223143896615345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21594063061922053d, y: 0.9031316706968193d), new NpgsqlTypes.NpgsqlPoint(x: 0.2859429841704054d, y: 0.21256802589556345d), new NpgsqlTypes.NpgsqlPoint(x: 0.931684640070731d, y: 0.4186645350124857d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2594280748917047d, y: 0.5391956419060749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831874284147479d, y: 0.7364778748882371d), new NpgsqlTypes.NpgsqlPoint(x: 0.40646189571319746d, y: 0.1732992240747111d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3424271603975434d, y: 0.8017941523353992d), new NpgsqlTypes.NpgsqlPoint(x: 0.9757684527052821d, y: 0.23912448118046026d), new NpgsqlTypes.NpgsqlPoint(x: 0.700952484174756d, y: 0.8519001309020212d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2267735971770789d, y: 0.2830587154403511d), new NpgsqlTypes.NpgsqlPoint(x: 0.24348491159828d, y: 0.5184691365361664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8370843156926631d, y: 0.12394231120320964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8853245594558022d, y: 0.8531695484617516d), new NpgsqlTypes.NpgsqlPoint(x: 0.3665253090809324d, y: 0.5045773739824481d), new NpgsqlTypes.NpgsqlPoint(x: 0.329437249687494d, y: 0.24756899537488408d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9314015211745932d, y: 0.6847581199707866d), new NpgsqlTypes.NpgsqlPoint(x: 0.05264820231172607d, y: 0.8188684269140575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196308158095697d, y: 0.40697288757981276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0538439796629121d, y: 0.856243907735161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454351136702596d, y: 0.8343376861900881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245654230248309d, y: 0.21163249668520834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8094151152564163d, y: 0.36282490399580136d), new NpgsqlTypes.NpgsqlPoint(x: 0.32026285487584494d, y: 0.13753147232537755d), new NpgsqlTypes.NpgsqlPoint(x: 0.38617412140819074d, y: 0.1715955533216349d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06402975182857118d, y: 0.5906759410362579d), new NpgsqlTypes.NpgsqlPoint(x: 0.36832863234376567d, y: 0.8834707525858493d), new NpgsqlTypes.NpgsqlPoint(x: 0.12085020309911643d, y: 0.04642333747094107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35476988206435445d, y: 0.9019733713892577d), new NpgsqlTypes.NpgsqlPoint(x: 0.43227180322097447d, y: 0.3336442537639478d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800583697555608d, y: 0.2460382696435175d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3928185721962738d, y: 0.8651448232933691d), new NpgsqlTypes.NpgsqlPoint(x: 0.18277497579423674d, y: 0.010549884791823505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5345682889565934d, y: 0.12591325162056033d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9630199367055924d, y: 0.5606683575266703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6820198803488867d, y: 0.3164902322228744d), new NpgsqlTypes.NpgsqlPoint(x: 0.10724735607758873d, y: 0.47188945748348965d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4596871015253782d, y: 0.9309607868809591d), new NpgsqlTypes.NpgsqlPoint(x: 0.638834479395042d, y: 0.36770245739983687d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605179236905977d, y: 0.256183166626457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17823894075566316d, y: 0.38922877272572853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256732708488886d, y: 0.5411199753237319d), new NpgsqlTypes.NpgsqlPoint(x: 0.16594158773940482d, y: 0.3430617736670235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4526247820259821d, y: 0.13268462438603768d), new NpgsqlTypes.NpgsqlPoint(x: 0.08898124617950232d, y: 0.1620030841366379d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768300846339397d, y: 0.9893310278313651d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1960430306307689d, y: 0.37664660997840593d), new NpgsqlTypes.NpgsqlPoint(x: 0.30429597554820464d, y: 0.28649595046360254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294602578609308d, y: 0.5519658933686479d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15358541944711168d, y: 0.9006158186082527d), new NpgsqlTypes.NpgsqlPoint(x: 0.9383114752550464d, y: 0.7575671650262d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426005788638459d, y: 0.3712549814606213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4891833633415543d, y: 0.45880184508322985d), new NpgsqlTypes.NpgsqlPoint(x: 0.18146260455532026d, y: 0.5492433661928648d), new NpgsqlTypes.NpgsqlPoint(x: 0.872947424031207d, y: 0.9416173288198718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6721876895239305d, y: 0.21381249851540185d), new NpgsqlTypes.NpgsqlPoint(x: 0.34054337131231993d, y: 0.11422559104244268d), new NpgsqlTypes.NpgsqlPoint(x: 0.1275764269840568d, y: 0.7018921412244138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5395983007573865d, y: 0.35993756613792005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7347145781516616d, y: 0.9199926606075788d), new NpgsqlTypes.NpgsqlPoint(x: 0.04085460284604403d, y: 0.8408917109325788d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9466745841526477d, y: 0.9780725004373985d), new NpgsqlTypes.NpgsqlPoint(x: 0.6510595600274938d, y: 0.42609854657662083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426927901705018d, y: 0.008192168142762801d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184964879246194d, y: 0.49960935199020684d), new NpgsqlTypes.NpgsqlPoint(x: 0.20378562845094017d, y: 0.44371887541404964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294989992782316d, y: 0.11691467018902646d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.649758535541186d, y: 0.49663153282666395d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125219691100216d, y: 0.6858935964005091d), new NpgsqlTypes.NpgsqlPoint(x: 0.49113823486715724d, y: 0.15863714746297175d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8362132625201762d, y: 0.9116931680862901d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885877548454102d, y: 0.03385546526430372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779720046073473d, y: 0.6844201076773124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30661587201227036d, y: 0.6156991995329315d), new NpgsqlTypes.NpgsqlPoint(x: 0.2837394331180424d, y: 0.18455236914520057d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627561071876724d, y: 0.3747805930412279d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8226490543228436d, y: 0.5476270345676845d), new NpgsqlTypes.NpgsqlPoint(x: 0.09410433890531966d, y: 0.6692758886620651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3425560526250233d, y: 0.16428895553613176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45009868912189077d, y: 0.8602181418393247d), new NpgsqlTypes.NpgsqlPoint(x: 0.15572628433113223d, y: 0.3081599501194554d), new NpgsqlTypes.NpgsqlPoint(x: 0.2796486405410995d, y: 0.11352136031690407d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26038253600569883d, y: 0.3220756936437057d), new NpgsqlTypes.NpgsqlPoint(x: 0.27900984162664677d, y: 0.25342698833951227d), new NpgsqlTypes.NpgsqlPoint(x: 0.32228055090945673d, y: 0.5929369105445389d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3762751832638024d, y: 0.5515117842970525d), new NpgsqlTypes.NpgsqlPoint(x: 0.008886609586559624d, y: 0.8819237714249204d), new NpgsqlTypes.NpgsqlPoint(x: 0.36859578482733946d, y: 0.4223583189353426d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13753667825107185d, y: 0.3948485618190094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4822447042592156d, y: 0.7463052101270881d), new NpgsqlTypes.NpgsqlPoint(x: 0.19431801943895288d, y: 0.41089261531648713d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1290907547475444d, y: 0.5439599320856661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838014965900723d, y: 0.5548361664696767d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585777488845153d, y: 0.9757988721337599d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3488555579345698d, y: 0.3297894128291222d), new NpgsqlTypes.NpgsqlPoint(x: 0.4796989638292848d, y: 0.38379164323488435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570086113248282d, y: 0.8275208513053537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4743244477846764d, y: 0.2632745384669115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9589790357927512d, y: 0.6348438086022273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779518671973709d, y: 0.454057768194442d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8520579769616832d, y: 0.2835381225962058d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012657763555602441d, y: 0.8540548239622886d), new NpgsqlTypes.NpgsqlPoint(x: 0.1626707288327045d, y: 0.028241099349720078d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26514863619523277d, y: 0.4323661205610657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514761983220384d, y: 0.962344630104377d), new NpgsqlTypes.NpgsqlPoint(x: 0.08202029148326295d, y: 0.6352130917247628d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4112660856823237d, y: 0.698832130470142d), new NpgsqlTypes.NpgsqlPoint(x: 0.3728659010595029d, y: 0.17216712020204195d), new NpgsqlTypes.NpgsqlPoint(x: 0.02762243423890065d, y: 0.2845660392954097d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5790187544544452d, y: 0.27750639821355993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350692178325475d, y: 0.9730432711472634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9838142563728274d, y: 0.7464861893959926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0882260828370326d, y: 0.26510328903367075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475862238750373d, y: 0.49829635505140946d), new NpgsqlTypes.NpgsqlPoint(x: 0.0716387258260931d, y: 0.19808965905959652d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24323009738153367d, y: 0.8620961865571551d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476732394081417d, y: 0.34158593540739823d), new NpgsqlTypes.NpgsqlPoint(x: 0.031119261170492685d, y: 0.6521313752474673d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7672907846356717d, y: 0.2231263602054273d), new NpgsqlTypes.NpgsqlPoint(x: 0.011352244251971233d, y: 0.06511319978697472d), new NpgsqlTypes.NpgsqlPoint(x: 0.20516506474624774d, y: 0.14085461080607808d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.201219045071242d, y: 0.44078482057151713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512383131737145d, y: 0.8878303917935247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856597969885606d, y: 0.612560665252372d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9611879611436006d, y: 0.4680697583945459d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774812533140992d, y: 0.47417577844508585d), new NpgsqlTypes.NpgsqlPoint(x: 0.14052455674850928d, y: 0.23516127540668608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5766738502711974d, y: 0.8703674724488423d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239028192305737d, y: 0.7348743108453449d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080338760988569d, y: 0.31387141414757114d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8126070574826463d, y: 0.17873725168389087d), new NpgsqlTypes.NpgsqlPoint(x: 0.18979869104590208d, y: 0.2774364286725478d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107312974303763d, y: 0.6912950552217861d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5715563461844635d, y: 0.10248896994333967d), new NpgsqlTypes.NpgsqlPoint(x: 0.706603634792831d, y: 0.8710618022648173d), new NpgsqlTypes.NpgsqlPoint(x: 0.040938363084799034d, y: 0.3831400866303095d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7706349739899879d, y: 0.9127479623053676d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520860703982589d, y: 0.35199312193706456d), new NpgsqlTypes.NpgsqlPoint(x: 0.8306661028148454d, y: 0.3141430813920828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8304391691080356d, y: 0.5231709450009495d), new NpgsqlTypes.NpgsqlPoint(x: 0.14172562910146658d, y: 0.6456679782366651d), new NpgsqlTypes.NpgsqlPoint(x: 0.40753068342093046d, y: 0.8701750096089049d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13930905841903296d, y: 0.8390722102864786d), new NpgsqlTypes.NpgsqlPoint(x: 0.07124150897336201d, y: 0.5689842118071655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705330331842222d, y: 0.1964361278062765d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26209951737064985d, y: 0.7193387540240074d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106304409717836d, y: 0.7564762171554981d), new NpgsqlTypes.NpgsqlPoint(x: 0.912882487001324d, y: 0.2689876088614227d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45058966651582677d, y: 0.25662062418239506d), new NpgsqlTypes.NpgsqlPoint(x: 0.2842563629033905d, y: 0.6079053569770131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946004659213206d, y: 0.2835462238388735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.585447058516378d, y: 0.8254304029191842d), new NpgsqlTypes.NpgsqlPoint(x: 0.9859182357502466d, y: 0.4145244691514387d), new NpgsqlTypes.NpgsqlPoint(x: 0.3871682717031921d, y: 0.18410531311681322d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6924626371722186d, y: 0.7518965722555632d), new NpgsqlTypes.NpgsqlPoint(x: 0.42117254224773637d, y: 0.2869594985651719d), new NpgsqlTypes.NpgsqlPoint(x: 0.11642943036035236d, y: 0.6612786957523167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42207087964854306d, y: 0.21996101130132584d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242764603833052d, y: 0.04718474064973033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131901743213112d, y: 0.9958623924812011d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9453986804373383d, y: 0.43979287444330795d), new NpgsqlTypes.NpgsqlPoint(x: 0.20360412849666276d, y: 0.2174646648175762d), new NpgsqlTypes.NpgsqlPoint(x: 0.016391092989360145d, y: 0.44295064205818746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6644213552009425d, y: 0.3863670466536735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123911262342183d, y: 0.29845386872813506d), new NpgsqlTypes.NpgsqlPoint(x: 0.07926846484289118d, y: 0.5592188278555315d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6670278868640207d, y: 0.06956900781692432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803522586032848d, y: 0.03358361187013026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770183148780145d, y: 0.9707911845755807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357117499814088d, y: 0.1787895787053383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437605879596751d, y: 0.5275927551186478d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873775184039257d, y: 0.9762871332641442d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40314504564266385d, y: 0.17207190962316188d), new NpgsqlTypes.NpgsqlPoint(x: 0.27497664894710294d, y: 0.8429787155317512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6658004847644217d, y: 0.49503931156896963d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787343877901787d, y: 0.739472808359017d), new NpgsqlTypes.NpgsqlPoint(x: 0.531928439684642d, y: 0.4993772230990936d), new NpgsqlTypes.NpgsqlPoint(x: 0.2515722663881602d, y: 0.02422460319692754d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4069485115287993d, y: 0.2833724281048958d), new NpgsqlTypes.NpgsqlPoint(x: 0.2522581943135509d, y: 0.24579791749310287d), new NpgsqlTypes.NpgsqlPoint(x: 0.40144060760957934d, y: 0.10491965322843799d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8977316227858634d, y: 0.37106787458184365d), new NpgsqlTypes.NpgsqlPoint(x: 0.09652067071458426d, y: 0.3713612441590187d), new NpgsqlTypes.NpgsqlPoint(x: 0.41209941586115506d, y: 0.500227778514067d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.624613017283579d, y: 0.5306015849651748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151832568250805d, y: 0.14065478634815265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8099911313063763d, y: 0.05194365255350342d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9461250118773032d, y: 0.6214332869370416d), new NpgsqlTypes.NpgsqlPoint(x: 0.2679159268229294d, y: 0.8528479436229367d), new NpgsqlTypes.NpgsqlPoint(x: 0.761727989950026d, y: 0.6004806404510457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5253287293394031d, y: 0.36649261402437117d), new NpgsqlTypes.NpgsqlPoint(x: 0.1259644688303474d, y: 0.2382855021063851d), new NpgsqlTypes.NpgsqlPoint(x: 0.1708902926233532d, y: 0.6746328477232442d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09756939947823184d, y: 0.9528408873361957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8546672645506451d, y: 0.12169365905885621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058245281437153d, y: 0.6978582864392803d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43985180015180214d, y: 0.560739501781105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937236776519617d, y: 0.013461814024727903d), new NpgsqlTypes.NpgsqlPoint(x: 0.3548274144546214d, y: 0.590502543607146d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8549004828090287d, y: 0.2630051977731097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846421498677667d, y: 0.0747982841319399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068279185577473d, y: 0.8987598868098279d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2785670981331285d, y: 0.29082243035453725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8508250559294224d, y: 0.9980210994901908d), new NpgsqlTypes.NpgsqlPoint(x: 0.15980099863055053d, y: 0.7835312012629819d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06682143840675803d, y: 0.9082116501864667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7527502043174851d, y: 0.8470153337803047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327765533469675d, y: 0.6638027629584494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7771688847178886d, y: 0.982815261429102d), new NpgsqlTypes.NpgsqlPoint(x: 0.24611286925499332d, y: 0.1790540238281626d), new NpgsqlTypes.NpgsqlPoint(x: 0.3779913032731613d, y: 0.0346185765418725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3550492448737794d, y: 0.6579931587496733d), new NpgsqlTypes.NpgsqlPoint(x: 0.31976894084675445d, y: 0.507044718615154d), new NpgsqlTypes.NpgsqlPoint(x: 0.23317004321088852d, y: 0.10032325221878524d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10314037274825827d, y: 0.5556479705324029d), new NpgsqlTypes.NpgsqlPoint(x: 0.4118183162752793d, y: 0.92385496055048d), new NpgsqlTypes.NpgsqlPoint(x: 0.28550141421719166d, y: 0.8021375791348736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.139219801054554d, y: 0.722015154068693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8764831076059911d, y: 0.10305041946462123d), new NpgsqlTypes.NpgsqlPoint(x: 0.42492554038052666d, y: 0.7292756320558174d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6221899628454045d, y: 0.42974142768477186d), new NpgsqlTypes.NpgsqlPoint(x: 0.6233472746059063d, y: 0.06782836440849371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9843553004030513d, y: 0.7974077334671439d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9272873837864073d, y: 0.38842913928139644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629375716986994d, y: 0.7972834633959371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144742083425659d, y: 0.17258068348881983d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27789959086505467d, y: 0.37797958394777d), new NpgsqlTypes.NpgsqlPoint(x: 0.15250414849507632d, y: 0.5848493703595038d), new NpgsqlTypes.NpgsqlPoint(x: 0.35095584360078547d, y: 0.9052412842144235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049858373645343956d, y: 0.3812913295652741d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291608549734064d, y: 0.4380849107652126d), new NpgsqlTypes.NpgsqlPoint(x: 0.38623390995544893d, y: 0.2697378883577771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46007827361853626d, y: 0.3550944648963982d), new NpgsqlTypes.NpgsqlPoint(x: 0.2850818454344378d, y: 0.2664231771257157d), new NpgsqlTypes.NpgsqlPoint(x: 0.19494277325117781d, y: 0.5643493417685834d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5387556143336841d, y: 0.7894386732146322d), new NpgsqlTypes.NpgsqlPoint(x: 0.25817536232665106d, y: 0.7825563890644164d), new NpgsqlTypes.NpgsqlPoint(x: 0.6881183473089517d, y: 0.701929792210778d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6121128483951419d, y: 0.19436142095794007d), new NpgsqlTypes.NpgsqlPoint(x: 0.3269784414464598d, y: 0.0404885544789505d), new NpgsqlTypes.NpgsqlPoint(x: 0.16872193860995854d, y: 0.20102737106890323d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1828112317925208d, y: 0.41270802253013095d), new NpgsqlTypes.NpgsqlPoint(x: 0.06702620119725766d, y: 0.16089669027979248d), new NpgsqlTypes.NpgsqlPoint(x: 0.27345299954863056d, y: 0.6806041017968008d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.358507927424921d, y: 0.2942393847062881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9980092664161208d, y: 0.7693143779288177d), new NpgsqlTypes.NpgsqlPoint(x: 0.4925693344852533d, y: 0.7598024362366346d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05138066045969125d, y: 0.9510359605099975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231235035168218d, y: 0.7035568879945036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675034272628719d, y: 0.5252011731731793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24385070110691942d, y: 0.7295683562397194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823147676771175d, y: 0.2358995285838117d), new NpgsqlTypes.NpgsqlPoint(x: 0.46809366649404816d, y: 0.5876727581860365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8095424920790252d, y: 0.9826768414865166d), new NpgsqlTypes.NpgsqlPoint(x: 0.46328192828236214d, y: 0.6041477405465291d), new NpgsqlTypes.NpgsqlPoint(x: 0.6401581841737068d, y: 0.4164936313071128d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47443485368827887d, y: 0.3376196974109733d), new NpgsqlTypes.NpgsqlPoint(x: 0.898743408212874d, y: 0.9066516607986784d), new NpgsqlTypes.NpgsqlPoint(x: 0.0836678224294437d, y: 0.9159183576442872d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6253643429162075d, y: 0.7781932914853592d), new NpgsqlTypes.NpgsqlPoint(x: 0.3749284107340666d, y: 0.6605247317551057d), new NpgsqlTypes.NpgsqlPoint(x: 0.6360342340522153d, y: 0.26132599350309005d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9122323864762415d, y: 0.6179829786179488d), new NpgsqlTypes.NpgsqlPoint(x: 0.015616341743171058d, y: 0.3843866155198221d), new NpgsqlTypes.NpgsqlPoint(x: 0.17830131270527483d, y: 0.7471022190753069d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23417288945331405d, y: 0.943666732647281d), new NpgsqlTypes.NpgsqlPoint(x: 0.13584852302944672d, y: 0.9408376646530978d), new NpgsqlTypes.NpgsqlPoint(x: 0.13246363024084584d, y: 0.0657788732484259d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02879278652676731d, y: 0.3971496357576334d), new NpgsqlTypes.NpgsqlPoint(x: 0.34713456207857174d, y: 0.9709937106423498d), new NpgsqlTypes.NpgsqlPoint(x: 0.38102504390577474d, y: 0.8486271381504646d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7076570602805319d, y: 0.9366301480873229d), new NpgsqlTypes.NpgsqlPoint(x: 0.5726303553678633d, y: 0.06980212639125749d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851139215163544d, y: 0.03240051928846821d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8296549791685764d, y: 0.40037218485411863d), new NpgsqlTypes.NpgsqlPoint(x: 0.22783705460793435d, y: 0.059830583062076115d), new NpgsqlTypes.NpgsqlPoint(x: 0.05199758739535332d, y: 0.9042822570022044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5529902709769505d, y: 0.6796446432924365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3760722385876336d, y: 0.6186117612565136d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583118034851827d, y: 0.5939684961446186d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35908643642709415d, y: 0.6341626267917866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8881937682979921d, y: 0.6926182703103426d), new NpgsqlTypes.NpgsqlPoint(x: 0.6377343699736407d, y: 0.5978875818471006d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5604535519712917d, y: 0.9232988240258229d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358238952645848d, y: 0.2203882885565237d), new NpgsqlTypes.NpgsqlPoint(x: 0.11644458255903056d, y: 0.5142994970385385d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38654865298116925d, y: 0.3626782609341018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9502237974338219d, y: 0.6517269162243787d), new NpgsqlTypes.NpgsqlPoint(x: 0.26042295756366896d, y: 0.11275571275101304d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7901184383214982d, y: 0.16394026991120858d), new NpgsqlTypes.NpgsqlPoint(x: 0.285752103282508d, y: 0.2606596579869921d), new NpgsqlTypes.NpgsqlPoint(x: 0.3964025541793722d, y: 0.6521591581747098d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5113139785978997d, y: 0.7706002112695293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6269929743147372d, y: 0.5077274179395638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807556025867895d, y: 0.377679164690117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9295325114776937d, y: 0.9886896261138686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825162770175926d, y: 0.43096984992179155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164725197285896d, y: 0.2882967340558802d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.63619818974296d, y: 0.008220495449491105d), new NpgsqlTypes.NpgsqlPoint(x: 0.17155162553677672d, y: 0.5158691970047214d), new NpgsqlTypes.NpgsqlPoint(x: 0.026577019063104723d, y: 0.15238235660360788d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5424764109508707d, y: 0.9510921120777501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531868609848767d, y: 0.7415038232149364d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271410281605768d, y: 0.8206751267410155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8762370947738044d, y: 0.36933292796255146d), new NpgsqlTypes.NpgsqlPoint(x: 0.3352437918676361d, y: 0.7231495091574079d), new NpgsqlTypes.NpgsqlPoint(x: 0.7612304385015005d, y: 0.4903092933517047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41908593241415915d, y: 0.7158669476375753d), new NpgsqlTypes.NpgsqlPoint(x: 0.4731626592288142d, y: 0.8270391218537503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9571004068124479d, y: 0.8220759220104865d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1079832447931035d, y: 0.6820358448827889d), new NpgsqlTypes.NpgsqlPoint(x: 0.13130249148682027d, y: 0.5542713736603825d), new NpgsqlTypes.NpgsqlPoint(x: 0.32739496882038366d, y: 0.13173251021167498d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38071924448006467d, y: 0.6302211558892693d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451462659411379d, y: 0.11748286594601975d), new NpgsqlTypes.NpgsqlPoint(x: 0.17956161636001333d, y: 0.24011442988241294d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1896099176501036d, y: 0.8700503071280024d), new NpgsqlTypes.NpgsqlPoint(x: 0.49064766547110583d, y: 0.4803914393026374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315867234508723d, y: 0.49863358896276244d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.642382938767221d, y: 0.147505893956002d), new NpgsqlTypes.NpgsqlPoint(x: 0.058726861569890376d, y: 0.21942375066670106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2435652525405292d, y: 0.06679946383037672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9816530034066977d, y: 0.17349811302013052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848418436370385d, y: 0.2494078393995538d), new NpgsqlTypes.NpgsqlPoint(x: 0.9654834209924071d, y: 0.6305229971009437d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.78054236096316d, y: 0.6023114568953948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176574641540185d, y: 0.020702553305885107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7030208130657224d, y: 0.9874059634380297d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.510903230559966d, y: 0.32773305466483305d), new NpgsqlTypes.NpgsqlPoint(x: 0.44145674485758224d, y: 0.6092002031078048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328925704892611d, y: 0.23167835679689075d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5109017824281744d, y: 0.5942215879580596d), new NpgsqlTypes.NpgsqlPoint(x: 0.2899171613253596d, y: 0.9536058280674365d), new NpgsqlTypes.NpgsqlPoint(x: 0.8734018111250049d, y: 0.7444508269056994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8613678485592936d, y: 0.17421625055738466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314647280569341d, y: 0.7884599679997892d), new NpgsqlTypes.NpgsqlPoint(x: 0.28223119597293134d, y: 0.2912053076623772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9302502965670749d, y: 0.3047110663224293d), new NpgsqlTypes.NpgsqlPoint(x: 0.49275886310675476d, y: 0.40037783123548176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144131972503642d, y: 0.9064576230432941d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6196689087026178d, y: 0.2693792995111064d), new NpgsqlTypes.NpgsqlPoint(x: 0.27460405892509654d, y: 0.07212261642868556d), new NpgsqlTypes.NpgsqlPoint(x: 0.35443532882806184d, y: 0.5836999801449215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9500530105975658d, y: 0.9053886476320533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9430673986984885d, y: 0.7477376852524638d), new NpgsqlTypes.NpgsqlPoint(x: 0.4066394021975487d, y: 0.23897172701771063d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2777549624753207d, y: 0.10721285911262002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9366959132179341d, y: 0.9241798236921875d), new NpgsqlTypes.NpgsqlPoint(x: 0.22957432144751733d, y: 0.8204923539912464d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10545595769792748d, y: 0.8904374826289296d), new NpgsqlTypes.NpgsqlPoint(x: 0.7880028040541329d, y: 0.316426196100262d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126234830488307d, y: 0.8062757281294576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6202594552701777d, y: 0.7868588445386493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392568447524831d, y: 0.6859260950565076d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386979962872956d, y: 0.42917564735662084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.513768354566023d, y: 0.33165255631398216d), new NpgsqlTypes.NpgsqlPoint(x: 0.28205839076951067d, y: 0.910611494634524d), new NpgsqlTypes.NpgsqlPoint(x: 0.13746940694336984d, y: 0.40530831729381833d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20694694595654983d, y: 0.6600814437724497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807924112633047d, y: 0.21376831894879078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905196862043152d, y: 0.8962164604789904d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8116595805760479d, y: 0.4678459086038158d), new NpgsqlTypes.NpgsqlPoint(x: 0.19473394423314472d, y: 0.9919366274089656d), new NpgsqlTypes.NpgsqlPoint(x: 0.09105869699414093d, y: 0.47225358070913814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7587914861824678d, y: 0.4975022866916038d), new NpgsqlTypes.NpgsqlPoint(x: 0.3740299419199158d, y: 0.9975099200269049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516777981058893d, y: 0.8526515123470167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5548669619278748d, y: 0.7657325821162695d), new NpgsqlTypes.NpgsqlPoint(x: 0.1993306126750426d, y: 0.675216228094479d), new NpgsqlTypes.NpgsqlPoint(x: 0.24452797809758287d, y: 0.5673090936294553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24555392556020594d, y: 0.15477557445577517d), new NpgsqlTypes.NpgsqlPoint(x: 0.1694274309371009d, y: 0.844940526488682d), new NpgsqlTypes.NpgsqlPoint(x: 0.38950673498418975d, y: 0.32962790291909994d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28388365454423137d, y: 0.02680151978004952d), new NpgsqlTypes.NpgsqlPoint(x: 0.05999616954175124d, y: 0.274706120317456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7490189154034941d, y: 0.5022905287430082d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2202053225381866d, y: 0.2247260411802008d), new NpgsqlTypes.NpgsqlPoint(x: 0.37792228079781565d, y: 0.19228150947188616d), new NpgsqlTypes.NpgsqlPoint(x: 0.16453330427857626d, y: 0.6229824367004126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31983034717851255d, y: 0.8580581339582336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9330760230679853d, y: 0.263604151626293d), new NpgsqlTypes.NpgsqlPoint(x: 0.38769320178677824d, y: 0.07844465014591795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27300051306194906d, y: 0.522231525782138d), new NpgsqlTypes.NpgsqlPoint(x: 0.48197589641865834d, y: 0.13528256762200397d), new NpgsqlTypes.NpgsqlPoint(x: 0.37404252808576743d, y: 0.745391305945376d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5253118675271248d, y: 0.4403744828432886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969743136064152d, y: 0.3697008593252904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8436712577927497d, y: 0.8983899364829122d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9816155059739528d, y: 0.8540712222900287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651013038873245d, y: 0.9119221522428443d), new NpgsqlTypes.NpgsqlPoint(x: 0.29790235320573777d, y: 0.24036002562302228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8732115713203117d, y: 0.5596099717735163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9954105868027867d, y: 0.5146263619433179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9705805227979664d, y: 0.31531508797873353d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029855494235533353d, y: 0.5268863956037683d), new NpgsqlTypes.NpgsqlPoint(x: 0.41446625200260867d, y: 0.696977446256232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9332061980180538d, y: 0.3419563808060837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6653199401372911d, y: 0.23352033577555897d), new NpgsqlTypes.NpgsqlPoint(x: 0.23892845702035714d, y: 0.40973589919698195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073125764750719d, y: 0.10622073216450001d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7532838136658829d, y: 0.2569171718258806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159359881703531d, y: 0.7008638651532961d), new NpgsqlTypes.NpgsqlPoint(x: 0.13940671114765235d, y: 0.0053131516019486735d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9432027996072355d, y: 0.20023325381621115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198894707348128d, y: 0.5920317923520606d), new NpgsqlTypes.NpgsqlPoint(x: 0.687415947811095d, y: 0.2161574913199763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1647219096652398d, y: 0.4912563355814463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479724596995386d, y: 0.9844827679593312d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331565993301484d, y: 0.9621422615358501d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.035021375410633215d, y: 0.5888585093561282d), new NpgsqlTypes.NpgsqlPoint(x: 0.03010831113952095d, y: 0.477065171319626d), new NpgsqlTypes.NpgsqlPoint(x: 0.4006303170106663d, y: 0.13508713499846614d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9706456793096739d, y: 0.9061819549182907d), new NpgsqlTypes.NpgsqlPoint(x: 0.1064381807629553d, y: 0.2550518643151026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9459509653909576d, y: 0.7020181308033029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2970158151897211d, y: 0.844476427860655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622007403221943d, y: 0.6034407272985425d), new NpgsqlTypes.NpgsqlPoint(x: 0.604353501703597d, y: 0.030074673516646833d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6874599484004579d, y: 0.583505242791302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161943041834142d, y: 0.35613391243648196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295861733347283d, y: 0.6421036948485701d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7372137089212071d, y: 0.852218318330005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279770596979244d, y: 0.8706750090814367d), new NpgsqlTypes.NpgsqlPoint(x: 0.0064953538491744345d, y: 0.8758867788880941d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5463834348043146d, y: 0.9550169228374427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913916835876666d, y: 0.6991252188244569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731413801897676d, y: 0.6253791644144193d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5299717062018122d, y: 0.6994025034929724d), new NpgsqlTypes.NpgsqlPoint(x: 0.2798478746124302d, y: 0.21262617897106917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943360268871876d, y: 0.43384757753515735d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4549267666523954d, y: 0.34009900442248286d), new NpgsqlTypes.NpgsqlPoint(x: 0.1857029294225112d, y: 0.5913039087215434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4573490231902968d, y: 0.07977503759829585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5820650051769195d, y: 0.2897477275477961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9650744951556451d, y: 0.3160485771705335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550852552586354d, y: 0.2063078788894217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2542913065286667d, y: 0.8373573189436334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7011674009929331d, y: 0.7276276240850021d), new NpgsqlTypes.NpgsqlPoint(x: 0.14989883350726985d, y: 0.8510538314538098d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11452629852832896d, y: 0.3808903290414223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8627085165700304d, y: 0.5794148144758023d), new NpgsqlTypes.NpgsqlPoint(x: 0.3636207475293741d, y: 0.8156522100937011d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42446952971982166d, y: 0.09918458375353068d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380978127340657d, y: 0.3739150539058518d), new NpgsqlTypes.NpgsqlPoint(x: 0.028913744505405403d, y: 0.5961556851095188d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09997132341887405d, y: 0.8115753586540378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389653331051194d, y: 0.338441453686674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5017589496437911d, y: 0.7512041044830926d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7115165786189105d, y: 0.8685971358712938d), new NpgsqlTypes.NpgsqlPoint(x: 0.716328527986618d, y: 0.3274577840592584d), new NpgsqlTypes.NpgsqlPoint(x: 0.31059473113726577d, y: 0.3984943268672684d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5150583261246117d, y: 0.5939255392911145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392944528102429d, y: 0.1963362480087033d), new NpgsqlTypes.NpgsqlPoint(x: 0.2349305328273047d, y: 0.9443429014307009d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2853866857730212d, y: 0.4238966558146088d), new NpgsqlTypes.NpgsqlPoint(x: 0.6412244315274478d, y: 0.24999554635811794d), new NpgsqlTypes.NpgsqlPoint(x: 0.12098384499315973d, y: 0.4788973767456238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8666602783311604d, y: 0.5691404041832969d), new NpgsqlTypes.NpgsqlPoint(x: 0.4378498701805874d, y: 0.10503148100265669d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346010962077103d, y: 0.5753325113375511d)),
},
    ModelInner = null,
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3244697821015561d, y: 0.7343670021872939d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239807159318184d, y: 0.7428502697797625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658618964774872d, y: 0.2215373299300023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.901384824200923d, y: 0.7810171579845454d), new NpgsqlTypes.NpgsqlPoint(x: 0.332749153240957d, y: 0.4750019343025994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626158443280209d, y: 0.5060890904542543d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9846221537632792d, y: 0.8806761439648473d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230500321357499d, y: 0.6661094836560134d), new NpgsqlTypes.NpgsqlPoint(x: 0.12163002077800122d, y: 0.47226934453938973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18153818729063942d, y: 0.12640174671148952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3173441622736546d, y: 0.10564265299368514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799867625845168d, y: 0.17962093074423957d)),
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
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788646610068567d, y: 0.927759188502174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8662691053145326d, y: 0.975215024282725d), new NpgsqlTypes.NpgsqlPoint(x: 0.7698932506492405d, y: 0.25071347292644985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38525711324090295d, y: 0.553790620058274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8703135215177864d, y: 0.9282994917256715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105286242215074d, y: 0.469752929415168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792778698218051d, y: 0.6932592122000621d), new NpgsqlTypes.NpgsqlPoint(x: 0.758118446283259d, y: 0.816942473872637d), new NpgsqlTypes.NpgsqlPoint(x: 0.5312033786000586d, y: 0.8177699699740614d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16383630037494057d, y: 0.5665742562349202d), new NpgsqlTypes.NpgsqlPoint(x: 0.607704030533009d, y: 0.1421866194691015d), new NpgsqlTypes.NpgsqlPoint(x: 0.660896683908557d, y: 0.520618389306971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8370220161016262d, y: 0.9870003378363239d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457051572376121d, y: 0.3596337097267043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563619816135137d, y: 0.9996814178961837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6854406885636648d, y: 0.03471002885219732d), new NpgsqlTypes.NpgsqlPoint(x: 0.028584671561585506d, y: 0.0960467507602718d), new NpgsqlTypes.NpgsqlPoint(x: 0.07177553009897308d, y: 0.46900368507450085d)),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43438006039861043d, y: 0.9623827007729174d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616723366610918d, y: 0.689422472060863d), new NpgsqlTypes.NpgsqlPoint(x: 0.15568958321996207d, y: 0.6475857313338282d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4336077157643432d, y: 0.7636609543274856d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552730803702641d, y: 0.29885833184816635d), new NpgsqlTypes.NpgsqlPoint(x: 0.656044195541063d, y: 0.8491193177807922d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2712959378125208d, y: 0.49365289165947857d), new NpgsqlTypes.NpgsqlPoint(x: 0.3759283580013191d, y: 0.7159825218560096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585694711458685d, y: 0.33790955438898584d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 11, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 31, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 137, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 96, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 99, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 112, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 107, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

