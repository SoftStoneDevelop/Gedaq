

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9219155819504279d, y: 0.678215251746355d), radius: 0.4806966753314259d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1412440442019396d, y: 0.12111282345972085d), radius: 0.3679303502816069d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30040447574137885d, y: 0.5143899544691688d), radius: 0.558836997639462d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007575378183021231d, y: 0.30789063189316357d), radius: 0.1280068566966659d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031206164431391903d, y: 0.9841087920208471d), radius: 0.9776025389778729d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3451371074662195d, y: 0.184906428572724d), radius: 0.41028568850592395d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8114302273116205d, y: 0.5748859868395083d), radius: 0.41106715904142166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.730054307334189d, y: 0.1528664285210174d), radius: 0.047279211016050704d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7194008647035655d, y: 0.4038667507450652d), radius: 0.6864048063861969d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016673586985605837d, y: 0.3688143370447734d), radius: 0.6253988079015026d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3900131427544399d, y: 0.05258383951624934d), radius: 0.6423842193727745d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07263349979550249d, y: 0.8949841154244316d), radius: 0.11582192946366399d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8436634348120322d, y: 0.20787911416063443d), radius: 0.1788590834330882d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8854220153498947d, y: 0.9562387877126929d), radius: 0.5866841864717465d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4621547215910793d, y: 0.5357056412012045d), radius: 0.32751877984184885d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8685294752543431d, y: 0.8698224573504348d), radius: 0.5946730840821851d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2282408569741209d, y: 0.38992554343618013d), radius: 0.8701721353725995d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31795628237678497d, y: 0.7994977166187948d), radius: 0.6575826567365257d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31887863176385267d, y: 0.0019821228051166706d), radius: 0.6194328060448472d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792246085412436d, y: 0.5286569258101714d), radius: 0.47175297090746915d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8479175461815208d, y: 0.020912215076968055d), radius: 0.5760993416029329d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5735977301127312d, y: 0.2360605907445743d), radius: 0.5055839915373792d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7594839202133808d, y: 0.6861715344094431d), radius: 0.9442209886743743d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6034658687660026d, y: 0.3653111725032364d), radius: 0.47509203695804536d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48749106548807564d, y: 0.1703564354899516d), radius: 0.6818782161662355d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7865652163010632d, y: 0.7380090966397347d), radius: 0.7763175578117071d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41933314169177927d, y: 0.48635452253021205d), radius: 0.557912140548692d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.365401605155135d, y: 0.4310543010068979d), radius: 0.9655165349762774d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0947089615537593d, y: 0.32247339401694397d), radius: 0.9389943657453024d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026318291416872253d, y: 0.7761027667773425d), radius: 0.6053477848510261d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47003228033089217d, y: 0.06593290258822238d), radius: 0.2199513558090146d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7312479475810314d, y: 0.33905441018623506d), radius: 0.3017459207169523d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05798562968109244d, y: 0.9452325847875698d), radius: 0.3233834944247952d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3610401473658096d, y: 0.7699158326264364d), radius: 0.09525680846519191d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.054495471350212155d, y: 0.9016200147849048d), radius: 0.7447998354077452d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.995380808353421d, y: 0.9694832064343049d), radius: 0.9430328662739698d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5929394380531496d, y: 0.1569942218422652d), radius: 0.09036162130338721d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9746968929234185d, y: 0.7304237769005076d), radius: 0.12246587579291823d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8519300324734813d, y: 0.3848529851675486d), radius: 0.0954814999597734d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2703887208450124d, y: 0.6117712310021777d), radius: 0.636179738287997d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7060613452074102d, y: 0.13683410182526956d), radius: 0.4376648969104775d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40634237257689454d, y: 0.9063852893133574d), radius: 0.6137543009145243d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17870699607464802d, y: 0.005696137967577508d), radius: 0.2571912127040852d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3131297647756348d, y: 0.39461853858481044d), radius: 0.057933725380875156d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5071775632624389d, y: 0.20017069876908888d), radius: 0.3437808057170487d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9726487393999274d, y: 0.855548061861001d), radius: 0.8483204512826142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7509498649910676d, y: 0.622303289953248d), radius: 0.6754694287619768d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8718815777144878d, y: 0.8557187164031496d), radius: 0.5092960028259893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5055910819220077d, y: 0.5115049577837227d), radius: 0.10058271113998529d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4283009867412859d, y: 0.6805784167818887d), radius: 0.40099805841491953d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.264395375473104d, y: 0.7471558712731575d), radius: 0.027304352712041235d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.768836096757402d, y: 0.34811761851558365d), radius: 0.5660848216106398d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7065225914181843d, y: 0.887221892158014d), radius: 0.010929366301598242d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6332132121696131d, y: 0.27599885804597d), radius: 0.13371637964034222d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9171357527295673d, y: 0.4028802247834504d), radius: 0.8316732638642763d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6653858191342028d, y: 0.9120720881361083d), radius: 0.9948856775083899d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7526947603268175d, y: 0.8790522805310733d), radius: 0.9281423022701956d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09185670008804714d, y: 0.48873541817557d), radius: 0.8125040499585171d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6007036513531718d, y: 0.13725037422823205d), radius: 0.5594356883372315d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44270929002542714d, y: 0.09432145017308657d), radius: 0.5248918449335948d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8171035505993997d, y: 0.5482640763064802d), radius: 0.04096966025513982d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46241725877028683d, y: 0.0008112496827277216d), radius: 0.22461780083609406d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06588841018450842d, y: 0.47637028126423175d), radius: 0.689369008500048d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4076572977898789d, y: 0.32108950330979624d), radius: 0.08493403839862934d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9150856163518549d, y: 0.5472670446383451d), radius: 0.6015389517648211d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3472227448935091d, y: 0.938303231644493d), radius: 0.13124335845401547d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5445450971001312d, y: 0.2781233096957352d), radius: 0.7925605005018436d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7776544963274227d, y: 0.6786786780174918d), radius: 0.6395771725191574d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7977585852924177d, y: 0.5015814854135288d), radius: 0.6517495657994894d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8827609933230408d, y: 0.7135649974556465d), radius: 0.3097200268613768d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4925036999322967d, y: 0.5121906974371949d), radius: 0.6105525776517277d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8995932965077781d, y: 0.18813286833460585d), radius: 0.5648759401199244d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03481614861294946d, y: 0.3778609194957705d), radius: 0.2513520621238444d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30945326655431005d, y: 0.22614127299760578d), radius: 0.8232502766371221d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5187229213029092d, y: 0.4320736291944973d), radius: 0.8970852186001166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2912326940216664d, y: 0.21396368770564966d), radius: 0.9808466748012972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9428480693254409d, y: 0.6583011319952234d), radius: 0.9582863825960732d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683914888391715d, y: 0.8436231922934975d), radius: 0.47767417454826344d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4750652436972872d, y: 0.33526279740862275d), radius: 0.6074564976790895d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6427307213752035d, y: 0.5584079622583905d), radius: 0.461312220730439d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7405600748640234d, y: 0.4535056576863369d), radius: 0.8804559728575673d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.246734526630214d, y: 0.45965093236318755d), radius: 0.7531034241664403d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49654977321525995d, y: 0.4245148594808861d), radius: 0.5422450349406797d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3620207396035553d, y: 0.8241399863467294d), radius: 0.038799444186267906d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47719645939664956d, y: 0.9517481501280994d), radius: 0.38193643209700656d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3799763746000494d, y: 0.03768141560716365d), radius: 0.06318441562930244d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.725259454901045d, y: 0.13132702204751767d), radius: 0.9632542079070714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3933827116970383d, y: 0.10620167398589464d), radius: 0.26113752032491566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377629823102076d, y: 0.005891281170370077d), radius: 0.6301234121517213d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12151726240148708d, y: 0.7978060114390336d), radius: 0.23162691879163544d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8495449871667463d, y: 0.18777519538403753d), radius: 0.7568582973812132d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8261471260327818d, y: 0.908509943046385d), radius: 0.6528719296105892d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5713027906982759d, y: 0.22508732273068988d), radius: 0.7263646096847275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3768802846780801d, y: 0.44366499408877513d), radius: 0.42270437789623594d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3040031888703786d, y: 0.9836899269200978d), radius: 0.141021482405289d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5497366212142805d, y: 0.21192997874093977d), radius: 0.8040500043459984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7719144171243594d, y: 0.34966902514474907d), radius: 0.8970230397835426d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8189808108534432d, y: 0.6729456782406659d), radius: 0.6494394000584746d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03304709242693771d, y: 0.8782129432588255d), radius: 0.46220898040225156d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4856839958835173d, y: 0.5302478382236046d), radius: 0.606954599793882d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6644756075834648d, y: 0.12153321680450202d), radius: 0.6462388956639066d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8971509901521717d, y: 0.776316834339744d), radius: 0.8107268287450985d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8007337935821018d, y: 0.8361064139820753d), radius: 0.5831463689262592d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3019992061079497d, y: 0.5934538675537292d), radius: 0.3648577784652758d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.061420904015382805d, y: 0.314681146728637d), radius: 0.6586983572855608d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5906327182123385d, y: 0.00369665326165014d), radius: 0.5231629602351118d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11930026016365403d, y: 0.18930945471570038d), radius: 0.024406589561832726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15366061377577722d, y: 0.7425800377231468d), radius: 0.2670268880319444d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46431032154125096d, y: 0.21845391372151124d), radius: 0.724907950610562d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1322791035660923d, y: 0.3497702391497649d), radius: 0.8242468894231137d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38698851648965304d, y: 0.285871738643131d), radius: 0.07823271714288527d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8963712484994012d, y: 0.6268828771360947d), radius: 0.3815711839090201d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9944987887616248d, y: 0.5631157887971764d), radius: 0.7798874211083132d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5911643443171641d, y: 0.49994019809169155d), radius: 0.49671556784792026d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8202723076634234d, y: 0.9360273593447189d), radius: 0.1691484776932931d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38023781842732596d, y: 0.07843214704525958d), radius: 0.3988265903175633d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7464101354113183d, y: 0.46060648885590016d), radius: 0.017705075623891786d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6013331149059913d, y: 0.42866200801028465d), radius: 0.47758196497418137d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48787576343666295d, y: 0.2312697273751848d), radius: 0.11100746851345011d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6215196953657105d, y: 0.8147953694507286d), radius: 0.6426783677113649d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01585837830598269d, y: 0.6122596506655592d), radius: 0.6684337895997987d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15334808799337585d, y: 0.14195839147675948d), radius: 0.6336799106661039d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6774444363201909d, y: 0.31284196513076823d), radius: 0.502443504030612d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9490821888901955d, y: 0.10284355027240966d), radius: 0.38943916557587477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5159675143561709d, y: 0.049927953392374214d), radius: 0.6123574138382819d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6356620514574906d, y: 0.44993214263395487d), radius: 0.16440401200927057d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5764077908067198d, y: 0.6047449396778977d), radius: 0.7486920212600331d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22582552988847715d, y: 0.22497620207582658d), radius: 0.19880496078525767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.745615713687074d, y: 0.4266938284658778d), radius: 0.6870216288019978d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6305338064128172d, y: 0.2387423957057676d), radius: 0.6881080685240935d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5874392765772293d, y: 0.5554651164465387d), radius: 0.9380103147912855d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5264309815246209d, y: 0.23345474387550114d), radius: 0.7121873117626926d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5787620267826876d, y: 0.061535810518309475d), radius: 0.1963059328239043d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7305376046442872d, y: 0.7109449593556609d), radius: 0.6243749279933323d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6640578693926963d, y: 0.8315733840762604d), radius: 0.9402573164764403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9285483189210603d, y: 0.14719543173846417d), radius: 0.8182604714879044d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8361036906315171d, y: 0.7245288831614644d), radius: 0.06899244972029295d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4517792499982758d, y: 0.8980863321351784d), radius: 0.41290245474816933d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.812087562034438d, y: 0.6754400594178644d), radius: 0.6577096269698297d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7162606173637064d, y: 0.3223110192210288d), radius: 0.6396071109577894d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6167949557123145d, y: 0.2778638859944369d), radius: 0.823583750216358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22594552493683584d, y: 0.11641981470202367d), radius: 0.5685103053816538d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44823722816434375d, y: 0.9712693522596696d), radius: 0.21610895353750625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8349860838158264d, y: 0.8403148421347472d), radius: 0.5534192095606746d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28163033432190976d, y: 0.11052409397328256d), radius: 0.18653787560724422d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37724232724312723d, y: 0.910810491634929d), radius: 0.39523651761362977d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.916889087354927d, y: 0.14760727098374438d), radius: 0.5250961080510057d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.831717540417603d, y: 0.15970869491195283d), radius: 0.7193024622937509d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7626531086903026d, y: 0.31181836607741165d), radius: 0.22713854277754753d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21511520285289776d, y: 0.7636795145720958d), radius: 0.5011511759432672d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2006865668734048d, y: 0.10476655352016162d), radius: 0.11878723099038913d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.054789841517579374d, y: 0.7962194184410647d), radius: 0.8599668405014798d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9859742258919784d, y: 0.24285077713765268d), radius: 0.6202233921703274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06525413598404917d, y: 0.24245418454402123d), radius: 0.5573290378639656d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40397442215210255d, y: 0.7735034146938597d), radius: 0.639059521532764d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32730258084583574d, y: 0.48070573980532527d), radius: 0.5760374940790142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03846802092729329d, y: 0.44787192937659237d), radius: 0.28792130482541833d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6630350136950534d, y: 0.44513294386163726d), radius: 0.13141333204823413d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.466448418245641d, y: 0.9769972533392832d), radius: 0.9354972020486799d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9853866946956222d, y: 0.6383314585583347d), radius: 0.9924405094854346d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19364903474583017d, y: 0.17531885237945888d), radius: 0.7550945408633946d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7380288670722804d, y: 0.31983590512261806d), radius: 0.6184560262131167d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22167148336959575d, y: 0.8831820064418082d), radius: 0.1916884170892873d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09120785228952877d, y: 0.6349697447210548d), radius: 0.9346417574749831d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4444768647261812d, y: 0.6281566079900156d), radius: 0.9122692586014092d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10156664163347207d, y: 0.776669629951579d), radius: 0.7691473440430813d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7787351755343058d, y: 0.2949106326501082d), radius: 0.1082448847576648d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4728014899387539d, y: 0.13332524928789058d), radius: 0.21104890624477157d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5373373529367456d, y: 0.4848981962776604d), radius: 0.9639200001113607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4288181844792526d, y: 0.4753540081573818d), radius: 0.460217203700516d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.488518396792068d, y: 0.18256379836701897d), radius: 0.8867600379395495d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7905793574283474d, y: 0.20579324941233312d), radius: 0.10296175981299582d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0020782919751555218d, y: 0.9400395247484781d), radius: 0.6316795166190833d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7466703937286633d, y: 0.7447792137591354d), radius: 0.7240337595863654d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06851808949044302d, y: 0.1905856997712997d), radius: 0.6554387911644236d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0902125810254446d, y: 0.26981152000634034d), radius: 0.8878777768825659d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9707156732132074d, y: 0.33746837871027835d), radius: 0.9286025426918284d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06607533545768562d, y: 0.915669471825435d), radius: 0.5003646080009214d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7465993570474376d, y: 0.658074686251521d), radius: 0.6896894393860054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9161038020228169d, y: 0.7402778748309856d), radius: 0.5890075814427369d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6503502012095451d, y: 0.603842377187553d), radius: 0.8429268602231089d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016861067260577012d, y: 0.4011040877241493d), radius: 0.36367304122488897d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32770337096586977d, y: 0.7149507114004151d), radius: 0.17763151684991285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7442519815477018d, y: 0.6288154371955476d), radius: 0.6995261602584153d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1744656591939191d, y: 0.6959451087776442d), radius: 0.8210122955840314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3424434074247169d, y: 0.07409760181479152d), radius: 0.7497974196335594d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8646385847686032d, y: 0.28623058231661747d), radius: 0.6005983529026039d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8637217545650624d, y: 0.44382780004192157d), radius: 0.02656203568279969d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7529323507519926d, y: 0.14948803581578451d), radius: 0.10543319423298925d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8056611386915782d, y: 0.3482764333836377d), radius: 0.7504479207914335d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8827405136969079d, y: 0.7097370880706342d), radius: 0.3337537637847703d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6352792570206389d, y: 0.5576785611642217d), radius: 0.8522574265287808d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17403812167658217d, y: 0.8301362521280801d), radius: 0.5541660943598754d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9734762049403821d, y: 0.9816505616715627d), radius: 0.17305811535315008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6792343095281059d, y: 0.44914563824342824d), radius: 0.32740076356099834d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4799729549110251d, y: 0.15425330249364033d), radius: 0.793316495530316d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6230013834523338d, y: 0.6449419195266891d), radius: 0.34414953740763554d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2197406257162572d, y: 0.4963770808225474d), radius: 0.5748101202917093d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8628004619644202d, y: 0.5657173243548982d), radius: 0.03602257967811995d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.062429044337212525d, y: 0.6648919051946507d), radius: 0.9489992741558446d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12285779601783309d, y: 0.19008552203933204d), radius: 0.515244265781233d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46662764026300063d, y: 0.6763331315450033d), radius: 0.2178145496410684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1799661052858943d, y: 0.6364935444152316d), radius: 0.7986019562047142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7512595070696191d, y: 0.26745634414709907d), radius: 0.5737034011819193d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.552122648644648d, y: 0.8623010270612337d), radius: 0.14668665617344034d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39759357008990726d, y: 0.5884271222965984d), radius: 0.294353120086869d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43831752227701193d, y: 0.42073494816955503d), radius: 0.256541581727053d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4025028659689317d, y: 0.27451216604268147d), radius: 0.6111042699904657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872674877985147d, y: 0.08873620918051595d), radius: 0.01358531326411494d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4282768520064323d, y: 0.0893320621161221d), radius: 0.5812298711215215d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.500472075609234d, y: 0.01283994749225803d), radius: 0.8930981741996107d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5869898241205017d, y: 0.3599102839554277d), radius: 0.1765214146753875d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6055303381816983d, y: 0.3190556860045266d), radius: 0.6207564820403834d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9683239941759975d, y: 0.2560544373093947d), radius: 0.26582415743490995d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16256350090361138d, y: 0.382781287679669d), radius: 0.9142577050291281d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30616971456151776d, y: 0.7288127901342761d), radius: 0.7896304361629265d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0834483844498013d, y: 0.8600669005669498d), radius: 0.041596581011460354d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2757165433212182d, y: 0.8621363809336209d), radius: 0.07499047299394135d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6759525649739255d, y: 0.8251596501992363d), radius: 0.6301598505252546d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7193532325183968d, y: 0.6046849145303644d), radius: 0.5383102064634222d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20097244008238913d, y: 0.17432793133912916d), radius: 0.6177747298284985d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069671667729795d, y: 0.8825229524383608d), radius: 0.5962163021677666d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45413764860201367d, y: 0.25642697384050195d), radius: 0.9405012781292376d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.806414416276568d, y: 0.8507844612299521d), radius: 0.6923386789268176d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2415000338871892d, y: 0.34372981750733844d), radius: 0.2970838477679081d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25743812619262263d, y: 0.9686353126720622d), radius: 0.49035652239045413d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4046557369240993d, y: 0.06206890165994772d), radius: 0.044005573672421305d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6460363822290321d, y: 0.25751050414388743d), radius: 0.012943523384760569d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5239826132789347d, y: 0.2153402024915817d), radius: 0.9295697761186923d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28896433809032196d, y: 0.0891162710304454d), radius: 0.18160300122830142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2535601411506748d, y: 0.8833265787678272d), radius: 0.7593323670758979d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.658945645036906d, y: 0.7136366438791502d), radius: 0.13179544519099862d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15948899006203088d, y: 0.9627361389409352d), radius: 0.17493608160165175d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9273935449974935d, y: 0.9166031729779551d), radius: 0.851194705132923d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16243986638367747d, y: 0.05346837443142005d), radius: 0.8841419124030236d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46665692008700055d, y: 0.161824115667754d), radius: 0.3024624842383492d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11314086327083006d, y: 0.5022507981329015d), radius: 0.4419123394388528d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8585745733203878d, y: 0.0773962218695241d), radius: 0.6333920839704866d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7542740469123634d, y: 0.2971596518870654d), radius: 0.7079061273850363d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9455150041720048d, y: 0.6400232542676897d), radius: 0.1924773440952503d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3709212553720004d, y: 0.45585845226360344d), radius: 0.9335461926157944d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9086454428125125d, y: 0.7890218691285575d), radius: 0.11918903435266193d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5431160390472757d, y: 0.6358580248606199d), radius: 0.8345039887630611d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4984980563008856d, y: 0.6081916093822723d), radius: 0.2775605991037451d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34896130991230145d, y: 0.6839930535477811d), radius: 0.46560127975449916d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7379731606015564d, y: 0.90065594604579d), radius: 0.32865608290439785d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6816147258296451d, y: 0.4184471475112944d), radius: 0.4641605380925813d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026775279844455713d, y: 0.7254235871617483d), radius: 0.8510175410344419d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6508186468476409d, y: 0.8345090208260934d), radius: 0.9855565254035542d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19407138468788054d, y: 0.5577182809287096d), radius: 0.04905121780428612d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050548370641466d, y: 0.6581856850278207d), radius: 0.12127943272476494d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9542372768853452d, y: 0.040522836352127944d), radius: 0.069617791721301d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8500001608276553d, y: 0.48312684121042415d), radius: 0.8191623857292475d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6263139567502732d, y: 0.8631359698495442d), radius: 0.6144674162789157d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21168928917687435d, y: 0.8271530032749165d), radius: 0.8850474419960099d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8271078636434158d, y: 0.14384484551209475d), radius: 0.4246038689834142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12249584124336765d, y: 0.28146848146973436d), radius: 0.5410145691075878d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17963183003322525d, y: 0.9077147071664501d), radius: 0.05738014823092341d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17426367231630624d, y: 0.22769685622923685d), radius: 0.9149155492339189d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5794854213228191d, y: 0.9500299640751039d), radius: 0.7196176115201486d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007883255084127017d, y: 0.4689957705834499d), radius: 0.623614757490466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14065517688132378d, y: 0.618035154967123d), radius: 0.41903327322587314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32941619007711054d, y: 0.7449100737188504d), radius: 0.12019152472408523d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18543251873699407d, y: 0.6680572762213441d), radius: 0.6291745963954696d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4292776700471418d, y: 0.315155758292362d), radius: 0.2467467741343985d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.669734883651208d, y: 0.9942220464804923d), radius: 0.9601195943458363d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1267683943694593d, y: 0.20674028181924642d), radius: 0.4692571801872688d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7621487297896845d, y: 0.8437513834736282d), radius: 0.07851381073501129d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7508869463363839d, y: 0.4830469832704698d), radius: 0.08955909762475489d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.50077763649863d, y: 0.6840041791094702d), radius: 0.33448549440476205d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 115, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 3, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 24, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 57, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 1, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 23, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 53, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 72, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI), typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                await ((INpgsqlCircleListcircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                ((INpgsqlCircleListcircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

