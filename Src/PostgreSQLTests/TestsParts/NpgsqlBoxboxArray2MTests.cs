

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7413523608857366d,right: 0.4149131064986591d,bottom: 0.29964631076607673d,left: 0.27632568352311626d),

new NpgsqlTypes.NpgsqlBox(top: 0.717685406335804d,right: 0.9898270096415698d,bottom: 0.6180401662155005d,left: 0.8713550666558441d),

new NpgsqlTypes.NpgsqlBox(top: 0.27897305116314786d,right: 0.8824689425666054d,bottom: 0.14477228302408596d,left: 0.7437502551022502d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.721806330753715d,right: 0.8476434482684575d,bottom: 0.5175585280344692d,left: 0.5702124387715468d),

new NpgsqlTypes.NpgsqlBox(top: 0.5623942034815077d,right: 0.9006251658439688d,bottom: 0.1936164660428451d,left: 0.29678059138656676d),

new NpgsqlTypes.NpgsqlBox(top: 0.5056652575537546d,right: 0.990693278657882d,bottom: 0.3579221575068021d,left: 0.7816590918193195d),

new NpgsqlTypes.NpgsqlBox(top: 0.7796510414649929d,right: 0.6999228523876682d,bottom: 0.6267159756493882d,left: 0.3880900993714711d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.774988233583019d,right: 0.7812862369669593d,bottom: 0.28436690631585715d,left: 0.3523570901278581d),

new NpgsqlTypes.NpgsqlBox(top: 0.8220193528599421d,right: 0.6368133714684014d,bottom: 0.11121222391403385d,left: 0.5426451998105769d),

new NpgsqlTypes.NpgsqlBox(top: 0.8902816685193176d,right: 0.6398041951707332d,bottom: 0.6477558526381378d,left: 0.21089891992177834d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2926162049625566d,right: 0.6056744735285882d,bottom: 0.2637892541367397d,left: 0.04342108142106815d),

new NpgsqlTypes.NpgsqlBox(top: 0.6821542413204321d,right: 0.5274963633847085d,bottom: 0.06454685729156018d,left: 0.13069461652941972d),

new NpgsqlTypes.NpgsqlBox(top: 0.9772830696363792d,right: 0.4254060799336651d,bottom: 0.8487398822584612d,left: 0.3982663019485143d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8878925064734801d,right: 0.6917400134362998d,bottom: 0.045711422487193065d,left: 0.622055108230926d),

new NpgsqlTypes.NpgsqlBox(top: 0.824466893003212d,right: 0.29063191623044504d,bottom: 0.5049991392314932d,left: 0.25295397999300184d),

new NpgsqlTypes.NpgsqlBox(top: 0.33689615358661895d,right: 0.9712983636126323d,bottom: 0.2560909530048707d,left: 0.13149085916648973d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7044459317490696d,right: 0.5442042615855897d,bottom: 0.2033279126310389d,left: 0.1436069546227301d),

new NpgsqlTypes.NpgsqlBox(top: 0.895428625811248d,right: 0.3831688959647457d,bottom: 0.6103580301789046d,left: 0.3205328013320713d),

new NpgsqlTypes.NpgsqlBox(top: 0.9681080475843885d,right: 0.6582534981498767d,bottom: 0.1453416607686907d,left: 0.1624684252730748d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7747671717075172d,right: 0.8546821853766888d,bottom: 0.11155744538751089d,left: 0.23864182685061452d),

new NpgsqlTypes.NpgsqlBox(top: 0.7985567286839281d,right: 0.9831534732733423d,bottom: 0.05496685481053021d,left: 0.742914125007885d),

new NpgsqlTypes.NpgsqlBox(top: 0.6541951001192938d,right: 0.9358441001578938d,bottom: 0.23674276941754102d,left: 0.917193612238026d),

new NpgsqlTypes.NpgsqlBox(top: 0.7731631602244461d,right: 0.7746437433913967d,bottom: 0.41943342326561794d,left: 0.2278613699351436d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6535512554896451d,right: 0.46350458466310207d,bottom: 0.11137619339238514d,left: 0.1327366029998852d),

new NpgsqlTypes.NpgsqlBox(top: 0.7980524591848049d,right: 0.41784542525731605d,bottom: 0.6266137710832717d,left: 0.001344116037366505d),

new NpgsqlTypes.NpgsqlBox(top: 0.9280726130689092d,right: 0.6514230850453774d,bottom: 0.4383465067875806d,left: 0.4152475013406064d),

new NpgsqlTypes.NpgsqlBox(top: 0.535642717839242d,right: 0.9028058639975979d,bottom: 0.34719097250094655d,left: 0.07819942117009016d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9733400364750652d,right: 0.4927907796415565d,bottom: 0.3746592735330946d,left: 0.4792472717269993d),

new NpgsqlTypes.NpgsqlBox(top: 0.6006659405859139d,right: 0.9412626359440195d,bottom: 0.43373500220233374d,left: 0.7474964557895396d),

new NpgsqlTypes.NpgsqlBox(top: 0.6432902802213455d,right: 0.5146273722631634d,bottom: 0.41062647357365223d,left: 0.2732371624607217d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.19579929932421403d,right: 0.9476230959807674d,bottom: 0.18000702159080717d,left: 0.5495494059085084d),

