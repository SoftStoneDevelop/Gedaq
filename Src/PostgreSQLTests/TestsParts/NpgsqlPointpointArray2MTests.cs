

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7337123132593113d, y: 0.6562404884306091d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8156188486248056d, y: 0.43696415066804484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17748876272909664d, y: 0.1311320177012938d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8151291933678021d, y: 0.33112684278447113d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3708372580641921d, y: 0.07609250111795152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42625119442361814d, y: 0.7764807449315762d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7955056828416288d, y: 0.07139348018498592d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9895380589191018d, y: 0.0834019562320032d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8255279046803284d, y: 0.06210972698210937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7615677242373223d, y: 0.9479508793729252d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8322797168493505d, y: 0.5321783689499443d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5088777817599591d, y: 0.10301808441499538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5486746028436293d, y: 0.09221325833884964d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7618221314073101d, y: 0.28341858485772764d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4776013816978738d, y: 0.510996187600109d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5555357882604343d, y: 0.5566280763342001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15937887298368292d, y: 0.8146657843028686d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.00260426778258227d, y: 0.5814046976951301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27577962883542406d, y: 0.8396816100992653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3519245793866399d, y: 0.9208248091291442d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24933184282071996d, y: 0.9016775999964546d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2328141097948928d, y: 0.9798705985639109d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46227052425750936d, y: 0.14129580145138343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10490975981636952d, y: 0.8044655283091963d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.267434031305816d, y: 0.9902886156934659d),

new NpgsqlTypes.NpgsqlPoint(x: 0.774096657162757d, y: 0.15488164651846115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.819259431392466d, y: 0.4058881180875864d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7525541250838255d, y: 0.49710282745419243d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3770386963894694d, y: 0.9811786890766186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.292919994590607d, y: 0.27093405475310306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12248764575851168d, y: 0.6782744378722544d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6312305865933463d, y: 0.06654070648611432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.513214035834423d, y: 0.903305508556985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.022945505158574298d, y: 0.765999199736977d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01675279635392901d, y: 0.8441040580947912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2184175343100787d, y: 0.1923722356896962d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27801770512920254d, y: 0.8379759420608186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08477246936029093d, y: 0.912823067532031d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47550634810045966d, y: 0.9784624102497004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8705164227975888d, y: 0.7056434440835722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39949798303304873d, y: 0.04865247242808868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7113271500667122d, y: 0.5164450288618097d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7362191398130533d, y: 0.8981057741638607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1086022732681573d, y: 0.9601895244028843d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2636514628507739d, y: 0.9649512209360065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6972220411881177d, y: 0.9620780032400605d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8390399287057455d, y: 0.22756783572681716d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04590836523980424d, y: 0.9275082019128672d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7640978255820764d, y: 0.3120385491893449d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3602679357459947d, y: 0.7339024232468465d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5858934593808446d, y: 0.8046106501811577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4052973777686013d, y: 0.22904746349746485d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9811554582002113d, y: 0.7560546293967954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05814851441148883d, y: 0.20230669056974526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8122030717158535d, y: 0.07474056151643604d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.152597067601011d, y: 0.29517982711501534d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6978190560390226d, y: 0.8579416078824202d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08942926565009324d, y: 0.3425655621199871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.016381201569789394d, y: 0.5924836109592028d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2500892054435164d, y: 0.9874017475004403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9579039111456d, y: 0.9555397241198269d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8152509498984705d, y: 0.01848653253687016d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46721907841990806d, y: 0.9426906586773156d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22686050356471654d, y: 0.1216679674733262d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6584094815626333d, y: 0.1418192665350999d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5611650579741961d, y: 0.020620721665183916d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9888463026850783d, y: 0.6357300543012636d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5941164450395438d, y: 0.1501624023292305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13020319517316503d, y: 0.5603485136444225d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3855087014274141d, y: 0.03896311708029665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5512073942751655d, y: 0.5754267721463215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.654595730732435d, y: 0.2406793394079243d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6451632964674064d, y: 0.5341080314647818d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5608274514301533d, y: 0.827746383789347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10818443853173287d, y: 0.5600763658534585d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8018997486919421d, y: 0.9289442397029756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1846281143110543d, y: 0.23447528428729436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6458303267570892d, y: 0.8190004724692548d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18383762767096523d, y: 0.2740719211165361d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7160527307314268d, y: 0.545771576363329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07317243485362224d, y: 0.09370431828313663d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028547710306362162d, y: 0.9363805793120142d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45980308523272273d, y: 0.9463748823223721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.005735234873813999d, y: 0.9419350579237303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09695515743143535d, y: 0.974840322408217d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6661658609506529d, y: 0.22191418537498975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.719326449010201d, y: 0.14395467361633796d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1765095159778155d, y: 0.9139132645995666d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18270023143640757d, y: 0.30529285892244284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37228827298554423d, y: 0.2508425854010754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37500522083478915d, y: 0.7425194462461684d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7853454019000268d, y: 0.21969359688082346d),

