

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD2
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD2 : INpgsqlBoxMArrayboxMMArrayD2
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD2E1M[] _testData = new NpgsqlBoxboxMMArrayD2E1M[]
        {
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8828080299493898d,right: 0.7016928285336007d,bottom: 0.8710177282596281d,left: 0.4616573434361443d),
new NpgsqlTypes.NpgsqlBox(top: 0.7852185131611368d,right: 0.797041080964112d,bottom: 0.07648363349924159d,left: 0.3269719343774392d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8785316531810825d,right: 0.49043607092100483d,bottom: 0.11157613363170926d,left: 0.25242205213329605d),
new NpgsqlTypes.NpgsqlBox(top: 0.9531527934243473d,right: 0.888186450681153d,bottom: 0.6295847220990685d,left: 0.04576213814947261d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6576108296002482d,right: 0.12037674819391708d,bottom: 0.11962312143750631d,left: 0.10008609542648894d),
new NpgsqlTypes.NpgsqlBox(top: 0.926190560700338d,right: 0.8743340148823506d,bottom: 0.6107523275573563d,left: 0.37199809504249504d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.23215818970598545d,right: 0.48334007890646546d,bottom: 0.04912539048550657d,left: 0.3664209639597088d),
new NpgsqlTypes.NpgsqlBox(top: 0.36353403803474627d,right: 0.7195431135906394d,bottom: 0.32960829113297774d,left: 0.08689488987950145d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.07707828973495667d,right: 0.9315167125825199d,bottom: 0.05536699452163474d,left: 0.7932794885597195d),
new NpgsqlTypes.NpgsqlBox(top: 0.23509476509520433d,right: 0.3485536476692982d,bottom: 0.1626366368273242d,left: 0.15563055281851157d), } },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6421647347033163d,right: 0.9574503481318515d,bottom: 0.17584116657267457d,left: 0.5045346119140082d),
new NpgsqlTypes.NpgsqlBox(top: 0.30000129937022346d,right: 0.9106681964062959d,bottom: 0.07164679639390947d,left: 0.8661252542383012d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8324661953622609d,right: 0.8845560989483292d,bottom: 0.26561586965815775d,left: 0.024419477363643805d),
new NpgsqlTypes.NpgsqlBox(top: 0.31918599005094617d,right: 0.6947722213274745d,bottom: 0.22881551081246998d,left: 0.16511434785064927d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.10708138184494731d,right: 0.9126081676532203d,bottom: 0.04604662965731754d,left: 0.24184120755530703d),
new NpgsqlTypes.NpgsqlBox(top: 0.5859877346096903d,right: 0.687565037450311d,bottom: 0.22271436916759868d,left: 0.4269046623909972d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5430637887242782d,right: 0.46231886131720645d,bottom: 0.2261545466947339d,left: 0.1334152140236512d),
new NpgsqlTypes.NpgsqlBox(top: 0.1743898855405378d,right: 0.28614025309905555d,bottom: 0.1327100853250679d,left: 0.14061001941873008d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9041705091851852d,right: 0.816649779176994d,bottom: 0.5292391195202022d,left: 0.2202621706915121d),
new NpgsqlTypes.NpgsqlBox(top: 0.7116831729476825d,right: 0.9254439331358078d,bottom: 0.6416923888943655d,left: 0.5193245145561148d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7635468683730651d,right: 0.5614851237534062d,bottom: 0.12896530197572598d,left: 0.14551966890497547d),
new NpgsqlTypes.NpgsqlBox(top: 0.9888092155702243d,right: 0.8734484074797915d,bottom: 0.66419854681904d,left: 0.4800987845144046d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8592209976681702d,right: 0.544057179048589d,bottom: 0.01554749598142302d,left: 0.3568769458982035d),
new NpgsqlTypes.NpgsqlBox(top: 0.924555079523179d,right: 0.802143386724925d,bottom: 0.5382612692355713d,left: 0.5979036490719075d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8464546323261802d,right: 0.3281061796619136d,bottom: 0.5194561584725985d,left: 0.08039062678589703d),
new NpgsqlTypes.NpgsqlBox(top: 0.5666820546427975d,right: 0.5368193158499193d,bottom: 0.4562856073644713d,left: 0.07514913422878611d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8634049259709052d,right: 0.7455783662110759d,bottom: 0.029575417562496487d,left: 0.6864469235166147d),
new NpgsqlTypes.NpgsqlBox(top: 0.3273584186652181d,right: 0.894403499536992d,bottom: 0.06719596433348318d,left: 0.6256962760300452d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7897506100247657d,right: 0.3696545914466266d,bottom: 0.2423495796643309d,left: 0.14418477142205788d),
new NpgsqlTypes.NpgsqlBox(top: 0.9269800455230961d,right: 0.44288258529344393d,bottom: 0.013870640592996364d,left: 0.15850151489579278d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9016122170816763d,right: 0.45034452174648165d,bottom: 0.07541193830929771d,left: 0.09755026075942619d),
new NpgsqlTypes.NpgsqlBox(top: 0.7155275326931835d,right: 0.9982475959888519d,bottom: 0.2839486374964332d,left: 0.6533154775641238d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.278040983547602d,right: 0.9874220855362251d,bottom: 0.2021867824345388d,left: 0.5831209191938651d),
new NpgsqlTypes.NpgsqlBox(top: 0.48138219997526865d,right: 0.4646628078172551d,bottom: 0.21946748368621283d,left: 0.10990337216835411d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.10845272848134635d,right: 0.9314123436321945d,bottom: 0.09147266161304812d,left: 0.48837541976646215d),
new NpgsqlTypes.NpgsqlBox(top: 0.938457625850635d,right: 0.6568563620309212d,bottom: 0.5095726988705824d,left: 0.39770786552115645d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6547844952025637d,right: 0.9136145693312987d,bottom: 0.13096842780950435d,left: 0.2640324167146413d),
new NpgsqlTypes.NpgsqlBox(top: 0.8048041697631413d,right: 0.3579779244367761d,bottom: 0.6226070328585214d,left: 0.1589771585692108d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5596448873154215d,right: 0.7363787751064249d,bottom: 0.27449181383166066d,left: 0.5503728675652301d),
new NpgsqlTypes.NpgsqlBox(top: 0.7503807553788613d,right: 0.8365230850253372d,bottom: 0.6974111781500234d,left: 0.17342526074611664d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.1250501406207668d,right: 0.659732121617446d,bottom: 0.0959923978930538d,left: 0.053424538070962035d),
new NpgsqlTypes.NpgsqlBox(top: 0.9857386699992722d,right: 0.7599240408745679d,bottom: 0.8730669675560128d,left: 0.7502519237032088d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7516700988798227d,right: 0.9056159711353856d,bottom: 0.2354057891857686d,left: 0.7960866261478575d),
new NpgsqlTypes.NpgsqlBox(top: 0.9356747657475433d,right: 0.26203044424851085d,bottom: 0.4520819679804151d,left: 0.12145322835795391d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8109862411558763d,right: 0.6635653509028017d,bottom: 0.4419458561106908d,left: 0.12070918860440949d),
new NpgsqlTypes.NpgsqlBox(top: 0.48379436179705704d,right: 0.540285380951854d,bottom: 0.3158562259122717d,left: 0.2414010045288909d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7785810988007449d,right: 0.9841507134055718d,bottom: 0.35440478369187123d,left: 0.333606414143197d),
new NpgsqlTypes.NpgsqlBox(top: 0.9786441049099045d,right: 0.6284614307678217d,bottom: 0.18845379884483415d,left: 0.39937633260968297d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.542065837211693d,right: 0.7882485707996739d,bottom: 0.41850441863397225d,left: 0.406848889240503d),
new NpgsqlTypes.NpgsqlBox(top: 0.6560762358592815d,right: 0.8904930717780077d,bottom: 0.5394824722563116d,left: 0.11735847529229071d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9385483206288038d,right: 0.3154668971770521d,bottom: 0.14678010164537836d,left: 0.01803345596136896d),
new NpgsqlTypes.NpgsqlBox(top: 0.4517070230253474d,right: 0.9965856883244462d,bottom: 0.2503168179614276d,left: 0.04361766201102235d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7126680195083873d,right: 0.5689479640968127d,bottom: 0.4435948129706385d,left: 0.12495112224115557d),
new NpgsqlTypes.NpgsqlBox(top: 0.6099921758229053d,right: 0.8181710686951444d,bottom: 0.143575601682139d,left: 0.18938526914253473d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5467412863332166d,right: 0.6795802843356827d,bottom: 0.455287995005917d,left: 0.12816256321630604d),
new NpgsqlTypes.NpgsqlBox(top: 0.42976238827606816d,right: 0.06813884284331384d,bottom: 0.10676151700186887d,left: 0.020130493534129323d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9733576492036455d,right: 0.7616580760935782d,bottom: 0.4676180074969415d,left: 0.36845957301553567d),
new NpgsqlTypes.NpgsqlBox(top: 0.20298488809768733d,right: 0.8358753867147662d,bottom: 0.008892431863360972d,left: 0.6914372099979854d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4927588076208812d,right: 0.16829328478467098d,bottom: 0.23627686778642887d,left: 0.06977284490237035d),
new NpgsqlTypes.NpgsqlBox(top: 0.21287383604433707d,right: 0.7668043577889853d,bottom: 0.20219683273590094d,left: 0.33234662048664665d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8793434225828693d,right: 0.5796370383501568d,bottom: 0.4511850553763027d,left: 0.014601386980213849d),
new NpgsqlTypes.NpgsqlBox(top: 0.5262914602260373d,right: 0.0703418671738868d,bottom: 0.27652914899555425d,left: 0.05608507911451732d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4284034380531867d,right: 0.7972654600184563d,bottom: 0.13494615104343455d,left: 0.5278165728724982d),
new NpgsqlTypes.NpgsqlBox(top: 0.17059087822713204d,right: 0.7500043549149915d,bottom: 0.06186625229345255d,left: 0.4183405645485363d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.24894327374262415d,right: 0.7902312257296422d,bottom: 0.08340598158853607d,left: 0.23396796229824934d),
new NpgsqlTypes.NpgsqlBox(top: 0.7693504306266953d,right: 0.3524038817396148d,bottom: 0.46237268703077994d,left: 0.1406318410192683d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5961563196837714d,right: 0.9449092174856161d,bottom: 0.19467510661974863d,left: 0.28634708475957993d),
new NpgsqlTypes.NpgsqlBox(top: 0.35997723848979024d,right: 0.3280027315548051d,bottom: 0.09254332566755552d,left: 0.061812814837476804d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.922302037416157d,right: 0.4776174413465939d,bottom: 0.34956782873068115d,left: 0.4574031479326155d),
new NpgsqlTypes.NpgsqlBox(top: 0.7068255770306258d,right: 0.26233524401302455d,bottom: 0.1666731751203846d,left: 0.002829541704540195d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7450493715345049d,right: 0.7837317686130976d,bottom: 0.18050329447650149d,left: 0.38690484248613244d),
new NpgsqlTypes.NpgsqlBox(top: 0.7181809910695494d,right: 0.9054998886274666d,bottom: 0.02782925170513395d,left: 0.6363490208584256d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6101443345356143d,right: 0.8064270072031278d,bottom: 0.4504901687688396d,left: 0.509911203830691d),
new NpgsqlTypes.NpgsqlBox(top: 0.9541333495517602d,right: 0.9754451791872184d,bottom: 0.011870244628395255d,left: 0.8009920134935797d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8555785695859819d,right: 0.9502595788350355d,bottom: 0.40023099247622707d,left: 0.759309804998268d),
new NpgsqlTypes.NpgsqlBox(top: 0.5826222743854667d,right: 0.5806404790438243d,bottom: 0.14518623480841952d,left: 0.5266354538530469d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8893753917573507d,right: 0.4115062504327426d,bottom: 0.28217875258500813d,left: 0.04956633900509344d),
new NpgsqlTypes.NpgsqlBox(top: 0.6523488477398324d,right: 0.5575236487261797d,bottom: 0.4165501100592044d,left: 0.15571725372561085d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6339600439157429d,right: 0.9663283428564838d,bottom: 0.17081648114402792d,left: 0.8853363064388886d),
new NpgsqlTypes.NpgsqlBox(top: 0.9393983314312973d,right: 0.6342536022699925d,bottom: 0.695285846354716d,left: 0.034546938741975675d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9314436771700019d,right: 0.9785853850049185d,bottom: 0.41769510654880426d,left: 0.5813028940239822d),
new NpgsqlTypes.NpgsqlBox(top: 0.9202298103335026d,right: 0.9369748758000154d,bottom: 0.8993432713122947d,left: 0.3937156351366573d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.3750964819488858d,right: 0.8561302941065813d,bottom: 0.07855398018350468d,left: 0.6222488207733535d),
new NpgsqlTypes.NpgsqlBox(top: 0.5976477095049695d,right: 0.4244613496472849d,bottom: 0.12039096440565844d,left: 0.15989449005888667d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6861314373489856d,right: 0.8968969891329515d,bottom: 0.48593566278621403d,left: 0.197342013758542d),
new NpgsqlTypes.NpgsqlBox(top: 0.2890769132833092d,right: 0.9790643157423526d,bottom: 0.14038742069943844d,left: 0.12239148863070382d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.29078639243371085d,right: 0.15789905349869593d,bottom: 0.1465795849000191d,left: 0.15745142667458922d),
new NpgsqlTypes.NpgsqlBox(top: 0.27188309459013005d,right: 0.7032179063007796d,bottom: 0.0012390077232877772d,left: 0.19377894670348106d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6844164830780253d,right: 0.880304790840853d,bottom: 0.36933168009851414d,left: 0.4745121975877391d),
new NpgsqlTypes.NpgsqlBox(top: 0.8068357610728933d,right: 0.6154378956805816d,bottom: 0.3050948475696129d,left: 0.18735963019529145d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8185510855550308d,right: 0.986488895528605d,bottom: 0.41788252168579054d,left: 0.2762378388280753d),
new NpgsqlTypes.NpgsqlBox(top: 0.5316912986628048d,right: 0.7227469096816866d,bottom: 0.0870398619203323d,left: 0.6669270722348328d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.88941387072164d,right: 0.7028972307709295d,bottom: 0.5346893678206474d,left: 0.21727569841512262d),
new NpgsqlTypes.NpgsqlBox(top: 0.5209205493061522d,right: 0.9124437949919787d,bottom: 0.5022749298399506d,left: 0.9082983779181103d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7613644667260304d,right: 0.31140295887538094d,bottom: 0.05707186678249343d,left: 0.2991858445378581d),
new NpgsqlTypes.NpgsqlBox(top: 0.5691099968890759d,right: 0.9372229676555974d,bottom: 0.5658288403845158d,left: 0.33540453842768825d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6352839829506327d,right: 0.717107756857266d,bottom: 0.09696785943044128d,left: 0.3027209496124784d),
new NpgsqlTypes.NpgsqlBox(top: 0.37035170504506565d,right: 0.3062289335484899d,bottom: 0.15098089609722976d,left: 0.27434940599707625d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7622886075873785d,right: 0.6502453829975074d,bottom: 0.30747817359691243d,left: 0.34629858403861746d),
new NpgsqlTypes.NpgsqlBox(top: 0.5652936553291893d,right: 0.9270028699877538d,bottom: 0.525396689966198d,left: 0.5641939396302771d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.3709543442567518d,right: 0.8014967288788667d,bottom: 0.2757087625561384d,left: 0.654983694783568d),
new NpgsqlTypes.NpgsqlBox(top: 0.27029337779916995d,right: 0.3343226443041971d,bottom: 0.25302755809328936d,left: 0.004429785639567196d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6057500298640934d,right: 0.8454992535452408d,bottom: 0.2937737187100389d,left: 0.3726023438359758d),
new NpgsqlTypes.NpgsqlBox(top: 0.8846370030861674d,right: 0.9154780515079227d,bottom: 0.6193322058549163d,left: 0.0260267734559122d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8209316294882293d,right: 0.4323052612443913d,bottom: 0.7335649703563278d,left: 0.3226168708095425d),
new NpgsqlTypes.NpgsqlBox(top: 0.48123854314479564d,right: 0.6131212203467173d,bottom: 0.07702158040929763d,left: 0.3704310132790193d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6811971178694044d,right: 0.5993425452745625d,bottom: 0.5959518513375031d,left: 0.14506033371650406d),
new NpgsqlTypes.NpgsqlBox(top: 0.2861643052555318d,right: 0.7248330341026709d,bottom: 0.20328753741953642d,left: 0.25720483787928106d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.21379057953697234d,right: 0.6318234118376528d,bottom: 0.09517903116856818d,left: 0.02989902688974133d),
new NpgsqlTypes.NpgsqlBox(top: 0.36203297044046634d,right: 0.5817024526918222d,bottom: 0.13904893471576174d,left: 0.08395176416607586d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6238777432238508d,right: 0.5508669068905364d,bottom: 0.36501255647511077d,left: 0.3361832374279652d),
new NpgsqlTypes.NpgsqlBox(top: 0.8179790305065274d,right: 0.08205338088254455d,bottom: 0.5370386393408584d,left: 0.0434819253916684d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5965186254590112d,right: 0.5274376276740578d,bottom: 0.024400465224514223d,left: 0.269018377735911d),
new NpgsqlTypes.NpgsqlBox(top: 0.9396373673773444d,right: 0.8249957451098229d,bottom: 0.14936451621651947d,left: 0.621255954863985d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7812473394645287d,right: 0.26245547586002527d,bottom: 0.2643913536333212d,left: 0.24732515860589543d),
new NpgsqlTypes.NpgsqlBox(top: 0.9999649841673276d,right: 0.8780462012818915d,bottom: 0.08179780264254177d,left: 0.433075862803057d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4124491155987049d,right: 0.8005730008835061d,bottom: 0.10959286274115465d,left: 0.3004692201170066d),
new NpgsqlTypes.NpgsqlBox(top: 0.939967141882552d,right: 0.5482707529613424d,bottom: 0.7873974115581885d,left: 0.3823662526223084d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6831900137159335d,right: 0.4603658010773003d,bottom: 0.06921591496173474d,left: 0.1347472356478644d),
new NpgsqlTypes.NpgsqlBox(top: 0.6875052749959738d,right: 0.40649833991641315d,bottom: 0.5277717524931689d,left: 0.38749274543756673d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8788463787930095d,right: 0.7692291162490339d,bottom: 0.19218844967198168d,left: 0.10134197746859774d),
new NpgsqlTypes.NpgsqlBox(top: 0.8039440232710556d,right: 0.5147064859855327d,bottom: 0.2981983808542342d,left: 0.37352623786683115d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6061394649189298d,right: 0.8534544072104784d,bottom: 0.17478234245066893d,left: 0.7056011208074234d),
new NpgsqlTypes.NpgsqlBox(top: 0.7085400877167369d,right: 0.6150944617523078d,bottom: 0.607726738627952d,left: 0.10249365249464915d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7714497531185862d,right: 0.9091881938741215d,bottom: 0.6564356066461393d,left: 0.08918140107110939d),
new NpgsqlTypes.NpgsqlBox(top: 0.979232991491498d,right: 0.9247435362156092d,bottom: 0.9713119443045463d,left: 0.4974541669586511d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.68431710712435d,right: 0.8408890553903543d,bottom: 0.5353177451340252d,left: 0.7469680078516702d),
new NpgsqlTypes.NpgsqlBox(top: 0.7477261924715931d,right: 0.42168155794364914d,bottom: 0.13479122874305882d,left: 0.20418066517840483d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5727117180433305d,right: 0.734151866427534d,bottom: 0.29779707321767435d,left: 0.5928232142925159d),
new NpgsqlTypes.NpgsqlBox(top: 0.8611617849051785d,right: 0.41194157916477125d,bottom: 0.7723865437851385d,left: 0.1941901376509697d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8450088941502701d,right: 0.5556030679642133d,bottom: 0.2231167782011364d,left: 0.040165183560235684d),
new NpgsqlTypes.NpgsqlBox(top: 0.21771571505334286d,right: 0.5608480147799758d,bottom: 0.0666011299223026d,left: 0.129561536766726d), } },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6361359687885068d,right: 0.7345237373086112d,bottom: 0.13993794931355663d,left: 0.5438350702535982d),
new NpgsqlTypes.NpgsqlBox(top: 0.40470500499628814d,right: 0.45169746553100276d,bottom: 0.10877425174887623d,left: 0.087152127811708d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8440602798127955d,right: 0.8665868131048979d,bottom: 0.7139602388051665d,left: 0.340895853992344d),
new NpgsqlTypes.NpgsqlBox(top: 0.599642665929656d,right: 0.7687264998936305d,bottom: 0.15888319586950572d,left: 0.5677664895847897d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.2967385315529716d,right: 0.702451886653141d,bottom: 0.1871399939967926d,left: 0.5610126591387531d),
new NpgsqlTypes.NpgsqlBox(top: 0.28873097374456047d,right: 0.6314209817979973d,bottom: 0.20615685567336817d,left: 0.2929894268110146d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6998859197891864d,right: 0.7640300306012439d,bottom: 0.12026627116307853d,left: 0.743148319880959d),
new NpgsqlTypes.NpgsqlBox(top: 0.925109566061973d,right: 0.8649181732245976d,bottom: 0.5048432521702567d,left: 0.770321055575584d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8185874445270813d,right: 0.7962576016764167d,bottom: 0.19221010160952856d,left: 0.06068056412629086d),
new NpgsqlTypes.NpgsqlBox(top: 0.47496981092099755d,right: 0.9754287516374552d,bottom: 0.009910449458148007d,left: 0.6708057215553737d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9565708506149697d,right: 0.8298286426926054d,bottom: 0.782115452840312d,left: 0.6634094853630343d),
new NpgsqlTypes.NpgsqlBox(top: 0.4652118008610261d,right: 0.9149126094003379d,bottom: 0.3853974644991668d,left: 0.7993178793738693d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.3992410750066291d,right: 0.9433912178057551d,bottom: 0.1268764562520449d,left: 0.8182885562698862d),
new NpgsqlTypes.NpgsqlBox(top: 0.8954412403789819d,right: 0.9107816178515161d,bottom: 0.5084957990194761d,left: 0.4377260806954193d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.974423887721491d,right: 0.7406237823912694d,bottom: 0.3249811681719651d,left: 0.21535990501902846d),
new NpgsqlTypes.NpgsqlBox(top: 0.9835127880654335d,right: 0.9202645999480032d,bottom: 0.6022483090606027d,left: 0.38288125645639925d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9116296212730457d,right: 0.8728372309276407d,bottom: 0.4342491217507325d,left: 0.06201966974241191d),
new NpgsqlTypes.NpgsqlBox(top: 0.9661180441829711d,right: 0.5595395316030822d,bottom: 0.7436524962072814d,left: 0.25051696797936274d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8967110900216334d,right: 0.4024959398274528d,bottom: 0.4936494799393991d,left: 0.014495574522103705d),
new NpgsqlTypes.NpgsqlBox(top: 0.7362277544560221d,right: 0.6315790876637433d,bottom: 0.17621961150977727d,left: 0.33472368088026094d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4742073603907415d,right: 0.28399552176886556d,bottom: 0.15048013209843836d,left: 0.16483679556978093d),
new NpgsqlTypes.NpgsqlBox(top: 0.9978857995485961d,right: 0.8422954426955483d,bottom: 0.22172048745099748d,left: 0.2359614816011012d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6295141904719095d,right: 0.7935121163280249d,bottom: 0.0963681399165851d,left: 0.35306708954182886d),
new NpgsqlTypes.NpgsqlBox(top: 0.6766332347680856d,right: 0.9416283370594946d,bottom: 0.1259972903889115d,left: 0.42131287221477365d), } },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.33346792180117535d,right: 0.5613810691841274d,bottom: 0.030576510447002825d,left: 0.2774340622635656d),
new NpgsqlTypes.NpgsqlBox(top: 0.986045046871153d,right: 0.2461655423892174d,bottom: 0.14450582395615819d,left: 0.18712626061008586d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5434114951734216d,right: 0.2573030427539802d,bottom: 0.016507346642333d,left: 0.06488344566978799d),
new NpgsqlTypes.NpgsqlBox(top: 0.8664411337321338d,right: 0.38061130226140527d,bottom: 0.45317518933580103d,left: 0.0040588585203107375d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8544540249029295d,right: 0.2531062376918285d,bottom: 0.4098438322635811d,left: 0.20588866063198208d),
new NpgsqlTypes.NpgsqlBox(top: 0.5349848749947038d,right: 0.5237523303531114d,bottom: 0.26321510305279594d,left: 0.2871091287617318d), } },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.3660822098487837d,right: 0.5911045817993974d,bottom: 0.28315445345406065d,left: 0.15587541937333127d),
new NpgsqlTypes.NpgsqlBox(top: 0.7160204125634055d,right: 0.5439141935482694d,bottom: 0.5495372165551629d,left: 0.5423539723910629d), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9016122170816763d,right: 0.45034452174648165d,bottom: 0.07541193830929771d,left: 0.09755026075942619d),
new NpgsqlTypes.NpgsqlBox(top: 0.7155275326931835d,right: 0.9982475959888519d,bottom: 0.2839486374964332d,left: 0.6533154775641238d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.10845272848134635d,right: 0.9314123436321945d,bottom: 0.09147266161304812d,left: 0.48837541976646215d),
new NpgsqlTypes.NpgsqlBox(top: 0.938457625850635d,right: 0.6568563620309212d,bottom: 0.5095726988705824d,left: 0.39770786552115645d), } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7516700988798227d,right: 0.9056159711353856d,bottom: 0.2354057891857686d,left: 0.7960866261478575d),
new NpgsqlTypes.NpgsqlBox(top: 0.9356747657475433d,right: 0.26203044424851085d,bottom: 0.4520819679804151d,left: 0.12145322835795391d), } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7126680195083873d,right: 0.5689479640968127d,bottom: 0.4435948129706385d,left: 0.12495112224115557d),
new NpgsqlTypes.NpgsqlBox(top: 0.6099921758229053d,right: 0.8181710686951444d,bottom: 0.143575601682139d,left: 0.18938526914253473d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9733576492036455d,right: 0.7616580760935782d,bottom: 0.4676180074969415d,left: 0.36845957301553567d),
new NpgsqlTypes.NpgsqlBox(top: 0.20298488809768733d,right: 0.8358753867147662d,bottom: 0.008892431863360972d,left: 0.6914372099979854d), } }));
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4284034380531867d,right: 0.7972654600184563d,bottom: 0.13494615104343455d,left: 0.5278165728724982d),
new NpgsqlTypes.NpgsqlBox(top: 0.17059087822713204d,right: 0.7500043549149915d,bottom: 0.06186625229345255d,left: 0.4183405645485363d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 109, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 73, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 31, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 109, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
FROM public.binary_npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI), typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