new NpgsqlTypes.NpgsqlBox(top: 0.8800566675958689d,right: 0.845757438665014d,bottom: 0.5812116766354459d,left: 0.2912985873104458d),

new NpgsqlTypes.NpgsqlBox(top: 0.996174424989787d,right: 0.9330006923194143d,bottom: 0.49044488562791444d,left: 0.43231040376719254d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7816022056426113d,right: 0.9331068591778984d,bottom: 0.13281870647731564d,left: 0.1174283296065659d),

new NpgsqlTypes.NpgsqlBox(top: 0.9593917246456626d,right: 0.8278655406506421d,bottom: 0.6063346495117197d,left: 0.7304023894212671d),

new NpgsqlTypes.NpgsqlBox(top: 0.7309185141199427d,right: 0.19600107838365743d,bottom: 0.1638449164487068d,left: 0.18854175541372953d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7493053783015274d,right: 0.5383031323662583d,bottom: 0.6794600399520457d,left: 0.1488273463065215d),

new NpgsqlTypes.NpgsqlBox(top: 0.7374247923680829d,right: 0.8360652391060633d,bottom: 0.7347534691178702d,left: 0.7991437246118958d),

new NpgsqlTypes.NpgsqlBox(top: 0.6966276009570807d,right: 0.2410636936896282d,bottom: 0.3765715333892259d,left: 0.22233979228425926d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7737446581326279d,right: 0.3448977899319724d,bottom: 0.5294423579749109d,left: 0.34213730083176763d),

new NpgsqlTypes.NpgsqlBox(top: 0.8544291759755759d,right: 0.6093442167035503d,bottom: 0.3001212457143765d,left: 0.41952339818978535d),

new NpgsqlTypes.NpgsqlBox(top: 0.49928070026513394d,right: 0.9848399989109936d,bottom: 0.49643588998084376d,left: 0.31226532250744743d),

new NpgsqlTypes.NpgsqlBox(top: 0.403804188278475d,right: 0.956509472503889d,bottom: 0.08865515431994753d,left: 0.8989156995285789d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.28464908043666926d,right: 0.6344604794784837d,bottom: 0.0910338341881709d,left: 0.5352177708184636d),

new NpgsqlTypes.NpgsqlBox(top: 0.9264320377040072d,right: 0.3946394482592753d,bottom: 0.9260217463961578d,left: 0.284592742164389d),

new NpgsqlTypes.NpgsqlBox(top: 0.3479953820497067d,right: 0.8688512276053216d,bottom: 0.3361763596800479d,left: 0.27959679844161334d),

new NpgsqlTypes.NpgsqlBox(top: 0.5900785763701007d,right: 0.722223520117133d,bottom: 0.020602941225391302d,left: 0.24399815232640143d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43399701365831067d,right: 0.5228075249982301d,bottom: 0.2839579198697625d,left: 0.16755588781397834d),

new NpgsqlTypes.NpgsqlBox(top: 0.5650845638378962d,right: 0.7055537452903244d,bottom: 0.2921343041409382d,left: 0.4090540364528854d),

new NpgsqlTypes.NpgsqlBox(top: 0.9017831094462018d,right: 0.8957328454663861d,bottom: 0.10346608107135924d,left: 0.6481255841255368d),

new NpgsqlTypes.NpgsqlBox(top: 0.7830124298114498d,right: 0.6403210323441261d,bottom: 0.5651452615006392d,left: 0.04114236141792105d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4099171150594768d,right: 0.7800531138213085d,bottom: 0.24543575237938386d,left: 0.014042937885752393d),

new NpgsqlTypes.NpgsqlBox(top: 0.5394484960045257d,right: 0.7362049815474646d,bottom: 0.3038019554237794d,left: 0.5790700220046937d),

new NpgsqlTypes.NpgsqlBox(top: 0.7971383166580084d,right: 0.533004221385855d,bottom: 0.6014493114085602d,left: 0.28384968368350283d),

new NpgsqlTypes.NpgsqlBox(top: 0.9322409693101791d,right: 0.6660193066274206d,bottom: 0.00991390825527283d,left: 0.27739582251706163d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4486829269184971d,right: 0.16859508487452424d,bottom: 0.2123402366074274d,left: 0.0033586989253768795d),

new NpgsqlTypes.NpgsqlBox(top: 0.9350180891543833d,right: 0.6410956187395237d,bottom: 0.5546626563200171d,left: 0.5556473779563981d),

new NpgsqlTypes.NpgsqlBox(top: 0.6467532247354995d,right: 0.9623693151936752d,bottom: 0.4173589322806105d,left: 0.6166595993465652d),

new NpgsqlTypes.NpgsqlBox(top: 0.6582475538361259d,right: 0.34691423024347745d,bottom: 0.396088226968241d,left: 0.06892385980599824d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4716588469393588d,right: 0.9438860010080262d,bottom: 0.0002197758444278941d,left: 0.41720937749920806d),

new NpgsqlTypes.NpgsqlBox(top: 0.6399680812647699d,right: 0.9044546050219249d,bottom: 0.5206696630907021d,left: 0.7034279344129908d),

new NpgsqlTypes.NpgsqlBox(top: 0.139681669869974d,right: 0.403592145787497d,bottom: 0.07240618771568086d,left: 0.2484818538793564d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9726097443488102d,right: 0.49121072065987736d,bottom: 0.8237916464506059d,left: 0.43889947098090487d),

