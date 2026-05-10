

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7868584029806915d,right: 0.5152095651292644d,bottom: 0.4446860244370723d,left: 0.23650239164727616d),

new NpgsqlTypes.NpgsqlBox(top: 0.2937794821727976d,right: 0.6605857729613376d,bottom: 0.19247399241758367d,left: 0.31127617033302957d),

new NpgsqlTypes.NpgsqlBox(top: 0.8582664194325897d,right: 0.7107919617429446d,bottom: 0.36419133593533737d,left: 0.4006895832023809d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4312441133219288d,right: 0.9541304068731059d,bottom: 0.024129195901697376d,left: 0.5454139606246302d),

new NpgsqlTypes.NpgsqlBox(top: 0.24508446146266283d,right: 0.882365413770174d,bottom: 0.14291338461071434d,left: 0.10594585544492086d),

new NpgsqlTypes.NpgsqlBox(top: 0.8076281500887991d,right: 0.8238935505893143d,bottom: 0.579564441391593d,left: 0.5459544631871266d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9406251921679004d,right: 0.326874582060813d,bottom: 0.6678056112580285d,left: 0.0699643405702206d),

new NpgsqlTypes.NpgsqlBox(top: 0.9706064160077968d,right: 0.8630489225585312d,bottom: 0.803490745332555d,left: 0.044777752542302984d),

new NpgsqlTypes.NpgsqlBox(top: 0.9787342538607198d,right: 0.5142576557621372d,bottom: 0.2989405513123815d,left: 0.3887176512921916d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9384116622225d,right: 0.38247396030483904d,bottom: 0.2937702652597597d,left: 0.09500107642966849d),

new NpgsqlTypes.NpgsqlBox(top: 0.9934891478963733d,right: 0.8682786735825012d,bottom: 0.8313760155982266d,left: 0.12407456376248471d),

new NpgsqlTypes.NpgsqlBox(top: 0.7090248563389727d,right: 0.6681252132432739d,bottom: 0.15211317720743334d,left: 0.4745501417599902d),

new NpgsqlTypes.NpgsqlBox(top: 0.356018439878683d,right: 0.7532137635229949d,bottom: 0.1968875306619572d,left: 0.02235988571515357d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9751867698825295d,right: 0.9355702283922999d,bottom: 0.09256294875739912d,left: 0.3248372761104352d),

new NpgsqlTypes.NpgsqlBox(top: 0.8964591505377321d,right: 0.5537931803716787d,bottom: 0.5720634831436087d,left: 0.22643516428425847d),

new NpgsqlTypes.NpgsqlBox(top: 0.826804668565159d,right: 0.8792928094074643d,bottom: 0.237168616785836d,left: 0.7632204417561177d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4474586059257163d,right: 0.8720560627728063d,bottom: 0.26629785173296605d,left: 0.017960347462332105d),

new NpgsqlTypes.NpgsqlBox(top: 0.5670924344912083d,right: 0.9436875778588634d,bottom: 0.3367127176248319d,left: 0.6497689476264801d),

new NpgsqlTypes.NpgsqlBox(top: 0.9424076306088895d,right: 0.8428236995268126d,bottom: 0.92033081474917d,left: 0.621038788764734d),

new NpgsqlTypes.NpgsqlBox(top: 0.9055368712306145d,right: 0.5974298753418685d,bottom: 0.09559178857044415d,left: 0.10615510366651837d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8843948433516463d,right: 0.6652443161830293d,bottom: 0.18797186169390578d,left: 0.5193371258572561d),

new NpgsqlTypes.NpgsqlBox(top: 0.7169363130439803d,right: 0.13645735351983757d,bottom: 0.35936633445545874d,left: 0.007089008271857988d),

new NpgsqlTypes.NpgsqlBox(top: 0.9054347984268117d,right: 0.6294463714705711d,bottom: 0.2577321013298768d,left: 0.34187788043390954d),

new NpgsqlTypes.NpgsqlBox(top: 0.8847268157834325d,right: 0.8893703589099067d,bottom: 0.815593239084265d,left: 0.8454571766942097d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5998309315890461d,right: 0.9981069359596307d,bottom: 0.3043784776878211d,left: 0.44352527530823793d),

new NpgsqlTypes.NpgsqlBox(top: 0.16680058368030848d,right: 0.6884015826741651d,bottom: 0.1387453502386261d,left: 0.22701053056661713d),

new NpgsqlTypes.NpgsqlBox(top: 0.20895350139304947d,right: 0.776631047847834d,bottom: 0.2019891963298711d,left: 0.35270078644327163d),

new NpgsqlTypes.NpgsqlBox(top: 0.981206344921587d,right: 0.4657697930595919d,bottom: 0.316295707458669d,left: 0.23343855958662252d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.21294989033055756d,right: 0.6103267386289304d,bottom: 0.20658926259579125d,left: 0.32623803322376d),

new NpgsqlTypes.NpgsqlBox(top: 0.9500270673312297d,right: 0.6424726661442414d,bottom: 0.7978618237594752d,left: 0.2898542678072942d),

new NpgsqlTypes.NpgsqlBox(top: 0.4477001321494183d,right: 0.7178139169142329d,bottom: 0.06308654509070222d,left: 0.1453165939689247d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9326191939525501d,right: 0.8117026924046791d,bottom: 0.6564243443076174d,left: 0.23261179497667583d),

new NpgsqlTypes.NpgsqlBox(top: 0.9315416482569613d,right: 0.9298031365600534d,bottom: 0.6811847458619135d,left: 0.06350339607828326d),

new NpgsqlTypes.NpgsqlBox(top: 0.8455022301790901d,right: 0.07018579293309013d,bottom: 0.6871486324070403d,left: 0.03354232217901387d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7603624299064621d,right: 0.6555921665722464d,bottom: 0.018114350119229572d,left: 0.2069529064540434d),

new NpgsqlTypes.NpgsqlBox(top: 0.6978174010477648d,right: 0.6349573347286961d,bottom: 0.32539968121183693d,left: 0.13244510863538306d),

new NpgsqlTypes.NpgsqlBox(top: 0.6162585174474761d,right: 0.9881348065798443d,bottom: 0.045847587442733095d,left: 0.8510061499326657d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7445308400955314d,right: 0.9128809823808098d,bottom: 0.6199641439830904d,left: 0.6595027172974784d),

