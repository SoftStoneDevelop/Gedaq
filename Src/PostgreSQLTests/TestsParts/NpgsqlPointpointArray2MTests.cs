

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8848744055314003d, y: 0.6494821102257601d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4504699576317961d, y: 0.27913426601307667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158500754513615d, y: 0.6339743946829806d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113931202929566d, y: 0.8245713911036898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991653643542269d, y: 0.5219431944287473d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3989083709056448d, y: 0.5012599196633775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5953190610525243d, y: 0.03349480399546323d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28634040577951203d, y: 0.8175466131955669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7312928328299346d, y: 0.23241702656843655d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7224026396761004d, y: 0.27626759790454636d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48814778868341646d, y: 0.720585935825327d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14528490416401363d, y: 0.014114874780198239d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5377281757653705d, y: 0.5497393696298698d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11028022037800733d, y: 0.832040537654659d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40883096431382027d, y: 0.3786134338799022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05591898591898492d, y: 0.8909273264242292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4317194932038887d, y: 0.03927793728967344d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6557661538931364d, y: 0.1979266871743297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2481106499701472d, y: 0.7709479891077193d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5701680438191709d, y: 0.30716327758985396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42456580750549267d, y: 0.6458774003020329d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9700189415119116d, y: 0.7192603602097069d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3237405585708286d, y: 0.08053389232400432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3430141319920609d, y: 0.7389614326209746d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19706110781318442d, y: 0.8513945591791469d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24999428236740295d, y: 0.48924826146640277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7883598635487132d, y: 0.21288428754231403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18545667685154688d, y: 0.8455248306692683d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.410383432189664d, y: 0.08323723074150213d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29419548185678834d, y: 0.15789171278622405d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7546279769132394d, y: 0.17336376464791436d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3987233603522099d, y: 0.5219739175756568d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21806765386057958d, y: 0.4191007861186621d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6419072488765086d, y: 0.8563973370464373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15409510468541898d, y: 0.04780207786750834d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7461303153956582d, y: 0.9501728602227223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29215155692033734d, y: 0.22345593390631302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1326900595724494d, y: 0.8278090621457339d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3078991838202778d, y: 0.3963478989969831d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15151405521907912d, y: 0.38418984133131007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23113944392995456d, y: 0.5957068017910506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5023238732977678d, y: 0.9341357944636584d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7657254084144866d, y: 0.7637996474372092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3402268020863115d, y: 0.93810601277895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5739781190574205d, y: 0.9299765531084302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38251113153836613d, y: 0.24292786564039381d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3571853195052591d, y: 0.9815356617773757d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8507500734272158d, y: 0.3403334704317925d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33833304811138243d, y: 0.8725118721137571d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21718726227386065d, y: 0.16396245209504512d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.414640192209614d, y: 0.20005180334366157d),