new NpgsqlTypes.NpgsqlBox(top: 0.767318473126384d,right: 0.708076626510823d,bottom: 0.2642113725034857d,left: 0.14995526199661446d),

new NpgsqlTypes.NpgsqlBox(top: 0.7754368982581776d,right: 0.7319709607801063d,bottom: 0.7688951567633744d,left: 0.44016225917776064d),

new NpgsqlTypes.NpgsqlBox(top: 0.7560507613998031d,right: 0.5261808603277323d,bottom: 0.11904988329869881d,left: 0.43096508638501696d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7121603646620063d,right: 0.9620568121685799d,bottom: 0.4431333128794349d,left: 0.4742118967293826d),

new NpgsqlTypes.NpgsqlBox(top: 0.5102622416661852d,right: 0.48965160070859715d,bottom: 0.3043361598469453d,left: 0.07294757740227487d),

new NpgsqlTypes.NpgsqlBox(top: 0.6357227133129025d,right: 0.2852752359707261d,bottom: 0.6047501886996524d,left: 0.2591188818097012d),

new NpgsqlTypes.NpgsqlBox(top: 0.7587038706077996d,right: 0.8388501356315228d,bottom: 0.3196060332656221d,left: 0.44461628326773694d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5768640450666205d,right: 0.8735646653420308d,bottom: 0.06739783066718585d,left: 0.6107754706645311d),

new NpgsqlTypes.NpgsqlBox(top: 0.901946710812609d,right: 0.47252821261384415d,bottom: 0.371278904341413d,left: 0.1828461890022598d),

new NpgsqlTypes.NpgsqlBox(top: 0.9416593359095575d,right: 0.654469651463337d,bottom: 0.553178352988424d,left: 0.5465328021325907d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7851514203359962d,right: 0.8426725981526312d,bottom: 0.7447120386009264d,left: 0.8125236271099459d),

new NpgsqlTypes.NpgsqlBox(top: 0.9865159255532775d,right: 0.6453314347084442d,bottom: 0.7140870436055489d,left: 0.6060268230978798d),

new NpgsqlTypes.NpgsqlBox(top: 0.7006956477167097d,right: 0.5169358764646516d,bottom: 0.5830782274168611d,left: 0.22330513645077998d),

new NpgsqlTypes.NpgsqlBox(top: 0.6919899413745809d,right: 0.3271499181466134d,bottom: 0.5200809369662204d,left: 0.18463808629031575d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6142660205099855d,right: 0.5735365111863562d,bottom: 0.07243050419006791d,left: 0.31529634154665853d),

new NpgsqlTypes.NpgsqlBox(top: 0.28959661395512726d,right: 0.2692766034233851d,bottom: 0.012388489195156005d,left: 0.2516457366548098d),

new NpgsqlTypes.NpgsqlBox(top: 0.9206398956522331d,right: 0.3863637438737616d,bottom: 0.8939534642806704d,left: 0.22414770097475845d),

new NpgsqlTypes.NpgsqlBox(top: 0.9706148336704621d,right: 0.34622971595662d,bottom: 0.4704550337599812d,left: 0.31967084406081436d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5616342948008071d,right: 0.523977581573517d,bottom: 0.25121955303658605d,left: 0.2996547694040347d),

new NpgsqlTypes.NpgsqlBox(top: 0.8091421753323086d,right: 0.8162516107340011d,bottom: 0.543060555705182d,left: 0.4612210104931155d),

new NpgsqlTypes.NpgsqlBox(top: 0.28538865539215763d,right: 0.9634740895634438d,bottom: 0.11057494989229122d,left: 0.05639366105054899d),

new NpgsqlTypes.NpgsqlBox(top: 0.7793408709399854d,right: 0.7917682552237757d,bottom: 0.22496690646906192d,left: 0.6696280007054025d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9273323018131787d,right: 0.6900484691128818d,bottom: 0.07534687923659256d,left: 0.42275841382837864d),

new NpgsqlTypes.NpgsqlBox(top: 0.3555662091939831d,right: 0.09112752529761348d,bottom: 0.0334584128806934d,left: 0.03409961289189156d),

new NpgsqlTypes.NpgsqlBox(top: 0.4105432653551334d,right: 0.8099333915266417d,bottom: 0.225339506327507d,left: 0.625170706591661d),

new NpgsqlTypes.NpgsqlBox(top: 0.5677471625085377d,right: 0.9539948594552924d,bottom: 0.2956558838917144d,left: 0.8779716449854825d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.841319024147969d,right: 0.9357159663015193d,bottom: 0.823571734141503d,left: 0.918107877510283d),

new NpgsqlTypes.NpgsqlBox(top: 0.7663353731019528d,right: 0.977016812734714d,bottom: 0.6398664340955542d,left: 0.2888799565544836d),

new NpgsqlTypes.NpgsqlBox(top: 0.9517304957063621d,right: 0.7813490671305064d,bottom: 0.7507424643237767d,left: 0.051784322848233755d),

new NpgsqlTypes.NpgsqlBox(top: 0.9719067391418648d,right: 0.761215947517227d,bottom: 0.23611592451991403d,left: 0.33406583587463623d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5759398373744258d,right: 0.7796762321566405d,bottom: 0.5744787898089498d,left: 0.5036050319791994d),

new NpgsqlTypes.NpgsqlBox(top: 0.6296105917951109d,right: 0.837761595150104d,bottom: 0.5291421249580905d,left: 0.6270532195961517d),

