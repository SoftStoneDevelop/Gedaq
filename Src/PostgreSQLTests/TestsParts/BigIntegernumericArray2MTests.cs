

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
    internal partial interface IBigIntegerListnumericArray
    {
    }
    
    internal partial class BigIntegerListnumericArray : IBigIntegerListnumericArray
    {


#region TestData

        private readonly BigIntegernumericArray2M[] _testData = new BigIntegernumericArray2M[]
        {
            new BigIntegernumericArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2113399340774900225L),

new System.Numerics.BigInteger(1997981445086922746L),

new System.Numerics.BigInteger(3817956323605404093L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7769812327053852593L),

new System.Numerics.BigInteger(9071595963833078014L),

new System.Numerics.BigInteger(5668247900797821282L),

new System.Numerics.BigInteger(3351014752231280245L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4737503805779128765L),

new System.Numerics.BigInteger(4008556832662119750L),

new System.Numerics.BigInteger(4715030196243120821L),

new System.Numerics.BigInteger(4264542521104861642L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6287364930449798147L),

new System.Numerics.BigInteger(7595723554592433015L),

new System.Numerics.BigInteger(7726558891426074626L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3867501680975294783L),

new System.Numerics.BigInteger(5636351122948864534L),

new System.Numerics.BigInteger(3326204337323253992L),

new System.Numerics.BigInteger(534025829915752048L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6982764456020063560L),

new System.Numerics.BigInteger(6327963160447061306L),

new System.Numerics.BigInteger(2015115415509024611L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3538590618844713116L),

new System.Numerics.BigInteger(1948509923687531301L),

new System.Numerics.BigInteger(4951520745791636746L),

},
},
            new BigIntegernumericArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8503946628356998084L),

new System.Numerics.BigInteger(7637307323822391588L),

new System.Numerics.BigInteger(6079739097363179799L),

new System.Numerics.BigInteger(3235551716129692433L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4794147530037022233L),

new System.Numerics.BigInteger(7979855821789603196L),

new System.Numerics.BigInteger(3331662381201017776L),

new System.Numerics.BigInteger(8696165584462435879L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7414621471961852194L),

new System.Numerics.BigInteger(628608172421074615L),

new System.Numerics.BigInteger(2092062910418977954L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3283592169042944080L),

new System.Numerics.BigInteger(1725989472462946307L),

new System.Numerics.BigInteger(752446931946597949L),

},
},
            new BigIntegernumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5642492791066657443L),

new System.Numerics.BigInteger(2706352379040462245L),

new System.Numerics.BigInteger(1359902786039858889L),

new System.Numerics.BigInteger(1423861814555967749L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(418419762942578227L),

new System.Numerics.BigInteger(1164267363733337168L),

new System.Numerics.BigInteger(6789333617135580993L),

new System.Numerics.BigInteger(712267381267767164L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5208761011389375914L),

new System.Numerics.BigInteger(1985485411947623402L),

new System.Numerics.BigInteger(3650463335715797878L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7853771688290380228L),

new System.Numerics.BigInteger(1630548576255210560L),

new System.Numerics.BigInteger(7580684165956093560L),

new System.Numerics.BigInteger(8605207528846378895L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5164839373884274048L),

new System.Numerics.BigInteger(7829828720858930325L),

new System.Numerics.BigInteger(5193192253736109482L),

},
},
            new BigIntegernumericArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4703423553039637191L),

new System.Numerics.BigInteger(3059311736923180562L),

new System.Numerics.BigInteger(4091899568540492089L),

new System.Numerics.BigInteger(5436804009015498433L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8844365378458575510L),

new System.Numerics.BigInteger(3011468217720139405L),

new System.Numerics.BigInteger(8692040189468748824L),

new System.Numerics.BigInteger(8074105496913586961L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4938690402907961440L),

new System.Numerics.BigInteger(4967880336669348747L),

new System.Numerics.BigInteger(3473509803293228557L),

new System.Numerics.BigInteger(1227038980932317828L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8444261224753168744L),

new System.Numerics.BigInteger(3959487101542031959L),

new System.Numerics.BigInteger(2207981831701000593L),

new System.Numerics.BigInteger(8810376792305069226L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2248753777354626752L),

new System.Numerics.BigInteger(2401498716983238013L),

new System.Numerics.BigInteger(887418526215687511L),

},
},
            new BigIntegernumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2436471336978835709L),

new System.Numerics.BigInteger(8858996756932636353L),

new System.Numerics.BigInteger(2093590853924318104L),

new System.Numerics.BigInteger(8496143528659513509L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5045535645485895626L),

new System.Numerics.BigInteger(6120897713072838471L),

new System.Numerics.BigInteger(4506703860286307336L),

new System.Numerics.BigInteger(3677477741832552060L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2474589052230796385L),

new System.Numerics.BigInteger(4447264140344285794L),

new System.Numerics.BigInteger(1056217433181868925L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5361738214007398043L),

