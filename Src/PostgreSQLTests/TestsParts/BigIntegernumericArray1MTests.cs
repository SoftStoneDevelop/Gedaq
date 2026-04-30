

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 1,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6734175095399492296L),
new System.Numerics.BigInteger(5588577745416644601L),
new System.Numerics.BigInteger(6804759625595434040L),
new System.Numerics.BigInteger(2436102234971220033L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4861727072283801335L),
new System.Numerics.BigInteger(8439227426202370221L),
new System.Numerics.BigInteger(2596089746304425016L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5863705466357991031L),
new System.Numerics.BigInteger(7780028845059495757L),
new System.Numerics.BigInteger(8496107635893826122L),
new System.Numerics.BigInteger(2552535656525947501L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6148541909712219681L),
new System.Numerics.BigInteger(5118315776784558968L),
new System.Numerics.BigInteger(6057608533523437329L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3922629638204209441L),
new System.Numerics.BigInteger(7575461924011837522L),
new System.Numerics.BigInteger(8388221698309298825L),
},
},
            new BigIntegernumericArray1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6097528030072829210L),
new System.Numerics.BigInteger(3728042760117943404L),
new System.Numerics.BigInteger(4078859805812965010L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9189720135117474390L),
new System.Numerics.BigInteger(431989086895667418L),
new System.Numerics.BigInteger(1460743958124538339L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2636943362742201852L),
new System.Numerics.BigInteger(8918166326137237774L),
new System.Numerics.BigInteger(8221904501323832573L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6487219376834224851L),
new System.Numerics.BigInteger(4622601429052880810L),
new System.Numerics.BigInteger(8245154618688424338L),
new System.Numerics.BigInteger(6732697765568198440L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2064008681701751768L),
new System.Numerics.BigInteger(3802658989099187542L),
new System.Numerics.BigInteger(815407011538871375L),
},
},
            new BigIntegernumericArray1M
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(782659851940087878L),
new System.Numerics.BigInteger(1475188150443676821L),
new System.Numerics.BigInteger(1084456055877174955L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9147461287929069446L),
new System.Numerics.BigInteger(7124289209461219095L),
new System.Numerics.BigInteger(1845875959271476310L),
new System.Numerics.BigInteger(3444432817880818155L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5889700333321666427L),
new System.Numerics.BigInteger(6936959158556930505L),
new System.Numerics.BigInteger(2790345573487156709L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6728133592697512196L),
new System.Numerics.BigInteger(3112158078425310700L),
new System.Numerics.BigInteger(8700847272823007128L),
new System.Numerics.BigInteger(2592226328608770585L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8790545278803391194L),
new System.Numerics.BigInteger(1040453769679638932L),
new System.Numerics.BigInteger(9081181972458186515L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4404812471348970996L),
new System.Numerics.BigInteger(8760341760367604612L),
new System.Numerics.BigInteger(2147029798102099002L),
new System.Numerics.BigInteger(7936911593383640407L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6111189498974045328L),
new System.Numerics.BigInteger(56782721032812944L),
new System.Numerics.BigInteger(4952685098028594586L),
new System.Numerics.BigInteger(5202129068343387803L),
},
},
            new BigIntegernumericArray1M
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7802482954450271722L),
new System.Numerics.BigInteger(5598729178084111283L),
new System.Numerics.BigInteger(3551414428097819198L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1490185790406109708L),
new System.Numerics.BigInteger(6428361115302163342L),
new System.Numerics.BigInteger(2796967588244118896L),
new System.Numerics.BigInteger(3837536756210366099L),
},
},
            new BigIntegernumericArray1M
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3087053111162436063L),
new System.Numerics.BigInteger(4511306801628986071L),
new System.Numerics.BigInteger(8463009488756006741L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1720608562350895945L),
new System.Numerics.BigInteger(2981115436018437357L),
new System.Numerics.BigInteger(3004264271065613356L),
new System.Numerics.BigInteger(7200085675917972494L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8758721208950087650L),
new System.Numerics.BigInteger(5667743311410323651L),
new System.Numerics.BigInteger(4626353000937447575L),
new System.Numerics.BigInteger(5857574762222095580L),
},
},
            new BigIntegernumericArray1M
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7756275964615842967L),
new System.Numerics.BigInteger(3677711767129143363L),
new System.Numerics.BigInteger(370466707445289860L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(217065133619165375L),
new System.Numerics.BigInteger(8040527761033544015L),
new System.Numerics.BigInteger(3307860908418785144L),
new System.Numerics.BigInteger(2518553819437576410L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 33,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3431137514872115420L),
new System.Numerics.BigInteger(4279779189304043078L),
new System.Numerics.BigInteger(9203155537911850710L),
new System.Numerics.BigInteger(6970225355466606558L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8831755942389559369L),
new System.Numerics.BigInteger(1731516691213720995L),
new System.Numerics.BigInteger(8901562521349696417L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(64857286520796196L),
new System.Numerics.BigInteger(1636134227875662226L),
new System.Numerics.BigInteger(6886607150061000613L),
},
},
            new BigIntegernumericArray1M
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2283342569222775133L),
new System.Numerics.BigInteger(5925424384415980739L),
new System.Numerics.BigInteger(1080292435257161951L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 34,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2347950816350700702L),
new System.Numerics.BigInteger(2750829931027279064L),
new System.Numerics.BigInteger(654514731508207081L),
new System.Numerics.BigInteger(8681879239280042522L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1272631105276381620L),
new System.Numerics.BigInteger(3836123403519120673L),
new System.Numerics.BigInteger(7808983250719186428L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2783991073657826861L),
new System.Numerics.BigInteger(5243702360964308518L),
new System.Numerics.BigInteger(465489011360438372L),
new System.Numerics.BigInteger(3000275182876048354L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2272433133730709392L),
new System.Numerics.BigInteger(3857779072449885642L),
new System.Numerics.BigInteger(3217373605408257990L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2743019388740625077L),
new System.Numerics.BigInteger(3164123813118700409L),
new System.Numerics.BigInteger(3545030769835687031L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8644360751259939235L),
new System.Numerics.BigInteger(8266018660152022668L),
new System.Numerics.BigInteger(2723545305479310162L),
new System.Numerics.BigInteger(3244185497627573543L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1066889080385646656L),
new System.Numerics.BigInteger(2739012157425228417L),
new System.Numerics.BigInteger(924590150110846106L),
},
},
            new BigIntegernumericArray1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6847863816067642729L),