new NpgsqlTypes.NpgsqlBox(top: 0.9367573404640998d,right: 0.9190213345669245d,bottom: 0.8272781942676681d,left: 0.4882744621966547d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9721876119053421d,right: 0.5019012486876043d,bottom: 0.6264483570409471d,left: 0.0862771218018884d),

new NpgsqlTypes.NpgsqlBox(top: 0.5113620327094704d,right: 0.9920861117988928d,bottom: 0.03160702810574656d,left: 0.5037102435108318d),

new NpgsqlTypes.NpgsqlBox(top: 0.8177944676338434d,right: 0.714501509673329d,bottom: 0.38169483099270474d,left: 0.4991382611777816d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8399360786550183d,right: 0.9019479522912861d,bottom: 0.6065623436905784d,left: 0.17597867461458394d),

new NpgsqlTypes.NpgsqlBox(top: 0.7720410276233751d,right: 0.9096051703788707d,bottom: 0.22629933898161958d,left: 0.36314716241271605d),

new NpgsqlTypes.NpgsqlBox(top: 0.8978454741585674d,right: 0.4747275873921817d,bottom: 0.16892002076941748d,left: 0.40368192419098725d),

new NpgsqlTypes.NpgsqlBox(top: 0.233786760619358d,right: 0.6923720750593513d,bottom: 0.08675564986451567d,left: 0.04066482207143529d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8795557569439351d,right: 0.8658665271249751d,bottom: 0.25528568846097854d,left: 0.13054050995780586d),

new NpgsqlTypes.NpgsqlBox(top: 0.3821600311420469d,right: 0.80610589349606d,bottom: 0.00439666889388346d,left: 0.18686745747968114d),

new NpgsqlTypes.NpgsqlBox(top: 0.43080269091803025d,right: 0.7728401194752271d,bottom: 0.10667337967179957d,left: 0.340339184156639d),

new NpgsqlTypes.NpgsqlBox(top: 0.9759019559512188d,right: 0.9665188352559932d,bottom: 0.7723333708958602d,left: 0.41694623488458415d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7344803473157343d,right: 0.40302992087685574d,bottom: 0.5843071312204399d,left: 0.2174020303864438d),

new NpgsqlTypes.NpgsqlBox(top: 0.658606428759037d,right: 0.9029229407567866d,bottom: 0.5901254518270239d,left: 0.26423806720815846d),

new NpgsqlTypes.NpgsqlBox(top: 0.8711229802016137d,right: 0.8853538105828744d,bottom: 0.5037557017228588d,left: 0.24675262346098747d),

new NpgsqlTypes.NpgsqlBox(top: 0.6300814699292347d,right: 0.9292986408792298d,bottom: 0.3486299769235913d,left: 0.3119284979038608d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7666646661088434d,right: 0.6688431907788565d,bottom: 0.509566261751696d,left: 0.20648046000302067d),

new NpgsqlTypes.NpgsqlBox(top: 0.5989920035337535d,right: 0.9802920060287825d,bottom: 0.19343852157616537d,left: 0.3615788867160704d),

new NpgsqlTypes.NpgsqlBox(top: 0.625930959550388d,right: 0.7015966671620715d,bottom: 0.4552515506749307d,left: 0.005688354690587705d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9655262563063218d,right: 0.5628185083171081d,bottom: 0.7754292081509079d,left: 0.047555157245459d),

new NpgsqlTypes.NpgsqlBox(top: 0.4926306168662645d,right: 0.4494321332011494d,bottom: 0.11671572196808899d,left: 0.10984557829018837d),

new NpgsqlTypes.NpgsqlBox(top: 0.14343002957119955d,right: 0.9894876149952248d,bottom: 0.06966311633641609d,left: 0.5492680504776716d),

new NpgsqlTypes.NpgsqlBox(top: 0.5991681276885672d,right: 0.7911970233730276d,bottom: 0.5123847664457172d,left: 0.29589726529937366d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25288598287197406d,right: 0.17635004008832467d,bottom: 0.005419495737008617d,left: 0.16803288488719115d),

new NpgsqlTypes.NpgsqlBox(top: 0.41081871910432355d,right: 0.8183629352018721d,bottom: 0.3385157165435476d,left: 0.7053388646803245d),

new NpgsqlTypes.NpgsqlBox(top: 0.2686135891667253d,right: 0.4349939802055992d,bottom: 0.08161133537394427d,left: 0.2599202812324628d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8306414595131247d,right: 0.8398806608946829d,bottom: 0.1421534013715824d,left: 0.48247256809381d),

new NpgsqlTypes.NpgsqlBox(top: 0.5385956971360104d,right: 0.7671078995200473d,bottom: 0.12123406817750293d,left: 0.2305075304808627d),

new NpgsqlTypes.NpgsqlBox(top: 0.49761727618208484d,right: 0.5753652956668122d,bottom: 0.12121458202536628d,left: 0.009458247927219943d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5853223186000207d,right: 0.8282541663818906d,bottom: 0.4169128148634086d,left: 0.4139396837188619d),

new NpgsqlTypes.NpgsqlBox(top: 0.8214699113226412d,right: 0.228842041030199d,bottom: 0.3185983696115847d,left: 0.023724464304836657d),

