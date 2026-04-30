

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1439081388508030683L),

new System.Numerics.BigInteger(2207534090104352676L),

new System.Numerics.BigInteger(4565991359567965013L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6961779895859871357L),

new System.Numerics.BigInteger(493434453666108610L),

new System.Numerics.BigInteger(6235948132423364935L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7604118849671634825L),

new System.Numerics.BigInteger(1942136320417277832L),

new System.Numerics.BigInteger(4511970899643986063L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4352154899301346361L),

new System.Numerics.BigInteger(9215488391304323819L),

new System.Numerics.BigInteger(2679556562577812543L),

new System.Numerics.BigInteger(5264635148126830859L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3663114947949620686L),

new System.Numerics.BigInteger(113209567360569383L),

new System.Numerics.BigInteger(6104581894978679327L),

},
},
            new BigIntegernumericArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8794687267603858793L),

new System.Numerics.BigInteger(7956896651061392364L),

new System.Numerics.BigInteger(502299882497607937L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6021703003580702496L),

new System.Numerics.BigInteger(8919379000559251597L),

new System.Numerics.BigInteger(6950171709733293894L),

new System.Numerics.BigInteger(273872374929272936L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5054591427489618192L),

new System.Numerics.BigInteger(2102443857166783465L),

new System.Numerics.BigInteger(5681721541875948804L),

new System.Numerics.BigInteger(9144831076667923812L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3148498184010426203L),

new System.Numerics.BigInteger(3254852178054067853L),

new System.Numerics.BigInteger(3081585389051911568L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(138737165985752548L),

new System.Numerics.BigInteger(6241720634823418537L),

new System.Numerics.BigInteger(2025953685002035093L),

},
},
            new BigIntegernumericArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2923417406018270923L),

new System.Numerics.BigInteger(8068706477536374768L),

new System.Numerics.BigInteger(8208834375625996953L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4770953368741935037L),

new System.Numerics.BigInteger(6823380097222637108L),

new System.Numerics.BigInteger(4921962529599560572L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5298436825122574067L),

new System.Numerics.BigInteger(4082789711418044416L),

new System.Numerics.BigInteger(5282562865202421756L),

new System.Numerics.BigInteger(4564278410304716340L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1033901850792017399L),

new System.Numerics.BigInteger(7626885568299129191L),

new System.Numerics.BigInteger(2168470503454628047L),

},
},
            new BigIntegernumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2351803274203918260L),

new System.Numerics.BigInteger(2843373973259079812L),

new System.Numerics.BigInteger(6106477718786716513L),

new System.Numerics.BigInteger(3144595064115835371L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4205682274895690568L),

new System.Numerics.BigInteger(7995497489713548810L),

new System.Numerics.BigInteger(2759108566171271931L),

new System.Numerics.BigInteger(3361748888799789364L),

},
},
            new BigIntegernumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5592234382506280112L),

new System.Numerics.BigInteger(5122431657547173362L),

new System.Numerics.BigInteger(4209322185812003096L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8657175197002635402L),

new System.Numerics.BigInteger(6503322326323329740L),

new System.Numerics.BigInteger(9077796093833025323L),

new System.Numerics.BigInteger(4314412760292055590L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6735573662771203302L),

new System.Numerics.BigInteger(4114213391260706276L),

new System.Numerics.BigInteger(6168164658765112309L),

new System.Numerics.BigInteger(4973624568725636777L),

},
},
            new BigIntegernumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3469000232087105739L),

new System.Numerics.BigInteger(621167875694637464L),

new System.Numerics.BigInteger(7099576123804486242L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2212393031477150339L),

new System.Numerics.BigInteger(241539214626954165L),

new System.Numerics.BigInteger(3687786853457500976L),

},
},
            new BigIntegernumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5176066922473454487L),

new System.Numerics.BigInteger(302058161594222927L),

new System.Numerics.BigInteger(1641165398402668319L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5270860177374730950L),

new System.Numerics.BigInteger(2050934765394060403L),

new System.Numerics.BigInteger(4978732659108820091L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5990541004549740108L),

new System.Numerics.BigInteger(4616694431176790900L),

new System.Numerics.BigInteger(4235241750300834435L),

},
},
            new BigIntegernumericArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7932459702082026497L),

new System.Numerics.BigInteger(6193375584244212383L),