new System.Numerics.BigInteger(9062498064812355730L),
new System.Numerics.BigInteger(520327310689551849L),
new System.Numerics.BigInteger(4063689449556889859L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4836586526727776797L),
new System.Numerics.BigInteger(637056914004047526L),
new System.Numerics.BigInteger(7297493193288451077L),
},
},
            new BigIntegernumericArray1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(383873446803723972L),
new System.Numerics.BigInteger(8993579960716548944L),
new System.Numerics.BigInteger(2041185301398217704L),
new System.Numerics.BigInteger(4333277150492418317L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 41,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6815843763311981081L),
new System.Numerics.BigInteger(8918785730281637390L),
new System.Numerics.BigInteger(2175738458651851987L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3338342225591604542L),
new System.Numerics.BigInteger(4364755391674701319L),
new System.Numerics.BigInteger(986533637573595394L),
new System.Numerics.BigInteger(2492391549825095760L),
},
},
            new BigIntegernumericArray1M
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8654871379501110215L),
new System.Numerics.BigInteger(4355129289123238295L),
new System.Numerics.BigInteger(8370546117454964715L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2567580674513024690L),
new System.Numerics.BigInteger(4837135240811602848L),
new System.Numerics.BigInteger(6545452231436364568L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2641276200852538530L),
new System.Numerics.BigInteger(1403261159371252712L),
new System.Numerics.BigInteger(1437545654553119768L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8316165241368885264L),
new System.Numerics.BigInteger(960371006575107938L),
new System.Numerics.BigInteger(3659773019955504864L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 89,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6749246495773082491L),
new System.Numerics.BigInteger(8689638162355517226L),
new System.Numerics.BigInteger(2716263195718910991L),
new System.Numerics.BigInteger(2058126748789508881L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 97,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7383378376500016938L),
new System.Numerics.BigInteger(5833100657834668298L),
new System.Numerics.BigInteger(5733141564828314012L),
new System.Numerics.BigInteger(5099305200171564270L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4424523235822974209L),
new System.Numerics.BigInteger(4547215041652881637L),
new System.Numerics.BigInteger(3614442902331215329L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4095121394776789946L),
new System.Numerics.BigInteger(534929405534199775L),
new System.Numerics.BigInteger(3084308586854428374L),
new System.Numerics.BigInteger(4217416717987690575L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2296038969161702657L),
new System.Numerics.BigInteger(5021859029057758577L),
new System.Numerics.BigInteger(6588124353072435194L),
new System.Numerics.BigInteger(6014955350736751626L),
},
},
            new BigIntegernumericArray1M
{
    Id = 102,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3591741564003365962L),