new System.Numerics.BigInteger(3637735403943005084L),

new System.Numerics.BigInteger(4724142215436186053L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2961682118726831211L),

new System.Numerics.BigInteger(2385472601459662168L),

new System.Numerics.BigInteger(1252154556038770808L),

new System.Numerics.BigInteger(6615242139279300806L),

},
},
            new BigIntegernumericArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8553557312918432128L),

new System.Numerics.BigInteger(228728257360506618L),

new System.Numerics.BigInteger(3040764673104339806L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8557161648723388434L),

new System.Numerics.BigInteger(3282031212824119803L),

new System.Numerics.BigInteger(3511614172549298342L),

new System.Numerics.BigInteger(923227402653295796L),

},
},
            new BigIntegernumericArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7872872927201612694L),

new System.Numerics.BigInteger(8227254949981394690L),

new System.Numerics.BigInteger(220340507876012406L),

new System.Numerics.BigInteger(2003895428364928458L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5751996453544299244L),

new System.Numerics.BigInteger(4566265904951240162L),

new System.Numerics.BigInteger(6394862982672273149L),

new System.Numerics.BigInteger(100678183791082167L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8418520977452880497L),

new System.Numerics.BigInteger(4294609044235737738L),

new System.Numerics.BigInteger(1359438967705266490L),

new System.Numerics.BigInteger(1295518808834845404L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3766743011261594379L),

new System.Numerics.BigInteger(5123506567917016847L),

new System.Numerics.BigInteger(9060183523226260094L),

new System.Numerics.BigInteger(5729002173293204717L),

},
},
            new BigIntegernumericArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2719007477987390438L),

new System.Numerics.BigInteger(5510131106495433968L),

new System.Numerics.BigInteger(6849555627548061546L),

new System.Numerics.BigInteger(8673221623815289862L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(293666964208723142L),

new System.Numerics.BigInteger(1605880331550311962L),

new System.Numerics.BigInteger(1755656983622182110L),

new System.Numerics.BigInteger(99589080385812119L),

},
},
            new BigIntegernumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4938790384119760463L),

new System.Numerics.BigInteger(7067646962562023254L),

new System.Numerics.BigInteger(4334754475252102482L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7560667043143450387L),

new System.Numerics.BigInteger(7680233813149785489L),

new System.Numerics.BigInteger(3172470751845428295L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8516179029160509954L),

new System.Numerics.BigInteger(8035089267236235338L),

new System.Numerics.BigInteger(6309644866684104052L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7872043707799523867L),

new System.Numerics.BigInteger(1865922078547446020L),

new System.Numerics.BigInteger(5638540099565144810L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3955729288272882598L),

new System.Numerics.BigInteger(8864821393768956047L),

new System.Numerics.BigInteger(1843414361129872696L),

},
},
            new BigIntegernumericArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(979553360015524379L),

new System.Numerics.BigInteger(6805942599356663327L),

new System.Numerics.BigInteger(3455181643728164408L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5950359958424633441L),

new System.Numerics.BigInteger(5711179401789971521L),

new System.Numerics.BigInteger(8464197605003500769L),

new System.Numerics.BigInteger(7297267801425959904L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7986413805669304071L),

new System.Numerics.BigInteger(8902844637642211257L),

new System.Numerics.BigInteger(2455820124696571543L),

new System.Numerics.BigInteger(7625961910789221516L),

},
},
            new BigIntegernumericArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4379397548847320538L),

new System.Numerics.BigInteger(1113005674256101099L),

new System.Numerics.BigInteger(7602330488660269304L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3344063839375748294L),

new System.Numerics.BigInteger(1665726844803193181L),

new System.Numerics.BigInteger(7172604073697979609L),

new System.Numerics.BigInteger(4899181430901073258L),

},
},
            new BigIntegernumericArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756432687361823449L),

new System.Numerics.BigInteger(7192506303884184923L),

new System.Numerics.BigInteger(5670879959437485237L),

new System.Numerics.BigInteger(6520155476948878975L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3333592096416673497L),

new System.Numerics.BigInteger(1072012253295356101L),

new System.Numerics.BigInteger(7268175509834713463L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6014545818283552059L),

new System.Numerics.BigInteger(5890463801583843917L),

new System.Numerics.BigInteger(3166064626866985694L),

},
},
            new BigIntegernumericArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5943896819256432323L),

new System.Numerics.BigInteger(8483990850997184884L),

new System.Numerics.BigInteger(6040433394191790302L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7653415834013080643L),

new System.Numerics.BigInteger(7083062416726910810L),

new System.Numerics.BigInteger(3880528525782884240L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3048249981660721768L),

new System.Numerics.BigInteger(6316231060062082202L),

new System.Numerics.BigInteger(6200715081575848934L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4507496486448382088L),

new System.Numerics.BigInteger(119322441267472476L),

new System.Numerics.BigInteger(862028007666419013L),

new System.Numerics.BigInteger(397481707259708895L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5751060010700886338L),