new NpgsqlTypes.NpgsqlBox(top: 0.5889828234069475d,right: 0.475548427614519d,bottom: 0.4455550930938843d,left: 0.44387453393480314d),

new NpgsqlTypes.NpgsqlBox(top: 0.9239969500148888d,right: 0.8138232296224456d,bottom: 0.11959067567503145d,left: 0.16755970788731656d),

new NpgsqlTypes.NpgsqlBox(top: 0.8931748786787552d,right: 0.7653869028760163d,bottom: 0.17940475162347924d,left: 0.6909865909017335d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4362755077373621d,right: 0.9491532719542429d,bottom: 0.1480197123880882d,left: 0.8013079687057741d),

new NpgsqlTypes.NpgsqlBox(top: 0.7980846324045835d,right: 0.8845628373516791d,bottom: 0.3778456591461963d,left: 0.6699560697756098d),

new NpgsqlTypes.NpgsqlBox(top: 0.4217064747706095d,right: 0.9806767266490972d,bottom: 0.3123298815514878d,left: 0.9026585131943974d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7463822736186952d,right: 0.7372286529436336d,bottom: 0.6660172706644802d,left: 0.46472544405317706d),

new NpgsqlTypes.NpgsqlBox(top: 0.20427682979922246d,right: 0.9108943655500094d,bottom: 0.12299744929708345d,left: 0.06226807598601325d),

new NpgsqlTypes.NpgsqlBox(top: 0.9814814789672869d,right: 0.7524855803084425d,bottom: 0.1267314761090652d,left: 0.32895786269502514d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6395514041034773d,right: 0.4791988451306811d,bottom: 0.13895848111828857d,left: 0.09504708068606993d),

new NpgsqlTypes.NpgsqlBox(top: 0.179029754219739d,right: 0.8904004051670557d,bottom: 0.14744793843334392d,left: 0.845315241499596d),

new NpgsqlTypes.NpgsqlBox(top: 0.6024657817585166d,right: 0.7315935614397403d,bottom: 0.16233515039890123d,left: 0.5951910728942247d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9827432059587222d,right: 0.48519549509288074d,bottom: 0.21110559224923076d,left: 0.11199367873869814d),

new NpgsqlTypes.NpgsqlBox(top: 0.9609286754231156d,right: 0.7137741186546959d,bottom: 0.4271301764930526d,left: 0.6916466116798303d),

new NpgsqlTypes.NpgsqlBox(top: 0.9811115410125567d,right: 0.9545365801486521d,bottom: 0.3036933120020029d,left: 0.5752328386095693d),

new NpgsqlTypes.NpgsqlBox(top: 0.5522126868083568d,right: 0.38841319260776164d,bottom: 0.34990580438279095d,left: 0.1829533031680466d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44586931769181326d,right: 0.4790396388948438d,bottom: 0.4299939295792701d,left: 0.035740226312572565d),

new NpgsqlTypes.NpgsqlBox(top: 0.5624533806680382d,right: 0.12245618209406561d,bottom: 0.14602216603726725d,left: 0.01935059645985493d),

new NpgsqlTypes.NpgsqlBox(top: 0.16266063188819413d,right: 0.9637132763633787d,bottom: 0.06772799114691752d,left: 0.4778545520939117d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7766426433377267d,right: 0.7136009861531896d,bottom: 0.5563491119040435d,left: 0.007597182278325509d),

new NpgsqlTypes.NpgsqlBox(top: 0.9157072294195762d,right: 0.05339416435532618d,bottom: 0.3834070833288177d,left: 0.01699187281560488d),

new NpgsqlTypes.NpgsqlBox(top: 0.33603473373506365d,right: 0.8948267233559402d,bottom: 0.18596046971094526d,left: 0.01846554085819463d),

new NpgsqlTypes.NpgsqlBox(top: 0.5681069776166237d,right: 0.9221887384760061d,bottom: 0.10945010969238389d,left: 0.07745329666104561d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9388100178412131d,right: 0.5996180269213534d,bottom: 0.41095729761066835d,left: 0.5212272719642105d),

new NpgsqlTypes.NpgsqlBox(top: 0.41388647750213436d,right: 0.8497054709227376d,bottom: 0.09118258834457393d,left: 0.33946388621265655d),

new NpgsqlTypes.NpgsqlBox(top: 0.6618803411877584d,right: 0.5308208716268783d,bottom: 0.3066638016033104d,left: 0.16571233941248664d),

new NpgsqlTypes.NpgsqlBox(top: 0.6277095220632128d,right: 0.6610909901818456d,bottom: 0.447178613774995d,left: 0.250242772341972d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8708747636852495d,right: 0.9706378248672454d,bottom: 0.8507201216421058d,left: 0.3514838215920747d),

new NpgsqlTypes.NpgsqlBox(top: 0.6628459985549088d,right: 0.8963515279325024d,bottom: 0.5742886725068234d,left: 0.6651821740119462d),

new NpgsqlTypes.NpgsqlBox(top: 0.9739884351520508d,right: 0.7195533868372644d,bottom: 0.9025440244127086d,left: 0.20417059087923417d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5966443757144319d,right: 0.554691191392475d,bottom: 0.3382233229291358d,left: 0.1725769699831995d),

new NpgsqlTypes.NpgsqlBox(top: 0.9746732458021848d,right: 0.8076842513984354d,bottom: 0.8493715901929865d,left: 0.5986715256400895d),

new NpgsqlTypes.NpgsqlBox(top: 0.2053940364502702d,right: 0.4832457496187753d,bottom: 0.03169541596907355d,left: 0.006881857439448136d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9889334731765285d,right: 0.4122547114462336d,bottom: 0.057500837710143804d,left: 0.3707908664940812d),

new NpgsqlTypes.NpgsqlBox(top: 0.8300436989025397d,right: 0.9490234601885994d,bottom: 0.33927523693385186d,left: 0.7355660180141034d),

new NpgsqlTypes.NpgsqlBox(top: 0.8988783741998467d,right: 0.6138826453096115d,bottom: 0.7235498503227071d,left: 0.06155458722223117d),

new NpgsqlTypes.NpgsqlBox(top: 0.5801611270202165d,right: 0.7590947473466725d,bottom: 0.04451905099655573d,left: 0.6931107808213306d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7631807276622035d,right: 0.3954875680344532d,bottom: 0.23125608085162996d,left: 0.3808975587165293d),

