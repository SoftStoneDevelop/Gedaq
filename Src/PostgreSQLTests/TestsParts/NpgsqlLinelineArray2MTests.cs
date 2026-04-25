

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.289599514505804d, b: 0.9843005364676124d, c: 0.9433649443560044d),

new NpgsqlTypes.NpgsqlLine(a: 0.45560744848638635d, b: 0.6408871566866167d, c: 0.1064039754310111d),

new NpgsqlTypes.NpgsqlLine(a: 0.7599850066942092d, b: 0.7833699104911784d, c: 0.6191168563596667d),

new NpgsqlTypes.NpgsqlLine(a: 0.14212256930568912d, b: 0.23605388240836056d, c: 0.6953079297614753d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19781546697368546d, b: 0.7320372364972859d, c: 0.20342179222312495d),

new NpgsqlTypes.NpgsqlLine(a: 0.9511963158823189d, b: 0.8987210950692665d, c: 0.7837591602868822d),

new NpgsqlTypes.NpgsqlLine(a: 0.7810052388629789d, b: 0.19333561476111705d, c: 0.921748398508914d),

new NpgsqlTypes.NpgsqlLine(a: 0.9519213400379887d, b: 0.40874527572720365d, c: 0.6240958346422333d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8828778513549124d, b: 0.7773176842191363d, c: 0.6385737661922418d),

new NpgsqlTypes.NpgsqlLine(a: 0.9497629287804213d, b: 0.5530064209242629d, c: 0.12716726450809546d),

new NpgsqlTypes.NpgsqlLine(a: 0.6810298789366599d, b: 0.5589649952594246d, c: 0.6347989473017467d),

new NpgsqlTypes.NpgsqlLine(a: 0.15435743050163553d, b: 0.7604368166938744d, c: 0.9406376992961485d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5918555441269363d, b: 0.15343804786076132d, c: 0.17902964038503744d),

new NpgsqlTypes.NpgsqlLine(a: 0.2039782896270399d, b: 0.3329189543954584d, c: 0.3093825735837752d),

new NpgsqlTypes.NpgsqlLine(a: 0.3598460554262841d, b: 0.5608060618641104d, c: 0.1381173138354329d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07973743651966203d, b: 0.8888241406832785d, c: 0.5280095637051107d),

new NpgsqlTypes.NpgsqlLine(a: 0.1092368739890548d, b: 0.6524442414863855d, c: 0.9474444859741652d),

new NpgsqlTypes.NpgsqlLine(a: 0.2543520092819417d, b: 0.36355365832632236d, c: 0.02638602141285684d),

new NpgsqlTypes.NpgsqlLine(a: 0.6796650102959617d, b: 0.8876692910524508d, c: 0.6531586268564531d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5054633901555103d, b: 0.4519533310622137d, c: 0.8461161737061764d),

new NpgsqlTypes.NpgsqlLine(a: 0.7202786909895813d, b: 0.30999390426632734d, c: 0.4289750891786994d),

new NpgsqlTypes.NpgsqlLine(a: 0.4035130703877915d, b: 0.9806018627586661d, c: 0.9457451608047082d),

new NpgsqlTypes.NpgsqlLine(a: 0.982757576477799d, b: 0.9378549448842345d, c: 0.024012225021325495d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6665467561866536d, b: 0.919258590440128d, c: 0.7526802983863978d),

new NpgsqlTypes.NpgsqlLine(a: 0.584294937812393d, b: 0.9703364225458825d, c: 0.09858272535113022d),

new NpgsqlTypes.NpgsqlLine(a: 0.8142343780086156d, b: 0.4790427345829745d, c: 0.21444966754223793d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32898142733780855d, b: 0.2893129996079328d, c: 0.3124775208866978d),

new NpgsqlTypes.NpgsqlLine(a: 0.20717038626457507d, b: 0.4994200429314679d, c: 0.6739777865229255d),

