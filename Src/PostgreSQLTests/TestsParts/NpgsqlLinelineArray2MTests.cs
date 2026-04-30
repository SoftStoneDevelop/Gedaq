

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5945815969804747d, b: 0.8950272306329232d, c: 0.4195582192982138d),

new NpgsqlTypes.NpgsqlLine(a: 0.0019752327539050984d, b: 0.13741996745089768d, c: 0.44384084015695024d),

new NpgsqlTypes.NpgsqlLine(a: 0.09260238147939359d, b: 0.6757361714375157d, c: 0.9731764653958027d),

new NpgsqlTypes.NpgsqlLine(a: 0.22960325554126926d, b: 0.4007845353052444d, c: 0.8685447416750922d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9729259439912004d, b: 0.710392954949041d, c: 0.4501985338277201d),

new NpgsqlTypes.NpgsqlLine(a: 0.0372445780468742d, b: 0.27845810890511247d, c: 0.3460230123524457d),

new NpgsqlTypes.NpgsqlLine(a: 0.724622340009441d, b: 0.4429010794889152d, c: 0.727925691906165d),

new NpgsqlTypes.NpgsqlLine(a: 0.6505285340889874d, b: 0.7692662667407614d, c: 0.0612655719623415d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35003399395321255d, b: 0.02846970901381296d, c: 0.2796024057898474d),

new NpgsqlTypes.NpgsqlLine(a: 0.87896922440373d, b: 0.9174364157466827d, c: 0.42519053720171207d),

new NpgsqlTypes.NpgsqlLine(a: 0.7635341421111191d, b: 0.49387318243195877d, c: 0.7697034559404563d),

new NpgsqlTypes.NpgsqlLine(a: 0.45598263866659006d, b: 0.24683801736307753d, c: 0.7315132357615469d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3162284625142754d, b: 0.9213661493270222d, c: 0.4247621599033833d),

new NpgsqlTypes.NpgsqlLine(a: 0.3527364812999907d, b: 0.43511320487977145d, c: 0.9615874472582635d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556615994445402d, b: 0.4027291121861586d, c: 0.05275155292019984d),

new NpgsqlTypes.NpgsqlLine(a: 0.5211500599920456d, b: 0.16352081266002516d, c: 0.933173814976463d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5869755483711186d, b: 0.6313777531418064d, c: 0.827352045011059d),

new NpgsqlTypes.NpgsqlLine(a: 0.2102169297074431d, b: 0.49556725094145926d, c: 0.3836156268930453d),

new NpgsqlTypes.NpgsqlLine(a: 0.699171672795746d, b: 0.579175640858163d, c: 0.6408127120486516d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2941345571737425d, b: 0.6924764529687037d, c: 0.9542858367985082d),

new NpgsqlTypes.NpgsqlLine(a: 0.2428830252194215d, b: 0.7241812940500333d, c: 0.7823023214235585d),

new NpgsqlTypes.NpgsqlLine(a: 0.8147413675426135d, b: 0.7379802117300567d, c: 0.7364258663870339d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04422540902114991d, b: 0.5700681590769844d, c: 0.9587966207477568d),

new NpgsqlTypes.NpgsqlLine(a: 0.09982947869206604d, b: 0.8803077455238854d, c: 0.45953311651852213d),

new NpgsqlTypes.NpgsqlLine(a: 0.1741914076018366d, b: 0.1757964540743815d, c: 0.8973312626920291d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.708643049154632d, b: 0.18977179140667377d, c: 0.2203336420335319d),

new NpgsqlTypes.NpgsqlLine(a: 0.23829800237156495d, b: 0.9088586907967721d, c: 0.4796410214366128d),

new NpgsqlTypes.NpgsqlLine(a: 0.9215532860645683d, b: 0.4898505761931631d, c: 0.8026042612177012d),

new NpgsqlTypes.NpgsqlLine(a: 0.2543855462276381d, b: 0.28570329149742024d, c: 0.3438416781355701d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4368026498202612d, b: 0.5632992152444251d, c: 0.15218419367595637d),

new NpgsqlTypes.NpgsqlLine(a: 0.7699140762507627d, b: 0.2174430637156758d, c: 0.5647294181670904d),