new System.Numerics.BigInteger(2207144075435885881L),

new System.Numerics.BigInteger(524499525263932308L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(32929416099740390L),

new System.Numerics.BigInteger(6999512053728311932L),

new System.Numerics.BigInteger(3484777201981471909L),

},
},
            new BigIntegernumericArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6227446083907394368L),

new System.Numerics.BigInteger(6512488456064132922L),

new System.Numerics.BigInteger(6689218973447834569L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1328750236089306501L),

new System.Numerics.BigInteger(3577401005115079812L),

new System.Numerics.BigInteger(1946871433275201427L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5905199127547483865L),

new System.Numerics.BigInteger(8160914690478901449L),

new System.Numerics.BigInteger(8027753068660597312L),

new System.Numerics.BigInteger(6204480972175415165L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2821441852778668435L),

new System.Numerics.BigInteger(7064211887890364474L),

new System.Numerics.BigInteger(4997769549449771543L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3204518004785933138L),

new System.Numerics.BigInteger(7587484447020376088L),

new System.Numerics.BigInteger(3667269227718886849L),

new System.Numerics.BigInteger(7293591224107932503L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3987275579589085327L),

new System.Numerics.BigInteger(6156871922934947482L),

new System.Numerics.BigInteger(6051169887107143257L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3462530791238544981L),

new System.Numerics.BigInteger(5510345876566494224L),

new System.Numerics.BigInteger(1828523681654494380L),

new System.Numerics.BigInteger(7289917384465225789L),

},
},
            new BigIntegernumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7581160810966659010L),

new System.Numerics.BigInteger(2732400786643343366L),

new System.Numerics.BigInteger(8909811689653353014L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9155890405609257653L),

new System.Numerics.BigInteger(2285778335586851145L),

new System.Numerics.BigInteger(1277809301367237892L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7440582540213213564L),

new System.Numerics.BigInteger(1043189670801042770L),

new System.Numerics.BigInteger(3656477852431335369L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6106714444037037702L),

new System.Numerics.BigInteger(8850056458604519511L),

new System.Numerics.BigInteger(6123997265701851569L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2590765836867854126L),

new System.Numerics.BigInteger(931528253787905481L),

new System.Numerics.BigInteger(6449162185825772755L),

},
},
            new BigIntegernumericArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2418462941263570564L),

new System.Numerics.BigInteger(2716151837050260732L),

new System.Numerics.BigInteger(309143027702315192L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7469818556765169324L),

new System.Numerics.BigInteger(4716866539352809366L),

new System.Numerics.BigInteger(8694946453141525372L),

new System.Numerics.BigInteger(7886390680323439135L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4814033563009214333L),

new System.Numerics.BigInteger(6357069038987839496L),

new System.Numerics.BigInteger(6445993961333498354L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8797744784224975656L),

new System.Numerics.BigInteger(3446034346376809327L),

new System.Numerics.BigInteger(3836020653337304425L),

},
},
            new BigIntegernumericArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1372869579525511221L),

new System.Numerics.BigInteger(3116408684771498915L),

new System.Numerics.BigInteger(3781762701323975783L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4131595808688771388L),

new System.Numerics.BigInteger(871190681719771955L),

new System.Numerics.BigInteger(4445063374334016821L),

},
},
            new BigIntegernumericArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6918237500557539510L),

new System.Numerics.BigInteger(5552482157873239673L),

new System.Numerics.BigInteger(9153301317764811791L),

new System.Numerics.BigInteger(5023386512593478205L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2891868741488370211L),

new System.Numerics.BigInteger(2933085886496329118L),

new System.Numerics.BigInteger(9063466292436416459L),

new System.Numerics.BigInteger(2241284401334706407L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7062653849135201814L),

new System.Numerics.BigInteger(8840298566898688136L),

new System.Numerics.BigInteger(6426339952055378553L),

},
},
            new BigIntegernumericArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7482189203633239624L),

new System.Numerics.BigInteger(8460236392313265866L),

new System.Numerics.BigInteger(3703765009625604866L),

new System.Numerics.BigInteger(2470016723043265185L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3316450463220046134L),

new System.Numerics.BigInteger(9214191177692387744L),

new System.Numerics.BigInteger(5434899938540990453L),

new System.Numerics.BigInteger(730868370406323608L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8260962176364425832L),

