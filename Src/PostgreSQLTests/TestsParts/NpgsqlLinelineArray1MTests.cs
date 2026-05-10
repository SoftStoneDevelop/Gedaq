

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4866255635374993d, b: 0.1929627257188301d, c: 0.083229639685242d),
new NpgsqlTypes.NpgsqlLine(a: 0.6006925029408835d, b: 0.648010584632963d, c: 0.3526701644833192d),
new NpgsqlTypes.NpgsqlLine(a: 0.32217821767695787d, b: 0.7162411186914804d, c: 0.10351885249732562d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4624182032212727d, b: 0.17090475431999963d, c: 0.8760387087721492d),
new NpgsqlTypes.NpgsqlLine(a: 0.03922580273771337d, b: 0.03949078881282864d, c: 0.3547420678685156d),
new NpgsqlTypes.NpgsqlLine(a: 0.5595177002979571d, b: 0.37417143049001966d, c: 0.21553712920683432d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5448522344438346d, b: 0.8254126646231886d, c: 0.5822270348264508d),
new NpgsqlTypes.NpgsqlLine(a: 0.5496481476247702d, b: 0.4489125040647881d, c: 0.6903775126752256d),
new NpgsqlTypes.NpgsqlLine(a: 0.07298719656301866d, b: 0.5591416010757102d, c: 0.03401794312806983d),
new NpgsqlTypes.NpgsqlLine(a: 0.1736130829135244d, b: 0.7499912928789747d, c: 0.5775843881812796d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1480263203375426d, b: 0.6841144177543733d, c: 0.5879501733614395d),
new NpgsqlTypes.NpgsqlLine(a: 0.7994334402723959d, b: 0.20855696948186875d, c: 0.3123014496309209d),
new NpgsqlTypes.NpgsqlLine(a: 0.6017887709334773d, b: 0.016157110875712033d, c: 0.4719159129190078d),
new NpgsqlTypes.NpgsqlLine(a: 0.7860517234714159d, b: 0.08205518493073927d, c: 0.3363064473796976d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7862214980674961d, b: 0.3771489079385957d, c: 0.6330534068644427d),
new NpgsqlTypes.NpgsqlLine(a: 0.7421482141392832d, b: 0.6220879380591698d, c: 0.7621094570367917d),
new NpgsqlTypes.NpgsqlLine(a: 0.8724524173969356d, b: 0.4150842159697734d, c: 0.31936657839034244d),
new NpgsqlTypes.NpgsqlLine(a: 0.8474764012724938d, b: 0.8203978083318063d, c: 0.8938295553727872d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8715415372060423d, b: 0.1615411712445205d, c: 0.5772537265388037d),
new NpgsqlTypes.NpgsqlLine(a: 0.890470995713357d, b: 0.6874711016982483d, c: 0.1633237891290229d),
new NpgsqlTypes.NpgsqlLine(a: 0.2930677059061578d, b: 0.13579341473259732d, c: 0.3433989208129813d),
new NpgsqlTypes.NpgsqlLine(a: 0.9474999350808613d, b: 0.7886160008189244d, c: 0.7223123713636528d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9979021983694023d, b: 0.3788036017253885d, c: 0.5060917629910359d),
new NpgsqlTypes.NpgsqlLine(a: 0.7271910476522767d, b: 0.5497143677571167d, c: 0.30056544334155944d),
new NpgsqlTypes.NpgsqlLine(a: 0.47919884009237856d, b: 0.9047721516240548d, c: 0.03862257907516797d),
new NpgsqlTypes.NpgsqlLine(a: 0.4309968036211581d, b: 0.5492689525193272d, c: 0.6402191904793693d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5496838377269996d, b: 0.25451065319111577d, c: 0.8159095510187779d),
new NpgsqlTypes.NpgsqlLine(a: 0.1345313866855571d, b: 0.12738870214193487d, c: 0.4858527601276469d),
new NpgsqlTypes.NpgsqlLine(a: 0.6285007908048522d, b: 0.6860851764654019d, c: 0.8973484261971846d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3161042566599065d, b: 0.19653236985661593d, c: 0.6861254083835331d),
new NpgsqlTypes.NpgsqlLine(a: 0.07089241754462594d, b: 0.7791366794818763d, c: 0.19965595481131382d),
new NpgsqlTypes.NpgsqlLine(a: 0.5969889256492963d, b: 0.308045352274845d, c: 0.7472981471626916d),
new NpgsqlTypes.NpgsqlLine(a: 0.7219744054266255d, b: 0.2597695884936788d, c: 0.28830717257836846d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.022171294421867715d, b: 0.24901769761769854d, c: 0.5292268849157282d),
new NpgsqlTypes.NpgsqlLine(a: 0.9568718013899302d, b: 0.26003702983303434d, c: 0.5874109360117418d),
new NpgsqlTypes.NpgsqlLine(a: 0.43849976374419497d, b: 0.2901541863563839d, c: 0.01908800003448985d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5291289906266621d, b: 0.2852903426182817d, c: 0.6856035957487016d),
new NpgsqlTypes.NpgsqlLine(a: 0.9847434683678492d, b: 0.20753684430548036d, c: 0.855394425559831d),
new NpgsqlTypes.NpgsqlLine(a: 0.9077241495933587d, b: 0.11677244978879076d, c: 0.5351580628873654d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30705462880892576d, b: 0.37504576363363873d, c: 0.7035793183878616d),
new NpgsqlTypes.NpgsqlLine(a: 0.1729076997523007d, b: 0.7538253138616373d, c: 0.2165633069212186d),
new NpgsqlTypes.NpgsqlLine(a: 0.26228220842623395d, b: 0.6667081413346044d, c: 0.21583916290128702d),
new NpgsqlTypes.NpgsqlLine(a: 0.45240548651348855d, b: 0.5160736468514726d, c: 0.4777058078365575d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6630938984706154d, b: 0.5347392387182137d, c: 0.7205486102600829d),
new NpgsqlTypes.NpgsqlLine(a: 0.6969424705106939d, b: 0.3227553235456382d, c: 0.6238039879764585d),
new NpgsqlTypes.NpgsqlLine(a: 0.5610832767565348d, b: 0.31239476032756586d, c: 0.9480180766621523d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1402478556505401d, b: 0.10656487865973907d, c: 0.5313828949611273d),
new NpgsqlTypes.NpgsqlLine(a: 0.2807455084357856d, b: 0.6465815705724504d, c: 0.08094273072140556d),
new NpgsqlTypes.NpgsqlLine(a: 0.5307344311569854d, b: 0.7357860936913665d, c: 0.1898411410174511d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5092752907884693d, b: 0.2212178028263947d, c: 0.004538043425062921d),
new NpgsqlTypes.NpgsqlLine(a: 0.7111311003522391d, b: 0.19833291228847405d, c: 0.31536002571934163d),
new NpgsqlTypes.NpgsqlLine(a: 0.35783280328283285d, b: 0.10980899494795116d, c: 0.045761685756004145d),
new NpgsqlTypes.NpgsqlLine(a: 0.30989436700022266d, b: 0.9051789807740395d, c: 0.4276612947375624d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10889163563445803d, b: 0.6106330730494551d, c: 0.2957499351019335d),
new NpgsqlTypes.NpgsqlLine(a: 0.5473625792432857d, b: 0.33227399602368335d, c: 0.6109976321120945d),
new NpgsqlTypes.NpgsqlLine(a: 0.45643401248584126d, b: 0.46058745045123284d, c: 0.2857028238730426d),
new NpgsqlTypes.NpgsqlLine(a: 0.7975335047565223d, b: 0.6610960805650639d, c: 0.6890798232080596d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10433492401987077d, b: 0.6008949185535497d, c: 0.8853178287856999d),
new NpgsqlTypes.NpgsqlLine(a: 0.5888526492577454d, b: 0.27915625605403627d, c: 0.9847388356893103d),
new NpgsqlTypes.NpgsqlLine(a: 0.9498279892585098d, b: 0.19474754303608854d, c: 0.4072071772782011d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.034596103451057014d, b: 0.8707998202877284d, c: 0.43920493586476517d),
new NpgsqlTypes.NpgsqlLine(a: 0.29440165636584203d, b: 0.943064502421777d, c: 0.25080900057143074d),
new NpgsqlTypes.NpgsqlLine(a: 0.2603351039213846d, b: 0.41340713472983315d, c: 0.9954152855218503d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534081478153136d, b: 0.7796529322685557d, c: 0.5736544063161643d),
new NpgsqlTypes.NpgsqlLine(a: 0.3505295024106203d, b: 0.6333980389433772d, c: 0.46541260298073217d),
new NpgsqlTypes.NpgsqlLine(a: 0.940939498753478d, b: 0.4696036894419283d, c: 0.8080817072803974d),
new NpgsqlTypes.NpgsqlLine(a: 0.8998805555829034d, b: 0.9251262836147189d, c: 0.9776859032312689d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6736722841981848d, b: 0.018535122251762792d, c: 0.5020678507164141d),
new NpgsqlTypes.NpgsqlLine(a: 0.8497505667604194d, b: 0.31661634971141583d, c: 0.19989181914795962d),
new NpgsqlTypes.NpgsqlLine(a: 0.2237282399065963d, b: 0.07322660193050012d, c: 0.25711067666187737d),
new NpgsqlTypes.NpgsqlLine(a: 0.4969142345827876d, b: 0.5868164212174047d, c: 0.08528571581580391d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7546095091384389d, b: 0.8769430295692856d, c: 0.6829401621772986d),
new NpgsqlTypes.NpgsqlLine(a: 0.1162858634814592d, b: 0.02986608362002008d, c: 0.44776629935359347d),
new NpgsqlTypes.NpgsqlLine(a: 0.9904957305981997d, b: 0.4740890597575974d, c: 0.47763723111434386d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1386930546085745d, b: 0.74592968476772d, c: 0.8333060489010756d),
new NpgsqlTypes.NpgsqlLine(a: 0.6641871923886858d, b: 0.46409623056141636d, c: 0.5481863344572524d),
new NpgsqlTypes.NpgsqlLine(a: 0.6392515643477158d, b: 0.490700735862196d, c: 0.8436826702733015d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7655989216540257d, b: 0.09237232543836116d, c: 0.5271293162550632d),
new NpgsqlTypes.NpgsqlLine(a: 0.4412726936372676d, b: 0.23669201526022943d, c: 0.11336060666657966d),
new NpgsqlTypes.NpgsqlLine(a: 0.6913018879185163d, b: 0.2897908706000768d, c: 0.3061319148871281d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.029890663910447812d, b: 0.8513151947560748d, c: 0.23710271311217923d),
new NpgsqlTypes.NpgsqlLine(a: 0.7641671876070952d, b: 0.5301904163808279d, c: 0.5205580090658645d),
new NpgsqlTypes.NpgsqlLine(a: 0.7701588118604726d, b: 0.5551213235149188d, c: 0.8721373423775515d),
new NpgsqlTypes.NpgsqlLine(a: 0.04853076972494863d, b: 0.9560419486269536d, c: 0.8465800652494679d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9196756024781527d, b: 0.06322562954601074d, c: 0.5977354726887879d),
new NpgsqlTypes.NpgsqlLine(a: 0.2811306069917616d, b: 0.526776697474167d, c: 0.9874487382932664d),
new NpgsqlTypes.NpgsqlLine(a: 0.43654495003728977d, b: 0.22001092018834656d, c: 0.19948126656909804d),
new NpgsqlTypes.NpgsqlLine(a: 0.15365867609021644d, b: 0.8896837201648696d, c: 0.442240986544324d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4884243027302644d, b: 0.6768393051568005d, c: 0.12178140486291045d),
new NpgsqlTypes.NpgsqlLine(a: 0.7059143948303775d, b: 0.03429075492901934d, c: 0.021461146854190538d),
new NpgsqlTypes.NpgsqlLine(a: 0.8459557791262474d, b: 0.5164229805703265d, c: 0.9308118116721245d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7309602232045962d, b: 0.803014872162105d, c: 0.06470052317762476d),
new NpgsqlTypes.NpgsqlLine(a: 0.43483782123872716d, b: 0.9220842446700006d, c: 0.3298191084866492d),
new NpgsqlTypes.NpgsqlLine(a: 0.30531761393902934d, b: 0.924716256837899d, c: 0.6384195554364958d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4849450717786554d, b: 0.22996630175269583d, c: 0.7870363959079477d),
new NpgsqlTypes.NpgsqlLine(a: 0.5617902155479367d, b: 0.7944144824731824d, c: 0.5886434131696748d),
new NpgsqlTypes.NpgsqlLine(a: 0.06171820150283969d, b: 0.8608404168709933d, c: 0.4973394417766046d),
new NpgsqlTypes.NpgsqlLine(a: 0.3144071198323056d, b: 0.4605644884826111d, c: 0.026676790261210503d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31078940473984373d, b: 0.8164966588743807d, c: 0.3217396952359939d),
new NpgsqlTypes.NpgsqlLine(a: 0.7462224068645942d, b: 0.23150326889840211d, c: 0.08533792329120071d),
new NpgsqlTypes.NpgsqlLine(a: 0.1103631517570226d, b: 0.6537591584516927d, c: 0.7113348077747151d),
new NpgsqlTypes.NpgsqlLine(a: 0.6578405416437191d, b: 0.30955921042125456d, c: 0.899517964773202d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.731597500602266d, b: 0.8362754267526841d, c: 0.17229135958936836d),
new NpgsqlTypes.NpgsqlLine(a: 0.101680365113613d, b: 0.2734830448967298d, c: 0.3008810288541174d),
new NpgsqlTypes.NpgsqlLine(a: 0.4618212619984823d, b: 0.2070234359995159d, c: 0.2550494144470913d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8531318507969359d, b: 0.5003239051080076d, c: 0.6507666996990005d),
new NpgsqlTypes.NpgsqlLine(a: 0.0391902303056233d, b: 0.9502910409266114d, c: 0.8142210242155855d),
new NpgsqlTypes.NpgsqlLine(a: 0.5895691827770847d, b: 0.24232395291060405d, c: 0.6387105872429315d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.37151538201672374d, b: 0.45204108111934127d, c: 0.20264984048774148d),
new NpgsqlTypes.NpgsqlLine(a: 0.3128330833457825d, b: 0.20953414956947125d, c: 0.9221758261183212d),
new NpgsqlTypes.NpgsqlLine(a: 0.7558386464267821d, b: 0.5475970586854153d, c: 0.12992832239289775d),
new NpgsqlTypes.NpgsqlLine(a: 0.9632498403126895d, b: 0.28983219560034257d, c: 0.7134240860686141d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7400799826773712d, b: 0.9384635138415138d, c: 0.21218849292377973d),
new NpgsqlTypes.NpgsqlLine(a: 0.7501515609647473d, b: 0.5018612518455358d, c: 0.840981623902257d),
new NpgsqlTypes.NpgsqlLine(a: 0.8033844513792872d, b: 0.09398057468183119d, c: 0.36815561212523473d),
new NpgsqlTypes.NpgsqlLine(a: 0.35413398745248503d, b: 0.013503208890198626d, c: 0.6515178856098729d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6122103927659004d, b: 0.9963883489721839d, c: 0.7461580892103999d),
new NpgsqlTypes.NpgsqlLine(a: 0.11853005913502457d, b: 0.07728062917463951d, c: 0.14559028263008145d),
new NpgsqlTypes.NpgsqlLine(a: 0.12165027727197064d, b: 0.7079713367153481d, c: 0.814978403592939d),
new NpgsqlTypes.NpgsqlLine(a: 0.7177290010741306d, b: 0.609062210489387d, c: 0.896967939922217d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8495634550259273d, b: 0.686294120942974d, c: 0.16806213822462934d),
new NpgsqlTypes.NpgsqlLine(a: 0.6782320449133257d, b: 0.6167654044152294d, c: 0.22481596295850304d),
new NpgsqlTypes.NpgsqlLine(a: 0.045346681633643304d, b: 0.34748776749412646d, c: 0.19198529418511845d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7944227870848437d, b: 0.04801067650052482d, c: 0.3329246301093868d),
new NpgsqlTypes.NpgsqlLine(a: 0.5518209722171544d, b: 0.9980942066844265d, c: 0.032040522090094004d),
new NpgsqlTypes.NpgsqlLine(a: 0.8003449478217475d, b: 0.02662588083118944d, c: 0.1825840737931892d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8729519823423673d, b: 0.28611632274217524d, c: 0.41302661067037305d),
new NpgsqlTypes.NpgsqlLine(a: 0.30556113588946643d, b: 0.4677205056210231d, c: 0.48233714845591935d),
new NpgsqlTypes.NpgsqlLine(a: 0.2375926846248949d, b: 0.9393797766429685d, c: 0.8133930066039341d),
new NpgsqlTypes.NpgsqlLine(a: 0.9948331620233344d, b: 0.41164786881840865d, c: 0.056652478727369004d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5395646889988319d, b: 0.25845457441271225d, c: 0.04172037379565896d),
new NpgsqlTypes.NpgsqlLine(a: 0.5400228961262804d, b: 0.25486855824594434d, c: 0.504301948429842d),
new NpgsqlTypes.NpgsqlLine(a: 0.4754963325269842d, b: 0.91243571341808d, c: 0.1987644686463672d),
new NpgsqlTypes.NpgsqlLine(a: 0.14210606824469507d, b: 0.6359020654449469d, c: 0.06659644581068958d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2212545310882481d, b: 0.04154244067293433d, c: 0.2503397119590064d),
new NpgsqlTypes.NpgsqlLine(a: 0.6669846695732812d, b: 0.6422301510590849d, c: 0.6302480951991981d),
new NpgsqlTypes.NpgsqlLine(a: 0.3867755264689935d, b: 0.02043652672616192d, c: 0.6583253260341633d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9492252756519982d, b: 0.6733052958063616d, c: 0.2002454147383541d),
new NpgsqlTypes.NpgsqlLine(a: 0.3532712713533458d, b: 0.3462908561072062d, c: 0.1022779360668904d),
new NpgsqlTypes.NpgsqlLine(a: 0.23904282823824152d, b: 0.9237611361206853d, c: 0.8509376256549451d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7145356823248799d, b: 0.4781128900243222d, c: 0.6100990941553297d),
new NpgsqlTypes.NpgsqlLine(a: 0.7948104376035678d, b: 0.0966607583158341d, c: 0.436675139018302d),
new NpgsqlTypes.NpgsqlLine(a: 0.05783431816537943d, b: 0.0007587824591993586d, c: 0.8867215378054222d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2526411208392846d, b: 0.4097178034505863d, c: 0.29384272687628843d),
new NpgsqlTypes.NpgsqlLine(a: 0.840180637272246d, b: 0.16981683868495967d, c: 0.5245599350940934d),
new NpgsqlTypes.NpgsqlLine(a: 0.6884157792166216d, b: 0.7256026803836485d, c: 0.712310876013999d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09393538453881078d, b: 0.5881996921846323d, c: 0.2831011796056855d),
new NpgsqlTypes.NpgsqlLine(a: 0.026857539513859274d, b: 0.15745646219511578d, c: 0.02823036245601751d),
new NpgsqlTypes.NpgsqlLine(a: 0.15879271700115039d, b: 0.22726599812859716d, c: 0.636643336038911d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7495063193520024d, b: 0.19644620785218703d, c: 0.33337084995074573d),
new NpgsqlTypes.NpgsqlLine(a: 0.47759023805807965d, b: 0.7911391901825513d, c: 0.028118762857709645d),
new NpgsqlTypes.NpgsqlLine(a: 0.4249877053226614d, b: 0.45428092618006854d, c: 0.6106514162595307d),
new NpgsqlTypes.NpgsqlLine(a: 0.16339628097671044d, b: 0.7776772363168689d, c: 0.866952835835128d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21214299597916364d, b: 0.4397248853652528d, c: 0.8671836721007637d),
new NpgsqlTypes.NpgsqlLine(a: 0.19678136724000095d, b: 0.7720102391738224d, c: 0.041592980471189867d),
new NpgsqlTypes.NpgsqlLine(a: 0.21317209839786533d, b: 0.833392329763224d, c: 0.45934490680466367d),
new NpgsqlTypes.NpgsqlLine(a: 0.9919989892287971d, b: 0.9454184900369074d, c: 0.7583455094848126d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.031044116610685735d, b: 0.5919597480579637d, c: 0.731619390381636d),
new NpgsqlTypes.NpgsqlLine(a: 0.35701249806343427d, b: 0.6571082477004078d, c: 0.7064498052668582d),
new NpgsqlTypes.NpgsqlLine(a: 0.8647522466171708d, b: 0.050795210995212225d, c: 0.09478399114890868d),
new NpgsqlTypes.NpgsqlLine(a: 0.240980998134384d, b: 0.9317242304676502d, c: 0.28630558679571205d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05745774089011779d, b: 0.5571744734690389d, c: 0.4844610180765486d),
new NpgsqlTypes.NpgsqlLine(a: 0.5529103710598601d, b: 0.9656582615353386d, c: 0.9579885719512591d),
new NpgsqlTypes.NpgsqlLine(a: 0.583687417016322d, b: 0.5299511916152002d, c: 0.5190986642754333d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7887685832049475d, b: 0.31273568404867513d, c: 0.9603674313978774d),
new NpgsqlTypes.NpgsqlLine(a: 0.018722288599092196d, b: 0.8397267673473747d, c: 0.5136847511263611d),
new NpgsqlTypes.NpgsqlLine(a: 0.1704575949243483d, b: 0.9790769395938798d, c: 0.003992288689427692d),
new NpgsqlTypes.NpgsqlLine(a: 0.19376696064096854d, b: 0.5632525937776272d, c: 0.5760224523912162d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07006140665454796d, b: 0.29239597582354027d, c: 0.7771844094638983d),
new NpgsqlTypes.NpgsqlLine(a: 0.9346204735028915d, b: 0.5554381292510383d, c: 0.7668130634476854d),
new NpgsqlTypes.NpgsqlLine(a: 0.7588370304459454d, b: 0.36340053208566636d, c: 0.8346352754312293d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24270353173121406d, b: 0.421412113924048d, c: 0.9004965457496079d),
new NpgsqlTypes.NpgsqlLine(a: 0.5770021793997433d, b: 0.16009586660196506d, c: 0.10408697726440175d),
new NpgsqlTypes.NpgsqlLine(a: 0.7326989298229963d, b: 0.5059885204946395d, c: 0.6188960411692924d),
new NpgsqlTypes.NpgsqlLine(a: 0.21062270952319861d, b: 0.6192984491985375d, c: 0.6916217803247071d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9855161745888842d, b: 0.2039782206967503d, c: 0.5796395890944382d),
new NpgsqlTypes.NpgsqlLine(a: 0.8809482430321547d, b: 0.9364528303614981d, c: 0.7437950570317249d),
new NpgsqlTypes.NpgsqlLine(a: 0.7032420991314068d, b: 0.7075758286019431d, c: 0.6323025758113338d),
new NpgsqlTypes.NpgsqlLine(a: 0.854801559427083d, b: 0.7339976260714187d, c: 0.9965594273468884d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4036326794840709d, b: 0.5021580174923753d, c: 0.9137200406862971d),
new NpgsqlTypes.NpgsqlLine(a: 0.6196671930999648d, b: 0.6756648227274892d, c: 0.12551702898610007d),
new NpgsqlTypes.NpgsqlLine(a: 0.18090682618043508d, b: 0.5291296689890274d, c: 0.01881427194716445d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5526148273514293d, b: 0.9642303215877323d, c: 0.6067547564210789d),
new NpgsqlTypes.NpgsqlLine(a: 0.33204661910525823d, b: 0.2778515519782768d, c: 0.7890608835708326d),
new NpgsqlTypes.NpgsqlLine(a: 0.5437639189638033d, b: 0.28946968274889107d, c: 0.9758658405232734d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4626420138409789d, b: 0.9142235169091458d, c: 0.897223983691261d),
new NpgsqlTypes.NpgsqlLine(a: 0.8564918334466485d, b: 0.7136185029536971d, c: 0.784352022135934d),
new NpgsqlTypes.NpgsqlLine(a: 0.7468963682954928d, b: 0.14963387736030964d, c: 0.19013368245515794d),
new NpgsqlTypes.NpgsqlLine(a: 0.566972482789001d, b: 0.3815486996926245d, c: 0.9572118036882554d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5001502557979771d, b: 0.10332416011703915d, c: 0.9908351884215078d),
new NpgsqlTypes.NpgsqlLine(a: 0.4657112845929561d, b: 0.14273631312742574d, c: 0.07558828333585721d),
new NpgsqlTypes.NpgsqlLine(a: 0.7057286258662071d, b: 0.7383768321208383d, c: 0.824388878280669d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8599419867944508d, b: 0.6044555450479007d, c: 0.32950068145304234d),
new NpgsqlTypes.NpgsqlLine(a: 0.6358459102205528d, b: 0.9850990323001304d, c: 0.39589716922746887d),
new NpgsqlTypes.NpgsqlLine(a: 0.815866503221599d, b: 0.1351344005553734d, c: 0.11891082123795238d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.47801204130761854d, b: 0.28350201329063185d, c: 0.44901648671726313d),
new NpgsqlTypes.NpgsqlLine(a: 0.7720386984204068d, b: 0.6609726434464547d, c: 0.8030288069027859d),
new NpgsqlTypes.NpgsqlLine(a: 0.7016892533143425d, b: 0.8121402303425989d, c: 0.9838312713505065d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6314869988266799d, b: 0.493252384771943d, c: 0.5770230451356286d),
new NpgsqlTypes.NpgsqlLine(a: 0.08245828792558918d, b: 0.9603416615063274d, c: 0.9462146514229369d),
new NpgsqlTypes.NpgsqlLine(a: 0.6854710217635189d, b: 0.3573149332630925d, c: 0.8165267732460182d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2521004263667559d, b: 0.13873307898247766d, c: 0.2668170340746516d),
new NpgsqlTypes.NpgsqlLine(a: 0.9803656139352499d, b: 0.7646014865325232d, c: 0.03562333590726785d),
new NpgsqlTypes.NpgsqlLine(a: 0.5652711460033834d, b: 0.8453978767808452d, c: 0.12079626209089633d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04073748517590514d, b: 0.5591121592217275d, c: 0.9141502954659504d),
new NpgsqlTypes.NpgsqlLine(a: 0.3633242497829141d, b: 0.5188683378383465d, c: 0.24772314844422438d),
new NpgsqlTypes.NpgsqlLine(a: 0.24036531296995212d, b: 0.8048409840559276d, c: 0.8896341627340404d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1463286188573153d, b: 0.3131260446515305d, c: 0.7610802069427457d),
new NpgsqlTypes.NpgsqlLine(a: 0.9922119693796316d, b: 0.37411903830229076d, c: 0.7895317801249649d),
new NpgsqlTypes.NpgsqlLine(a: 0.22731480098882706d, b: 0.8862605491744582d, c: 0.3335653231730705d),
new NpgsqlTypes.NpgsqlLine(a: 0.45285470382954107d, b: 0.7022500501940465d, c: 0.082360350178307d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9920279268683156d, b: 0.3928293814623165d, c: 0.589404220370597d),
new NpgsqlTypes.NpgsqlLine(a: 0.3027236481839106d, b: 0.7059054037668548d, c: 0.7560211141587557d),
new NpgsqlTypes.NpgsqlLine(a: 0.14646713673789646d, b: 0.01796608405310074d, c: 0.9123290268411496d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9285249418525764d, b: 0.06341268385227594d, c: 0.8152591918404752d),
new NpgsqlTypes.NpgsqlLine(a: 0.05034886572004316d, b: 0.16870549091483444d, c: 0.7017203251116801d),
new NpgsqlTypes.NpgsqlLine(a: 0.575111752857926d, b: 0.6670536863818717d, c: 0.3944861259325164d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23711661160910857d, b: 0.870805388635433d, c: 0.8269571775363883d),
new NpgsqlTypes.NpgsqlLine(a: 0.3930677736532582d, b: 0.917478776654745d, c: 0.018389460125469603d),
new NpgsqlTypes.NpgsqlLine(a: 0.7381336539570473d, b: 0.31663708628528175d, c: 0.7450145011290392d),
new NpgsqlTypes.NpgsqlLine(a: 0.7098733780499327d, b: 0.25110525237991244d, c: 0.9268359641692536d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4905313548285579d, b: 0.2168566318248717d, c: 0.919674649675578d),
new NpgsqlTypes.NpgsqlLine(a: 0.8739927754603607d, b: 0.7744886020212494d, c: 0.5324604392517867d),
new NpgsqlTypes.NpgsqlLine(a: 0.1400174069910708d, b: 0.2668509426924881d, c: 0.9270167201489196d),
new NpgsqlTypes.NpgsqlLine(a: 0.9720350317741903d, b: 0.8244526972152639d, c: 0.8280979817551062d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29624887884267626d, b: 0.6804779295919948d, c: 0.2037532689060556d),
new NpgsqlTypes.NpgsqlLine(a: 0.44784667410764445d, b: 0.39613892720627697d, c: 0.653325531303128d),
new NpgsqlTypes.NpgsqlLine(a: 0.7197469535175236d, b: 0.7235448971458804d, c: 0.11581681247416298d),
new NpgsqlTypes.NpgsqlLine(a: 0.6072644049834465d, b: 0.5086816057196134d, c: 0.46582705951626335d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15136784060994302d, b: 0.09498645219647506d, c: 0.6343334007271009d),
new NpgsqlTypes.NpgsqlLine(a: 0.37102236034824587d, b: 0.09514324693098397d, c: 0.23517966637486798d),
new NpgsqlTypes.NpgsqlLine(a: 0.9443397390435304d, b: 0.7311927685341504d, c: 0.8694201232689073d),
new NpgsqlTypes.NpgsqlLine(a: 0.4827148764576741d, b: 0.9236779886568453d, c: 0.8243220976515636d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18872023744779498d, b: 0.5437049289757585d, c: 0.2451387892593735d),
new NpgsqlTypes.NpgsqlLine(a: 0.5844155359210641d, b: 0.8495902660330209d, c: 0.23121529889993797d),
new NpgsqlTypes.NpgsqlLine(a: 0.7150420427587763d, b: 0.6874787100411299d, c: 0.006009128254455209d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4511158076013614d, b: 0.21140267762457698d, c: 0.32415559006184747d),
new NpgsqlTypes.NpgsqlLine(a: 0.8671531370307223d, b: 0.020857238821063384d, c: 0.2414600034335529d),
new NpgsqlTypes.NpgsqlLine(a: 0.7008998311789065d, b: 0.506673167747498d, c: 0.8678382048238339d),
new NpgsqlTypes.NpgsqlLine(a: 0.71795004301029d, b: 0.6062325587847442d, c: 0.5260135182394614d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7458535011277765d, b: 0.9257575734588577d, c: 0.4680179543388323d),
new NpgsqlTypes.NpgsqlLine(a: 0.5659875968187533d, b: 0.4161142075359284d, c: 0.71355426604106d),
new NpgsqlTypes.NpgsqlLine(a: 0.5270237806522944d, b: 0.05412321527172326d, c: 0.6624447899820318d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.47755488696794635d, b: 0.33500369572140076d, c: 0.7290812627444672d),
new NpgsqlTypes.NpgsqlLine(a: 0.5651623434971064d, b: 0.009651249121671368d, c: 0.8306571292815449d),
new NpgsqlTypes.NpgsqlLine(a: 0.993938716723378d, b: 0.6600144796852108d, c: 0.8999732474289781d),
new NpgsqlTypes.NpgsqlLine(a: 0.652249442504019d, b: 0.084362262977839d, c: 0.521853042836014d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9676490476114374d, b: 0.28553097571143393d, c: 0.015431632238970483d),
new NpgsqlTypes.NpgsqlLine(a: 0.8562289916505053d, b: 0.7939921540763271d, c: 0.9342008811568863d),
new NpgsqlTypes.NpgsqlLine(a: 0.7372386318298524d, b: 0.3892734828200666d, c: 0.5536614207324015d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6046633439988846d, b: 0.44900648152469413d, c: 0.07665903554636133d),
new NpgsqlTypes.NpgsqlLine(a: 0.857377038908874d, b: 0.6550179861624453d, c: 0.251197847611937d),
new NpgsqlTypes.NpgsqlLine(a: 0.32846432093361666d, b: 0.17649512420880764d, c: 0.3924066176120117d),
new NpgsqlTypes.NpgsqlLine(a: 0.27064170901243134d, b: 0.05641366618503407d, c: 0.38469619070191596d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9401337494178243d, b: 0.10481657989520043d, c: 0.4380064270870144d),
new NpgsqlTypes.NpgsqlLine(a: 0.06826997177416438d, b: 0.018436199547763765d, c: 0.9762515734794415d),
new NpgsqlTypes.NpgsqlLine(a: 0.09887334717784246d, b: 0.34728115603934984d, c: 0.23959869449667837d),
new NpgsqlTypes.NpgsqlLine(a: 0.5078543008851655d, b: 0.15525180852963616d, c: 0.681113485271953d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.671726134712812d, b: 0.6317131203688355d, c: 0.2749524934538442d),
new NpgsqlTypes.NpgsqlLine(a: 0.7881881654854589d, b: 0.1754248118945253d, c: 0.9014758828295104d),
new NpgsqlTypes.NpgsqlLine(a: 0.4756577545477463d, b: 0.7709683454239465d, c: 0.8370424940548736d),
new NpgsqlTypes.NpgsqlLine(a: 0.5145976287673936d, b: 0.20760294896382914d, c: 0.10146947820834384d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5175020672112818d, b: 0.7128474622179762d, c: 0.6353806921229623d),
new NpgsqlTypes.NpgsqlLine(a: 0.2815876507392142d, b: 0.9660288969891209d, c: 0.9078529101265868d),
new NpgsqlTypes.NpgsqlLine(a: 0.8350020045580354d, b: 0.9320353261373733d, c: 0.4269574278951225d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19566820331889934d, b: 0.8018593260645674d, c: 0.20362195136505168d),
new NpgsqlTypes.NpgsqlLine(a: 0.29747466718251625d, b: 0.5698409205617985d, c: 0.5797931735430103d),
new NpgsqlTypes.NpgsqlLine(a: 0.6747434597954636d, b: 0.7304658187131187d, c: 0.5735978832749663d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2897743032096606d, b: 0.3770463798145539d, c: 0.9268155736996169d),
new NpgsqlTypes.NpgsqlLine(a: 0.18472090045449785d, b: 0.3665915131455094d, c: 0.7442846879531901d),
new NpgsqlTypes.NpgsqlLine(a: 0.5601451014606036d, b: 0.15098987196428482d, c: 0.6372766267213066d),
new NpgsqlTypes.NpgsqlLine(a: 0.23148533359699364d, b: 0.6609955902729688d, c: 0.7730456316616026d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9876208653387099d, b: 0.5155827040519357d, c: 0.9568066697327904d),
new NpgsqlTypes.NpgsqlLine(a: 0.7911104718182027d, b: 0.959624481138839d, c: 0.8204983738887753d),
new NpgsqlTypes.NpgsqlLine(a: 0.6055637138409181d, b: 0.067359626296433d, c: 0.8238668395802169d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8138970211601131d, b: 0.7631318095800859d, c: 0.4440819646874469d),
new NpgsqlTypes.NpgsqlLine(a: 0.17171183597548922d, b: 0.6968423171977408d, c: 0.9101409511193681d),
new NpgsqlTypes.NpgsqlLine(a: 0.24025063130117663d, b: 0.8071382630588055d, c: 0.2626926200141977d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 202,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9107495489490641d, b: 0.45962675000439734d, c: 0.2611069062840782d),
new NpgsqlTypes.NpgsqlLine(a: 0.6780021019792636d, b: 0.001139603345771123d, c: 0.8092614981737506d),
new NpgsqlTypes.NpgsqlLine(a: 0.9360396803468262d, b: 0.508107784413004d, c: 0.7174056492770031d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 203,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7786523796474744d, b: 0.9818422387051545d, c: 0.23473828811467934d),
new NpgsqlTypes.NpgsqlLine(a: 0.18056037958351612d, b: 0.5294654397017686d, c: 0.3503827373810501d),
new NpgsqlTypes.NpgsqlLine(a: 0.5552859553390727d, b: 0.036007044391008214d, c: 0.6092011110769688d),
new NpgsqlTypes.NpgsqlLine(a: 0.12259471535154154d, b: 0.12883976242586115d, c: 0.43700997249687923d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29755998228048586d, b: 0.2731739147823965d, c: 0.9671120725904512d),
new NpgsqlTypes.NpgsqlLine(a: 0.9480835198157961d, b: 0.788418158929055d, c: 0.4664308977674838d),
new NpgsqlTypes.NpgsqlLine(a: 0.04438714574222291d, b: 0.1783588353912604d, c: 0.03780483938944246d),
new NpgsqlTypes.NpgsqlLine(a: 0.04215173072993694d, b: 0.5680091183714518d, c: 0.4847762764800002d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20584947105376628d, b: 0.7315589487550922d, c: 0.011043202155660237d),
new NpgsqlTypes.NpgsqlLine(a: 0.5897473438674979d, b: 0.9126941015601882d, c: 0.10920822141443409d),
new NpgsqlTypes.NpgsqlLine(a: 0.588128584752436d, b: 0.8442284789653827d, c: 0.00834625469969541d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8836847464613089d, b: 0.9934412632579183d, c: 0.7691577557455055d),
new NpgsqlTypes.NpgsqlLine(a: 0.14101187904810297d, b: 0.8228778920481867d, c: 0.22645274434371898d),
new NpgsqlTypes.NpgsqlLine(a: 0.7325493660469076d, b: 0.39490351020364933d, c: 0.6395067013896326d),
new NpgsqlTypes.NpgsqlLine(a: 0.17586012450373534d, b: 0.9204335408170233d, c: 0.9864743327352445d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 208,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9803909038630245d, b: 0.13493138533663518d, c: 0.9515222532942306d),
new NpgsqlTypes.NpgsqlLine(a: 0.5158784426729365d, b: 0.1756869564732072d, c: 0.4875471943179358d),
new NpgsqlTypes.NpgsqlLine(a: 0.8083512616185999d, b: 0.3759816193862331d, c: 0.8398943805009997d),
new NpgsqlTypes.NpgsqlLine(a: 0.11488695851384745d, b: 0.7535195913177737d, c: 0.3528420960771729d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.44382853018739565d, b: 0.8498391853523081d, c: 0.2817343444383834d),
new NpgsqlTypes.NpgsqlLine(a: 0.7899679187880115d, b: 0.4628944321872033d, c: 0.8091756990300958d),
new NpgsqlTypes.NpgsqlLine(a: 0.3446912823631554d, b: 0.829080171527155d, c: 0.07016015861444203d),
new NpgsqlTypes.NpgsqlLine(a: 0.09351846961842691d, b: 0.9165312461765275d, c: 0.38679452651569857d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1402478556505401d, b: 0.10656487865973907d, c: 0.5313828949611273d),
new NpgsqlTypes.NpgsqlLine(a: 0.2807455084357856d, b: 0.6465815705724504d, c: 0.08094273072140556d),
new NpgsqlTypes.NpgsqlLine(a: 0.5307344311569854d, b: 0.7357860936913665d, c: 0.1898411410174511d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10889163563445803d, b: 0.6106330730494551d, c: 0.2957499351019335d),
new NpgsqlTypes.NpgsqlLine(a: 0.5473625792432857d, b: 0.33227399602368335d, c: 0.6109976321120945d),
new NpgsqlTypes.NpgsqlLine(a: 0.45643401248584126d, b: 0.46058745045123284d, c: 0.2857028238730426d),
new NpgsqlTypes.NpgsqlLine(a: 0.7975335047565223d, b: 0.6610960805650639d, c: 0.6890798232080596d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6736722841981848d, b: 0.018535122251762792d, c: 0.5020678507164141d),
new NpgsqlTypes.NpgsqlLine(a: 0.8497505667604194d, b: 0.31661634971141583d, c: 0.19989181914795962d),
new NpgsqlTypes.NpgsqlLine(a: 0.2237282399065963d, b: 0.07322660193050012d, c: 0.25711067666187737d),
new NpgsqlTypes.NpgsqlLine(a: 0.4969142345827876d, b: 0.5868164212174047d, c: 0.08528571581580391d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7309602232045962d, b: 0.803014872162105d, c: 0.06470052317762476d),
new NpgsqlTypes.NpgsqlLine(a: 0.43483782123872716d, b: 0.9220842446700006d, c: 0.3298191084866492d),
new NpgsqlTypes.NpgsqlLine(a: 0.30531761393902934d, b: 0.924716256837899d, c: 0.6384195554364958d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 202;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 193;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 83, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 145, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 177, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 90, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 142, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 15, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[30], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI), typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                await ((INpgsqlLineArraylineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                ((INpgsqlLineArraylineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineArraylineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