new NpgsqlTypes.NpgsqlLine(a: 0.1797245560025308d, b: 0.04531367974071454d, c: 0.2215841735368611d),

new NpgsqlTypes.NpgsqlLine(a: 0.06094292645760013d, b: 0.9311610385066373d, c: 0.6600310595803773d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31891708735041824d, b: 0.6450890714071077d, c: 0.9802387699438974d),

new NpgsqlTypes.NpgsqlLine(a: 0.5693290693312837d, b: 0.6028821105586569d, c: 0.07320026257845968d),

new NpgsqlTypes.NpgsqlLine(a: 0.9505340993816151d, b: 0.4927493972094781d, c: 0.1359967151295013d),

new NpgsqlTypes.NpgsqlLine(a: 0.3469207119618054d, b: 0.28008986030104843d, c: 0.47248097051481297d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.936008313297663d, b: 0.6311621767953098d, c: 0.2518913428260805d),

new NpgsqlTypes.NpgsqlLine(a: 0.5316628711607602d, b: 0.9878136872368501d, c: 0.8311442807180949d),

new NpgsqlTypes.NpgsqlLine(a: 0.016504129676323753d, b: 0.2917696962687185d, c: 0.21734854071235366d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31124160380463817d, b: 0.22442025805460275d, c: 0.2397052961478765d),

new NpgsqlTypes.NpgsqlLine(a: 0.07434409451550739d, b: 0.46688285565158616d, c: 0.5346654446731884d),

new NpgsqlTypes.NpgsqlLine(a: 0.7276088994267431d, b: 0.5174612282042741d, c: 0.8211388973981276d),

new NpgsqlTypes.NpgsqlLine(a: 0.37716479463424424d, b: 0.8067120925722892d, c: 0.685176023591656d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10599928557623683d, b: 0.527806734706727d, c: 0.6082212891302837d),

new NpgsqlTypes.NpgsqlLine(a: 0.2191721872636443d, b: 0.638101494982516d, c: 0.6539136839838101d),

new NpgsqlTypes.NpgsqlLine(a: 0.34366681153215806d, b: 0.3171122544014945d, c: 0.6637372380068742d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5753312115181504d, b: 0.8768572500506073d, c: 0.7862430965400375d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257964434423605d, b: 0.4330497713790997d, c: 0.7099625757008511d),

new NpgsqlTypes.NpgsqlLine(a: 0.8959865463652267d, b: 0.22766273530371928d, c: 0.06195773873312227d),

new NpgsqlTypes.NpgsqlLine(a: 0.41763319601110305d, b: 0.05991846560837577d, c: 0.08414264197055443d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44148099223919657d, b: 0.7731973012335989d, c: 0.09196652362732793d),

new NpgsqlTypes.NpgsqlLine(a: 0.022418851746209945d, b: 0.33107896073136645d, c: 0.2434164917071271d),

new NpgsqlTypes.NpgsqlLine(a: 0.918735043878334d, b: 0.38960674230495096d, c: 0.41966011967120675d),

new NpgsqlTypes.NpgsqlLine(a: 0.6868274012633822d, b: 0.2964937333640568d, c: 0.42989516161673336d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9198992706246141d, b: 0.45872146317670115d, c: 0.3506612290529849d),

new NpgsqlTypes.NpgsqlLine(a: 0.22457357443366233d, b: 0.8634522653005585d, c: 0.18505018160962472d),

new NpgsqlTypes.NpgsqlLine(a: 0.21445032493699145d, b: 0.7979330432324361d, c: 0.3227746417297279d),

new NpgsqlTypes.NpgsqlLine(a: 0.9451888381352629d, b: 0.8060013795555142d, c: 0.17319846386649573d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6658743547128089d, b: 0.8290716034696439d, c: 0.4740638799431337d),

new NpgsqlTypes.NpgsqlLine(a: 0.30060805162880133d, b: 0.4753479604630191d, c: 0.7948879378669561d),

new NpgsqlTypes.NpgsqlLine(a: 0.39457634732589897d, b: 0.31571736289097296d, c: 0.39134107319064726d),

