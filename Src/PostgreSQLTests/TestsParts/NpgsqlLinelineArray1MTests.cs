

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
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9894341721789586d, b: 0.8165305622646912d, c: 0.4592652432043034d),
new NpgsqlTypes.NpgsqlLine(a: 0.35932061084229794d, b: 0.08973620495603507d, c: 0.3499477273446411d),
new NpgsqlTypes.NpgsqlLine(a: 0.299032217205078d, b: 0.6053382757645244d, c: 0.44744816657200814d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6924488189944428d, b: 0.346250940878449d, c: 0.45778894603385445d),
new NpgsqlTypes.NpgsqlLine(a: 0.883019840314497d, b: 0.007795074341712782d, c: 0.9662885274480235d),
new NpgsqlTypes.NpgsqlLine(a: 0.5091689378057008d, b: 0.6018918469175143d, c: 0.44530117148310666d),
new NpgsqlTypes.NpgsqlLine(a: 0.3155466581470785d, b: 0.1971781353059956d, c: 0.19815223618001865d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7225953244059955d, b: 0.05510707106686863d, c: 0.5779738534518964d),
new NpgsqlTypes.NpgsqlLine(a: 0.14915680906068807d, b: 0.1236282565305058d, c: 0.7616803752733357d),
new NpgsqlTypes.NpgsqlLine(a: 0.6013935936163548d, b: 0.27560476714827387d, c: 0.5609475183561742d),
new NpgsqlTypes.NpgsqlLine(a: 0.5659966280056491d, b: 0.19299684751660195d, c: 0.3930697093443978d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6266272825461205d, b: 0.37411685531337857d, c: 0.017847944030568108d),
new NpgsqlTypes.NpgsqlLine(a: 0.8387222245164362d, b: 0.75304657554247d, c: 0.6683565500233376d),
new NpgsqlTypes.NpgsqlLine(a: 0.32377754981613316d, b: 0.9150574894704986d, c: 0.8644405839444322d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.691436208954252d, b: 0.37097285773080624d, c: 0.26563360798534874d),
new NpgsqlTypes.NpgsqlLine(a: 0.6325322836576839d, b: 0.7279565753295311d, c: 0.8348312564840081d),
new NpgsqlTypes.NpgsqlLine(a: 0.273249865499104d, b: 0.3405097351190046d, c: 0.5440579653304501d),
new NpgsqlTypes.NpgsqlLine(a: 0.9848233414077058d, b: 0.4634434858531833d, c: 0.5843644058073045d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6675144182357621d, b: 0.14293341759792988d, c: 0.5344372345239142d),
new NpgsqlTypes.NpgsqlLine(a: 0.0813923882779356d, b: 0.9433563327953527d, c: 0.42169832950281805d),
new NpgsqlTypes.NpgsqlLine(a: 0.7368054120787896d, b: 0.09398603246130632d, c: 0.30951765512761586d),
new NpgsqlTypes.NpgsqlLine(a: 0.9191226311276551d, b: 0.40254320939121013d, c: 0.9722137369583225d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9377277094326704d, b: 0.3202718996808821d, c: 0.955445209264998d),
new NpgsqlTypes.NpgsqlLine(a: 0.4697090650967719d, b: 0.26172661866852986d, c: 0.09948908007229018d),
new NpgsqlTypes.NpgsqlLine(a: 0.15604803537090117d, b: 0.9802129972994759d, c: 0.45330577636204084d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6115855417245736d, b: 0.4668875660183254d, c: 0.2539480554126101d),
new NpgsqlTypes.NpgsqlLine(a: 0.6125009350112199d, b: 0.3435652136090869d, c: 0.781486893748558d),
new NpgsqlTypes.NpgsqlLine(a: 0.10945795962449756d, b: 0.742508584817406d, c: 0.479336381785853d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5978037441804087d, b: 0.5312183183362824d, c: 0.00459727095198148d),
new NpgsqlTypes.NpgsqlLine(a: 0.35561110784845507d, b: 0.3380008923403356d, c: 0.6328800893084401d),
new NpgsqlTypes.NpgsqlLine(a: 0.38804843688576196d, b: 0.018320058751583157d, c: 0.9425748678742607d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9025846450886227d, b: 0.7651565996583846d, c: 0.6904575379253616d),
new NpgsqlTypes.NpgsqlLine(a: 0.6783998915773601d, b: 0.3780611428492714d, c: 0.3995386786929275d),
new NpgsqlTypes.NpgsqlLine(a: 0.14297221646062475d, b: 0.7598046499527062d, c: 0.7113860256809165d),
new NpgsqlTypes.NpgsqlLine(a: 0.9886344093569713d, b: 0.7324221533010141d, c: 0.6345114323630302d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7780790767037619d, b: 0.24206026516040557d, c: 0.9722020370468776d),
new NpgsqlTypes.NpgsqlLine(a: 0.6774555971795662d, b: 0.09783803205541186d, c: 0.984843827873424d),
new NpgsqlTypes.NpgsqlLine(a: 0.46692896340916057d, b: 0.6431647227724155d, c: 0.43539766500253374d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26557274659554686d, b: 0.48519517610716756d, c: 0.7701834324027502d),
new NpgsqlTypes.NpgsqlLine(a: 0.9587040529604467d, b: 0.09316753562095659d, c: 0.09955474629763672d),
new NpgsqlTypes.NpgsqlLine(a: 0.398904212855419d, b: 0.9486560999374795d, c: 0.22918627084520649d),
new NpgsqlTypes.NpgsqlLine(a: 0.6724197688635402d, b: 0.7629750047497886d, c: 0.029579917898375885d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14997808134841017d, b: 0.8818718896242463d, c: 0.9910804553550171d),
new NpgsqlTypes.NpgsqlLine(a: 0.680031791083934d, b: 0.5603216385865358d, c: 0.03838318410584041d),
new NpgsqlTypes.NpgsqlLine(a: 0.5841680564114946d, b: 0.2663160522678608d, c: 0.05779831307634231d),
new NpgsqlTypes.NpgsqlLine(a: 0.5350558704648513d, b: 0.003810984073199908d, c: 0.1275495447731697d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9432282675569624d, b: 0.6002153470749739d, c: 0.02596693060154065d),
new NpgsqlTypes.NpgsqlLine(a: 0.11532282419431172d, b: 0.26970413758295486d, c: 0.7770262842948444d),
new NpgsqlTypes.NpgsqlLine(a: 0.23549401732263764d, b: 0.9787460057993962d, c: 0.7495521871375289d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28304081128069336d, b: 0.7571166125169627d, c: 0.7982960200904307d),
new NpgsqlTypes.NpgsqlLine(a: 0.9128158197341449d, b: 0.11844612915853714d, c: 0.7928736963825657d),
new NpgsqlTypes.NpgsqlLine(a: 0.363915742152791d, b: 0.5440512076557094d, c: 0.36994429818608565d),
new NpgsqlTypes.NpgsqlLine(a: 0.9798704576072748d, b: 0.10141650853872619d, c: 0.09758923629678284d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8332223316600411d, b: 0.18317391524116666d, c: 0.5129779020095732d),
new NpgsqlTypes.NpgsqlLine(a: 0.9676310314948874d, b: 0.4049495570956151d, c: 0.8244726496232989d),
new NpgsqlTypes.NpgsqlLine(a: 0.4102429287654439d, b: 0.7500102716510183d, c: 0.6629709358970096d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18527612860375553d, b: 0.9060329144452006d, c: 0.5661552601636628d),
new NpgsqlTypes.NpgsqlLine(a: 0.0689312762812071d, b: 0.1565011790860228d, c: 0.9907631766326626d),
new NpgsqlTypes.NpgsqlLine(a: 0.868363913939676d, b: 0.37994886114653337d, c: 0.47749078173270676d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9254573992880833d, b: 0.7329950162191586d, c: 0.10491692910575601d),
new NpgsqlTypes.NpgsqlLine(a: 0.024196255820043033d, b: 0.607131626625144d, c: 0.3945233000274997d),
new NpgsqlTypes.NpgsqlLine(a: 0.2178285940369702d, b: 0.45862021655218377d, c: 0.7056969305971805d),
new NpgsqlTypes.NpgsqlLine(a: 0.7685235366131448d, b: 0.34684097277668424d, c: 0.08795325259956832d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6548601725542699d, b: 0.029012949991917947d, c: 0.41096970370462504d),
new NpgsqlTypes.NpgsqlLine(a: 0.21973988349692497d, b: 0.988657399166812d, c: 0.3637149464223264d),
new NpgsqlTypes.NpgsqlLine(a: 0.12076479610481194d, b: 0.1408390686218549d, c: 0.19903146357617163d),
new NpgsqlTypes.NpgsqlLine(a: 0.2758316843896651d, b: 0.20125742053111217d, c: 0.8498658567337644d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09700657806791235d, b: 0.36236509356176705d, c: 0.6684805473497292d),
new NpgsqlTypes.NpgsqlLine(a: 0.12430520813083745d, b: 0.3500357922734456d, c: 0.08139043117333156d),
new NpgsqlTypes.NpgsqlLine(a: 0.4850346265104193d, b: 0.7674217525077774d, c: 0.3021880542937436d),
new NpgsqlTypes.NpgsqlLine(a: 0.7348205909206466d, b: 0.4047528935172461d, c: 0.9305304171351363d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4279292767857511d, b: 0.7049175690913707d, c: 0.9661387290505153d),
new NpgsqlTypes.NpgsqlLine(a: 0.8968508514634267d, b: 0.3048422462186905d, c: 0.9737740363921263d),
new NpgsqlTypes.NpgsqlLine(a: 0.5737142358504193d, b: 0.687277608211987d, c: 0.0970222332783548d),
new NpgsqlTypes.NpgsqlLine(a: 0.23563142488208133d, b: 0.4013062391375596d, c: 0.14907185800199274d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7383717215465051d, b: 0.4395662950289225d, c: 0.4287779802535526d),
new NpgsqlTypes.NpgsqlLine(a: 0.04290640289754932d, b: 0.7047321151231096d, c: 0.41444273075832416d),
new NpgsqlTypes.NpgsqlLine(a: 0.9561877366232513d, b: 0.1197060045313435d, c: 0.8832503158661802d),
new NpgsqlTypes.NpgsqlLine(a: 0.6273792315197216d, b: 0.5645808576702142d, c: 0.09036561606138183d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9767119652047345d, b: 0.2480131369340065d, c: 0.8320428292992357d),
new NpgsqlTypes.NpgsqlLine(a: 0.914875505983561d, b: 0.7579550796188522d, c: 0.6381668204783371d),
new NpgsqlTypes.NpgsqlLine(a: 0.6686634670363006d, b: 0.12800087965611728d, c: 0.8223296412858319d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29240244141163574d, b: 0.483733848636109d, c: 0.22653447500211987d),
new NpgsqlTypes.NpgsqlLine(a: 0.1916120758483537d, b: 0.9978138762905012d, c: 0.61328180945752d),
new NpgsqlTypes.NpgsqlLine(a: 0.32159569756308315d, b: 0.6255163801411113d, c: 0.3671823814078946d),
new NpgsqlTypes.NpgsqlLine(a: 0.4783713924305596d, b: 0.4922327994729425d, c: 0.18833743945712966d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1898921844101925d, b: 0.749603725737316d, c: 0.8907431881279126d),
new NpgsqlTypes.NpgsqlLine(a: 0.4621963513973881d, b: 0.7667698022517506d, c: 0.06065249575097087d),
new NpgsqlTypes.NpgsqlLine(a: 0.8738763597099789d, b: 0.45762946113954217d, c: 0.7124960968013191d),
new NpgsqlTypes.NpgsqlLine(a: 0.9314251031449918d, b: 0.8546628429718862d, c: 0.15179707262271436d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2520519133162227d, b: 0.6082738114513603d, c: 0.603989134260579d),
new NpgsqlTypes.NpgsqlLine(a: 0.21322032889544218d, b: 0.6701144827599443d, c: 0.31730375541221d),
new NpgsqlTypes.NpgsqlLine(a: 0.05716461701811948d, b: 0.6677367269203568d, c: 0.19311068822088084d),
new NpgsqlTypes.NpgsqlLine(a: 0.4427627258731963d, b: 0.04793342318975047d, c: 0.15678049023089313d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6886456142557262d, b: 0.7601641272016323d, c: 0.025118324542241388d),
new NpgsqlTypes.NpgsqlLine(a: 0.8083472792815656d, b: 0.8076443089961374d, c: 0.28807884185465793d),
new NpgsqlTypes.NpgsqlLine(a: 0.38368908625178066d, b: 0.09730483562638115d, c: 0.006656135614050984d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30570511792198785d, b: 0.497186115821759d, c: 0.5626102681878888d),
new NpgsqlTypes.NpgsqlLine(a: 0.4532672151196764d, b: 0.3444109470862543d, c: 0.9557533996125095d),
new NpgsqlTypes.NpgsqlLine(a: 0.770694360896954d, b: 0.06729895722575352d, c: 0.5010050542872653d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08249645191189625d, b: 0.998308173830233d, c: 0.5540692153859161d),
new NpgsqlTypes.NpgsqlLine(a: 0.7186175666275979d, b: 0.5221634521412888d, c: 0.6394678502853837d),
new NpgsqlTypes.NpgsqlLine(a: 0.5968424712567284d, b: 0.8006645980608349d, c: 0.49526013553863624d),
new NpgsqlTypes.NpgsqlLine(a: 0.6166771555989286d, b: 0.5561530479681502d, c: 0.5684524430663924d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9948041522193972d, b: 0.8695291807077549d, c: 0.3588471169771944d),
new NpgsqlTypes.NpgsqlLine(a: 0.22310529368963206d, b: 0.06325820890550282d, c: 0.926421589678131d),
new NpgsqlTypes.NpgsqlLine(a: 0.8360665847353719d, b: 0.8610823674251776d, c: 0.9158872473020082d),
new NpgsqlTypes.NpgsqlLine(a: 0.1932837786435595d, b: 0.555865214166013d, c: 0.4136324079364736d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3403869413845456d, b: 0.06756209730923624d, c: 0.40037699275752536d),
new NpgsqlTypes.NpgsqlLine(a: 0.44263040433909007d, b: 0.317112211315535d, c: 0.8757721132267836d),
new NpgsqlTypes.NpgsqlLine(a: 0.32739354439879864d, b: 0.6702433285640731d, c: 0.7419589646123586d),
new NpgsqlTypes.NpgsqlLine(a: 0.6186698001253308d, b: 0.25085551340203327d, c: 0.02912317229064032d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12153819546837885d, b: 0.0061776545307379305d, c: 0.8587407688331979d),
new NpgsqlTypes.NpgsqlLine(a: 0.7268518949859468d, b: 0.12114691156867552d, c: 0.845696193365685d),
new NpgsqlTypes.NpgsqlLine(a: 0.5265437278516236d, b: 0.33583801650295453d, c: 0.31297122626515705d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5377345816627441d, b: 0.16377324040967245d, c: 0.682384799794913d),
new NpgsqlTypes.NpgsqlLine(a: 0.27654833599013107d, b: 0.02464248379363876d, c: 0.4723373084820781d),
new NpgsqlTypes.NpgsqlLine(a: 0.9906318026520768d, b: 0.49085244245812565d, c: 0.960992759679261d),
new NpgsqlTypes.NpgsqlLine(a: 0.13457811413427145d, b: 0.8595659579301043d, c: 0.1907265168414526d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7997331961637204d, b: 0.8988955618917617d, c: 0.683842998193868d),
new NpgsqlTypes.NpgsqlLine(a: 0.5254300215424494d, b: 0.9013155205037368d, c: 0.9428601540238778d),
new NpgsqlTypes.NpgsqlLine(a: 0.6243795295300952d, b: 0.7332588767818349d, c: 0.4171450948122767d),
new NpgsqlTypes.NpgsqlLine(a: 0.14465795905820966d, b: 0.6555057865051765d, c: 0.16878377589157456d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8673241000084687d, b: 0.2622754981180043d, c: 0.7128845986491685d),
new NpgsqlTypes.NpgsqlLine(a: 0.8345081149048021d, b: 0.9230035132227181d, c: 0.15558365451022116d),
new NpgsqlTypes.NpgsqlLine(a: 0.6294555473668616d, b: 0.1912207937448417d, c: 0.9396813056078286d),
new NpgsqlTypes.NpgsqlLine(a: 0.5953476057256454d, b: 0.9689682652359074d, c: 0.10904003280990993d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3966555418441641d, b: 0.5736928682077633d, c: 0.5304944545044716d),
new NpgsqlTypes.NpgsqlLine(a: 0.725623996677866d, b: 0.09033124057707198d, c: 0.788959264262979d),
new NpgsqlTypes.NpgsqlLine(a: 0.988461965752405d, b: 0.3126200718317883d, c: 0.0726935444345932d),
new NpgsqlTypes.NpgsqlLine(a: 0.44603065233150485d, b: 0.7925993518416156d, c: 0.2537144006580785d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27563111602357926d, b: 0.46956183151073905d, c: 0.4445201871216795d),
new NpgsqlTypes.NpgsqlLine(a: 0.3533211645879182d, b: 0.09945821445976077d, c: 0.5837692246452054d),
new NpgsqlTypes.NpgsqlLine(a: 0.6338189801766246d, b: 0.8699510826464218d, c: 0.7686451799511521d),
new NpgsqlTypes.NpgsqlLine(a: 0.5035364314321363d, b: 0.647216468810804d, c: 0.8441767208743011d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8410073189061099d, b: 0.7384923657266859d, c: 0.11950591287382994d),
new NpgsqlTypes.NpgsqlLine(a: 0.3231448792993168d, b: 0.7054098444465384d, c: 0.1507201142323451d),
new NpgsqlTypes.NpgsqlLine(a: 0.9058920969708455d, b: 0.8264453695272789d, c: 0.28211450833879526d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9341357223745826d, b: 0.17392958578486928d, c: 0.8614308178324263d),
new NpgsqlTypes.NpgsqlLine(a: 0.8551845061952562d, b: 0.14383881491122041d, c: 0.3032441295274121d),
new NpgsqlTypes.NpgsqlLine(a: 0.33952789782202875d, b: 0.8451204838709039d, c: 0.26765735621714426d),
new NpgsqlTypes.NpgsqlLine(a: 0.611990823286192d, b: 0.22990618316256795d, c: 0.6687736364981924d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8575165405518409d, b: 0.8448343900732135d, c: 0.5942262930944509d),
new NpgsqlTypes.NpgsqlLine(a: 0.7003364685460737d, b: 0.5007765436526594d, c: 0.5616316220620946d),
new NpgsqlTypes.NpgsqlLine(a: 0.7103535353466232d, b: 0.9213880960401593d, c: 0.24956101776995632d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8991280322882595d, b: 0.4651948402993198d, c: 0.7197685969210892d),
new NpgsqlTypes.NpgsqlLine(a: 0.8854155246674515d, b: 0.4780387525008505d, c: 0.4506756442903619d),
new NpgsqlTypes.NpgsqlLine(a: 0.9358937620030928d, b: 0.49457499277924843d, c: 0.5531562430855181d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24482065478514725d, b: 0.8206117604073562d, c: 0.9610285561087082d),
new NpgsqlTypes.NpgsqlLine(a: 0.9992663883133017d, b: 0.4057046943535355d, c: 0.05239211035566815d),
new NpgsqlTypes.NpgsqlLine(a: 0.022096582363554607d, b: 0.13214197408324746d, c: 0.6999668498328796d),
new NpgsqlTypes.NpgsqlLine(a: 0.35931009757126575d, b: 0.0375458677016266d, c: 0.5057999946050056d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6440110542383941d, b: 0.17598227631817875d, c: 0.1341452600354861d),
new NpgsqlTypes.NpgsqlLine(a: 0.19448245775791895d, b: 0.12848881860809924d, c: 0.5849701560193873d),
new NpgsqlTypes.NpgsqlLine(a: 0.9760576618553448d, b: 0.8460605886043336d, c: 0.18722308212485206d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5279321923404774d, b: 0.8105953693190094d, c: 0.5566495531114785d),
new NpgsqlTypes.NpgsqlLine(a: 0.8512984716334165d, b: 0.6938775578592911d, c: 0.27750004445844123d),
new NpgsqlTypes.NpgsqlLine(a: 0.49541885326052926d, b: 0.31787435332146685d, c: 0.934502877113355d),
new NpgsqlTypes.NpgsqlLine(a: 0.7961174126693479d, b: 0.41880335224145004d, c: 0.1347697991187432d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48568356008412195d, b: 0.4518529540564953d, c: 0.7309769763959534d),
new NpgsqlTypes.NpgsqlLine(a: 0.6649657260255633d, b: 0.383234498500134d, c: 0.46182140756308687d),
new NpgsqlTypes.NpgsqlLine(a: 0.6021152063736777d, b: 0.426152406589005d, c: 0.152058620475631d),
new NpgsqlTypes.NpgsqlLine(a: 0.7979204474527926d, b: 0.42249632249787394d, c: 0.9140256344176301d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5150652522831719d, b: 0.02981886275861323d, c: 0.0956981097639823d),
new NpgsqlTypes.NpgsqlLine(a: 0.16318529230194112d, b: 0.7877189044597445d, c: 0.07340322904307428d),
new NpgsqlTypes.NpgsqlLine(a: 0.765082740605098d, b: 0.41257908228406037d, c: 0.32143297444091157d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2539822637109842d, b: 0.41315140212452817d, c: 0.7891900414032692d),
new NpgsqlTypes.NpgsqlLine(a: 0.695208255217699d, b: 0.6075397415786948d, c: 0.0254551461074477d),
new NpgsqlTypes.NpgsqlLine(a: 0.9657685737993577d, b: 0.31580100749406825d, c: 0.30916133252253286d),
new NpgsqlTypes.NpgsqlLine(a: 0.6131171574903392d, b: 0.05967666213781775d, c: 0.9201428041383102d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8591994433442032d, b: 0.1949051237811803d, c: 0.16509923740504007d),
new NpgsqlTypes.NpgsqlLine(a: 0.0867588365644173d, b: 0.4371496342281158d, c: 0.7303199973120921d),
new NpgsqlTypes.NpgsqlLine(a: 0.33522955375672603d, b: 0.2725093659139439d, c: 0.9404029536163765d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9354412280238243d, b: 0.6720385511073793d, c: 0.055232881220722674d),
new NpgsqlTypes.NpgsqlLine(a: 0.0013347280909977721d, b: 0.13391787140745082d, c: 0.6646739636836714d),
new NpgsqlTypes.NpgsqlLine(a: 0.256961357259607d, b: 0.776113853088778d, c: 0.16114936104118516d),
new NpgsqlTypes.NpgsqlLine(a: 0.13864208235025832d, b: 0.5888336926827334d, c: 0.8789558655423929d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42671452141317623d, b: 0.7834495892039369d, c: 0.5938469028987096d),
new NpgsqlTypes.NpgsqlLine(a: 0.7305228150634788d, b: 0.40388320564116775d, c: 0.8503942676705003d),
new NpgsqlTypes.NpgsqlLine(a: 0.6350031977702842d, b: 0.04741671629072308d, c: 0.13346003000257278d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15143853306180322d, b: 0.3722597935669315d, c: 0.1812005223600318d),
new NpgsqlTypes.NpgsqlLine(a: 0.161999668205983d, b: 0.5472677432028852d, c: 0.16677800999475123d),
new NpgsqlTypes.NpgsqlLine(a: 0.674952595637685d, b: 0.5792086728080599d, c: 0.11773371657562548d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.74972770989309d, b: 0.4999655814361359d, c: 0.528287473297171d),
new NpgsqlTypes.NpgsqlLine(a: 0.6098242581365463d, b: 0.3409889754881029d, c: 0.8306688661259014d),
new NpgsqlTypes.NpgsqlLine(a: 0.1471538937803678d, b: 0.9662888512526093d, c: 0.624177421955627d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5999329589207731d, b: 0.9217582115542937d, c: 0.12072776021567266d),
new NpgsqlTypes.NpgsqlLine(a: 0.09117260423866469d, b: 0.7872167361013283d, c: 0.8879744722209045d),
new NpgsqlTypes.NpgsqlLine(a: 0.42583487237842865d, b: 0.02484472123588244d, c: 0.69091066421647d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26700736337882947d, b: 0.729273150086179d, c: 0.9967711609820952d),
new NpgsqlTypes.NpgsqlLine(a: 0.43218533851300156d, b: 0.759048183985377d, c: 0.09880643033886871d),
new NpgsqlTypes.NpgsqlLine(a: 0.7210785370923745d, b: 0.8918679178165266d, c: 0.14696181701671496d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8324233067431561d, b: 0.7312060203331772d, c: 0.4773334026403272d),
new NpgsqlTypes.NpgsqlLine(a: 0.012712282414568454d, b: 0.22578984850848682d, c: 0.6794140515271107d),
new NpgsqlTypes.NpgsqlLine(a: 0.2732070218051953d, b: 0.9767794072019516d, c: 0.37840483548547343d),
new NpgsqlTypes.NpgsqlLine(a: 0.29416683838386315d, b: 0.9939472505385787d, c: 0.857039217794446d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05007627536041748d, b: 0.8202828734074799d, c: 0.18673129711514935d),
new NpgsqlTypes.NpgsqlLine(a: 0.5913836034836757d, b: 0.6336051007316857d, c: 0.010300038994145111d),
new NpgsqlTypes.NpgsqlLine(a: 0.7156929651850583d, b: 0.6990583231718219d, c: 0.375650712691982d),
new NpgsqlTypes.NpgsqlLine(a: 0.9128540520676169d, b: 0.66290917349053d, c: 0.3079884182843319d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4011993085306744d, b: 0.985081110215463d, c: 0.9039719767800426d),
new NpgsqlTypes.NpgsqlLine(a: 0.7000505627514229d, b: 0.28299605754620427d, c: 0.6693232319706366d),
new NpgsqlTypes.NpgsqlLine(a: 0.7532098630657289d, b: 0.9576197384971236d, c: 0.85591338103576d),
new NpgsqlTypes.NpgsqlLine(a: 0.7897064983455431d, b: 0.228022166909449d, c: 0.4148923231640349d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8935198071578034d, b: 0.8578709855162585d, c: 0.971291987444324d),
new NpgsqlTypes.NpgsqlLine(a: 0.1669664982115614d, b: 0.5657025650853799d, c: 0.3943238449289933d),
new NpgsqlTypes.NpgsqlLine(a: 0.023756096109957103d, b: 0.2297732622717671d, c: 0.4914458489814716d),
new NpgsqlTypes.NpgsqlLine(a: 0.3260799849552207d, b: 0.8786279624676742d, c: 0.5785287532122079d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06146592456653621d, b: 0.4887273624920242d, c: 0.43192284630293276d),
new NpgsqlTypes.NpgsqlLine(a: 0.024348971948935483d, b: 0.7853391181119532d, c: 0.06975455997585578d),
new NpgsqlTypes.NpgsqlLine(a: 0.3161686126332812d, b: 0.5225678551326032d, c: 0.7065166272999038d),
new NpgsqlTypes.NpgsqlLine(a: 0.3914231582501375d, b: 0.09829853642232633d, c: 0.19484136563118182d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49941231113227624d, b: 0.7462584446987433d, c: 0.05477985802286467d),
new NpgsqlTypes.NpgsqlLine(a: 0.3455685701463336d, b: 0.7824807964264305d, c: 0.19507020760980798d),
new NpgsqlTypes.NpgsqlLine(a: 0.4241468257511495d, b: 0.5717054678339883d, c: 0.29289589117727266d),
new NpgsqlTypes.NpgsqlLine(a: 0.2645296713573131d, b: 0.5063986519209352d, c: 0.2725318072336522d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8127119420576929d, b: 0.19551882802761256d, c: 0.24215012512982137d),
new NpgsqlTypes.NpgsqlLine(a: 0.45382657393943804d, b: 0.31769336653023517d, c: 0.35699816279524066d),
new NpgsqlTypes.NpgsqlLine(a: 0.6275199809010947d, b: 0.9770063686360458d, c: 0.561952839222844d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40954553591979304d, b: 0.2092941650745609d, c: 0.10356407675524115d),
new NpgsqlTypes.NpgsqlLine(a: 0.2836919155947212d, b: 0.16317413165503103d, c: 0.17491612504957366d),
new NpgsqlTypes.NpgsqlLine(a: 0.680847931564041d, b: 0.24544053467411509d, c: 0.42878561835830564d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6070106960286495d, b: 0.6091671518735641d, c: 0.7669659184972798d),
new NpgsqlTypes.NpgsqlLine(a: 0.30181094735317193d, b: 0.6369589689176539d, c: 0.7784335526885078d),
new NpgsqlTypes.NpgsqlLine(a: 0.5213845082899786d, b: 0.0692674978670984d, c: 0.4346189075563226d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22303131289719358d, b: 0.07213043063520419d, c: 0.4483055792223669d),
new NpgsqlTypes.NpgsqlLine(a: 0.5916211739158199d, b: 0.8578784796447705d, c: 0.8169893610239444d),
new NpgsqlTypes.NpgsqlLine(a: 0.48708397990677577d, b: 0.5000832937428686d, c: 0.34143643580429583d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34907174360623994d, b: 0.30670415683762464d, c: 0.2538059277869922d),
new NpgsqlTypes.NpgsqlLine(a: 0.30808434612667046d, b: 0.10686148100217852d, c: 0.4657393698768574d),
new NpgsqlTypes.NpgsqlLine(a: 0.49065481790125276d, b: 0.5824560625773971d, c: 0.490880106972854d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5493782534342548d, b: 0.6010302942733176d, c: 0.854708352421641d),
new NpgsqlTypes.NpgsqlLine(a: 0.6908351004032306d, b: 0.7926655434965801d, c: 0.7291463277158342d),
new NpgsqlTypes.NpgsqlLine(a: 0.07681821371451891d, b: 0.7254358943757707d, c: 0.47131926900695675d),
new NpgsqlTypes.NpgsqlLine(a: 0.0671267820115331d, b: 0.8891892221883833d, c: 0.5346500688824103d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6952563836230338d, b: 0.969547961964992d, c: 0.007931737937326933d),
new NpgsqlTypes.NpgsqlLine(a: 0.5686420676625795d, b: 0.4336608126286471d, c: 0.05540305434669357d),
new NpgsqlTypes.NpgsqlLine(a: 0.39329387514036374d, b: 0.4868396749369954d, c: 0.7575105387771893d),
new NpgsqlTypes.NpgsqlLine(a: 0.7206988812774802d, b: 0.9968841426920723d, c: 0.7782769366871315d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18568306026440518d, b: 0.45493885780756316d, c: 0.7139472581011442d),
new NpgsqlTypes.NpgsqlLine(a: 0.4097878996151998d, b: 0.7456087136970125d, c: 0.9787283352103486d),
new NpgsqlTypes.NpgsqlLine(a: 0.6039867002357903d, b: 0.8305718549800858d, c: 0.3062670476549796d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9957815505340536d, b: 0.4849449726008326d, c: 0.050086918733343366d),
new NpgsqlTypes.NpgsqlLine(a: 0.8174755182331542d, b: 0.613206804308035d, c: 0.022125024544668137d),
new NpgsqlTypes.NpgsqlLine(a: 0.3390721605294479d, b: 0.11845342649584889d, c: 0.08837231522612321d),
new NpgsqlTypes.NpgsqlLine(a: 0.019634137073039515d, b: 0.40681001870420097d, c: 0.008090959297827993d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7350374985013611d, b: 0.24926090678271728d, c: 0.1581930276781639d),
new NpgsqlTypes.NpgsqlLine(a: 0.403290696281834d, b: 0.49128631795121114d, c: 0.7847005445373109d),
new NpgsqlTypes.NpgsqlLine(a: 0.4073342541229513d, b: 0.8519769964198584d, c: 0.5217988372948645d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9841706825679847d, b: 0.9235066988751165d, c: 0.3053915653144059d),
new NpgsqlTypes.NpgsqlLine(a: 0.0018086024494852193d, b: 0.799282525826738d, c: 0.35897146410931213d),
new NpgsqlTypes.NpgsqlLine(a: 0.8878558304066706d, b: 0.022467728137082865d, c: 0.12194661741302115d),
new NpgsqlTypes.NpgsqlLine(a: 0.6475379660809981d, b: 0.009495979147900568d, c: 0.044093881880714836d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5047147361951849d, b: 0.7090186892983298d, c: 0.5644655793418937d),
new NpgsqlTypes.NpgsqlLine(a: 0.8324414409604182d, b: 0.6442531050683149d, c: 0.5290582148693858d),
new NpgsqlTypes.NpgsqlLine(a: 0.215013612526477d, b: 0.4308021310763327d, c: 0.12177013243182477d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7867528243042534d, b: 0.5485847837192748d, c: 0.36761504830743397d),
new NpgsqlTypes.NpgsqlLine(a: 0.24402293856995372d, b: 0.0803268198138758d, c: 0.8283294236635316d),
new NpgsqlTypes.NpgsqlLine(a: 0.4371955436616348d, b: 0.31611181670450217d, c: 0.4916919416938257d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5849157322403081d, b: 0.9124725623646157d, c: 0.7884422639960954d),
new NpgsqlTypes.NpgsqlLine(a: 0.1021337431986229d, b: 0.22202593665917025d, c: 0.3960928747086073d),
new NpgsqlTypes.NpgsqlLine(a: 0.9681706606305807d, b: 0.12541925229073458d, c: 0.8067759193019459d),
new NpgsqlTypes.NpgsqlLine(a: 0.4491822275259396d, b: 0.9280433409192729d, c: 0.5588045731153191d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9828184452500192d, b: 0.3638980242795278d, c: 0.8930179088368662d),
new NpgsqlTypes.NpgsqlLine(a: 0.9752518103070454d, b: 0.5508252879773083d, c: 0.08346154955108498d),
new NpgsqlTypes.NpgsqlLine(a: 0.0775158454121796d, b: 0.9762555156049938d, c: 0.12358946756755707d),
new NpgsqlTypes.NpgsqlLine(a: 0.032199701841995276d, b: 0.6510873883897789d, c: 0.229967098408564d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30556408864182605d, b: 0.11595634032249647d, c: 0.5006500981357491d),
new NpgsqlTypes.NpgsqlLine(a: 0.588967700889991d, b: 0.3621859106486818d, c: 0.25463873861015496d),
new NpgsqlTypes.NpgsqlLine(a: 0.3079622438197206d, b: 0.7235003327568207d, c: 0.7745943502129865d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5419670344575002d, b: 0.6618453061558437d, c: 0.5842564246073191d),
new NpgsqlTypes.NpgsqlLine(a: 0.7536366358427562d, b: 0.47560135545117255d, c: 0.1992564502584695d),
new NpgsqlTypes.NpgsqlLine(a: 0.7419236638943634d, b: 0.22767163398112766d, c: 0.358482132898971d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06236603985258593d, b: 0.8980145117179745d, c: 0.4639851386460385d),
new NpgsqlTypes.NpgsqlLine(a: 0.034102300763411475d, b: 0.4057323012247035d, c: 0.06431647756329695d),
new NpgsqlTypes.NpgsqlLine(a: 0.8511292933822615d, b: 0.5346496353482982d, c: 0.40666191993816636d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39795939610736264d, b: 0.28520778246433753d, c: 0.2633732478772407d),
new NpgsqlTypes.NpgsqlLine(a: 0.8353817811312552d, b: 0.2113673980426729d, c: 0.8725712778700861d),
new NpgsqlTypes.NpgsqlLine(a: 0.7499623207385233d, b: 0.04313000483990859d, c: 0.0034464831581556554d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8606647429469185d, b: 0.29792879638675374d, c: 0.6895947771477018d),
new NpgsqlTypes.NpgsqlLine(a: 0.9054899869761718d, b: 0.6771213031413225d, c: 0.688519676835144d),
new NpgsqlTypes.NpgsqlLine(a: 0.2616950278194444d, b: 0.06344221085504098d, c: 0.6331729142666419d),
new NpgsqlTypes.NpgsqlLine(a: 0.6797228738264111d, b: 0.6280545124585571d, c: 0.6498073541519392d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7780790767037619d, b: 0.24206026516040557d, c: 0.9722020370468776d),
new NpgsqlTypes.NpgsqlLine(a: 0.6774555971795662d, b: 0.09783803205541186d, c: 0.984843827873424d),
new NpgsqlTypes.NpgsqlLine(a: 0.46692896340916057d, b: 0.6431647227724155d, c: 0.43539766500253374d),
}));
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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28304081128069336d, b: 0.7571166125169627d, c: 0.7982960200904307d),
new NpgsqlTypes.NpgsqlLine(a: 0.9128158197341449d, b: 0.11844612915853714d, c: 0.7928736963825657d),
new NpgsqlTypes.NpgsqlLine(a: 0.363915742152791d, b: 0.5440512076557094d, c: 0.36994429818608565d),
new NpgsqlTypes.NpgsqlLine(a: 0.9798704576072748d, b: 0.10141650853872619d, c: 0.09758923629678284d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine(a: 0.09700657806791235d, b: 0.36236509356176705d, c: 0.6684805473497292d),
new NpgsqlTypes.NpgsqlLine(a: 0.12430520813083745d, b: 0.3500357922734456d, c: 0.08139043117333156d),
new NpgsqlTypes.NpgsqlLine(a: 0.4850346265104193d, b: 0.7674217525077774d, c: 0.3021880542937436d),
new NpgsqlTypes.NpgsqlLine(a: 0.7348205909206466d, b: 0.4047528935172461d, c: 0.9305304171351363d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9767119652047345d, b: 0.2480131369340065d, c: 0.8320428292992357d),
new NpgsqlTypes.NpgsqlLine(a: 0.914875505983561d, b: 0.7579550796188522d, c: 0.6381668204783371d),
new NpgsqlTypes.NpgsqlLine(a: 0.6686634670363006d, b: 0.12800087965611728d, c: 0.8223296412858319d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1898921844101925d, b: 0.749603725737316d, c: 0.8907431881279126d),
new NpgsqlTypes.NpgsqlLine(a: 0.4621963513973881d, b: 0.7667698022517506d, c: 0.06065249575097087d),
new NpgsqlTypes.NpgsqlLine(a: 0.8738763597099789d, b: 0.45762946113954217d, c: 0.7124960968013191d),
new NpgsqlTypes.NpgsqlLine(a: 0.9314251031449918d, b: 0.8546628429718862d, c: 0.15179707262271436d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08249645191189625d, b: 0.998308173830233d, c: 0.5540692153859161d),
new NpgsqlTypes.NpgsqlLine(a: 0.7186175666275979d, b: 0.5221634521412888d, c: 0.6394678502853837d),
new NpgsqlTypes.NpgsqlLine(a: 0.5968424712567284d, b: 0.8006645980608349d, c: 0.49526013553863624d),
new NpgsqlTypes.NpgsqlLine(a: 0.6166771555989286d, b: 0.5561530479681502d, c: 0.5684524430663924d),
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 71, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 76, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 120, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 78, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 53, query1, 138, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[34], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 71, query1, 64, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 64, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 30, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[34], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[34], false);
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