new NpgsqlTypes.NpgsqlBox(top: 0.9107988683293115d,right: 0.8637788364132621d,bottom: 0.8996919459071516d,left: 0.8152420679712911d),

new NpgsqlTypes.NpgsqlBox(top: 0.31845540216832724d,right: 0.8245577266458226d,bottom: 0.11000701084114406d,left: 0.29847504769301425d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4290933808394014d,right: 0.736881890627509d,bottom: 0.20241035220972603d,left: 0.5329473032589d),

new NpgsqlTypes.NpgsqlBox(top: 0.8159080113521572d,right: 0.5945747518004143d,bottom: 0.21872543761727914d,left: 0.5047968195424118d),

new NpgsqlTypes.NpgsqlBox(top: 0.58207142132483d,right: 0.10509640801068809d,bottom: 0.44503152889598285d,left: 0.004365163680161599d),

new NpgsqlTypes.NpgsqlBox(top: 0.9416901899405503d,right: 0.6712293518125699d,bottom: 0.33709887304160735d,left: 0.5531086113714219d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4370191818409128d,right: 0.3603490468568017d,bottom: 0.3044580883503938d,left: 0.052051218421752754d),

new NpgsqlTypes.NpgsqlBox(top: 0.6691214308829839d,right: 0.9752037970792496d,bottom: 0.17100229379837628d,left: 0.005719531092467811d),

new NpgsqlTypes.NpgsqlBox(top: 0.4680523324784506d,right: 0.18451488909314595d,bottom: 0.4634913343470398d,left: 0.021646191001248205d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9081194588131074d,right: 0.9811249810214007d,bottom: 0.0604649356282857d,left: 0.0650295101668279d),

new NpgsqlTypes.NpgsqlBox(top: 0.7349165940974551d,right: 0.7773181098566403d,bottom: 0.5372438384034098d,left: 0.6909625398215268d),

new NpgsqlTypes.NpgsqlBox(top: 0.349716074157979d,right: 0.6334562755821642d,bottom: 0.260467897314684d,left: 0.05061835134387349d),

new NpgsqlTypes.NpgsqlBox(top: 0.7196846035590528d,right: 0.9406173794892327d,bottom: 0.3576706291067604d,left: 0.828209116249282d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7070450513067544d,right: 0.9942069601157412d,bottom: 0.3390089282554578d,left: 0.4687261885327052d),

new NpgsqlTypes.NpgsqlBox(top: 0.78596913982786d,right: 0.2039737576527776d,bottom: 0.22589489019470832d,left: 0.10831389123145874d),

new NpgsqlTypes.NpgsqlBox(top: 0.5984373395602248d,right: 0.5124077200817038d,bottom: 0.47292873855844353d,left: 0.3903167143659647d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.808415829307457d,right: 0.8391475653814885d,bottom: 0.3624564494370657d,left: 0.6205741525718215d),

new NpgsqlTypes.NpgsqlBox(top: 0.4003769287170247d,right: 0.4302777655262904d,bottom: 0.3621184500119674d,left: 0.17666045824154175d),

new NpgsqlTypes.NpgsqlBox(top: 0.26191132657146765d,right: 0.676367328443069d,bottom: 0.0772596064476544d,left: 0.6485674973207438d),

new NpgsqlTypes.NpgsqlBox(top: 0.8954151460259077d,right: 0.7877769686694494d,bottom: 0.12958561905551846d,left: 0.44442488877136466d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3009304057382418d,right: 0.7630767427533452d,bottom: 0.09296543442643634d,left: 0.3646362934458276d),

new NpgsqlTypes.NpgsqlBox(top: 0.6700932543491023d,right: 0.4258516298243241d,bottom: 0.5871846893903586d,left: 0.10429600327599364d),

new NpgsqlTypes.NpgsqlBox(top: 0.8149200111162899d,right: 0.22989713959052205d,bottom: 0.6914472599480916d,left: 0.07820543513476941d),

new NpgsqlTypes.NpgsqlBox(top: 0.7004724156149329d,right: 0.36883249201163637d,bottom: 0.06396291803985599d,left: 0.27954336579420547d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6976428284833729d,right: 0.7045345563830483d,bottom: 0.2553514242393533d,left: 0.6462036167963345d),

new NpgsqlTypes.NpgsqlBox(top: 0.6941020379812358d,right: 0.5559117496764995d,bottom: 0.38597443100880735d,left: 0.11548712890378487d),

new NpgsqlTypes.NpgsqlBox(top: 0.8883022344056912d,right: 0.8473841611415143d,bottom: 0.7851703634486755d,left: 0.20201151210416246d),

new NpgsqlTypes.NpgsqlBox(top: 0.6556628808562137d,right: 0.41548997678483146d,bottom: 0.5727483687634757d,left: 0.1834215298610795d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9615256925363875d,right: 0.8454357466385963d,bottom: 0.20976775144269155d,left: 0.6796185401700158d),

new NpgsqlTypes.NpgsqlBox(top: 0.7506022182377647d,right: 0.8665903047671876d,bottom: 0.4899107533369864d,left: 0.31658543240363d),

new NpgsqlTypes.NpgsqlBox(top: 0.6400268335036182d,right: 0.31824237020607316d,bottom: 0.08879724198973593d,left: 0.016895779715787818d),