new NpgsqlTypes.NpgsqlBox(top: 0.35888384741223855d,right: 0.7197653902371621d,bottom: 0.35633311899785636d,left: 0.1388988396408557d),

new NpgsqlTypes.NpgsqlBox(top: 0.889906811265394d,right: 0.8599166260598362d,bottom: 0.40714342319549424d,left: 0.511511634040435d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25177500611833126d,right: 0.940666077317331d,bottom: 0.16182917583641354d,left: 0.012288382816574406d),

new NpgsqlTypes.NpgsqlBox(top: 0.7483050195344616d,right: 0.8277830875385906d,bottom: 0.3069843786248905d,left: 0.5316868495889618d),

new NpgsqlTypes.NpgsqlBox(top: 0.9925106930340573d,right: 0.839743851626466d,bottom: 0.5858369807907238d,left: 0.1510597426072149d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4028146529464719d,right: 0.6698314919330998d,bottom: 0.3858931516117884d,left: 0.3664187923594787d),

new NpgsqlTypes.NpgsqlBox(top: 0.7541632841011133d,right: 0.983384609809591d,bottom: 0.5200954410427567d,left: 0.759358567131824d),

new NpgsqlTypes.NpgsqlBox(top: 0.9015167860262828d,right: 0.9866525230718316d,bottom: 0.7717717106780247d,left: 0.5805337210036355d),

new NpgsqlTypes.NpgsqlBox(top: 0.401655181595549d,right: 0.616315511499541d,bottom: 0.05901242307955035d,left: 0.2996688822417516d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8257072221148563d,right: 0.6761472556234417d,bottom: 0.08558280801243046d,left: 0.2021978837715347d),

new NpgsqlTypes.NpgsqlBox(top: 0.8394459357573791d,right: 0.2775769501140102d,bottom: 0.7886918386209526d,left: 0.215357763980074d),

new NpgsqlTypes.NpgsqlBox(top: 0.854562478629545d,right: 0.4849224629627331d,bottom: 0.4544250856850902d,left: 0.4504759805656997d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9602038448744928d,right: 0.7571443817778125d,bottom: 0.6655074663930934d,left: 0.5303481522922725d),

new NpgsqlTypes.NpgsqlBox(top: 0.5229732105545193d,right: 0.9470741708064473d,bottom: 0.3691450283633628d,left: 0.08760143061817594d),

new NpgsqlTypes.NpgsqlBox(top: 0.4121569204684895d,right: 0.9756274326407643d,bottom: 0.16698265227838904d,left: 0.009015251822258485d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9555351689380877d,right: 0.9807859314767186d,bottom: 0.8137667965737546d,left: 0.11038181252870727d),

new NpgsqlTypes.NpgsqlBox(top: 0.9482174046416681d,right: 0.5796947810397899d,bottom: 0.027833715744586485d,left: 0.3431565166887589d),

new NpgsqlTypes.NpgsqlBox(top: 0.31504827315283d,right: 0.665759697019888d,bottom: 0.28890914762619657d,left: 0.09156425629331721d),

new NpgsqlTypes.NpgsqlBox(top: 0.5628693473593442d,right: 0.5839876679873753d,bottom: 0.4802823146824027d,left: 0.024680643632856714d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8982710913329525d,right: 0.8046255506504605d,bottom: 0.09885547190121968d,left: 0.47164696572594134d),

new NpgsqlTypes.NpgsqlBox(top: 0.08203222732541782d,right: 0.6425309724862713d,bottom: 0.07141903435501362d,left: 0.2836448308408639d),

new NpgsqlTypes.NpgsqlBox(top: 0.70457844686231d,right: 0.40102516029451496d,bottom: 0.07351662123022806d,left: 0.29692142658800813d),

new NpgsqlTypes.NpgsqlBox(top: 0.6607771249375806d,right: 0.5963969585431595d,bottom: 0.10510378068681436d,left: 0.00718618959870132d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5537414663429292d,right: 0.47355004691360125d,bottom: 0.1846933814530184d,left: 0.08190365330509675d),

new NpgsqlTypes.NpgsqlBox(top: 0.2023484842383606d,right: 0.7348670691389302d,bottom: 0.1810642717619526d,left: 0.4297478548726851d),

new NpgsqlTypes.NpgsqlBox(top: 0.9871985446410588d,right: 0.41351047526700657d,bottom: 0.05832504112891734d,left: 0.3941385384065259d),

new NpgsqlTypes.NpgsqlBox(top: 0.6407381102274297d,right: 0.2925444403444417d,bottom: 0.5183271753538329d,left: 0.2402579713157189d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9308706549840567d,right: 0.8852067478115377d,bottom: 0.5658034099159609d,left: 0.44857538172550115d),

new NpgsqlTypes.NpgsqlBox(top: 0.566406857085698d,right: 0.3940745296404232d,bottom: 0.35779569476313067d,left: 0.24913976144148642d),

new NpgsqlTypes.NpgsqlBox(top: 0.7492009318813295d,right: 0.5342381646632712d,bottom: 0.4057734607431883d,left: 0.2834638412570064d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7633294754568992d,right: 0.9086923746642368d,bottom: 0.3809214139850332d,left: 0.24434792074234957d),

new NpgsqlTypes.NpgsqlBox(top: 0.8418409831287635d,right: 0.6117095789125827d,bottom: 0.4094061553121827d,left: 0.3069590217277861d),

new NpgsqlTypes.NpgsqlBox(top: 0.35419710460850506d,right: 0.5250370055062473d,bottom: 0.2639200557789627d,left: 0.19841894991188358d),

new NpgsqlTypes.NpgsqlBox(top: 0.6731266964394784d,right: 0.2491833954986682d,bottom: 0.5103852394463277d,left: 0.13242403633970723d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5399100463396149d,right: 0.49810818275195257d,bottom: 0.09329001583910568d,left: 0.289554510856174d),

new NpgsqlTypes.NpgsqlBox(top: 0.47794491234909997d,right: 0.9910110403740334d,bottom: 0.3388490638544791d,left: 0.9546633397990666d),

new NpgsqlTypes.NpgsqlBox(top: 0.7723199388956111d,right: 0.21595307671278618d,bottom: 0.7154927273329189d,left: 0.12539339172523833d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6045198246417536d,right: 0.6849467635966227d,bottom: 0.04108081207210834d,left: 0.3036549265169366d),