new NpgsqlTypes.NpgsqlLine(a: 0.4071623112538747d, b: 0.6836740271264221d, c: 0.27229435050403816d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5634275758790912d, b: 0.7951099039116317d, c: 0.7727670009026749d),

new NpgsqlTypes.NpgsqlLine(a: 0.5135017325634862d, b: 0.1942622330426279d, c: 0.6754507683960806d),

new NpgsqlTypes.NpgsqlLine(a: 0.5718623571311724d, b: 0.047845571290671685d, c: 0.8246189981022852d),

new NpgsqlTypes.NpgsqlLine(a: 0.7875173156628755d, b: 0.2917027163611686d, c: 0.9638483455961325d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9897805641644062d, b: 0.9011204924674937d, c: 0.16284808001564188d),

new NpgsqlTypes.NpgsqlLine(a: 0.826248719782921d, b: 0.42165538518259515d, c: 0.2506052702583388d),

new NpgsqlTypes.NpgsqlLine(a: 0.2767716553369851d, b: 0.9673572113433144d, c: 0.9609004918807538d),

new NpgsqlTypes.NpgsqlLine(a: 0.8075974990416347d, b: 0.5820786723001792d, c: 0.03581017292945399d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08611743904688052d, b: 0.28126679595067083d, c: 0.9321858553438811d),

new NpgsqlTypes.NpgsqlLine(a: 0.6557498109152009d, b: 0.8879402362513457d, c: 0.07834469890204565d),

new NpgsqlTypes.NpgsqlLine(a: 0.8211240487676914d, b: 0.34453402265586697d, c: 0.8802202253387921d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3669202269041134d, b: 0.9349212412836894d, c: 0.6068666570126079d),

new NpgsqlTypes.NpgsqlLine(a: 0.8369619346797648d, b: 0.3194736966952253d, c: 0.5485234583431265d),

new NpgsqlTypes.NpgsqlLine(a: 0.33500013410350116d, b: 0.5343980832244607d, c: 0.5264327419527378d),

new NpgsqlTypes.NpgsqlLine(a: 0.9598805503463657d, b: 0.296056325496577d, c: 0.9523635546428574d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4466556255972036d, b: 0.4935385047554597d, c: 0.018597051199645054d),

new NpgsqlTypes.NpgsqlLine(a: 0.7166364636838051d, b: 0.9918715869293204d, c: 0.1240026079474954d),

new NpgsqlTypes.NpgsqlLine(a: 0.40501836085632925d, b: 0.7874661250617875d, c: 0.5336967839981173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1558266926736891d, b: 0.7398151855198876d, c: 0.22864004038807428d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8572063647039242d, b: 0.22866104984272217d, c: 0.33706074201181646d),

new NpgsqlTypes.NpgsqlLine(a: 0.457867520659216d, b: 0.7378352011009633d, c: 0.9545906225349542d),

new NpgsqlTypes.NpgsqlLine(a: 0.4596234306191165d, b: 0.48133343839930554d, c: 0.412080399697366d),

new NpgsqlTypes.NpgsqlLine(a: 0.2025852012805951d, b: 0.4769156682628889d, c: 0.21156077389004846d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7833320210870224d, b: 0.28889482107807885d, c: 0.9595998874523111d),

new NpgsqlTypes.NpgsqlLine(a: 0.1570841583240008d, b: 0.265939786797347d, c: 0.9337993269262578d),

new NpgsqlTypes.NpgsqlLine(a: 0.7080486361540465d, b: 0.7439386559761955d, c: 0.9820189953931483d),

new NpgsqlTypes.NpgsqlLine(a: 0.8896854365490979d, b: 0.2253003483018109d, c: 0.8899558591496632d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8725607444686255d, b: 0.26504890740767073d, c: 0.40824563934052727d),

new NpgsqlTypes.NpgsqlLine(a: 0.16756156783546217d, b: 0.8173498834886896d, c: 0.05302926690459209d),

new NpgsqlTypes.NpgsqlLine(a: 0.2431013953844564d, b: 0.8588487098918397d, c: 0.9629613009521327d),