new NpgsqlTypes.NpgsqlBox(top: 0.43689697270708805d,right: 0.37682135310464016d,bottom: 0.1471283537315875d,left: 0.3694354011528992d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9249665898683699d,right: 0.9833253094318664d,bottom: 0.2023752298480791d,left: 0.8528338482701818d),

new NpgsqlTypes.NpgsqlBox(top: 0.5406185083005273d,right: 0.3910851551861605d,bottom: 0.24568654804343248d,left: 0.3501004546903481d),

new NpgsqlTypes.NpgsqlBox(top: 0.9679605048427611d,right: 0.3114729577717652d,bottom: 0.2749566029783551d,left: 0.14086032227748002d),

new NpgsqlTypes.NpgsqlBox(top: 0.5600220202313664d,right: 0.42160616253739147d,bottom: 0.25559016961334524d,left: 0.08155715626961169d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9909781674859001d,right: 0.8708273132370832d,bottom: 0.5120345454498579d,left: 0.6421109333797764d),

new NpgsqlTypes.NpgsqlBox(top: 0.6738944736978094d,right: 0.7838388978841638d,bottom: 0.15973174072609297d,left: 0.1869548856604597d),

new NpgsqlTypes.NpgsqlBox(top: 0.8582987815112768d,right: 0.5977085437719659d,bottom: 0.29574431832558756d,left: 0.44347743232077186d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9764476615185523d,right: 0.5011027240138267d,bottom: 0.3582974930480384d,left: 0.49557777784365553d),

new NpgsqlTypes.NpgsqlBox(top: 0.6026881713365343d,right: 0.7305695499962873d,bottom: 0.5298495241650595d,left: 0.701585456647303d),

new NpgsqlTypes.NpgsqlBox(top: 0.5050532755293559d,right: 0.6310877443656951d,bottom: 0.18776026128329182d,left: 0.46625993411001077d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3857937793022753d,right: 0.728019029566772d,bottom: 0.1520576761040482d,left: 0.6257476134782581d),

new NpgsqlTypes.NpgsqlBox(top: 0.6891010552087671d,right: 0.7780304418822852d,bottom: 0.610854334489952d,left: 0.25268855752224384d),

new NpgsqlTypes.NpgsqlBox(top: 0.42046372302952273d,right: 0.8139397594216564d,bottom: 0.24462160190976512d,left: 0.5466270823686854d),

new NpgsqlTypes.NpgsqlBox(top: 0.7611933430623276d,right: 0.886323122545558d,bottom: 0.22502918196947552d,left: 0.029083760512156887d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8416890965284952d,right: 0.7804898599882262d,bottom: 0.4823502405738799d,left: 0.4430473898472246d),

new NpgsqlTypes.NpgsqlBox(top: 0.44015407948419283d,right: 0.9660471709100242d,bottom: 0.11309978916743624d,left: 0.5645425443659698d),

new NpgsqlTypes.NpgsqlBox(top: 0.4942372365529687d,right: 0.4578903783797338d,bottom: 0.3935901441372255d,left: 0.4073369452078853d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8638610811278454d,right: 0.952822114522203d,bottom: 0.8024116011360134d,left: 0.41386841771429206d),

new NpgsqlTypes.NpgsqlBox(top: 0.6343417136370499d,right: 0.8972267843034795d,bottom: 0.03691333445833156d,left: 0.17600611879643502d),

new NpgsqlTypes.NpgsqlBox(top: 0.49547035743396495d,right: 0.8927797032710996d,bottom: 0.3602410808159816d,left: 0.32325875688529315d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47132254796415074d,right: 0.8929268760994d,bottom: 0.13017173929529102d,left: 0.5843549972525984d),

new NpgsqlTypes.NpgsqlBox(top: 0.22616546519922232d,right: 0.64961769574721d,bottom: 0.10125104492628179d,left: 0.11518898918029197d),

new NpgsqlTypes.NpgsqlBox(top: 0.8886809970204772d,right: 0.7914184368657774d,bottom: 0.6058278720122745d,left: 0.30582259312438975d),

new NpgsqlTypes.NpgsqlBox(top: 0.8628259227272596d,right: 0.9089128465425045d,bottom: 0.5966780061650196d,left: 0.40426972310023834d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7778768055562671d,right: 0.661275237288684d,bottom: 0.4218364893251554d,left: 0.4282400436721777d),

new NpgsqlTypes.NpgsqlBox(top: 0.7708470291983139d,right: 0.8551873223418388d,bottom: 0.6722938666655601d,left: 0.16252271395533813d),

new NpgsqlTypes.NpgsqlBox(top: 0.4983468149420677d,right: 0.8115952140123217d,bottom: 0.3781910583395093d,left: 0.525720316209366d),

new NpgsqlTypes.NpgsqlBox(top: 0.43430250265341996d,right: 0.5223992738991375d,bottom: 0.3311072669048669d,left: 0.47879225244182855d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8826470695887821d,right: 0.9366239623750471d,bottom: 0.8014814414249694d,left: 0.9062505403961856d),

new NpgsqlTypes.NpgsqlBox(top: 0.41509176593161146d,right: 0.42055647808523056d,bottom: 0.262430558109239d,left: 0.33128296409938385d),

new NpgsqlTypes.NpgsqlBox(top: 0.9955503607368361d,right: 0.7918899800739027d,bottom: 0.5754849409977288d,left: 0.37690514497423855d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6204289318325779d,right: 0.8955992283359856d,bottom: 0.3939909139566007d,left: 0.521973895916143d),