new NpgsqlTypes.NpgsqlBox(top: 0.413171725309715d,right: 0.42973398470674573d,bottom: 0.0844577512080319d,left: 0.119648721683981d),

new NpgsqlTypes.NpgsqlBox(top: 0.8935083342659913d,right: 0.6000572818077776d,bottom: 0.6148228315557813d,left: 0.05769414088673308d),

new NpgsqlTypes.NpgsqlBox(top: 0.6012243052708506d,right: 0.8250431645138898d,bottom: 0.5274307040911188d,left: 0.5239313059587478d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.870639230920181d,right: 0.2859714199632687d,bottom: 0.5373885318553331d,left: 0.13839022318527727d),

new NpgsqlTypes.NpgsqlBox(top: 0.8369533601735237d,right: 0.6306688112969927d,bottom: 0.11811049128451112d,left: 0.28289542827524716d),

new NpgsqlTypes.NpgsqlBox(top: 0.19022027443488965d,right: 0.5357276498285185d,bottom: 0.14598001921871828d,left: 0.25149559234312646d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7195132225392217d,right: 0.8496436153019913d,bottom: 0.43974088477298945d,left: 0.38804694547819996d),

new NpgsqlTypes.NpgsqlBox(top: 0.43355335591398847d,right: 0.9631022871685639d,bottom: 0.03535772006150484d,left: 0.07324768901962297d),

new NpgsqlTypes.NpgsqlBox(top: 0.7139187824262082d,right: 0.9220439838179659d,bottom: 0.0023282752694646636d,left: 0.4710136829400845d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5505379094666758d,right: 0.6359717188066741d,bottom: 0.3118189233811538d,left: 0.5998929970829724d),

new NpgsqlTypes.NpgsqlBox(top: 0.6797412846536037d,right: 0.9835967508266649d,bottom: 0.27100776387950976d,left: 0.07611590095331211d),

new NpgsqlTypes.NpgsqlBox(top: 0.6753055704205947d,right: 0.6936350116575726d,bottom: 0.21512355600384436d,left: 0.26147560999666875d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6057180849449079d,right: 0.5020773408212204d,bottom: 0.2386914795271199d,left: 0.21502013467631076d),

new NpgsqlTypes.NpgsqlBox(top: 0.6604734706265365d,right: 0.5254824885266443d,bottom: 0.2303580721093419d,left: 0.2661648357776256d),

new NpgsqlTypes.NpgsqlBox(top: 0.9761609624255027d,right: 0.9040911469331082d,bottom: 0.14805541398759714d,left: 0.7773125633627421d),

new NpgsqlTypes.NpgsqlBox(top: 0.7723747030438467d,right: 0.9234163024968175d,bottom: 0.24258804757322483d,left: 0.6811993738820283d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9688539895779482d,right: 0.9124631212658998d,bottom: 0.8355778078344416d,left: 0.09622728914575007d),

new NpgsqlTypes.NpgsqlBox(top: 0.8039510484465785d,right: 0.9885832778538506d,bottom: 0.27425048369842386d,left: 0.8705732188838998d),

new NpgsqlTypes.NpgsqlBox(top: 0.7127749564376828d,right: 0.5015610796557459d,bottom: 0.07033059421080856d,left: 0.40396965663625184d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5159073363535989d,right: 0.8443676286916382d,bottom: 0.44207494419195126d,left: 0.7752989016255887d),

new NpgsqlTypes.NpgsqlBox(top: 0.632912342766624d,right: 0.5859929301334351d,bottom: 0.5814698250807592d,left: 0.4667812155071026d),

new NpgsqlTypes.NpgsqlBox(top: 0.8461260079391328d,right: 0.9230198638185523d,bottom: 0.17343627407720197d,left: 0.10933518263227626d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4151553366071157d,right: 0.35620094812673764d,bottom: 0.23869163261102888d,left: 0.28452408380491745d),

new NpgsqlTypes.NpgsqlBox(top: 0.884357613920561d,right: 0.4095981259055992d,bottom: 0.07405917583423349d,left: 0.3231883370455595d),

new NpgsqlTypes.NpgsqlBox(top: 0.9857349089767399d,right: 0.6796988382082614d,bottom: 0.48460715825096357d,left: 0.3265256107633835d),

new NpgsqlTypes.NpgsqlBox(top: 0.8244619379121393d,right: 0.9684408086565403d,bottom: 0.4368645981095709d,left: 0.7744991222867662d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8711027440790301d,right: 0.9350064637559355d,bottom: 0.3047447091248182d,left: 0.6515960886634027d),

new NpgsqlTypes.NpgsqlBox(top: 0.8691913929529271d,right: 0.7286734893554562d,bottom: 0.50532460002751d,left: 0.00410050500913739d),

new NpgsqlTypes.NpgsqlBox(top: 0.41207345375027515d,right: 0.9941797817282955d,bottom: 0.03648463142977487d,left: 0.28743658311394304d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7225390676898494d,right: 0.6480797725909794d,bottom: 0.7206878678054947d,left: 0.2508926399516125d),

new NpgsqlTypes.NpgsqlBox(top: 0.28990175240291083d,right: 0.8132471981147026d,bottom: 0.22766285115398666d,left: 0.7241015713261755d),

new NpgsqlTypes.NpgsqlBox(top: 0.2545251121341213d,right: 0.9784614423561886d,bottom: 0.0257769506250346d,left: 0.2457850177214822d),

new NpgsqlTypes.NpgsqlBox(top: 0.8678184360589908d,right: 0.6049328355316086d,bottom: 0.42990600670392554d,left: 0.022593420982277457d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6678801621205435d,right: 0.6512555351968206d,bottom: 0.5517535261821073d,left: 0.37972117598945676d),

new NpgsqlTypes.NpgsqlBox(top: 0.7716734083671085d,right: 0.09544026833251795d,bottom: 0.43351991184409755d,left: 0.007061953810434063d),

new NpgsqlTypes.NpgsqlBox(top: 0.9218333715983648d,right: 0.8924071299542367d,bottom: 0.1962576176357529d,left: 0.4587372644809078d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8766936093758669d,right: 0.38117470795962005d,bottom: 0.6319206860346515d,left: 0.08376877845058273d),

new NpgsqlTypes.NpgsqlBox(top: 0.7587760441250735d,right: 0.7332815084518877d,bottom: 0.6990472942138137d,left: 0.26986821278240736d),