new NpgsqlTypes.NpgsqlLine(a: 0.43579159696848524d, b: 0.8730072456721965d, c: 0.3027876079284728d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.950541846116667d, b: 0.6419392686839028d, c: 0.31095898379061115d),

new NpgsqlTypes.NpgsqlLine(a: 0.7647828883736023d, b: 0.6315371521682228d, c: 0.7568135686097484d),

new NpgsqlTypes.NpgsqlLine(a: 0.025696318586808098d, b: 0.09257117899425427d, c: 0.336513304864538d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6935364649407174d, b: 0.255991507928523d, c: 0.16758401502359777d),

new NpgsqlTypes.NpgsqlLine(a: 0.4159273092096606d, b: 0.9879036132475526d, c: 0.026796824827246102d),

new NpgsqlTypes.NpgsqlLine(a: 0.01871729840345615d, b: 0.026724425851132216d, c: 0.4156567851066042d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1619128573226587d, b: 0.0635478882041921d, c: 0.9134566084408416d),

new NpgsqlTypes.NpgsqlLine(a: 0.4252509725936694d, b: 0.09534077587024747d, c: 0.9982335393446282d),

new NpgsqlTypes.NpgsqlLine(a: 0.48200798779203835d, b: 0.5869776893433144d, c: 0.7701370070662957d),

new NpgsqlTypes.NpgsqlLine(a: 0.5030668520379747d, b: 0.8461065318723309d, c: 0.21338544004813775d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7593107277011355d, b: 0.2918920607628892d, c: 0.3245437806256899d),

new NpgsqlTypes.NpgsqlLine(a: 0.44452111332662336d, b: 0.6757943249364828d, c: 0.34333320623974417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9054323298593744d, b: 0.43272160581691244d, c: 0.3793961177438354d),

new NpgsqlTypes.NpgsqlLine(a: 0.7305980562859614d, b: 0.5273177738856608d, c: 0.5887710770305706d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9903606375110064d, b: 0.6096326732872681d, c: 0.401154982282913d),

new NpgsqlTypes.NpgsqlLine(a: 0.4121668773092113d, b: 0.06021038519259858d, c: 0.9270199437307394d),

new NpgsqlTypes.NpgsqlLine(a: 0.04748399803783421d, b: 0.6755951921391555d, c: 0.08651299713687421d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21982793960381064d, b: 0.2623111386836273d, c: 0.8958648581811268d),

new NpgsqlTypes.NpgsqlLine(a: 0.0900955437250277d, b: 0.1013553095507469d, c: 0.3748559624383546d),

new NpgsqlTypes.NpgsqlLine(a: 0.6906223152961126d, b: 0.8758239882342276d, c: 0.029905765523772443d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39350220363716215d, b: 0.6462592132956202d, c: 0.3103654274740235d),

new NpgsqlTypes.NpgsqlLine(a: 0.41444935881728584d, b: 0.044936545456425114d, c: 0.512539962187688d),

new NpgsqlTypes.NpgsqlLine(a: 0.37628528411522066d, b: 0.8720620505694792d, c: 0.41797202962009516d),

new NpgsqlTypes.NpgsqlLine(a: 0.6965876700669781d, b: 0.19710640394639167d, c: 0.18097723165780766d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.013969098927840706d, b: 0.8587923327028646d, c: 0.5874427885194244d),

new NpgsqlTypes.NpgsqlLine(a: 0.629890893707506d, b: 0.4444205863310653d, c: 0.9082471900090918d),

new NpgsqlTypes.NpgsqlLine(a: 0.9264980587486954d, b: 0.6600620217112603d, c: 0.09532055877241363d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5140858547040359d, b: 0.02856459991962934d, c: 0.03182877295409792d),

new NpgsqlTypes.NpgsqlLine(a: 0.060648947900892036d, b: 0.561536274810755d, c: 0.9116890037913653d),

new NpgsqlTypes.NpgsqlLine(a: 0.484448025076589d, b: 0.3368147496354291d, c: 0.4944636174535275d),

new NpgsqlTypes.NpgsqlLine(a: 0.9820265042782376d, b: 0.2623396114780614d, c: 0.5494190427787977d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.001630737871584742d, b: 0.3594964669328753d, c: 0.6788086956331125d),