new NpgsqlTypes.NpgsqlPoint(x: 0.01752459622745206d, y: 0.557499889308765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0044030509295399645d, y: 0.7979283678921409d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6941410430600264d, y: 0.6015470224530374d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22084476532299047d, y: 0.9718310895965669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10034420555639978d, y: 0.6972927162545366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16045679276902103d, y: 0.8704705502295874d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8519659130687196d, y: 0.9298291107610349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18433235081312116d, y: 0.43867275595419886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5475133323590228d, y: 0.4199276786913503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1736392282161826d, y: 0.44683039053071116d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4683260944636898d, y: 0.2681274516943436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02389252508703843d, y: 0.8702511174528134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8256124783185995d, y: 0.9176129623989353d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37711571474909744d, y: 0.16964244544574147d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9041564645986724d, y: 0.009609323983899132d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9033851806905988d, y: 0.6131762906440508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49268923255539687d, y: 0.8610853438985876d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09036937240937237d, y: 0.22227303101635432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1379001153773981d, y: 0.6150435069061592d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7062684983133554d, y: 0.658794610453856d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8046032493561726d, y: 0.5172327572812857d),

new NpgsqlTypes.NpgsqlPoint(x: 0.015525189108254733d, y: 0.10066912053532151d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38933687008609186d, y: 0.14444503784652374d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6985852901097d, y: 0.35286619967578836d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4132230965053024d, y: 0.1923723364310217d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28997301250328145d, y: 0.19121130506321893d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21878386204221245d, y: 0.6077833403427751d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1957287632942638d, y: 0.17802609496525867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23532813497927496d, y: 0.5172677082907722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48909658655886845d, y: 0.6031141584258759d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15536061408937873d, y: 0.8659347123135923d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9275288343421805d, y: 0.8582031817598077d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4203254814805759d, y: 0.7198024183978661d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43760670299676463d, y: 0.3313946967446062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36321969697706213d, y: 0.7769105932609072d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9777671820098558d, y: 0.15621151663721244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8083885245891541d, y: 0.9300173433701024d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19062414003100492d, y: 0.36184083154886126d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07936504988949067d, y: 0.2842842858960474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7968846164698845d, y: 0.49913336458287083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.478271927025005d, y: 0.33954901859006015d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7379443962484077d, y: 0.47040027386654715d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7412735512259155d, y: 0.6742854590394286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7889159196367664d, y: 0.5698982843972991d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39547854401315674d, y: 0.6014546563105968d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8276182182299496d, y: 0.3937612723192365d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5851591007456494d, y: 0.1193499611458314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4117296855699407d, y: 0.9839401300391836d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08806488254863254d, y: 0.33223929836128463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9026136123740648d, y: 0.40636028816509207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05157737233742876d, y: 0.7993965266925581d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7857985094628971d, y: 0.5879856743322133d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5739424917977466d, y: 0.9848438949962736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38049519201663307d, y: 0.2971531261585756d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6595403195422856d, y: 0.06492490148485652d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7580944043300004d, y: 0.41397886739224476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8921457023759973d, y: 0.09354422306555032d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028088574588305604d, y: 0.3546040815244602d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5945287754341811d, y: 0.4272784004443738d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951574758138988d, y: 0.12180540633260295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5320678089787545d, y: 0.45570106742854144d),