new NpgsqlTypes.NpgsqlBox(top: 0.9809037191715493d,right: 0.5645037026364716d,bottom: 0.4021883864753135d,left: 0.37090291314328994d),

new NpgsqlTypes.NpgsqlBox(top: 0.6787905666447148d,right: 0.9224791155252466d,bottom: 0.19403893254142657d,left: 0.27262317509321166d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5347383136463056d,right: 0.5498210739086519d,bottom: 0.053253551956041756d,left: 0.15769631717115384d),

new NpgsqlTypes.NpgsqlBox(top: 0.40737240140676734d,right: 0.48905451217379714d,bottom: 0.33458015465811797d,left: 0.007150471954448623d),

new NpgsqlTypes.NpgsqlBox(top: 0.9796752756731333d,right: 0.4720618424827203d,bottom: 0.14212505221843652d,left: 0.26260893138111085d),

new NpgsqlTypes.NpgsqlBox(top: 0.8265728873634792d,right: 0.8328499002987809d,bottom: 0.03600597972454822d,left: 0.6664173909723442d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7122300433386723d,right: 0.38085164194963084d,bottom: 0.08267579707358508d,left: 0.08310286895391839d),

new NpgsqlTypes.NpgsqlBox(top: 0.41760761288457315d,right: 0.3813371125995628d,bottom: 0.24593163655793537d,left: 0.06994033977085945d),

new NpgsqlTypes.NpgsqlBox(top: 0.8420280607463855d,right: 0.9319540887614806d,bottom: 0.28992877787751004d,left: 0.41334838879395785d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.724187040648453d,right: 0.9846770710972602d,bottom: 0.27915897819714786d,left: 0.3816494914601086d),

new NpgsqlTypes.NpgsqlBox(top: 0.5634120254691977d,right: 0.7273623905067761d,bottom: 0.5450632930004419d,left: 0.40304542598553217d),

new NpgsqlTypes.NpgsqlBox(top: 0.3468346125154974d,right: 0.6741248828816587d,bottom: 0.29460231115940116d,left: 0.35299092855231706d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6521176876262533d,right: 0.6315642625168937d,bottom: 0.2576014210569624d,left: 0.42358396809716903d),

new NpgsqlTypes.NpgsqlBox(top: 0.6647746967569503d,right: 0.21917598936676752d,bottom: 0.34414927715975263d,left: 0.05169731910008468d),

new NpgsqlTypes.NpgsqlBox(top: 0.48692050458707614d,right: 0.8142940185626203d,bottom: 0.30110397533167066d,left: 0.5437017908355516d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.13087979785263182d,right: 0.6559446156602542d,bottom: 0.06957829314455566d,left: 0.04892355941120452d),

new NpgsqlTypes.NpgsqlBox(top: 0.5239659973355184d,right: 0.6216462199574697d,bottom: 0.4506304831953346d,left: 0.4761817254314257d),

new NpgsqlTypes.NpgsqlBox(top: 0.9522018563769931d,right: 0.8150962073257288d,bottom: 0.8586179334891508d,left: 0.8077260343254414d),

new NpgsqlTypes.NpgsqlBox(top: 0.9731003371709539d,right: 0.09627904964472633d,bottom: 0.24205104831602675d,left: 0.053284719396205604d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7088558117548408d,right: 0.7948381941661747d,bottom: 0.4145638731961343d,left: 0.47876529497815856d),

new NpgsqlTypes.NpgsqlBox(top: 0.8060621818400066d,right: 0.7226783043197228d,bottom: 0.4206854378767897d,left: 0.3502781479590582d),

new NpgsqlTypes.NpgsqlBox(top: 0.5726824767368544d,right: 0.8695741512200087d,bottom: 0.5401919884248825d,left: 0.5410612862863846d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4703878669852375d,right: 0.9119786902569962d,bottom: 0.06497253013271442d,left: 0.8923948365531371d),

new NpgsqlTypes.NpgsqlBox(top: 0.7894088333416818d,right: 0.3232410773651525d,bottom: 0.48076109100690523d,left: 0.065072007277727d),

new NpgsqlTypes.NpgsqlBox(top: 0.7643797738342498d,right: 0.48026492759068984d,bottom: 0.4807208521643238d,left: 0.2991900590420985d),

new NpgsqlTypes.NpgsqlBox(top: 0.30629655209585194d,right: 0.5512129318248622d,bottom: 0.0830150320738876d,left: 0.03353207567372252d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9341601286563946d,right: 0.7147768619311324d,bottom: 0.7066467997347399d,left: 0.0650595369620357d),

new NpgsqlTypes.NpgsqlBox(top: 0.7251486963478548d,right: 0.24888128285414834d,bottom: 0.3773341189381626d,left: 0.11408070370570123d),

new NpgsqlTypes.NpgsqlBox(top: 0.38472263161994524d,right: 0.9464968595714729d,bottom: 0.25667972218188717d,left: 0.716917362971949d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6081792387167795d,right: 0.8225831942493003d,bottom: 0.013595340629033004d,left: 0.020520733900010968d),

new NpgsqlTypes.NpgsqlBox(top: 0.94566992056752d,right: 0.8298555352792474d,bottom: 0.21372358374135492d,left: 0.8287803288857797d),

new NpgsqlTypes.NpgsqlBox(top: 0.4223078460817399d,right: 0.24915865495991674d,bottom: 0.20659130702286355d,left: 0.2284795494368389d),

new NpgsqlTypes.NpgsqlBox(top: 0.7557922455478118d,right: 0.4238686206837059d,bottom: 0.3452270674682747d,left: 0.30611324538909424d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6181792943090089d,right: 0.882262557568174d,bottom: 0.34098690761136585d,left: 0.2925660922782286d),

new NpgsqlTypes.NpgsqlBox(top: 0.5178810515201163d,right: 0.36911017181663175d,bottom: 0.17146558245654064d,left: 0.1852136114113091d),

new NpgsqlTypes.NpgsqlBox(top: 0.5153145180281474d,right: 0.6144429849378222d,bottom: 0.39658312610776414d,left: 0.015175699326424819d),

new NpgsqlTypes.NpgsqlBox(top: 0.32644946595348023d,right: 0.6571185933816296d,bottom: 0.00537581732861081d,left: 0.29830247751241934d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9614875679527377d,right: 0.3422639587595313d,bottom: 0.7757405204922896d,left: 0.27428016277602807d),