new NpgsqlTypes.NpgsqlLine(a: 0.5951889959492723d, b: 0.982436261545195d, c: 0.766703668932131d),

new NpgsqlTypes.NpgsqlLine(a: 0.29128163184656497d, b: 0.20356831145888443d, c: 0.9129395893601033d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1533879252226319d, b: 0.02684411464279335d, c: 0.31008162218385416d),

new NpgsqlTypes.NpgsqlLine(a: 0.8627266990820551d, b: 0.7354170282365555d, c: 0.4706107804498847d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772348340541023d, b: 0.42868312340457915d, c: 0.3455748992501648d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7070412302946336d, b: 0.20813019683891454d, c: 0.10404585977907344d),

new NpgsqlTypes.NpgsqlLine(a: 0.16868921857510089d, b: 0.3151094880415276d, c: 0.18911474877027934d),

new NpgsqlTypes.NpgsqlLine(a: 0.1866982061989899d, b: 0.3068170261070541d, c: 0.5565845801063097d),

new NpgsqlTypes.NpgsqlLine(a: 0.02080588177891174d, b: 0.7520355684831398d, c: 0.34218535374881187d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12227178530017535d, b: 0.034881103626284826d, c: 0.07664620705130887d),

new NpgsqlTypes.NpgsqlLine(a: 0.8717633656371091d, b: 0.16516387877125727d, c: 0.9880117808454753d),

new NpgsqlTypes.NpgsqlLine(a: 0.033336480810978286d, b: 0.6742127543093164d, c: 0.9383293178191576d),

new NpgsqlTypes.NpgsqlLine(a: 0.9054604362474655d, b: 0.2724954992622498d, c: 0.39397276154361704d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7650953570112944d, b: 0.9234465358774443d, c: 0.4405501350079688d),

new NpgsqlTypes.NpgsqlLine(a: 0.776835167427208d, b: 0.3701401562365755d, c: 0.5587446611011126d),

new NpgsqlTypes.NpgsqlLine(a: 0.03948976642471258d, b: 0.016450606386219535d, c: 0.234137423084549d),

new NpgsqlTypes.NpgsqlLine(a: 0.634914433152295d, b: 0.4889898956226043d, c: 0.6230204833454324d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0014468500262685424d, b: 0.4375749611995787d, c: 0.28565813177373056d),

new NpgsqlTypes.NpgsqlLine(a: 0.4968070104278208d, b: 0.03906665165734391d, c: 0.07686008167025138d),

new NpgsqlTypes.NpgsqlLine(a: 0.2709209657703633d, b: 0.4685544491310576d, c: 0.8587094769780571d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9135945810034163d, b: 0.4927837868614481d, c: 0.06132128737715714d),

new NpgsqlTypes.NpgsqlLine(a: 0.3653622901453283d, b: 0.5585850650694762d, c: 0.599364852299076d),

new NpgsqlTypes.NpgsqlLine(a: 0.24433928474091393d, b: 0.05337001020100507d, c: 0.8646171311705327d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616726831212574d, b: 0.07668371199959478d, c: 0.7035314158459341d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04386211908513726d, b: 0.7014931370619885d, c: 0.28627177995980146d),

new NpgsqlTypes.NpgsqlLine(a: 0.7020415463521947d, b: 0.7859938192834564d, c: 0.5414187657182675d),

new NpgsqlTypes.NpgsqlLine(a: 0.11994272828137442d, b: 0.5997661689648767d, c: 0.8199642808537182d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8710194309259766d, b: 0.7981085926662375d, c: 0.28606962626139554d),

new NpgsqlTypes.NpgsqlLine(a: 0.47260651145378185d, b: 0.4463765471148933d, c: 0.2920692936798932d),

new NpgsqlTypes.NpgsqlLine(a: 0.17275202835633274d, b: 0.04249200353884053d, c: 0.15799728528049195d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4574301560840045d, b: 0.02647572680126875d, c: 0.5740010436544535d),

new NpgsqlTypes.NpgsqlLine(a: 0.909411765703712d, b: 0.8257031182181207d, c: 0.4902806997307192d),