new System.Numerics.BigInteger(9086528400139084484L),

new System.Numerics.BigInteger(8741825979699054226L),

new System.Numerics.BigInteger(6072706262912253589L),

},
},
            new BigIntegernumericArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(611094442406171081L),

new System.Numerics.BigInteger(8479148873634580252L),

new System.Numerics.BigInteger(519441857331159068L),

new System.Numerics.BigInteger(5136842878996476290L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5073675557993642090L),

new System.Numerics.BigInteger(4468686557482875921L),

new System.Numerics.BigInteger(7368281161082854252L),

new System.Numerics.BigInteger(1070300604649517672L),

},
},
            new BigIntegernumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1197899592677440412L),

new System.Numerics.BigInteger(6923687729166337110L),

new System.Numerics.BigInteger(351596367741948204L),

new System.Numerics.BigInteger(8743852407196204123L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4607663342155814300L),

new System.Numerics.BigInteger(5904709722339204177L),

new System.Numerics.BigInteger(566406938972777683L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8468311988714216972L),

new System.Numerics.BigInteger(2929103685471668914L),

new System.Numerics.BigInteger(8723854634964791878L),

new System.Numerics.BigInteger(1732667921161956605L),

},
},
            new BigIntegernumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8928945157048697700L),

new System.Numerics.BigInteger(8349683642877620113L),

new System.Numerics.BigInteger(4753884402908392746L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2938788822964631207L),

new System.Numerics.BigInteger(7548158911576300379L),

new System.Numerics.BigInteger(700156442868836065L),

new System.Numerics.BigInteger(9218216381281210234L),

},
},
            new BigIntegernumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(24722258495661743L),

new System.Numerics.BigInteger(2549411780497804145L),

new System.Numerics.BigInteger(246295835766325813L),

new System.Numerics.BigInteger(8010495401014550321L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1095101811546638581L),

new System.Numerics.BigInteger(5133369192419351794L),

new System.Numerics.BigInteger(2504742422718720927L),

new System.Numerics.BigInteger(7116801752233629539L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7795989746713005215L),

new System.Numerics.BigInteger(2101932586709605013L),

new System.Numerics.BigInteger(2870412336477587501L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7080203484014688048L),

new System.Numerics.BigInteger(1528981209216644464L),

new System.Numerics.BigInteger(3856201230933765724L),

new System.Numerics.BigInteger(2348558247730588029L),

},
},
            new BigIntegernumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7343485833634440701L),

new System.Numerics.BigInteger(1827211121414948637L),

new System.Numerics.BigInteger(5849912471064982992L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1048087608388980200L),

new System.Numerics.BigInteger(4455772996469921856L),

new System.Numerics.BigInteger(8768767587678894172L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6039739270876250482L),

new System.Numerics.BigInteger(3377341325339576235L),

new System.Numerics.BigInteger(6094020869178304067L),

new System.Numerics.BigInteger(7940279766322968891L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5508075661146863601L),

new System.Numerics.BigInteger(8183726389188283463L),

new System.Numerics.BigInteger(2999472219502576282L),

new System.Numerics.BigInteger(2941283339694038773L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7489462531797563899L),

new System.Numerics.BigInteger(4511838961493609894L),

new System.Numerics.BigInteger(7061337180496815984L),

new System.Numerics.BigInteger(7791992399216650432L),

},
},
            new BigIntegernumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5241285636870896612L),

new System.Numerics.BigInteger(5150575565112822984L),

new System.Numerics.BigInteger(5623506148297984370L),

new System.Numerics.BigInteger(6846640617094628502L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4869191296970488874L),

new System.Numerics.BigInteger(8867672236496180521L),

new System.Numerics.BigInteger(4407940865272063713L),

},
},
            new BigIntegernumericArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(222658545351368802L),

new System.Numerics.BigInteger(223655612400715292L),

new System.Numerics.BigInteger(7873518949398475824L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8609204987431957982L),

new System.Numerics.BigInteger(72187188077472530L),

new System.Numerics.BigInteger(4901888391582772279L),

new System.Numerics.BigInteger(6995514057621834704L),

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
INSERT INTO public.bigintegernumericarray2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
INSERT INTO public.bigintegernumericarray2mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericArray)), 
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
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                List<BigIntegernumericArray2M> models = null;

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray2M> models = null;

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 62, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 31, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 71, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 56, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 83, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 13, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 105, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[29], false);
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
                await using var cmd = await ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
BigIntegernumericArray2M.AssertModel(models[0],_testData[2], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[3], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[4], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[5], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[6], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[7], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[23],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[24],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[25],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[26],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
BigIntegernumericArray2M.AssertModel(models[0],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
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
                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
FROM public.binary_bigintegernumericarray2m m
LEFT JOIN public.binary_bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray2M>(15);

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
                ((IBigIntegerListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IBigIntegerListnumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IBigIntegerListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[23],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[24],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[25],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[26],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[27],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[28],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