new NpgsqlTypes.NpgsqlLine(a: 0.46721127119949146d, b: 0.05066953250256734d, c: 0.5105444587910041d),

new NpgsqlTypes.NpgsqlLine(a: 0.9859388361736078d, b: 0.4088689506739114d, c: 0.9673516441441222d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9033629152820686d, b: 0.6554645615701249d, c: 0.5645475277610847d),

new NpgsqlTypes.NpgsqlLine(a: 0.02901289634579096d, b: 0.9917836014799568d, c: 0.17141654044702692d),

new NpgsqlTypes.NpgsqlLine(a: 0.7935947119995376d, b: 0.06357973672495498d, c: 0.36384921475546617d),

new NpgsqlTypes.NpgsqlLine(a: 0.18928208310298655d, b: 0.39683370701403753d, c: 0.5809377863830293d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20554103246047295d, b: 0.13416604565563084d, c: 0.427415795542592d),

new NpgsqlTypes.NpgsqlLine(a: 0.3062388838464891d, b: 0.9623686209345187d, c: 0.1169218977106189d),

new NpgsqlTypes.NpgsqlLine(a: 0.5045144233465275d, b: 0.8409381380886577d, c: 0.9892652788018265d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7320765271687011d, b: 0.26796976553150764d, c: 0.7310318334358152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5324801593274373d, b: 0.24546270107343082d, c: 0.7687369975235714d),

new NpgsqlTypes.NpgsqlLine(a: 0.055099315725763875d, b: 0.7713451615345573d, c: 0.9844936055325972d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9251085670216983d, b: 0.29989782809972876d, c: 0.33333167907399575d),

new NpgsqlTypes.NpgsqlLine(a: 0.749903304573504d, b: 0.7905149858936295d, c: 0.7698330711101998d),

new NpgsqlTypes.NpgsqlLine(a: 0.9692198415281418d, b: 0.8641913409251636d, c: 0.20009210370777386d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30360283883287753d, b: 0.8244555855305945d, c: 0.9878455776360339d),

new NpgsqlTypes.NpgsqlLine(a: 0.36965787610308454d, b: 0.9851808360955884d, c: 0.7902402757068907d),

new NpgsqlTypes.NpgsqlLine(a: 0.7916530742613489d, b: 0.8742858837749349d, c: 0.8117585749780258d),

new NpgsqlTypes.NpgsqlLine(a: 0.9722174365929633d, b: 0.056706224765309066d, c: 0.06854809978526899d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4949690878665389d, b: 0.010496364671437552d, c: 0.3680514677891834d),

new NpgsqlTypes.NpgsqlLine(a: 0.9148643620705086d, b: 0.4340913024266332d, c: 0.9493874624134035d),

new NpgsqlTypes.NpgsqlLine(a: 0.4301126207314103d, b: 0.635289107149439d, c: 0.594301053504901d),

new NpgsqlTypes.NpgsqlLine(a: 0.3026595513959237d, b: 0.7490366579241318d, c: 0.7298193540804278d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08686547948251555d, b: 0.08409323040178662d, c: 0.6101215982549106d),

new NpgsqlTypes.NpgsqlLine(a: 0.923404549320767d, b: 0.44880330688592396d, c: 0.576551108902739d),

new NpgsqlTypes.NpgsqlLine(a: 0.28266193795282757d, b: 0.9328799811549014d, c: 0.047161883603534904d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436983602402198d, b: 0.858964223593383d, c: 0.897940631540299d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.707140576295481d, b: 0.6197129307541366d, c: 0.8314261602231684d),

new NpgsqlTypes.NpgsqlLine(a: 0.15864872330667745d, b: 0.3245904893999243d, c: 0.21364242210867357d),

new NpgsqlTypes.NpgsqlLine(a: 0.8346674248144776d, b: 0.2816750515568499d, c: 0.13016748270731637d),

