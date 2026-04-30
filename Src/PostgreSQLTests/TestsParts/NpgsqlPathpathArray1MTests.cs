

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
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4140718162143565d, y: 0.00519844777068712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391958829041195d, y: 0.6049519947070532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7281239731910647d, y: 0.3781908606332951d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6901030883359759d, y: 0.15093638642931162d), new NpgsqlTypes.NpgsqlPoint(x: 0.08541325963485669d, y: 0.5635351114786822d), new NpgsqlTypes.NpgsqlPoint(x: 0.21140855543228643d, y: 0.05277415979518685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016338553557499247d, y: 0.42469242551648734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4791990451770535d, y: 0.6316868838009447d), new NpgsqlTypes.NpgsqlPoint(x: 0.36900886371066566d, y: 0.8053083287692425d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.379193151559474d, y: 0.7378621905421462d), new NpgsqlTypes.NpgsqlPoint(x: 0.4229931473983529d, y: 0.3890026871549094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268972710547189d, y: 0.7701190397186803d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8582853422696212d, y: 0.07924797626543456d), new NpgsqlTypes.NpgsqlPoint(x: 0.4716796388625948d, y: 0.9970729080857036d), new NpgsqlTypes.NpgsqlPoint(x: 0.7000148231066903d, y: 0.34480097524398867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8414486138288935d, y: 0.9366086749523929d), new NpgsqlTypes.NpgsqlPoint(x: 0.13728646284931545d, y: 0.040496257562902094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7236772024183179d, y: 0.36450181126024983d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9113246107701479d, y: 0.5589249762827312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6031547739917787d, y: 0.035918641632142534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872631985669102d, y: 0.3442520387486251d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7142523854340368d, y: 0.1163246421694587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907607736415032d, y: 0.1041587628881292d), new NpgsqlTypes.NpgsqlPoint(x: 0.12453244855818624d, y: 0.25390718602492257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6227347550022441d, y: 0.05852767837277684d), new NpgsqlTypes.NpgsqlPoint(x: 0.12795314276991043d, y: 0.1126742224320938d), new NpgsqlTypes.NpgsqlPoint(x: 0.47616563350174024d, y: 0.28409762209542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029563090723200403d, y: 0.8351256506868124d), new NpgsqlTypes.NpgsqlPoint(x: 0.2019069482160768d, y: 0.9329238196415326d), new NpgsqlTypes.NpgsqlPoint(x: 0.13883770191319345d, y: 0.3854358994772249d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811321087432072d, y: 0.9946359609041218d), new NpgsqlTypes.NpgsqlPoint(x: 0.3276668080932663d, y: 0.15529523049944438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444051539774449d, y: 0.6315471297305859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16816738167666778d, y: 0.30865969664388726d), new NpgsqlTypes.NpgsqlPoint(x: 0.21523075412290382d, y: 0.9460052037547063d), new NpgsqlTypes.NpgsqlPoint(x: 0.40555868478056933d, y: 0.8634029395851462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9372085505475807d, y: 0.7796062811482325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3965092379236673d, y: 0.41537464265387714d), new NpgsqlTypes.NpgsqlPoint(x: 0.27348359142090584d, y: 0.8971200081840939d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24243798276018813d, y: 0.3236041560450035d), new NpgsqlTypes.NpgsqlPoint(x: 0.2621355133956552d, y: 0.9339917144366081d), new NpgsqlTypes.NpgsqlPoint(x: 0.2603920611783881d, y: 0.9217429746467766d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7376638437262911d, y: 0.40087002470822475d), new NpgsqlTypes.NpgsqlPoint(x: 0.32905641490847815d, y: 0.05306342918102114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833857570288755d, y: 0.481523862118418d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9461522441573891d, y: 0.016904779628180377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248808661385395d, y: 0.6724385448737442d), new NpgsqlTypes.NpgsqlPoint(x: 0.38998822996686466d, y: 0.4445529810520248d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09906428123513966d, y: 0.13043278019139648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173336297543916d, y: 0.7560025245936329d), new NpgsqlTypes.NpgsqlPoint(x: 0.966171175028025d, y: 0.5113839231683428d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00570001473021553d, y: 0.7776677445932555d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014238011151662d, y: 0.71696431345086d), new NpgsqlTypes.NpgsqlPoint(x: 0.22455574502124265d, y: 0.7413223721734205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9221540286298197d, y: 0.9477230985902629d), new NpgsqlTypes.NpgsqlPoint(x: 0.08912745876075978d, y: 0.09647603893233125d), new NpgsqlTypes.NpgsqlPoint(x: 0.14610379506072957d, y: 0.3736327615502142d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32947709746578135d, y: 0.38156709828019963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642855268270224d, y: 0.993457020276438d), new NpgsqlTypes.NpgsqlPoint(x: 0.1761915166382958d, y: 0.3689255701075952d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2102504106184102d, y: 0.5352241991741036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974118806091861d, y: 0.07863259595014738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624177032149229d, y: 0.5715409684979549d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5899350639235084d, y: 0.587443107753264d), new NpgsqlTypes.NpgsqlPoint(x: 0.2257940316852951d, y: 0.3122962805171543d), new NpgsqlTypes.NpgsqlPoint(x: 0.3694554773237585d, y: 0.16253962647384357d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19867840890286415d, y: 0.9927395596757614d), new NpgsqlTypes.NpgsqlPoint(x: 0.32678163664821824d, y: 0.04431372303347203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5260083314013947d, y: 0.32034478528132704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6794107827572953d, y: 0.9057280463156054d), new NpgsqlTypes.NpgsqlPoint(x: 0.05264773180079585d, y: 0.6737488437832038d), new NpgsqlTypes.NpgsqlPoint(x: 0.07442504884742274d, y: 0.4591292691020493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9343331777139804d, y: 0.3367911992952749d), new NpgsqlTypes.NpgsqlPoint(x: 0.46906960586651214d, y: 0.6695356883689637d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783785568571874d, y: 0.6465758455190644d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7232289649250986d, y: 0.533479983718432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035079531709929d, y: 0.49670385703439257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5527951646261154d, y: 0.5082054415781907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5600099438012089d, y: 0.26741825425552657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962633913938421d, y: 0.7709653266050537d), new NpgsqlTypes.NpgsqlPoint(x: 0.4343910063844637d, y: 0.21974717915862796d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6640005804767433d, y: 0.37423839904318856d), new NpgsqlTypes.NpgsqlPoint(x: 0.223539405455924d, y: 0.019990648994804294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6081554137677799d, y: 0.934915688321206d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.976656094164108d, y: 0.736405969705506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6782083861642d, y: 0.7236139186151724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572452454513701d, y: 0.29312757944052714d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6857383495153802d, y: 0.9974811907940822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6334333755405226d, y: 0.937632200518888d), new NpgsqlTypes.NpgsqlPoint(x: 0.0817595010530976d, y: 0.857239261626563d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08068859463444245d, y: 0.4387842152097645d), new NpgsqlTypes.NpgsqlPoint(x: 0.41101578325880095d, y: 0.7242688689964575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231679374375606d, y: 0.7771965596158045d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08220369498965263d, y: 0.2592396031902171d), new NpgsqlTypes.NpgsqlPoint(x: 0.09840124335424572d, y: 0.7380853719193364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227745785699633d, y: 0.5460533334773038d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8467986309239817d, y: 0.9615573899220238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6599178622970687d, y: 0.04956032554753187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217599343502352d, y: 0.8984921159530893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40517938791118857d, y: 0.7640215644404068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515767023826433d, y: 0.40949656312529614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7938647127710243d, y: 0.20024514618473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4005716563820254d, y: 0.5052857256342215d), new NpgsqlTypes.NpgsqlPoint(x: 0.3870436367999459d, y: 0.645335115806446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550439686735085d, y: 0.9325503324093521d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46962912031682347d, y: 0.6742054591971582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5158508866050064d, y: 0.7945090581595914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483618891541865d, y: 0.969833425180953d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06239625412137684d, y: 0.6449112728765268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532847900951576d, y: 0.15545443873759313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3971063246182943d, y: 0.15596059113601501d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22394709285353454d, y: 0.6491196242186886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8785449102340704d, y: 0.9856852322450103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7563829791756498d, y: 0.23183512639399328d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9743036646343353d, y: 0.3523019580765945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040299948137124d, y: 0.5722070163726328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9634975152936056d, y: 0.32320034873164516d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2872823057338473d, y: 0.8821539732919355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3344149508488653d, y: 0.00875312712185039d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006046935307831d, y: 0.3010065643853579d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8226200364174652d, y: 0.9802738248672546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247689175295059d, y: 0.09054527502433796d), new NpgsqlTypes.NpgsqlPoint(x: 0.04860742766584758d, y: 0.7882336276968495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4230066274428793d, y: 0.30738332503310506d), new NpgsqlTypes.NpgsqlPoint(x: 0.911864062528514d, y: 0.15527724866203252d), new NpgsqlTypes.NpgsqlPoint(x: 0.0554261066563444d, y: 0.7210135122032976d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6263642995375817d, y: 0.47171875841878697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531321209150091d, y: 0.11279094124522371d), new NpgsqlTypes.NpgsqlPoint(x: 0.09501046677255809d, y: 0.010765430916463425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.557086558407942d, y: 0.5753192024753933d), new NpgsqlTypes.NpgsqlPoint(x: 0.22273791861488113d, y: 0.42473441177077764d), new NpgsqlTypes.NpgsqlPoint(x: 0.16989912381995653d, y: 0.5380261732642153d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14919514274148926d, y: 0.3189312615151727d), new NpgsqlTypes.NpgsqlPoint(x: 0.49830127709636507d, y: 0.891936072433352d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483155380639358d, y: 0.8770150363804489d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9454415908074628d, y: 0.49711327478914824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902645573324903d, y: 0.10415011853138623d), new NpgsqlTypes.NpgsqlPoint(x: 0.13448210751895462d, y: 0.6897450910213666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1589905384764091d, y: 0.3844756175325962d), new NpgsqlTypes.NpgsqlPoint(x: 0.21384449200697808d, y: 0.6703956770383818d), new NpgsqlTypes.NpgsqlPoint(x: 0.4347287465442736d, y: 0.16637931383058857d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15350666311310535d, y: 0.20093935777256133d), new NpgsqlTypes.NpgsqlPoint(x: 0.11202500769076418d, y: 0.338271243529914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355363315458444d, y: 0.266693198564517d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3210375160117789d, y: 0.7438705640948771d), new NpgsqlTypes.NpgsqlPoint(x: 0.017913513977545592d, y: 0.957263605118372d), new NpgsqlTypes.NpgsqlPoint(x: 0.25013840828130707d, y: 0.39049887136336237d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5504911521283729d, y: 0.33988973057232597d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943498385938123d, y: 0.9174095301927608d), new NpgsqlTypes.NpgsqlPoint(x: 0.09601886516202562d, y: 0.24424908792331546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19528458219343403d, y: 0.28198451315631246d), new NpgsqlTypes.NpgsqlPoint(x: 0.27513688249572255d, y: 0.806788913961193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961973022940864d, y: 0.7304767909235864d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12577118356667416d, y: 0.24942189779225488d), new NpgsqlTypes.NpgsqlPoint(x: 0.004800967758086472d, y: 0.987246585514014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485375392018925d, y: 0.5954689945245921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30717983631372836d, y: 0.900999141249504d), new NpgsqlTypes.NpgsqlPoint(x: 0.18674137121808942d, y: 0.6894679544641183d), new NpgsqlTypes.NpgsqlPoint(x: 0.85537152311519d, y: 0.43202149732777007d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8016641786916638d, y: 0.12687099793338408d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390967365842991d, y: 0.34410494836401395d), new NpgsqlTypes.NpgsqlPoint(x: 0.12726089232661164d, y: 0.7884913619429255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7480083947862309d, y: 0.7352465606023705d), new NpgsqlTypes.NpgsqlPoint(x: 0.26399990260635176d, y: 0.770513534973351d), new NpgsqlTypes.NpgsqlPoint(x: 0.4323595486751446d, y: 0.25834161223730023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311933643553275d, y: 0.7798897149107391d), new NpgsqlTypes.NpgsqlPoint(x: 0.1881651770216266d, y: 0.5578989839677624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326667384881979d, y: 0.21157165436411585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5835203610849053d, y: 0.9675477852086849d), new NpgsqlTypes.NpgsqlPoint(x: 0.686645882183514d, y: 0.47837797791383563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7506112057627046d, y: 0.6819023533921736d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7783671764228967d, y: 0.012961750871976374d), new NpgsqlTypes.NpgsqlPoint(x: 0.45638136475981383d, y: 0.7503516183686104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059115245767251d, y: 0.3141222022379111d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.95505077636886d, y: 0.7143494488524117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8603849049152207d, y: 0.7089078591873992d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766480285016846d, y: 0.08371157036934807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6298108847108532d, y: 0.1819462607139689d), new NpgsqlTypes.NpgsqlPoint(x: 0.433709437881287d, y: 0.9169168422141286d), new NpgsqlTypes.NpgsqlPoint(x: 0.33285997410657153d, y: 0.3663069080314788d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4754376178591091d, y: 0.7425605234316534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531747522107971d, y: 0.9879076595052664d), new NpgsqlTypes.NpgsqlPoint(x: 0.32123892961414d, y: 0.5095386815551893d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7373450203798646d, y: 0.7515482049181619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626042676748209d, y: 0.32756367523089835d), new NpgsqlTypes.NpgsqlPoint(x: 0.24624490196887705d, y: 0.8811936286369771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6695372401390633d, y: 0.8076241240502215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7445937692176332d, y: 0.40585084315961295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383995175163893d, y: 0.4888741212827815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48754230617308036d, y: 0.6663431601528946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6398642746179597d, y: 0.9951050546321126d), new NpgsqlTypes.NpgsqlPoint(x: 0.27990165035824277d, y: 0.10377929525069551d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5829280426350174d, y: 0.9474963209590869d), new NpgsqlTypes.NpgsqlPoint(x: 0.49193149236471023d, y: 0.7792485895028658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9336580336247493d, y: 0.1653563097881099d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.995719375561863d, y: 0.3956980397548554d), new NpgsqlTypes.NpgsqlPoint(x: 0.4085971869060807d, y: 0.5720341703493333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350346964938322d, y: 0.7210572132656013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9972042829863875d, y: 0.04931757217778354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4480020238551876d, y: 0.32739897707026133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366610593678113d, y: 0.9020036776402667d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36529482981101d, y: 0.08238163933413811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5059315473149176d, y: 0.7822288559427024d), new NpgsqlTypes.NpgsqlPoint(x: 0.182349242454932d, y: 0.7713817191474281d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4647704980017371d, y: 0.19884766527023445d), new NpgsqlTypes.NpgsqlPoint(x: 0.31775619760283225d, y: 0.6442710674424097d), new NpgsqlTypes.NpgsqlPoint(x: 0.20958644057435383d, y: 0.370389949906227d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45121121683137533d, y: 0.7457899130493586d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277872296732326d, y: 0.7892062283483336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575777112480045d, y: 0.6394910692276712d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5108180035549703d, y: 0.9771088701652869d), new NpgsqlTypes.NpgsqlPoint(x: 0.7386510307262006d, y: 0.7313616678348476d), new NpgsqlTypes.NpgsqlPoint(x: 0.5598410035536444d, y: 0.6554754236343091d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7154376772200803d, y: 0.8559891709751662d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140875628822179d, y: 0.4260344124030767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140621465175764d, y: 0.2538559220356087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4050614598926279d, y: 0.4902077637864505d), new NpgsqlTypes.NpgsqlPoint(x: 0.1961332060714961d, y: 0.8690037276624079d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407497498142132d, y: 0.7552437929441644d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6253394761459423d, y: 0.77474743706955d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246416617095351d, y: 0.5261045933380933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7010691218348449d, y: 0.47364381827831314d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7015087548488024d, y: 0.39571098318653664d), new NpgsqlTypes.NpgsqlPoint(x: 0.07594487019400908d, y: 0.4724504316547403d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197336723141165d, y: 0.8254064363053617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.793560461878602d, y: 0.19515463690579526d), new NpgsqlTypes.NpgsqlPoint(x: 0.1759519304324645d, y: 0.8166575015448876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554300759647007d, y: 0.5408427764217232d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3561124612749522d, y: 0.7748013968859103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665836017042529d, y: 0.8925441352267087d), new NpgsqlTypes.NpgsqlPoint(x: 0.001449871273731529d, y: 0.0730827454106815d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7957941961427717d, y: 0.4638402192814056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737099603815481d, y: 0.48816565429782544d), new NpgsqlTypes.NpgsqlPoint(x: 0.601062869171958d, y: 0.5679678168328939d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9848873657071896d, y: 0.9419212119935065d), new NpgsqlTypes.NpgsqlPoint(x: 0.05817115290813346d, y: 0.12217575619258236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766895292950115d, y: 0.5421070299138968d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5887357603326443d, y: 0.04174313622970516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199620553118054d, y: 0.12087584926657335d), new NpgsqlTypes.NpgsqlPoint(x: 0.49138068803768264d, y: 0.3074343349165273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.037097838434144936d, y: 0.7101381362234308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9635296673905831d, y: 0.4747835734181357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960008829672675d, y: 0.9786723196457977d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42665456802794455d, y: 0.3582322394665123d), new NpgsqlTypes.NpgsqlPoint(x: 0.516333374631752d, y: 0.8543917496380005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703674981894362d, y: 0.0911424302267606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29005538268615805d, y: 0.10628967150688362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314785565823914d, y: 0.8821123929793319d), new NpgsqlTypes.NpgsqlPoint(x: 0.25442721633103194d, y: 0.07237638038410676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669535039948317d, y: 0.12291592274558283d), new NpgsqlTypes.NpgsqlPoint(x: 0.06572243158353575d, y: 0.6574233750249746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642428856604071d, y: 0.7094292621763151d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1426743939605265d, y: 0.8301522280805954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2844465528428327d, y: 0.7650778470024745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964734723690222d, y: 0.146897897407269d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7123575411467252d, y: 0.5779532011594768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7362687824699912d, y: 0.12125663055410574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603417142272164d, y: 0.7349425108094733d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7446217435079181d, y: 0.32273868608119816d), new NpgsqlTypes.NpgsqlPoint(x: 0.11461848243943462d, y: 0.6802456952511506d), new NpgsqlTypes.NpgsqlPoint(x: 0.41581645545745305d, y: 0.7200061670721147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8437048531353868d, y: 0.3437970379749766d), new NpgsqlTypes.NpgsqlPoint(x: 0.04478957746549039d, y: 0.40665574818866834d), new NpgsqlTypes.NpgsqlPoint(x: 0.24491035752138846d, y: 0.7407627280461152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6280236605585386d, y: 0.15527138285915154d), new NpgsqlTypes.NpgsqlPoint(x: 0.8971593411294204d, y: 0.5930707666375079d), new NpgsqlTypes.NpgsqlPoint(x: 0.15479834080025778d, y: 0.4119454827936384d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5062864340213147d, y: 0.8045898456975917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234677172894831d, y: 0.40658722571211325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6261371257607071d, y: 0.4989390609136568d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8125374376387021d, y: 0.6892587891603668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343187882049196d, y: 0.7541895310729818d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732716068109204d, y: 0.48815943471171663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08929131186425954d, y: 0.3395316884143721d), new NpgsqlTypes.NpgsqlPoint(x: 0.49715207843813747d, y: 0.06808143816442458d), new NpgsqlTypes.NpgsqlPoint(x: 0.36346847833636253d, y: 0.47816435968133d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37347080377076736d, y: 0.7672702119070877d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278690505222286d, y: 0.4770134596062191d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276275895408578d, y: 0.6868075738370553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7615890446184473d, y: 0.9087178825714919d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230183547723705d, y: 0.009528621235838641d), new NpgsqlTypes.NpgsqlPoint(x: 0.40056896294483657d, y: 0.10143154081896288d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40989444809792286d, y: 0.47560364387024046d), new NpgsqlTypes.NpgsqlPoint(x: 0.019625351410766156d, y: 0.9806600866257278d), new NpgsqlTypes.NpgsqlPoint(x: 0.27270538337625616d, y: 0.35918529363807716d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8807380854997238d, y: 0.6242245828457607d), new NpgsqlTypes.NpgsqlPoint(x: 0.4961323543740761d, y: 0.16853524843523127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768571851488215d, y: 0.62534468239499d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30674266329725575d, y: 0.3429887938410797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7783803011895446d, y: 0.7519225685560152d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922587500083608d, y: 0.44925955826089337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7803363389860596d, y: 0.7165385407485054d), new NpgsqlTypes.NpgsqlPoint(x: 0.11522420719139903d, y: 0.7245268363716105d), new NpgsqlTypes.NpgsqlPoint(x: 0.043882946147245416d, y: 0.7125713888120089d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8526029214376322d, y: 0.34288381229740617d), new NpgsqlTypes.NpgsqlPoint(x: 0.44418683115730495d, y: 0.11718001251623034d), new NpgsqlTypes.NpgsqlPoint(x: 0.33266386820741767d, y: 0.1961283355660457d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5734929049122237d, y: 0.6592103018112571d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078469786303287d, y: 0.7983326035766534d), new NpgsqlTypes.NpgsqlPoint(x: 0.583194005710353d, y: 0.01903197386449129d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3539050262040524d, y: 0.6801703945003992d), new NpgsqlTypes.NpgsqlPoint(x: 0.752272044798209d, y: 0.5660197338516353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7967662042462716d, y: 0.6332984071461327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.039257004290852104d, y: 0.3712989103677228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5009158134776078d, y: 0.12603572907743432d), new NpgsqlTypes.NpgsqlPoint(x: 0.4965468741483857d, y: 0.7245006660967649d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18201634331643546d, y: 0.38902249745698236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3506632339623942d, y: 0.9049948404156026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6512538515086753d, y: 0.45358439881403645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29355249565384545d, y: 0.8560916545392004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789745417387763d, y: 0.6167604542526941d), new NpgsqlTypes.NpgsqlPoint(x: 0.9436966109048459d, y: 0.9289535487422143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.577743119885464d, y: 0.8079540556338958d), new NpgsqlTypes.NpgsqlPoint(x: 0.4111346402574232d, y: 0.5180998803390505d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518091821357622d, y: 0.1341114634351559d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024668114414186704d, y: 0.21917939186964497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112549199636281d, y: 0.23596229666437696d), new NpgsqlTypes.NpgsqlPoint(x: 0.3018179758482292d, y: 0.8001019108562134d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16749538331758873d, y: 0.50163046181305d), new NpgsqlTypes.NpgsqlPoint(x: 0.11901588654653017d, y: 0.46331219230027154d), new NpgsqlTypes.NpgsqlPoint(x: 0.31299488031646716d, y: 0.4726868632163602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7025339297624958d, y: 0.2559849905333096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289485731790098d, y: 0.5211426150016022d), new NpgsqlTypes.NpgsqlPoint(x: 0.33516043228320325d, y: 0.9013667969827205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.721439587187417d, y: 0.6238897403525011d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768479761973701d, y: 0.9410613410929667d), new NpgsqlTypes.NpgsqlPoint(x: 0.42641238776584856d, y: 0.916050659113974d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23085720185709435d, y: 0.5435742733236775d), new NpgsqlTypes.NpgsqlPoint(x: 0.3262787925004078d, y: 0.7398353168448681d), new NpgsqlTypes.NpgsqlPoint(x: 0.27099766834219574d, y: 0.6025994434093745d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5319320215941733d, y: 0.8076502207258969d), new NpgsqlTypes.NpgsqlPoint(x: 0.35392280121016517d, y: 0.4142793611761374d), new NpgsqlTypes.NpgsqlPoint(x: 0.34018676597326436d, y: 0.448410872052027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38568836827003294d, y: 0.5992783172801595d), new NpgsqlTypes.NpgsqlPoint(x: 0.26198992300333834d, y: 0.8993345646159774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6198723285961957d, y: 0.09379554808120849d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9564463652315753d, y: 0.9608683474509088d), new NpgsqlTypes.NpgsqlPoint(x: 0.07190735446427243d, y: 0.06613688826631725d), new NpgsqlTypes.NpgsqlPoint(x: 0.008593490929997616d, y: 0.7501342376532147d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6836606246341651d, y: 0.4306088731990856d), new NpgsqlTypes.NpgsqlPoint(x: 0.03089771568505595d, y: 0.029656069660061513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4671482753498786d, y: 0.11716841396606725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0704867998696379d, y: 0.4441018530069387d), new NpgsqlTypes.NpgsqlPoint(x: 0.31969521018485614d, y: 0.23115551361114106d), new NpgsqlTypes.NpgsqlPoint(x: 0.06531144841539194d, y: 0.8780987508481133d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6054020433619393d, y: 0.8587916028329439d), new NpgsqlTypes.NpgsqlPoint(x: 0.0308207310063896d, y: 0.6532792199067737d), new NpgsqlTypes.NpgsqlPoint(x: 0.13826390859109028d, y: 0.32277642562589615d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7809817309504723d, y: 0.28137251289810716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7349620840958123d, y: 0.5018252585142128d), new NpgsqlTypes.NpgsqlPoint(x: 0.2560445382649895d, y: 0.3343315869993482d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5000320341047062d, y: 0.6705350754677901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937338039807297d, y: 0.24292673117426644d), new NpgsqlTypes.NpgsqlPoint(x: 0.2057688662558862d, y: 0.4551697922181638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2574235725591961d, y: 0.09519351127715703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366239505635455d, y: 0.8725667576144769d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727244759579093d, y: 0.15036597783317285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20438266918342118d, y: 0.14735195454458827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418245141713837d, y: 0.5641062572734749d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097745882667263d, y: 0.09683255995575868d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8767548967906942d, y: 0.9884593884829336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398555680361323d, y: 0.872756942929767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551628074323167d, y: 0.4484743797997335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7541120256980318d, y: 0.5880700793413641d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670904056337926d, y: 0.4330397706354525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9870712517964236d, y: 0.11736275187927292d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6316822986440704d, y: 0.7742225622083103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807145026687468d, y: 0.9265907790552161d), new NpgsqlTypes.NpgsqlPoint(x: 0.4359694652115593d, y: 0.5600326661829015d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059521268919687675d, y: 0.2448269429796931d), new NpgsqlTypes.NpgsqlPoint(x: 0.4657169966314647d, y: 0.3701191289178354d), new NpgsqlTypes.NpgsqlPoint(x: 0.09190912824965647d, y: 0.22531398815569192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4627845587865411d, y: 0.4555874791515582d), new NpgsqlTypes.NpgsqlPoint(x: 0.14433415688745888d, y: 0.6884162609609836d), new NpgsqlTypes.NpgsqlPoint(x: 0.09564685397088246d, y: 0.9866920225472326d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9762630450212016d, y: 0.18319558178879558d), new NpgsqlTypes.NpgsqlPoint(x: 0.13853880693927056d, y: 0.29126774271064615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926640421988608d, y: 0.6944736164266673d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7505366727823427d, y: 0.8271467408879176d), new NpgsqlTypes.NpgsqlPoint(x: 0.072566133743458d, y: 0.896504268121971d), new NpgsqlTypes.NpgsqlPoint(x: 0.055746527718088745d, y: 0.10711442586055298d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14176840138178948d, y: 0.8122327137473122d), new NpgsqlTypes.NpgsqlPoint(x: 0.28397053966616714d, y: 0.5078181066441403d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823813925532106d, y: 0.32105245173426067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.681544070240362d, y: 0.8497774786425608d), new NpgsqlTypes.NpgsqlPoint(x: 0.964863742564056d, y: 0.4746712680203292d), new NpgsqlTypes.NpgsqlPoint(x: 0.10171938503927824d, y: 0.7688424270292215d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05355820337284534d, y: 0.9045992567160746d), new NpgsqlTypes.NpgsqlPoint(x: 0.501754272839053d, y: 0.8839596563431052d), new NpgsqlTypes.NpgsqlPoint(x: 0.4419657246008091d, y: 0.48095152167616195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311850020925935d, y: 0.6127026146940694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206417207002148d, y: 0.12301227973971507d), new NpgsqlTypes.NpgsqlPoint(x: 0.0037280003096090697d, y: 0.41470855694594944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7203707607072505d, y: 0.6668199597558749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171343624663558d, y: 0.7092900010441859d), new NpgsqlTypes.NpgsqlPoint(x: 0.11371561563674992d, y: 0.7124973857049093d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9210219025388171d, y: 0.647424726829757d), new NpgsqlTypes.NpgsqlPoint(x: 0.24212186908890798d, y: 0.25728682082988596d), new NpgsqlTypes.NpgsqlPoint(x: 0.619923290853546d, y: 0.23460830863417126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6525614194274446d, y: 0.6678936678272058d), new NpgsqlTypes.NpgsqlPoint(x: 0.43457665074155294d, y: 0.631635111984423d), new NpgsqlTypes.NpgsqlPoint(x: 0.998491585512215d, y: 0.7199897495738415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10756020634695451d, y: 0.27386270613209673d), new NpgsqlTypes.NpgsqlPoint(x: 0.512317197072997d, y: 0.9172909293235635d), new NpgsqlTypes.NpgsqlPoint(x: 0.6170239516474891d, y: 0.27619911220570437d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06869020369189183d, y: 0.4796769340099828d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993215562672639d, y: 0.5970564051428704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584714133516224d, y: 0.031485925856146735d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7490182946164283d, y: 0.9154088216205742d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008515603774953d, y: 0.273681827362644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391415415230686d, y: 0.6259882656243021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14180153109307725d, y: 0.9307149478130583d), new NpgsqlTypes.NpgsqlPoint(x: 0.7445447611767564d, y: 0.29036917725910005d), new NpgsqlTypes.NpgsqlPoint(x: 0.4705448807950434d, y: 0.09208768435428316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8248831040012216d, y: 0.9702993747455321d), new NpgsqlTypes.NpgsqlPoint(x: 0.7558156769239797d, y: 0.2808872008064214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4339809527573961d, y: 0.0828313247798349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3098372201190208d, y: 0.6669825034736501d), new NpgsqlTypes.NpgsqlPoint(x: 0.4904270731303658d, y: 0.8199274374298209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5085978853143354d, y: 0.824421796094657d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.908702660910778d, y: 0.8291330402117314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501108620304256d, y: 0.5164085111367454d), new NpgsqlTypes.NpgsqlPoint(x: 0.2576250947519795d, y: 0.13740623992387968d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8730129342230901d, y: 0.47794061324928183d), new NpgsqlTypes.NpgsqlPoint(x: 0.1955326261695951d, y: 0.9384065462752086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570831007569244d, y: 0.9873281782151724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.688899259184418d, y: 0.1027272505132204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4115192257730177d, y: 0.47206104594096243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914735491725187d, y: 0.19338729190445725d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4415815780163419d, y: 0.09202949122820303d), new NpgsqlTypes.NpgsqlPoint(x: 0.34478605789634853d, y: 0.07023342548164035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5600198119824564d, y: 0.9820141924047018d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3128435050242765d, y: 0.1719724756318629d), new NpgsqlTypes.NpgsqlPoint(x: 0.09152341347367987d, y: 0.49830540550416536d), new NpgsqlTypes.NpgsqlPoint(x: 0.47913163272884174d, y: 0.13116022129264548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852682727956538d, y: 0.1752811709607025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383706082899163d, y: 0.4993744540959757d), new NpgsqlTypes.NpgsqlPoint(x: 0.07966669901070222d, y: 0.22676698336498646d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23870836706558385d, y: 0.20884631279798083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545663354012886d, y: 0.46383485190543405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892016101280519d, y: 0.7526032638368493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6718242011963349d, y: 0.6699244396805585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8144480345897877d, y: 0.6603113912179115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9108977522454509d, y: 0.845183194807354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16438932229336867d, y: 0.7199103487471389d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417176746025117d, y: 0.027652424631794736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930997343029458d, y: 0.2991746688113487d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08740944311640231d, y: 0.6103560349657334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572668844583311d, y: 0.12392770881262705d), new NpgsqlTypes.NpgsqlPoint(x: 0.0621315575833814d, y: 0.33496405501111093d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6048874331080156d, y: 0.5577994827396368d), new NpgsqlTypes.NpgsqlPoint(x: 0.48176069692447576d, y: 0.6552560967255021d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235875033772767d, y: 0.8040277900775984d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1654511836290935d, y: 0.6441784840023155d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058911719496735d, y: 0.6905415361709404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6142213536873193d, y: 0.19395713675890636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7281587075313025d, y: 0.021529999063070404d), new NpgsqlTypes.NpgsqlPoint(x: 0.49494890365980804d, y: 0.7111964166395595d), new NpgsqlTypes.NpgsqlPoint(x: 0.34513645807955506d, y: 0.471690477520201d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05254315899779316d, y: 0.745953079603273d), new NpgsqlTypes.NpgsqlPoint(x: 0.7834304862232144d, y: 0.23065778577976548d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429588990275012d, y: 0.13265010543822664d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8772336264546512d, y: 0.8400846418900171d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328771667020594d, y: 0.933902907713244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432204816180669d, y: 0.45848175987391104d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48988243138009946d, y: 0.07668051760535943d), new NpgsqlTypes.NpgsqlPoint(x: 0.34145842443408825d, y: 0.869656761003651d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288661501038473d, y: 0.010256531627902299d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6529905678045307d, y: 0.7791537725256064d), new NpgsqlTypes.NpgsqlPoint(x: 0.016843940747454766d, y: 0.9294726288369018d), new NpgsqlTypes.NpgsqlPoint(x: 0.11899058700352916d, y: 0.5195291994059003d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11813927849731809d, y: 0.42440093700750237d), new NpgsqlTypes.NpgsqlPoint(x: 0.24201035032232043d, y: 0.017749134985606152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8754373180161861d, y: 0.6541705058744609d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0996412859400142d, y: 0.33696937913819747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7534206066706312d, y: 0.49162874725818173d), new NpgsqlTypes.NpgsqlPoint(x: 0.7937155032244907d, y: 0.31925334990990717d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8135566260124861d, y: 0.7644298666132876d), new NpgsqlTypes.NpgsqlPoint(x: 0.1896246353826011d, y: 0.8520876883350396d), new NpgsqlTypes.NpgsqlPoint(x: 0.42854930532181035d, y: 0.10240140945817089d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.413911919504207d, y: 0.7824724650725862d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254898952199039d, y: 0.5300212594231606d), new NpgsqlTypes.NpgsqlPoint(x: 0.3408862800049658d, y: 0.8760350175421752d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.264916974372855d, y: 0.5763218326097749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5326017462738384d, y: 0.9914686517333265d), new NpgsqlTypes.NpgsqlPoint(x: 0.595346830863749d, y: 0.369371622123689d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6073018430167041d, y: 0.14436857148997218d), new NpgsqlTypes.NpgsqlPoint(x: 0.38479842898092587d, y: 0.5850763184042881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562735983001204d, y: 0.7448552938926478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5943420088034321d, y: 0.2992072418317373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3749973332141595d, y: 0.6724247259851315d), new NpgsqlTypes.NpgsqlPoint(x: 0.030736394825240043d, y: 0.263422941009007d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5373652048781461d, y: 0.3754878575274676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172116351554449d, y: 0.7428861076441725d), new NpgsqlTypes.NpgsqlPoint(x: 0.3633321261651784d, y: 0.07009735762061475d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9173679039640906d, y: 0.7698657066636029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9169280800508939d, y: 0.6260362167749739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664498734552222d, y: 0.45181437853773343d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8138288972456421d, y: 0.6935946222038655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349679398112685d, y: 0.7236579905093665d), new NpgsqlTypes.NpgsqlPoint(x: 0.0004282351190832978d, y: 0.46695935013601164d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5524685751823872d, y: 0.4051343217782244d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386139993022644d, y: 0.18646751453842314d), new NpgsqlTypes.NpgsqlPoint(x: 0.22951945837399057d, y: 0.8552881519262507d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19126350564013828d, y: 0.055009586045177916d), new NpgsqlTypes.NpgsqlPoint(x: 0.1915594002603227d, y: 0.8867341085774306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4362382917953038d, y: 0.17974580161756115d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43386176533031795d, y: 0.003128593686878678d), new NpgsqlTypes.NpgsqlPoint(x: 0.886942901105688d, y: 0.6261511467820183d), new NpgsqlTypes.NpgsqlPoint(x: 0.25725672419027534d, y: 0.6486501860666205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14086996386515205d, y: 0.5113113296961411d), new NpgsqlTypes.NpgsqlPoint(x: 0.8745663924456604d, y: 0.7081405244652906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725872273341027d, y: 0.6217935008202311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6273933929908497d, y: 0.11621856410886611d), new NpgsqlTypes.NpgsqlPoint(x: 0.2804048126888362d, y: 0.3229291193394218d), new NpgsqlTypes.NpgsqlPoint(x: 0.32736818919917254d, y: 0.338757789782026d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1638837791420411d, y: 0.5100698399823634d), new NpgsqlTypes.NpgsqlPoint(x: 0.027709017742655218d, y: 0.3675364346876152d), new NpgsqlTypes.NpgsqlPoint(x: 0.12029482918935241d, y: 0.009829462895650343d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45846636281861175d, y: 0.31678452305113247d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822153678774434d, y: 0.7086520468472567d), new NpgsqlTypes.NpgsqlPoint(x: 0.6448487333653938d, y: 0.5113073000419207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6000278187135131d, y: 0.4979913961726462d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897417809188248d, y: 0.3831875589547714d), new NpgsqlTypes.NpgsqlPoint(x: 0.11689142915932016d, y: 0.7584084713781203d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7331515065778533d, y: 0.10306286256892616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5206934143199852d, y: 0.6012157655185058d), new NpgsqlTypes.NpgsqlPoint(x: 0.08280021634193147d, y: 0.5328137996918186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5458468874044458d, y: 0.8577385521674259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5300139008433551d, y: 0.8018795141911755d), new NpgsqlTypes.NpgsqlPoint(x: 0.875878916298784d, y: 0.019965151106752232d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15705300087414764d, y: 0.603558138002487d), new NpgsqlTypes.NpgsqlPoint(x: 0.17064070714921542d, y: 0.5137980807253991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5790131947123052d, y: 0.693248991519906d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3819378373807092d, y: 0.2448415911327524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728534706308187d, y: 0.9664511717266876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7220376078872203d, y: 0.555934050988813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40487903510320644d, y: 0.40006139379520833d), new NpgsqlTypes.NpgsqlPoint(x: 0.46899434104918414d, y: 0.5910046719571416d), new NpgsqlTypes.NpgsqlPoint(x: 0.4425819693322338d, y: 0.9384471582011286d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36361058596249063d, y: 0.09058017093477644d), new NpgsqlTypes.NpgsqlPoint(x: 0.1447093126788347d, y: 0.42880694602284386d), new NpgsqlTypes.NpgsqlPoint(x: 0.784281535742212d, y: 0.6410163248398815d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3747545708750367d, y: 0.6517337123308894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7482493796354444d, y: 0.2073861035227098d), new NpgsqlTypes.NpgsqlPoint(x: 0.26779082892216155d, y: 0.8525537338188308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2925017346624911d, y: 0.9558642974067557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781500888955141d, y: 0.07441044630729243d), new NpgsqlTypes.NpgsqlPoint(x: 0.1016017145878817d, y: 0.9295920463822295d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3705648840923529d, y: 0.3687427203966843d), new NpgsqlTypes.NpgsqlPoint(x: 0.5018659295934151d, y: 0.15887426140159489d), new NpgsqlTypes.NpgsqlPoint(x: 0.0879011957456447d, y: 0.591146486393507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7095940590265134d, y: 0.46838226006508465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7752161402938228d, y: 0.5477999025730651d), new NpgsqlTypes.NpgsqlPoint(x: 0.4934795583150582d, y: 0.8788940942533596d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8150154046790425d, y: 0.7720269635241664d), new NpgsqlTypes.NpgsqlPoint(x: 0.20935028865407046d, y: 0.8506581332087357d), new NpgsqlTypes.NpgsqlPoint(x: 0.40503135644233235d, y: 0.913822346918943d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49612141471841265d, y: 0.13694432855423855d), new NpgsqlTypes.NpgsqlPoint(x: 0.48163071217486886d, y: 0.7192538945255679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8663072388433886d, y: 0.7382304021418673d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06299157646803555d, y: 0.06989634387316679d), new NpgsqlTypes.NpgsqlPoint(x: 0.9255879340592673d, y: 0.9124641400198501d), new NpgsqlTypes.NpgsqlPoint(x: 0.19904003509704804d, y: 0.9046710866803881d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24469719096834996d, y: 0.9857013720940883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920402771755092d, y: 0.6524169447211436d), new NpgsqlTypes.NpgsqlPoint(x: 0.1250239955664455d, y: 0.20612494963220407d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5955268710053083d, y: 0.2888067732382307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5601510607924235d, y: 0.3911470175630596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130229350124256d, y: 0.5692319730685933d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2811782690225746d, y: 0.6987687647046686d), new NpgsqlTypes.NpgsqlPoint(x: 0.7071850650977396d, y: 0.993354185033628d), new NpgsqlTypes.NpgsqlPoint(x: 0.18991798855166342d, y: 0.5188466537390132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7534113462616262d, y: 0.2715074895208628d), new NpgsqlTypes.NpgsqlPoint(x: 0.45544543749560573d, y: 0.1974347906559636d), new NpgsqlTypes.NpgsqlPoint(x: 0.09023040103561653d, y: 0.7171203943202686d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39926552891064704d, y: 0.36227692349641183d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111306083289416d, y: 0.2341234635962166d), new NpgsqlTypes.NpgsqlPoint(x: 0.46635993039601287d, y: 0.38894466922553417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556891494422183d, y: 0.6018846136225917d), new NpgsqlTypes.NpgsqlPoint(x: 0.10247419671987135d, y: 0.7526848366525665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4446910318334216d, y: 0.25926211359961826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8034010820645534d, y: 0.7071137420703674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606430218598882d, y: 0.8814899324219493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597949559496106d, y: 0.8448008269407539d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6676394141510064d, y: 0.8909146523394291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790866112733726d, y: 0.7795679152698374d), new NpgsqlTypes.NpgsqlPoint(x: 0.1856352575790733d, y: 0.6998230341632211d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12101787041159429d, y: 0.158645719842186d), new NpgsqlTypes.NpgsqlPoint(x: 0.446207952236105d, y: 0.29861691797795376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8767278197663492d, y: 0.5995797765005921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5224177034424949d, y: 0.23114316007751634d), new NpgsqlTypes.NpgsqlPoint(x: 0.498314665973555d, y: 0.5531692302148434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6686021147375107d, y: 0.9203419364307797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.671853367468947d, y: 0.47451114717230414d), new NpgsqlTypes.NpgsqlPoint(x: 0.1402778526085141d, y: 0.7066071086143794d), new NpgsqlTypes.NpgsqlPoint(x: 0.28638243884383296d, y: 0.4363388299883384d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15459796101884926d, y: 0.11065451095790968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531623884384526d, y: 0.8579816563022492d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587531321779481d, y: 0.04037494230488603d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9782427695692604d, y: 0.8610843671677118d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106529702231174d, y: 0.10821301540223505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8192292560287865d, y: 0.4577527970585258d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11644312024760906d, y: 0.47197082345245733d), new NpgsqlTypes.NpgsqlPoint(x: 0.015364322775711647d, y: 0.46063081014681684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606290403504511d, y: 0.6039795425957809d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8238208142278592d, y: 0.36309335795283637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802484219128501d, y: 0.4630270219378839d), new NpgsqlTypes.NpgsqlPoint(x: 0.13686778606591876d, y: 0.2556110701270363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754162902801528d, y: 0.09735258657688761d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193689222104503d, y: 0.0013522290951315519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948459675810935d, y: 0.7898638615491347d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5480160387544797d, y: 0.6385980068065571d), new NpgsqlTypes.NpgsqlPoint(x: 0.27472646468930795d, y: 0.3032496410872164d), new NpgsqlTypes.NpgsqlPoint(x: 0.03749779979537615d, y: 0.8388297147277304d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03184459202832701d, y: 0.2162637769129393d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539288300307292d, y: 0.427489193874652d), new NpgsqlTypes.NpgsqlPoint(x: 0.1742137857678535d, y: 0.7608356147680599d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7543851439292294d, y: 0.2383590000723187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298693983572083d, y: 0.1288792885006561d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166891639400907d, y: 0.14252842768989893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8178532964018882d, y: 0.7723826389404974d), new NpgsqlTypes.NpgsqlPoint(x: 0.34089651642693364d, y: 0.18221086318957225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4984718731841633d, y: 0.02599896872981089d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7624575220676953d, y: 0.7155763661978001d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476704765196014d, y: 0.06869105452360702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317824572918124d, y: 0.8691125140630361d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5468298742526668d, y: 0.69829069396187d), new NpgsqlTypes.NpgsqlPoint(x: 0.23123539142939697d, y: 0.9963361047382053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5907804353690239d, y: 0.5786510535606029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5916706656591886d, y: 0.9446037206659574d), new NpgsqlTypes.NpgsqlPoint(x: 0.20060278670772713d, y: 0.40706584285871705d), new NpgsqlTypes.NpgsqlPoint(x: 0.46577323113074187d, y: 0.8993395293588131d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9735846030903142d, y: 0.2257663452316595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707281076788691d, y: 0.38673033307435634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3954290240995155d, y: 0.12411314136970031d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08057414731878276d, y: 0.11238475600602371d), new NpgsqlTypes.NpgsqlPoint(x: 0.17144900774458638d, y: 0.7874128893567222d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779681039005067d, y: 0.949057315378982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07393185873430863d, y: 0.13472454649318122d), new NpgsqlTypes.NpgsqlPoint(x: 0.3689365222874542d, y: 0.34864290615944293d), new NpgsqlTypes.NpgsqlPoint(x: 0.12897860647986703d, y: 0.7877963478454113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15415688284722429d, y: 0.8436612044027858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249721373191018d, y: 0.7704479041129471d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510067238162357d, y: 0.14873549074735637d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40157184310648886d, y: 0.6081705662854541d), new NpgsqlTypes.NpgsqlPoint(x: 0.602088073416859d, y: 0.6242478419318276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8900712976725375d, y: 0.9581691543121257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9405685889252764d, y: 0.6541509735725697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801693312488413d, y: 0.35514091695989847d), new NpgsqlTypes.NpgsqlPoint(x: 0.10835394778880236d, y: 0.3670295425253639d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35216482464795784d, y: 0.36940556206204145d), new NpgsqlTypes.NpgsqlPoint(x: 0.949917330634681d, y: 0.9712395798109065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9497630280182623d, y: 0.953879736380349d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3173530970068714d, y: 0.36259337063601016d), new NpgsqlTypes.NpgsqlPoint(x: 0.06623685652034295d, y: 0.12033388268467737d), new NpgsqlTypes.NpgsqlPoint(x: 0.36757640945506176d, y: 0.005566600888745832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40580187899706377d, y: 0.16666857781606148d), new NpgsqlTypes.NpgsqlPoint(x: 0.54477236891343d, y: 0.6553040510070403d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039844447598325d, y: 0.6211593891886523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3968758785313705d, y: 0.4957896552925154d), new NpgsqlTypes.NpgsqlPoint(x: 0.03783644202732739d, y: 0.7509134466496074d), new NpgsqlTypes.NpgsqlPoint(x: 0.652511715700635d, y: 0.07135774669062278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6137566953950229d, y: 0.8525685290832435d), new NpgsqlTypes.NpgsqlPoint(x: 0.35889395224880205d, y: 0.5521416237729073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3332601162126845d, y: 0.9919043755034758d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991961637844313d, y: 0.14137745048404537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975829316882167d, y: 0.6141453570805699d), new NpgsqlTypes.NpgsqlPoint(x: 0.2191685067586241d, y: 0.48330388796472445d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01779301668051969d, y: 0.55517824429184d), new NpgsqlTypes.NpgsqlPoint(x: 0.35703856524020383d, y: 0.8711393843845638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501154991314739d, y: 0.0893154618435007d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7930197542999847d, y: 0.4335018435914466d), new NpgsqlTypes.NpgsqlPoint(x: 0.24053077825180913d, y: 0.9827044327708324d), new NpgsqlTypes.NpgsqlPoint(x: 0.49934488138894817d, y: 0.49065353525422273d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8901997567946387d, y: 0.9281067244227227d), new NpgsqlTypes.NpgsqlPoint(x: 0.8533159003538683d, y: 0.01999508086137025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852866373140964d, y: 0.28273592908675504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1561203732585441d, y: 0.8080441856649011d), new NpgsqlTypes.NpgsqlPoint(x: 0.4156115968128423d, y: 0.37888532701934996d), new NpgsqlTypes.NpgsqlPoint(x: 0.36278338859114334d, y: 0.3756771550584187d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19115002573247786d, y: 0.1814589781423369d), new NpgsqlTypes.NpgsqlPoint(x: 0.35186227439240336d, y: 0.11398538965318206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833470121626762d, y: 0.21583793054714118d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9959674786285089d, y: 0.26830722004128815d), new NpgsqlTypes.NpgsqlPoint(x: 0.21727188709239098d, y: 0.546234861562657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5697670397504004d, y: 0.29205386568757397d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47123890370075383d, y: 0.710087765028793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988336009100478d, y: 0.2877878428166777d), new NpgsqlTypes.NpgsqlPoint(x: 0.78167198936437d, y: 0.1620547968432362d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6533038567014886d, y: 0.405234102087512d), new NpgsqlTypes.NpgsqlPoint(x: 0.026242938459162923d, y: 0.31663533505756825d), new NpgsqlTypes.NpgsqlPoint(x: 0.5380149028390295d, y: 0.2172319230204638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18097717000336533d, y: 0.46746834183853525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869157731091943d, y: 0.7697619621136134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9530427888950678d, y: 0.11932828374706406d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9260018544340474d, y: 0.9465115020242515d), new NpgsqlTypes.NpgsqlPoint(x: 0.051399861186136486d, y: 0.3010665977073802d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780782646800297d, y: 0.007287417419920894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6729153364209035d, y: 0.8915209840284202d), new NpgsqlTypes.NpgsqlPoint(x: 0.41131135113118766d, y: 0.32993133361420623d), new NpgsqlTypes.NpgsqlPoint(x: 0.37867345795864293d, y: 0.6151476522359974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3994580951562431d, y: 0.03943400197414193d), new NpgsqlTypes.NpgsqlPoint(x: 0.4532168300778391d, y: 0.8939332232070638d), new NpgsqlTypes.NpgsqlPoint(x: 0.9941818644946135d, y: 0.8375181264473581d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.695167986006021d, y: 0.9233358674427689d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395201102058334d, y: 0.1987968039091399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440285232521151d, y: 0.2411788683223861d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6761046686226277d, y: 0.5849722117131871d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733685811080919d, y: 0.03812600672910238d), new NpgsqlTypes.NpgsqlPoint(x: 0.3452796160681342d, y: 0.10870780943565117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5398784234426504d, y: 0.417804300243389d), new NpgsqlTypes.NpgsqlPoint(x: 0.47833311872499107d, y: 0.09318240743530781d), new NpgsqlTypes.NpgsqlPoint(x: 0.45998904016517195d, y: 0.14407153201345935d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4167609665702309d, y: 0.9496157834478895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664997578421365d, y: 0.5144261127554919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242650544524334d, y: 0.2013536167983827d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5400243878745539d, y: 0.0002175881551562675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830174756269652d, y: 0.30755861215658253d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409155725322576d, y: 0.2776743151386638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8399366690612996d, y: 0.7876476497481764d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222348313111687d, y: 0.7540316956898329d), new NpgsqlTypes.NpgsqlPoint(x: 0.7585555642349714d, y: 0.6192575366360461d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7745917566711987d, y: 0.21682607278418975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8711163529549003d, y: 0.9662497954029861d), new NpgsqlTypes.NpgsqlPoint(x: 0.13994113617966764d, y: 0.5347734681635031d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10255832894024508d, y: 0.996113826583751d), new NpgsqlTypes.NpgsqlPoint(x: 0.11594631525997279d, y: 0.7227336435605121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037127325875817d, y: 0.9378862988989175d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5773617769965014d, y: 0.9056354518098695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6959519065835172d, y: 0.7230118582404529d), new NpgsqlTypes.NpgsqlPoint(x: 0.8682748495246981d, y: 0.47322214550967345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5199221694388303d, y: 0.2697071878599552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8895495447833861d, y: 0.3055158106269613d), new NpgsqlTypes.NpgsqlPoint(x: 0.12809315757378648d, y: 0.8970232782474246d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4079710820481772d, y: 0.13036910541876845d), new NpgsqlTypes.NpgsqlPoint(x: 0.387559232265806d, y: 0.7307409990579358d), new NpgsqlTypes.NpgsqlPoint(x: 0.5633257527371496d, y: 0.2871951482004661d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.517014792692446d, y: 0.6502759377948102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531548890827093d, y: 0.6265248764034043d), new NpgsqlTypes.NpgsqlPoint(x: 0.18127591092706896d, y: 0.6856308667785312d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054302470692700666d, y: 0.5895188506889055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540817200711073d, y: 0.03717970703599893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5584245532205606d, y: 0.2153302162892784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2685838530982846d, y: 0.06623833430889003d), new NpgsqlTypes.NpgsqlPoint(x: 0.904627371965558d, y: 0.26209460215237146d), new NpgsqlTypes.NpgsqlPoint(x: 0.10897813981201321d, y: 0.5319001773037193d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9648719698414772d, y: 0.3395567855999423d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634334300005831d, y: 0.7704951737317999d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648557400488787d, y: 0.22157539706089702d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7329569825946471d, y: 0.09226572580417913d), new NpgsqlTypes.NpgsqlPoint(x: 0.4064024087851148d, y: 0.6548254354069136d), new NpgsqlTypes.NpgsqlPoint(x: 0.22372482871900812d, y: 0.13900469501437573d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29292062751427994d, y: 0.5825344307675168d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015207833415182d, y: 0.2567116816996873d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933779267199467d, y: 0.5461362367447585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22650054086133564d, y: 0.9672011133597187d), new NpgsqlTypes.NpgsqlPoint(x: 0.1086034179499108d, y: 0.3076850873907989d), new NpgsqlTypes.NpgsqlPoint(x: 0.510943507991133d, y: 0.7186044453908199d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7762607836234113d, y: 0.5649383448216941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107412833487536d, y: 0.5630094780958887d), new NpgsqlTypes.NpgsqlPoint(x: 0.381228113175091d, y: 0.6457474806343655d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27846211946640076d, y: 0.8957284761401463d), new NpgsqlTypes.NpgsqlPoint(x: 0.1898717463563424d, y: 0.6859643220080994d), new NpgsqlTypes.NpgsqlPoint(x: 0.620700088277749d, y: 0.8357151422760147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.924591210969465d, y: 0.7537204799405702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7620469860751904d, y: 0.6376274021623515d), new NpgsqlTypes.NpgsqlPoint(x: 0.08966546935669784d, y: 0.6829682533645207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7904832681443523d, y: 0.7688225858300388d), new NpgsqlTypes.NpgsqlPoint(x: 0.388332302175876d, y: 0.6487553982823142d), new NpgsqlTypes.NpgsqlPoint(x: 0.14763438179139088d, y: 0.9703737442321546d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7031265751857764d, y: 0.358429554235252d), new NpgsqlTypes.NpgsqlPoint(x: 0.155854812210117d, y: 0.5968453659028412d), new NpgsqlTypes.NpgsqlPoint(x: 0.12602022765852827d, y: 0.8105441707733868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07837668035621292d, y: 0.230319427706541d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288599099242531d, y: 0.7347651823672624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638618180106019d, y: 0.17173304922123533d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6382288829972239d, y: 0.9699554390736286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9963290721375544d, y: 0.0020054969781165832d), new NpgsqlTypes.NpgsqlPoint(x: 0.29025478075944156d, y: 0.9245178063497416d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31034749303670817d, y: 0.15662999124197075d), new NpgsqlTypes.NpgsqlPoint(x: 0.44809507926802605d, y: 0.326320956196699d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004229662276042d, y: 0.15884974851671718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.387278357738274d, y: 0.3928984478856654d), new NpgsqlTypes.NpgsqlPoint(x: 0.002668264258843922d, y: 0.19991742195780893d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374781222988992d, y: 0.4932705634516483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9546522440103051d, y: 0.747023503004211d), new NpgsqlTypes.NpgsqlPoint(x: 0.23088812845391027d, y: 0.8520460700042851d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231733410272154d, y: 0.7075604789410561d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07773374273828582d, y: 0.46638189121967166d), new NpgsqlTypes.NpgsqlPoint(x: 0.25804747110390314d, y: 0.45616105344743396d), new NpgsqlTypes.NpgsqlPoint(x: 0.0964177030007708d, y: 0.7567311775994094d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31721669541783104d, y: 0.616837646979558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9276151859192884d, y: 0.7198416783659649d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001099996056104d, y: 0.6781910678146643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9527833578289081d, y: 0.8627767826053403d), new NpgsqlTypes.NpgsqlPoint(x: 0.17953652095243655d, y: 0.8453243406905033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037184952216277d, y: 0.5087240835327401d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49051024788419395d, y: 0.5830391031112667d), new NpgsqlTypes.NpgsqlPoint(x: 0.6697891739735193d, y: 0.08624590323562109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897595931375653d, y: 0.7648213332931619d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9634948901421999d, y: 0.788846303456457d), new NpgsqlTypes.NpgsqlPoint(x: 0.47553138594965805d, y: 0.2184923984070697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089976006407672d, y: 0.8778196138110373d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8976100466466076d, y: 0.06748698803231423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573426490042052d, y: 0.052061734433908824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889491746988739d, y: 0.8570317644699135d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.66570302644829d, y: 0.9423373575646934d), new NpgsqlTypes.NpgsqlPoint(x: 0.14531565261153667d, y: 0.8658141100799764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9237106413806971d, y: 0.9444868631832347d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7249416117459866d, y: 0.6341465981999556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732956631387099d, y: 0.194421177079247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575116737367654d, y: 0.747224505055764d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7911494926963546d, y: 0.6770471494731196d), new NpgsqlTypes.NpgsqlPoint(x: 0.1260122023621726d, y: 0.7377790817213643d), new NpgsqlTypes.NpgsqlPoint(x: 0.4950192201988882d, y: 0.1275274001604777d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07079910436005277d, y: 0.5877144329358729d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418431065038248d, y: 0.057074318663502877d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224982850290034d, y: 0.5925763288430994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156140484237235d, y: 0.06402498825456038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283235478607766d, y: 0.6551848808167169d), new NpgsqlTypes.NpgsqlPoint(x: 0.21449198574214168d, y: 0.7650622551904632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40343093309834055d, y: 0.013906012023295777d), new NpgsqlTypes.NpgsqlPoint(x: 0.4734915725732035d, y: 0.8753409674416556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888674239370665d, y: 0.8672140655031988d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1400939518869383d, y: 0.054364952577046766d), new NpgsqlTypes.NpgsqlPoint(x: 0.31105678015401883d, y: 0.7743909312369837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6979901955797351d, y: 0.19964898834098266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8948776496193742d, y: 0.20829037558160446d), new NpgsqlTypes.NpgsqlPoint(x: 0.420983464705756d, y: 0.44229449046591307d), new NpgsqlTypes.NpgsqlPoint(x: 0.0347270471808393d, y: 0.9836904607997523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.730334126921509d, y: 0.49688713513692406d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771574847300482d, y: 0.5262875013662027d), new NpgsqlTypes.NpgsqlPoint(x: 0.06947751542409952d, y: 0.026063084148164162d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11778325118570798d, y: 0.8114069688329136d), new NpgsqlTypes.NpgsqlPoint(x: 0.23627651469947775d, y: 0.13112689523121246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960864430312373d, y: 0.6543606617464002d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.662091757115867d, y: 0.9535602846174559d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185217838961176d, y: 0.1580024694972072d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313576808190267d, y: 0.9935606355435336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7968825155038028d, y: 0.17920676542757796d), new NpgsqlTypes.NpgsqlPoint(x: 0.09323555173399711d, y: 0.5104613138553773d), new NpgsqlTypes.NpgsqlPoint(x: 0.43371400707468d, y: 0.1856363527767868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4829690496678919d, y: 0.672917275328823d), new NpgsqlTypes.NpgsqlPoint(x: 0.37992539399033376d, y: 0.6091811471085884d), new NpgsqlTypes.NpgsqlPoint(x: 0.00635420221171934d, y: 0.22714399832775178d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31885442268758646d, y: 0.021575504614737784d), new NpgsqlTypes.NpgsqlPoint(x: 0.042326242357580646d, y: 0.3259143913456465d), new NpgsqlTypes.NpgsqlPoint(x: 0.04208012598197808d, y: 0.01098987566846854d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2561871810823527d, y: 0.43046292037688083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975620385577309d, y: 0.1596643242368162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823396357115076d, y: 0.4180907668877457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371994736471231d, y: 0.15650815363445902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541475526252433d, y: 0.15081403326912968d), new NpgsqlTypes.NpgsqlPoint(x: 0.866123955826272d, y: 0.08573725911599706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15285024063103259d, y: 0.32439405353778494d), new NpgsqlTypes.NpgsqlPoint(x: 0.42074795254970654d, y: 0.3476241528159162d), new NpgsqlTypes.NpgsqlPoint(x: 0.350649381003576d, y: 0.18302064798011886d)),
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2872823057338473d, y: 0.8821539732919355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3344149508488653d, y: 0.00875312712185039d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006046935307831d, y: 0.3010065643853579d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8226200364174652d, y: 0.9802738248672546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247689175295059d, y: 0.09054527502433796d), new NpgsqlTypes.NpgsqlPoint(x: 0.04860742766584758d, y: 0.7882336276968495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4230066274428793d, y: 0.30738332503310506d), new NpgsqlTypes.NpgsqlPoint(x: 0.911864062528514d, y: 0.15527724866203252d), new NpgsqlTypes.NpgsqlPoint(x: 0.0554261066563444d, y: 0.7210135122032976d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8016641786916638d, y: 0.12687099793338408d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390967365842991d, y: 0.34410494836401395d), new NpgsqlTypes.NpgsqlPoint(x: 0.12726089232661164d, y: 0.7884913619429255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7480083947862309d, y: 0.7352465606023705d), new NpgsqlTypes.NpgsqlPoint(x: 0.26399990260635176d, y: 0.770513534973351d), new NpgsqlTypes.NpgsqlPoint(x: 0.4323595486751446d, y: 0.25834161223730023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311933643553275d, y: 0.7798897149107391d), new NpgsqlTypes.NpgsqlPoint(x: 0.1881651770216266d, y: 0.5578989839677624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326667384881979d, y: 0.21157165436411585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5835203610849053d, y: 0.9675477852086849d), new NpgsqlTypes.NpgsqlPoint(x: 0.686645882183514d, y: 0.47837797791383563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7506112057627046d, y: 0.6819023533921736d)),
}));
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7373450203798646d, y: 0.7515482049181619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626042676748209d, y: 0.32756367523089835d), new NpgsqlTypes.NpgsqlPoint(x: 0.24624490196887705d, y: 0.8811936286369771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6695372401390633d, y: 0.8076241240502215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7445937692176332d, y: 0.40585084315961295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383995175163893d, y: 0.4888741212827815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48754230617308036d, y: 0.6663431601528946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6398642746179597d, y: 0.9951050546321126d), new NpgsqlTypes.NpgsqlPoint(x: 0.27990165035824277d, y: 0.10377929525069551d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7015087548488024d, y: 0.39571098318653664d), new NpgsqlTypes.NpgsqlPoint(x: 0.07594487019400908d, y: 0.4724504316547403d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197336723141165d, y: 0.8254064363053617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.793560461878602d, y: 0.19515463690579526d), new NpgsqlTypes.NpgsqlPoint(x: 0.1759519304324645d, y: 0.8166575015448876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554300759647007d, y: 0.5408427764217232d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3561124612749522d, y: 0.7748013968859103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665836017042529d, y: 0.8925441352267087d), new NpgsqlTypes.NpgsqlPoint(x: 0.001449871273731529d, y: 0.0730827454106815d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37347080377076736d, y: 0.7672702119070877d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278690505222286d, y: 0.4770134596062191d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276275895408578d, y: 0.6868075738370553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7615890446184473d, y: 0.9087178825714919d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230183547723705d, y: 0.009528621235838641d), new NpgsqlTypes.NpgsqlPoint(x: 0.40056896294483657d, y: 0.10143154081896288d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40989444809792286d, y: 0.47560364387024046d), new NpgsqlTypes.NpgsqlPoint(x: 0.019625351410766156d, y: 0.9806600866257278d), new NpgsqlTypes.NpgsqlPoint(x: 0.27270538337625616d, y: 0.35918529363807716d)),
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr2.Value = 9;
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[31],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 89, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 32, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 153, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 133, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 46, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 14, 89))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[34], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
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

