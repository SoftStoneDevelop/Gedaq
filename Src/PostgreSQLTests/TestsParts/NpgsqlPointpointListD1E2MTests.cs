

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
    internal partial interface INpgsqlPointListpointListD1
    {
    }
    
    internal partial class NpgsqlPointListpointListD1 : INpgsqlPointListpointListD1
    {


#region TestData

        private readonly NpgsqlPointpointListD1E2M[] _testData = new NpgsqlPointpointListD1E2M[]
        {
            new NpgsqlPointpointListD1E2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6538998160357927d, y: 0.36733815191602526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24936697732957813d, y: 0.9933621392709091d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5675938625842791d, y: 0.031013488670387668d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9974126268443922d, y: 0.043452066897538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5866661152091324d, y: 0.7615753264228013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7477567773267797d, y: 0.2860210229652521d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3420840852944116d, y: 0.9469040272514306d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2987890626038129d, y: 0.33684720725085493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27296939987528734d, y: 0.6520066297286967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34891395162165617d, y: 0.11878116183455101d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8184567456829112d, y: 0.6636121654188004d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14471918682083573d, y: 0.4030471035913987d),

new NpgsqlTypes.NpgsqlPoint(x: 0.729371884951441d, y: 0.2695384953966351d),

new NpgsqlTypes.NpgsqlPoint(x: 0.673943296559358d, y: 0.12540206980998314d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39968769192945897d, y: 0.9792667474773518d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8606241146533449d, y: 0.8498898125733423d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6320511997571433d, y: 0.388123753225316d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9950363780700412d, y: 0.09288684183844875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2763691398985165d, y: 0.25464338009191d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2947981813191395d, y: 0.8698421113609074d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03134165322546667d, y: 0.15220995899477308d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6420818338198033d, y: 0.9032913286495067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3359786035732122d, y: 0.9165781502169622d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5676418428979328d, y: 0.039893345932424884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18984665385897803d, y: 0.3561837542577184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37043642719037095d, y: 0.28441093957360786d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8781484503950081d, y: 0.7230503998822981d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26176283139347867d, y: 0.9075113106316811d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9586429505401151d, y: 0.44303008593761506d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8802984723869395d, y: 0.5136580962170426d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6296969072989955d, y: 0.918098837705531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5737819243759952d, y: 0.9900845157353525d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6351634703392738d, y: 0.8702096687123768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719134646672657d, y: 0.9342817869527473d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26428564314617187d, y: 0.14569648140434732d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03036111571231348d, y: 0.6649829379883219d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8598489110398491d, y: 0.4962966787537789d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4730050018390013d, y: 0.7706498982481074d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7341585986885937d, y: 0.9670479536100771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7913727548160914d, y: 0.880082816517883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2559220793762067d, y: 0.13104842980283948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8955868470334267d, y: 0.3141773757376837d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27737987565205857d, y: 0.9135310104548092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7850494164309857d, y: 0.4098588666705145d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6163171187424153d, y: 0.6435462427977892d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.018647566651270986d, y: 0.7629232632676495d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05372636881895332d, y: 0.772033727365211d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6096530965301781d, y: 0.505386619312943d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5026273455243553d, y: 0.0396679376242387d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08442329294603823d, y: 0.5504295869351451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6069822001577738d, y: 0.28421907374543987d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45836237623181586d, y: 0.959461285846216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9544325210212499d, y: 0.43044466480880716d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11261820033590297d, y: 0.9643596833370593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18436758524245278d, y: 0.8650021888014562d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8274000133173804d, y: 0.9597269225966225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9717519297140816d, y: 0.551842929140105d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.014137668009935211d, y: 0.7235661338694159d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8662830391207603d, y: 0.7538971200280075d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8228992529694982d, y: 0.889503478151506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6398913825989344d, y: 0.7179168899249669d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9690522070122005d, y: 0.5650223464400418d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7796289495868777d, y: 0.3049355185451379d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7825841820378678d, y: 0.3388896902408495d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6445046699783511d, y: 0.06112839748946264d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25783873295753d, y: 0.5973268259075242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4117020859260532d, y: 0.6066405316289525d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9039640618963678d, y: 0.0023124671953810294d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4199314037599903d, y: 0.9025203482254285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4744188486183524d, y: 0.7399385622547406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38665884031593944d, y: 0.6117396657152496d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0681902411057751d, y: 0.7041188085005222d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9570082786572572d, y: 0.3408975285695782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2939306678112643d, y: 0.19354683106975934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8373904054565582d, y: 0.6144773109983839d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2719887630029483d, y: 0.5317495352148345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05230238397700848d, y: 0.0766743773393298d),

new NpgsqlTypes.NpgsqlPoint(x: 0.278838712533763d, y: 0.26931231879931505d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7178722202646044d, y: 0.19412194496973267d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30035302959321064d, y: 0.8315479311246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9143374908486537d, y: 0.8195140037014301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.054695788653448596d, y: 0.02984157626387851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6316838547234598d, y: 0.5452159325204418d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05747393825858982d, y: 0.5382714995065582d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07810628799787456d, y: 0.34954432670811686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11578545369874071d, y: 0.6942029746674421d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9017803284029788d, y: 0.7677113981491228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7757751060167053d, y: 0.27546098044844736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08887850892763993d, y: 0.44220879041271977d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3097084489193448d, y: 0.7763830768237531d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8924117666169024d, y: 0.608195067975479d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9222643372543976d, y: 0.10225414601062277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8519028305665589d, y: 0.7161491731386591d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22387670949448413d, y: 0.3675406288148647d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31626845784026547d, y: 0.5200870184981964d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6875715744217438d, y: 0.07074446470046869d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7583109855248554d, y: 0.7848510326183752d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9281442532773287d, y: 0.7966704789841043d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6773430027036114d, y: 0.2043661864081523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.702027203248017d, y: 0.590396828677111d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6087366524480328d, y: 0.7734132577798677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.777975357337142d, y: 0.534266284762555d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7442607201748653d, y: 0.4290108772225488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6946986284447131d, y: 0.4418956890913238d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8236838145582116d, y: 0.43533648275902903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41125062957010716d, y: 0.00953696446640151d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7151917698178413d, y: 0.17498269917026832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3839180433696928d, y: 0.0465829703300068d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06589705135699342d, y: 0.04402650554207954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3412567187052685d, y: 0.7003493488404926d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9837730911290788d, y: 0.44581831241976766d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8916222368612637d, y: 0.05221467231415455d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4291861882012167d, y: 0.653445761216445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1659076913489259d, y: 0.03401657306391059d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13020653717972397d, y: 0.6172296261236587d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6965763332605005d, y: 0.08459488968333728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8862280577091d, y: 0.9413404259989879d),

new NpgsqlTypes.NpgsqlPoint(x: 0.778215218513795d, y: 0.7964254845822155d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17668575776390683d, y: 0.7000541613252405d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6832161137248711d, y: 0.6778630975905195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8229015466522197d, y: 0.15912329140604287d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3950144591206304d, y: 0.4405171971405486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18869102107367908d, y: 0.7773514420523842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20765225547076505d, y: 0.49270031466891984d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7783387788627781d, y: 0.3615581595545524d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20896207588349114d, y: 0.8260839720358035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5279822781213623d, y: 0.20520894383879418d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6699366067628996d, y: 0.2123524590434348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.308323469245533d, y: 0.8750660674708212d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7576789625687169d, y: 0.8271054100944086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45886926869073863d, y: 0.9365103287336087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7846224984121398d, y: 0.6741000663952049d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3900128658810471d, y: 0.8756839753705254d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20488093749283143d, y: 0.914747880716869d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6784645042175084d, y: 0.8078705503020437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18388698073482546d, y: 0.015657540243566914d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29675968261192665d, y: 0.46203713322554163d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46451812241010193d, y: 0.0975266809340799d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8705800369210631d, y: 0.3467108627730058d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159853326746983d, y: 0.781855817557267d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6249616436164274d, y: 0.3038723038304908d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8345364076592172d, y: 0.304170493234313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2232583425414375d, y: 0.3797046469757054d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.62049395560235d, y: 0.6483850957481397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8575120322751619d, y: 0.44053223266758734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9923777626759136d, y: 0.1618893981291598d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33270992299034097d, y: 0.8028347522740324d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2756765458311754d, y: 0.2503988900309315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21679019902341523d, y: 0.8234344305639653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7722989492441016d, y: 0.6790874615647935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.560564894026488d, y: 0.6809185157074706d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2833244401110879d, y: 0.9693498295000125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7396983609985175d, y: 0.5230851983455531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5652493498495004d, y: 0.42177374422379466d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0701205563869618d, y: 0.9130453565770605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24781447233311193d, y: 0.9563188379009134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2153265978063853d, y: 0.32362503287566446d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.674374279230843d, y: 0.4426731249983238d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4886336043727424d, y: 0.7581250367012069d),

new NpgsqlTypes.NpgsqlPoint(x: 0.941831738860094d, y: 0.028127619840950357d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7124022087339269d, y: 0.09710940819737146d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8092608942983885d, y: 0.30244183844819994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6107026173610915d, y: 0.4860367522348673d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5791750174318301d, y: 0.3718151354832736d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4756907517278338d, y: 0.5837352606011613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02864200002239603d, y: 0.33707975565029624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8584979810100264d, y: 0.03658076391337306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7215575783859403d, y: 0.13319497739633468d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9034618393994215d, y: 0.017587549306024908d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4890513388399079d, y: 0.4531405964552886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6092261394961355d, y: 0.15093772542998052d),

new NpgsqlTypes.NpgsqlPoint(x: 0.036469509901477015d, y: 0.15819114691591163d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5891412687664108d, y: 0.3385421028159109d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5606861686067017d, y: 0.07851261470269166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5553583066032228d, y: 0.7231800290793414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03434389622035994d, y: 0.7626090115803633d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.788271736880835d, y: 0.7167193505519818d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37440653207273245d, y: 0.13672448609847876d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6677668251618984d, y: 0.8301743049466245d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6523134225970373d, y: 0.39956335356824535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5949792805558066d, y: 0.16880096303907477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19362254444552607d, y: 0.2967241404694815d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.460735986302949d, y: 0.10170974767133745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8243472366532745d, y: 0.20433023658444094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.893588608529223d, y: 0.13201750054439032d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8744868750545267d, y: 0.12916962657430886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45347645275254433d, y: 0.20921481985645551d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03545424251082718d, y: 0.3217341964626381d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6013837587411032d, y: 0.7139171813472901d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19857643371304623d, y: 0.01928966121969289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2936722576823162d, y: 0.8622244237597784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49318069495922423d, y: 0.41151387917656435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6858527324991732d, y: 0.41432271684855526d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6606203520050395d, y: 0.6926042703176518d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9132294536846037d, y: 0.7019030332423917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6032737644196209d, y: 0.7613473371184829d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7092217281478489d, y: 0.7517360685413234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09003383986259617d, y: 0.7902796468240244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2947259936586617d, y: 0.2945046589897453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5442414329994876d, y: 0.5786119784428165d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5033664555649885d, y: 0.11670882963950535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.597874506306216d, y: 0.4327691477971184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21355539664240197d, y: 0.22837543813279682d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12178137030998848d, y: 0.6437515008033126d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370198113887741d, y: 0.019393629439432125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40381078048677366d, y: 0.024026605314069416d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7218088494445193d, y: 0.48595408662808137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1452910342631082d, y: 0.7313560426733954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.551000139052599d, y: 0.24582760524873792d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9772280633097814d, y: 0.6401748136104317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2151613719553349d, y: 0.830094792160825d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11570596625696727d, y: 0.3615675057860548d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20868894937089066d, y: 0.9454332572487906d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9426220122738473d, y: 0.9133747276276503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20997007369238774d, y: 0.46417835446287614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4253717889147537d, y: 0.3390618471345197d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1586696041647041d, y: 0.9182076818817425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22954465385120404d, y: 0.1406482397235701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.805268717812237d, y: 0.15447016095183785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0345330192181581d, y: 0.7720645312762301d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23855856155335897d, y: 0.4926026425059732d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7373614342744218d, y: 0.43180452977525674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6679964190111476d, y: 0.20874943261646906d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9539280531731866d, y: 0.07895371874385204d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15588643401115154d, y: 0.49179599285396003d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23650837846934036d, y: 0.19441532090741354d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03756804972527439d, y: 0.41802564441948564d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7274318782001833d, y: 0.007858083855450504d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5080152454174864d, y: 0.2607052310268485d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16890072108511311d, y: 0.49794636175869267d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7421904586561846d, y: 0.43821297628945466d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9144192701154557d, y: 0.7255164827305041d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9759591643874437d, y: 0.8676136129794464d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9716292007327618d, y: 0.21038296040505677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021916583255094824d, y: 0.46525022450935594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2324568984178974d, y: 0.30662570865131544d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9394041393501749d, y: 0.7477958082457123d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7057350857879849d, y: 0.33929980589827347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17253430563081584d, y: 0.5999667915176238d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7843344603965318d, y: 0.8603696665479218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33043166455666606d, y: 0.07715879062336639d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05056369933616589d, y: 0.726293450440933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26812669851278725d, y: 0.5085618764909027d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5490375167561713d, y: 0.5201404861008092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43409634048722123d, y: 0.7852255106660384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9589875192862163d, y: 0.009120850389730761d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5540714286333882d, y: 0.4016991171482759d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5828881301150443d, y: 0.46248906002534484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05543059632211489d, y: 0.35398679290949897d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7937907334528375d, y: 0.6877980605200291d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5145598994296843d, y: 0.33577604942559136d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5398687045538549d, y: 0.6280488662115004d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9307205992826242d, y: 0.418142826592253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10079151110905393d, y: 0.8796259749381022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2479011712825434d, y: 0.6073596879821083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5227329976054983d, y: 0.346525877661358d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11321631663292808d, y: 0.9823473428339734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9114207626254199d, y: 0.5990453677425066d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13535029760475403d, y: 0.45790165635610847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04576708313976008d, y: 0.9611174754982381d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.019188590250251214d, y: 0.07945872684420985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3768498052717434d, y: 0.3707448529563969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04889715386321147d, y: 0.705804852767165d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2183116448725929d, y: 0.697620877425799d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4670878526476365d, y: 0.3530466544967029d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21505846792071825d, y: 0.15707308597609282d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                List<NpgsqlPointpointListD1E2M> models = null;

                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointListD1E2M> models = null;

                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 130;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 10;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 25, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 18, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 153, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 86, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 69, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 79, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 69, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 33, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointListD1E2M),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
FROM public.binary_npgsqlpointpointlistd1e2m m
LEFT JOIN public.binary_npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointListpointListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI), typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                await ((INpgsqlPointListpointListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                ((INpgsqlPointListpointListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