new NpgsqlTypes.NpgsqlLine(a: 0.6453788235322382d, b: 0.9780869647437063d, c: 0.5868982187627592d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26852139291810695d, b: 0.9555369869826384d, c: 0.6883005665973909d),

new NpgsqlTypes.NpgsqlLine(a: 0.7070731187931124d, b: 0.5514239158391342d, c: 0.7303611562920876d),

new NpgsqlTypes.NpgsqlLine(a: 0.6166850822116855d, b: 0.4908238938773455d, c: 0.10873160413439709d),

new NpgsqlTypes.NpgsqlLine(a: 0.002281403526774084d, b: 0.9034990672902258d, c: 0.6819974089863822d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06387292433833358d, b: 0.5020336735129227d, c: 0.13459709725049063d),

new NpgsqlTypes.NpgsqlLine(a: 0.8499316640790222d, b: 0.811895247248827d, c: 0.6360205676179266d),

new NpgsqlTypes.NpgsqlLine(a: 0.5131068348574651d, b: 0.2737237871932694d, c: 0.030383322504064614d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5795732854364852d, b: 0.1906822326446833d, c: 0.750508386014687d),

new NpgsqlTypes.NpgsqlLine(a: 0.2356443645102413d, b: 0.29473862261027706d, c: 0.48904838415238816d),

new NpgsqlTypes.NpgsqlLine(a: 0.8453094721304547d, b: 0.8780368805408254d, c: 0.5880381945846838d),

new NpgsqlTypes.NpgsqlLine(a: 0.4448897781428741d, b: 0.5227920146599869d, c: 0.5946398678216063d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15036340496526834d, b: 0.6356020098493947d, c: 0.6312461356240127d),

new NpgsqlTypes.NpgsqlLine(a: 0.4460793780339457d, b: 0.3151798592847399d, c: 0.05567703122449852d),

new NpgsqlTypes.NpgsqlLine(a: 0.424819521471804d, b: 0.9080525462641849d, c: 0.14068478488128955d),

new NpgsqlTypes.NpgsqlLine(a: 0.10049974906017367d, b: 0.970147698686115d, c: 0.5267418402661825d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5658488973347592d, b: 0.1748227606976276d, c: 0.4224591853881d),

new NpgsqlTypes.NpgsqlLine(a: 0.023657492182158957d, b: 0.63023874014827d, c: 0.43745441191902257d),

new NpgsqlTypes.NpgsqlLine(a: 0.166159592475994d, b: 0.9112467193381832d, c: 0.34549568270445286d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36464956138318816d, b: 0.44851024916359783d, c: 0.7552962599854663d),

new NpgsqlTypes.NpgsqlLine(a: 0.6711970339353147d, b: 0.3874359529453715d, c: 0.17476734936654503d),

new NpgsqlTypes.NpgsqlLine(a: 0.5117311126125339d, b: 0.9035669066854543d, c: 0.37105461981881815d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7751758619164335d, b: 0.3730710836845964d, c: 0.9992807982927026d),

new NpgsqlTypes.NpgsqlLine(a: 0.7799217804062492d, b: 0.16689719684192694d, c: 0.469097289262863d),

new NpgsqlTypes.NpgsqlLine(a: 0.33930619866929124d, b: 0.05660576615844015d, c: 0.7601271509748271d),

new NpgsqlTypes.NpgsqlLine(a: 0.7079886762024311d, b: 0.24045072686997937d, c: 0.7130403258669256d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3568827642903224d, b: 0.5742717915465625d, c: 0.4673081629937683d),

new NpgsqlTypes.NpgsqlLine(a: 0.2969879965640566d, b: 0.48764410222495425d, c: 0.7947388347130392d),

new NpgsqlTypes.NpgsqlLine(a: 0.9187113470164996d, b: 0.1318192256532239d, c: 0.775828047000516d),

new NpgsqlTypes.NpgsqlLine(a: 0.7028915837855744d, b: 0.43013900313594455d, c: 0.8665265377298846d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5565467868774173d, b: 0.6932500485742968d, c: 0.16777879818303287d),