new NpgsqlTypes.NpgsqlBox(top: 0.4658591798402095d,right: 0.8309018821452766d,bottom: 0.1550999276293208d,left: 0.35300823749658383d),

new NpgsqlTypes.NpgsqlBox(top: 0.49399924121212924d,right: 0.9646988538632161d,bottom: 0.4485149593549038d,left: 0.3511518935745893d),

new NpgsqlTypes.NpgsqlBox(top: 0.42243048577438647d,right: 0.8268553714928708d,bottom: 0.2622283661948017d,left: 0.22304488732579908d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9440038978226037d,right: 0.7072399309034333d,bottom: 0.15460163522750514d,left: 0.37663866051561223d),

new NpgsqlTypes.NpgsqlBox(top: 0.1507032249062925d,right: 0.8758965238035265d,bottom: 0.12847465405195035d,left: 0.11286259170139601d),

new NpgsqlTypes.NpgsqlBox(top: 0.6347435767081028d,right: 0.6803943909499519d,bottom: 0.15914304546136826d,left: 0.1989271180003792d),

new NpgsqlTypes.NpgsqlBox(top: 0.6334934254168822d,right: 0.4966796687168298d,bottom: 0.5667508067306058d,left: 0.14000354373892698d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3902540960227745d,right: 0.597130265008467d,bottom: 0.22682248081959833d,left: 0.1616385738735111d),

new NpgsqlTypes.NpgsqlBox(top: 0.9286423501890303d,right: 0.8742164477973055d,bottom: 0.8807577101828937d,left: 0.026792065218878558d),

new NpgsqlTypes.NpgsqlBox(top: 0.6691514911061127d,right: 0.3587432874086409d,bottom: 0.3112591208831259d,left: 0.24957488973423547d),

new NpgsqlTypes.NpgsqlBox(top: 0.5376104937254251d,right: 0.7616572178721008d,bottom: 0.1708565879624242d,left: 0.62782542029082d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8672916442052491d,right: 0.8366547792367625d,bottom: 0.0873954172614887d,left: 0.7978609275956147d),

new NpgsqlTypes.NpgsqlBox(top: 0.7856089982151886d,right: 0.8046825254555247d,bottom: 0.16866204454064337d,left: 0.6482640992088473d),

new NpgsqlTypes.NpgsqlBox(top: 0.6127335394047384d,right: 0.6424580431775702d,bottom: 0.1794123842230455d,left: 0.4695116852547049d),

new NpgsqlTypes.NpgsqlBox(top: 0.9145284009781202d,right: 0.9610765507626514d,bottom: 0.7081825641630505d,left: 0.7137085848684407d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9821846795887474d,right: 0.5293883227906112d,bottom: 0.5867154071903039d,left: 0.018832593509736206d),

new NpgsqlTypes.NpgsqlBox(top: 0.8982920382378358d,right: 0.692168241697461d,bottom: 0.28450819967394625d,left: 0.6801364519278068d),

new NpgsqlTypes.NpgsqlBox(top: 0.36682635644131956d,right: 0.9127765815304018d,bottom: 0.0800443973160675d,left: 0.33784702475469053d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7881455711327249d,right: 0.7933156533362056d,bottom: 0.24276995980901284d,left: 0.24434752568771045d),

new NpgsqlTypes.NpgsqlBox(top: 0.709986718767267d,right: 0.8781644946024364d,bottom: 0.5592708830825616d,left: 0.3287963045895592d),

new NpgsqlTypes.NpgsqlBox(top: 0.6694996018269913d,right: 0.4692212683312894d,bottom: 0.28446253886078554d,left: 0.34862608822355745d),

new NpgsqlTypes.NpgsqlBox(top: 0.8379454428700838d,right: 0.7019599404634004d,bottom: 0.591008812571288d,left: 0.502865667145861d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2267775683368749d,right: 0.7945820274993681d,bottom: 0.02293412578636267d,left: 0.11252540913675368d),

new NpgsqlTypes.NpgsqlBox(top: 0.8752043075170817d,right: 0.6772402101637458d,bottom: 0.16327267860597228d,left: 0.3990312636262464d),

new NpgsqlTypes.NpgsqlBox(top: 0.8586039119944514d,right: 0.8948470963729072d,bottom: 0.7545124691634254d,left: 0.4794737771033549d),

new NpgsqlTypes.NpgsqlBox(top: 0.9910216256793042d,right: 0.630193279307448d,bottom: 0.9121081807872543d,left: 0.4597226884574187d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9949024651643443d,right: 0.6863303990374992d,bottom: 0.29623822937799416d,left: 0.6499630214580034d),

new NpgsqlTypes.NpgsqlBox(top: 0.8150685639906502d,right: 0.2095796722651997d,bottom: 0.2623399941853626d,left: 0.06610221106217429d),

new NpgsqlTypes.NpgsqlBox(top: 0.8404738765186625d,right: 0.9164222789454481d,bottom: 0.09308819078669184d,left: 0.8878289233332187d),

new NpgsqlTypes.NpgsqlBox(top: 0.8742218807455602d,right: 0.7865226871745307d,bottom: 0.019760591697287055d,left: 0.7532342900596674d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41447644740363165d,right: 0.4369041315781831d,bottom: 0.20664822802584615d,left: 0.23938779243276398d),

new NpgsqlTypes.NpgsqlBox(top: 0.7741942908086551d,right: 0.6894801900348282d,bottom: 0.4398813720728365d,left: 0.4616387812416406d),

new NpgsqlTypes.NpgsqlBox(top: 0.9556781820269649d,right: 0.33724667031837163d,bottom: 0.23768458585897667d,left: 0.18274753762082252d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9113386117728262d,right: 0.7711608942710696d,bottom: 0.5247665520754375d,left: 0.25015484684287115d),

new NpgsqlTypes.NpgsqlBox(top: 0.7998761688004062d,right: 0.6746520275886957d,bottom: 0.5441617660152636d,left: 0.12020119477248892d),

new NpgsqlTypes.NpgsqlBox(top: 0.5429242171986609d,right: 0.6833570147834489d,bottom: 0.3283250228063168d,left: 0.16031620584880468d),

new NpgsqlTypes.NpgsqlBox(top: 0.6762311232973109d,right: 0.07284499403570932d,bottom: 0.2847228627080206d,left: 0.04090139557476469d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8436618822617064d,right: 0.7937318877632865d,bottom: 0.45724116567098305d,left: 0.2873821063659595d),

