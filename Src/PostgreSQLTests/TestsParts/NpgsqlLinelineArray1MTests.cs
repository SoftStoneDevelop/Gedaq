

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2859498399661602d, b: 0.35268354891208553d, c: 0.08510165835904215d),
new NpgsqlTypes.NpgsqlLine(a: 0.7624236330714451d, b: 0.6631970189787617d, c: 0.7339903375052876d),
new NpgsqlTypes.NpgsqlLine(a: 0.06436995302713389d, b: 0.2481478780183649d, c: 0.06754369479304678d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8243673228731881d, b: 0.204875531421719d, c: 0.02425350319828612d),
new NpgsqlTypes.NpgsqlLine(a: 0.06273421953609493d, b: 0.4838590846573747d, c: 0.5516886170211575d),
new NpgsqlTypes.NpgsqlLine(a: 0.5280558198358069d, b: 0.5143548185847147d, c: 0.4717005406973245d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5300347519216915d, b: 0.983630766180568d, c: 0.5407531122930455d),
new NpgsqlTypes.NpgsqlLine(a: 0.4713375700444249d, b: 0.40221155879523274d, c: 0.22807855201030458d),
new NpgsqlTypes.NpgsqlLine(a: 0.8667088504795302d, b: 0.03487506046190336d, c: 0.5416252119815216d),
new NpgsqlTypes.NpgsqlLine(a: 0.039829487210953474d, b: 0.41975450822217963d, c: 0.3910053695170954d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31239663428235187d, b: 0.7100184886294101d, c: 0.044723515834251715d),
new NpgsqlTypes.NpgsqlLine(a: 0.7237842139272055d, b: 0.7802814547205932d, c: 0.9328852890331389d),
new NpgsqlTypes.NpgsqlLine(a: 0.10683885338970522d, b: 0.5843943950838233d, c: 0.6768857064299d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14134181864946604d, b: 0.1688200885229908d, c: 0.005176518468500202d),
new NpgsqlTypes.NpgsqlLine(a: 0.347129483101976d, b: 0.18139573446505042d, c: 0.9201143049003094d),
new NpgsqlTypes.NpgsqlLine(a: 0.12749322698943155d, b: 0.4532997010290495d, c: 0.23727270365871722d),
new NpgsqlTypes.NpgsqlLine(a: 0.7235232728619517d, b: 0.930113164264751d, c: 0.37249323590908745d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9429656629538936d, b: 0.3632988573076863d, c: 0.21185922258744672d),
new NpgsqlTypes.NpgsqlLine(a: 0.6929170058816804d, b: 0.6657000043197249d, c: 0.49166381581516716d),
new NpgsqlTypes.NpgsqlLine(a: 0.2826829469987746d, b: 0.5169144245356062d, c: 0.18092691140573702d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21826854057383194d, b: 0.9453276510440569d, c: 0.6211500192553661d),
new NpgsqlTypes.NpgsqlLine(a: 0.3714054631667688d, b: 0.20161741900193564d, c: 0.722173094842531d),
new NpgsqlTypes.NpgsqlLine(a: 0.7837720043256337d, b: 0.9772575974538062d, c: 0.570381440921648d),
new NpgsqlTypes.NpgsqlLine(a: 0.9086073917103148d, b: 0.46722148705849087d, c: 0.8145691363734969d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7079993411476885d, b: 0.7368528474566344d, c: 0.5803807116390973d),
new NpgsqlTypes.NpgsqlLine(a: 0.7111909724448394d, b: 0.6195207546755982d, c: 0.9007297716042081d),
new NpgsqlTypes.NpgsqlLine(a: 0.8044110805270427d, b: 0.014288095037468862d, c: 0.7581621384384074d),
new NpgsqlTypes.NpgsqlLine(a: 0.8604376379890882d, b: 0.7095185299827047d, c: 0.7710372628958215d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7889192532426084d, b: 0.8228490103609034d, c: 0.11908605207737921d),
new NpgsqlTypes.NpgsqlLine(a: 0.1553767965143732d, b: 0.32684271754713534d, c: 0.7380540343480602d),
new NpgsqlTypes.NpgsqlLine(a: 0.2806783263026349d, b: 0.4885230098051919d, c: 0.49128986926847706d),
new NpgsqlTypes.NpgsqlLine(a: 0.11688964655068823d, b: 0.2937083048299267d, c: 0.03583210665487302d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7286824292382309d, b: 0.747949922146387d, c: 0.862868537896514d),
new NpgsqlTypes.NpgsqlLine(a: 0.5720283202874572d, b: 0.9602678168706689d, c: 0.31465768638534664d),
new NpgsqlTypes.NpgsqlLine(a: 0.3171499295990623d, b: 0.9268638451348272d, c: 0.9446732089259684d),
new NpgsqlTypes.NpgsqlLine(a: 0.06348736517297981d, b: 0.6140400920179073d, c: 0.7494502034651181d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5404659835000837d, b: 0.34481322901925904d, c: 0.45598924853532774d),
new NpgsqlTypes.NpgsqlLine(a: 0.8868575171023061d, b: 0.7269275822246797d, c: 0.6193900803910389d),
new NpgsqlTypes.NpgsqlLine(a: 0.7054600389899329d, b: 0.20081728171660962d, c: 0.5253719549949748d),
new NpgsqlTypes.NpgsqlLine(a: 0.08917117215582449d, b: 0.9710023867302204d, c: 0.09028965831802338d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6934765259687135d, b: 0.9550687583862683d, c: 0.9622542615195162d),
new NpgsqlTypes.NpgsqlLine(a: 0.9113083296937424d, b: 0.21667560752031534d, c: 0.36080362173086233d),
new NpgsqlTypes.NpgsqlLine(a: 0.4661302776001707d, b: 0.19763569907113354d, c: 0.5218977036752823d),
new NpgsqlTypes.NpgsqlLine(a: 0.3684284812623192d, b: 0.6078151168244518d, c: 0.873757861078894d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7276120464324428d, b: 0.3568550122941718d, c: 0.8196164218784432d),
new NpgsqlTypes.NpgsqlLine(a: 0.014649800668979474d, b: 0.9427859370791652d, c: 0.6412553112269302d),
new NpgsqlTypes.NpgsqlLine(a: 0.5065048573736751d, b: 0.9705547741369435d, c: 0.05328557098105824d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8032804786177578d, b: 0.8985354457111716d, c: 0.39839811071008735d),
new NpgsqlTypes.NpgsqlLine(a: 0.6427042584841562d, b: 0.15679173248917777d, c: 0.9286831318501372d),
new NpgsqlTypes.NpgsqlLine(a: 0.16244564296347086d, b: 0.7320846582348814d, c: 0.6867851574131254d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6711273272628284d, b: 0.4882213800438999d, c: 0.7442525071560425d),
new NpgsqlTypes.NpgsqlLine(a: 0.68420601251077d, b: 0.7489393281640789d, c: 0.510376614906218d),
new NpgsqlTypes.NpgsqlLine(a: 0.208563013548542d, b: 0.4483955127469623d, c: 0.18988947193411143d),
new NpgsqlTypes.NpgsqlLine(a: 0.32174447686060414d, b: 0.4668065106765953d, c: 0.23847554615207045d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3796614009299225d, b: 0.1532527625050849d, c: 0.6551704846213239d),
new NpgsqlTypes.NpgsqlLine(a: 0.2189654747089015d, b: 0.5376568590470288d, c: 0.8247980680149517d),
new NpgsqlTypes.NpgsqlLine(a: 0.3414511938989212d, b: 0.23206552673508463d, c: 0.2974713095533089d),
new NpgsqlTypes.NpgsqlLine(a: 0.1451261419958031d, b: 0.41840242710002995d, c: 0.5023035223677343d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3793972233382876d, b: 0.1684964150265037d, c: 0.7022444667958977d),
new NpgsqlTypes.NpgsqlLine(a: 0.4311601757686947d, b: 0.36201192234693136d, c: 0.9294347811778468d),
new NpgsqlTypes.NpgsqlLine(a: 0.22760493497294143d, b: 0.8199637919049846d, c: 0.5682696696630243d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06553839410933793d, b: 0.9330030549227567d, c: 0.8016419542030548d),
new NpgsqlTypes.NpgsqlLine(a: 0.37580673425618893d, b: 0.7775474622596458d, c: 0.0859219825146108d),
new NpgsqlTypes.NpgsqlLine(a: 0.21283122596589843d, b: 0.7920408660823817d, c: 0.8027131186199482d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25217096574473674d, b: 0.6169099559697439d, c: 0.6754962514667313d),
new NpgsqlTypes.NpgsqlLine(a: 0.7768202205944668d, b: 0.3927166169849201d, c: 0.9321505135799054d),
new NpgsqlTypes.NpgsqlLine(a: 0.8249345942734139d, b: 0.25257449444718183d, c: 0.3145841376147228d),
new NpgsqlTypes.NpgsqlLine(a: 0.8766393313605984d, b: 0.409686304019936d, c: 0.21481477324747833d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.163619218425053d, b: 0.41433062670289555d, c: 0.5424725780909312d),
new NpgsqlTypes.NpgsqlLine(a: 0.8828924479997627d, b: 0.4857424996182783d, c: 0.4761161242651146d),
new NpgsqlTypes.NpgsqlLine(a: 0.2840260342059727d, b: 0.8018038943255508d, c: 0.7158317999325297d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05432143930660327d, b: 0.3637904934915629d, c: 0.0731050227775688d),
new NpgsqlTypes.NpgsqlLine(a: 0.3747331895125703d, b: 0.7909080122387699d, c: 0.6146394717696844d),
new NpgsqlTypes.NpgsqlLine(a: 0.7546018926985236d, b: 0.937200963157146d, c: 0.06578401592980143d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.011050323860111955d, b: 0.5833918238446214d, c: 0.22374205800392133d),
new NpgsqlTypes.NpgsqlLine(a: 0.7368469762536073d, b: 0.9095444862499696d, c: 0.5943351857734951d),
new NpgsqlTypes.NpgsqlLine(a: 0.9212646485736423d, b: 0.8371153516352496d, c: 0.7345265286967249d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19727087445769553d, b: 0.4553648730257118d, c: 0.15643500343809202d),
new NpgsqlTypes.NpgsqlLine(a: 0.894668615102319d, b: 0.6414977076216893d, c: 0.7014357416227419d),
new NpgsqlTypes.NpgsqlLine(a: 0.15340072245876668d, b: 0.4367374706376903d, c: 0.8867804400397413d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4533017051479242d, b: 0.40908120994461594d, c: 0.8296018640106486d),
new NpgsqlTypes.NpgsqlLine(a: 0.6415983776716774d, b: 0.4462348329067831d, c: 0.7959258575403478d),
new NpgsqlTypes.NpgsqlLine(a: 0.8933206960222257d, b: 0.3566024618986078d, c: 0.7273399136427773d),
new NpgsqlTypes.NpgsqlLine(a: 0.7878144998056262d, b: 0.09984991376803654d, c: 0.7375440103674827d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.351059420922192d, b: 0.3135015075883517d, c: 0.6863359477230214d),
new NpgsqlTypes.NpgsqlLine(a: 0.8510742778532878d, b: 0.023408136295078874d, c: 0.384301627729971d),
new NpgsqlTypes.NpgsqlLine(a: 0.8111026581407778d, b: 0.6282375854580606d, c: 0.46926170860019456d),
new NpgsqlTypes.NpgsqlLine(a: 0.6361370739801924d, b: 0.44331309794494844d, c: 0.7937266807470502d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7335508818225976d, b: 0.6440900560248959d, c: 0.9523040368312133d),
new NpgsqlTypes.NpgsqlLine(a: 0.8007364405196205d, b: 0.6964780299286062d, c: 0.699554450201857d),
new NpgsqlTypes.NpgsqlLine(a: 0.5446788782101938d, b: 0.2722838250669072d, c: 0.760330350581032d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0049518857240906655d, b: 0.9008292487302271d, c: 0.2818662395754131d),
new NpgsqlTypes.NpgsqlLine(a: 0.22674921952468463d, b: 0.3627994122836853d, c: 0.581304063804585d),
new NpgsqlTypes.NpgsqlLine(a: 0.6309511482206605d, b: 0.572544996512717d, c: 0.6807501891171341d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5032264778806982d, b: 0.8290900630487564d, c: 0.6059797977596978d),
new NpgsqlTypes.NpgsqlLine(a: 0.1839451387613793d, b: 0.22406093459825127d, c: 0.1802420966915056d),
new NpgsqlTypes.NpgsqlLine(a: 0.6812145499949538d, b: 0.6322017907605222d, c: 0.8972083201888423d),
new NpgsqlTypes.NpgsqlLine(a: 0.5291417038771399d, b: 0.5754722765410513d, c: 0.7313904024372011d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46358143763246695d, b: 0.584065650827873d, c: 0.9569996685130839d),
new NpgsqlTypes.NpgsqlLine(a: 0.6508739952335821d, b: 0.056150017855363665d, c: 0.35531650872978615d),
new NpgsqlTypes.NpgsqlLine(a: 0.08242342283163784d, b: 0.6286647643997934d, c: 0.9323673362313061d),
new NpgsqlTypes.NpgsqlLine(a: 0.37341744197798055d, b: 0.5406071959872191d, c: 0.9459028105401244d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.240677310425373d, b: 0.35529531353692023d, c: 0.8211953326073375d),
new NpgsqlTypes.NpgsqlLine(a: 0.5786980047730983d, b: 0.42531373789715365d, c: 0.3239575207894906d),
new NpgsqlTypes.NpgsqlLine(a: 0.034186914366603705d, b: 0.07285709616012814d, c: 0.924030925119274d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8686289355553348d, b: 0.3478603955691736d, c: 0.061408047125532494d),
new NpgsqlTypes.NpgsqlLine(a: 0.5233622521364568d, b: 0.0634249659032542d, c: 0.6473571011254816d),
new NpgsqlTypes.NpgsqlLine(a: 0.5535674010404378d, b: 0.25626722194992035d, c: 0.5700310147854686d),
new NpgsqlTypes.NpgsqlLine(a: 0.1338926916654084d, b: 0.4768874313189999d, c: 0.21979887997436287d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4866627513483127d, b: 0.8928848800910311d, c: 0.4890861336354656d),
new NpgsqlTypes.NpgsqlLine(a: 0.1770386271823604d, b: 0.12306641561302434d, c: 0.688148328264619d),
new NpgsqlTypes.NpgsqlLine(a: 0.16138506420344456d, b: 0.886255205632427d, c: 0.2539311072945656d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43180367966486766d, b: 0.7224655866383884d, c: 0.8151689066081689d),
new NpgsqlTypes.NpgsqlLine(a: 0.10182191988455891d, b: 0.855587357886482d, c: 0.048986954407133965d),
new NpgsqlTypes.NpgsqlLine(a: 0.5588531113655703d, b: 0.8778401819918471d, c: 0.5225592902739427d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7039348206403021d, b: 0.40751175820260555d, c: 0.7320786102753446d),
new NpgsqlTypes.NpgsqlLine(a: 0.27061430536727904d, b: 0.004353180963203029d, c: 0.392219341773294d),
new NpgsqlTypes.NpgsqlLine(a: 0.05162389297120151d, b: 0.5012095955567412d, c: 0.4945785300358888d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9740537502927267d, b: 0.8186505181964963d, c: 0.5465399380956922d),
new NpgsqlTypes.NpgsqlLine(a: 0.16900546961680474d, b: 0.017857613295177654d, c: 0.2582764125714434d),
new NpgsqlTypes.NpgsqlLine(a: 0.37794304592878736d, b: 0.08522046696479257d, c: 0.13987699090801475d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.273538920970115d, b: 0.7677447990287279d, c: 0.20979199988563368d),
new NpgsqlTypes.NpgsqlLine(a: 0.47070439892745364d, b: 0.1947187631990236d, c: 0.04582262548912275d),
new NpgsqlTypes.NpgsqlLine(a: 0.6423325904919489d, b: 0.6561388716615953d, c: 0.9846834520236346d),
new NpgsqlTypes.NpgsqlLine(a: 0.6936315141327746d, b: 0.20869468404749025d, c: 0.2087329388060244d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.372955293523045d, b: 0.5024632967638545d, c: 0.5581929640578126d),
new NpgsqlTypes.NpgsqlLine(a: 0.045101887443129596d, b: 0.11796130773441982d, c: 0.36842145511809454d),
new NpgsqlTypes.NpgsqlLine(a: 0.23491559598171052d, b: 0.41296267376275253d, c: 0.8634289508954025d),
new NpgsqlTypes.NpgsqlLine(a: 0.30028926731236405d, b: 0.8747058371868466d, c: 0.8781327241533895d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.816407306858531d, b: 0.48660342019140357d, c: 0.6992246272347145d),
new NpgsqlTypes.NpgsqlLine(a: 0.6565882251477458d, b: 0.038646187501684026d, c: 0.8883737309870045d),
new NpgsqlTypes.NpgsqlLine(a: 0.09321166547064441d, b: 0.6225151837641316d, c: 0.3463177436288586d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12996768349201893d, b: 0.6851384555187989d, c: 0.4283986344249353d),
new NpgsqlTypes.NpgsqlLine(a: 0.10200684422959205d, b: 0.46924586978527494d, c: 0.22094819447190917d),
new NpgsqlTypes.NpgsqlLine(a: 0.03166146018207916d, b: 0.587105943053762d, c: 0.13686602884926313d),
new NpgsqlTypes.NpgsqlLine(a: 0.25464208556133183d, b: 0.45603454235012864d, c: 0.4782254876016838d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9411354667676033d, b: 0.9444014835600938d, c: 0.7756047440788267d),
new NpgsqlTypes.NpgsqlLine(a: 0.020652828825915348d, b: 0.827523550510397d, c: 0.9487208709910755d),
new NpgsqlTypes.NpgsqlLine(a: 0.3979332527275975d, b: 0.7675381003256513d, c: 0.7392938403699556d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3110091413784718d, b: 0.20277908209505202d, c: 0.1370668847474189d),
new NpgsqlTypes.NpgsqlLine(a: 0.6079804450323734d, b: 0.0836767038434868d, c: 0.2774096166438935d),
new NpgsqlTypes.NpgsqlLine(a: 0.4453071652934355d, b: 0.37065654404232784d, c: 0.6227782382295463d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.35063461443615374d, b: 0.5142002570908021d, c: 0.41075766738743635d),
new NpgsqlTypes.NpgsqlLine(a: 0.08367157447900953d, b: 0.8235317871997888d, c: 0.40364214559420075d),
new NpgsqlTypes.NpgsqlLine(a: 0.18499151496768795d, b: 0.5063409748789346d, c: 0.22533467290799136d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2118489069557412d, b: 0.4123590416350288d, c: 0.7360715642699073d),
new NpgsqlTypes.NpgsqlLine(a: 0.2371111688646994d, b: 0.035720385157470336d, c: 0.5308115941655643d),
new NpgsqlTypes.NpgsqlLine(a: 0.17861752259450692d, b: 0.058084608153318285d, c: 0.628636292526836d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04278122639185011d, b: 0.8821023994509375d, c: 0.8667502324272334d),
new NpgsqlTypes.NpgsqlLine(a: 0.22965972504819077d, b: 0.6746327307455519d, c: 0.3667587512271868d),
new NpgsqlTypes.NpgsqlLine(a: 0.7370292951773376d, b: 0.05895480573591394d, c: 0.06524459974310992d),
new NpgsqlTypes.NpgsqlLine(a: 0.32516869867475506d, b: 0.8485200367523011d, c: 0.7772987319846969d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4322234328396436d, b: 0.14850522077105677d, c: 0.42045603157469646d),
new NpgsqlTypes.NpgsqlLine(a: 0.9173299667763999d, b: 0.09832094223960264d, c: 0.7323451266493255d),
new NpgsqlTypes.NpgsqlLine(a: 0.27131292680978303d, b: 0.23589086307914886d, c: 0.7508073055271867d),
new NpgsqlTypes.NpgsqlLine(a: 0.7360541736917262d, b: 0.028617643601240084d, c: 0.011153289675630229d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3086296207969045d, b: 0.5752897870634301d, c: 0.5798018401354985d),
new NpgsqlTypes.NpgsqlLine(a: 0.5286077742920344d, b: 0.18845566118150203d, c: 0.11985567641679606d),
new NpgsqlTypes.NpgsqlLine(a: 0.9839235156070282d, b: 0.46600088846497334d, c: 0.4947476585040066d),
new NpgsqlTypes.NpgsqlLine(a: 0.9568016940438443d, b: 0.034710554710132735d, c: 0.32736826159538446d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38987185578921735d, b: 0.37856097010341483d, c: 0.7804123975083466d),
new NpgsqlTypes.NpgsqlLine(a: 0.9334327399659126d, b: 0.8458943818967062d, c: 0.20639997825634038d),
new NpgsqlTypes.NpgsqlLine(a: 0.9469433465107796d, b: 0.8554644124624626d, c: 0.5169246235536948d),
new NpgsqlTypes.NpgsqlLine(a: 0.9999946147215943d, b: 0.781691323460283d, c: 0.22940430858598393d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5192370101803638d, b: 0.40860685866845703d, c: 0.7951013736836718d),
new NpgsqlTypes.NpgsqlLine(a: 0.053791784377097085d, b: 0.06376941160206073d, c: 0.589629199289751d),
new NpgsqlTypes.NpgsqlLine(a: 0.011289466717961827d, b: 0.9178066668952352d, c: 0.6356769975823793d),
new NpgsqlTypes.NpgsqlLine(a: 0.2734802997056006d, b: 0.14013205709008303d, c: 0.2417762140706341d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3189441957907111d, b: 0.5700673699403979d, c: 0.2997343037692326d),
new NpgsqlTypes.NpgsqlLine(a: 0.811644516637511d, b: 0.7815711243269432d, c: 0.4072073584910004d),
new NpgsqlTypes.NpgsqlLine(a: 0.5521088138751916d, b: 0.2946729611156491d, c: 0.07657948061601938d),
new NpgsqlTypes.NpgsqlLine(a: 0.07784813016618908d, b: 0.4254375268309797d, c: 0.9949123201484238d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5596167691045544d, b: 0.8934393848406156d, c: 0.8998034090075367d),
new NpgsqlTypes.NpgsqlLine(a: 0.19065984342155085d, b: 0.3593358528663948d, c: 0.13304387895398428d),
new NpgsqlTypes.NpgsqlLine(a: 0.9857447861538969d, b: 0.19660969366464476d, c: 0.9805541139612125d),
new NpgsqlTypes.NpgsqlLine(a: 0.43644838651033024d, b: 0.7381903572786054d, c: 0.6880341374292531d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5503766403928634d, b: 0.07981438278154951d, c: 0.8855849956990695d),
new NpgsqlTypes.NpgsqlLine(a: 0.7950358372730008d, b: 0.6155850011097023d, c: 0.10273885748766065d),
new NpgsqlTypes.NpgsqlLine(a: 0.2664832640626573d, b: 0.6841176107912773d, c: 0.37266780782637365d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3290507200855657d, b: 0.3627534315518496d, c: 0.7453904995688916d),
new NpgsqlTypes.NpgsqlLine(a: 0.33413967443592885d, b: 0.12809759956964095d, c: 0.06902624235039068d),
new NpgsqlTypes.NpgsqlLine(a: 0.2933299051772923d, b: 0.5899031281997978d, c: 0.8956429156578345d),
new NpgsqlTypes.NpgsqlLine(a: 0.4918231013414691d, b: 0.1516683051162775d, c: 0.5134595834560891d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23952620283630943d, b: 0.7033926613900561d, c: 0.4575034946573756d),
new NpgsqlTypes.NpgsqlLine(a: 0.3631805060896298d, b: 0.21922651454657216d, c: 0.0908334871881381d),
new NpgsqlTypes.NpgsqlLine(a: 0.6305541294027328d, b: 0.26096436769395015d, c: 0.7861436024107077d),
new NpgsqlTypes.NpgsqlLine(a: 0.11507770316993737d, b: 0.4613484052441442d, c: 0.6247053376567491d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2911497501692534d, b: 0.6996173040938153d, c: 0.1480001327597953d),
new NpgsqlTypes.NpgsqlLine(a: 0.37714202742776015d, b: 0.6843553440436745d, c: 0.4723439318734849d),
new NpgsqlTypes.NpgsqlLine(a: 0.5412370985833d, b: 0.7451965530496257d, c: 0.9181676171032696d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7792615061599591d, b: 0.4423570422196351d, c: 0.033342997751058756d),
new NpgsqlTypes.NpgsqlLine(a: 0.08892179641271591d, b: 0.6755888436298016d, c: 0.2405972155981042d),
new NpgsqlTypes.NpgsqlLine(a: 0.529850555269489d, b: 0.9317644910283877d, c: 0.5965634859317819d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2108444347733769d, b: 0.5640213877222509d, c: 0.9288638409152928d),
new NpgsqlTypes.NpgsqlLine(a: 0.8948660627527077d, b: 0.5125172654397743d, c: 0.2704804452188343d),
new NpgsqlTypes.NpgsqlLine(a: 0.8788244915730379d, b: 0.007239383876778915d, c: 0.03259733901105133d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15330381067394072d, b: 0.9581284949755089d, c: 0.7733887157302156d),
new NpgsqlTypes.NpgsqlLine(a: 0.4574431893135391d, b: 0.5089973310850444d, c: 0.11049424301151844d),
new NpgsqlTypes.NpgsqlLine(a: 0.5002925009026792d, b: 0.010594850654737087d, c: 0.47409932198515725d),
new NpgsqlTypes.NpgsqlLine(a: 0.21863363329908525d, b: 0.8206293863927376d, c: 0.2978531540373619d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9041653316953394d, b: 0.4636214915565181d, c: 0.08076175285111431d),
new NpgsqlTypes.NpgsqlLine(a: 0.3054620961028852d, b: 0.4785641664914305d, c: 0.8402781581326524d),
new NpgsqlTypes.NpgsqlLine(a: 0.9801940195759322d, b: 0.5415607996332622d, c: 0.1982544005579906d),
new NpgsqlTypes.NpgsqlLine(a: 0.22432557017607413d, b: 0.9663516160000846d, c: 0.5738361198305884d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5113389885632782d, b: 0.5754032886767295d, c: 0.9740422464699809d),
new NpgsqlTypes.NpgsqlLine(a: 0.9107984458952401d, b: 0.09612310557754178d, c: 0.029148531386188115d),
new NpgsqlTypes.NpgsqlLine(a: 0.4276733525784996d, b: 0.4559711960606089d, c: 0.2690919573405016d),
new NpgsqlTypes.NpgsqlLine(a: 0.0016848613801486723d, b: 0.7101924327575967d, c: 0.7669689757580561d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7982659301529399d, b: 0.7273812944205728d, c: 0.8222434915263401d),
new NpgsqlTypes.NpgsqlLine(a: 0.8659941264934417d, b: 0.8730975582759068d, c: 0.4022134798390863d),
new NpgsqlTypes.NpgsqlLine(a: 0.19261328220114182d, b: 0.09040121420765046d, c: 0.21433629650219932d),
new NpgsqlTypes.NpgsqlLine(a: 0.43113847125208515d, b: 0.7759572415600836d, c: 0.5950804331609567d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9581887463099585d, b: 0.6166973144357812d, c: 0.18045925770717086d),
new NpgsqlTypes.NpgsqlLine(a: 0.716020388570231d, b: 0.7974911101138902d, c: 0.5808924810926576d),
new NpgsqlTypes.NpgsqlLine(a: 0.41329414537480114d, b: 0.8881716099452754d, c: 0.5936430002012596d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7136301280294558d, b: 0.962382350878844d, c: 0.731534787625278d),
new NpgsqlTypes.NpgsqlLine(a: 0.3011387755221919d, b: 0.3926009514340244d, c: 0.5665809464368622d),
new NpgsqlTypes.NpgsqlLine(a: 0.9146328467679382d, b: 0.6704788353174038d, c: 0.46895317231068423d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871427488307574d, b: 0.07999845505242986d, c: 0.5075204371710967d),
new NpgsqlTypes.NpgsqlLine(a: 0.9877924175605862d, b: 0.8610500583226336d, c: 0.8262537849216391d),
new NpgsqlTypes.NpgsqlLine(a: 0.4689685120523813d, b: 0.062489621989298194d, c: 0.9588815484126905d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31715524231350356d, b: 0.10272093343817756d, c: 0.5772378653523547d),
new NpgsqlTypes.NpgsqlLine(a: 0.3996320333881158d, b: 0.5729751232310197d, c: 0.3920579989058047d),
new NpgsqlTypes.NpgsqlLine(a: 0.8679353123553195d, b: 0.7480664138761745d, c: 0.4348704294525767d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.929968380768184d, b: 0.7980285402630238d, c: 0.8097327443435424d),
new NpgsqlTypes.NpgsqlLine(a: 0.047074114469958905d, b: 0.9050786728939376d, c: 0.3575727087190408d),
new NpgsqlTypes.NpgsqlLine(a: 0.9604982625512587d, b: 0.7148314727754721d, c: 0.9319797092307623d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2943581826966266d, b: 0.4483158168146447d, c: 0.9332877322533825d),
new NpgsqlTypes.NpgsqlLine(a: 0.9480109670692275d, b: 0.2271968328204762d, c: 0.30409617052072024d),
new NpgsqlTypes.NpgsqlLine(a: 0.04509308573221249d, b: 0.49633912482201403d, c: 0.7142902542631825d),
new NpgsqlTypes.NpgsqlLine(a: 0.37991060151700906d, b: 0.6976868058602984d, c: 0.8041856473738557d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8867477696250012d, b: 0.08516571986966781d, c: 0.0017844078657944795d),
new NpgsqlTypes.NpgsqlLine(a: 0.7088287073707097d, b: 0.16674408883871306d, c: 0.4011899281011776d),
new NpgsqlTypes.NpgsqlLine(a: 0.5327658371207098d, b: 0.441143165868232d, c: 0.15362397274734407d),
new NpgsqlTypes.NpgsqlLine(a: 0.013762809200702164d, b: 0.9938190533233745d, c: 0.603867388041762d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0961557189182396d, b: 0.7821422348174947d, c: 0.2666547697705378d),
new NpgsqlTypes.NpgsqlLine(a: 0.09397689668132847d, b: 0.9667992882431137d, c: 0.588276551539824d),
new NpgsqlTypes.NpgsqlLine(a: 0.39962917583357493d, b: 0.9614971188679226d, c: 0.44613417002522615d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18751892679690763d, b: 0.7475560762004437d, c: 0.22888288562691095d),
new NpgsqlTypes.NpgsqlLine(a: 0.09295562742876551d, b: 0.8913789293390869d, c: 0.3406424252604938d),
new NpgsqlTypes.NpgsqlLine(a: 0.3344484932023273d, b: 0.9506288416015908d, c: 0.07977123301026445d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8927228775171153d, b: 0.11119342767720652d, c: 0.1566112469852935d),
new NpgsqlTypes.NpgsqlLine(a: 0.8322490968512942d, b: 0.2949094120556105d, c: 0.3279444208135398d),
new NpgsqlTypes.NpgsqlLine(a: 0.13079012893328945d, b: 0.905071247948215d, c: 0.7679262217715099d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755857427828798d, b: 0.857550078887047d, c: 0.47934229705837783d),
new NpgsqlTypes.NpgsqlLine(a: 0.3710293124850049d, b: 0.5026709508498137d, c: 0.23202373922724995d),
new NpgsqlTypes.NpgsqlLine(a: 0.9627093860630219d, b: 0.678911291670454d, c: 0.4195176118099907d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7121236935963564d, b: 0.9202550886060261d, c: 0.23624669116082997d),
new NpgsqlTypes.NpgsqlLine(a: 0.40323400360612094d, b: 0.9561059438737028d, c: 0.8024662489893823d),
new NpgsqlTypes.NpgsqlLine(a: 0.9348578738905318d, b: 0.021381699165267665d, c: 0.37525838425026903d),
new NpgsqlTypes.NpgsqlLine(a: 0.597273728311061d, b: 0.30469143695798706d, c: 0.47764419701510963d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3796614009299225d, b: 0.1532527625050849d, c: 0.6551704846213239d),
new NpgsqlTypes.NpgsqlLine(a: 0.2189654747089015d, b: 0.5376568590470288d, c: 0.8247980680149517d),
new NpgsqlTypes.NpgsqlLine(a: 0.3414511938989212d, b: 0.23206552673508463d, c: 0.2974713095533089d),
new NpgsqlTypes.NpgsqlLine(a: 0.1451261419958031d, b: 0.41840242710002995d, c: 0.5023035223677343d),
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.011050323860111955d, b: 0.5833918238446214d, c: 0.22374205800392133d),
new NpgsqlTypes.NpgsqlLine(a: 0.7368469762536073d, b: 0.9095444862499696d, c: 0.5943351857734951d),
new NpgsqlTypes.NpgsqlLine(a: 0.9212646485736423d, b: 0.8371153516352496d, c: 0.7345265286967249d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 54, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 79, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 127, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 119, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 141, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

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
                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