new NpgsqlTypes.NpgsqlLine(a: 0.48537917461310853d, b: 0.4382753417480967d, c: 0.9106979146568382d),

new NpgsqlTypes.NpgsqlLine(a: 0.16138464680136788d, b: 0.6663862375758071d, c: 0.5960219911728002d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6002149425874621d, b: 0.9782986437234532d, c: 0.1369405956122628d),

new NpgsqlTypes.NpgsqlLine(a: 0.15313276844441248d, b: 0.7323888603576514d, c: 0.8225442858344627d),

new NpgsqlTypes.NpgsqlLine(a: 0.15920987381397067d, b: 0.9029271956245198d, c: 0.012738069924783768d),

new NpgsqlTypes.NpgsqlLine(a: 0.9754338167352594d, b: 0.465566713398594d, c: 0.816275031270936d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9952640778688687d, b: 0.4058365996334983d, c: 0.9020129452707961d),

new NpgsqlTypes.NpgsqlLine(a: 0.30988490873791563d, b: 0.31288971737777993d, c: 0.311927965256656d),

new NpgsqlTypes.NpgsqlLine(a: 0.25711284419913494d, b: 0.38339433045895754d, c: 0.0857164711115167d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43220327409249704d, b: 0.1749532636641299d, c: 0.9372805962367059d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461087917946624d, b: 0.81525471159601d, c: 0.20679556321176096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12307831675698755d, b: 0.8972294025407435d, c: 0.38704276296945905d),

new NpgsqlTypes.NpgsqlLine(a: 0.6899117981367939d, b: 0.9861568125097623d, c: 0.6638092104219501d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42410442998947084d, b: 0.4069898864458751d, c: 0.6434936608947069d),

new NpgsqlTypes.NpgsqlLine(a: 0.10478067799334334d, b: 0.7221642756023029d, c: 0.9846697091195101d),

new NpgsqlTypes.NpgsqlLine(a: 0.6597172525543292d, b: 0.5278969684428536d, c: 0.3419590519287097d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07342899410948267d, b: 0.8976491920240649d, c: 0.33735338681094085d),

new NpgsqlTypes.NpgsqlLine(a: 0.6529688126520424d, b: 0.7023536802237215d, c: 0.19362028698756062d),

new NpgsqlTypes.NpgsqlLine(a: 0.9787237057363847d, b: 0.5673832521717245d, c: 0.9184116865100918d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7384167836069384d, b: 0.04284676963747436d, c: 0.4848017242575665d),

new NpgsqlTypes.NpgsqlLine(a: 0.3999400694821291d, b: 0.8870291477930027d, c: 0.7092182109290822d),

new NpgsqlTypes.NpgsqlLine(a: 0.3164115634742092d, b: 0.2626930853873086d, c: 0.20593138089200658d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06930222614576886d, b: 0.8050837408549759d, c: 0.20227947448543382d),

new NpgsqlTypes.NpgsqlLine(a: 0.2537462887452411d, b: 0.7665598295878772d, c: 0.9377608284329542d),

new NpgsqlTypes.NpgsqlLine(a: 0.4221964398733633d, b: 0.3918972467525792d, c: 0.1716552861334676d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9739376327571421d, b: 0.5848896695492107d, c: 0.37920419799327487d),

new NpgsqlTypes.NpgsqlLine(a: 0.6861731511891555d, b: 0.7186688107721787d, c: 0.6134958731811757d),

new NpgsqlTypes.NpgsqlLine(a: 0.8685335313856658d, b: 0.5188176259153109d, c: 0.4653822012143737d),

new NpgsqlTypes.NpgsqlLine(a: 0.42240300997132463d, b: 0.842823705149186d, c: 0.1550672348141937d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4487271497277838d, b: 0.4419831784360375d, c: 0.9846147299951268d),

new NpgsqlTypes.NpgsqlLine(a: 0.05610868698067817d, b: 0.9590377549824871d, c: 0.9368115024934182d),

new NpgsqlTypes.NpgsqlLine(a: 0.37773522696355044d, b: 0.5503458273005217d, c: 0.3050637931338629d),