new NpgsqlTypes.NpgsqlPoint(x: 0.379435598506938d, y: 0.22523387537282202d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9428495235663578d, y: 0.04193176754537464d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8835587975750732d, y: 0.3954106313732343d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3208969798886059d, y: 0.3523380708573919d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05742889109553073d, y: 0.03451997013035801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.856559092091992d, y: 0.8136750558770451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8575071177014554d, y: 0.8054476470003286d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7073165653646013d, y: 0.06827596002816427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07266736432640541d, y: 0.06183675283766432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06580295408081671d, y: 0.40798573285014683d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07274460742319d, y: 0.17144296369496415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8283451832138091d, y: 0.8843690002791621d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9815478154009096d, y: 0.15568805662928786d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9884857417694672d, y: 0.0375110112896887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9470185335728835d, y: 0.6838896875845919d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2697460693064673d, y: 0.6862279828670681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32726808859397083d, y: 0.06267928289383551d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9467849803326904d, y: 0.6163360789636081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8562625943348914d, y: 0.3594023730251231d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5785395921801805d, y: 0.9959771433555249d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5047066041092311d, y: 0.706698821341548d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07994441710605693d, y: 0.7776138210850218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39226943076875354d, y: 0.7783796902177706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6702781387173741d, y: 0.1703687341346949d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5365961286615538d, y: 0.1478622630424934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8347391884003839d, y: 0.6980021801587368d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8040788746625464d, y: 0.5296720876152605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5650562301460933d, y: 0.021067018575090635d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8711319292406491d, y: 0.0091346744250137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40689523265640537d, y: 0.12718053580967725d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4747057917198215d, y: 0.6926889646285439d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.348520451859076d, y: 0.9933044554161147d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06817298064255739d, y: 0.7179602716586653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5340176844417449d, y: 0.6662094306457839d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487041806068195d, y: 0.8419388437612422d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5572633989015687d, y: 0.505381208446142d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3692817149967784d, y: 0.8963410518127699d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6848193926773595d, y: 0.6499329118340285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8583537484017326d, y: 0.0647352662214623d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5443439919433413d, y: 0.5252053795699373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572524065241143d, y: 0.8980607337664906d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3107670042215728d, y: 0.7384978094448942d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30051997360780525d, y: 0.9667498404026557d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9785900645155275d, y: 0.5610641841992152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11241669952565925d, y: 0.24418742301747753d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2971015000107058d, y: 0.055854406696955516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6200976809817107d, y: 0.5963233423395968d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7811251040115242d, y: 0.620031245685137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3222807223967954d, y: 0.04785988483820225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9866691006580548d, y: 0.6320726385689024d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29618066449442826d, y: 0.829897619047577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06745123039799394d, y: 0.9801230038157933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.509967846813043d, y: 0.8717232100999708d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.015935201679975974d, y: 0.8590171604528347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9188473007168831d, y: 0.7835091477743537d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9477321982769068d, y: 0.2846407456026854d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5112598997594767d, y: 0.6564646181371717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9468619993784544d, y: 0.5800528676323472d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818033302746322d, y: 0.7178562346657531d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9937862460524902d, y: 0.04021292837597634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.309741050039811d, y: 0.08318864481369481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010813577687557085d, y: 0.3866337551156205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5744545771872622d, y: 0.5540861728388723d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.033948435832534485d, y: 0.37707754445316755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44234474725925d, y: 0.2913751634313586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46901522983913235d, y: 0.10948182976586862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5288792928392338d, y: 0.15750259395773847d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4349963889613617d, y: 0.3773889024398561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03657382066554249d, y: 0.17456394522355967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3669586771189005d, y: 0.10681443766192789d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8150745176347823d, y: 0.154612735087448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43916349255311793d, y: 0.8695136444604199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30493325063512844d, y: 0.5545604833221162d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3963016512510058d, y: 0.2858709356292004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24695081496713145d, y: 0.5773168414419961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.825460239995656d, y: 0.7711959188600895d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5539886591681741d, y: 0.14683948775283007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9038091633144684d, y: 0.6365108570844242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5941045796536897d, y: 0.47028530936709745d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8681846358159899d, y: 0.7137097044499046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2161163725160773d, y: 0.7915759470926729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.829609910679805d, y: 0.6821983465107974d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6711295199616845d, y: 0.24809389952126115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08017991615806153d, y: 0.11456375263549368d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6992176981888003d, y: 0.6108810017669881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.540957447223981d, y: 0.6745820149081169d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6552678028343774d, y: 0.5891311087255738d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7748363768412806d, y: 0.7279719473696642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017007283658129202d, y: 0.4585701633184974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02137122270399583d, y: 0.8916467437260401d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7841321221246144d, y: 0.9774905095368199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9903513948573893d, y: 0.9533429477260228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3226026644208848d, y: 0.20377409929402712d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8038220895921302d, y: 0.9879177155741401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.782503274775042d, y: 0.6155907380655228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21416154473727167d, y: 0.9228978333583967d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.63177274238506d, y: 0.5219184195768255d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17526723875246708d, y: 0.11468157273780277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6414618799056316d, y: 0.36328735641509813d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.020842872411842905d, y: 0.10520664139081193d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7069364843963274d, y: 0.7651527780010701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8838138910563611d, y: 0.7518777861860336d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7379843414225271d, y: 0.892610314930132d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7234576960204745d, y: 0.39367789863910074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13680077373262078d, y: 0.5572695090060369d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19246350852579674d, y: 0.6812440494108248d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7489901104287556d, y: 0.7680737153537899d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5281382605230706d, y: 0.47911508795869884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.204900203366721d, y: 0.6731283437559057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20810042646782823d, y: 0.8809116905230185d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7188987773928133d, y: 0.30803672122200276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25165935750154866d, y: 0.7752313844358111d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05348087303619209d, y: 0.30249766337794914d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0819811699638453d, y: 0.0572361449155927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23215485453413076d, y: 0.37327243703140167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9572079634553293d, y: 0.7429470563756733d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10096390588798365d, y: 0.4161723691775977d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21907754947424374d, y: 0.6442226338755082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5485507178842192d, y: 0.12676189445936847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5329775038559933d, y: 0.32539460912810336d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14748522409147136d, y: 0.44485821917792d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7130958810790571d, y: 0.315742265921942d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3557462247013551d, y: 0.3243987041470161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9788867249961362d, y: 0.5549629114874298d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32794802430828063d, y: 0.6615997756605931d),

new NpgsqlTypes.NpgsqlPoint(x: 0.875572197846936d, y: 0.7980906960980367d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31737179923569314d, y: 0.47353571686442564d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4891867439962032d, y: 0.8265338625655275d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13161215873483045d, y: 0.16500248377670923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.054360487686593406d, y: 0.04695623210845934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44103829446606113d, y: 0.9981979003213985d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.021847441407161106d, y: 0.9579050115829536d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8492687172741553d, y: 0.40869039259307194d),