new NpgsqlTypes.NpgsqlLine(a: 0.7182071197647044d, b: 0.39057714367190766d, c: 0.08319721350868281d),

new NpgsqlTypes.NpgsqlLine(a: 0.07955271967343203d, b: 0.9984416587764617d, c: 0.21160821298282728d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7202660035870355d, b: 0.6742847467666135d, c: 0.9241710872026832d),

new NpgsqlTypes.NpgsqlLine(a: 0.27020363964756444d, b: 0.4993978886466274d, c: 0.15419625064823617d),

new NpgsqlTypes.NpgsqlLine(a: 0.011517240983334398d, b: 0.5071923860028764d, c: 0.004768266688673806d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03255699467226647d, b: 0.5484956817089277d, c: 0.2811937535874849d),

new NpgsqlTypes.NpgsqlLine(a: 0.5369403360537497d, b: 0.5814652409274571d, c: 0.28233467986393135d),

new NpgsqlTypes.NpgsqlLine(a: 0.8250978588448178d, b: 0.43817179228161784d, c: 0.5882849342918932d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2593466304641082d, b: 0.9814280534746782d, c: 0.6145524334282243d),

new NpgsqlTypes.NpgsqlLine(a: 0.9429296337468478d, b: 0.3913586113045804d, c: 0.4338041961575554d),

new NpgsqlTypes.NpgsqlLine(a: 0.5335455294129182d, b: 0.7420003411796972d, c: 0.33601965129146016d),

new NpgsqlTypes.NpgsqlLine(a: 0.5550087939940759d, b: 0.027727757849452028d, c: 0.8136397866780832d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25590773995198146d, b: 0.6479233486675846d, c: 0.31938193599890663d),

new NpgsqlTypes.NpgsqlLine(a: 0.7363656138246157d, b: 0.1320008700155203d, c: 0.7328752547754829d),

new NpgsqlTypes.NpgsqlLine(a: 0.26391575915952004d, b: 0.3403349620235736d, c: 0.09179245474357522d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7924381577019516d, b: 0.43991518424517906d, c: 0.9447692813045285d),

new NpgsqlTypes.NpgsqlLine(a: 0.18579249945707677d, b: 0.6420973290597781d, c: 0.27072454098964205d),

new NpgsqlTypes.NpgsqlLine(a: 0.4369396064891856d, b: 0.19007456929121624d, c: 0.017631428801744398d),

new NpgsqlTypes.NpgsqlLine(a: 0.10157770701521296d, b: 0.2889716770672782d, c: 0.31964958087909723d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8502535200328485d, b: 0.3628593270120062d, c: 0.4446141869257897d),

new NpgsqlTypes.NpgsqlLine(a: 0.3252707710393372d, b: 0.3162359979463083d, c: 0.6988529835029229d),

new NpgsqlTypes.NpgsqlLine(a: 0.6995303607999364d, b: 0.12306119966204088d, c: 0.49648733003046575d),

new NpgsqlTypes.NpgsqlLine(a: 0.46998585094397904d, b: 0.006794162302393936d, c: 0.19180979562304512d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.087855739053736d, b: 0.13837598015660602d, c: 0.08205906713121314d),

new NpgsqlTypes.NpgsqlLine(a: 0.21994048124716792d, b: 0.7685455919264563d, c: 0.8757996803965233d),

new NpgsqlTypes.NpgsqlLine(a: 0.4241506332934789d, b: 0.3628038455048499d, c: 0.11138457264293122d),

new NpgsqlTypes.NpgsqlLine(a: 0.19711891756167588d, b: 0.3450664319950736d, c: 0.38658472924756615d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28196137894926754d, b: 0.708904722049219d, c: 0.5465985052684388d),