new NpgsqlTypes.NpgsqlLine(a: 0.6866848733261095d, b: 0.9329914870081729d, c: 0.9846371142789215d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3138227857929322d, b: 0.6510585657557882d, c: 0.1637169211544527d),

new NpgsqlTypes.NpgsqlLine(a: 0.2954647874229597d, b: 0.8089111791330462d, c: 0.6825552957723322d),

new NpgsqlTypes.NpgsqlLine(a: 0.878731628945253d, b: 0.3262902895367972d, c: 0.34009358425686953d),

new NpgsqlTypes.NpgsqlLine(a: 0.29972190254972775d, b: 0.038762847348563834d, c: 0.3894579960826139d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.296289594726438d, b: 0.9450845152001548d, c: 0.23947604428008684d),

new NpgsqlTypes.NpgsqlLine(a: 0.38133894644448596d, b: 0.72922393847408d, c: 0.4805358371194346d),

new NpgsqlTypes.NpgsqlLine(a: 0.47949901530911654d, b: 0.9488977910483991d, c: 0.10295270516193877d),

new NpgsqlTypes.NpgsqlLine(a: 0.5706316554741766d, b: 0.9454798633388256d, c: 0.14164888444150425d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39834517115774226d, b: 0.3773747462728574d, c: 0.902886023368193d),

new NpgsqlTypes.NpgsqlLine(a: 0.32704902355019727d, b: 0.14864831913060905d, c: 0.16514326367294307d),

new NpgsqlTypes.NpgsqlLine(a: 0.499767484778445d, b: 0.24731237660492134d, c: 0.4274028053495338d),

new NpgsqlTypes.NpgsqlLine(a: 0.44402044889942416d, b: 0.5360958276117163d, c: 0.2597717292291223d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4741168531912303d, b: 0.649472778470124d, c: 0.590359298523951d),

new NpgsqlTypes.NpgsqlLine(a: 0.48016099018233616d, b: 0.6515959117834078d, c: 0.2774855677321759d),

new NpgsqlTypes.NpgsqlLine(a: 0.21818436197868596d, b: 0.5683636221152054d, c: 0.5223569216597609d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.562685123784359d, b: 0.2802416464447465d, c: 0.6920543675171137d),

new NpgsqlTypes.NpgsqlLine(a: 0.8402222656152365d, b: 0.40283859047709425d, c: 0.2937236059729085d),

new NpgsqlTypes.NpgsqlLine(a: 0.41548875294092724d, b: 0.4038108018760338d, c: 0.16136215313224556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7917466696871395d, b: 0.6745743337755492d, c: 0.39358186247465354d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9883973747967628d, b: 0.30987263181936386d, c: 0.42884070385823736d),

new NpgsqlTypes.NpgsqlLine(a: 0.3673659808999875d, b: 0.6059971838946632d, c: 0.38034561547850965d),

new NpgsqlTypes.NpgsqlLine(a: 0.2397999188754384d, b: 0.14505882670384962d, c: 0.12692944237691262d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5155973803482717d, b: 0.20081534781630406d, c: 0.18112276621637935d),

new NpgsqlTypes.NpgsqlLine(a: 0.39172316546643227d, b: 0.6180924087028586d, c: 0.7789526599838134d),

new NpgsqlTypes.NpgsqlLine(a: 0.11696974367219393d, b: 0.9914549284474574d, c: 0.7091599133230023d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8187444313873197d, b: 0.9314251247466341d, c: 0.6181536528891957d),

new NpgsqlTypes.NpgsqlLine(a: 0.11276955679790979d, b: 0.11129856683934958d, c: 0.38600796498301493d),

new NpgsqlTypes.NpgsqlLine(a: 0.8887416407976149d, b: 0.2103196421188004d, c: 0.2962392571963728d),

new NpgsqlTypes.NpgsqlLine(a: 0.26339370914646576d, b: 0.6287523423258358d, c: 0.5303699057495024d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3692961755088512d, b: 0.8234081370727796d, c: 0.859169478947107d),

new NpgsqlTypes.NpgsqlLine(a: 0.9832847470490178d, b: 0.4724489428150851d, c: 0.6334810324418712d),