new NpgsqlTypes.NpgsqlPoint(x: 0.401898526249457d, y: 0.3966952628837872d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31009329151548626d, y: 0.7995263548595747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39445062403208087d, y: 0.19401473630461064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8115605136031308d, y: 0.22980537513928656d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.76495648134152d, y: 0.5408117964724313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9177650600983619d, y: 0.4379651412714778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42605980835075075d, y: 0.15155081168893358d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18685342376161052d, y: 0.06605596196857633d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48744903417247376d, y: 0.09561639207984696d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07364467478844006d, y: 0.33868869680083336d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1997202070739661d, y: 0.1682675714977433d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4269797120225517d, y: 0.40874763103416223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8808771224577093d, y: 0.5834919594333695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49283915130595d, y: 0.16563034741734972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09721116129966256d, y: 0.34504799052565105d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31401709560469193d, y: 0.16223970521380637d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5542139861241991d, y: 0.764757207314587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14329866656061563d, y: 0.27565200993181904d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8703274634956927d, y: 0.23602078611748267d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6677595639027204d, y: 0.23686202486049257d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6364006058298405d, y: 0.9365385050928604d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6817736279662718d, y: 0.8405358408201149d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5706851307530845d, y: 0.4208659973403872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6733261001898089d, y: 0.6267977317987193d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8868948267425885d, y: 0.8737744685215257d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9122142635289766d, y: 0.2856750716830936d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12793922763307952d, y: 0.4143555477266858d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5397760465002305d, y: 0.10121016638120206d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3435651908351224d, y: 0.4995745469712817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11070174416985434d, y: 0.8559738961834007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9853790466550032d, y: 0.23705157075877648d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5277132937213966d, y: 0.6506859608147872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6644110684591144d, y: 0.3279452417435229d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1040584669557777d, y: 0.9499239599388432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9432633829370763d, y: 0.9455586270871154d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9603400314884705d, y: 0.5823052649966813d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28467937571507385d, y: 0.34206182238595884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6768838092941598d, y: 0.9336560446486486d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32031080320691074d, y: 0.6575630124282297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8938608177158986d, y: 0.8563095011897344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5190865309716137d, y: 0.13670734041158494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08009885983629705d, y: 0.21815925732269625d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7490940325380329d, y: 0.7407513228611917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0504704397644381d, y: 0.49020717031326766d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8452878659196126d, y: 0.14421029057481416d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12553943662698785d, y: 0.06814026269610252d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8911691181415949d, y: 0.040392400164736886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08275661099323539d, y: 0.035845823978621905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22299818060168475d, y: 0.16310804029857018d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9444489619543807d, y: 0.9544143511728791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8485006391511133d, y: 0.6693650613817397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6565623507820657d, y: 0.44648583203898384d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02955346171403428d, y: 0.8390370984105343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8311286279775162d, y: 0.6204764649879052d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7017019873489619d, y: 0.3681171235984976d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9945417926552563d, y: 0.5654659844393165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17448689783525684d, y: 0.21481041568374237d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25349627941141706d, y: 0.4709226302735343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38187786776325994d, y: 0.2939669989359003d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44363497201417945d, y: 0.661440046891344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39904696455418043d, y: 0.9184958365876418d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36487297148144315d, y: 0.9788431761636882d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49708519387858774d, y: 0.716586303184798d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9622054495734681d, y: 0.7803385045177518d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8616160059779527d, y: 0.6535454152901592d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25165479577341243d, y: 0.8525774330915201d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06920531723778567d, y: 0.31935957906337775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7808773529672911d, y: 0.5928815680038516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1256560077462724d, y: 0.03311880005325629d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09250443788847718d, y: 0.9809027601241366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6632636049009673d, y: 0.0323128564271733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7667446132767978d, y: 0.20485233624557764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6307782001669767d, y: 0.4351836859310766d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49897697523544493d, y: 0.2702393042838086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26425078323749296d, y: 0.9077778622318254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48774335496810906d, y: 0.5851893697701926d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06151668120111886d, y: 0.9685915376689301d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5091780144788778d, y: 0.4459529119446496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3675407656734432d, y: 0.2535103097520891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856710177891115d, y: 0.03881574881141758d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46618831178683495d, y: 0.6478167915190455d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5808766452901173d, y: 0.6420526451115408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9864102698707009d, y: 0.8671654331739994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4751643142625952d, y: 0.6358993272155886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666673659040418d, y: 0.5101960902947975d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5519326738742196d, y: 0.6982333248886295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35215030406871783d, y: 0.702691817545744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8773714830204502d, y: 0.4668163431361346d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.74036292899697d, y: 0.44757288076368984d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8425212487282255d, y: 0.9614312484233053d),

new NpgsqlTypes.NpgsqlPoint(x: 0.019382470395281404d, y: 0.7359616738920083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7642253418275429d, y: 0.38308544428591584d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14112218011612587d, y: 0.6542554515034013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9160836044596289d, y: 0.3725358018077609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08182617767329725d, y: 0.5177148538089694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42170809290323863d, y: 0.946987025139438d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
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
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 88, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 36, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 7, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 157, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 97, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 68, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 12, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[28],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

