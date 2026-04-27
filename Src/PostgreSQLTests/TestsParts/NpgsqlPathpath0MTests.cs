

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
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6300384082776639d, y: 0.7495320030437037d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587360579187037d, y: 0.0190375632764902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6346034118733048d, y: 0.7280110309953616d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5471760774136353d, y: 0.2585227912960819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718623076383583d, y: 0.41161683898967794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355824858609684d, y: 0.2843345713448113d)),
},
            new NpgsqlPathpath0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4165830524643521d, y: 0.0830388451964762d), new NpgsqlTypes.NpgsqlPoint(x: 0.08829222857848407d, y: 0.5943174264904748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876111662074002d, y: 0.17128450452822186d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1142065824617603d, y: 0.9415909088183784d), new NpgsqlTypes.NpgsqlPoint(x: 0.3627983692837803d, y: 0.45255535514486134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680824183164645d, y: 0.8740173824885492d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6958800324827679d, y: 0.9323916687893822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271328684149409d, y: 0.41412994394869473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4354542597835125d, y: 0.36359964472035555d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8733588118651534d, y: 0.16321155095710926d), new NpgsqlTypes.NpgsqlPoint(x: 0.39315876647382486d, y: 0.9503506349189761d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645159395078658d, y: 0.10709211709870237d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7414732174132882d, y: 0.5528478153648975d), new NpgsqlTypes.NpgsqlPoint(x: 0.056119563992861665d, y: 0.5832535399207119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504067695106311d, y: 0.4835051441183762d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6521081336574701d, y: 0.19389437253408304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493160649245717d, y: 0.26525891719588446d), new NpgsqlTypes.NpgsqlPoint(x: 0.64087570089057d, y: 0.5485107311065177d)),
},
            new NpgsqlPathpath0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.706160539508384d, y: 0.005141111016677358d), new NpgsqlTypes.NpgsqlPoint(x: 0.07547497378100276d, y: 0.16745793447467827d), new NpgsqlTypes.NpgsqlPoint(x: 0.39019766116189136d, y: 0.4720841220664519d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.256188874853568d, y: 0.8431560538159182d), new NpgsqlTypes.NpgsqlPoint(x: 0.9257084269951422d, y: 0.04115692451214159d), new NpgsqlTypes.NpgsqlPoint(x: 0.08892551564764106d, y: 0.652981052955308d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02528017333357202d, y: 0.0036121020286387084d), new NpgsqlTypes.NpgsqlPoint(x: 0.10732959603669323d, y: 0.5158115432186098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4775577856230766d, y: 0.5790709858144809d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6178927124264777d, y: 0.9851239502443295d), new NpgsqlTypes.NpgsqlPoint(x: 0.39063668822867714d, y: 0.947174323517244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447844424973548d, y: 0.7248786467596995d)),
},
            new NpgsqlPathpath0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05123065431848717d, y: 0.5382680400422305d), new NpgsqlTypes.NpgsqlPoint(x: 0.21774613077866212d, y: 0.9950773928640092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999894798101748d, y: 0.34774489809489106d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15579580019727768d, y: 0.06381108541433689d), new NpgsqlTypes.NpgsqlPoint(x: 0.11529763666657311d, y: 0.9859693937875755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3914042588673693d, y: 0.36408382455228505d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01888634634689934d, y: 0.5747075777544562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251221495554437d, y: 0.431725187358144d), new NpgsqlTypes.NpgsqlPoint(x: 0.19735061516444297d, y: 0.7492463306561229d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8702680077616768d, y: 0.7509466595567518d), new NpgsqlTypes.NpgsqlPoint(x: 0.4769529403430788d, y: 0.9038849586911017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5634180454093034d, y: 0.3621748906716937d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6515623898081567d, y: 0.9545158800799922d), new NpgsqlTypes.NpgsqlPoint(x: 0.96676524294417d, y: 0.9435876178168235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270920933123629d, y: 0.1985019808062688d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16058513028457178d, y: 0.6229721328759219d), new NpgsqlTypes.NpgsqlPoint(x: 0.34796830943747903d, y: 0.18664291919945286d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175904268806188d, y: 0.5809811545546887d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7445133643202186d, y: 0.8770284761823003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303441676852148d, y: 0.8489118742862688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471125798692454d, y: 0.8041077749505472d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6078602283653777d, y: 0.36768957153108395d), new NpgsqlTypes.NpgsqlPoint(x: 0.1287968810690403d, y: 0.6328292418253414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954308107744425d, y: 0.8872937769923123d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7844371876329728d, y: 0.18297677787012545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6552206450692818d, y: 0.0847647148511036d), new NpgsqlTypes.NpgsqlPoint(x: 0.941565060273267d, y: 0.43806488291844314d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6273066703325338d, y: 0.8512600908796363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889247102062146d, y: 0.3657173957244293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168168183104842d, y: 0.6831728386804343d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772202322566165d, y: 0.17915506251070845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603336084521403d, y: 0.13297292060724564d), new NpgsqlTypes.NpgsqlPoint(x: 0.25848930175407114d, y: 0.4289770315281872d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.851844309600514d, y: 0.7018564833172163d), new NpgsqlTypes.NpgsqlPoint(x: 0.5957297124303375d, y: 0.9788304512982757d), new NpgsqlTypes.NpgsqlPoint(x: 0.2997499418676687d, y: 0.3170976120122728d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6999999070233826d, y: 0.4357051396862184d), new NpgsqlTypes.NpgsqlPoint(x: 0.43270381161938165d, y: 0.049086718071997715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2090709061069469d, y: 0.13966609953472842d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6715159356840498d, y: 0.8880238421387208d), new NpgsqlTypes.NpgsqlPoint(x: 0.49140044432054253d, y: 0.9876512123217106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749309553544869d, y: 0.03502030197369144d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6729231180790392d, y: 0.4814560521945269d), new NpgsqlTypes.NpgsqlPoint(x: 0.1995246206896446d, y: 0.5431674304706859d), new NpgsqlTypes.NpgsqlPoint(x: 0.40833687596285495d, y: 0.014339446661259747d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0964167158734982d, y: 0.5842303671827865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8796125411521427d, y: 0.45976677479433214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4948627395247269d, y: 0.5254190728255941d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9168258456060225d, y: 0.49146980426892384d), new NpgsqlTypes.NpgsqlPoint(x: 0.2921100253077422d, y: 0.20390123074414213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930098723004823d, y: 0.9143463210990602d)),
},
            new NpgsqlPathpath0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42892803124040535d, y: 0.37514919974800354d), new NpgsqlTypes.NpgsqlPoint(x: 0.44759577419755103d, y: 0.2146692775963055d), new NpgsqlTypes.NpgsqlPoint(x: 0.34401919520058966d, y: 0.012616808839248095d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8836600263188228d, y: 0.30826577881696005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971707306236446d, y: 0.009085413309394164d), new NpgsqlTypes.NpgsqlPoint(x: 0.663033929714687d, y: 0.39096111325163485d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10930798153262355d, y: 0.22556476547585413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902569686943317d, y: 0.5881768071532187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914221979551064d, y: 0.020549479989464325d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140810007873626d, y: 0.7221924571473407d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646112863422416d, y: 0.32654020460067945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729197123714792d, y: 0.3496695986954931d)),
},
            new NpgsqlPathpath0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07465195745434361d, y: 0.27944946309460483d), new NpgsqlTypes.NpgsqlPoint(x: 0.3099380963691144d, y: 0.990943419190619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213136568078592d, y: 0.2308106813878963d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7753076427823288d, y: 0.9581393286262891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9083663661018183d, y: 0.2970472896285863d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038218773284613983d, y: 0.49050349545931926d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11991834043230121d, y: 0.06800246878188443d), new NpgsqlTypes.NpgsqlPoint(x: 0.14251783273970497d, y: 0.3646942350224006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6038144066949053d, y: 0.5791631882847204d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22267988886481394d, y: 0.59018489978376d), new NpgsqlTypes.NpgsqlPoint(x: 0.46265038035368455d, y: 0.6830285334331706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8338288832189096d, y: 0.00788591182573073d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371227993365242d, y: 0.433150849078187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321780151777735d, y: 0.387296223664655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314340353802173d, y: 0.2712397097846202d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3260656738662907d, y: 0.8337131136194827d), new NpgsqlTypes.NpgsqlPoint(x: 0.42161845545032606d, y: 0.5748725625755013d), new NpgsqlTypes.NpgsqlPoint(x: 0.022655750456023194d, y: 0.22186464531528138d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31506189766540793d, y: 0.3522457701361885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215945616063922d, y: 0.28210863391776464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345051506595011d, y: 0.6030166556905684d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8566869647253373d, y: 0.733946245836079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244567665890496d, y: 0.781029905845733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560113728403145d, y: 0.5430858450339738d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22284767125838711d, y: 0.321577721984161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923975566935771d, y: 0.8113899759003377d), new NpgsqlTypes.NpgsqlPoint(x: 0.3601927880489252d, y: 0.7408538032647688d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8845069880781331d, y: 0.5832446133544374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694547676329802d, y: 0.7364511305841229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6858895070493819d, y: 0.9857946094173081d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14870275062068428d, y: 0.7647909234832413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922641529929551d, y: 0.7746025265805577d), new NpgsqlTypes.NpgsqlPoint(x: 0.1326722777502608d, y: 0.7024158205892392d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5673635669024245d, y: 0.7731348949686744d), new NpgsqlTypes.NpgsqlPoint(x: 0.33928059704529256d, y: 0.8057358670878573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166220974409557d, y: 0.6147651685327331d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7098140717676267d, y: 0.8092753879144646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846271568111523d, y: 0.3061248892044476d), new NpgsqlTypes.NpgsqlPoint(x: 0.006271617864172185d, y: 0.24043139857048923d)),
},
            new NpgsqlPathpath0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31527489529216324d, y: 0.852655297007515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8889632960621615d, y: 0.6472661008526572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535613037230026d, y: 0.9525916741324028d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957411241865315d, y: 0.19902201659857122d), new NpgsqlTypes.NpgsqlPoint(x: 0.17302653075258678d, y: 0.9039382978236474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4202422673906324d, y: 0.8161724949289915d)),
},
            new NpgsqlPathpath0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.847842550045621d, y: 0.6197757055064179d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464179984974675d, y: 0.5316456028916419d), new NpgsqlTypes.NpgsqlPoint(x: 0.18221153576556148d, y: 0.09319456375492519d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31308287541372426d, y: 0.47831534151469146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737751515127683d, y: 0.17120649455211512d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785384143819032d, y: 0.15767093215199957d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313514383679978d, y: 0.6567215608856876d), new NpgsqlTypes.NpgsqlPoint(x: 0.30137222950647735d, y: 0.20884501579921277d), new NpgsqlTypes.NpgsqlPoint(x: 0.0803479207868163d, y: 0.12107007574746798d)),
},
            new NpgsqlPathpath0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9834323318143712d, y: 0.7520647445623716d), new NpgsqlTypes.NpgsqlPoint(x: 0.16850611252586323d, y: 0.7333005558897999d), new NpgsqlTypes.NpgsqlPoint(x: 0.7505552944533084d, y: 0.6403555460794731d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6317074410052093d, y: 0.17568327678730322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154471361773005d, y: 0.5130477247118258d), new NpgsqlTypes.NpgsqlPoint(x: 0.7753595103738224d, y: 0.4907155999851106d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.907913085448011d, y: 0.36913169990953376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813570896125809d, y: 0.5429053833179671d), new NpgsqlTypes.NpgsqlPoint(x: 0.1538963687263062d, y: 0.12679067766493124d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31627162132425013d, y: 0.45447737352558415d), new NpgsqlTypes.NpgsqlPoint(x: 0.33585459356212666d, y: 0.8777603583517243d), new NpgsqlTypes.NpgsqlPoint(x: 0.1424464155323415d, y: 0.0408711910046855d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3308593474071012d, y: 0.20542226365059224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495379320517978d, y: 0.44382522957643034d), new NpgsqlTypes.NpgsqlPoint(x: 0.1943947088317305d, y: 0.6862480278169055d)),
},
            new NpgsqlPathpath0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14224683552529171d, y: 0.8476055227061888d), new NpgsqlTypes.NpgsqlPoint(x: 0.1506296787908371d, y: 0.998024580742324d), new NpgsqlTypes.NpgsqlPoint(x: 0.2448795634154335d, y: 0.8002398266590957d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8755387195118209d, y: 0.2761331409968887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711834964065641d, y: 0.12156541554327993d), new NpgsqlTypes.NpgsqlPoint(x: 0.27658962602114956d, y: 0.4041157152868471d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0521694551739037d, y: 0.14260948157005826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777238343217723d, y: 0.23701139939154192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479199468730737d, y: 0.9862994559930064d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40818923133426543d, y: 0.0066408142992150365d), new NpgsqlTypes.NpgsqlPoint(x: 0.36625289177110254d, y: 0.66492576750161d), new NpgsqlTypes.NpgsqlPoint(x: 0.43845343845914575d, y: 0.9687789133050013d)),
},
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6178927124264777d, y: 0.9851239502443295d), new NpgsqlTypes.NpgsqlPoint(x: 0.39063668822867714d, y: 0.947174323517244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447844424973548d, y: 0.7248786467596995d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 89, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 130, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[29], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 108, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 18, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 34, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 142);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6300384082776639d, y: 0.7495320030437037d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587360579187037d, y: 0.0190375632764902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6346034118733048d, y: 0.7280110309953616d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5471760774136353d, y: 0.2585227912960819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718623076383583d, y: 0.41161683898967794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355824858609684d, y: 0.2843345713448113d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4165830524643521d, y: 0.0830388451964762d), new NpgsqlTypes.NpgsqlPoint(x: 0.08829222857848407d, y: 0.5943174264904748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876111662074002d, y: 0.17128450452822186d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1142065824617603d, y: 0.9415909088183784d), new NpgsqlTypes.NpgsqlPoint(x: 0.3627983692837803d, y: 0.45255535514486134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680824183164645d, y: 0.8740173824885492d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6958800324827679d, y: 0.9323916687893822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271328684149409d, y: 0.41412994394869473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4354542597835125d, y: 0.36359964472035555d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8733588118651534d, y: 0.16321155095710926d), new NpgsqlTypes.NpgsqlPoint(x: 0.39315876647382486d, y: 0.9503506349189761d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645159395078658d, y: 0.10709211709870237d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7414732174132882d, y: 0.5528478153648975d), new NpgsqlTypes.NpgsqlPoint(x: 0.056119563992861665d, y: 0.5832535399207119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504067695106311d, y: 0.4835051441183762d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6521081336574701d, y: 0.19389437253408304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493160649245717d, y: 0.26525891719588446d), new NpgsqlTypes.NpgsqlPoint(x: 0.64087570089057d, y: 0.5485107311065177d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.706160539508384d, y: 0.005141111016677358d), new NpgsqlTypes.NpgsqlPoint(x: 0.07547497378100276d, y: 0.16745793447467827d), new NpgsqlTypes.NpgsqlPoint(x: 0.39019766116189136d, y: 0.4720841220664519d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.256188874853568d, y: 0.8431560538159182d), new NpgsqlTypes.NpgsqlPoint(x: 0.9257084269951422d, y: 0.04115692451214159d), new NpgsqlTypes.NpgsqlPoint(x: 0.08892551564764106d, y: 0.652981052955308d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02528017333357202d, y: 0.0036121020286387084d), new NpgsqlTypes.NpgsqlPoint(x: 0.10732959603669323d, y: 0.5158115432186098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4775577856230766d, y: 0.5790709858144809d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6178927124264777d, y: 0.9851239502443295d), new NpgsqlTypes.NpgsqlPoint(x: 0.39063668822867714d, y: 0.947174323517244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447844424973548d, y: 0.7248786467596995d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05123065431848717d, y: 0.5382680400422305d), new NpgsqlTypes.NpgsqlPoint(x: 0.21774613077866212d, y: 0.9950773928640092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999894798101748d, y: 0.34774489809489106d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15579580019727768d, y: 0.06381108541433689d), new NpgsqlTypes.NpgsqlPoint(x: 0.11529763666657311d, y: 0.9859693937875755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3914042588673693d, y: 0.36408382455228505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01888634634689934d, y: 0.5747075777544562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251221495554437d, y: 0.431725187358144d), new NpgsqlTypes.NpgsqlPoint(x: 0.19735061516444297d, y: 0.7492463306561229d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8702680077616768d, y: 0.7509466595567518d), new NpgsqlTypes.NpgsqlPoint(x: 0.4769529403430788d, y: 0.9038849586911017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5634180454093034d, y: 0.3621748906716937d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6515623898081567d, y: 0.9545158800799922d), new NpgsqlTypes.NpgsqlPoint(x: 0.96676524294417d, y: 0.9435876178168235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270920933123629d, y: 0.1985019808062688d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16058513028457178d, y: 0.6229721328759219d), new NpgsqlTypes.NpgsqlPoint(x: 0.34796830943747903d, y: 0.18664291919945286d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175904268806188d, y: 0.5809811545546887d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7445133643202186d, y: 0.8770284761823003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303441676852148d, y: 0.8489118742862688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471125798692454d, y: 0.8041077749505472d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6078602283653777d, y: 0.36768957153108395d), new NpgsqlTypes.NpgsqlPoint(x: 0.1287968810690403d, y: 0.6328292418253414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954308107744425d, y: 0.8872937769923123d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7844371876329728d, y: 0.18297677787012545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6552206450692818d, y: 0.0847647148511036d), new NpgsqlTypes.NpgsqlPoint(x: 0.941565060273267d, y: 0.43806488291844314d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6273066703325338d, y: 0.8512600908796363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889247102062146d, y: 0.3657173957244293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168168183104842d, y: 0.6831728386804343d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772202322566165d, y: 0.17915506251070845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603336084521403d, y: 0.13297292060724564d), new NpgsqlTypes.NpgsqlPoint(x: 0.25848930175407114d, y: 0.4289770315281872d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.851844309600514d, y: 0.7018564833172163d), new NpgsqlTypes.NpgsqlPoint(x: 0.5957297124303375d, y: 0.9788304512982757d), new NpgsqlTypes.NpgsqlPoint(x: 0.2997499418676687d, y: 0.3170976120122728d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6999999070233826d, y: 0.4357051396862184d), new NpgsqlTypes.NpgsqlPoint(x: 0.43270381161938165d, y: 0.049086718071997715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2090709061069469d, y: 0.13966609953472842d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6715159356840498d, y: 0.8880238421387208d), new NpgsqlTypes.NpgsqlPoint(x: 0.49140044432054253d, y: 0.9876512123217106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749309553544869d, y: 0.03502030197369144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6729231180790392d, y: 0.4814560521945269d), new NpgsqlTypes.NpgsqlPoint(x: 0.1995246206896446d, y: 0.5431674304706859d), new NpgsqlTypes.NpgsqlPoint(x: 0.40833687596285495d, y: 0.014339446661259747d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0964167158734982d, y: 0.5842303671827865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8796125411521427d, y: 0.45976677479433214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4948627395247269d, y: 0.5254190728255941d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9168258456060225d, y: 0.49146980426892384d), new NpgsqlTypes.NpgsqlPoint(x: 0.2921100253077422d, y: 0.20390123074414213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930098723004823d, y: 0.9143463210990602d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42892803124040535d, y: 0.37514919974800354d), new NpgsqlTypes.NpgsqlPoint(x: 0.44759577419755103d, y: 0.2146692775963055d), new NpgsqlTypes.NpgsqlPoint(x: 0.34401919520058966d, y: 0.012616808839248095d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8836600263188228d, y: 0.30826577881696005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971707306236446d, y: 0.009085413309394164d), new NpgsqlTypes.NpgsqlPoint(x: 0.663033929714687d, y: 0.39096111325163485d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10930798153262355d, y: 0.22556476547585413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902569686943317d, y: 0.5881768071532187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914221979551064d, y: 0.020549479989464325d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140810007873626d, y: 0.7221924571473407d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646112863422416d, y: 0.32654020460067945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729197123714792d, y: 0.3496695986954931d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07465195745434361d, y: 0.27944946309460483d), new NpgsqlTypes.NpgsqlPoint(x: 0.3099380963691144d, y: 0.990943419190619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213136568078592d, y: 0.2308106813878963d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7753076427823288d, y: 0.9581393286262891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9083663661018183d, y: 0.2970472896285863d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038218773284613983d, y: 0.49050349545931926d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11991834043230121d, y: 0.06800246878188443d), new NpgsqlTypes.NpgsqlPoint(x: 0.14251783273970497d, y: 0.3646942350224006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6038144066949053d, y: 0.5791631882847204d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22267988886481394d, y: 0.59018489978376d), new NpgsqlTypes.NpgsqlPoint(x: 0.46265038035368455d, y: 0.6830285334331706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8338288832189096d, y: 0.00788591182573073d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371227993365242d, y: 0.433150849078187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321780151777735d, y: 0.387296223664655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314340353802173d, y: 0.2712397097846202d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3260656738662907d, y: 0.8337131136194827d), new NpgsqlTypes.NpgsqlPoint(x: 0.42161845545032606d, y: 0.5748725625755013d), new NpgsqlTypes.NpgsqlPoint(x: 0.022655750456023194d, y: 0.22186464531528138d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31506189766540793d, y: 0.3522457701361885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215945616063922d, y: 0.28210863391776464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345051506595011d, y: 0.6030166556905684d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8566869647253373d, y: 0.733946245836079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244567665890496d, y: 0.781029905845733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560113728403145d, y: 0.5430858450339738d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22284767125838711d, y: 0.321577721984161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923975566935771d, y: 0.8113899759003377d), new NpgsqlTypes.NpgsqlPoint(x: 0.3601927880489252d, y: 0.7408538032647688d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8845069880781331d, y: 0.5832446133544374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694547676329802d, y: 0.7364511305841229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6858895070493819d, y: 0.9857946094173081d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14870275062068428d, y: 0.7647909234832413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922641529929551d, y: 0.7746025265805577d), new NpgsqlTypes.NpgsqlPoint(x: 0.1326722777502608d, y: 0.7024158205892392d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5673635669024245d, y: 0.7731348949686744d), new NpgsqlTypes.NpgsqlPoint(x: 0.33928059704529256d, y: 0.8057358670878573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166220974409557d, y: 0.6147651685327331d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7098140717676267d, y: 0.8092753879144646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846271568111523d, y: 0.3061248892044476d), new NpgsqlTypes.NpgsqlPoint(x: 0.006271617864172185d, y: 0.24043139857048923d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31527489529216324d, y: 0.852655297007515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8889632960621615d, y: 0.6472661008526572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535613037230026d, y: 0.9525916741324028d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957411241865315d, y: 0.19902201659857122d), new NpgsqlTypes.NpgsqlPoint(x: 0.17302653075258678d, y: 0.9039382978236474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4202422673906324d, y: 0.8161724949289915d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.847842550045621d, y: 0.6197757055064179d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464179984974675d, y: 0.5316456028916419d), new NpgsqlTypes.NpgsqlPoint(x: 0.18221153576556148d, y: 0.09319456375492519d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31308287541372426d, y: 0.47831534151469146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737751515127683d, y: 0.17120649455211512d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785384143819032d, y: 0.15767093215199957d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313514383679978d, y: 0.6567215608856876d), new NpgsqlTypes.NpgsqlPoint(x: 0.30137222950647735d, y: 0.20884501579921277d), new NpgsqlTypes.NpgsqlPoint(x: 0.0803479207868163d, y: 0.12107007574746798d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9834323318143712d, y: 0.7520647445623716d), new NpgsqlTypes.NpgsqlPoint(x: 0.16850611252586323d, y: 0.7333005558897999d), new NpgsqlTypes.NpgsqlPoint(x: 0.7505552944533084d, y: 0.6403555460794731d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6317074410052093d, y: 0.17568327678730322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154471361773005d, y: 0.5130477247118258d), new NpgsqlTypes.NpgsqlPoint(x: 0.7753595103738224d, y: 0.4907155999851106d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.907913085448011d, y: 0.36913169990953376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813570896125809d, y: 0.5429053833179671d), new NpgsqlTypes.NpgsqlPoint(x: 0.1538963687263062d, y: 0.12679067766493124d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31627162132425013d, y: 0.45447737352558415d), new NpgsqlTypes.NpgsqlPoint(x: 0.33585459356212666d, y: 0.8777603583517243d), new NpgsqlTypes.NpgsqlPoint(x: 0.1424464155323415d, y: 0.0408711910046855d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3308593474071012d, y: 0.20542226365059224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495379320517978d, y: 0.44382522957643034d), new NpgsqlTypes.NpgsqlPoint(x: 0.1943947088317305d, y: 0.6862480278169055d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14224683552529171d, y: 0.8476055227061888d), new NpgsqlTypes.NpgsqlPoint(x: 0.1506296787908371d, y: 0.998024580742324d), new NpgsqlTypes.NpgsqlPoint(x: 0.2448795634154335d, y: 0.8002398266590957d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8755387195118209d, y: 0.2761331409968887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711834964065641d, y: 0.12156541554327993d), new NpgsqlTypes.NpgsqlPoint(x: 0.27658962602114956d, y: 0.4041157152868471d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0521694551739037d, y: 0.14260948157005826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777238343217723d, y: 0.23701139939154192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479199468730737d, y: 0.9862994559930064d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40818923133426543d, y: 0.0066408142992150365d), new NpgsqlTypes.NpgsqlPoint(x: 0.36625289177110254d, y: 0.66492576750161d), new NpgsqlTypes.NpgsqlPoint(x: 0.43845343845914575d, y: 0.9687789133050013d)))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6300384082776639d, y: 0.7495320030437037d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587360579187037d, y: 0.0190375632764902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6346034118733048d, y: 0.7280110309953616d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5471760774136353d, y: 0.2585227912960819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718623076383583d, y: 0.41161683898967794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355824858609684d, y: 0.2843345713448113d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4165830524643521d, y: 0.0830388451964762d), new NpgsqlTypes.NpgsqlPoint(x: 0.08829222857848407d, y: 0.5943174264904748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876111662074002d, y: 0.17128450452822186d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1142065824617603d, y: 0.9415909088183784d), new NpgsqlTypes.NpgsqlPoint(x: 0.3627983692837803d, y: 0.45255535514486134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680824183164645d, y: 0.8740173824885492d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6958800324827679d, y: 0.9323916687893822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271328684149409d, y: 0.41412994394869473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4354542597835125d, y: 0.36359964472035555d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8733588118651534d, y: 0.16321155095710926d), new NpgsqlTypes.NpgsqlPoint(x: 0.39315876647382486d, y: 0.9503506349189761d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645159395078658d, y: 0.10709211709870237d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7414732174132882d, y: 0.5528478153648975d), new NpgsqlTypes.NpgsqlPoint(x: 0.056119563992861665d, y: 0.5832535399207119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504067695106311d, y: 0.4835051441183762d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6521081336574701d, y: 0.19389437253408304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493160649245717d, y: 0.26525891719588446d), new NpgsqlTypes.NpgsqlPoint(x: 0.64087570089057d, y: 0.5485107311065177d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.706160539508384d, y: 0.005141111016677358d), new NpgsqlTypes.NpgsqlPoint(x: 0.07547497378100276d, y: 0.16745793447467827d), new NpgsqlTypes.NpgsqlPoint(x: 0.39019766116189136d, y: 0.4720841220664519d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.256188874853568d, y: 0.8431560538159182d), new NpgsqlTypes.NpgsqlPoint(x: 0.9257084269951422d, y: 0.04115692451214159d), new NpgsqlTypes.NpgsqlPoint(x: 0.08892551564764106d, y: 0.652981052955308d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02528017333357202d, y: 0.0036121020286387084d), new NpgsqlTypes.NpgsqlPoint(x: 0.10732959603669323d, y: 0.5158115432186098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4775577856230766d, y: 0.5790709858144809d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6178927124264777d, y: 0.9851239502443295d), new NpgsqlTypes.NpgsqlPoint(x: 0.39063668822867714d, y: 0.947174323517244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447844424973548d, y: 0.7248786467596995d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05123065431848717d, y: 0.5382680400422305d), new NpgsqlTypes.NpgsqlPoint(x: 0.21774613077866212d, y: 0.9950773928640092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999894798101748d, y: 0.34774489809489106d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15579580019727768d, y: 0.06381108541433689d), new NpgsqlTypes.NpgsqlPoint(x: 0.11529763666657311d, y: 0.9859693937875755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3914042588673693d, y: 0.36408382455228505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01888634634689934d, y: 0.5747075777544562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251221495554437d, y: 0.431725187358144d), new NpgsqlTypes.NpgsqlPoint(x: 0.19735061516444297d, y: 0.7492463306561229d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8702680077616768d, y: 0.7509466595567518d), new NpgsqlTypes.NpgsqlPoint(x: 0.4769529403430788d, y: 0.9038849586911017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5634180454093034d, y: 0.3621748906716937d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6515623898081567d, y: 0.9545158800799922d), new NpgsqlTypes.NpgsqlPoint(x: 0.96676524294417d, y: 0.9435876178168235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270920933123629d, y: 0.1985019808062688d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16058513028457178d, y: 0.6229721328759219d), new NpgsqlTypes.NpgsqlPoint(x: 0.34796830943747903d, y: 0.18664291919945286d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175904268806188d, y: 0.5809811545546887d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7445133643202186d, y: 0.8770284761823003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303441676852148d, y: 0.8489118742862688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471125798692454d, y: 0.8041077749505472d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6078602283653777d, y: 0.36768957153108395d), new NpgsqlTypes.NpgsqlPoint(x: 0.1287968810690403d, y: 0.6328292418253414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954308107744425d, y: 0.8872937769923123d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7844371876329728d, y: 0.18297677787012545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6552206450692818d, y: 0.0847647148511036d), new NpgsqlTypes.NpgsqlPoint(x: 0.941565060273267d, y: 0.43806488291844314d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6273066703325338d, y: 0.8512600908796363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889247102062146d, y: 0.3657173957244293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168168183104842d, y: 0.6831728386804343d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772202322566165d, y: 0.17915506251070845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603336084521403d, y: 0.13297292060724564d), new NpgsqlTypes.NpgsqlPoint(x: 0.25848930175407114d, y: 0.4289770315281872d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.851844309600514d, y: 0.7018564833172163d), new NpgsqlTypes.NpgsqlPoint(x: 0.5957297124303375d, y: 0.9788304512982757d), new NpgsqlTypes.NpgsqlPoint(x: 0.2997499418676687d, y: 0.3170976120122728d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6999999070233826d, y: 0.4357051396862184d), new NpgsqlTypes.NpgsqlPoint(x: 0.43270381161938165d, y: 0.049086718071997715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2090709061069469d, y: 0.13966609953472842d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6715159356840498d, y: 0.8880238421387208d), new NpgsqlTypes.NpgsqlPoint(x: 0.49140044432054253d, y: 0.9876512123217106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749309553544869d, y: 0.03502030197369144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6729231180790392d, y: 0.4814560521945269d), new NpgsqlTypes.NpgsqlPoint(x: 0.1995246206896446d, y: 0.5431674304706859d), new NpgsqlTypes.NpgsqlPoint(x: 0.40833687596285495d, y: 0.014339446661259747d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0964167158734982d, y: 0.5842303671827865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8796125411521427d, y: 0.45976677479433214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4948627395247269d, y: 0.5254190728255941d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9168258456060225d, y: 0.49146980426892384d), new NpgsqlTypes.NpgsqlPoint(x: 0.2921100253077422d, y: 0.20390123074414213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930098723004823d, y: 0.9143463210990602d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42892803124040535d, y: 0.37514919974800354d), new NpgsqlTypes.NpgsqlPoint(x: 0.44759577419755103d, y: 0.2146692775963055d), new NpgsqlTypes.NpgsqlPoint(x: 0.34401919520058966d, y: 0.012616808839248095d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8836600263188228d, y: 0.30826577881696005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971707306236446d, y: 0.009085413309394164d), new NpgsqlTypes.NpgsqlPoint(x: 0.663033929714687d, y: 0.39096111325163485d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10930798153262355d, y: 0.22556476547585413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902569686943317d, y: 0.5881768071532187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914221979551064d, y: 0.020549479989464325d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140810007873626d, y: 0.7221924571473407d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646112863422416d, y: 0.32654020460067945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729197123714792d, y: 0.3496695986954931d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07465195745434361d, y: 0.27944946309460483d), new NpgsqlTypes.NpgsqlPoint(x: 0.3099380963691144d, y: 0.990943419190619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213136568078592d, y: 0.2308106813878963d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7753076427823288d, y: 0.9581393286262891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9083663661018183d, y: 0.2970472896285863d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038218773284613983d, y: 0.49050349545931926d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11991834043230121d, y: 0.06800246878188443d), new NpgsqlTypes.NpgsqlPoint(x: 0.14251783273970497d, y: 0.3646942350224006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6038144066949053d, y: 0.5791631882847204d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22267988886481394d, y: 0.59018489978376d), new NpgsqlTypes.NpgsqlPoint(x: 0.46265038035368455d, y: 0.6830285334331706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8338288832189096d, y: 0.00788591182573073d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371227993365242d, y: 0.433150849078187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321780151777735d, y: 0.387296223664655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314340353802173d, y: 0.2712397097846202d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3260656738662907d, y: 0.8337131136194827d), new NpgsqlTypes.NpgsqlPoint(x: 0.42161845545032606d, y: 0.5748725625755013d), new NpgsqlTypes.NpgsqlPoint(x: 0.022655750456023194d, y: 0.22186464531528138d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31506189766540793d, y: 0.3522457701361885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215945616063922d, y: 0.28210863391776464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345051506595011d, y: 0.6030166556905684d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8566869647253373d, y: 0.733946245836079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244567665890496d, y: 0.781029905845733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560113728403145d, y: 0.5430858450339738d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22284767125838711d, y: 0.321577721984161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923975566935771d, y: 0.8113899759003377d), new NpgsqlTypes.NpgsqlPoint(x: 0.3601927880489252d, y: 0.7408538032647688d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8845069880781331d, y: 0.5832446133544374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694547676329802d, y: 0.7364511305841229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6858895070493819d, y: 0.9857946094173081d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14870275062068428d, y: 0.7647909234832413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922641529929551d, y: 0.7746025265805577d), new NpgsqlTypes.NpgsqlPoint(x: 0.1326722777502608d, y: 0.7024158205892392d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5673635669024245d, y: 0.7731348949686744d), new NpgsqlTypes.NpgsqlPoint(x: 0.33928059704529256d, y: 0.8057358670878573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166220974409557d, y: 0.6147651685327331d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7098140717676267d, y: 0.8092753879144646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846271568111523d, y: 0.3061248892044476d), new NpgsqlTypes.NpgsqlPoint(x: 0.006271617864172185d, y: 0.24043139857048923d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31527489529216324d, y: 0.852655297007515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8889632960621615d, y: 0.6472661008526572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535613037230026d, y: 0.9525916741324028d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957411241865315d, y: 0.19902201659857122d), new NpgsqlTypes.NpgsqlPoint(x: 0.17302653075258678d, y: 0.9039382978236474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4202422673906324d, y: 0.8161724949289915d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.847842550045621d, y: 0.6197757055064179d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464179984974675d, y: 0.5316456028916419d), new NpgsqlTypes.NpgsqlPoint(x: 0.18221153576556148d, y: 0.09319456375492519d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31308287541372426d, y: 0.47831534151469146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737751515127683d, y: 0.17120649455211512d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785384143819032d, y: 0.15767093215199957d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313514383679978d, y: 0.6567215608856876d), new NpgsqlTypes.NpgsqlPoint(x: 0.30137222950647735d, y: 0.20884501579921277d), new NpgsqlTypes.NpgsqlPoint(x: 0.0803479207868163d, y: 0.12107007574746798d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9834323318143712d, y: 0.7520647445623716d), new NpgsqlTypes.NpgsqlPoint(x: 0.16850611252586323d, y: 0.7333005558897999d), new NpgsqlTypes.NpgsqlPoint(x: 0.7505552944533084d, y: 0.6403555460794731d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6317074410052093d, y: 0.17568327678730322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154471361773005d, y: 0.5130477247118258d), new NpgsqlTypes.NpgsqlPoint(x: 0.7753595103738224d, y: 0.4907155999851106d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.907913085448011d, y: 0.36913169990953376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813570896125809d, y: 0.5429053833179671d), new NpgsqlTypes.NpgsqlPoint(x: 0.1538963687263062d, y: 0.12679067766493124d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31627162132425013d, y: 0.45447737352558415d), new NpgsqlTypes.NpgsqlPoint(x: 0.33585459356212666d, y: 0.8777603583517243d), new NpgsqlTypes.NpgsqlPoint(x: 0.1424464155323415d, y: 0.0408711910046855d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3308593474071012d, y: 0.20542226365059224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495379320517978d, y: 0.44382522957643034d), new NpgsqlTypes.NpgsqlPoint(x: 0.1943947088317305d, y: 0.6862480278169055d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14224683552529171d, y: 0.8476055227061888d), new NpgsqlTypes.NpgsqlPoint(x: 0.1506296787908371d, y: 0.998024580742324d), new NpgsqlTypes.NpgsqlPoint(x: 0.2448795634154335d, y: 0.8002398266590957d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8755387195118209d, y: 0.2761331409968887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711834964065641d, y: 0.12156541554327993d), new NpgsqlTypes.NpgsqlPoint(x: 0.27658962602114956d, y: 0.4041157152868471d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0521694551739037d, y: 0.14260948157005826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777238343217723d, y: 0.23701139939154192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479199468730737d, y: 0.9862994559930064d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40818923133426543d, y: 0.0066408142992150365d), new NpgsqlTypes.NpgsqlPoint(x: 0.36625289177110254d, y: 0.66492576750161d), new NpgsqlTypes.NpgsqlPoint(x: 0.43845343845914575d, y: 0.9687789133050013d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