new NpgsqlTypes.NpgsqlBox(top: 0.876962876136103d,right: 0.5250530096490972d,bottom: 0.8158333655181091d,left: 0.18758035018967412d),

new NpgsqlTypes.NpgsqlBox(top: 0.8192339631291795d,right: 0.7504379076763478d,bottom: 0.7701465480268256d,left: 0.5657973617780608d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9546926791233721d,right: 0.7439418842184998d,bottom: 0.2713105904862403d,left: 0.3489315992361359d),

new NpgsqlTypes.NpgsqlBox(top: 0.9371387719771084d,right: 0.5096321279275973d,bottom: 0.47412113781108134d,left: 0.46483954653057524d),

new NpgsqlTypes.NpgsqlBox(top: 0.9893301021179329d,right: 0.8658198723668213d,bottom: 0.1473883857564081d,left: 0.8450559905376065d),

new NpgsqlTypes.NpgsqlBox(top: 0.7576951654962198d,right: 0.8972226732875883d,bottom: 0.6178890387589078d,left: 0.8161683744778012d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6909758118912819d,right: 0.7120348142378358d,bottom: 0.45669915263033967d,left: 0.3445081050230505d),

new NpgsqlTypes.NpgsqlBox(top: 0.7262553927244194d,right: 0.6468826364462923d,bottom: 0.3093860272387211d,left: 0.00567591088354058d),

new NpgsqlTypes.NpgsqlBox(top: 0.21174180272354404d,right: 0.5772000497464366d,bottom: 0.11990169223293734d,left: 0.5539164543081512d),

new NpgsqlTypes.NpgsqlBox(top: 0.7056809132288493d,right: 0.6855753041169667d,bottom: 0.4497692980400796d,left: 0.3776331022669692d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8861081661565285d,right: 0.9615727600376153d,bottom: 0.5836834513541672d,left: 0.20110481548572956d),

new NpgsqlTypes.NpgsqlBox(top: 0.9181598004915509d,right: 0.5265755546533982d,bottom: 0.6115156384365275d,left: 0.04732586512326209d),

new NpgsqlTypes.NpgsqlBox(top: 0.9706353645930146d,right: 0.9073010760532416d,bottom: 0.2739607644216938d,left: 0.5570173191120967d),

new NpgsqlTypes.NpgsqlBox(top: 0.7106561914685353d,right: 0.9221526298925421d,bottom: 0.32725992625214617d,left: 0.22167809237959724d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.556887892669204d,right: 0.16844639263261496d,bottom: 0.3706677534981545d,left: 0.0016320306772025228d),

new NpgsqlTypes.NpgsqlBox(top: 0.791806364461257d,right: 0.5659227630609434d,bottom: 0.3904313471721833d,left: 0.5238242690356594d),

new NpgsqlTypes.NpgsqlBox(top: 0.9994309633611735d,right: 0.7712098990990449d,bottom: 0.15791396408032754d,left: 0.7105065460882601d),

new NpgsqlTypes.NpgsqlBox(top: 0.9430580253325195d,right: 0.4975078999612508d,bottom: 0.4384262377604312d,left: 0.1756700868572041d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.790735125489272d,right: 0.8472983353917126d,bottom: 0.6871125284924633d,left: 0.7585444587138068d),

new NpgsqlTypes.NpgsqlBox(top: 0.5888381175832123d,right: 0.5200701275358061d,bottom: 0.2791541960784394d,left: 0.41733481313592125d),

new NpgsqlTypes.NpgsqlBox(top: 0.11200246882269826d,right: 0.9651344468327503d,bottom: 0.056720820327762045d,left: 0.5056560176276692d),

new NpgsqlTypes.NpgsqlBox(top: 0.5224964003562583d,right: 0.18825642835705514d,bottom: 0.13330063092105893d,left: 0.07754655516926567d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8278357441561417d,right: 0.6421375090489767d,bottom: 0.4717798159457032d,left: 0.46188445724879423d),

new NpgsqlTypes.NpgsqlBox(top: 0.8424555554731632d,right: 0.30282098140145297d,bottom: 0.8183139243991413d,left: 0.20039495817198394d),

new NpgsqlTypes.NpgsqlBox(top: 0.5619749268792854d,right: 0.5896966017371942d,bottom: 0.03535052043585718d,left: 0.45463608700016056d),

new NpgsqlTypes.NpgsqlBox(top: 0.9937840670444412d,right: 0.43922135656277594d,bottom: 0.45267160879276636d,left: 0.39043797225089094d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9121109607373398d,right: 0.7919764976502623d,bottom: 0.7005007083030493d,left: 0.7337175450843072d),

new NpgsqlTypes.NpgsqlBox(top: 0.8284975398300755d,right: 0.9717740622907942d,bottom: 0.364086042795698d,left: 0.6957128426704556d),

new NpgsqlTypes.NpgsqlBox(top: 0.5053393785702285d,right: 0.9489701925210622d,bottom: 0.25392169427705824d,left: 0.09419887610824906d),

new NpgsqlTypes.NpgsqlBox(top: 0.6665131941566502d,right: 0.42869823941745744d,bottom: 0.6229919068790337d,left: 0.21188115011547892d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9064173772207997d,right: 0.3729847023059616d,bottom: 0.7832216704586071d,left: 0.31027189592092885d),