new NpgsqlTypes.NpgsqlLine(a: 0.31771804731076625d, b: 0.7507207534979712d, c: 0.6885614846547842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8297216519700527d, b: 0.32560895751322627d, c: 0.7152610621409524d),

new NpgsqlTypes.NpgsqlLine(a: 0.07401721690600271d, b: 0.018775079633928216d, c: 0.6694383876413689d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7256716756317169d, b: 0.46870596542872534d, c: 0.26969536759316237d),

new NpgsqlTypes.NpgsqlLine(a: 0.15272213114210498d, b: 0.3042702010574514d, c: 0.7078242556172228d),

new NpgsqlTypes.NpgsqlLine(a: 0.43578398099841853d, b: 0.11747104361256655d, c: 0.2096109386282352d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3897984236066885d, b: 0.5604257242695024d, c: 0.298733733385678d),

new NpgsqlTypes.NpgsqlLine(a: 0.9586730089987722d, b: 0.8152910078324841d, c: 0.8929726837271822d),

new NpgsqlTypes.NpgsqlLine(a: 0.18529874128848478d, b: 0.5319007808064774d, c: 0.23850988535075868d),

new NpgsqlTypes.NpgsqlLine(a: 0.18524146791642226d, b: 0.19819068517116956d, c: 0.41104912303538177d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9299738221709453d, b: 0.0871004452457208d, c: 0.0420173255069618d),

new NpgsqlTypes.NpgsqlLine(a: 0.8367386097280343d, b: 0.054847804277476264d, c: 0.43801202367241765d),

new NpgsqlTypes.NpgsqlLine(a: 0.5705029974009782d, b: 0.7387240393085138d, c: 0.7531008642382093d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6616256782344455d, b: 0.7414063876871367d, c: 0.6063083389434321d),

new NpgsqlTypes.NpgsqlLine(a: 0.35399474115379115d, b: 0.028342210575292404d, c: 0.9690227315576658d),

new NpgsqlTypes.NpgsqlLine(a: 0.7878940044701817d, b: 0.8606553608166967d, c: 0.9964408903965994d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8463520628900217d, b: 0.2510694566754498d, c: 0.1324327265596087d),

new NpgsqlTypes.NpgsqlLine(a: 0.8991789254488636d, b: 0.397975069249076d, c: 0.9991577416133532d),

new NpgsqlTypes.NpgsqlLine(a: 0.36238146752138556d, b: 0.012973686956640695d, c: 0.9608601204743823d),

new NpgsqlTypes.NpgsqlLine(a: 0.44097625945248287d, b: 0.2632426953919147d, c: 0.7351177684436804d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4322827228218572d, b: 0.47034691572829346d, c: 0.3907522230256575d),

new NpgsqlTypes.NpgsqlLine(a: 0.9474662650946747d, b: 0.47327604724444206d, c: 0.2792221313962129d),

new NpgsqlTypes.NpgsqlLine(a: 0.8054176888618385d, b: 0.7417037102535697d, c: 0.8928118661405984d),

new NpgsqlTypes.NpgsqlLine(a: 0.07044553984581203d, b: 0.4697737833330442d, c: 0.5751287281623108d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7554482834939987d, b: 0.6293239714092607d, c: 0.8895692986420588d),

new NpgsqlTypes.NpgsqlLine(a: 0.8243952635953966d, b: 0.41606716083231354d, c: 0.8963478555264772d),

new NpgsqlTypes.NpgsqlLine(a: 0.22324886391880794d, b: 0.13587575816759845d, c: 0.9606204443146975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4351297556970106d, b: 0.9681052704466733d, c: 0.307760616768756d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6439110496720883d, b: 0.4724536454917375d, c: 0.3350764515343444d),

new NpgsqlTypes.NpgsqlLine(a: 0.5371483964279486d, b: 0.2638914827784017d, c: 0.6751614239668841d),