new System.Numerics.BigInteger(3188061562882094169L),
new System.Numerics.BigInteger(1938081700290032047L),
new System.Numerics.BigInteger(4888711140902949578L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 105,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8424597646700478673L),
new System.Numerics.BigInteger(3629480976814015716L),
new System.Numerics.BigInteger(4470870166975395730L),
new System.Numerics.BigInteger(6071661410277079017L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4409896491235352102L),
new System.Numerics.BigInteger(3490271460664742412L),
new System.Numerics.BigInteger(7195197001438844616L),
new System.Numerics.BigInteger(8781459453067554264L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7095118448741729326L),
new System.Numerics.BigInteger(6864762079362082304L),
new System.Numerics.BigInteger(1603082389735147960L),
new System.Numerics.BigInteger(7862715434334628253L),
},
},
            new BigIntegernumericArray1M
{
    Id = 110,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1545032090834297146L),
new System.Numerics.BigInteger(5103997197911526684L),
new System.Numerics.BigInteger(526855379579810038L),
new System.Numerics.BigInteger(770039187858151110L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5453217713843592583L),
new System.Numerics.BigInteger(2162800798924677246L),
new System.Numerics.BigInteger(4313688311321599593L),
},
},
            new BigIntegernumericArray1M
{
    Id = 115,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8279615505411497157L),
new System.Numerics.BigInteger(3584525312546477293L),
new System.Numerics.BigInteger(6036908391478377101L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6641645037403291470L),
new System.Numerics.BigInteger(1210595150001792893L),
new System.Numerics.BigInteger(423330876009909787L),
new System.Numerics.BigInteger(2872799106817096595L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4116547042101995396L),
new System.Numerics.BigInteger(3478005619391141545L),
new System.Numerics.BigInteger(2907735558898068957L),
new System.Numerics.BigInteger(2960976155626397710L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3567421182636442638L),
new System.Numerics.BigInteger(8277806603431438114L),
new System.Numerics.BigInteger(8914870520962724276L),
new System.Numerics.BigInteger(1802209232690743055L),
},
},
            new BigIntegernumericArray1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7805407195916292350L),
new System.Numerics.BigInteger(5342762484589002285L),
new System.Numerics.BigInteger(8810004384672298004L),
new System.Numerics.BigInteger(2571623106969040780L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4748067730438160317L),
new System.Numerics.BigInteger(8516127513379433490L),
new System.Numerics.BigInteger(689882108704610378L),
new System.Numerics.BigInteger(4728775215876290006L),
},
},
            new BigIntegernumericArray1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7259603279291920432L),