new NpgsqlTypes.NpgsqlBox(top: 0.286915088271646d,right: 0.633106148190853d,bottom: 0.2221199938902133d,left: 0.197841266104692d),

new NpgsqlTypes.NpgsqlBox(top: 0.5724596143000144d,right: 0.9048596366023822d,bottom: 0.4821958668049726d,left: 0.8952359041187968d),

new NpgsqlTypes.NpgsqlBox(top: 0.9008551441882636d,right: 0.835661314785464d,bottom: 0.13585845610064085d,left: 0.7843734051561897d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8702766935017526d,right: 0.818062444776244d,bottom: 0.4797658599141644d,left: 0.22941455377178943d),

new NpgsqlTypes.NpgsqlBox(top: 0.5248318584135526d,right: 0.7116503501267825d,bottom: 0.21144590330133217d,left: 0.3213138788179437d),

new NpgsqlTypes.NpgsqlBox(top: 0.6115715510010656d,right: 0.8727675436293659d,bottom: 0.554057237254197d,left: 0.2719512694099737d),

new NpgsqlTypes.NpgsqlBox(top: 0.4305190264718338d,right: 0.5359968080540676d,bottom: 0.3389619474667783d,left: 0.16566718663154245d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6386634734701415d,right: 0.7776265676317604d,bottom: 0.4260865930639849d,left: 0.3873306525783933d),

new NpgsqlTypes.NpgsqlBox(top: 0.3507322283709092d,right: 0.6578187847390381d,bottom: 0.03362526060269899d,left: 0.16860118226326282d),

new NpgsqlTypes.NpgsqlBox(top: 0.7178883039934069d,right: 0.9757798584452049d,bottom: 0.06407713169710227d,left: 0.04438091817025824d),

new NpgsqlTypes.NpgsqlBox(top: 0.5571438131626675d,right: 0.7080731272401108d,bottom: 0.19459910216925136d,left: 0.5360898388202148d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9561494128354124d,right: 0.9898954683146635d,bottom: 0.15536976582543627d,left: 0.7876282573089864d),

new NpgsqlTypes.NpgsqlBox(top: 0.9126042770161602d,right: 0.9034604638623637d,bottom: 0.22065068655625575d,left: 0.33944519652016747d),

new NpgsqlTypes.NpgsqlBox(top: 0.9772416765834128d,right: 0.7059152976127385d,bottom: 0.09774490668952784d,left: 0.54238624555973d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8891539283049285d,right: 0.9324377042126025d,bottom: 0.34149381230484477d,left: 0.36571356920952647d),

new NpgsqlTypes.NpgsqlBox(top: 0.7315124847095162d,right: 0.7740027645207846d,bottom: 0.5670052172419001d,left: 0.3326989860895939d),

new NpgsqlTypes.NpgsqlBox(top: 0.6431904522952613d,right: 0.9792693717092841d,bottom: 0.4974809266212191d,left: 0.37733652805655404d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8049122927667176d,right: 0.6713815333203126d,bottom: 0.4326098964494077d,left: 0.6192339146505867d),

new NpgsqlTypes.NpgsqlBox(top: 0.8091514277201454d,right: 0.8726186118885705d,bottom: 0.6834837107083159d,left: 0.7748386142861196d),

new NpgsqlTypes.NpgsqlBox(top: 0.620022242633026d,right: 0.813613335147666d,bottom: 0.058408620677796175d,left: 0.6586885648553764d),

new NpgsqlTypes.NpgsqlBox(top: 0.9800671504294302d,right: 0.7477070608833729d,bottom: 0.1823213498828058d,left: 0.39552344877067114d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.29488081202474015d,right: 0.6360111201377322d,bottom: 0.1564382427525992d,left: 0.08483568846005585d),

new NpgsqlTypes.NpgsqlBox(top: 0.6076779323896849d,right: 0.34080232981140324d,bottom: 0.024992460735519306d,left: 0.23723696411673045d),

new NpgsqlTypes.NpgsqlBox(top: 0.8790480302166641d,right: 0.7311369629704727d,bottom: 0.630540420120142d,left: 0.25367057775012425d),

new NpgsqlTypes.NpgsqlBox(top: 0.9413239131282466d,right: 0.8793751128770165d,bottom: 0.39828845846956706d,left: 0.7708940622929973d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7260313955475056d,right: 0.40577657431762426d,bottom: 0.1614053067487745d,left: 0.28198118215682744d),

new NpgsqlTypes.NpgsqlBox(top: 0.4548392205672318d,right: 0.9190753283550643d,bottom: 0.35881548181981093d,left: 0.4644480804687602d),

new NpgsqlTypes.NpgsqlBox(top: 0.8951833372442488d,right: 0.650509751825296d,bottom: 0.8388200287356562d,left: 0.13622609416861475d),

new NpgsqlTypes.NpgsqlBox(top: 0.38403741969472904d,right: 0.6301682535453241d,bottom: 0.04329195231934768d,left: 0.18685809343532378d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44297936329227694d,right: 0.7067625582644816d,bottom: 0.03396984163350436d,left: 0.46545491504527303d),

new NpgsqlTypes.NpgsqlBox(top: 0.9402848353649601d,right: 0.8791200591685726d,bottom: 0.5024460198070062d,left: 0.01821035592550846d),

new NpgsqlTypes.NpgsqlBox(top: 0.8147557111538664d,right: 0.580166588123966d,bottom: 0.776303291719583d,left: 0.27610231599671153d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6026050792647445d,right: 0.8052381217610605d,bottom: 0.5927062948406767d,left: 0.09503288307722191d),

new NpgsqlTypes.NpgsqlBox(top: 0.837345789486746d,right: 0.7811830826722356d,bottom: 0.4436583320621027d,left: 0.5056738238419759d),

new NpgsqlTypes.NpgsqlBox(top: 0.36581943195550326d,right: 0.6436482471898487d,bottom: 0.1496034675802853d,left: 0.2999333681658142d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5891864052349447d,right: 0.5073918461611955d,bottom: 0.13545125737772234d,left: 0.30200961437876284d),

new NpgsqlTypes.NpgsqlBox(top: 0.8305788079544892d,right: 0.1356434742596272d,bottom: 0.07309792992124697d,left: 0.09744639805665756d),