new NpgsqlTypes.NpgsqlLine(a: 0.8491148718385376d, b: 0.8185091162273678d, c: 0.241010751660086d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40167736157515277d, b: 0.8792178244979981d, c: 0.4067739132460241d),

new NpgsqlTypes.NpgsqlLine(a: 0.9264994732998799d, b: 0.9216700894823358d, c: 0.038239336429700344d),

new NpgsqlTypes.NpgsqlLine(a: 0.5672583229281312d, b: 0.8584420545789232d, c: 0.1301272779557352d),

new NpgsqlTypes.NpgsqlLine(a: 0.9598657902126372d, b: 0.8660701031677921d, c: 0.4772883798856189d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5525259196984026d, b: 0.7569099848818557d, c: 0.750078578581583d),

new NpgsqlTypes.NpgsqlLine(a: 0.4580589499238792d, b: 0.4150690287675969d, c: 0.07646158959339433d),

new NpgsqlTypes.NpgsqlLine(a: 0.5173535193236589d, b: 0.852791361833379d, c: 0.3678351492604407d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4688893019687783d, b: 0.9836046484483943d, c: 0.11299630438211994d),

new NpgsqlTypes.NpgsqlLine(a: 0.44301407590751274d, b: 0.5372206905708292d, c: 0.36213178879326224d),

new NpgsqlTypes.NpgsqlLine(a: 0.8975821740782252d, b: 0.5829828827383066d, c: 0.5863828122317386d),

new NpgsqlTypes.NpgsqlLine(a: 0.8077712458947645d, b: 0.7628337164920456d, c: 0.34535269044288774d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7123500544840073d, b: 0.18814392435717875d, c: 0.3527513156073745d),

new NpgsqlTypes.NpgsqlLine(a: 0.6578814716801513d, b: 0.6492252828202324d, c: 0.6696851519568855d),

new NpgsqlTypes.NpgsqlLine(a: 0.032076760029530305d, b: 0.8612515532745557d, c: 0.3436526465238243d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4595309920469517d, b: 0.8447680941359272d, c: 0.3174799099943295d),

new NpgsqlTypes.NpgsqlLine(a: 0.447897138982452d, b: 0.4014092425239293d, c: 0.46419609430847d),

new NpgsqlTypes.NpgsqlLine(a: 0.836461852775018d, b: 0.2506728023875847d, c: 0.680686278518146d),

new NpgsqlTypes.NpgsqlLine(a: 0.4987109427979496d, b: 0.7701423229369051d, c: 0.6323192419162735d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8045405059738227d, b: 0.2403025911554051d, c: 0.41017853032350504d),

new NpgsqlTypes.NpgsqlLine(a: 0.08723079167485714d, b: 0.21564564208612336d, c: 0.5914200741176989d),

new NpgsqlTypes.NpgsqlLine(a: 0.21942155991348367d, b: 0.8144636329757281d, c: 0.47688621412666843d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23125543805460091d, b: 0.14888554449203883d, c: 0.5430801124191706d),

new NpgsqlTypes.NpgsqlLine(a: 0.6046734150487798d, b: 0.48364052060149465d, c: 0.8049726417020484d),

new NpgsqlTypes.NpgsqlLine(a: 0.9378014768569435d, b: 0.7357290637459003d, c: 0.2554947172081663d),

new NpgsqlTypes.NpgsqlLine(a: 0.4369872759175186d, b: 0.10934161128040465d, c: 0.9243992690804129d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7347229784956952d, b: 0.25031799603885563d, c: 0.23838159890391453d),

new NpgsqlTypes.NpgsqlLine(a: 0.42643969623185574d, b: 0.5641754829519441d, c: 0.43757620309138134d),

new NpgsqlTypes.NpgsqlLine(a: 0.8851123545000377d, b: 0.5427365420019873d, c: 0.28399287013114793d),

new NpgsqlTypes.NpgsqlLine(a: 0.4020865894840745d, b: 0.5158163715603604d, c: 0.3042301066088057d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5532987114766064d, b: 0.4051022860294706d, c: 0.33569098572506817d),