new System.Numerics.BigInteger(2822379139583711984L),

new System.Numerics.BigInteger(4041194083372292965L),

new System.Numerics.BigInteger(9052252185249909614L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7065145616772218305L),

new System.Numerics.BigInteger(3493153294929765334L),

new System.Numerics.BigInteger(4151536476390672024L),

new System.Numerics.BigInteger(2662726351251766182L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4848805678190276790L),

new System.Numerics.BigInteger(2678172017719165561L),

new System.Numerics.BigInteger(6303956344243717299L),

new System.Numerics.BigInteger(8708794421457507142L),

},
},
            new BigIntegernumericArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6890279415634050841L),

new System.Numerics.BigInteger(1152195093574968978L),

new System.Numerics.BigInteger(6722353405275313223L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4370780837353614652L),

new System.Numerics.BigInteger(8774301985648078471L),

new System.Numerics.BigInteger(4008639200039733010L),

new System.Numerics.BigInteger(8165974739356215306L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8345119443801473150L),

new System.Numerics.BigInteger(8611191568808458513L),

new System.Numerics.BigInteger(2140720327261402891L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1309944378531268560L),

new System.Numerics.BigInteger(9051014172627862761L),

new System.Numerics.BigInteger(1212824296782592601L),

},
},
            new BigIntegernumericArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3203183286636054129L),

new System.Numerics.BigInteger(589567131574138970L),

new System.Numerics.BigInteger(1155499178665752509L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1859052318817031701L),

new System.Numerics.BigInteger(5142453052610626380L),

new System.Numerics.BigInteger(9163387612434930191L),

},
},
            new BigIntegernumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2395868879469409310L),

new System.Numerics.BigInteger(8564140814073392848L),

new System.Numerics.BigInteger(1176589734874517493L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4119997451649639803L),

new System.Numerics.BigInteger(8259038977892884344L),

new System.Numerics.BigInteger(7371392440319600658L),

new System.Numerics.BigInteger(749968951780694245L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6731881133265412506L),

new System.Numerics.BigInteger(5542876733968633362L),

new System.Numerics.BigInteger(3911957248451258671L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4850349494487992567L),

new System.Numerics.BigInteger(7936399464062928375L),

new System.Numerics.BigInteger(735608711302567585L),

new System.Numerics.BigInteger(4754314167675903391L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7773358024564606209L),

new System.Numerics.BigInteger(8898723766329485864L),

new System.Numerics.BigInteger(6197234870563014802L),

new System.Numerics.BigInteger(4062135851915774439L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4765537020876436927L),

new System.Numerics.BigInteger(4095115186944526169L),

new System.Numerics.BigInteger(2040123615638691274L),

new System.Numerics.BigInteger(792087569197221729L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4888267045344405578L),

new System.Numerics.BigInteger(2031005293113782477L),

new System.Numerics.BigInteger(1261626097202590818L),

new System.Numerics.BigInteger(6810317939645736600L),

},
},
            new BigIntegernumericArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7509512599154955981L),

new System.Numerics.BigInteger(7704121809860756674L),

new System.Numerics.BigInteger(4441067436889754470L),

new System.Numerics.BigInteger(6630946541785753075L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8070986350306551029L),

new System.Numerics.BigInteger(3186284317748915952L),

new System.Numerics.BigInteger(4985901641476214557L),

},
},
            new BigIntegernumericArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608317302055487529L),

new System.Numerics.BigInteger(1175853894450225923L),

new System.Numerics.BigInteger(1962604933558179565L),

new System.Numerics.BigInteger(4602245015082412760L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6554622798399920895L),

new System.Numerics.BigInteger(7374456792267213235L),

new System.Numerics.BigInteger(2503774687734651817L),

new System.Numerics.BigInteger(5321819925913290080L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1415794422614986820L),

new System.Numerics.BigInteger(6555083032897429131L),

new System.Numerics.BigInteger(7343279532808295076L),

},
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 107, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 65, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 52, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[29], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 30, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 107, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[29], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 103, 47))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 81, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
BigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
BigIntegernumericArray2M.AssertModel(models[0],_testData[7], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((IBigIntegerListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((IBigIntegerListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(BigIntegernumericArray2MI),
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
            queryMapType: typeof(BigIntegernumericArray2M),
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

