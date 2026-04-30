

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8074078159280617d, y: 0.07076632210175593d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15619095862477173d, y: 0.8382437944764874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23832335869793775d, y: 0.5294957792460067d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1777100364672124d, y: 0.07048326414627615d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7589925123868295d, y: 0.8575637666680291d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6156707229364106d, y: 0.39016410678284275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9645713420691386d, y: 0.15037588646670952d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34480145031799614d, y: 0.5709550821732183d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04952189215412672d, y: 0.8763187885891416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5274512138779869d, y: 0.22818398561066466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6377984436364974d, y: 0.19007069263395093d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7089912842482085d, y: 0.33305042215190594d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2780866207385664d, y: 0.990613046233248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6602680570539576d, y: 0.8484009966849875d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6515909139528963d, y: 0.6224624553803677d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03417831325440879d, y: 0.9380391763920403d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3702588655403576d, y: 0.34421238513345975d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9107027047671894d, y: 0.8006814435072115d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9392986139609067d, y: 0.15246480633930393d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7055054195826096d, y: 0.6259918306085639d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03531386289577221d, y: 0.7385936232462673d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6904258432719521d, y: 0.45358241090274176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31657198154954835d, y: 0.12629437786964537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06731006701020315d, y: 0.8389226326455307d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7021828863436613d, y: 0.5499276128912788d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2089967476036093d, y: 0.7703388329020292d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20105964729530457d, y: 0.8254816989896125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09658966860093265d, y: 0.9731829389819018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10250765300651865d, y: 0.8166051908655501d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.506018767772469d, y: 0.034502024501651296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.303227100579028d, y: 0.25607096159166054d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24755192699744277d, y: 0.017336996945801375d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11992200394102692d, y: 0.7728426360622267d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2331785473158765d, y: 0.1406655316150751d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5591616226136644d, y: 0.31941470405363515d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.81102023702253d, y: 0.11262428654254397d),
new NpgsqlTypes.NpgsqlPoint(x: 0.017265511507242315d, y: 0.42252951808881223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39190716995095d, y: 0.5331600135925709d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2648928723854599d, y: 0.5024639573349177d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7519012473482588d, y: 0.29938485491682665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3668553995873778d, y: 0.11910582031987016d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44939410630027377d, y: 0.9928192827361656d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8143225686828848d, y: 0.9946512577296517d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7778092055328792d, y: 0.24112122955696014d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43412730339530636d, y: 0.2247869320789173d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8190601357219752d, y: 0.7666717387229233d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.911588506608608d, y: 0.49322141406235753d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9985662558451663d, y: 0.9735276448381788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8343687992702766d, y: 0.28322494080170724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13999111003263398d, y: 0.5758246992515761d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43413683325511554d, y: 0.9741839504378721d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11330369759979386d, y: 0.8900875828915662d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9322336423879506d, y: 0.31126427539614787d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5602326984601005d, y: 0.831871535767965d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1792775783570416d, y: 0.5675246046035264d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2812249542125276d, y: 0.16912354607752889d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7115207445301123d, y: 0.2670530772375449d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8676952357574192d, y: 0.56851525198838d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3697744124177149d, y: 0.7819747943891681d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2062017825336323d, y: 0.1548443880743161d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9002077815166556d, y: 0.3993592474673807d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18780603709613752d, y: 0.56763909098557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7085200645798878d, y: 0.5852614928570055d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7429456773561516d, y: 0.659882909569656d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14832575749085064d, y: 0.5358242577261881d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7689911038286393d, y: 0.24566841035322262d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07041781758400467d, y: 0.07539924320788649d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10170892667852593d, y: 0.9837360794932405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6098737025563713d, y: 0.1980495007181985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07181139909988188d, y: 0.5584043864718797d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7594698828616268d, y: 0.5080651920225706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5668824207837088d, y: 0.9596943302730127d),
new NpgsqlTypes.NpgsqlPoint(x: 0.029541595677809118d, y: 0.2543869366053225d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6300255916026843d, y: 0.8576435300479758d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9433226477187708d, y: 0.19935808551729828d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10286209382480549d, y: 0.44710386070589003d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8181727923289744d, y: 0.8152978198222226d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1785530367256909d, y: 0.01675368108905717d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6201565684118823d, y: 0.17881840649370762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5035758876895913d, y: 0.9914777063681296d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04780092027548033d, y: 0.29313753564121003d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8096933634602321d, y: 0.9229260495588114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27819807580363054d, y: 0.23159076492737107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8812618607752787d, y: 0.892915935369129d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39171270238271727d, y: 0.7215879386868191d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8229575801197414d, y: 0.8312772344703877d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9417273902924994d, y: 0.4935635777397438d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8926627474383826d, y: 0.6623114564162929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3144812710919407d, y: 0.8969127903994151d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43414831172793833d, y: 0.36328482749405655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7110794742282536d, y: 0.21929431690063006d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21434084249375418d, y: 0.7886831253795823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.323196177631896d, y: 0.444831775808591d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31425141853418437d, y: 0.16627366990461467d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9744127799781582d, y: 0.2629147211756119d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8690819572745405d, y: 0.9974494209117133d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3032715315725635d, y: 0.5008597744115396d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7405602492722658d, y: 0.18576783443393463d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6521960211391181d, y: 0.36336611377869255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8588984609629362d, y: 0.1954408549275759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19925892200451356d, y: 0.8281306341364542d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7292995395052094d, y: 0.9504172207446837d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30657333994629754d, y: 0.837641488950851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05158267261313243d, y: 0.3361835791539741d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6376245137136339d, y: 0.054117301247446736d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41475847549752143d, y: 0.4928896272257146d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06990236710921827d, y: 0.6857056842250873d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8381187620570619d, y: 0.07558727172744883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9401203407444576d, y: 0.4370141859070391d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25385859680575107d, y: 0.26750273290253257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9390194101363486d, y: 0.5721291702610071d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6989950497739871d, y: 0.022086610136210827d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5018329145343543d, y: 0.2877368463457488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21724394856344986d, y: 0.10670846377930976d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44615512694193726d, y: 0.7090028459346615d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16356884511695913d, y: 0.07331681680786217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12612935161865813d, y: 0.42864166509035706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3061403782232669d, y: 0.7286836261154856d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13853279653980533d, y: 0.6360067225520443d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7851044421766978d, y: 0.7549651558646224d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7980055162327925d, y: 0.4465124421488399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10860574637915332d, y: 0.8012647761862381d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8498129657017895d, y: 0.12117435735506754d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8118221396438501d, y: 0.4219602309148247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7744186465696726d, y: 0.9278850055253213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40210693208791226d, y: 0.20405731967858864d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45727344294031913d, y: 0.8399815211025119d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35119711462191283d, y: 0.17407022646024073d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1301556694099496d, y: 0.5391328478772863d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6247594477931108d, y: 0.5597184297987641d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20508146038808706d, y: 0.47378862726770443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8423767485930375d, y: 0.4871520032226855d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9459888445904491d, y: 0.7720597763516615d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8854034967195762d, y: 0.02799018830413913d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6711878165344747d, y: 0.4718161678763334d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6749485514584085d, y: 0.9883179858073541d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29595552911092293d, y: 0.26477895318525946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8027104466882493d, y: 0.31057008969212063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9480860917397727d, y: 0.2846764880325402d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10864223898193648d, y: 0.412367813864685d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3311259036583182d, y: 0.27902199525078086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46661541404485973d, y: 0.1476831249026761d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38198809779256804d, y: 0.08199569304770471d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7451481888431889d, y: 0.19094352272658277d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9702050949179831d, y: 0.6157647490712159d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2611394977995102d, y: 0.5263301766973915d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6132611567426536d, y: 0.7159519019771736d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6594712205885828d, y: 0.1645414884410532d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5407391390630499d, y: 0.9475693928133763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9494584716270665d, y: 0.32711554098520945d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25758385732916445d, y: 0.02780505218825413d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5711187878425652d, y: 0.3237528511845861d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6481620227759035d, y: 0.43964136080308613d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2445753897202977d, y: 0.5236986052402374d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05994557022546487d, y: 0.9126130225140998d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2980120039486831d, y: 0.5975894430396509d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4468985774211549d, y: 0.1880245526779124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.961628011314231d, y: 0.002808797371711691d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4336575785188722d, y: 0.09506192670766045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.469876526582541d, y: 0.9743060388627067d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31078126479767065d, y: 0.06503729972960737d),
new NpgsqlTypes.NpgsqlPoint(x: 0.943252037632009d, y: 0.3970803337297638d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40864101137424425d, y: 0.4531371751090906d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37014692397204274d, y: 0.8198743928938478d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5918360307825192d, y: 0.3949827309216073d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5472961821938915d, y: 0.276982629176986d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6730317779460352d, y: 0.11783180896580625d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43408440552422d, y: 0.32728060276476456d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20578426794243498d, y: 0.2268737071569723d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4060249736313368d, y: 0.7911728935443286d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11229580739072753d, y: 0.015851856019582833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34492685036364645d, y: 0.8560791991079764d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6890627437120448d, y: 0.413702546022249d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16176301829991246d, y: 0.041143853311864875d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8902768011305308d, y: 0.6790014021751061d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8179644022229616d, y: 0.6937025397376447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.843557586806878d, y: 0.08532161437692665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6969848429142892d, y: 0.22521157479094212d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18512130343946764d, y: 0.1758311258391717d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6817929443473348d, y: 0.8022259319108106d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8239383000778093d, y: 0.7629637925923356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6114232625558613d, y: 0.4015053258279181d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8799583223642675d, y: 0.1902577262632451d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2701958228792398d, y: 0.7637746765016029d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7472377895958597d, y: 0.6858464629924294d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8471214965873656d, y: 0.43181705318065755d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8699685459568304d, y: 0.21707970593269565d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8198410370204083d, y: 0.8927393273734876d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8481053806493691d, y: 0.44190439889741606d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6595827283919687d, y: 0.5355451551232723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0072771205956393414d, y: 0.8358900266053922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30966128769696577d, y: 0.7714505899310488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8006448228055502d, y: 0.5844890639441107d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0310445704758473d, y: 0.9758148559800358d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5004450871083034d, y: 0.6622801812835241d),
new NpgsqlTypes.NpgsqlPoint(x: 0.908407481472176d, y: 0.28636012801038147d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4994469353796791d, y: 0.36247307162002407d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6862427457224409d, y: 0.873354443929732d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7077012228136418d, y: 0.8637326506256091d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5030079955758211d, y: 0.6369943710373988d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47516085422802623d, y: 0.5601670673492486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1841041724359459d, y: 0.10629627051016277d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.791837950524914d, y: 0.3250048633266448d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3168527154123435d, y: 0.8280292873371501d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34203537600337497d, y: 0.26406586916907093d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3375348921059067d, y: 0.9445689772743362d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4058275388279978d, y: 0.4202979414328547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7681382874399385d, y: 0.68281278266891d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8367504489679225d, y: 0.22931008398651787d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9895580170681623d, y: 0.8282922802974446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9439937611453738d, y: 0.030117054527933895d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9725904168870252d, y: 0.2422179973954045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.349324450737449d, y: 0.7151451233791948d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5627644270904999d, y: 0.31328391406831857d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22221408685979382d, y: 0.02095250824391115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7353956282318382d, y: 0.8760035851555281d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6127058305820251d, y: 0.5417907306235654d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3132745480735911d, y: 0.4572137484376243d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31263878684351243d, y: 0.8865854988941854d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5823111277076897d, y: 0.8557001821204789d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6770246768954731d, y: 0.4867961548805698d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6333778888383895d, y: 0.2782332621639735d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3428208513473132d, y: 0.9402465249925643d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21388720426734809d, y: 0.44178425549444245d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.911588506608608d, y: 0.49322141406235753d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9985662558451663d, y: 0.9735276448381788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8343687992702766d, y: 0.28322494080170724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13999111003263398d, y: 0.5758246992515761d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10170892667852593d, y: 0.9837360794932405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6098737025563713d, y: 0.1980495007181985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07181139909988188d, y: 0.5584043864718797d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 40;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 87;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 79, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 129, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 88, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 57, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 114, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 31, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 45, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