new NpgsqlTypes.NpgsqlLine(a: 0.9918455574232975d, b: 0.7416998980227693d, c: 0.4432551432758691d),

new NpgsqlTypes.NpgsqlLine(a: 0.4572326615791408d, b: 0.8082843866752114d, c: 0.32270530684309706d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13100498672547412d, b: 0.06276026360843534d, c: 0.3293367939762958d),

new NpgsqlTypes.NpgsqlLine(a: 0.7470014966975781d, b: 0.18240331958587175d, c: 0.6331158754843571d),

new NpgsqlTypes.NpgsqlLine(a: 0.32557638967169666d, b: 0.012240810490048104d, c: 0.8186300583526381d),

new NpgsqlTypes.NpgsqlLine(a: 0.28897761882960904d, b: 0.2820324609794268d, c: 0.5986366690055815d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8007330728856507d, b: 0.005811749987939097d, c: 0.6419327727211431d),

new NpgsqlTypes.NpgsqlLine(a: 0.8408712690607199d, b: 0.9949770578220668d, c: 0.8285410442336226d),

new NpgsqlTypes.NpgsqlLine(a: 0.7726972000315527d, b: 0.7297066218017814d, c: 0.9272392715595036d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4533460139449206d, b: 0.20541867002295333d, c: 0.4498760757130994d),

new NpgsqlTypes.NpgsqlLine(a: 0.4862875012111165d, b: 0.4073522387606484d, c: 0.16553545900500477d),

new NpgsqlTypes.NpgsqlLine(a: 0.0635766967152388d, b: 0.7764549630942429d, c: 0.16623101151175168d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09201072028461055d, b: 0.04363937117781158d, c: 0.4888694267436463d),

new NpgsqlTypes.NpgsqlLine(a: 0.14921882390895302d, b: 0.48844948161687485d, c: 0.10403265089966662d),

new NpgsqlTypes.NpgsqlLine(a: 0.5459537014147372d, b: 0.9708249064149478d, c: 0.9592593741264697d),

new NpgsqlTypes.NpgsqlLine(a: 0.05243406314302823d, b: 0.10025069963644562d, c: 0.5711485569567871d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3047146916463245d, b: 0.3518253483878845d, c: 0.022013080632797832d),

new NpgsqlTypes.NpgsqlLine(a: 0.1452235642981915d, b: 0.4426187356852127d, c: 0.6814819733912602d),

new NpgsqlTypes.NpgsqlLine(a: 0.06678144376541395d, b: 0.5075197054686369d, c: 0.049034359321397214d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3232280056666009d, b: 0.9785369673776723d, c: 0.6394911569627129d),

new NpgsqlTypes.NpgsqlLine(a: 0.915746890155d, b: 0.6594668192453261d, c: 0.9381632008457446d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236631492858757d, b: 0.6371458122124386d, c: 0.6056809239831394d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1746583314686081d, b: 0.9842801480166182d, c: 0.3390679629493224d),

new NpgsqlTypes.NpgsqlLine(a: 0.1708682290156638d, b: 0.4468554481167195d, c: 0.5609511894238276d),

new NpgsqlTypes.NpgsqlLine(a: 0.2017784795365779d, b: 0.050829665115817324d, c: 0.672214142462426d),

new NpgsqlTypes.NpgsqlLine(a: 0.7890655464685967d, b: 0.5005548634826164d, c: 0.7352137307948837d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9427927949086004d, b: 0.22842159480849d, c: 0.2262162714783582d),

new NpgsqlTypes.NpgsqlLine(a: 0.7187511583586871d, b: 0.2513580807734944d, c: 0.29352502207960773d),

new NpgsqlTypes.NpgsqlLine(a: 0.3993992277168368d, b: 0.9533818148485602d, c: 0.19698780482429745d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.334018325268996d, b: 0.2798911495509725d, c: 0.8831471588889566d),