new NpgsqlTypes.NpgsqlBox(top: 0.9254500628485649d,right: 0.9959325736883478d,bottom: 0.842196904166102d,left: 0.4377357286421386d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3893825965426697d,right: 0.9391957509379364d,bottom: 0.3456146236919637d,left: 0.8739005676689655d),

new NpgsqlTypes.NpgsqlBox(top: 0.8671965841793453d,right: 0.7987462336703018d,bottom: 0.6744971899472956d,left: 0.21015126490132452d),

new NpgsqlTypes.NpgsqlBox(top: 0.8673946582019504d,right: 0.22430951708324198d,bottom: 0.13221455420720096d,left: 0.10095002440963552d),

new NpgsqlTypes.NpgsqlBox(top: 0.7322273103655604d,right: 0.4355460667239064d,bottom: 0.31966932211561605d,left: 0.09665145494236493d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9961546647151074d,right: 0.3157025202884365d,bottom: 0.8855541252025332d,left: 0.0040046749784474756d),

new NpgsqlTypes.NpgsqlBox(top: 0.6916247865012598d,right: 0.7435514452595413d,bottom: 0.139087567893472d,left: 0.4345043571737459d),

new NpgsqlTypes.NpgsqlBox(top: 0.924967732278357d,right: 0.7562949925466418d,bottom: 0.8660691265700369d,left: 0.02543754343875848d),

new NpgsqlTypes.NpgsqlBox(top: 0.9794796501874924d,right: 0.4400832287035322d,bottom: 0.8215302288229351d,left: 0.22020053103363546d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4553052499708282d,right: 0.33489488077794627d,bottom: 0.16027547268690234d,left: 0.16928835342638227d),

new NpgsqlTypes.NpgsqlBox(top: 0.9919659923886496d,right: 0.9183161493239302d,bottom: 0.4638684845943779d,left: 0.0030392716736102887d),

new NpgsqlTypes.NpgsqlBox(top: 0.6007984608448496d,right: 0.9640679446644245d,bottom: 0.05120511094195135d,left: 0.006800704115093703d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5376064989383882d,right: 0.5586543945136146d,bottom: 0.14912693915307051d,left: 0.31922894056464146d),

new NpgsqlTypes.NpgsqlBox(top: 0.9083833206599129d,right: 0.8423043478226464d,bottom: 0.7249425641764805d,left: 0.3185922136244078d),

new NpgsqlTypes.NpgsqlBox(top: 0.41582506422639d,right: 0.12642841483843636d,bottom: 0.31706913570565887d,left: 0.05864083552350374d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6039485678165191d,right: 0.8889997627959839d,bottom: 0.31103879146552804d,left: 0.14881371158164813d),

new NpgsqlTypes.NpgsqlBox(top: 0.48036182017551055d,right: 0.9428331119088764d,bottom: 0.3378769311453388d,left: 0.37708158665340374d),

new NpgsqlTypes.NpgsqlBox(top: 0.9346808552793308d,right: 0.9109790471731449d,bottom: 0.6219260390592383d,left: 0.06012710043808178d),

new NpgsqlTypes.NpgsqlBox(top: 0.6097620663392944d,right: 0.6089672408419546d,bottom: 0.006621834004385541d,left: 0.07344343067938375d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6178555883880921d,right: 0.40916029029846135d,bottom: 0.2361837032193661d,left: 0.02900404672226775d),

new NpgsqlTypes.NpgsqlBox(top: 0.8909664884444952d,right: 0.08048074383630632d,bottom: 0.16333367773386376d,left: 0.03420307885705132d),

new NpgsqlTypes.NpgsqlBox(top: 0.8671529719053581d,right: 0.6427157235468268d,bottom: 0.03364728744711465d,left: 0.337234586513955d),

new NpgsqlTypes.NpgsqlBox(top: 0.8343159810903663d,right: 0.48589690313999157d,bottom: 0.04202407827886845d,left: 0.45642711805044234d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7814930586985117d,right: 0.2158308469724386d,bottom: 0.22779873238925374d,left: 0.2012520197806219d),

new NpgsqlTypes.NpgsqlBox(top: 0.5612757681346662d,right: 0.8952335793403366d,bottom: 0.5463206923430196d,left: 0.5362677006794279d),

new NpgsqlTypes.NpgsqlBox(top: 0.1179379088259851d,right: 0.3483767660959167d,bottom: 0.049953513372348435d,left: 0.14862240479995348d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44581669371627053d,right: 0.6215381843266001d,bottom: 0.29943585562651254d,left: 0.31700370667358435d),

new NpgsqlTypes.NpgsqlBox(top: 0.9677349607836273d,right: 0.9667312573626208d,bottom: 0.6061214788830295d,left: 0.4105486107137225d),

new NpgsqlTypes.NpgsqlBox(top: 0.9412161503582077d,right: 0.8894181148260707d,bottom: 0.35692124589133634d,left: 0.7879102298751784d),

new NpgsqlTypes.NpgsqlBox(top: 0.8614752371118317d,right: 0.6238378890587637d,bottom: 0.4359847305425901d,left: 0.3469172809467739d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9686244275300089d,right: 0.3728647608029355d,bottom: 0.5668260219743618d,left: 0.12376239464503169d),

new NpgsqlTypes.NpgsqlBox(top: 0.8025434097016546d,right: 0.43249976065214246d,bottom: 0.404405758225309d,left: 0.12506733153124638d),

new NpgsqlTypes.NpgsqlBox(top: 0.3485374112017835d,right: 0.9498628380855177d,bottom: 0.02817817034765613d,left: 0.7429022672046988d),

new NpgsqlTypes.NpgsqlBox(top: 0.8707801260726821d,right: 0.8536067695483038d,bottom: 0.2921683206335771d,left: 0.5487048854382445d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2205084540319805d,right: 0.4944981328048609d,bottom: 0.023706854863857707d,left: 0.12419704005444854d),

new NpgsqlTypes.NpgsqlBox(top: 0.2895169528432927d,right: 0.6798437728089282d,bottom: 0.2691104218321748d,left: 0.6180914164924042d),

new NpgsqlTypes.NpgsqlBox(top: 0.6060320769108993d,right: 0.5816949610172162d,bottom: 0.23510487504988353d,left: 0.06408830865029591d),

},
    ModelInner = null,
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 48, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 14, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[32],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 27, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 62, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 171, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

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
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI), typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                await ((INpgsqlBoxListboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                ((INpgsqlBoxListboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

