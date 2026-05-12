

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
    internal partial interface IBigIntegerListnumericListD1
    {
    }
    
    internal partial class BigIntegerListnumericListD1 : IBigIntegerListnumericListD1
    {


#region TestData

        private readonly BigIntegernumericListD1E2M[] _testData = new BigIntegernumericListD1E2M[]
        {
            new BigIntegernumericListD1E2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(695141220506400085L),

new System.Numerics.BigInteger(2984988812039589418L),

new System.Numerics.BigInteger(145507176417292563L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6010571187985688075L),

new System.Numerics.BigInteger(1930728797621824810L),

new System.Numerics.BigInteger(7641651320800458531L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4634373837445101417L),

new System.Numerics.BigInteger(1381281874042665814L),

new System.Numerics.BigInteger(7578307916626931370L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4488009042363110110L),

new System.Numerics.BigInteger(3544261126722440042L),

new System.Numerics.BigInteger(8311898916972050728L),

new System.Numerics.BigInteger(8306500369183949245L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4533977135396977478L),

new System.Numerics.BigInteger(8001390262997713936L),

new System.Numerics.BigInteger(4054122773335598821L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4717006566979755373L),

new System.Numerics.BigInteger(6807831268040479464L),

new System.Numerics.BigInteger(9222394037455134716L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6304584903584411732L),

new System.Numerics.BigInteger(4052493430863600738L),

new System.Numerics.BigInteger(3405941054609310092L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8530221476392122295L),

new System.Numerics.BigInteger(4870015013924117655L),

new System.Numerics.BigInteger(6997525283370071923L),

new System.Numerics.BigInteger(8811321433130442338L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4108335954552450666L),

new System.Numerics.BigInteger(6876022523351134869L),

new System.Numerics.BigInteger(5071095592531225620L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4457842087531460960L),

new System.Numerics.BigInteger(1205811594289433090L),

new System.Numerics.BigInteger(5067881131417251651L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6242135223711168773L),

new System.Numerics.BigInteger(6511213660975864692L),

new System.Numerics.BigInteger(56060023008895669L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7661167960984826198L),

new System.Numerics.BigInteger(2477718712623384625L),

new System.Numerics.BigInteger(6053122165820327772L),

new System.Numerics.BigInteger(5687977342381244977L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5676902704586117614L),

new System.Numerics.BigInteger(1594016801021207102L),

new System.Numerics.BigInteger(1906794399038359003L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3615474924061219250L),

new System.Numerics.BigInteger(5081614822014718363L),

new System.Numerics.BigInteger(4985362768593197607L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4368663268680839331L),

new System.Numerics.BigInteger(768612322725417166L),

new System.Numerics.BigInteger(438197530470055611L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2590480118186695858L),

new System.Numerics.BigInteger(2616649005820188956L),

new System.Numerics.BigInteger(1195083089603386688L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7162881563564085612L),

new System.Numerics.BigInteger(1634855682440102718L),

new System.Numerics.BigInteger(3300100491032512588L),

new System.Numerics.BigInteger(9195847723808015804L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4720947000467883706L),

new System.Numerics.BigInteger(1822996111303178645L),

new System.Numerics.BigInteger(663322394093364736L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5392417231826670741L),

new System.Numerics.BigInteger(5623983910406067575L),

new System.Numerics.BigInteger(2875270403728544003L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6953000068734210131L),

new System.Numerics.BigInteger(3995269656195533817L),

new System.Numerics.BigInteger(7448585839830498968L),

new System.Numerics.BigInteger(6861357902521887424L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4887266958544591479L),

new System.Numerics.BigInteger(2857359180557841664L),

new System.Numerics.BigInteger(7807827758858492524L),

new System.Numerics.BigInteger(4990318698669296658L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2400979565459047815L),

new System.Numerics.BigInteger(8788511552728596292L),

new System.Numerics.BigInteger(6235765536639845707L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3812013519100818854L),

new System.Numerics.BigInteger(6966323613294534568L),

new System.Numerics.BigInteger(3165979229783120129L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266769385421643290L),

new System.Numerics.BigInteger(3440562702959757398L),

new System.Numerics.BigInteger(4225331821183647598L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5631116778305033852L),

new System.Numerics.BigInteger(8730689080084211069L),

new System.Numerics.BigInteger(6732554311914969035L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1378641028732593850L),

new System.Numerics.BigInteger(1973712471787652705L),

new System.Numerics.BigInteger(5733059388354903680L),

new System.Numerics.BigInteger(5682116173620090615L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2227803892946359371L),

new System.Numerics.BigInteger(2593127413567899130L),

new System.Numerics.BigInteger(3731353220400034037L),

new System.Numerics.BigInteger(7148000564732498100L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4759609392811535135L),

new System.Numerics.BigInteger(5137802559782317376L),

new System.Numerics.BigInteger(6232110217961586641L),

new System.Numerics.BigInteger(5868920111219019022L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1052431289803661848L),

new System.Numerics.BigInteger(2727384021549596141L),

new System.Numerics.BigInteger(3994103851405337287L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8226259837776648513L),

new System.Numerics.BigInteger(4168942029829670442L),

new System.Numerics.BigInteger(3879469324392119789L),

new System.Numerics.BigInteger(5802729370373344312L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2633479329211356787L),

new System.Numerics.BigInteger(1103124434056347562L),

new System.Numerics.BigInteger(4715426076599640226L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7112146943511407044L),

new System.Numerics.BigInteger(6608220365304584172L),

new System.Numerics.BigInteger(1688331147923352188L),

new System.Numerics.BigInteger(1782950595250867199L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3719385001125944238L),

new System.Numerics.BigInteger(6761812574723788864L),

new System.Numerics.BigInteger(4766463211005903415L),

new System.Numerics.BigInteger(2309697944348906880L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7025898117191483350L),

new System.Numerics.BigInteger(4525117259888312997L),

new System.Numerics.BigInteger(5184156543855521098L),

new System.Numerics.BigInteger(6539011885520120731L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6579911965703148825L),

new System.Numerics.BigInteger(3583378723487455269L),

new System.Numerics.BigInteger(1554320790863262853L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3673265590235382111L),

new System.Numerics.BigInteger(5645306202578687748L),

new System.Numerics.BigInteger(4297296728437682478L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5117675935411829158L),

new System.Numerics.BigInteger(2528676082120189462L),

new System.Numerics.BigInteger(7991258342949103350L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6581108046830094704L),

new System.Numerics.BigInteger(6502908470685210210L),

new System.Numerics.BigInteger(2413928271349259510L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8643032186304093102L),

new System.Numerics.BigInteger(7880774912868567696L),

new System.Numerics.BigInteger(329341290818363770L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(327178700665556463L),

new System.Numerics.BigInteger(560936604926070475L),

new System.Numerics.BigInteger(198057575092647816L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6360581446858555360L),

new System.Numerics.BigInteger(8567255565963207013L),

new System.Numerics.BigInteger(425683453233009336L),

new System.Numerics.BigInteger(969970184856661726L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1217818957820568683L),

new System.Numerics.BigInteger(6030067688265887666L),

new System.Numerics.BigInteger(8133912348857270193L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1429850376529446807L),

new System.Numerics.BigInteger(5215273371942818452L),

new System.Numerics.BigInteger(3210967725069181895L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8787968480413566595L),

new System.Numerics.BigInteger(6549549361874670992L),

new System.Numerics.BigInteger(1732151988392541399L),

new System.Numerics.BigInteger(1739437703110017091L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8866556593730402877L),

new System.Numerics.BigInteger(2865613424756497211L),

new System.Numerics.BigInteger(9046956580101957344L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1187852253764715974L),

new System.Numerics.BigInteger(6823266900083194743L),

new System.Numerics.BigInteger(988025651722070239L),

new System.Numerics.BigInteger(5124988552053007758L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3016005230938876209L),

new System.Numerics.BigInteger(6869980981483729943L),

new System.Numerics.BigInteger(97640168745857072L),

new System.Numerics.BigInteger(3078475676723456238L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8671892712111220663L),

new System.Numerics.BigInteger(5663893455037150048L),

new System.Numerics.BigInteger(5336149031713804192L),

new System.Numerics.BigInteger(8072067415990424201L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(983502893438578168L),

new System.Numerics.BigInteger(8235943204798921631L),

new System.Numerics.BigInteger(8642224230303137861L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8601051228735526334L),

new System.Numerics.BigInteger(5081177745503274795L),

new System.Numerics.BigInteger(5808323306317831925L),

new System.Numerics.BigInteger(5449213929269075097L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(97486887300986888L),

new System.Numerics.BigInteger(7705526727667543078L),

new System.Numerics.BigInteger(2647339314705586765L),

new System.Numerics.BigInteger(8777636012977840714L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6989531497491088070L),

new System.Numerics.BigInteger(6019724005890651725L),

new System.Numerics.BigInteger(8658201743993067650L),

new System.Numerics.BigInteger(4241277361987281316L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2574103723547653874L),

new System.Numerics.BigInteger(3858659258926860625L),

new System.Numerics.BigInteger(687401522322679813L),

new System.Numerics.BigInteger(951099231693253892L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(384801256005049220L),

new System.Numerics.BigInteger(247698165019368352L),

new System.Numerics.BigInteger(612597788267284129L),

new System.Numerics.BigInteger(4857067553152410433L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2941689686757153357L),

new System.Numerics.BigInteger(8917831976743503871L),

new System.Numerics.BigInteger(1840907754337036005L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5548894031285363533L),

new System.Numerics.BigInteger(2038476626308233550L),

new System.Numerics.BigInteger(962290393405828009L),

new System.Numerics.BigInteger(1406458910930059302L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5789808596657146553L),

new System.Numerics.BigInteger(6919504079355332481L),

new System.Numerics.BigInteger(6974522204579012103L),

new System.Numerics.BigInteger(4633267199435710612L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3407341241826017613L),

new System.Numerics.BigInteger(4188590406431804322L),

new System.Numerics.BigInteger(2149258709448569139L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5982173449221486327L),

new System.Numerics.BigInteger(6974299323016110747L),

new System.Numerics.BigInteger(8833083909761104264L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(829217902965330888L),

new System.Numerics.BigInteger(483806847593029378L),

new System.Numerics.BigInteger(6586401967179378420L),

new System.Numerics.BigInteger(5164015767727148000L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8375909032486331165L),

new System.Numerics.BigInteger(6932042250585650943L),

new System.Numerics.BigInteger(8550530053076068200L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3691694277116135388L),

new System.Numerics.BigInteger(5882645058094711339L),

new System.Numerics.BigInteger(6965786934337481723L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8487691431061550414L),

new System.Numerics.BigInteger(8944716584152742098L),

new System.Numerics.BigInteger(2210344053720074577L),

new System.Numerics.BigInteger(6768171805787677399L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(142500330685352269L),

new System.Numerics.BigInteger(6582009419272090874L),

new System.Numerics.BigInteger(5656297509251729927L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1021020023975401438L),

new System.Numerics.BigInteger(7799034182770265360L),

new System.Numerics.BigInteger(7883220789799399250L),

new System.Numerics.BigInteger(4022599870625911871L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1056466538859605775L),

new System.Numerics.BigInteger(8204300159655256873L),

new System.Numerics.BigInteger(275589105812689769L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3161557256572176140L),

new System.Numerics.BigInteger(8467187858312331020L),

new System.Numerics.BigInteger(1730569964600323970L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(584627396720099L),

new System.Numerics.BigInteger(679061440993327466L),

new System.Numerics.BigInteger(8047504290526420893L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(690801396270321939L),

new System.Numerics.BigInteger(5876304575578345478L),

new System.Numerics.BigInteger(1152560453693214183L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1352814123825204426L),

new System.Numerics.BigInteger(4154061196936312493L),

new System.Numerics.BigInteger(8300093011378932437L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7552466312544789356L),

new System.Numerics.BigInteger(517786356726073568L),

new System.Numerics.BigInteger(4140499915611628227L),

new System.Numerics.BigInteger(3787756265705602256L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(487272887197720627L),

new System.Numerics.BigInteger(4982514682033853077L),

new System.Numerics.BigInteger(2745949969586224025L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7812262259208388521L),

new System.Numerics.BigInteger(4196918414774764796L),

new System.Numerics.BigInteger(5712453939811071210L),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2mi(
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
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
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

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
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
                List<BigIntegernumericListD1E2M> models = null;

                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericListD1E2M> models = null;

                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr2.Value = 93;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 38, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 119, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 151, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 151, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 87, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 103, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 142);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MI),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericListD1E2M),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
FROM public.binary_bigintegernumericlistd1e2m m
LEFT JOIN public.binary_bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IBigIntegerListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI), typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                await ((IBigIntegerListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                ((IBigIntegerListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