new NpgsqlTypes.NpgsqlLine(a: 0.6728143436136236d, b: 0.28768009077788703d, c: 0.02890245774119382d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5089442682934829d, b: 0.786348750598099d, c: 0.7438538582581163d),

new NpgsqlTypes.NpgsqlLine(a: 0.1546743055853218d, b: 0.4640404295731856d, c: 0.1560806066896181d),

new NpgsqlTypes.NpgsqlLine(a: 0.8141547516151668d, b: 0.7665184776944036d, c: 0.7085673443370009d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6763255496727963d, b: 0.3889334764914092d, c: 0.09535129658096808d),

new NpgsqlTypes.NpgsqlLine(a: 0.476688963838898d, b: 0.8473914229384217d, c: 0.27301861870094934d),

new NpgsqlTypes.NpgsqlLine(a: 0.465968607021377d, b: 0.7258431315674649d, c: 0.9572480348851845d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2548072168630289d, b: 0.20652680586816163d, c: 0.3177114614551575d),

new NpgsqlTypes.NpgsqlLine(a: 0.13375502233877568d, b: 0.3016348202003364d, c: 0.7442827020125887d),

new NpgsqlTypes.NpgsqlLine(a: 0.08869653581259551d, b: 0.06392291940211614d, c: 0.4752857877627551d),

new NpgsqlTypes.NpgsqlLine(a: 0.13842850233048798d, b: 0.9300422226416192d, c: 0.6965753331034282d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39544193292144025d, b: 0.14921464702258103d, c: 0.5546421069572187d),

new NpgsqlTypes.NpgsqlLine(a: 0.7054483386383709d, b: 0.2802631650232017d, c: 0.3038889130368272d),

new NpgsqlTypes.NpgsqlLine(a: 0.44399603614927197d, b: 0.12776255446856666d, c: 0.7802357665999351d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12428287514779268d, b: 0.18273268837015955d, c: 0.18598031790699265d),

new NpgsqlTypes.NpgsqlLine(a: 0.04588186573009512d, b: 0.5666308793809369d, c: 0.13736803752946591d),

new NpgsqlTypes.NpgsqlLine(a: 0.16751596865513052d, b: 0.1579742210779519d, c: 0.9646122388792969d),

new NpgsqlTypes.NpgsqlLine(a: 0.6699730330782079d, b: 0.6699089283764453d, c: 0.6045020403956259d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5183154529248352d, b: 0.4347013707394326d, c: 0.9428542069565196d),

new NpgsqlTypes.NpgsqlLine(a: 0.22760557053550057d, b: 0.4101526109073367d, c: 0.2540582278438984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9489901547180599d, b: 0.58054115893579d, c: 0.916794002661479d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9844062630692927d, b: 0.2552961757937122d, c: 0.45704617258939717d),

new NpgsqlTypes.NpgsqlLine(a: 0.15164280239100114d, b: 0.16150441795172632d, c: 0.9529162552985279d),

new NpgsqlTypes.NpgsqlLine(a: 0.036537795882887414d, b: 0.9132723837919741d, c: 0.39299486186948973d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46238437858569814d, b: 0.0029680753635591417d, c: 0.8465799184047523d),

new NpgsqlTypes.NpgsqlLine(a: 0.5178532571987378d, b: 0.3710818129684509d, c: 0.5456587776951036d),

new NpgsqlTypes.NpgsqlLine(a: 0.9550220352902028d, b: 0.46260168117636635d, c: 0.8016702479237785d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2224260062372434d, b: 0.8256732988732814d, c: 0.7665558485609445d),

new NpgsqlTypes.NpgsqlLine(a: 0.5006364873401794d, b: 0.36045241412315643d, c: 0.2778435899603737d),

new NpgsqlTypes.NpgsqlLine(a: 0.8717975841491821d, b: 0.4310947887312834d, c: 0.06216747666089406d),

new NpgsqlTypes.NpgsqlLine(a: 0.7883510728095863d, b: 0.1503757861175582d, c: 0.7538264670552614d),

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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
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
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 135, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 147, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 98, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 140, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 82, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlLinelineArray2MI),
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

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlLinelineArray2M),
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

