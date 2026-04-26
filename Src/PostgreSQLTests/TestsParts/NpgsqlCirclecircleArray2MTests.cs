

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31500880091197425d, y: 0.1847067578642495d), radius: 0.1158782154414798d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.366188824639725d, y: 0.4178707341929875d), radius: 0.8810042767007347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6755335793857788d, y: 0.9899970555697069d), radius: 0.5291341692720097d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05896799564365329d, y: 0.7885242726347842d), radius: 0.2733443201104149d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17199960421921934d, y: 0.8839504202911437d), radius: 0.47811888710657613d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986592917064399d, y: 0.6728823318791993d), radius: 0.3530047596522867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6658291925229292d, y: 0.5780824211239909d), radius: 0.33754213429026725d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7587296654172107d, y: 0.3852676667596775d), radius: 0.5425516589082678d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7223221151678538d, y: 0.6043447872219837d), radius: 0.2898215163106782d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.001958428802223078d, y: 0.0366832108598808d), radius: 0.09772221471694609d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2524194585477507d, y: 0.6476959269541379d), radius: 0.07267712758099065d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7970330389329492d, y: 0.1288197693683737d), radius: 0.09214260665863849d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9240164656550249d, y: 0.7163205787835096d), radius: 0.10597877435371061d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9853456994338584d, y: 0.39284578458171504d), radius: 0.01660208144840758d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8727734190874735d, y: 0.5823467220597925d), radius: 0.9472603744585847d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3120540669209234d, y: 0.6310832483869655d), radius: 0.7761374894052054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14573662010032817d, y: 0.3621547937711175d), radius: 0.17785955640006634d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17651968655957162d, y: 0.2080763370028743d), radius: 0.1276280654850005d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4299757071280269d, y: 0.8883214789817053d), radius: 0.9013728945274851d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7002888010573854d, y: 0.4302954721003086d), radius: 0.6905421975009809d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7203197487374579d, y: 0.4530697729997024d), radius: 0.0777634871691828d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7037380032134658d, y: 0.4523368900054704d), radius: 0.9541310322100004d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8712429412152667d, y: 0.08651742553248187d), radius: 0.8126856451324261d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0893415538105663d, y: 0.18223343566489147d), radius: 0.6463149883619677d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6246147739295319d, y: 0.9652789275734746d), radius: 0.0666628678654142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7617763379316911d, y: 0.12684749033221754d), radius: 0.7381455405113859d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9365043938533183d, y: 0.049467543792739876d), radius: 0.10923984012863819d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26646823124243546d, y: 0.8870629627135608d), radius: 0.7562565599515741d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9012494830671517d, y: 0.07153472316660903d), radius: 0.7938913834089268d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9048104166387542d, y: 0.5789475903642134d), radius: 0.24439752436567375d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7390351756149968d, y: 0.13568823128919838d), radius: 0.6217378268892431d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41553415428855434d, y: 0.585460563511429d), radius: 0.4768488193154723d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40106190764616334d, y: 0.12067212964926854d), radius: 0.5037482205309242d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09323914379440168d, y: 0.28664584087631473d), radius: 0.7587035784665226d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.662930833061292d, y: 0.7335541896354266d), radius: 0.13812826850977533d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8214773974188926d, y: 0.3764460766707791d), radius: 0.06716920388185377d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3352657234551142d, y: 0.9112111996815412d), radius: 0.326605428176183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6219568741600091d, y: 0.9516119411306706d), radius: 0.5869667587885606d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425595543157051d, y: 0.8186510125697697d), radius: 0.5038060414340854d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6318922718913996d, y: 0.04967917507451669d), radius: 0.6077134612546236d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3062183954087948d, y: 0.5675229759253642d), radius: 0.6824549295391286d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39700815840231685d, y: 0.07483912142418159d), radius: 0.26190979460272235d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5103283035079059d, y: 0.3844538377945568d), radius: 0.33762858620326763d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4585944518069429d, y: 0.839961286441265d), radius: 0.6366784881885285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5113220653163809d, y: 0.5898963121774093d), radius: 0.6295932419273765d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13538728398149125d, y: 0.8026728476122319d), radius: 0.6012203341918638d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3602157777626406d, y: 0.6902071139121734d), radius: 0.7176487517784915d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.631245705597565d, y: 0.4907537026878016d), radius: 0.6178977155935791d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0014446638887484209d, y: 0.14340614110712535d), radius: 0.1527682721209921d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6486496953321991d, y: 0.3237567676164158d), radius: 0.19808420659596881d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03584661323221483d, y: 0.9918458111498699d), radius: 0.8812853294025055d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33307144583783466d, y: 0.7325573169182529d), radius: 0.17675616825588203d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6662989838600212d, y: 0.18064460407531657d), radius: 0.6781977856973254d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8905468415827767d, y: 0.5294109548657456d), radius: 0.8980228573066645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6393921520232569d, y: 0.7526023626260326d), radius: 0.479715507824102d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9467588862784178d, y: 0.2883594642160806d), radius: 0.49350053883416756d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6928802924428169d, y: 0.9035540636820776d), radius: 0.7104538580047585d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3910813557391898d, y: 0.2670014241263624d), radius: 0.7510537588830508d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5387001401157412d, y: 0.46216486458795514d), radius: 0.9841194717510436d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9860520935347743d, y: 0.7794224482367579d), radius: 0.283948200725861d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8258192909928384d, y: 0.015582386284521021d), radius: 0.6984185053308086d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08741773165725553d, y: 0.6327455808449997d), radius: 0.514466222975732d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6972736354250983d, y: 0.6714887529439822d), radius: 0.8410399282168728d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7241317818097258d, y: 0.523600593351192d), radius: 0.8278465442641804d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8728867439925948d, y: 0.3448643018604691d), radius: 0.3715458772564081d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.994640578924467d, y: 0.9874358392561999d), radius: 0.2240514596431623d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.529782307921998d, y: 0.7249670469336744d), radius: 0.7497263770853533d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9262370174149275d, y: 0.8857500657517737d), radius: 0.20146923821650742d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18303304505518458d, y: 0.5782795926487929d), radius: 0.6630137920651082d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49750107292208945d, y: 0.2202461006223364d), radius: 0.9514072923434532d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6824806886674935d, y: 0.8075810012891314d), radius: 0.7423191337696865d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18311285371824015d, y: 0.9845275633202328d), radius: 0.6255238154534173d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.569440388258317d, y: 0.3643239729709d), radius: 0.3408258663610322d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21762326177643987d, y: 0.9743927369724195d), radius: 0.696020133474919d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7687101015639259d, y: 0.3066114645438426d), radius: 0.2868037669542419d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.279477118674776d, y: 0.9489533501804366d), radius: 0.48357440409809005d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2376353821878856d, y: 0.13889365686772848d), radius: 0.12778708630131808d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4455267413828031d, y: 0.11255676733408138d), radius: 0.24647647421460517d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.730299209676721d, y: 0.5980037075020356d), radius: 0.030770312312446646d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36558345052395225d, y: 0.6815473335509743d), radius: 0.7918146426978494d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.003093822726910611d, y: 0.341765082720916d), radius: 0.48841525309271716d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4021680975725552d, y: 0.04706384623113502d), radius: 0.014948997525554897d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.720092773235988d, y: 0.2801530296979863d), radius: 0.4857674522430977d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43952219684408755d, y: 0.15121407165916823d), radius: 0.8457545023933752d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7730154291536135d, y: 0.3938133658416d), radius: 0.9978804351351287d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7571687067717494d, y: 0.413678075839194d), radius: 0.3203857333640713d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3961554658481726d, y: 0.8958361931143815d), radius: 0.652083063670665d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7644426726076139d, y: 0.08041210311040914d), radius: 0.3092425943814947d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8227699556801296d, y: 0.3678907310942161d), radius: 0.7541615525333568d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6475258068571906d, y: 0.8216499571561897d), radius: 0.5247180587370306d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5531079641491532d, y: 0.9045546469199477d), radius: 0.43343129993310414d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43576604811536523d, y: 0.43136483501787193d), radius: 0.8816333279993349d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1859734658915303d, y: 0.04233332630076814d), radius: 0.8241879614651964d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9722461850619023d, y: 0.783356044375145d), radius: 0.5253947706741859d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1579073142038825d, y: 0.7147923920528477d), radius: 0.23299288814630714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8102087263112834d, y: 0.9895807161527148d), radius: 0.866888224375337d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5054423086414449d, y: 0.7096132176797773d), radius: 0.4439198537190322d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6562678691785887d, y: 0.11126903414031453d), radius: 0.8205233483772837d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8920469426634945d, y: 0.6914996947947907d), radius: 0.07381942987360512d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2122186489868717d, y: 0.03807134320618111d), radius: 0.8661861285993455d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8652890970021431d, y: 0.5141769505145011d), radius: 0.6467846990246706d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31427833438270114d, y: 0.9280330005047336d), radius: 0.419091741985943d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3652877658092829d, y: 0.40276258663188846d), radius: 0.6700148511559323d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2946050047514953d, y: 0.38820697585835207d), radius: 0.7725574972412653d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8919204951991808d, y: 0.8124108618168592d), radius: 0.8830891581926259d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4858254227565699d, y: 0.48643949543102627d), radius: 0.4226433339475252d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6496190833729356d, y: 0.02394066333950806d), radius: 0.08103958183181714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5472019102464748d, y: 0.34403738979977927d), radius: 0.11606041791050448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6385347690192315d, y: 0.5276222386467699d), radius: 0.2941801971104263d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9101265750562532d, y: 0.540210382145877d), radius: 0.20360656430369672d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6210475246359949d, y: 0.8827428029699628d), radius: 0.9426322911815789d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26411844569941845d, y: 0.9658963931913507d), radius: 0.3043565264015464d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7348661557881292d, y: 0.2020452562841406d), radius: 0.9410518206158142d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9451183523093132d, y: 0.21432358612271896d), radius: 0.7948514110797594d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4073602901783626d, y: 0.8177793304059258d), radius: 0.11279496610852402d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715614729028022d, y: 0.04216957215296102d), radius: 0.7417805432469188d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19954986128757024d, y: 0.8492067529041285d), radius: 0.7022613329741867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1422534597203825d, y: 0.28088389602016084d), radius: 0.49955758327911315d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44462543524638276d, y: 0.6940860967369888d), radius: 0.27221555585340784d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3969942183070553d, y: 0.2748569389220634d), radius: 0.014094704789619161d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3979227333929892d, y: 0.13242049958275282d), radius: 0.6741151671948229d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10242469678773292d, y: 0.8363032506951882d), radius: 0.7911313676697428d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8123966728941953d, y: 0.17013200845756693d), radius: 0.97297359222186d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30702049523405384d, y: 0.9944048321863065d), radius: 0.23702790218484293d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6647520306658048d, y: 0.4765585110724826d), radius: 0.05640496892886315d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09488417433914786d, y: 0.34414009477879626d), radius: 0.2501787575262514d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.927206977261229d, y: 0.2528168798245578d), radius: 0.5792676661071867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6188546792697049d, y: 0.5141501825834971d), radius: 0.09258748068229394d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6017670170230538d, y: 0.8653442857757563d), radius: 0.651926435659332d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6946033241807167d, y: 0.42439088148181325d), radius: 0.5798564608519139d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058910449192036585d, y: 0.6287528339947864d), radius: 0.8452025849774331d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2824727409819402d, y: 0.14115741120317182d), radius: 0.9269297970877095d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7652422766108968d, y: 0.03156342467627471d), radius: 0.6340464017721521d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2156956344733575d, y: 0.004932870715900872d), radius: 0.8540680950365913d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46113781419380495d, y: 0.3404732686171973d), radius: 0.392325373124605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7993096075322786d, y: 0.5185997045317758d), radius: 0.3092205651415909d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5042476023915614d, y: 0.208177550937664d), radius: 0.9450970423279665d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47353118383291437d, y: 0.7386834163256346d), radius: 0.6825137663303927d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5999532269973417d, y: 0.94576912951549d), radius: 0.007409254835091139d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7474061748421676d, y: 0.7212980944551973d), radius: 0.9237994028420319d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8851931401614007d, y: 0.8597410393731315d), radius: 0.9801157102627087d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3079556975040503d, y: 0.6352781923890141d), radius: 0.769662341626938d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11781317333717256d, y: 0.7088129109604061d), radius: 0.396860992493167d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4078637193275886d, y: 0.06628754289792804d), radius: 0.6471424272745147d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45676876911318587d, y: 0.6032857513866848d), radius: 0.5784934816439806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40574976581694755d, y: 0.6531931489596855d), radius: 0.12011450325969175d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4450519061441769d, y: 0.08445986934520622d), radius: 0.37892828345381513d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9008745554163682d, y: 0.30503552984908766d), radius: 0.060386175753208815d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26873446451592087d, y: 0.10473029977849868d), radius: 0.7350597735371472d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0721287317411119d, y: 0.021885969127543925d), radius: 0.24597722261595212d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11478757531396655d, y: 0.26570899700953365d), radius: 0.8554619871286072d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16021357705996597d, y: 0.6049046155737603d), radius: 0.8151040224037004d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9133635129290342d, y: 0.39278675273140207d), radius: 0.6433256359956838d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9925301620583152d, y: 0.4370081906604244d), radius: 0.9886210432120464d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30512549591487526d, y: 0.6724766997602194d), radius: 0.23869044790691618d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8048272670731351d, y: 0.29120128704749115d), radius: 0.5665504327088068d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.842998446711868d, y: 0.026192438842062238d), radius: 0.9947022941467298d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7207078953820065d, y: 0.9570518894107352d), radius: 0.9746415812729492d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5565838813178103d, y: 0.10714727516120737d), radius: 0.6234630232303678d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7399322141316889d, y: 0.2435769978463388d), radius: 0.5516146607020096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5566369585126891d, y: 0.012463345706714368d), radius: 0.5140409265327137d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5518972777243927d, y: 0.4105043736662145d), radius: 0.015802016088486415d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8504115903751703d, y: 0.31246984851789505d), radius: 0.03383398886920164d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1491714016427288d, y: 0.077365770869402d), radius: 0.7158523248461083d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04149446066400564d, y: 0.1889181332004385d), radius: 0.899786824457867d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21746778964192104d, y: 0.9968885547317348d), radius: 0.5807813373193785d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.520520036384837d, y: 0.41443693988317276d), radius: 0.2719199410851809d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7673491419112484d, y: 0.1159282247192488d), radius: 0.7649640135826645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.526108564553197d, y: 0.23354359720733409d), radius: 0.21824044806285703d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8143929080871165d, y: 0.2047241605538166d), radius: 0.35342584402053756d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3520655795451947d, y: 0.8886111601110076d), radius: 0.11538869712703315d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2827547761451037d, y: 0.17966003095423044d), radius: 0.47921463963481425d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2776696227641424d, y: 0.4396101720909876d), radius: 0.34285061065576383d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5559668778022759d, y: 0.07490060460082093d), radius: 0.3282086176327079d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9403549581909292d, y: 0.9735513645618543d), radius: 0.6105936988174926d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5376925777389034d, y: 0.34444954816137996d), radius: 0.6905108527635248d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2105312698288183d, y: 0.26419945222204466d), radius: 0.9033663337109347d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3011710801806188d, y: 0.6368046701897597d), radius: 0.5530984133980945d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7263741058938757d, y: 0.24971827615712427d), radius: 0.17726942493956577d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9595568401465845d, y: 0.7838862194850786d), radius: 0.47634765590190475d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37585547070486414d, y: 0.41353181599962296d), radius: 0.14205187143120457d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7332991440655292d, y: 0.8399907229180333d), radius: 0.7027871418009979d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7844562121398754d, y: 0.7106501035276673d), radius: 0.7543973683403562d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04564316086748599d, y: 0.9086740299216486d), radius: 0.3533826230405277d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6220522953082193d, y: 0.9418394841872735d), radius: 0.5026442245997442d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9580494414157711d, y: 0.786437032895566d), radius: 0.019142228360081393d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24706124425994103d, y: 0.788549534225733d), radius: 0.4863338550505867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14922996934216426d, y: 0.8357017699727592d), radius: 0.25137094977266616d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4005123980782833d, y: 0.6900451318418496d), radius: 0.02033298423468033d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9884894942693268d, y: 0.4121213379779535d), radius: 0.6639783685605183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8887326442793956d, y: 0.39618087108137845d), radius: 0.87620729913777d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09034948630429385d, y: 0.1632734873645646d), radius: 0.7511685885579436d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29334402634152124d, y: 0.6504873333726504d), radius: 0.14743580882159246d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6510109905615759d, y: 0.9211276080094122d), radius: 0.6945098644297625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9480886637916374d, y: 0.5604946309946057d), radius: 0.023752792533961675d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5548289302167512d, y: 0.4439804402726152d), radius: 0.1658932083433916d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8887610372124539d, y: 0.18712988933672536d), radius: 0.8310610516040607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25548767645676385d, y: 0.24330773301919217d), radius: 0.8723984775778055d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13090698102850018d, y: 0.9864624432140187d), radius: 0.5293727230174683d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03255392441810101d, y: 0.11617771361135543d), radius: 0.11616928887587707d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5562065591256676d, y: 0.38544335149744613d), radius: 0.28572221822559707d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13486126025742318d, y: 0.8414605574209864d), radius: 0.9917206555713025d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4553482295218807d, y: 0.719325568922057d), radius: 0.37012299675097937d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5686676128176216d, y: 0.9335566773960338d), radius: 0.5554077480029d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2684801852383979d, y: 0.3799036392722641d), radius: 0.45590986900061836d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8327297907852026d, y: 0.9295078124905631d), radius: 0.8422516197405757d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.802138819145682d, y: 0.1987100794292681d), radius: 0.8624231181169502d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05942115197943321d, y: 0.27299749111661487d), radius: 0.1402524247909651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9577450830096621d, y: 0.29969941290542834d), radius: 0.5320355753210787d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.141135704351514d, y: 0.43240230705965144d), radius: 0.46973915326368265d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12621067308279854d, y: 0.8795086014534138d), radius: 0.9587412396775757d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9653223533404626d, y: 0.22135970144219552d), radius: 0.699225021393951d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.034080781561774076d, y: 0.24378445650658787d), radius: 0.09183244110139144d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26800729653450894d, y: 0.4446405506081329d), radius: 0.5533288426019924d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5262002607364832d, y: 0.5030901175854433d), radius: 0.9525907645106774d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.880610497679524d, y: 0.7024265506821884d), radius: 0.3783742398832205d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9757508153853823d, y: 0.176823137214563d), radius: 0.043357600349730685d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4943970294520422d, y: 0.595620643980208d), radius: 0.9504729616199531d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8681324096800797d, y: 0.41683999446901476d), radius: 0.07280837126880846d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46578182938686563d, y: 0.9069348598787768d), radius: 0.22633251393749343d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.599239039152607d, y: 0.7869956398568546d), radius: 0.8802839968361058d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06270189690617023d, y: 0.8967620675673057d), radius: 0.28939979230804536d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2214109046530517d, y: 0.22849739650836132d), radius: 0.9683687886581914d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9669663134797559d, y: 0.24378343274589787d), radius: 0.7334776456670983d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28296149117363223d, y: 0.2382571096705821d), radius: 0.9421532690915048d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21822399202917864d, y: 0.22620292313654344d), radius: 0.17378804729021002d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4211110064030763d, y: 0.6287490300019514d), radius: 0.006743889821982929d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17682526084287453d, y: 0.055074081931936636d), radius: 0.05899898588508479d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.039535664427184924d, y: 0.5639877021170616d), radius: 0.16646729692572992d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7869792200986453d, y: 0.19479288520408433d), radius: 0.2516154323431138d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3913062484584442d, y: 0.7330919815646791d), radius: 0.7001810441648553d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040403193395807224d, y: 0.3005872320507811d), radius: 0.5532574893184851d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42095511670546126d, y: 0.8581046641607958d), radius: 0.4884617820108855d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7003698231330509d, y: 0.3828488845144835d), radius: 0.04808535664376079d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3631999494642204d, y: 0.9559777904246387d), radius: 0.7554542483896091d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6701309337066874d, y: 0.9606484770550867d), radius: 0.713045641080923d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5760838032288257d, y: 0.25491386664582194d), radius: 0.12333699725889524d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3265921096111428d, y: 0.43918572304307346d), radius: 0.6503046968959415d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020248444039480007d, y: 0.4972328186906071d), radius: 0.15856654465220854d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8746839180882615d, y: 0.6089099606902018d), radius: 0.11001212465300603d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7457378193450895d, y: 0.6639036420933696d), radius: 0.5232804099136239d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8429805244479031d, y: 0.18978853777533744d), radius: 0.36081947883495946d),

},
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 103, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 53, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 105, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 149, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[29], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 9, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 116, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 126, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
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
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2M>(15);

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
                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