new System.Numerics.BigInteger(3622088005244953667L),
new System.Numerics.BigInteger(7149998685058824040L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2637361565907586670L),
new System.Numerics.BigInteger(137919648241676347L),
new System.Numerics.BigInteger(6984081862344438585L),
new System.Numerics.BigInteger(3566394869222793612L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3840357697394703536L),
new System.Numerics.BigInteger(8252010933202010427L),
new System.Numerics.BigInteger(1414367110914729824L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(143077082974769904L),
new System.Numerics.BigInteger(5528146296250177249L),
new System.Numerics.BigInteger(8953789335196248980L),
new System.Numerics.BigInteger(2908070908183722185L),
},
},
            new BigIntegernumericArray1M
{
    Id = 126,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3011061846001425767L),
new System.Numerics.BigInteger(4105164356264738628L),
new System.Numerics.BigInteger(3615247000954010462L),
new System.Numerics.BigInteger(3850685560394184072L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4438792641937495631L),
new System.Numerics.BigInteger(2610588496928802268L),
new System.Numerics.BigInteger(4820490813973700641L),
new System.Numerics.BigInteger(8711154226187817797L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2951334512919507341L),
new System.Numerics.BigInteger(2143240642172758747L),
new System.Numerics.BigInteger(4440968945450747191L),
new System.Numerics.BigInteger(1007685989131284343L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(304652864027893058L),
new System.Numerics.BigInteger(294887328867625288L),
new System.Numerics.BigInteger(8685734008166532395L),
new System.Numerics.BigInteger(380679282832463244L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8838801550544777161L),
new System.Numerics.BigInteger(868133085783337812L),
new System.Numerics.BigInteger(2253951509723656722L),
},
},
            new BigIntegernumericArray1M
{
    Id = 138,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3906649321064282457L),
new System.Numerics.BigInteger(3572481781019752457L),
new System.Numerics.BigInteger(8570274669780322072L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 145,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6542557607415745929L),
new System.Numerics.BigInteger(938864112618524341L),
new System.Numerics.BigInteger(1983417455617555779L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3634421297037569878L),
new System.Numerics.BigInteger(8678685694177546945L),
new System.Numerics.BigInteger(5362893841759416844L),
new System.Numerics.BigInteger(989852121053344010L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 149,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6855239277596149489L),
new System.Numerics.BigInteger(2225916614319522128L),
new System.Numerics.BigInteger(4687922972086717828L),
new System.Numerics.BigInteger(5947677042733670059L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 158,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8512656778679673087L),
new System.Numerics.BigInteger(5966943560554448496L),
new System.Numerics.BigInteger(8712753381084559615L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7186904510054609564L),
new System.Numerics.BigInteger(8956528041820480862L),
new System.Numerics.BigInteger(7901349301427408814L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3488501727422949625L),
new System.Numerics.BigInteger(7323661050085052543L),
new System.Numerics.BigInteger(6017257332266720348L),
new System.Numerics.BigInteger(1070041843614967543L),
},
},
            new BigIntegernumericArray1M
{
    Id = 162,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2651192036930287228L),
new System.Numerics.BigInteger(4125282759773613747L),
new System.Numerics.BigInteger(3496247570637439195L),
new System.Numerics.BigInteger(2297905205600271434L),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 83;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 58, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 22, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 1, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 83, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 149, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 149, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 49, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));
BigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[30], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[31], false);BigIntegernumericArray1M.AssertModel(models[27],_testData[32], false);BigIntegernumericArray1M.AssertModel(models[28],_testData[33], false);BigIntegernumericArray1M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
BigIntegernumericArray1M.AssertModel(models[0],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[29], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[30], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[31], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[32], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[33], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI), typeof(BigIntegernumericArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                await ((IBigIntegerArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                ((IBigIntegerArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