new NpgsqlTypes.NpgsqlLine(a: 0.4928338129876716d, b: 0.7420414657912672d, c: 0.8611407226524188d),

new NpgsqlTypes.NpgsqlLine(a: 0.8109523439296988d, b: 0.14272817047557163d, c: 0.9542586492745623d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.026936591495572593d, b: 0.79783627888235d, c: 0.34211313641091334d),

new NpgsqlTypes.NpgsqlLine(a: 0.09287952430432389d, b: 0.43382775894420167d, c: 0.6168965826449709d),

new NpgsqlTypes.NpgsqlLine(a: 0.5867806575059945d, b: 0.715799346865354d, c: 0.9624206441531474d),

new NpgsqlTypes.NpgsqlLine(a: 0.8578389684647711d, b: 0.7464909233018973d, c: 0.8765127965103604d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9806528419559445d, b: 0.9718736529154369d, c: 0.9548893983451904d),

new NpgsqlTypes.NpgsqlLine(a: 0.9114403529998982d, b: 0.08028357464079172d, c: 0.843618881252389d),

new NpgsqlTypes.NpgsqlLine(a: 0.20634866903689697d, b: 0.4294548144628896d, c: 0.17368554849029694d),

new NpgsqlTypes.NpgsqlLine(a: 0.7377758051812064d, b: 0.7219333751842709d, c: 0.6642897566035663d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9339373277504917d, b: 0.8018589667117041d, c: 0.1569786358014249d),

new NpgsqlTypes.NpgsqlLine(a: 0.9104342382160509d, b: 0.8303800268115037d, c: 0.45962079620607044d),

new NpgsqlTypes.NpgsqlLine(a: 0.6979492231351987d, b: 0.16279596273082064d, c: 0.49768684624405646d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1377238917910365d, b: 0.31899200165795794d, c: 0.4803783098456794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9589750248234031d, b: 0.7242612280175802d, c: 0.39414972025241657d),

new NpgsqlTypes.NpgsqlLine(a: 0.6274150123444769d, b: 0.920121594002664d, c: 0.6834858009813712d),

new NpgsqlTypes.NpgsqlLine(a: 0.8534437410353459d, b: 0.6043703803423842d, c: 0.0639670086727343d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6576001325081517d, b: 0.3891296114082905d, c: 0.7122466332176965d),

new NpgsqlTypes.NpgsqlLine(a: 0.9093359677715764d, b: 0.1784610795504884d, c: 0.32531905331468536d),

new NpgsqlTypes.NpgsqlLine(a: 0.06553156116093495d, b: 0.9890462708532367d, c: 0.4211341157012687d),

new NpgsqlTypes.NpgsqlLine(a: 0.9481510424265888d, b: 0.29116882301722213d, c: 0.8096441480519253d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42133212092852734d, b: 0.21421450123375563d, c: 0.6547409729199467d),

new NpgsqlTypes.NpgsqlLine(a: 0.5644618633819134d, b: 0.9299823716573218d, c: 0.8352472924279026d),

new NpgsqlTypes.NpgsqlLine(a: 0.9220723284383627d, b: 0.5447661173052352d, c: 0.9760091054348566d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8497229911459994d, b: 0.7937329353210857d, c: 0.3718726539859901d),

new NpgsqlTypes.NpgsqlLine(a: 0.7087735328498139d, b: 0.2687519519031343d, c: 0.9928056303084356d),

new NpgsqlTypes.NpgsqlLine(a: 0.9811322122194505d, b: 0.11458942106947467d, c: 0.6977363257846713d),

new NpgsqlTypes.NpgsqlLine(a: 0.04541336777073002d, b: 0.2715503046565175d, c: 0.2961899941288182d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                var models = await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
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

                var models =  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 17, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatchAsync(connection, 21, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
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
                var models =  ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatch(connection, 79, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2M>(15);

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
                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