new NpgsqlTypes.NpgsqlPoint(x: 0.625340005898744d, y: 0.2964960077200044d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9528001911507696d, y: 0.32700164738196313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.854664105572291d, y: 0.5849799690585429d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7551554516336522d, y: 0.5575421006403906d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8845708081094745d, y: 0.6315266975668726d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.618205230476682d, y: 0.4322939445727021d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6581404170683082d, y: 0.9192637425546392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5957116218733509d, y: 0.4001685313608421d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5610702946271471d, y: 0.9826123490332235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0958178123638197d, y: 0.14232494010569863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10893744432646602d, y: 0.3747600332755614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16856495230459623d, y: 0.787253552583815d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9103363093179547d, y: 0.511151647876362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7154260963228027d, y: 0.15821002407798135d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7721173459757298d, y: 0.8848782965929483d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45286033833406814d, y: 0.18908700275243184d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23367092578859017d, y: 0.9414900525080819d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03894717518716795d, y: 0.4093013740648831d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05864364167472291d, y: 0.9649109054785971d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5185753033080227d, y: 0.7006660280217297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6398256596404587d, y: 0.5768134738303696d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8748492169448842d, y: 0.607753644146402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5396730725369248d, y: 0.028513750932598225d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25036715507578633d, y: 0.08848255675388517d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021759168001486695d, y: 0.38223482859613866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.718798643586128d, y: 0.8516030247710362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34955001477430603d, y: 0.22466454844492356d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.829715578318431d, y: 0.4847255908950113d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2787780191172574d, y: 0.4987081840149181d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8264328711245104d, y: 0.8926705349888683d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39389267342204337d, y: 0.014163357944255717d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2283136541213997d, y: 0.33256362996164734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8636975179063633d, y: 0.5319288810965844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2877088326416767d, y: 0.13127229103695337d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2734010133859217d, y: 0.7385123207566252d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3647425258528173d, y: 0.8077299781741902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4376454088852232d, y: 0.7199011570313392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17485872123002377d, y: 0.8091190091222471d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05831932151964747d, y: 0.4146411794712125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8902765522925151d, y: 0.2994244843988223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41342130387067566d, y: 0.8090876619633973d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5637571874680748d, y: 0.7769824122470782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7697922800013922d, y: 0.20769488019067406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27105395802295584d, y: 0.14779168215369165d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.056628048568530764d, y: 0.9492174870252461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28733342545598706d, y: 0.512301945570329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473503817448336d, y: 0.5803177450401616d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5821114207325813d, y: 0.7896447840905256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.709042011029736d, y: 0.4897919263267687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.783697203311845d, y: 0.5275167631390694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7351027415247277d, y: 0.5616741812529134d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6414852136705907d, y: 0.2853679996218115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4198436922501385d, y: 0.5170364307378134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49346511245455515d, y: 0.855107134291052d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8930733680835713d, y: 0.3901880432670103d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503863294249843d, y: 0.7161760270561243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16957330141302862d, y: 0.4240586395183161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6997166960534834d, y: 0.22089212134418235d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7788358791906033d, y: 0.4265443322405925d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33351551918185096d, y: 0.5593029223307907d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7421782883188157d, y: 0.9344544811608382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03692618804575398d, y: 0.927147705984631d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48864454077030994d, y: 0.19126657020927507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4627980092254804d, y: 0.24998689971614774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2751632343507968d, y: 0.7866175684431341d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6283034366459953d, y: 0.21259476390372756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8847339835091341d, y: 0.7560701716976681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5925339565287727d, y: 0.28440707083190364d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5068115402314423d, y: 0.47675654462431716d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4821712304565654d, y: 0.5379901591667839d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17585094948728663d, y: 0.3115563090533653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6826772117291913d, y: 0.5099653798171085d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5384763256296456d, y: 0.10303105690763814d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46940132488751474d, y: 0.35644877476233194d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8100352575846175d, y: 0.4416361942030793d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23412242499755154d, y: 0.7970394774119293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9548633871260678d, y: 0.14159723450678596d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9607704593699307d, y: 0.8196610404302617d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6247457291482362d, y: 0.8382071940439905d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4463570178165547d, y: 0.029277688524841916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8945163059047584d, y: 0.9185707815954555d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16704548567084965d, y: 0.9873945190700222d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0501058030062973d, y: 0.5052954867813263d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21737129048080084d, y: 0.6343952656488543d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8607459010444491d, y: 0.20587003271132998d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9573029960865771d, y: 0.6359488368990153d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37512674929617895d, y: 0.9455983321461805d),

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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
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

                var models =  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 107, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatchAsync(connection, 86, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);
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
                var models =  ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatch(connection, 136, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2M>(15);

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
                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