new NpgsqlTypes.NpgsqlBox(top: 0.8793759106180334d,right: 0.9564264922573135d,bottom: 0.8265785916365019d,left: 0.5763068262847327d),

new NpgsqlTypes.NpgsqlBox(top: 0.5782247291108326d,right: 0.8015704579134142d,bottom: 0.4042013621629077d,left: 0.05595856867084681d),

new NpgsqlTypes.NpgsqlBox(top: 0.3260237976855399d,right: 0.4095113863441686d,bottom: 0.026052022253828078d,left: 0.14953538815454925d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9202206963204673d,right: 0.12611580742679163d,bottom: 0.5949218172258659d,left: 0.10782274751700927d),

new NpgsqlTypes.NpgsqlBox(top: 0.9267496511978731d,right: 0.8942659163863493d,bottom: 0.3862277693178192d,left: 0.7857518942245638d),

new NpgsqlTypes.NpgsqlBox(top: 0.766790593675007d,right: 0.9653893566178233d,bottom: 0.34939594924469686d,left: 0.33052933311189303d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6125499988577777d,right: 0.9461688664366973d,bottom: 0.2778138768063705d,left: 0.07272071688579707d),

new NpgsqlTypes.NpgsqlBox(top: 0.5005478521795175d,right: 0.6546423825701275d,bottom: 0.3896080902625344d,left: 0.2692372910625527d),

new NpgsqlTypes.NpgsqlBox(top: 0.6420615712735432d,right: 0.09706281575899023d,bottom: 0.2914342846917335d,left: 0.08991076017036215d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.09324000608212857d,right: 0.6284023549491433d,bottom: 0.007389384752642614d,left: 0.04163670209744952d),

new NpgsqlTypes.NpgsqlBox(top: 0.8999484615900457d,right: 0.983354542146646d,bottom: 0.1545224383787852d,left: 0.5684730905712928d),

new NpgsqlTypes.NpgsqlBox(top: 0.16294683123812137d,right: 0.7519398721363266d,bottom: 0.04714441127963931d,left: 0.22744612187166124d),

new NpgsqlTypes.NpgsqlBox(top: 0.9946243995984457d,right: 0.8844647013171735d,bottom: 0.5793991699625649d,left: 0.269535221878356d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7238784512635762d,right: 0.8471539021846534d,bottom: 0.020265423250962145d,left: 0.1969821764618317d),

new NpgsqlTypes.NpgsqlBox(top: 0.40664944872683806d,right: 0.9247696725220527d,bottom: 0.22087569048625455d,left: 0.027617201858160523d),

new NpgsqlTypes.NpgsqlBox(top: 0.07057810227995909d,right: 0.3563972163274063d,bottom: 0.06488640445980343d,left: 0.23655755126990619d),

new NpgsqlTypes.NpgsqlBox(top: 0.835421301010455d,right: 0.8847827929353008d,bottom: 0.49265312253407956d,left: 0.39185976182455573d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6232139901925727d,right: 0.33792291184046597d,bottom: 0.20410437038736318d,left: 0.31961954256339487d),

new NpgsqlTypes.NpgsqlBox(top: 0.9486137993068827d,right: 0.5977620072875236d,bottom: 0.510091509011966d,left: 0.014037921661985697d),

new NpgsqlTypes.NpgsqlBox(top: 0.4923980908125807d,right: 0.5243701683470466d,bottom: 0.312120973539069d,left: 0.5097669713606601d),

new NpgsqlTypes.NpgsqlBox(top: 0.040893396600780396d,right: 0.2228548931407658d,bottom: 0.03108263608607198d,left: 0.08093362841600893d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.798187520972699d,right: 0.6695600453523843d,bottom: 0.7357371890119536d,left: 0.48807020738812457d),

new NpgsqlTypes.NpgsqlBox(top: 0.8294861707143386d,right: 0.7731901937021632d,bottom: 0.6053961465477717d,left: 0.10706375435946947d),

new NpgsqlTypes.NpgsqlBox(top: 0.817826562705558d,right: 0.7158746944206095d,bottom: 0.10676997640320174d,left: 0.14870821316053395d),

new NpgsqlTypes.NpgsqlBox(top: 0.7186547688594366d,right: 0.4966448158557718d,bottom: 0.26203797721891087d,left: 0.38201129079284957d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.284870693313945d,right: 0.7526060093123392d,bottom: 0.13006646187640958d,left: 0.3513770774715127d),

new NpgsqlTypes.NpgsqlBox(top: 0.721863896624467d,right: 0.9643529829525418d,bottom: 0.5449737093158377d,left: 0.8278844182268761d),

new NpgsqlTypes.NpgsqlBox(top: 0.5769767846781171d,right: 0.7289251123007557d,bottom: 0.21766903466445475d,left: 0.4319253925258537d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9093480772906541d,right: 0.8037738478066621d,bottom: 0.80562722431491d,left: 0.6531298123521344d),

new NpgsqlTypes.NpgsqlBox(top: 0.441635990640032d,right: 0.8479188765432436d,bottom: 0.2545199710674111d,left: 0.21080342262185037d),

new NpgsqlTypes.NpgsqlBox(top: 0.8651297399566635d,right: 0.9346411062971889d,bottom: 0.6128853469737789d,left: 0.7629650113912224d),

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
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
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
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 8, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 49, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 120, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 130, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 139, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 128, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

